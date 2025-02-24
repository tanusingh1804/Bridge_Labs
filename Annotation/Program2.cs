using System;

class LegacyAPI
{
   [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.")]
   public void OldFeature()
   {
       Console.WriteLine("This is an old feature.");
   }

   public void NewFeature()
   {
       Console.WriteLine("This is the new and improved feature.");
   }
}

class Program2
{
   static void Main(string[] args)
   {
       LegacyAPI api = new LegacyAPI();
       api.OldFeature();
       api.NewFeature();
   }
}
