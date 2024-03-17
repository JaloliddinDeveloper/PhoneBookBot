using Microsoft.EntityFrameworkCore;
using PhoneBookBot.Models;

namespace PhoneBookBot.Brokers
{
    internal partial class StorageBroker
    {
        public DbSet<Contact> Contacts { get; set; }
        public async ValueTask<Contact> InsertContactAsync(Contact contact)
        {
            return await InsertAsync(contact);
        }
        public  IQueryable<Contact> SelectAllContacts()
        { 
            return SelectAll<Contact>();
        }
        public async ValueTask<Contact> UpdateContactAsync(Contact contact)
        {
            return await UpdateAsync(contact);
        }
        public async ValueTask<Contact> DeleteContactAsync(Contact contact)
        {
            return await DeleteAsync(contact);
        }
    }
}
