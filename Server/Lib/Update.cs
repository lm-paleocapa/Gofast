namespace Server.Lib
{
    using MySql.Data.MySqlClient;
    using System.Collections.Generic;
    using System.Threading;
    using Newtonsoft.Json;
    using System.Drawing;
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