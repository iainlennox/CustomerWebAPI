namespace CustomerWebAPI.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    public DateTime? CreatedDate { get; set; } = DateTime.Now; // Set a valid default

    }
}
