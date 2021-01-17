using BusinessLogicLayer.DeductibleStudent;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using static BusinessLogicLayer.DeductibleStudent.DeductibleStudentsReport;

namespace BusinessLogicLayer
{
    public class Excel
    {
        public void CreateReportFile1(IEnumerable<DeductibleStudentsTable> data_table, string filePath)
        {
            FileWorker.DeleteFileIfExists(filePath);
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                excelPackage.Workbook.Worksheets.Add("Deductible students");
                ExcelWorksheet excelWorksheet = excelWorkBook.Worksheets[0];
            }
        }

        public static void CreateReportFile(IEnumerable<DeductibleStudentsTable> data_table, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();
            ExcelWorksheet workSheet = null;
            string[] Headers = { "Surname", "Name", "MiddleName", "Mark", "EducationForms" };
            foreach (var data in data_table)
            {
                int currentRow = 1;
                workSheet = excel.Workbook.Worksheets.Add(data.GroupName);
                workSheet.Cells[currentRow, currentRow].Value = $"{data.GroupName} students to be expelled";
                workSheet.Cells[currentRow, currentRow, currentRow, Headers.Length].Merge = true;
                for (int i = 0; i < Headers.Length; i++)
                {
                    workSheet.Cells[currentRow, ++i].Value = Headers[--i];
                }
                for (int i = ++currentRow, j = 0; j < data.deductibleStudents.Count(); i++, j++)
                {
                    workSheet.Cells[i, 1].Value = data.deductibleStudents.ToList()[j].Surname;
                    workSheet.Cells[i, 2].Value = data.deductibleStudents.ToList()[j].Name;
                    workSheet.Cells[i, 3].Value = data.deductibleStudents.ToList()[j].MiddleName;
                    workSheet.Cells[i, 3].Value = data.deductibleStudents.ToList()[j].EducationForm;
                }
            }

            using FileStream stream = File.Create(filePath);
            stream?.Close();
            File.WriteAllBytes(filePath, excel.GetAsByteArray());

            excel?.Dispose();
            workSheet?.Dispose();
        }
    }
}
