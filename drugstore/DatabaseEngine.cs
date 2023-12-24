using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace drugstore
{
    class DatabaseEngine
    {
        public static string ConnectionString { get; set; }
        public static string Command { get; set; }
        public static NpgsqlConnection Connection { get; set; }
        DatabaseEngine()
        {
            ConnectionString = "Host=localhost;Username=postgres;Password=1234;Database=drugs";
            Connection = new NpgsqlConnection(ConnectionString);
        }
        public async void Open()
        {
            try
            {
                await Connection.OpenAsync();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async void Close()
        {
            await Connection.CloseAsync();
        }
        public async void Do(string command)
        {
            Command = command;
            var nc = new NpgsqlCommand(Command, Connection);
            try
            {
                await nc.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void FillTable(DataGrid grid, string command)
        {
            Command = command;
            var nc = new NpgsqlCommand(Command, Connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = nc;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            
            grid.DataSource = table;
        }
    }
}
