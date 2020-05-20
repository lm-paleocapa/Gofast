namespace OfficialChat.Lib.Client
{
    using System;
    public class Messages
    {
        public string from { get; set; } // Da chi viene il messaggio.
        public string to { get; set; } // Verso che deve andare il messaggio.
        public string date { get; set; } // Orario di invio del messaggio.
        public string message { get; set; } // Stringa della messaggio.
        public string messageType { get; set; } // Che tipo di messaggio è (testo, audio, video, immagine).
    }
}