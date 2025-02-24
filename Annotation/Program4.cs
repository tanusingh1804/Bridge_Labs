using System;
using System.Reflection;


[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
   public int Priority { get; }
   public string AssignedTo { get; }

   public TaskInfoAttribute(int priority, string assignedTo)
   {
       Priority = priority;
       AssignedTo = assignedTo;
   }
}

class TaskManager
{
   [TaskInfo(1, "Rahul")]
   public void CompleteTask()
   {
       Console.WriteLine("Task completed.");
   }
}

class Program4
{
   static void Main(string[] args)
   {
       TaskManager taskManager = new TaskManager();
       taskManager.CompleteTask();

       MethodInfo methodInfo = typeof(TaskManager).GetMethod("CompleteTask");
       if (methodInfo != null)
       {
           object[] attributes = methodInfo.GetCustomAttributes(typeof(TaskInfoAttribute), false);
           foreach (TaskInfoAttribute attr in attributes)
           {
               Console.WriteLine($"Priority: {attr.Priority}, Assigned To: {attr.AssignedTo}");
           }
       }
   }
}
