
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class Stf_3_6 : BaseSearchClass
    {
        private StorageStationDbContext context { get; set; }

        public new string HtmlTable { get; set; }
        public new string Table { get; set; }
        public bool All { get; set; }
        public bool Stf3 { get; set; }
        public bool Stf3Cpt { get; set; }
        public bool Stf4 { get; set; }
        public bool Stf5 { get; set; }
        public bool Stf6 { get; set; }

        public Stf_3_6()
        {
            context = new StorageStationDbContext();
        }

        public void GetDataFromSql(string nr, bool download = false)
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (!string.IsNullOrWhiteSpace(nr))
                {
                    var result = context.PanelFontijneL1s
                            .Where(x => x.ManufacturingLotTraceCode == nr);

                    var resultArray = result.ToArray();
                    if (resultArray.Length > 0)
                    {
                        if (download)
                        {
                            Table = dataTable.WriteTextToFile(result);
                        }
                        else
                        {
                            HtmlTable = dataTable.WriteToTable(resultArray);
                        }
                    }
                }
            }
            catch { }
        }

        public void GetDataFromSql(IList<string> list, bool download = false)
        {
            try
            {
                DataTable dataTable = new DataTable();

                foreach (string nr in list)
                {
                    if (!string.IsNullOrWhiteSpace(nr))
                    {
                        var result = context.PanelFontijneL1s
                                .Where(x => x.ManufacturingLotTraceCode == nr || x.Csm2BrickCode == nr || x.Csm2BrickCode == nr);

                        var resultArray = result.ToArray();
                        if (resultArray.Length > 0)
                        {
                            if (download)
                            {
                                Table = dataTable.WriteTextToFile(result);
                            }
                            else
                            {
                                HtmlTable = dataTable.WriteToTable(resultArray);
                            }
                        }
                    }
                }
            }
            catch { }
        }

        public void GetDataFromSqlStf3(DateTime dateTime, bool download = false)
        {
            try
            {
                DateTime from = dateTime;
                DateTime to = dateTime.AddDays(1);

                DataTable dataTable = new DataTable();

                var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
                var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

                var result = context.PanelFontijneL1s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo));

                var resultArray = result.ToArray();
                if (resultArray.Length > 0)
                {
                    if (download)
                    {
                        Table = dataTable.WriteTextToFile(result);
                    }
                    else
                    {
                        HtmlTable = dataTable.WriteToTable(resultArray);
                    }
                }
            }
            catch { }
        }

        public void GetDataFromSqlStf3Cpt(DateTime dateTime, bool download = false)
        {
            try
            {
                DateTime from = dateTime;
                DateTime to = dateTime.AddDays(1);

                DataTable dataTable = new DataTable();

                var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
                var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

                var result = context.PanelFontijneL1s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(a => new
                          {
                              ManufacturingLotTraceCode = a.ManufacturingLotTraceCode,
                              CptOutletPushoutForce = a.CptOutletPushoutForce,
                              CptInletPushoutForce = a.CptInletPushoutForce,
                              CsiOutletSubstrateMeasureShell = a.CsiOutletSubstrateMeasureShell,
                              CsiInletSubstrateMeasureShell = a.CsiInletSubstrateMeasureShell
                          });

                var resultArray = result.ToArray();
                if (resultArray.Length > 0)
                {
                    if (download)
                    {
                        Table = dataTable.WriteTextToFile(result);
                    }
                    else
                    {
                        HtmlTable = dataTable.WriteToTable(resultArray);
                    }
                }
            }
            catch { }
        }

        public void GetDataFromSqlStf3Cpt(IList<string> list, bool download = false)
        {
            try
            {
                DataTable dataTable = new DataTable();

                foreach (string byCode in list)
                {
                    if (!string.IsNullOrWhiteSpace(byCode))
                    {
                        var result = context.PanelFontijneL1s
                          .Where(x => x.ManufacturingLotTraceCode == byCode)
                          .Select(a => new
                          {
                              ManufacturingLotTraceCode = a.ManufacturingLotTraceCode,
                              CptOutletPushoutForce = a.CptOutletPushoutForce,
                              CptInletPushoutForce = a.CptInletPushoutForce,
                              CsiOutletSubstrateMeasureShell = a.CsiOutletSubstrateMeasureShell,
                              CsiInletSubstrateMeasureShell = a.CsiInletSubstrateMeasureShell
                          });

                        var resultArray = result.ToArray();
                        if (resultArray.Length > 0)
                        {
                            if (download)
                            {
                                Table = dataTable.WriteTextToFile(result);
                            }
                            else
                            {
                                HtmlTable = dataTable.WriteToTable(resultArray);
                            }
                        }
                    }
                }
            }
            catch { }
        }

        public void GetDataFromSqlStf4(DateTime dateTime, bool download = false)
        {
            try
            {
                DateTime from = dateTime;
                DateTime to = dateTime.AddDays(1);

                DataTable dataTable = new DataTable();

                var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
                var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

                var result = context.PanelFontijneL1s
                          .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo));

                var resultArray = result.ToArray();
                if (resultArray.Length > 0)
                {
                    if (download)
                    {
                        Table = dataTable.WriteTextToFile(result);
                    }
                    else
                    {
                        HtmlTable = dataTable.WriteToTable(resultArray);
                    }
                }
            }
            catch { }
        }

        public void GetDataFromSqlStf5(DateTime dateTime, bool download = false)
        {
            try
            {
                DateTime from = dateTime;
                DateTime to = dateTime.AddDays(1);

                DataTable dataTable = new DataTable();

                var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
                var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

                var result = context.PanelFontijneL1s
                          .Where(x => (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo));

                var resultArray = result.ToArray();
                if (resultArray.Length > 0)
                {
                    if (download)
                    {
                        Table = dataTable.WriteTextToFile(result);
                    }
                    else
                    {
                        HtmlTable = dataTable.WriteToTable(resultArray);
                    }
                }
            }
            catch { }
        }

        public void GetDataFromSqlStf6(DateTime dateTime, bool download = false)
        {
            try
            {
                DateTime from = dateTime;
                DateTime to = dateTime.AddDays(1);

                DataTable dataTable = new DataTable();

                var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
                var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

                var result = context.PanelFontijneL1s
                          .Where(x => (x.FrameTime4 >= frameTimeFrom && x.FrameTime4 < frameTimeTo));

                var resultArray = result.ToArray();
                if (resultArray.Length > 0)
                {
                    if (download)
                    {
                        Table = dataTable.WriteTextToFile(result);
                    }
                    else
                    {
                        HtmlTable = dataTable.WriteToTable(resultArray);
                    }
                }
            }
            catch { }
        }

        public void GetDataFromSqlAll(DateTime dateTime, bool download = false)
        {
            try
            {
                DateTime from = dateTime;
                DateTime to = dateTime.AddDays(1);

                DataTable dataTable = new DataTable();

                var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
                var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

                var result = context.PanelFontijneL1s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo)
                          || (x.FrameTime4 >= frameTimeFrom && x.FrameTime4 < frameTimeTo));

                var resultArray = result.ToArray();
                if (resultArray.Length > 0)
                {
                    if (download)
                    {
                        Table = dataTable.WriteTextToFile(result);
                    }
                    else
                    {
                        HtmlTable = dataTable.WriteToTable(resultArray);
                    }
                }
            }
            catch{ }
        }

        //private void WriteToTable(Table.StorageStation.PanelFontijneL1[] result)
        //{
        //    DataTable table = new DataTable();

        //    table = result.ToDataTable();

        //    HtmlTable = table.ConvertDataTableToHTMLTable();
        //}

        //private void WriteToFile(IQueryable<Table.StorageStation.PanelFontijneL1> result)
        //{
        //    DataTable table = new DataTable();
        //    table = result.ToDataTable();
        //    var text = table.ConvertDataTableToText();


        //    //Serialize
        //    //MemoryStream stream = new MemoryStream();
        //    ////StreamWriter writer = new StreamWriter(stream); 
        //    //string stream = string.Empty;

        //    //stream = JsonSerializer.Serialize(result);
        //    //byte[] bytes = Encoding.ASCII.GetBytes(stream.Replace(',', ';'));

        //    byte[] bytesText = Encoding.ASCII.GetBytes(text);
        //    Table = bytesText;
        //}

    }
}
