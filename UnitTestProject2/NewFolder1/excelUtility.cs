using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.COM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Reflection.Metadata.Ecma335;

namespace UnitTestProject2.NewFolder1
{

    public class excelUtility
    {


        /*   Spreadsheet sp;

          //  Spreadsheet sp;
          public static IEnumerable<object[]> AdditionData(string fPath, string sname)
              {
                  get
                  {

                  new Object[]

                  {


                      Spreadsheet sp = new Spreadsheet();
                  sp.LoadFromFile(fPath);
                  int lrow = sp.Workbook.Worksheets.ByName(sname).UsedRangeRowMax;
                  for (int i = 0; i < lrow; i++)
                  {
                      string sdata = sp.Workbook.Worksheets.ByName(sname).Cell(i, 0).ToString();


                      Console.WriteLine("data " + i + ":" + sdata);
                  }
              }

                  return sdata;
              }

          */


        public string excelData(int rowNo, int columnNo)
        {
            Spreadsheet sheet = new Spreadsheet();
            sheet.LoadFromFile("D:\\C#\\Excel\\Workbook1.xlsx");


            Worksheet sh = sheet.Workbook.Worksheets.ByName("Sheet1"); //particular sheet

            string data = sh.Cell(rowNo, columnNo).ToString();

            return data;
        }


        public IEnumerable<Object> Multidata(string sheetname)
        {
            Spreadsheet spreadsheet = new Spreadsheet();

            String Path = "C:\\Users\\panth\\source\\repos\\UnitTestProject2\\UnitTestProject2\\NewFolder1\\Excel1.xlsx";



            spreadsheet.LoadFromFile(Path);
            Worksheet wb = spreadsheet.Workbook.Worksheets.ByName(sheetname);

            int row = wb.UsedRangeRowMax;
            int cel = wb.UsedRangeColumnMax;

            for (int i = 0; i <= row; i++)
            {
                String key = wb.Cell(i, 0).ToString();
                String value = wb.Cell(i, 1).ToString();

                yield return new[] { key, value };
            }
        }

        public IEnumerable<Object> data(int row)
        {
            Spreadsheet sh = new Spreadsheet();

            String Path = "C:\\Users\\panth\\source\\repos\\UnitTestProject2\\UnitTestProject2\\NewFolder1\\Excel1.xlsx";

            sh.LoadFromFile(Path);
            Worksheet wb = sh.Workbook.Worksheets.ByName("Sheet1");

            //  int row = wb.UsedRangeRowMax;
            // int cel = wb.UsedRangeColumnMax;



            // for (int i = 0; i <= row; i++)
            // {
            string data = wb.Cell(row, 0).ToString();

            yield return new[] { data };
            // }




        }



    }
}
