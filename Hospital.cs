//using System;
//using System.Collections.Generic;

//class Hospital
//{
//    public string Name { get; }
//    public List<Doctor> Doctors { get; } = new List<Doctor>();
//    public List<Patient> Patients { get; } = new List<Patient>();

//    public Hospital(string name)
//    {
//        Name = name;
//    }

//    public void AddDoctor(Doctor doctor)
//    {
//        Doctors.Add(doctor);
//    }

//    public void AddPatient(Patient patient)
//    {
//        Patients.Add(patient);
//    }

//    public void ShowDoctors()
//    {
//        Console.WriteLine("\nDoctors in " + Name + ":");
//        foreach (Doctor doctor in Doctors)
//        {
//            Console.WriteLine("Doctor: " + doctor.Name);
//        }
//    }

//    public void ShowPatients()
//    {
//        Console.WriteLine("\nPatients in " + Name + ":");
//        foreach (Patient patient in Patients)
//        {
//            Console.WriteLine("Patient: " + patient.Name);
//        }
//    }
//}

//class Doctor
//{
//    public string Name { get; }

//    public Doctor(string name)
//    {
//        Name = name;
//    }

//    public void Consult(Patient patient)
//    {
//        Console.WriteLine($"{Name} is consulting {patient.Name}");
//    }
//}

//class Patient
//{
//    public string Name { get; }

//    public Patient(string name)
//    {
//        Name = name;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter hospital name: ");
//        string hospitalName = Console.ReadLine();
//        Hospital hospital = new Hospital(hospitalName);

//        Console.Write($"Enter number of doctors in {hospitalName}: ");
//        int doctorCount = int.Parse(Console.ReadLine());

//        for (int i = 0; i < doctorCount; i++)
//        {
//            Console.Write("Enter doctor name: ");
//            string doctorName = Console.ReadLine();
//            Doctor doctor = new Doctor(doctorName);
//            hospital.AddDoctor(doctor);
//        }

//        Console.Write($"Enter number of patients in {hospitalName}: ");
//        int patientCount = int.Parse(Console.ReadLine());

//        for (int i = 0; i < patientCount; i++)
//        {
//            Console.Write("Enter patient name: ");
//            string patientName = Console.ReadLine();
//            Patient patient = new Patient(patientName);
//            hospital.AddPatient(patient);
//        }

//        hospital.ShowDoctors();
//        hospital.ShowPatients();

//        Console.WriteLine("\nConsultation Sessions:");
//        foreach (Doctor doctor in hospital.Doctors)
//        {
//            foreach (Patient patient in hospital.Patients)
//            {
//                doctor.Consult(patient);
//            }
//        }
//    }
//}
