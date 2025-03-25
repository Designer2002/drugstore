using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace drugstore
{
    internal class Jsoner
    {
        public static DataTable DeSerializeTable(byte[] data)
        {

            if (Encoding.UTF8.GetString(data).StartsWith("\"") && Encoding.UTF8.GetString(data).EndsWith("\""))
            {
                System.Windows.Forms.MessageBox.Show("a");
                //System.Windows.Forms.MessageBox.Show(Encoding.UTF8.GetString(data));
                return (DataTable)JsonConvert.DeserializeObject(Encoding.ASCII.GetString(data).Substring(1, Encoding.ASCII.GetString(data).Length - 2), (typeof(DataTable)));
            }
            if (Encoding.UTF8.GetString(data) != "[]" || Encoding.UTF8.GetString(data).Contains("]"))
            {
                //System.Windows.Forms.MessageBox.Show(Encoding.UTF8.GetString(data));
                return (DataTable)JsonConvert.DeserializeObject(Encoding.ASCII.GetString(data), (typeof(DataTable)));

            }
            else
            {
                //System.Windows.Forms.MessageBox.Show(Encoding.UTF8.GetString(data));
                return new DataTable();
            }
        }
        
    }
}
