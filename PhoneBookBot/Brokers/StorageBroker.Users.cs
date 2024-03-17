using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PhoneBookBot.Models;

namespace PhoneBookBot.Brokers
{
    internal partial class StorageBroker: IStorageBroker
    {
        public DbSet<User> Users { get; set; }

       public async ValueTask<User> InsertUserAsync(User user)
        {
          return  await InsertAsync(user);
        }
        public IQueryable<User> SelectAllUsersAsync()
        {
         return SelectAll<User>();
        }
        public async ValueTask<User> UpdateUserAsync(User user)
        {
            return await UpdateAsync(user);
        }
        public ValueTask<User> DeleteUserAsync(User user)
        {
            return DeleteAsync(user);
        }
    }
}
