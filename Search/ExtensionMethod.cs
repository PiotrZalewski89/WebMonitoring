using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace WebMonitoring.Search
{
    public static class ExtensionMethod
    {
        //public static string ToCSV(this DataTable dtDataTable)
        //{

        //    string value = string.Empty;
        //    string csv = string.Empty;

        //    for (int i = 0; i < dtDataTable.Columns.Count; i++)
        //    {
        //        value +=  dtDataTable.Columns[i];
        //        if (i < dtDataTable.Columns.Count - 1)
        //        {
        //            value += ";";
        //        }
        //    }
            
        //    foreach (DataRow dr in dtDataTable.Rows)
        //    {
        //        var columnCount = dtDataTable.Columns.Count;
        //        for (int i = 0; i < columnCount; i++)
        //        {
        //            if (!Convert.IsDBNull(dr[i]))
        //            {
        //                value += dr[i].ToString();
        //                if (value.Contains(';'))
        //                {
        //                    csv += value;
        //                }
        //            }
        //        }
        //    }

        //    return csv;
        //}

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, typeof(string));
            }

            object[] values = new object[props.Count];

            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public static DataTable ToDataTable<T>(this IQueryable<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, typeof(string));
            }

            object[] values = new object[props.Count];

            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, typeof(string));
            }

            object[] values = new object[props.Count];

            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public static string ConvertDataTableToHTMLTable(this DataTable dt)
        {
            return @"<thead><tr> " + string.Join("", dt.Columns.Cast<DataColumn>().Select(dc => @"<td>" + dc.ColumnName + @"</td>")) + @"</tr></thead>" +
            @"<tbody><tr>" + string.Join(@"</tr><tr>", dt.AsEnumerable().Select(row => @"<td>" + string.Join(@"</td><td>", row.ItemArray) + @"</td>").ToArray()) + @"</tr></tbody>";

        }

        public static string ConvertDataTableToText(this DataTable dt)
        {
            return string.Join(";", dt.Columns.Cast<DataColumn>().Select(dc => dc.ColumnName)) + Environment.NewLine
            + string.Join(Environment.NewLine, dt.AsEnumerable().Select(row => string.Join(@";", row.ItemArray)).ToArray());

        }

        public static string WriteToTable<T>(this DataTable table, T[] result)
        {
            table = result.ToDataTable();
            return table.ConvertDataTableToHTMLTable();
        }

        public static byte[] WriteToFile<T>(this DataTable table, IQueryable<T> result)
        {
            table = result.ToDataTable();
            var text = table.ConvertDataTableToText();
            byte[] bytesText = Encoding.UTF8.GetBytes(text);
            return bytesText;
        }

        public static byte[] WriteToFile<T>(this DataTable table, IEnumerable<T> result)
        {
            table = result.ToDataTable();
            var text = table.ConvertDataTableToText();
            byte[] bytesText = Encoding.UTF8.GetBytes(text);
            return bytesText;
        }

        public static string WriteTextToFile<T>(this DataTable table, IEnumerable<T> result)
        {
            table = result.ToDataTable();
            return table.ConvertDataTableToText();
        }

        public static byte[] GenerationFile(IEnumerable<string> Table, IEnumerable<string> fileName)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    int i = 0;
                    foreach (var t in Table)
                    {
                        var file = archive.CreateEntry(fileName.ElementAt(i++) + ".csv");
                        using (var streamWriter = new StreamWriter(file.Open()))
                        {
                            streamWriter.Write(t);
                        }
                    }
                }
                return memoryStream.ToArray();
            }
        }

    }
}
