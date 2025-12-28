namespace RestaurantManagementSystem
{
    internal class Table
    {
        public int Id { get; set; }
        public int TableNumber { get; set; } 
        public int Capacity { get; set; }
        public required string Location { get; set; }
        public TableStatus Status { get; set; }
    }
}
