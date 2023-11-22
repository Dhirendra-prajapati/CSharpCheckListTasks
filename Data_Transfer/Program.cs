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
            string filePath = @"C:\Users\Nimap\Downloads\OneDrive_2023-10-17\Sales Reco.xlsx";
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
           
            Console.ReadLine();
        }
    }
}

 
