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
            //List<MovieData> movies = GetMovies();
            //MovieData movie = movies.Find(m => m.Id == id);
            MovieData movieData = new MovieData();
            using (DataModel db = new DataModel())
            {
                Movie movie = db.Movie.Find(id);
                movieData.Id = movie.Id;
                movieData.Title = movie.Title;
                movieData.Runtime = movie.Runtime;
                movieData.Description = movie.Description;
                movieData.ImgPath = movie.ImgPath;
                movieData.Genre = movie.Genre;

                List<MovieViewingData> viewings = new List<MovieViewingData>();
                foreach (Viewing viewing in movie.Viewing.OrderBy(m => m.Date))
                {
                    MovieViewingData viewingData = new MovieViewingData();
                    viewingData.Id = viewing.Id;
                    viewingData.Date = (DateTime)viewing.Date;
                    viewingData.Theater = viewing.Theater.Name;

                    int availableSeats = 0;
                    List<List<SeatData>> seats = new List<List<SeatData>>();
                    int nRows = (int)viewing.Theater.Seat.Max(m => m.Row);
                    for (int i = 0; i < nRows; i++)
                    {
                        List<SeatData> row = new List<SeatData>();
                        seats.Add(row);
                    }
                    foreach (Seat seat in viewing.Theater.Seat.OrderBy(m => m.Row).ThenBy(n => n.Number))
                    {
                        SeatData seatData = new SeatData();
                        seatData.Id = seat.Id;
                        seatData.Number = (int)seat.Number;

                        //  TODO: REDO THIS. IT DOESNT WORK
                        //seatData.IsBooked = (seat.Booking.Count > 0);
                        foreach (Booking booking in viewing.Booking)
                        {
                            if (booking.Seat.Contains(seat))
                            {
                                seatData.IsBooked = true;
                                break;
                            }
                            else
                            {
                                seatData.IsBooked = false;
                            }
                        }


                        if (!seatData.IsBooked)
                        {
                            availableSeats++;
                        }
                        seats.ElementAt((int)seat.Row - 1).Add(seatData);
                    }

                    viewingData.AvailableSeats = availableSeats;
                    viewingData.NSeats = viewing.Theater.Seat.Count();
                    viewingData.Seats = seats;
                    viewings.Add(viewingData);
                }

                movieData.Viewing = viewings;
            }
            return movieData;
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
                    //returnMovie.Viewing = movie.Viewing;
                    movies.Add(returnMovie);
                }
            }

            return movies;
        }

        //Eftersom att vi inte vet om vilket id en kund har när de försöker logga in görs en LINQ-sökning för att hitta kund med epost.
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

        //publik metod som returnerar data kring en användare som nyligen loggat in för att få tag på id och namn.
        public CustomerData GetCustomerData(Customer customer)
        {
            CustomerData customerData = new CustomerData();
            using (DataModel db = new DataModel())
            {
                var result = from cust in db.Customer
                             where cust.Email.Equals(customer.Email)
                             select cust;

                Customer custFromDb = result.FirstOrDefault();
                customerData.Id = custFromDb.Id;
                customerData.Name = custFromDb.Name;
                customerData.Email = custFromDb.Email;
                //customerData.Booking = custFromDb.Booking;
                return customerData;
            }
        }

        //publik metod som returnerar data kring en användare som nyligen loggat in, denna använder id.
        public CustomerData GetCustomerDataById(int id)
        {
            using (DataModel db = new DataModel())
            {
                Customer customerFromDb = db.Customer.Find(id);
                CustomerData customerData = new CustomerData();
                customerData.Id = customerFromDb.Id;
                customerData.Email = customerFromDb.Email;
                customerData.Name = customerFromDb.Name;
                //customerData.Booking = customerFromDb.Booking;
                customerData.Password = customerFromDb.Password;
                return customerData;
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

        //Functions for updating customer information.
        public void UpdateCustomerPass(CustomerData customer)
        {
            using (DataModel db = new DataModel())
            {
                Customer custInDb = db.Customer.Find(customer.Id);
                custInDb.Password = customer.Password;
                db.SaveChanges();
            }
        }
        //Functions for updating customer information.
        public void UpdateCustomerMail(CustomerData customer)
        {
            using (DataModel db = new DataModel())
            {
                Customer custInDb = db.Customer.Find(customer.Id);
                custInDb.Email = customer.Email;
                db.SaveChanges();
            }
        }

        //----------------------Admin------------------//
        public void RegisterMovie(Movie newMovie)
        {
            using (DataModel db = new DataModel())
            {
                db.Movie.Add(newMovie);
                db.SaveChanges();
            }
        }

        public List<CustomerData> GetCustomers()
        {
            List<CustomerData> customers = new List<CustomerData>();
            using (DataModel db = new DataModel())
            {
                foreach (var customerInDb in db.Customer)
                {
                    CustomerData customer = new CustomerData();
                    customer.Id = customerInDb.Id;
                    customer.Name = customerInDb.Name;
                    customer.Email = customerInDb.Email;
                    //customer.Booking = customerInDb.Booking; Temporary fix for problem in admin view.
                    customers.Add(customer);
                }

                return customers;
            }
        }

        public void RemoveCustomer(int id)
        {
            using (DataModel db = new DataModel())
            {
                Customer customer = db.Customer.Find(id);

                RemoveBookings(customer);

                db.Customer.Remove(customer);

                db.SaveChanges();
            }
        }

        private void RemoveBookings(Customer customer)
        {
            using (DataModel db = new DataModel())
            {

                List<BookingData> bookings = GetCustomersBookings(customer.Id);

                foreach(BookingData booking in bookings)
                {
                    Booking bookingInDb = db.Booking.Find(booking.Id);
                    db.Booking.Remove(bookingInDb);
                }

                db.SaveChanges();
            }
        }

        public List<TheaterData> GetTheaters()
        {
            using (DataModel db = new DataModel())
            {
                List<TheaterData> theaters = new List<TheaterData>();
                foreach (var theater in db.Theater)
                {
                    TheaterData theaterData = new TheaterData();
                    theaterData.Id = theater.Id;
                    theaterData.Name = theater.Name;
                    //theaterData.Seat = theater.Seat; Temporary fix for problem in admin view.
                    theaters.Add(theaterData);
                }
                return theaters;
            }
        }

        public void RegisterViewing(Viewing newViewing)
        {
            using (DataModel db = new DataModel())
            {
                db.Viewing.Add(newViewing);
                db.SaveChanges();
            }
        }

        //  Get all bookings for a specific customer
        public List<BookingData> GetCustomersBookings(int customerId)
        {
            List<BookingData> data = new List<BookingData>();
            using (DataModel db = new DataModel())
            {
                Customer customer = db.Customer.Find(customerId);
                List<Booking> bookings = customer.Booking.ToList();
                foreach (Booking booking in bookings)
                {
                    BookingData bookingData = new BookingData();
                    bookingData.Id = booking.Id;

                    BookingViewingData viewingData = new BookingViewingData();
                    viewingData.Id = booking.Viewing.Id;
                    viewingData.Date = (DateTime)booking.Viewing.Date;
                    viewingData.TheaterName = booking.Viewing.Theater.Name;

                    MovieData movieData = new MovieData();
                    movieData.Id = booking.Viewing.Movie.Id;
                    movieData.Title = booking.Viewing.Movie.Title;
                    movieData.Runtime = booking.Viewing.Movie.Runtime;
                    //  If neccesary, add more data to moviedata object, such as description, genre, etc

                    viewingData.Movie = movieData;
                    bookingData.Viewing = viewingData;

                    List<int> seats = new List<int>();
                    foreach (Seat seat in booking.Seat)
                    {
                        seats.Add((int)seat.Number);
                    }
                    bookingData.Seats = seats;

                    data.Add(bookingData);
                }
            }
            return data;
        }

        public bool BookViewing(BookingSubmissionData bookingData)
        {
            //Check seat availability for viewing
            foreach (int seatid in bookingData.SeatIds)
            {
                if (!SeatAvailable(seatid, bookingData.ViewingId))
                {
                    return false;
                }
            }
            //Book seats
            using (DataModel db = new DataModel())
            {
                Booking booking = new Booking();
                booking.CustomerID = bookingData.CustomerId;
                booking.Customer = db.Customer.Find(bookingData.CustomerId);
                booking.ViewingID = bookingData.ViewingId;
                booking.Viewing = db.Viewing.Find(bookingData.ViewingId);
                List<Seat> seats = new List<Seat>();
                foreach (int seatid in bookingData.SeatIds)
                {
                    Seat seat = db.Seat.Find(seatid);
                    seats.Add(seat);
                }
                booking.Seat = seats;
                db.Booking.Add(booking);
                db.SaveChanges();
            }
            return true;
        }

        private bool SeatAvailable(int seatid, int viewingid)
        {
            using (DataModel db = new DataModel())
            {
                Seat seat = db.Seat.Find(seatid);
                Viewing viewing = db.Viewing.Find(viewingid);
                foreach (Booking booking in viewing.Booking)
                {
                    if (booking.Seat.Contains(seat))
                    {
                        return false;
                    }
                }
                return true;
            }
        }


    }
}
