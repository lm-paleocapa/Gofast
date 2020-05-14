namespace Server.Lib
{
    using MySql.Data.MySqlClient;
    using System.Collections.Generic;
    using System.Threading;
    using Newtonsoft.Json;
    using System.Drawing;
    class Start
    {
        public static void OnServerOpen(MySqlConnection mainCnn)
        {
            string query;
            MySqlCommand cmd;
            MySqlDataReader reader;

            query = "select user from account;";
            cmd = new MySqlCommand(query, mainCnn);
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
}