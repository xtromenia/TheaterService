using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TheaterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        //Hämtar en specifik film med hjälp av id för att visa upp i filmvyn på front-end.
        public MovieData GetMovie(int id)
        {
            List<MovieData> movies = GetMovies();
            MovieData movie = movies.Find(m => m.Id == id);
            return movie;
        }

        //Funktion som hämtar alla registrerade filmer i databasen och skickar över till front-end i form av MovieData objekt.
        public List<MovieData> GetMovies()
        {
            List<MovieData> movies = new List<MovieData>();

            using (DataModel db = new DataModel())
            {
                foreach (var movie in db.Movie.ToList())
                {
                    MovieData returnMovie = new MovieData();
                    returnMovie.Id = movie.Id;
                    returnMovie.Title = movie.Title;
                    returnMovie.Runtime = movie.Runtime;
                    returnMovie.Description = movie.Description;
                    returnMovie.ImgPath = movie.ImgPath;
                    returnMovie.Genre = movie.Genre;
                    returnMovie.Viewing = movie.Viewing;
                    movies.Add(returnMovie);
                }
            }

            return movies;
        }

        //Eftersom att vi inte vet om vilket id en kund har när de försöker logga in görs en LINQ-sökning för att hitta kund med epost.
        //Private då den enbart behövs på back-end och inte front-end.
        private Customer GetCustomer(Customer customer)
        {
            using (DataModel db = new DataModel())
            {
                var result = from cust in db.Customer
                             where cust.Email.Equals(customer.Email)
                             select cust;

                Customer custInDb = result.FirstOrDefault();
                return custInDb;
            }
        }

        //Logik som kontrollerar ifall det användare matat in i loginvy på front-end är korrekt, returnerar antingen true eller false.
        public bool LoginCustomer(Customer customer)
        {
            Customer custInDb = GetCustomer(customer);

                if (custInDb.Email.Equals(customer.Email) && 
                    custInDb.Password.Equals(customer.Password))
                {
                    return true;
                }
                else
                    return false;   
        }

        //Tar emot ett nyskapat objekt från registreringsvyn på front-end och registrerar i databastabell.
        public void RegisterCustomer(Customer newCustomer)
        {
            using (DataModel db = new DataModel())
            {
                db.Customer.Add(newCustomer);
                db.SaveChanges();
            }
        }
    }
}
