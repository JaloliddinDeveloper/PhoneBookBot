using PhoneBookBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookBot.Services
{
    internal interface IUserService
    {
        ValueTask<User> AddUserAsync(User user);
        IQueryable<User> RetrieveAllUsersAsync();
        ValueTask<User> ModifyUserAsync(User user);
        ValueTask<User> RemoveUserAsync(User user);
    }
}
