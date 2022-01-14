using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TheaterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<MovieData> GetMovies();
        
        [OperationContract]
        MovieData GetMovie(int id);

        [OperationContract]
        void RegisterCustomer(Customer newCustomer);
       
        [OperationContract]
        bool LoginCustomer(Customer customer);

        [OperationContract]
        CustomerData GetCustomerData(Customer customer);

        [OperationContract]
        CustomerData GetCustomerDataById(int id);

        [OperationContract]
        void UpdateCustomerPass(CustomerData customer);

        [OperationContract]
        void UpdateCustomerMail(CustomerData customer);

        [OperationContract]
        List<BookingData> GetCustomersBookings(int customerId);

        [OperationContract]
        bool BookViewing(BookingSubmissionData bookingData);


        //Admin
        [OperationContract]
        void RegisterMovie(Movie newMovie);

        [OperationContract]
        void UpdateMovie(MovieData updatedInfo);

        [OperationContract]
        void RemoveMovie(int id);

        [OperationContract]
        void RegisterViewing(Viewing newViewing);

        [OperationContract]
        List<CustomerData> GetCustomers();

        [OperationContract]
        void RemoveCustomer(int id);

        [OperationContract]
        List<TheaterData> GetTheaters();
    }




    [ServiceContract]
    public class MovieData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int Runtime { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string ImgPath { get; set; }
        [DataMember]
        public string Genre { get; set; }
        [DataMember]
        public List<MovieViewingData> Viewing { get; set; }
    }

    //  ViewingData class specifically intended for the client booking functionality
    [ServiceContract]
    public class MovieViewingData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Theater { get; set; }
        [DataMember]
        public int AvailableSeats { get; set; }
        [DataMember]
        public int NSeats { get; set; }
        [DataMember]
        public List<List<SeatData>> Seats { get; set; }
    }

    [ServiceContract]
    public class SeatData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public bool IsBooked { get; set; }
    }




    [ServiceContract]
    public class CustomerData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public void Customer()
        {
            Booking = new HashSet<Booking>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }
    }
    [ServiceContract]
    public class TheaterData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public void Theater()
        {
            Seat = new HashSet<Seat>();
            Viewing = new HashSet<Viewing>();
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Name { get; set; }

        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seat> Seat { get; set; }

        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viewing> Viewing { get; set; }
    }




    [ServiceContract]
    public class BookingData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public BookingViewingData Viewing { get; set; }
        [DataMember]
        public List<int> Seats { get; set; }
    }

    //  Subset av ViewingData enbart avsedd för bookings, avskalad därefter
    [ServiceContract]
    public class BookingViewingData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public MovieData Movie { get; set; }
        [DataMember]
        public string TheaterName { get; set; }
    }



    //  Data object to send to service to submit booking
    [ServiceContract]
    public class BookingSubmissionData
    {
        [DataMember]
        public int ViewingId { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public List<int> SeatIds { get; set; }
    }
}
