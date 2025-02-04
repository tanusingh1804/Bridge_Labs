
using System;

class Patient
{
   public static string HospitalName = "Army Hospital";
   private static int totalPatients = 0;

   public readonly int PatientID;
   public string Name { get; set; }
   public int Age { get; set; }
   public string Ailment { get; set; }

   public Patient(string name, int age, string ailment)
   {
       this.PatientID = ++totalPatients; // Auto-increment PatientID
       this.Name = name;
       this.Age = age;
       this.Ailment = ailment;
   }

   public static void GetTotalPatients()
   {
       Console.WriteLine("Total patients admitted: " + totalPatients);
   }

   public void DisplayDetails(object obj)
   {
       if (obj is Patient patient)
       {
           Console.WriteLine("\nPatient Details:");
           Console.WriteLine("Patient ID    : " + patient.PatientID);
           Console.WriteLine("Name          : " + patient.Name);
           Console.WriteLine("Age           : " + patient.Age);
           Console.WriteLine("Ailment       : " + patient.Ailment);
           Console.WriteLine("Hospital Name : " + HospitalName);
       }
       else
       {
           Console.WriteLine("Invalid object. Cannot display patient details.");
       }
   }
}

class Program
{
   static void Main(string[] args)
   {
       Console.Write("Enter number of patients to admit: ");
       int numPatients = Convert.ToInt32(Console.ReadLine());

       Patient[] patients = new Patient[numPatients]; // Array without Generics

       for (int i = 0; i < numPatients; i++)
       {
           Console.WriteLine("\nEnter details for Patient " + (i + 1) + ":");

           Console.Write("Enter Name: ");
           string name = Console.ReadLine();

           Console.Write("Enter Age: ");
           int age = Convert.ToInt32(Console.ReadLine());

           Console.Write("Enter Ailment: ");
           string ailment = Console.ReadLine();

           patients[i] = new Patient(name, age, ailment);
       }

       Console.WriteLine("\nAll Patient Details:");
       for (int i = 0; i < numPatients; i++)
       {
           patients[i].DisplayDetails(patients[i]);
       }

       Patient.GetTotalPatients();
   }
}
