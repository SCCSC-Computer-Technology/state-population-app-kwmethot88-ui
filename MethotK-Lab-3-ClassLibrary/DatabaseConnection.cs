using System;
using System.Data;
using System.Data.OleDb;

namespace MethotK_Lab_3_ClassLibrary
{
    public class DatabaseConnection
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rltka\source\repos\Lab-3-Database-Access.accdb;Persist Security Info=False;";

        public DataTable GetStates()
        {
            DataTable table = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM [State Database]";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public DataTable GetStateByName(string stateName)
        {
            DataTable table = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM [State Database] WHERE [State] = ?";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@State", stateName);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }
    }
}