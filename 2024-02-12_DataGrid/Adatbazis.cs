using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;

namespace _2024_02_12_DataGrid
{
    internal class Adatbazis
    {
        MySqlConnection connection;
        MySqlCommand command;
        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = "192.168.41.1";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orszagok";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                nyit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                zar();
            }
        }

        private void zar()
        {
            if(connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    

        private void nyit()
        {
            if(connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        internal List<Orszag> orszagok()
        {
            command.CommandText = "SELECT orsz2.kontinens, orszag, fovaros, terulet FROM orsz2 WHERE 1";
            List<Orszag> orszagok = new List<Orszag>();
            try
            {
                nyit();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    orszagok.Add(new Orszag(reader.GetString("orszag"), reader.GetString("kontinens"), reader.GetString("fovaros"), reader.GetDecimal("terulet")));
                }
                return orszagok;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                zar();
            }
        }
    }
}
