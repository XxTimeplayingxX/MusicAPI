namespace MusicAPI.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        //Agregamos este campo, pero nos va a salir el error, 
        //Es por eso que debemos de usar Migrations
        public string Duration { get; set; }

    }
}
