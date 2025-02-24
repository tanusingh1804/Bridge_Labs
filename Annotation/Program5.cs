using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
   public string Description { get; }

   public BugReportAttribute(string description)
   {
       Description = description;
   }
}

class Software
{
   [BugReport("Null reference exception occurs in edge cases.")]
   [BugReport("Performance issue when processing large data sets.")]
   public void ProcessData()
   {
       Console.WriteLine("Processing data...");
   }
}

class Program5
{
   static void Main(string[] args)
   {
       Software software = new Software();
       software.ProcessData();

       MethodInfo methodInfo = typeof(Software).GetMethod("ProcessData");
       if (methodInfo != null)
       {
           object[] attributes = methodInfo.GetCustomAttributes(typeof(BugReportAttribute), false);
           foreach (BugReportAttribute attr in attributes)
           {
               Console.WriteLine($"Bug Report: {attr.Description}");
           }
       }
   }
}
