

/*Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
cognome,
nome,
email,
password,
recapito telefonico,
Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
titolo,
anno,
settore(storia, matematica, economia, …),
stato(In Prestito, Disponibile),
uno scaffale in cui è posizionato,
un autore (Nome, Cognome).
Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
*/

// biblioteca
//documenti
//utenti

// Documenti estende Utente

using System.Data.SqlClient;

public class Document : Library.User
{
    public int isbn { get; set; }
    public string title { get; set; }
    public string section { get; set; }
    public bool available { get; set; }
    public string position { get; set; }
    public string author { get; set; }
    public int year { get; set; }
    public int duration { get; set; }

    public Document (int isbn, string title, string section, bool available, string position, string author, int year, int duration, string firstName, string lastName, string email, string password, long phoneNumber): base(firstName, lastName, email, password,phoneNumber)
    {
        this.isbn = isbn;
        this.title = title;
        this.section = section;
        this.available = available;
        this.position = position;
        this.author = author;
        this.year = year;
        this.duration = duration;
    }

    public Document(string firstName, string lastName, string email, string password, long phoneNumber, int isbn, string title, string section, bool available, string position, string author, int year, int duration) : base(firstName, lastName, email, password, phoneNumber)
    {
    }

    public static void Print(SqlDataReader reader)
    {
        Console.WriteLine($"Title: {reader.GetString(1)}");
        Console.WriteLine($"Genre: {reader.GetString(2)}");
        Console.WriteLine($"Position: {reader.GetString(3)}");
        Console.WriteLine($"Author: {reader.GetString(4)}");
        Console.WriteLine("");
    }
}


