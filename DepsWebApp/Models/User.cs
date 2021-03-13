using System;

namespace DepsWebApp.Models
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class User
    {
        public  string Login { get; set; }
        public  string Password { get; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}