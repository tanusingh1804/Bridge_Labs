using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class CsvEncryption
{
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("12345678901234567890123456789012"); // 32-byte Key
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("1234567890123456"); // 16-byte IV

    static void Main(string[] args)
    {
        string csvFilePath = "employees_encrypted.csv";
        string decryptedCsvFile = "employees_decrypted.csv";

        
        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "Aman", Department = "IT", Salary = "50000", Email = "aman@example.com" },
            new Employee { ID = 2, Name = "Neha", Department = "HR", Salary = "45000", Email = "neha@example.com" },
            new Employee { ID = 3, Name = "Rahul", Department = "Finance", Salary = "60000", Email = "rahul@example.com" }
        };

  
        EncryptAndWriteToCsv(employees, csvFilePath);
        Console.WriteLine(" Encrypted data written to CSV: employees_encrypted.csv");

        ReadAndDecryptCsv(csvFilePath, decryptedCsvFile);
        Console.WriteLine(" Decrypted data written to CSV: employees_decrypted.csv");
    }

    static void EncryptAndWriteToCsv(List<Employee> employees, string filePath)
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.WriteLine("ID,Name,Department,Salary,Email");

            foreach (var emp in employees)
            {
                string encryptedSalary = Encrypt(emp.Salary);
                string encryptedEmail = Encrypt(emp.Email);

                sw.WriteLine($"{emp.ID},{emp.Name},{emp.Department},{encryptedSalary},{encryptedEmail}");
            }
        }
    }

    static void ReadAndDecryptCsv(string encryptedFilePath, string decryptedFilePath)
    {
        var employees = new List<Employee>();
        string[] lines = File.ReadAllLines(encryptedFilePath);

        using (StreamWriter sw = new StreamWriter(decryptedFilePath))
        {
            sw.WriteLine(lines[0]); 

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                employees.Add(new Employee
                {
                    ID = int.Parse(data[0]),
                    Name = data[1],
                    Department = data[2],
                    Salary = Decrypt(data[3]),
                    Email = Decrypt(data[4])
                });

                sw.WriteLine($"{data[0]},{data[1]},{data[2]},{Decrypt(data[3])},{Decrypt(data[4])}");
            }
        }
    }

    static string Encrypt(string plainText)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;

            using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                return Convert.ToBase64String(encryptedBytes);
            }
        }
    }

    static string Decrypt(string cipherText)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;

            using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
            {
                byte[] encryptedBytes = Convert.FromBase64String(cipherText);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Salary { get; set; }
    public string Email { get; set; }
}
