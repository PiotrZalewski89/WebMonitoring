
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS10
    {
        private string ConnectionString => "Host=172.16.30.20;Port=5432;Database=postgres;Username=cl;Password=cl1234";

        private string ResultOk => "OK";
        private string Remove => "Remove";

        private string[] DescriptionWS10 = new string[]
       {
            "Linia rezystancyjna",
            "Znakowarka laserowa",
            "Wiremash",
            "Wkrętak / Clip",
            "Spradzian geometrii",
            "Kontrola Jakości"
       };

        private string[] ProductionPartNumber = new string[]
        {
            "976.119.213.F",
            "976.119.213.G",
            "976.119.213.H",
            "976.119.213.J",
            "976.119.213.K",
            "976.119.364.G",
            "976.119.364.H",
            "976.119.368.C",
            "976.119.369.E",
            "976.119.520.E",
            "976.119.535.B",
            "976.119.714.D",
        };

        private Dictionary<string, List<int>> _LineData { get; set; }

        public Dictionary<string, List<int>> LineData { get => _LineData; }

        private DbProduction Production { get; set; } = new DbProduction(new ProductionDbContext());

        public string PartNumber { get; set; }

        private int target = 0;
        public int Target
        {
            get
            {
                if (target == 0)
                {
                    string nameTarget;

                    if (!string.IsNullOrEmpty(PartNumber))
                        nameTarget = LineDescription.LineWS10 + "_" + PartNumber;
                    else
                        nameTarget = LineDescription.LineWS10;

                    var result = Production.GetTarget(nameTarget);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[12];
                }
                return target;
            }
            set
            {
                target = value;

                string nameTarget;

                if (!string.IsNullOrEmpty(PartNumber))
                    nameTarget = LineDescription.LineWS10 + "_" + PartNumber;
                else
                    nameTarget = LineDescription.LineWS10;

                Production.SetTarget(nameTarget, target);
            }
        }

        public List<int> WeldingCell { get; set; }
        public List<int> FinalGauge { get; set; }
        public List<int> LaserMarking { get; set; }
        public List<int> Wiremash { get; set; }
        public List<int> Torque_Clipping { get; set; }
        public List<int> ControlLoop { get; set; }

        public async Task<int> WeldingCellData(DateTime dateTimeFrom, DateTime dateTimeTo, string pn = "")
        {
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                if(!string.IsNullOrEmpty(pn))
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT COALESCE(SUM(""BOX_QTY""), 0) as ""COUNTER"" FROM ""PORSCHE"".""tbl_ROBOT_WELDING_ASSY"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""CODE"" like '%" + pn.Substring(pn.Length - 5) + "%' ;", connection); 
                    using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT COALESCE(SUM(""BOX_QTY""), 0)  as ""COUNTER"" FROM ""PORSCHE"".""tbl_ROBOT_WELDING_ASSY"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK';", connection); 
                    using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }  
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public async Task<int> LaserMarkingData(DateTime dateTimeFrom, DateTime dateTimeTo, string pn = "")
        {
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                if (!string.IsNullOrEmpty(pn))
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_LASER_MARKING"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""FINAL_CODE"" like '%" + pn + "%' ;", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_LASER_MARKING"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK';", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<int> WiremashData(DateTime dateTimeFrom, DateTime dateTimeTo, string pn = "")
        {
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                if (!string.IsNullOrEmpty(pn))
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_WIREMASH_ASSY"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""CODE"" like '%" + pn + "%' ;", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_WIREMASH_ASSY"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK';", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<int> ClippingData(DateTime dateTimeFrom, DateTime dateTimeTo, string pn = "")
        {
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                if (!string.IsNullOrEmpty(pn))
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_CLIPPING_ASSY"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""CODE"" like '%" + pn + "%' ;", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_CLIPPING_ASSY"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK';", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<int> TorqueData(DateTime dateTimeFrom, DateTime dateTimeTo, string pn = "")
        {
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                if (!string.IsNullOrEmpty(pn))
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_TORQUE_CLIPPING_ASSY"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""FINAL_CODE"" like '%" + pn + "%' ;", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_TORQUE_CLIPPING_ASSY"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK';", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<int> GaugeData(DateTime dateTimeFrom, DateTime dateTimeTo, string pn = "")
        {
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                if (!string.IsNullOrEmpty(pn))
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_QUALITY_GAUGE"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""CODE"" like '%" + pn + "%' ;", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_QUALITY_GAUGE"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK';", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<int> ControlLoopData(DateTime dateTimeFrom, DateTime dateTimeTo, string pn = "")
        {
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                if (!string.IsNullOrEmpty(pn))
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_CONTROL_LOOP"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""RESULT"" != 'REMOVE' and ""CODE"" like '%" + pn + "%' ;", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_CONTROL_LOOP"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""RESULT"" != 'REMOVE';", connection); using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        return Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<List<DataFromCL>> ControlLoopData_ByPN(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            List<DataFromCL> data = new();

            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT ""CODE"" FROM ""PORSCHE"".""tbl_CONTROL_LOOP"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""RESULT"" != 'REMOVE';", connection);

                using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var r = reader["CODE"].ToString();

                    foreach (var pn in ProductionPartNumber)
                    {
                        if (r.Contains(pn))
                        {
                            int index = data.FindIndex(x => x.PN.Contains(pn));

                            if (index >= 0)
                            {
                                data.ElementAt(index).Qty++;
                            }
                            else
                            {
                                data.Add(new DataFromCL { PN = pn, Qty = 1 });
                            }
                            break;
                        }
                    }
                }

                return data;

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public async Task GetProductionCountPerHour(DateTime dateTime, string pn = "")
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            WeldingCell = new List<int>();
            Wiremash = new List<int>();
            FinalGauge = new List<int>();
            Torque_Clipping = new List<int>();
            LaserMarking = new List<int>();
            ControlLoop = new List<int>();


            for (int i = 0; i < 8; i++)
            {
                WeldingCell.Add(await WeldingCellData(dateTimeFrom, dateTimeTo, pn));
                LaserMarking.Add(await LaserMarkingData(dateTimeFrom, dateTimeTo, pn));
                Wiremash.Add(await WiremashData(dateTimeFrom, dateTimeTo, pn));
                var clip = await ClippingData(dateTimeFrom, dateTimeTo, pn);
                var torque = await TorqueData(dateTimeFrom, dateTimeTo, pn);
                Torque_Clipping.Add(clip + torque);
                FinalGauge.Add(await GaugeData(dateTimeFrom, dateTimeTo, pn));
                ControlLoop.Add(await ControlLoopData(dateTimeFrom, dateTimeTo, pn));

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            WeldingCell.Add(WeldingCell.Sum());
            LaserMarking.Add(LaserMarking.Sum());
            Wiremash.Add(Wiremash.Sum());
            Torque_Clipping.Add(Torque_Clipping.Sum());
            FinalGauge.Add(FinalGauge.Sum());
            ControlLoop.Add(ControlLoop.Sum());

            //"976.119.213.F" - 0
            //"976.119.213.G" - 1
            //"976.119.213.H" - 2
            //"976.119.213.J" - 3
            //"976.119.213.K" - 4
            //"976.119.364.G" - 5
            //"976.119.364.H" - 6
            //"976.119.368.C" - 7
            //"976.119.369.E" - 8
            //"976.119.520.E" - 9
            //"976.119.535.B" - 10
            //"976.119.714.D" - 11

            if (pn != ProductionPartNumber[9] && pn != ProductionPartNumber[10] && pn != ProductionPartNumber[11] ) 
                _LineData.Add(DescriptionWS10[0], WeldingCell);

            if (pn != ProductionPartNumber[9] && pn != ProductionPartNumber[10] && pn != ProductionPartNumber[11])
                _LineData.Add(DescriptionWS10[1], LaserMarking);

            if (pn == ProductionPartNumber[0] || pn == ProductionPartNumber[1] || pn == ProductionPartNumber[2] || pn == ProductionPartNumber[3] || pn == ProductionPartNumber[4] || pn == ProductionPartNumber[5] || pn == ProductionPartNumber[6] || pn == ProductionPartNumber[7])
                _LineData.Add(DescriptionWS10[2], Wiremash);

            if (pn == ProductionPartNumber[0] || pn == ProductionPartNumber[1] || pn == ProductionPartNumber[2] || pn == ProductionPartNumber[3] || pn == ProductionPartNumber[4] || pn == ProductionPartNumber[8])
                _LineData.Add(DescriptionWS10[3], Torque_Clipping);

            if (pn != ProductionPartNumber[9] && pn != ProductionPartNumber[10] && pn != ProductionPartNumber[11])
                _LineData.Add(DescriptionWS10[4], FinalGauge);

            _LineData.Add(DescriptionWS10[5], ControlLoop);
        }

        public async Task<int> GetCountFromDayWS10(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_CONTROL_LOOP"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""RESULT"" != 'REMOVE';", connection);

                using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    var r = Convert.ToInt64(reader["COUNTER"]);
                    return Convert.ToInt32(r is { } ? r : 0);
                }
            }
            catch
            {
                return 0;
            }

            return 0;
        }

        public async Task<List<List<DataFromCL>>> GetDailyRaport(DateTime dateTime)
        {
            List<DataFromCL> data = new();
            List<List<DataFromCL>> Shift = new();

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                    connection.Open();

                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT ""CODE"" FROM ""PORSCHE"".""tbl_CONTROL_LOOP"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""RESULT"" != 'REMOVE';", connection);

                    using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        var r = reader["CODE"].ToString();

                        foreach (var pn in ProductionPartNumber)
                        {
                            if (r.Contains(pn))
                            {
                                int index = data.FindIndex(x => x.PN.Contains(pn));

                                if (index >= 0)
                                {
                                    data.ElementAt(index).Qty++;
                                }
                                else
                                {
                                    data.Add(new DataFromCL { PN = pn, Qty = 1 });
                                }
                                break;
                            }
                        }
                    }
                }
                catch
                {
                    return null;
                }

                Shift.Add(new List<DataFromCL>());

                foreach (var d in data)
                {
                    Shift[Shift.Count - 1].Add(new DataFromCL { PN = d.PN, Qty = d.Qty });
                }

                data.Clear();
                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);
            }

            return Shift;
        }

        public async Task<int[]> GetDailyRaportCL(DateTime dateTime)
        {
            int[] partsShift = new int[3];

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                for (int i = 0; i < 3; i++)
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_CONTROL_LOOP"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""RESULT"" != 'REMOVE';", connection);

                    using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        partsShift[i] = Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        partsShift[i] = 0;
                    }

                    dateTimeFrom = dateTimeFrom.AddHours(8);
                    dateTimeTo = dateTimeTo.AddHours(8);
                }             
            }
            catch
            {
                return null;
            }

            return partsShift;
        }

        public async Task<int[]> GetDailyRaportRW(DateTime dateTime, string line)
        {
            int[] partsShift = new int[3];

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                for (int i = 0; i < 3; i++)
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT COALESCE(SUM(""BOX_QTY""), 0)  as ""COUNTER"" FROM ""PORSCHE"".""tbl_ROBOT_WELDING_ASSY"" 
                                        where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""LINE"" = '" + line + @"'  and ""CODE_BOX_1"" <> 'SIM';", connection);

                    using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        partsShift[i] = Convert.ToInt32(r is { } ? r : 0);
                    }
                    else
                    {
                        partsShift[i] = 0;
                    }

                    dateTimeFrom = dateTimeFrom.AddHours(8);
                    dateTimeTo = dateTimeTo.AddHours(8);
                }
            }
            catch
            {
                return null;
            }

            return partsShift;
        }


        public async Task<int> ActiveShift(DateTime dateTime)
        {
            int shifts = 0;

            var dateTimeFrom = dateTime.Date;
            dateTimeFrom = dateTimeFrom.AddHours(6);
            var dateTimeTo = dateTime.Date;
            dateTimeTo = dateTimeTo.AddHours(14);

            for (int i = 0; i < 3; i++)
            {
                int result1 = 0;

                try
                {
                    using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                    connection.Open();

                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT count(*) as ""COUNTER"" FROM ""PORSCHE"".""tbl_CONTROL_LOOP"" where ""DT_OPERATION"" between '" + dateTimeFrom + "' and '" + dateTimeTo + @"' and ""RESULT"" != 'NOK' and ""RESULT"" != 'REMOVE';", connection);

                    using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var r = Convert.ToInt64(reader["COUNTER"]);
                        result1 = Convert.ToInt32(r is { } ? r : 0); 
                    }
                }
                catch
                {
                    result1 = 0;
                }

                if (result1 > 10 )
                {
                    shifts++;
                }

                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);
            }

            return shifts;
        }
    }

    public class DataFromCL
    {
        public string PN { get; set; }
        public int Qty { get; set; }
    }

    public class GroupDataCL
    {
        public List<DataFromCL> Data = new List<DataFromCL>();
        public int Sum { get; set; } = 0;
    }

}
