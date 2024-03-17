namespace PhoneBookBot.Models
{
    internal class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public Status Status { get; set; }
        public string HelperName { get; set; }
    }
}
