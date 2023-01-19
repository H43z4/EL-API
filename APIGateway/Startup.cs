using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using RepositoryLayer;
using UserManagement;
using Logging;
using Setup;
using PermitIssuance;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Authentication.JwtStatelessToken;
using Authentication;
using APIGateway.Middleware;
using Wkhtmltopdf.NetCore;
using Stock;
using POS;
using Person;

namespace APIGateway
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //var cultureInfo = new CultureInfo("de-DE");
            //cultureInfo.DateTimeFormat.ShortDatePattern = "yyyyMMdd";
            //CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            //CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            //System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat = new DateTimeFormatInfo() { FullDateTimePattern = "yyyy/MM/dd hh:mm:ss" };

            //services.Configure<SharedLib.Configuration.RabbitMQServerConfig>(Configuration.GetSection("RabbitMQServerConfig"));
            services.Configure<SharedLib.Configuration.RabbitMQServerConfig>(Configuration.GetSection("RabbitMQConfig"));

            //services.Configure<KestrelServerOptions>(options =>
            //{
            //    options.AllowSynchronousIO = true;
            //});

            //// If using IIS:
            //services.Configure<IISServerOptions>(options =>
            //{
            //    options.AllowSynchronousIO = true;
            //});

            services.AddCors();

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(Logging.OnActionExecutedAttribute));
            });

            //services.AddMvc(options =>
            //{
            //    options.Filters.Add(typeof(Logging.InterceptionAttribute));
            //});

            //services.AddMvc(options =>
            //{
            //    options.Filters.Add(typeof(Logging.ErrorHandlingFilter));
            //});

            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")),
            //    contextLifetime: ServiceLifetime.Transient,
            //    optionsLifetime: ServiceLifetime.Scoped);

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);
            services.AddTransient<IAdoNet>(x => new AdoNet(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IDBHelper>(x => new DBHelper(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ITokenService, Authentication.JwtStatelessToken.TokenService>();
            //services.AddTransient<ILog, LogService>();
            services.AddScoped<ILoggingService, LoggingService>();
            services.AddTransient<IUserManagement, UserManagement.UserManagement>();
            #region Vehicle-Registration-Services

         

            services.AddTransient(typeof(ISetupservice<>), typeof(SetupService<>));
           

            #endregion


            #region Reports

            services.AddWkhtmltopdf();

            #endregion

            #region PermitIssuance-Services
            services.AddTransient<IPermitIssuanceService, PermitIssuanceService>();
            services.AddTransient<IInventoryService, InventoryInService>();
            services.AddTransient<IPOSService, POSService>();
            services.AddTransient<IPersonService, PersonService>();

            #endregion
            services.AddStatelessTokenAuthentication();

            services.AddControllers().AddNewtonsoftJson();
            //services.AddControllers().AddNewtonsoftJson(options => { options.SerializerSettings. });

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "APIGateway", Version = "v1" });
            });

            services.Configure<ApiBehaviorOptions>(o =>
            {
                o.InvalidModelStateResponseFactory = actionContext =>
                    new BadRequestObjectResult(ApiResponse.GetValidationErrorResponse(ApiResponseType.VALIDATION_ERROR, actionContext.ModelState.Values.SelectMany(v => v.Errors).Select(x => x.ErrorMessage), null, null, null));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            app.UseMiddleware<HttpLoggingMiddleware>();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            //app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.)
            //app.UseSwaggerUI();
            //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "APIGateway v1"));
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "swagger";
            });

            app.UseStaticFiles();

            app.UseRouting();

            //app.Use(async (context, next) =>
            //{
            //    // Do work that doesn't write to the Response.
            //    await next.Invoke();

            //    var a = context.Response;
            //    // Do logging or other work that doesn't write to the Response.
            //});


            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("/index.html");
            });
          
        }
    }
}
