using System.Threading.Tasks;
using DepsWebApp.Models;

namespace DepsWebApp.Storages
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public interface IUsersStorage
    {
        bool Save(User authenticationDetails);
        User GetUser(string login, string password);
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}