using System;
using System.Text;
using DepsWebApp.Models;
using DepsWebApp.Storages;

namespace DepsWebApp.Services.CustomAuthentication
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class CustomAuthenticationService : ICustomAuthenticationService
    {
        private readonly IUsersStorage _storage;

        public CustomAuthenticationService(IUsersStorage storage)
        {
            _storage = storage;
        }

        public string Register(RegistrationModel registrationModel)
        {
            if (string.IsNullOrWhiteSpace(registrationModel.Login) || string.IsNullOrWhiteSpace(registrationModel.Password))
            {
                return null;
            }

            string plainCredentials = $"{registrationModel.Login}:{registrationModel.Password}";
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainCredentials);
            string authToken = Convert.ToBase64String(plainTextBytes);
            
            User authDetails = new User(registrationModel.Login, registrationModel.Password);
            if (_storage.Save(authDetails))
            {
                return authToken;
            }
            else
            {
                return null;
            }

        }

        public bool Authenticate(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            
            User authenticationDetails = _storage.GetUser(login, password);

            return authenticationDetails != null;
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}