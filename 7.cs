using System;
using System.Collections.Generic;

// Abstract Class
public abstract class Patient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract double CalculateBill();
    public void GetPatientDetails()
    {
        Console.WriteLine("Patient: " + Name + ", Age: " + Age);
    }
}

// Subclasses
public class InPatient : Patient
{
    public override double CalculateBill()
    {
        return 1000;  // Example bill for in-patient
    }
}

public class OutPatient : Patient
{
    public override double CalculateBill()
    {
        return 200;  // Example bill for out-patient
    }
}

// Interface
public interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

// Main Program
public class Program
{
    public static void Main()
    {
        List<Patient> patients = new List<Patient>
        {
            new InPatient { PatientId = 1, Name = "John", Age = 40 },
            new OutPatient { PatientId = 2, Name = "Alice", Age = 30 }
        };

        foreach (var patient in patients)
        {
            patient.GetPatientDetails();
            double bill = patient.CalculateBill();
            Console.WriteLine("Bill: " + bill);
        }
    }
}
