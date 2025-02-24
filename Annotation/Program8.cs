using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;


[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class PerformanceTester
{
   [LogExecutionTime]
   public void FastMethod()
   {
       Thread.Sleep(100); 
       Console.WriteLine("Fast method executed.");
   }

   [LogExecutionTime]
   public void SlowMethod()
   {
       Thread.Sleep(500); 
       Console.WriteLine("Slow method executed.");
   }
}

class Program8
{
   static void Main(string[] args)
   {
       PerformanceTester tester = new PerformanceTester();
       MeasureExecutionTime(tester, "FastMethod");
       MeasureExecutionTime(tester, "SlowMethod");
   }

   static void MeasureExecutionTime(object obj, string methodName)
   {
       MethodInfo method = obj.GetType().GetMethod(methodName);
       if (method != null && method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
       {
           Stopwatch stopwatch = Stopwatch.StartNew();
           method.Invoke(obj, null);
           stopwatch.Stop();
           Console.WriteLine($"Execution time of {methodName}: {stopwatch.ElapsedMilliseconds} ms\n");
       }
   }
}
