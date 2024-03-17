using PhoneBookBot.Brokers;
using PhoneBookBot.Models;

namespace PhoneBookBot.Services
{
    internal class UserService:IUserService
    {
        private readonly IStorageBroker storageBroker;

        public UserService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async  ValueTask<User> AddUserAsync(User user)
        {
            return await this.storageBroker.InsertUserAsync(user);
        }
        public  IQueryable<User> RetrieveAllUsersAsync()
        {
            return this.storageBroker.SelectAllUsersAsync();
        }
        
        public async ValueTask<User> ModifyUserAsync(User user)
        {
           return await this.storageBroker.UpdateUserAsync(user);
        }

        public async ValueTask<User> RemoveUserAsync(User user)
        {
           return await this.storageBroker.DeleteUserAsync(user);
        }

    }
}
