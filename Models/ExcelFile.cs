using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace WebMonitoring.Models
{
    public class ExcelFile
    {
       //static public string Error { get; set; }


        public bool InsertCellEPPlus(DateTime dateTime, TSQ dailyRaport)
        {
            string fileName = "Monitoring.xlsx";
            string path = @"\\192.168.40.9\Public\TSQ\Monitoring\";

            const int startIndexRow = 3; //pozycja startowa liczenia wiersza
            const int totalShift = 3;
            const int offsetDay = 1;

            int day = dateTime.Day;

            int i = 0;
            while (i < 5)
            {
                if (!CheckIfFileIsOpen(path + fileName))
                {
                    try
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        //Open the excel work book
                        var xlFile = new FileInfo(path + fileName);
                        using (var xlWorkBook = new ExcelPackage(xlFile))
                        {
                            //insert to Outpu Details WS3A 
                            const string ws3A = "Output Details WS3A";
                            var xlSheet = xlWorkBook.Workbook.Worksheets[ws3A];
                            //HR10 Cela 2 LP1
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 6].Value = dailyRaport.LineWs3A_2LP1.Line;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs3A_2LP1.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs3A_2LP1.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs3A_2LP1.Shift3;
                            }

                            //HR10 Cela 2 LP2
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 9].Value = dailyRaport.LineWs3A_2LP2.Line;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineWs3A_2LP2.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineWs3A_2LP2.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineWs3A_2LP2.Shift3;
                            }

                            //HR10 Cela 0 LP1
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 12].Value = dailyRaport.LineWs3A_0LP1.Line;
                              
                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 13].Value = dailyRaport.LineWs3A_0LP1.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 13].Value = dailyRaport.LineWs3A_0LP1.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 13].Value = dailyRaport.LineWs3A_0LP1.Shift3;
                            }

                            //HR10GPF Cela GPF1LP1
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 15].Value = dailyRaport.LineWs3A_1LP1Gpf.Line;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineWs3A_1LP1Gpf.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineWs3A_1LP1Gpf.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineWs3A_1LP1Gpf.Shift3;
                            }

                            //HR10GPF Cela GPF2LP1
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 18].Value = dailyRaport.LineWs3A_2LP1Gpf.Line;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 19].Value = dailyRaport.LineWs3A_2LP1Gpf.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 19].Value = dailyRaport.LineWs3A_2LP1Gpf.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 19].Value = dailyRaport.LineWs3A_2LP1Gpf.Shift3;
                            }

                            //HR10 Cela 1 Cupler LP2
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 21].Value = dailyRaport.LineWs3A_1LP2_Rurki.Line;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 22].Value = dailyRaport.LineWs3A_1LP2_Rurki.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 22].Value = dailyRaport.LineWs3A_1LP2_Rurki.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 22].Value = dailyRaport.LineWs3A_1LP2_Rurki.Shift3;
                            }

                            //insert to Outpu Details WS3B
                            const string ws3B = "Output Details WS3B";
                            xlSheet = xlWorkBook.Workbook.Worksheets[ws3B];

                            //HR10 DET
                            //for (int rowShift = 1; rowShift <= 3; rowShift++)
                            //{
                            //    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 6].Value = dailyRaport.LineWs3.Model;

                            //    if (rowShift == 1)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs3.Shift1;
                            //    else if (rowShift == 2)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs3.Shift2;
                            //    else if (rowShift == 3)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs3.Shift3;
                            //}

                            //HR10 GPF
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 9].Value = dailyRaport.LineWs3.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineWs3.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineWs3.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineWs3.Shift3;
                            }

                            //insert to Outpu Details WS2 HR16
                            const string ws2Hr16 = "Output Details WS2 HR16";
                            xlSheet = xlWorkBook.Workbook.Worksheets[ws2Hr16];

                            //HR16
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs2.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs2.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs2.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs2.Shift3;
                            }

                            //insert to Outpu Details WS4
                            const string ws4 = "Output Details WS4";
                            xlSheet = xlWorkBook.Workbook.Worksheets[ws4];

                            //BR10 BJA
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 6].Value = dailyRaport.LineWs8_Bja.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs8_Bja.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs8_Bja.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs8_Bja.Shift3;
                            }

                            //BR10 GPF
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 9].Value = dailyRaport.LineWs8_Bja.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineWs8_Bja.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineWs8_Bja.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineWs8_Bja.Shift3;
                            }

                            //insert to Outpu Details STF3
                            const string stf3 = "Output Details STF3";
                            xlSheet = xlWorkBook.Workbook.Worksheets[stf3];

                            ////STF3 HR10 DET
                            //for (int rowShift = 1; rowShift <= 3; rowShift++)
                            //{
                            //    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 6].Value = dailyRaport.LineStf3.Line;

                            //    if (rowShift == 1)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineStf3.Shift1;
                            //    else if (rowShift == 2)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineStf3.Shift2;
                            //    else if (rowShift == 3)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineStf3.Shift3;
                            //}

                            ////STF3 BR10 ED
                            //for (int rowShift = 1; rowShift <= 3; rowShift++)
                            //{
                            //    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 9].Value = dailyRaport.LineStf3.Line;

                            //    if (rowShift == 1)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineStf3.Shift1;
                            //    else if (rowShift == 2)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineStf3.Shift2;
                            //    else if (rowShift == 3)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 10].Value = dailyRaport.LineStf3.Shift3;
                            //}

                            //STF3 HR16
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 12].Value = dailyRaport.LineStf3.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 13].Value = dailyRaport.LineStf3.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 13].Value = dailyRaport.LineStf3.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 13].Value = dailyRaport.LineStf3.Shift3;
                            }


                            //insert to Outpu Details STF4
                            const string stf4 = "Output Details STF4";
                            xlSheet = xlWorkBook.Workbook.Worksheets[stf4];

                            ////STF4 HR10 GPF
                            //for (int rowShift = 1; rowShift <= 3; rowShift++)
                            //{
                            //    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 15].Value = dailyRaport.LineStf4.Model;

                            //    if (rowShift == 1)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineStf4.Shift1;
                            //    else if (rowShift == 2)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineStf4.Shift2;
                            //    else if (rowShift == 3)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineStf4.Shift3;
                            //}

                            //STF4 BR10 BJA
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 18].Value = dailyRaport.LineStf4.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 19].Value = dailyRaport.LineStf4.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 19].Value = dailyRaport.LineStf4.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 19].Value = dailyRaport.LineStf4.Shift3;
                            }

                            //STF4 BR10 GPF
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 21].Value = dailyRaport.LineStf4.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 22].Value = dailyRaport.LineStf4.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 22].Value = dailyRaport.LineStf4.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 22].Value = dailyRaport.LineStf4.Shift3;
                            }

                            //insert to Outpu Details STF5
                            const string stf5 = "Output Details STF5";
                            xlSheet = xlWorkBook.Workbook.Worksheets[stf5];

                            //STF5 BR10 BJA
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 15].Value = dailyRaport.LineStf5.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineStf5.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineStf5.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineStf5.Shift3;
                            }

                            //insert to Outpu Details WS1
                            const string ws1 = "Output Details WS1 V50";
                            xlSheet = xlWorkBook.Workbook.Worksheets[ws1];

                            //V50
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs1V50.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs1V50.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs1V50.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs1V50.Shift3;
                            }

                            //insert to Outpu Details WS5
                            const string ws5 = "Output Details WS5 CNH";
                            xlSheet = xlWorkBook.Workbook.Worksheets[ws5];

                            //CNH 537
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs5.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs5.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs5.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs5.Shift3;
                            }

                            //insert to Outpu Details STF6
                            const string stf6 = "Output Details STF6";
                            xlSheet = xlWorkBook.Workbook.Worksheets[stf6];

                            ////STF6 HR10 GPF
                            //for (int rowShift = 1; rowShift <= 3; rowShift++)
                            //{
                            //    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 12].Value = dailyRaport.LineStf6.Model;

                            //    if (rowShift == 1)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 13].Value = dailyRaport.LineStf6.Shift1;
                            //    else if (rowShift == 2)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 13].Value = dailyRaport.LineStf6.Shift2;
                            //    else if (rowShift == 3)
                            //        xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 13].Value = dailyRaport.LineStf6.Shift3;
                            //}

                            //STF6 HR16
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 15].Value = dailyRaport.LineStf6.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineStf6.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineStf6.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 16].Value = dailyRaport.LineStf6.Shift3;
                            }

                            //insert to Outpu Details WS6
                            const string ws6 = "Output Details WS6 CNH";
                            xlSheet = xlWorkBook.Workbook.Worksheets[ws6];

                            //CNH 529
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs6.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs6.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs6.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs6.Shift3;
                            }

                            //insert to Outpu Details WS7
                            const string ws7 = "Output Details WS7 CNH";
                            xlSheet = xlWorkBook.Workbook.Worksheets[ws7];

                            //CNH 529
                            for (int rowShift = 1; rowShift <= 3; rowShift++)
                            {
                                xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 7].Value = dailyRaport.LineWs7.Model;

                                if (rowShift == 1)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs7.Shift1;
                                else if (rowShift == 2)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs7.Shift2;
                                else if (rowShift == 3)
                                    xlSheet.Cells[(day - offsetDay) * totalShift + startIndexRow + rowShift, 8].Value = dailyRaport.LineWs7.Shift3;
                            }

                            //zapis do piliku
                            xlWorkBook.Save();
                        }
                        return true;
                    }
                    catch// (Exception ex)
                    {
                        //Error = ex.ToString();
                        //Console.WriteLine(ex);
                        return false;
                    }
            }
                else
            {
                throw new Exception("Plik otwarty");
            }

            i++;
            System.Threading.Thread.Sleep(1000);
        }
            return false;
        }

        private bool CheckIfFileIsOpen(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None);

                s.Close();

                return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine( ex.ToString());

                return true;
            }
        }

        private int Yesterday()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;
            var dateDay = DateTime.Now;
            var tempDay = new DateTime(dateDay.Year, dateDay.Month - 1, cal.GetDaysInMonth(dateDay.Year, dateDay.Month - 1));
            return tempDay.Day;
        }
    }
}
