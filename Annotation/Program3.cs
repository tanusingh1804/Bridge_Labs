using System;
using System.Collections;

class Program3
{
   static void Main(string[] args)
   {
#pragma warning disable CS8600 
#pragma warning disable CS8618 

       ArrayList list = new ArrayList(); 
       list.Add(10);
       list.Add("Hello");
       list.Add(3.14);

       foreach (var item in list)
       {
           Console.WriteLine(item);
       }

#pragma warning restore CS8600
#pragma warning restore CS8618
   }
}
