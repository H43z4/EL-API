using Microsoft.AspNetCore.Http;

namespace APIGateway.Logging.ConfigurationClasses
{
    public class RequestConfiguration
    {
        public static string GetRequestTraceId(HttpContext context) {

            return context.TraceIdentifier;
        }
    }
}
