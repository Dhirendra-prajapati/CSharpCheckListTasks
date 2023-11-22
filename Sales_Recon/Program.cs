using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;



namespace Sales_Recon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook jeSales = excelApp.Workbooks.Open(@"C:\Users\Nimap\Downloads\OneDrive_2023-11-08\Sales Reco\JE Sales CJNC 10.01 - 10.09.xlsm");
            Excel.Worksheet journal = (Excel.Worksheet)jeSales.Worksheets["Journal"];
            Excel.Workbook salesRecon = excelApp.Workbooks.Open(@"C:\Users\Nimap\Downloads\OneDrive_2023-11-08\Sales Reco\8.Sales Recon Sep 2023 - South & North.xlsx");
            Excel.Worksheet glSalesSept = (Excel.Worksheet)salesRecon.Worksheets["GL sales Sept"];
            //int targetColumn = 8;
            //Excel.Range columnRange = journal.Columns[targetColumn];
            Excel.Range dataRange = journal.Range["H1:H619"];
            List<string> accountFilterList = new List<string>();
            string str =null;
            foreach(Excel.Range cell in dataRange.Cells)
            {
                if (cell.Value != null)
                {
                    str = cell.Value.ToString();
                    string[] str1 = str.Split('-');
                    foreach (string str2 in str1)
                    {
                        if (str2.Contains("40001") || str2.Contains("40091"))
                        {
                           
                            accountFilterList.Add(cell.Value);

                        }
                    }
                }
            }

            string[] filterValue=accountFilterList.ToArray();
            Range journalFilter = journal.Range[journal.Cells[1, 1], journal.Cells[619, 16]];
            journalFilter.AutoFilter(8,filterValue, Excel.XlAutoFilterOperator.xlFilterValues);
            //copy the filter data
            //Excel.Range sourceHeaderRow = journal.Rows[4]; // Assuming header is in the first row
            //Excel.Range destinationHeaderColumn = glSalesSept.Rows[1];
            //int columnIndex = FindColumnIndexByName(headerRow, "Entity"); // Change "ColumnName" to your column name
            int sourceColumnIndex = FindColumnIndexByName(journal,"Account");
            Excel.Range sourceColumn = journal.Columns[sourceColumnIndex];

            int sourceColumnEntity = FindColumnIndexByName(journal, "Entity");
            Excel.Range sourceColumn1= journal.Columns[sourceColumnEntity];

            int destinationColumnIndex = FindColumnIndexByName(glSalesSept, "Account Number"); // Change "DestinationColumnName" to your destination column name
            Excel.Range destinationColumn = glSalesSept.Columns[destinationColumnIndex];
            sourceColumn.Copy(destinationColumn);

            int destinationColumnEntity = FindColumnIndexByName(glSalesSept, "Entity"); // Change "DestinationColumnName" to your destination column name
            Excel.Range destinationEntity = glSalesSept.Columns[destinationColumnEntity];
            sourceColumn.Copy(destinationColumn);






        }
        private static int FindColumnIndexByName(Excel.Worksheet worksheet, string columnName)
        {
            foreach (Excel.Range cell in worksheet.Columns)
            {
                if (cell.Value2 != null && cell.Value2.ToString() == columnName)
                {
                    return cell.Column;
                }
            }
            return -1; // Column not found
        }
    }
}
