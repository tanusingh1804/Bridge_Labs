using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
   public string Name { get; }

   public JsonFieldAttribute(string name)
   {
       Name = name;
   }
}

class User
{
   [JsonField("user_name")]
   public string Username { get; set; }

   [JsonField("user_age")]
   public int Age { get; set; }

   [JsonField("email_address")]
   public string Email { get; set; }

   public User(string username, int age, string email)
   {
       Username = username;
       Age = age;
       Email = email;
   }
}

class Program11
{
   static void Main(string[] args)
   {
       User user = new User("Rahul", 25, "rahul@example.com");
       string jsonString = SerializeToJson(user);
       Console.WriteLine(jsonString);
   }

   static string SerializeToJson(object obj)
   {
       Dictionary<string, object> jsonDict = new Dictionary<string, object>();
       Type objType = obj.GetType();

       foreach (PropertyInfo prop in objType.GetProperties())
       {
           JsonFieldAttribute? attr = prop.GetCustomAttribute<JsonFieldAttribute>();
           if (attr != null)
           {
               object? value = prop.GetValue(obj);
               jsonDict[attr.Name] = value ?? "null"; 
           }
       }

       return FormatJson(jsonDict);
   }

   static string FormatJson(Dictionary<string, object> jsonDict)
   {
       StringBuilder sb = new StringBuilder();
       sb.AppendLine("{");
       foreach (var kvp in jsonDict)
       {
           sb.AppendLine($"  \"{kvp.Key}\": \"{kvp.Value}\",");
       }
       if (sb.Length > 2) sb.Length -= 3; 
       sb.AppendLine("\n}");
       return sb.ToString();
   }
}
