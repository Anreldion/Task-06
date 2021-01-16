using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace BusinessLogicLayer
{
    public class Excel
    {
        public static void CreateReportFile(string path)
        {
            FileWorker.DeleteFileIfExists(path);
            FileInfo file = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                excelPackage.Workbook.Worksheets.Add("Deductible students");
                ExcelWorksheet excelWorksheet = excelWorkBook.Worksheets[0];

            }
        }
    }
}
