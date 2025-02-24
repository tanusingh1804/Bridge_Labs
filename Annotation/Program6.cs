using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
   public string Level { get; }

   public ImportantMethodAttribute(string level = "HIGH")
   {
       Level = level;
   }
}

class TaskManager
{
   [ImportantMethod("HIGH")]
   public void CriticalTask()
   {
       Console.WriteLine("Executing critical task...");
   }

   [ImportantMethod("MEDIUM")]
   public void RoutineTask()
   {
       Console.WriteLine("Executing routine task...");
   }

   public void NormalTask()
   {
       Console.WriteLine("Executing normal task...");
   }
}

class Program6
{
   static void Main(string[] args)
   {
       TaskManager taskManager = new TaskManager();
       taskManager.CriticalTask();
       taskManager.RoutineTask();
       taskManager.NormalTask();

       MethodInfo[] methods = typeof(TaskManager).GetMethods();
       foreach (MethodInfo method in methods)
       {
           object[] attributes = method.GetCustomAttributes(typeof(ImportantMethodAttribute), false);
           foreach (ImportantMethodAttribute attr in attributes)
           {
               Console.WriteLine($"Method: {method.Name}, Importance Level: {attr.Level}");
           }
       }
   }
}

