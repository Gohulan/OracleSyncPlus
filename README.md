===================================================================================================================
# OracleSyncPlus - Oracle to SQL Server Data Migration
===================================================================================================================

This is a C# console application that migrates data from an Oracle database to a SQL Server database. The application uses the Oracle.DataAccess and Microsoft.Data.SqlClient packages to connect to the Oracle and SQL Server databases, respectively. The application reads data from an Oracle table and inserts it into a SQL Server table using SqlBulkCopy.

===================================================================================================================
Getting Started
===================================================================================================================

To get started with the application, follow these steps:

Clone this repository to your local machine.
Open the solution file (OracleToSqlServerMigrator.sln) in Visual Studio.
Build the solution to ensure that all packages are installed and the code compiles without errors.
Modify the source code to set the correct connection strings and table names for your Oracle and SQL Server databases.
Run the application to start the data migration process.

===================================================================================================================
Prerequisites
===================================================================================================================

To run the application, you will need the following software installed on your machine:

.NET Framework 4.6.1 or later
Visual Studio 2017 or later

===================================================================================================================
Configuration
===================================================================================================================
To configure the application for your Oracle and SQL Server databases, modify the following lines of code in the Program.cs file:

string oracleConnectionString = "Data Source=your_oracle_database;User ID=username;Password=password;";
string sqlConnectionString = "Data Source=your_sql_server_database;Initial Catalog=your_database;User ID=username;Password=password;";
string oracleTableName = "your_oracle_table";
string sqlTableName = "your_sql_server_table";
Replace the placeholders your_oracle_database, your_sql_server_database, username, password, your_oracle_table, and your_sql_server_table with the actual database and table names for your migration.

===================================================================================================================
License
===================================================================================================================

This project is licensed under the MIT License - see the LICENSE file for details.

===================================================================================================================
Acknowledgments
===================================================================================================================

This project was inspired by the need to migrate data from an Oracle database to a SQL Server database. Special thanks to the developers of the Oracle.DataAccess and Microsoft.Data.SqlClient packages for providing easy-to-use data providers for Oracle and SQL Server, respectively.



