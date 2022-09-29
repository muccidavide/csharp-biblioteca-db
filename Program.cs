using System.Data.SqlClient;


// Creazione Lista Libri Esempio
/*List<Library.User> users = new List<Library.User>();
List<Document> documenti = new List<Document>();

Book lotr = new Book(1234567893,"Il signore degli anelli", "Fantasy", true, "A3", "Tolkien", 1920, 143, "Davide", "Mucci", "davidemucci@email.com", "lakaldlkfnalksfn", 3342512230 );
Book guerraEPace = new Book(1231567829, "Guerra e pace", "Romanzo", true, "B3", "Tolstoj", 1899, 555, "Davide", "Mucci", "davidemucci@email.com", "lakaldlkfnalksfn", 3342512230);


documenti.Add(lotr);
documenti.Add(guerraEPace);

// Creazione nuovi utenti

Library.User davide = new Library.User("davide", "mucci", "davidemucci@email.com", "lsajfapjfa", 3342512234);

users.Add(davide);
  
Library ravenna = new Library( users, documenti);

// Metodo di Ricerca
ravenna.Search();
*/


string connectionString = "Data Source=localhost;Initial Catalog=experis-biblioteca;Integrated Security=True";

SqlConnection connection = new SqlConnection(connectionString);
try
{
    connection.Open();
}
catch(SqlException ex)
{
    Console.WriteLine(ex.Message);  
}
finally
{
    connection.Close();
}

