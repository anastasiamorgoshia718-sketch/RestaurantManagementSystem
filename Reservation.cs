namespace RestaurantManagementSystem
{
    internal class Reservation
    {
        public int Id { get; set; }
        public required string CustomerName { get; set; }
        public required string CustomerPhone { get; set; }
        public required DateTime ReservationDate { get; set; }
        public int NumberOfGuests { get; set; }
        public required string SpecialRequests { get; set; }
        public ReservationStatus Status { get; set; }
    }
}
