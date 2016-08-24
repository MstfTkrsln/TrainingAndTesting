using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CodentQ;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;


namespace ExcelTool
{
    public class ExcelCreator
    {


        Excel.Application ExcelUygulama;
        Excel.Workbook ExcelProje;
        Excel.Worksheet ExcelSayfa;
        object Missing = System.Reflection.Missing.Value;
        Excel.Range ExcelRange;

        int rowCnt = 0;
        int columnCnt = 0;

        string s_dosyaadi = "";
        string s_veri = "";

        public void CreateExcelFile2()
        {
            DataSet ds=new DataSet();
            ds.Tables.Add();
            
            ds.Tables[0].Columns.Add();
            ds.Tables[0].Columns.Add();

            for (int i=0; i < 30; i++)
            {
                DataRow dr = ds.Tables[0].NewRow();
                
                dr[0] = "Data 0";
                dr[1] = "Data 1";

                ds.Tables[0].Rows.Add(dr);
            }


            excelconnect ec=new excelconnect();
            ec.saveexcel(ds,@"c:\\exceldeneme.xls");
            
            
        }

        public void CreateExcelFile()
        {
            ExcelUygulama = new Excel.Application();
            ExcelProje = ExcelUygulama.Workbooks.Add(Missing);

            ExcelSayfa = (Excel.Worksheet)ExcelProje.Worksheets.get_Item(1);
            ExcelRange = ExcelSayfa.UsedRange;
            ExcelSayfa = (Excel.Worksheet)ExcelUygulama.ActiveSheet;

            ExcelUygulama.Visible = true;
            ExcelUygulama.AlertBeforeOverwriting = true;



            rowCnt = 2;
            columnCnt = 2;
            s_veri = "deneme yazi";
            if (s_veri != "" && rowCnt != 0 && columnCnt != 0)
            {
                Excel.Range bolge = (Excel.Range)ExcelSayfa.Cells[rowCnt, columnCnt];
                bolge.Value2 = s_veri;
            }
            s_dosyaadi = "exceltest";

            if (s_dosyaadi != "")
            {
                ExcelProje.SaveAs(@"c:\\" + s_dosyaadi + ".xlsx", Excel.XlFileFormat.xlWorkbookDefault, Missing, Missing, false, Missing, Excel.XlSaveAsAccessMode.xlNoChange);
                ExcelProje.Close(true, Missing, Missing);
                ExcelUygulama.Quit();


            }

        }

    }


}



