using System;

public class PassengerNode
{
    public int TicketNumber;
    public string PassengerName;
    public string SeatNumber;
    public PassengerNode Next;
    public PassengerNode Prev;

    public PassengerNode(int ticketNumber, string passengerName, string seatNumber)
    {
        TicketNumber = ticketNumber;
        PassengerName = passengerName;
        SeatNumber = seatNumber;
    }
}

public class BusReservation
{
    private PassengerNode head;
    private PassengerNode tail;

    // Add a passenger (book a seat)
    public void BookSeat(int ticketNumber, string passengerName, string seatNumber)
    {
        PassengerNode newPassenger = new PassengerNode(ticketNumber, passengerName, seatNumber);
        if (tail == null)
        {
            head = tail = newPassenger;
        }
        else
        {
            tail.Next = newPassenger;
            newPassenger.Prev = tail;
            tail = newPassenger;
        }
    }

    // Cancel a seat (remove passenger)
    public void CancelSeat(int ticketNumber)
    {
        if (head == null)
        {
            Console.WriteLine("No bookings available.");
            return;
        }

        if (head.TicketNumber == ticketNumber)
        {
            head = head.Next;
            if (head != null)
                head.Prev = null;
            Console.WriteLine("Ticket " + ticketNumber + " has been canceled.");
            return;
        }

        PassengerNode current = head;
        while (current != null && current.TicketNumber != ticketNumber)
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Ticket " + ticketNumber + " not found.");
        }
        else
        {
            if (current.Prev != null) current.Prev.Next = current.Next;
            if (current.Next != null) current.Next.Prev = current.Prev;
            Console.WriteLine("Ticket " + ticketNumber + " has been canceled.");
        }
    }

    // Display all passengers
    public void DisplayPassengers()
    {
        if (head == null)
        {
            Console.WriteLine("No passengers booked.");
            return;
        }

        PassengerNode current = head;
        while (current != null)
        {
            Console.WriteLine($"Ticket Number: {current.TicketNumber}, Name: {current.PassengerName}, Seat: {current.SeatNumber}");
            current = current.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BusReservation busReservation = new BusReservation();
        busReservation.BookSeat(101, "Alice", "A1");
        busReservation.BookSeat(102, "Bob", "A2");
        busReservation.BookSeat(103, "Charlie", "A3");

        Console.WriteLine("Current Passengers:");
        busReservation.DisplayPassengers();

        busReservation.CancelSeat(102);
        Console.WriteLine("\nUpdated Passenger List:");
        busReservation.DisplayPassengers();
    }
}
