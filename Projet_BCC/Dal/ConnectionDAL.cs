﻿using MySql.Data.MySqlClient;
using System;

namespace Projet_BCC
{
    class ConnectionDAL
    {
        private static string server;
        private static string database;
        private static string uid;
        private static string password;
        public static MySqlConnection connection;

        public static MySqlConnection OpenConnection()
        {
            if (connection == null) //  si la connexion est déjà ouverte, il ne la refera pas 
            {
                server = "localhost";
                database = "bcc";
                uid = "root";
                password = "";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connecter");
            }
            return connection;
        }
    }
}
