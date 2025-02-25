//using System;
//using System.IO;
//using System.Collections.Generic;

//class CSVMerge
//{
//    static void Main(string[] args)
//    {
//        string file1 = "students1.csv";
//        string file2 = "students2.csv";
//        string outputFile = "merged_students.csv";

//        Dictionary<int, string[]> studentData = new Dictionary<int, string[]>();

//        try
//        {
//            using (StreamReader sr = new StreamReader(file1))
//            {
//                string line = sr.ReadLine();

//                while ((line = sr.ReadLine()) != null)
//                {
//                    string[] data = line.Split(',');
//                    int id = int.Parse(data[0]);
//                    studentData[id] = new string[] { data[1], data[2] };
//                }
//            }

//            using (StreamReader sr = new StreamReader(file2))
//            {
//                string line = sr.ReadLine();

//                while ((line = sr.ReadLine()) != null)
//                {
//                    string[] data = line.Split(',');
//                    int id = int.Parse(data[0]);

//                    if (studentData.ContainsKey(id))
//                    {
//                        studentData[id] = new string[] { studentData[id][0], studentData[id][1], data[1], data[2] };
//                    }
//                }
//            }

//            using (StreamWriter sw = new StreamWriter(outputFile))
//            {
//                sw.WriteLine("ID,Name,Age,Marks,Grade");
//                foreach (var entry in studentData)
//                {
//                    sw.WriteLine($"{entry.Key},{string.Join(",", entry.Value)}");
//                }
//            }

//            Console.WriteLine("CSV Files Merged Successfully! Output: merged_students.csv");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}
