
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;

namespace WebMonitoring.Search
{
    public class Stf1 : BaseSearchClass
    {
        private Stf1DbContext context { get; set; }
        private CodeStf Codes { get; set; }
        public Stf1()
        {
            context = new Stf1DbContext();
            FindData = new List<string>();
        }

        private CodeStf FindCode(string code)
        {
            var result = context.TblMeasuredAssemblies
                .Where(x => x.VShellSerialNum == code)
                .Select(x => new CodeStf
                {
                    Shell1 = x.VShellSerialNum,
                    Brick1 = x.VBrick1SerialNum,
                    Brick2 = x.VBrick2SerialNum,
                    Mat1 = x.VMat1SerialNum,
                    Mat2 = x.VMat2SerialNum
                }).ToArray();


            if (result.Length == 0)
            {
                result = context.TblMeasuredAssemblies
                 .Where(x => x.VShellSerialNum.Contains(code) || x.VBrick2SerialNum.Contains(code) || x.VBrick1SerialNum.Contains(code) || x.VMat1SerialNum.Contains(code) || x.VMat2SerialNum.Contains(code))
                 .Select(x => new CodeStf
                 {
                     Shell1 = x.VShellSerialNum,
                     Brick1 = x.VBrick1SerialNum,
                     Brick2 = x.VBrick2SerialNum,
                     Mat1 = x.VMat1SerialNum,
                     Mat2 = x.VMat2SerialNum
                 }).ToArray();                
            }

            return result != null ? result[0] : new CodeStf
            {
                Shell1 = Brak,
                Shell2 = Brak,
                Brick1 = Brak,
                Brick2 = Brak,
                Mat1 = Brak,
                Mat2 = Brak
            };
        }

        public void GetDataFromSql(IList<string> codeList, bool download = false)
        {
            Table = new List<string>();
            HtmlTable = new List<string>();
            NameTable = new List<string>();
            DataTable dataTable = new DataTable();
            FileName = new List<string>();

            try
            {
                foreach (var code in codeList)
                {
                    Codes = FindCode(code);

                    if (!string.IsNullOrWhiteSpace(Codes.Brick1) && Codes.Brick1 != Brak)
                    {
                        var result = context.TblBricks
                                .Where(x => x.VSerialNum == Codes.Brick1);

                        var resultArray = result.ToArray();
                        if (resultArray.Length > 0)
                        {
                            if (download)
                            { 
                                Table.Add(dataTable.WriteTextToFile(result));
                                FileName.Add("TblBricks 1");
                            }
                            else
                            {
                                NameTable.Add("Brick1");
                                HtmlTable.Add(dataTable.WriteToTable(resultArray));
                            }

                        }
                    }

                    if (!string.IsNullOrWhiteSpace(Codes.Brick2) && Codes.Brick2 != Brak)
                    {
                        var result = context.TblBricks
                                .Where(x => x.VSerialNum == Codes.Brick2);

                        var resultArray = result.ToArray();
                        if (resultArray.Length > 0)
                        {
                            if (download)
                            { 
                                Table.Add(dataTable.WriteTextToFile(result));
                                FileName.Add("TblBricks 2");
                            }
                            else
                            {
                                NameTable.Add("Brick2");
                                HtmlTable.Add(dataTable.WriteToTable(resultArray));
                            }

                            
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(Codes.Mat1) && Codes.Mat1 != Brak)
                    {
                        var result = context.TblMats
                                .Where(x => x.VSerialNum == Codes.Mat1);

                        var resultArray = result.ToArray();
                        if (resultArray.Length > 0)
                        {
                            if (download)
                            { 
                                Table.Add(dataTable.WriteTextToFile(result));
                                FileName.Add("TblMats 1");
                            }
                            else
                            {
                                NameTable.Add("Mat1");
                                HtmlTable.Add(dataTable.WriteToTable(resultArray));
                            }
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(Codes.Mat2) && Codes.Mat2 != Brak)
                    {
                        var result = context.TblMats
                                .Where(x => x.VSerialNum == Codes.Mat2);

                        var resultArray = result.ToArray();
                        if (resultArray.Length > 0)
                        {
                            if (download)
                            { 
                                Table.Add(dataTable.WriteTextToFile(result));
                                FileName.Add("TblMats 2");
                            }
                            else
                            {
                                NameTable.Add("Mat2");
                                HtmlTable.Add(dataTable.WriteToTable(resultArray));
                            }
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(Codes.Shell1) && Codes.Shell1 != Brak)
                    {
                        var result = context.TblMeasuredAssemblies
                                .Where(x => x.VShellSerialNum == Codes.Shell1);

                        var resultArray = result.ToArray();
                        if (resultArray.Length > 0)
                        {
                            if (download)
                            { 
                                Table.Add(dataTable.WriteTextToFile(result));
                                FileName.Add("TblMeasuredAssemblies");
                            }
                            else
                            {
                                NameTable.Add("Shell");
                                HtmlTable.Add(dataTable.WriteToTable(resultArray));
                            }
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(Codes.Shell1) && Codes.Shell1 != Brak)
                    {
                        var result = context.TblSubAssemblies
                                .Where(x => x.VShellSerialNum == Codes.Shell1);

                        var resultArray = result.ToArray();
                        if (resultArray.Length > 0)
                        {
                            if (download)
                            { 
                                Table.Add(dataTable.WriteTextToFile(result));
                                FileName.Add("TblSubAssemblies");
                            }
                            else
                            {
                                NameTable.Add("SubAssembly");
                                HtmlTable.Add(dataTable.WriteToTable(resultArray));
                            }
                        }
                    }
                }
            }
            catch { }

        }

        public void GetDataFromSql(DateTime? dateTime, bool download = false)
        {
            Table = new List<string>();
            HtmlTable = new List<string>();
            DataTable dataTable = new DataTable();
            FileName = new List<string>();

            DateTime? from = dateTime;
            DateTime? to = dateTime.Value.AddDays(1);

            try
            {
                var result1 = context.TblBricks
                         .Where(x => x.DtMeasure >= from && x.DtMeasure < to);

                var resultArray1 = result1.ToArray();
                if (resultArray1.Length > 0)
                {
                    if (download)
                    {
                        Table.Add(dataTable.WriteTextToFile(result1));
                        FileName.Add("TblBricks 1");
                    }
                    else
                        HtmlTable.Add(dataTable.WriteToTable(resultArray1));
                }

                var result2 = context.TblBricks
                           .Where(x => x.DtMeasure >= from && x.DtMeasure < to);

                var resultArray2 = result2.ToArray();
                if (resultArray2.Length > 0)
                {
                    if (download)
                    {
                        Table.Add(dataTable.WriteTextToFile(result2));
                        FileName.Add("TblBricks 2");
                    }
                    else
                        HtmlTable.Add(dataTable.WriteToTable(resultArray2));
                }

                var result3 = context.TblMats
                          .Where(x => x.DtTimeOfMeasure >= from && x.DtTimeOfMeasure < to);

                var resultArray3 = result3.ToArray();
                if (resultArray3.Length > 0)
                {

                    if (download)
                    {
                        Table.Add(dataTable.WriteTextToFile(result3));
                        FileName.Add("TblMats 1");
                    }
                    else
                        HtmlTable.Add(dataTable.WriteToTable(resultArray3));
                }

                var result4 = context.TblMats
                            .Where(x => x.DtTimeOfMeasure >= from && x.DtTimeOfMeasure < to);

                var resultArray4 = result4.ToArray();
                if (resultArray4.Length > 0)
                {

                    if (download)
                    {
                        Table.Add(dataTable.WriteTextToFile(result4));
                        FileName.Add("TblMats 2");
                    }
                    else
                        HtmlTable.Add(dataTable.WriteToTable(resultArray4));
                }

                var result5 = context.TblMeasuredAssemblies
                            .Where(x => x.DtAssembly >= from && x.DtAssembly < to);

                var resultArray5 = result5.ToArray();
                if (resultArray5.Length > 0)
                {

                    if (download)
                    {
                        Table.Add(dataTable.WriteTextToFile(result5));
                        FileName.Add("TblMeasuredAsseblies");
                    }
                    else
                        HtmlTable.Add(dataTable.WriteToTable(resultArray5)); 
                }
            }
            catch { }

        }   

    


    }
}
