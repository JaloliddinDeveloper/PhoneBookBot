using PhoneBookBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookBot.Brokers
{
    internal partial interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User User);
        IQueryable<User> SelectAllUsersAsync();
        ValueTask<User> UpdateUserAsync(User User);
        ValueTask<User> DeleteUserAsync(User User);
    }
}
