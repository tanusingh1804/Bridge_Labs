using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
   public string Task { get; }
   public string AssignedTo { get; }
   public string Priority { get; }

   public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
   {
       Task = task;
       AssignedTo = assignedTo;
       Priority = priority;
   }
}

class Project
{
   [Todo("Implement user authentication", "Rahul", "HIGH")]
   public void LoginFeature()
   {
       Console.WriteLine("Login feature is under development.");
   }

   [Todo("Optimize database queries", "Priya")]
   public void OptimizeDatabase()
   {
       Console.WriteLine("Database optimization is pending.");
   }

   [Todo("Improve UI design", "Amit", "LOW")]
   [Todo("Fix layout issues", "Sneha", "HIGH")]
   public void ImproveUI()
   {
       Console.WriteLine("UI improvements are planned.");
   }
}

class Program7
{
   static void Main(string[] args)
   {
       Project project = new Project();
       project.LoginFeature();
       project.OptimizeDatabase();
       project.ImproveUI();

       MethodInfo[] methods = typeof(Project).GetMethods();
       foreach (MethodInfo method in methods)
       {
           object[] attributes = method.GetCustomAttributes(typeof(TodoAttribute), false);
           foreach (TodoAttribute attr in attributes)
           {
               Console.WriteLine($"Method: {method.Name}, Task: {attr.Task}, Assigned To: {attr.AssignedTo}, Priority: {attr.Priority}");
           }
       }
   }
}

