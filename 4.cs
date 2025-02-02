using System;

class Program
{
    static void Main()
    {
        HotelBooking booking1 = new HotelBooking("John", "Deluxe", 3);
        HotelBooking booking2 = new HotelBooking(booking1);

        Console.WriteLine("Booking 1 - Guest: " + booking1.GuestName + ", Room: " + booking1.RoomType + ", Nights: " + booking1.Nights);
        Console.WriteLine("Booking 2 - Guest: " + booking2.GuestName + ", Room: " + booking2.RoomType + ", Nights: " + booking2.Nights);
    }
}

class HotelBooking
{
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }

    public HotelBooking()
    {
        GuestName = "Unknown";
        RoomType = "Standard";
        Nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    public HotelBooking(HotelBooking other)
    {
        GuestName = other.GuestName;
        RoomType = other.RoomType;
        Nights = other.Nights;
    }
}
