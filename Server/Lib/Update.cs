namespace Server.Lib
{
    using MySql.Data.MySqlClient;
    using System.Collections.Generic;
    using System.Threading;
    using Newtonsoft.Json;
    using System.Drawing;

    class Start
    {
        public static void OnServerOpen(MySqlConnection cnn)
        {
            string query;
            MySqlCommand cmd;
            MySqlDataReader reader;

            query = "select user from account;";
            cmd = new MySqlCommand(query, cnn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Obj.WebsocketUsers user = new Obj.WebsocketUsers
                {
                    SocketConnected = false,
                    user = reader[0].ToString()
                };
                Program.usersConnected.Add(user);
            }
            reader.Close();
        }
    }
    class Update
    {
        public static void Start()
        {
            new Thread(() =>
            {
            }).Start();

            new Thread(() =>
            {
            }).Start(); // Aggiungere il controllo per i nuovi amici
        }
    }
}