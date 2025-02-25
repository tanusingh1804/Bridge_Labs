//using System;
//using System.IO;

//class CSVModify
//{
//    static void Main(string[] args)
//    {
//        string inputFilePath = "employees.csv";  
//        string outputFilePath = "updated_employees.csv";

//        try
//        {
//            using (StreamReader sr = new StreamReader(inputFilePath))
//            using (StreamWriter sw = new StreamWriter(outputFilePath))
//            {
//                string line = sr.ReadLine();
//                sw.WriteLine(line); 

//                while ((line = sr.ReadLine()) != null)
//                {
//                    string[] data = line.Split(',');

//                    if (data[2] == "IT") 
//                    {
//                        double salary = double.Parse(data[3]); 
//                        salary *= 1.10; 
//                        data[3] = salary.ToString("F2"); 
//                    }

//                    sw.WriteLine(string.Join(",", data)); 
//                }
//            }

//            Console.WriteLine("Salaries updated and saved to 'updated_employees.csv'.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}
