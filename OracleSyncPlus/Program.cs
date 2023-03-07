using System;
using System.Data;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;

namespace OracleSyncPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string oracleConnectionString = "Data Source=your_oracle_database;User ID=username;Password=password;";
            string sqlConnectionString = "Data Source=your_sql_server_database;Initial Catalog=your_database;User ID=username;Password=password;";

            // Connect to Oracle database
            using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
            {
                oracleConnection.Open();

                // Read data from Oracle table
                using (OracleCommand oracleCommand = new OracleCommand("SELECT * FROM your_oracle_table", oracleConnection))
                {
                    using (OracleDataReader oracleDataReader = oracleCommand.ExecuteReader())
                    {
                        // Connect to SQL Server database
                        using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionString))
                        {
                            sqlConnection.Open();

                            // Insert data into SQL Server table
                            using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(sqlConnection))
                            {
                                sqlBulkCopy.DestinationTableName = "your_sql_server_table";
                                sqlBulkCopy.WriteToServer(oracleDataReader);
                            }
                        }
                    }
                }
            }


        }
    }
}
