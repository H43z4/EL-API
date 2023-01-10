using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models.DatabaseModels.Authentication;
using Models.ViewModels.Identity;
using Models.ViewModels.PermitIssuance.Setup;
using Models.ViewModels.VehicleRegistration.Core;
using Models.DatabaseModels.PermitIssuance.Setup;
using SharedLib.Common;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UserManagement;

namespace Authentication.JwtStatelessToken
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly IUserManagement userManagement; 
        private readonly string _secret;
        private readonly string _expDate;


        public TokenService(IConfiguration configuration, IUserManagement userManagement)
        {
            _configuration = configuration;
            this.userManagement = userManagement;

            _secret = configuration.GetSection("JwtConfig").GetSection("secret").Value;
            _expDate = configuration.GetSection("JwtConfig").GetSection("expirationInMinutes").Value;
        }

        public async Task<AuthenticationResult> Authenticate(string username, string password)
        {
            VwUser _user = await this.ValidateCredentials(username, password);

            var authenticationResult = new AuthenticationResult()
            {
                IsAuthenticated = _user is not null,
                User = _user,
            };

            if (_user != null)
            {
                Claim[] claims = new Claim[]
                {
                    new Claim("UserId", _user.UserId.ToString()),
                    new Claim("UserDistrictId", _user.UserDistrictId.ToString()),
                    new Claim("RoleId", string.Join(",", _user.UserRoles.Select(x => x.RoleId))),
                    new Claim(ClaimTypes.NameIdentifier, _user.UserName),
                };

                authenticationResult.Token = this.GenerateJwtSecurityToken(claims);
            }

            return authenticationResult;
        }

        public async Task<AuthenticationResult> AuthenticateUser(string username, string password)
        {
            VwEPRSUser _user = await this.ValidateUserCredentials(username, password);

            var authenticationResult = new AuthenticationResult()
            {
                IsAuthenticated = _user is not null,
                EPRSUser = _user,
            };

            if (_user != null)
            {
                Claim[] claims = new Claim[]
                {
                    new Claim("UserId", _user.UserId.ToString()),
                    //new Claim("UserDistrictId", _user.UserDistrictId.ToString()),
                    new Claim("RoleId", string.Join(",", _user.UserRoles.Select(x => x.RoleId))),
                    new Claim(ClaimTypes.NameIdentifier, _user.UserName),
                };

                authenticationResult.Token = this.GenerateJwtSecurityToken(claims);
            }

            return authenticationResult;
        }

        private async Task<VwUser> ValidateCredentials(string username, string password)
        {
            var ds = await this.userManagement.GetUserInfo(username);

            var vwUser = ds.Tables[0].ToList<VwUser>().FirstOrDefault();

            if (vwUser is null)
            {
                return null;
            }

            var user = new User() 
            { 
                UserId = vwUser.UserId,
                UserName = vwUser.UserName,
                Password = vwUser.Password 
            };

            var passwordHasher = new PasswordHasher<Models.DatabaseModels.Authentication.User>();
            var passwordVerificationResult = passwordHasher.VerifyHashedPassword(user, vwUser.Password, password);

            if (passwordVerificationResult == PasswordVerificationResult.Failed)
            {
                return null;
            }

            var fullName = string.Empty;

            if (vwUser.UserTypeId == 1)
            {
                var person = ds.Tables[1].ToList<VwPerson>().FirstOrDefault();
                fullName = person.PersonName;
            }
            else if (vwUser.UserTypeId == 2)
            {
                var business = ds.Tables[1].ToList<VwBusiness>().FirstOrDefault();
                fullName = business.BusinessName;
            }

            //var roles = this.userManagement.GetUserRoles(user.UserId);

            var roles = ds.Tables[2].ToList<Role>();

            return new VwUser() { UserId = vwUser.UserId, UserName = vwUser.UserName, FullName = fullName, UserDistrictId = vwUser.UserDistrictId, UserRoles = roles };
        }
        private async Task<VwEPRSUser> ValidateUserCredentials(string username, string password)
        {
            var ds = await this.userManagement.GetEPRSUserInfo(username);

            var vwEPRSUser = ds.Tables[0].ToList<VwEPRSUser>().FirstOrDefault();

            if (vwEPRSUser is null)
            {
                return null;
            }

            var user = new EPRSUser()
            {
                UserId = (long)vwEPRSUser.UserId,
                UserName = vwEPRSUser.UserName,
                Password = vwEPRSUser.Password
            };

            var passwordHasher = new PasswordHasher<EPRSUser>();
            var passwordVerificationResult = passwordHasher.VerifyHashedPassword(user, vwEPRSUser.Password, password);

            if (passwordVerificationResult == PasswordVerificationResult.Failed)
            {
                return null;
            }

            var fullName = string.Empty;

            //if (vwEPRSUser.UserTypeId == 1)
            //{
            //    var person = ds.Tables[1].ToList<VwPerson>().FirstOrDefault();
            //    fullName = person.PersonName;
            //}
            //else if (vwUser.UserTypeId == 2)
            //{
            //    var business = ds.Tables[1].ToList<VwBusiness>().FirstOrDefault();
            //    fullName = business.BusinessName;
            //}

            //var roles = this.userManagement.GetUserRoles(user.UserId);

            var roles = ds.Tables[1].ToList<Role>();

            return new VwEPRSUser() { UserId = vwEPRSUser.UserId, UserName = vwEPRSUser.UserName, FullName = vwEPRSUser.FullName, UserRoles = roles };
        }

        private AuthenticationTicket GetAuthenticationTicket(Claim[] claims)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, nameof(TokenAuthenticationHandler));
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            AuthenticationTicket authTicket = new AuthenticationTicket(claimsPrincipal, TokenAuthenticationSchemeOptions.Name);

            return authTicket;
        }

        public string GenerateJwtSecurityToken(Claim[] claims)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(double.Parse(_expDate)),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        //public VwUser ValidateToken(string token)
        //{
        //    try
        //    {
        //        var tokenHandler = new JwtSecurityTokenHandler();
        //        var key = Encoding.ASCII.GetBytes(_secret);

        //        tokenHandler.ValidateToken(token, new TokenValidationParameters
        //        {
        //            IssuerSigningKey = new SymmetricSecurityKey(key),
        //        }, out SecurityToken validatedToken);

        //        var jwtToken = (JwtSecurityToken)validatedToken;
        //        var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "UserId").Value);
        //        var userName = jwtToken.Claims.First(x => x.Type == "UserName").Value;

        //        // attach account to context on successful jwt validation
        //        //context.Items["Account"] = await dataContext.Accounts.FindAsync(accountId);

        //        return new VwUser()
        //        {
        //            UserId = userId,
        //            UserName = userName
        //        };
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public TokenInfo ValidateToken(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_secret);

                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "UserId").Value);
                var userName = jwtToken.Claims.First(x => x.Type == "nameid").Value;
               // var userDistrictId = int.Parse(jwtToken.Claims.First(x => x.Type == "UserDistrictId").Value);
                var userRoleIds = jwtToken.Claims.First(x => x.Type == "RoleId").Value
                                    .Split(",")
                                    .ToList();

                var userRoles = new List<Role>();
                
                userRoleIds.ForEach(x => userRoles.Add(new Role() { RoleId = Convert.ToInt32(x) }));

                return new TokenInfo()
                {
                    Ticket = this.GetAuthenticationTicket(jwtToken.Claims.ToArray()),
                    EPRSUser = new VwEPRSUser()
                    {
                        UserId = userId,
                        UserName = userName,
                        //UserDistrictId = userDistrictId,
                        UserRoles = userRoles
                    }
                };
            }
            catch (Exception)
            {
                //throw;
                return null;
            }
        }
        public TokenInfo ValidateEPRSToken(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_secret);

                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "UserId").Value);
                var userName = jwtToken.Claims.First(x => x.Type == "nameid").Value;
                // var userDistrictId = int.Parse(jwtToken.Claims.First(x => x.Type == "UserDistrictId").Value);
                var userRoleIds = jwtToken.Claims.First(x => x.Type == "RoleId").Value
                                    .Split(",")
                                    .ToList();

                var userRoles = new List<Role>();

                userRoleIds.ForEach(x => userRoles.Add(new Role() { RoleId = Convert.ToInt32(x) }));

                return new TokenInfo()
                {
                    Ticket = this.GetAuthenticationTicket(jwtToken.Claims.ToArray()),
                    User = new VwUser()
                    {
                        UserId = userId,
                        UserName = userName,
                        //UserDistrictId = userDistrictId,
                        UserRoles = userRoles
                    }
                };
            }
            catch (Exception)
            {
                //throw;
                return null;
            }
        }
    }
}
