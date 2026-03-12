using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class CheckBoxLineWS10 : BaseSearchClass
    {
        private Codes Codes { get; set; }
        private string ConnectionString => "Host=172.16.30.20;Port=5432;Database=postgres;Username=cl;Password=cl1234";

        public bool All { get; set; }
        public bool WeldingCell { get; set; }
        public bool Marking { get; set; }
        public bool Wiremash { get; set; }
        public bool Clipping { get; set; }
        public bool ControlLoop { get; set; }


        public CheckBoxLineWS10()
        {
            FindData = new List<string>();
        }

        public async Task SelectAsync(string code)
        {
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();

                if (!string.IsNullOrEmpty(code))
                {
                    using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT * FROM ""PORSCHE"".""V_tbl_CONTROL_LOOP_ALL"" where ""CODE"" = '" + code + "';", connection); 
                    using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        var columnSchema = await reader.GetColumnSchemaAsync();

                        for(int i = 0; i < reader.FieldCount; i++)
                        {
                            var fieldValue = await reader.GetFieldValueAsync<object[]>(i);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ;
            }
        }
    }



}
