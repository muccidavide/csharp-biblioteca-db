using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Transactions;

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

Console.WriteLine("Vuoi cercare[1] o aggiungere[2] un documento?");
int userResponse;
try
{
    userResponse = Convert.ToInt32(Console.ReadLine());

    switch (userResponse)
    {
        case 1:

            try
            {
                connection.Open();

                Console.WriteLine("Inserisci il titolo");

                string answer = Console.ReadLine();
                string query = $"SELECT * FROM Documents LEFT JOIN Books ON Books.id = Documents.id LEFT JOIN Dvd ON Dvd.id = Documents.id WHERE Documents.Title like @Title ";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add(new SqlParameter("@Title", answer));

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Document.Print(reader);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            break;
        case 2:


            try
            {
                connection.Open();

                Console.WriteLine("Inserisci il titolo");
                string title = Console.ReadLine();
                Console.WriteLine("Inserisci il genere");
                string section = Console.ReadLine();

                string charRandom = GetLetter().ToString();
                Random r = new Random();
                int randomInt = r.Next(1, 10);

                string position = randomInt + charRandom;

                Console.WriteLine("Inserisci l'Autore");
                string author = Console.ReadLine();
                Console.WriteLine("Inserisci il anno di pubblicazione");
                string releaseYearInput = Console.ReadLine();
                /*
                 transaction prova
                 */
                int releaseYear = Int32.Parse(releaseYearInput);

                string query = "INSERT INTO Documents (Title, Section, Position, Author, ReleaseYear) VALUES(@Title, @Section, @Position, @Author, @ReleaseYear)";
                SqlCommand sqlCommand = new SqlCommand(query, connection);

                sqlCommand.Parameters.Add(new SqlParameter("@Title", title));
                sqlCommand.Parameters.Add(new SqlParameter("@Section", section));
                sqlCommand.Parameters.Add(new SqlParameter("@Position", position));
                sqlCommand.Parameters.Add(new SqlParameter("@Author", author));
                sqlCommand.Parameters.Add(new SqlParameter("@ReleaseYear", releaseYear));

                int affectedRows = sqlCommand.ExecuteNonQuery();
                Console.WriteLine(affectedRows);
            


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            break;


    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}






static char GetLetter()
{
    string chars = "ABCDEF";
    Random rand = new Random();
    int num = rand.Next(0, chars.Length);
    return chars[num];
}