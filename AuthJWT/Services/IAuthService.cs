using AuthJWT.Models;

namespace AuthJWT.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(LogInModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    
    }
}
