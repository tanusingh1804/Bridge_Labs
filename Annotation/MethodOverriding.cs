using System;

class Animal
{
   public virtual void MakeSound()
   {
       Console.WriteLine("Animal makes a sound.");
   }
}

class Dog : Animal
{
   public override void MakeSound()
   {
       Console.WriteLine("Dog barks: Woof woof!");
   }
}

class MethodOverriding
{
   static void Main(string[] args)
   {

       static void Main(string[] args)
       {
           Dog myDog = new Dog();
           myDog.MakeSound();
       }
   }
}

   
       
       
    