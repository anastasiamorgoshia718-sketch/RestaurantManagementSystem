 Console.WriteLine("Hello, World!");

enum MenuCategory
{
    Appetizer,
    MainCourse,
    Dessert,
    Beverage 
}
enum TableStatus
    {
    Available,
    Occupied,
    Reserved
}
enum ReservationStatus
{
    Confirmed,
    Cancelled,
    Completed
}

//Task description:
//რესტორნის მართვის სისტემა:
//    შექმენით შემდეგი კლასები: 
//    MenuItem: Id, Name, Description, Price, Category (enum: Appetizer, MainCourse, Dessert, Beverage), IsAvailable;
//Table: Id, TableNumber(უნიკალური), Capacity, Location, Status (enum: Available, Occupied, Reserved);
//Waiter: Id, FirstName, LastName, PhoneNumber, Email (უნიკალური), HireDate;
//Reservation: Id, CustomerName, CustomerPhone, ReservationDate, NumberOfGuests, SpecialRequests, Status (enum: Confirmed, Cancelled, Completed);
//მიგრაციების შექმნა: Add - Migration InitialCreate Update-Database
