using Microsoft.AspNetCore.Authentication;
using Models.ViewModels.Identity;
using System.Threading.Tasks;

namespace Authentication
{
    public interface ITokenService 
    {
        Task<AuthenticationResult> Authenticate(string username, string password);
        TokenInfo ValidateToken(string token);
    }
}