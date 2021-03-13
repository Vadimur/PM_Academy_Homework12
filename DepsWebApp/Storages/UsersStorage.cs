using System.Collections.Concurrent;
using DepsWebApp.Models;

namespace DepsWebApp.Storages
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class UsersStorage : IUsersStorage
    {
        private readonly ConcurrentDictionary<string, User> _registeredUsers = new ConcurrentDictionary<string, User>();
        
        public bool Save(User authenticationDetails)
        {
            return _registeredUsers.TryAdd(authenticationDetails.Login, authenticationDetails);
        }

        public User GetUser(string login, string password)
        {
            bool isSuccess = _registeredUsers.TryGetValue(login, out User registeredUser);
            if (isSuccess && registeredUser.Login.Equals(login) && registeredUser.Password.Equals(password))
            {
                return registeredUser;
            }
            
            return null;
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}