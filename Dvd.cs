

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






public class Dvd : Document
{
    public int minutesDuration { get; set; }

    public Dvd(int isbn, string title, string section, bool available, string position, string author, int year, int duration, string firstName, string lastName, string email, string password, long phoneNumber) : base(firstName, lastName, email, password, phoneNumber, isbn, title, section, available, position, author, year, duration)
    {
        this.minutesDuration = minutesDuration;
    }
}



