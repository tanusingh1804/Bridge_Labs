using System;
using System.Reflection;


[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
   public string Role { get; }

   public RoleAllowedAttribute(string role)
   {
       Role = role;
   }
}

class SecureActions
{
   [RoleAllowed("ADMIN")]
   public void AdminTask()
   {
       Console.WriteLine("Admin task executed successfully!");
   }

   [RoleAllowed("USER")]
   public void UserTask()
   {
       Console.WriteLine("User task executed successfully!");
   }
}

class Program10
{
   static void Main(string[] args)
   {
       SecureActions actions = new SecureActions();

       SimulateMethodAccess(actions, "AdminTask", "ADMIN");  
       SimulateMethodAccess(actions, "AdminTask", "USER");   
       SimulateMethodAccess(actions, "UserTask", "USER");    
       SimulateMethodAccess(actions, "UserTask", "GUEST");   
   }

   static void SimulateMethodAccess(object obj, string methodName, string userRole)
   {
       MethodInfo method = obj.GetType().GetMethod(methodName);
       if (method != null)
       {
           RoleAllowedAttribute roleAttr = method.GetCustomAttribute<RoleAllowedAttribute>();
           if (roleAttr != null)
           {
               if (roleAttr.Role == userRole)
               {
                   method.Invoke(obj, null); 
               }
               else
               {
                   Console.WriteLine($"Access Denied! {userRole} cannot execute {methodName}.");
               }
           }
       }
   }
}
