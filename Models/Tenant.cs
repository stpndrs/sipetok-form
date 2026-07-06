namespace sipetok_form.Models
{
    internal class Tenant
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public bool IsValid { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
