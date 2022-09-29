

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

// Libreria
public partial class Library
{
    public string Title { get; set; }
    // Lista Utenti
    protected List<User> users;
    // Lista Documenti
    protected List<Document> documents;

    // Costruttore
    public Library(List<User> users, List<Document> documents)
    {
        this.users = users;
        this.documents = documents;

    }
    // Metodi Libreria

    public void Search()
    {
        Console.WriteLine("Inserisci il titolo o codice");

        string answer = Console.ReadLine(); 

        foreach (Document document in documents)
        {
            if(document.title.Contains(answer))
            {
                Console.WriteLine($"Il Libro {document.title} è presente nella libreria");
            }
            else
            {
                Console.WriteLine($"Il Libro {answer} non è presente nella libreria");
            }
        }
    }


}


