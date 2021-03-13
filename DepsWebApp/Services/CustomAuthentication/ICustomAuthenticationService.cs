using DepsWebApp.Models;

namespace DepsWebApp.Services.CustomAuthentication
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public interface ICustomAuthenticationService
    {
        string Register(RegistrationModel registrationModel);
        bool Authenticate(string login, string password);
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}