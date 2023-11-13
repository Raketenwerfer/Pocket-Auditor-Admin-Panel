﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_Audior_Admin_Panel.Auxiliaries
{
    public class DatabaseInitiator
    {

        private string connectionString;
        public string server, database, username, password;

        public DatabaseInitiator(string _server, string _db, string _username, string _password)
        {
            // Replace these values with your actual database information
            server = _server;
            database = _db;
            username = _username;
            password = _password;

            connectionString = $"Server={server};Database={database};User ID={username};Password={password};";
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it, show a message)
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
