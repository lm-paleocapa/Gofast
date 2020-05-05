namespace OfficialChat.Lib.Client
{
    using System;
    using System.Collections.Generic;
    public class JSON
    {
            public int id { get; set; } // Identifica la funzione.
            public string username { get; set; } // Identifica L'utente che sta provando ad eseguire l'accesso.
            public bool uok { get; set; } // Identifica se il nome utente è presente nel db.
            public string password { get; set; } // Password che è stata immessa nel client.
            public bool pok { get; set; } // Identifica se la password è corretta nel db.
            public int age { get; set; } // Identifica l'età dell'utente.
            public string image { get; set; } // Immagine profilo dell'utente.
            public List<FRIENDS> friends { get; set; } // Lista di amici dell'utente.
            public string from { get; set; } // Da chi viene il messaggio.
            public string to { get; set; } // Verso che deve andare il messaggio.
            public DateTime date { get; set; } // Orario di invio del messaggio.
            public string message { get; set; } // Stringa della messaggio.
            public string messageType { get; set; } // Che tipo di messaggio è (testo, audio, video, immagine).
    }
}