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

        }
    }
}
