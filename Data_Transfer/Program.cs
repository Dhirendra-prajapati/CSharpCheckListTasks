using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Data_Transfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            string filePath = @"C:\Users\Nimap\Downloads\Daily sales - Copy.xlsx";
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets["2023"];
            Excel.Range headerRow = worksheet.Rows[2];
            var targetColumn = 6;
            Excel.Range column = worksheet.Columns[targetColumn];
            string substringToFilter = "D*";
            column.AutoFilter(1,$"*{substringToFilter}*", Excel.XlAutoFilterOperator.xlAnd, Type.Missing, true);
            Excel.Range visibleData = worksheet.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeVisible);
            foreach (Excel.Range cell in visibleData)
            {
                object value = cell.Value;
                Console.WriteLine(value);
            }

            //Excel.Worksheet excelWorksheet = (Excel.Worksheet)workbook.Worksheets[3];
            //Excel.Range columnA = worksheet.Range["G:G"];
            //string columnNameA = columnA.Cells[1, 1].Value.ToString();
            //Console.WriteLine("Column name :"+columnA);





            //List<string> filteredValues = new List<string>();

            //foreach (Excel.Range cell in columnA)
            //{
            //    if (cell.Value2 is string cellValue && cellValue.StartsWith("D", StringComparison.OrdinalIgnoreCase))
            //    {
            //        filteredValues.Add(cellValue);
            //    }
            //}
            //foreach(var data in filteredValues)
            //{

            // Console.WriteLine(filteredValues.ToString());

            //}
            //var ColumnName = columnA.Cells[2, 7];


            //try
            //{

            //    worksheet.AutoFilterMode = false;

            //    worksheet.UsedRange.AutoFilter(1, "Dist", Excel.XlAutoFilterOperator.xlFilterValues, Type.Missing, Type.Missing);

            //    Excel.Range filteredRange = worksheet.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeVisible);


            //    foreach (Excel.Range cell in filteredRange)
            //    {
            //        if (cell.Value2 is string cellValue && cellValue.StartsWith("D", StringComparison.OrdinalIgnoreCase))
            //        {
            //            filteredValues.Add(cellValue);
            //        }
            //    }

            //    foreach (string value in filteredValues)
            //    {
            //        Console.WriteLine(value);
            //    }
            //}
            //finally
            //{
            workbook.Close(false, Type.Missing, Type.Missing);
            Marshal.ReleaseComObject(workbook);
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
            //}
            Console.ReadLine();
        }
    }
}

 
