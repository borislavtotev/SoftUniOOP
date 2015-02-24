using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _15_LINQtoExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Dropbox\OOP\FuncitonalProgramming\6. Functional-Programming-Homework\Students-data.txt");
            List<Student> students = new List<Student>();

            foreach (var line in lines)
            {
                string[] inputs = line.Split('\t');
                //Console.WriteLine(line);
                int num1;

                if (int.TryParse(inputs[0], out num1))
                {
                    Student currentStudent = new Student(Convert.ToInt32(inputs[0]), inputs[1], inputs[2], inputs[3], inputs[4],
                        inputs[5], Convert.ToInt32(inputs[6]), Convert.ToInt32(inputs[7]), Convert.ToInt32(inputs[8]),
                        Convert.ToDouble(inputs[9]), Convert.ToInt32(inputs[10]), Convert.ToDouble(inputs[11]));
                    currentStudent.CalculateResult();
                    students.Add(currentStudent);                    
                }
            }

            var onlineStudents = 
                from student in students
                where student.StudentType == "Online"
                orderby student.result descending
                select student;

            // Set the file name and get the output directory
            var fileName = "OnlineStudents.xlsx";
            var outputDir = @"D:\Dropbox\OOP\FuncitonalProgramming\15_LINQtoExcel\";
            string filePath = outputDir + fileName;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            var file = new FileInfo(filePath);

            // Create the package and make sure you wrap it in a using statement
            using (var package = new ExcelPackage(file))
            {
                // add a new worksheet to the empty workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Online Students");
                worksheet.Cells[1, 1].Value = "SoftUni OOP Course Results";
                worksheet.Cells[1, 1, 1, 13].Merge = true;
                worksheet.Cells[1, 1, 1, 13].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[1, 1, 1, 13].Style.Font.Bold = true;
                worksheet.Cells[2, 1].Value = "ID";
                worksheet.Cells[2, 2].Value = "First name";
                worksheet.Cells[2, 3].Value = "Last name";
                worksheet.Cells[2, 4].Value = "Email";
                worksheet.Cells[2, 5].Value = "Gender";
                worksheet.Cells[2, 6].Value = "Student type";
                worksheet.Cells[2, 7].Value = "Exam result";
                worksheet.Cells[2, 8].Value = "Homework sent";
                worksheet.Cells[2, 9].Value = "Homework evaluated";
                worksheet.Cells[2, 10].Value = "Teamwork";
                worksheet.Cells[2, 11].Value = "Attendances";
                worksheet.Cells[2, 12].Value = "Bonus";
                worksheet.Cells[2, 13].Value = "Result";

                int row = 3;
                foreach (var student in onlineStudents)
                {
                    worksheet.Cells[row, 1].Value = student.ID;
                    worksheet.Cells[row, 2].Value = student.FirstName;
                    worksheet.Cells[row, 3].Value = student.LastName;
                    worksheet.Cells[row, 4].Value = student.Email;
                    worksheet.Cells[row, 5].Value = student.Gender;
                    worksheet.Cells[row, 6].Value = student.StudentType;
                    worksheet.Cells[row, 7].Value = student.ExamResult;
                    worksheet.Cells[row, 8].Value = student.HomeworkSent;
                    worksheet.Cells[row, 9].Value = student.HomeworkEvaluated;
                    worksheet.Cells[row, 10].Value = student.TeamworkScope;
                    worksheet.Cells[row, 11].Value = student.AttendancesCount;
                    worksheet.Cells[row, 12].Value = student.Bonus;
                    worksheet.Cells[row, 13].Value = student.result;
                    row++;
                }

                for (int i = 1; i <= 13; i++)
                {
                    worksheet.Column(i).AutoFit();                    
                }

                package.Save();
            }
        }
    }
}
