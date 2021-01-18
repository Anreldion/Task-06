using BusinessLogicLayer.DeductibleStudent;
using BusinessLogicLayer.PointsByGroup;
using BusinessLogicLayer.SessionResult;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace BusinessLogicLayer
{
    public class Excel
    {

        static void SetHeaderStyle(ExcelWorksheet workSheet, int row)
        {
            workSheet.Row(row).Style.WrapText = true;
            workSheet.Row(row).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            workSheet.Row(row).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            workSheet.Row(row).Height = (double)30;

        }


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

                    SetHeaderStyle(workSheet, 1);

                    workSheet.Column(1).Width = (double)4;
                    workSheet.Column(2).Width = 14;
                    workSheet.Column(3).Width = 16;
                    workSheet.Column(4).Width = 16;
                    workSheet.Column(5).Width = 10;

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

                        workSheet.Cells[i, 1].Value = i - 1;
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

        public static void CreateReportFile(IEnumerable<PointsByGroupTable> data_table, string filePath)
        {
            FileWorker.DeleteFileIfExists(filePath);
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                foreach (var data in data_table)
                {
                    ExcelWorksheet workSheet = excelPackage.Workbook.Worksheets.Add(data.SessionPeriod);

                    SetHeaderStyle(workSheet, 1);

                    workSheet.Column(1).Width = 4;
                    workSheet.Column(2).Width = 15;
                    workSheet.Column(3).Width = 10;
                    workSheet.Column(4).Width = 10;
                    workSheet.Column(5).Width = 10;

                    workSheet.Cells["A1:E1"].Style.Font.Size = 10;
                    workSheet.Cells["A1:E1"].Style.Font.Name = "Arial Cyr";
                    workSheet.Cells["A1:E1"].Style.Font.Bold = true;
                    workSheet.Cells["A1:E1"].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Medium);
                    workSheet.Cells["B1:D1"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    workSheet.Cells["B1:D1"].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                    workSheet.Cells[1, 1].Value = "№ ";
                    workSheet.Cells[1, 2].Value = "Group Name";
                    workSheet.Cells[1, 3].Value = "Minimum Score";
                    workSheet.Cells[1, 4].Value = "Average Score";
                    workSheet.Cells[1, 5].Value = "Maximum Score";

                    int i = 2;
                    for (int j = 0; j < data.pointsByGroups.Count(); i++, j++)
                    {
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Font.Size = 10;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Font.Name = "Arial Cyr";
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.WrapText = true;
                        workSheet.Cells["E" + i.ToString()].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;

                        workSheet.Cells[i, 1].Value = i - 1;
                        workSheet.Cells[i, 2].Value = data.pointsByGroups.ToList()[j].GroupName;
                        workSheet.Cells[i, 3].Value = data.pointsByGroups.ToList()[j].MinimumScore;
                        workSheet.Cells[i, 4].Value = data.pointsByGroups.ToList()[j].AverageScore;
                        workSheet.Cells[i, 5].Value = data.pointsByGroups.ToList()[j].MaximumScore;
                    }
                    workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                }
                excelPackage.Save();
                Process.Start(new ProcessStartInfo("explorer.exe", "/open, " + filePath));
            }
        }
        public static void CreateReportFile(IEnumerable<SessionResultTable> data_table, string filePath)
        {
            FileWorker.DeleteFileIfExists(filePath);
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                foreach (var data in data_table)
                {
                    

                }
                excelPackage.Save();
                Process.Start(new ProcessStartInfo("explorer.exe", "/open, " + filePath));
            }
        }
    }
}
