using System;

public class RequestNode
{
    public int RequestID;
    public string CustomerName;
    public string IssueDescription;
    public RequestNode Next;

    public RequestNode(int requestID, string customerName, string issueDescription)
    {
        RequestID = requestID;
        CustomerName = customerName;
        IssueDescription = issueDescription;
        Next = null;
    }
}

public class RequestQueue
{
    private RequestNode front;
    private RequestNode rear;

    // Add a request to the queue
    public void Enqueue(int requestID, string customerName, string issueDescription)
    {
        RequestNode newRequest = new RequestNode(requestID, customerName, issueDescription);
        if (rear == null)
        {
            front = rear = newRequest;
        }
        else
        {
            rear.Next = newRequest;
            rear = newRequest;
        }
    }

    // Remove a request from the queue (FIFO)
    public void Dequeue()
    {
        if (front == null)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.WriteLine($"Processing request ID: {front.RequestID}, Customer: {front.CustomerName}, Issue: {front.IssueDescription}");
        front = front.Next;
        if (front == null) rear = null;  // If the queue is empty
    }

    // Display all requests
    public void DisplayQueue()
    {
        if (front == null)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        RequestNode current = front;
        while (current != null)
        {
            Console.WriteLine($"Request ID: {current.RequestID}, Customer: {current.CustomerName}, Issue: {current.IssueDescription}");
            current = current.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        RequestQueue requestQueue = new RequestQueue();
        requestQueue.Enqueue(1, "Alice", "Account Issue");
        requestQueue.Enqueue(2, "Bob", "Technical Support");
        requestQueue.Enqueue(3, "Charlie", "Billing Query");

        Console.WriteLine("Customer Requests:");
        requestQueue.DisplayQueue();

        requestQueue.Dequeue();
        Console.WriteLine("\nAfter Processing One Request:");
        requestQueue.DisplayQueue();
    }
}
