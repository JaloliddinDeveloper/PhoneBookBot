using PhoneBookBot.Models;

namespace PhoneBookBot.Brokers
{
    internal partial interface IStorageBroker
    {
        ValueTask<Contact> InsertContactAsync(Contact contact);
        IQueryable<Contact> SelectAllContacts();
        ValueTask<Contact> UpdateContactAsync(Contact contact);
        ValueTask<Contact> DeleteContactAsync(Contact contact);
    }
}
