namespace RestaurantManagementSystem
{
    internal class Waiter
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; } 
        public DateTime HireDate { get; set; }
    }
}
