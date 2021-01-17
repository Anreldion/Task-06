using BusinessLogicLayer.DeductibleStudent;
using BusinessLogicLayer.PointsByGroup;
using BusinessLogicLayer.SessionResult;
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
        public static void CreateReportFile(IEnumerable<DeductibleStudentsTable> data_table, string filePath)
        {
            FileWorker.DeleteFileIfExists(filePath);
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;

                
                foreach (var data in data_table)
                {
                    ExcelWorksheet workSheet = excelPackage.Workbook.Worksheets.Add(data.GroupName);

                    workSheet.Row(1).Style.WrapText = true;
                    workSheet.Row(1).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    workSheet.Row(1).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                    double widthTest = 0.71;
                    workSheet.Row(1).Height = (double)30;
                    workSheet.Column(1).Width = (double)4.14 + widthTest;
                    workSheet.Column(2).Width = 14 + widthTest;
                    workSheet.Column(3).Width = 16 + widthTest;
                    workSheet.Column(4).Width = 16 + widthTest;
                    workSheet.Column(5).Width = 10.29 + widthTest;

                    workSheet.Cells["A1:E1"].Style.Font.Size = 10;
                    workSheet.Cells["A1:E1"].Style.Font.Name = "Arial Cyr";
                    workSheet.Cells["A1:E1"].Style.Font.Bold = true;
                    workSheet.Cells["A1:E1"].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Medium);
                    workSheet.Cells["B1:D1"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    workSheet.Cells["B1:D1"].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                    workSheet.Cells[1, 1].Value = "№ ";
                    workSheet.Cells[1, 2].Value = "Surname";
                    workSheet.Cells[1, 3].Value = "Name";
                    workSheet.Cells[1, 4].Value = "Middlename";
                    workSheet.Cells[1, 5].Value = "Education forms";
                    int i = 2;
                    for (int j = 0; j < data.deductibleStudents.Count(); i++, j++)
                    {
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Font.Size = 10;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Font.Name = "Arial Cyr";
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.WrapText = true;
                        workSheet.Cells["E" + i.ToString()].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;

                        workSheet.Cells[i, 1].Value = i-1;
                        workSheet.Cells[i, 2].Value = data.deductibleStudents.ToList()[j].Surname;
                        workSheet.Cells[i, 3].Value = data.deductibleStudents.ToList()[j].Name;
                        workSheet.Cells[i, 4].Value = data.deductibleStudents.ToList()[j].MiddleName;
                        workSheet.Cells[i, 5].Value = data.deductibleStudents.ToList()[j].EducationForm;
                    }
                    workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                }
                
                excelPackage.Save();
                Process.Start(new ProcessStartInfo("explorer.exe", "/open, " + filePath));
            }
        }

        public static void CreateReportFile1(IEnumerable<DeductibleStudentsTable> data_table, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();
            ExcelWorksheet workSheet = null;
            string[] Headers = { "Surname", "Name", "MiddleName", "EducationForms" };
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

        public static void CreateReportFile(IEnumerable<PointsByGroupTable> data_table, string filePath)
        {
        }
        public static void CreateReportFile(IEnumerable<SessionResultTable> data_table, string filePath)
        {
        }
        }
    }
