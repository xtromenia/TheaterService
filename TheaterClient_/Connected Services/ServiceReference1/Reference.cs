﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieData", Namespace="http://schemas.datacontract.org/2004/07/TheaterService")]
    public partial class MovieData : object
    {
        
        private string DescriptionField;
        
        private string GenreField;
        
        private int IdField;
        
        private string ImgPathField;
        
        private int RuntimeField;
        
        private string TitleField;
        
        private ServiceReference1.Viewing[] ViewingField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genre
        {
            get
            {
                return this.GenreField;
            }
            set
            {
                this.GenreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImgPath
        {
            get
            {
                return this.ImgPathField;
            }
            set
            {
                this.ImgPathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Runtime
        {
            get
            {
                return this.RuntimeField;
            }
            set
            {
                this.RuntimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Viewing[] Viewing
        {
            get
            {
                return this.ViewingField;
            }
            set
            {
                this.ViewingField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Viewing", Namespace="http://schemas.datacontract.org/2004/07/TheaterService")]
    public partial class Viewing : object
    {
        
        private ServiceReference1.Booking[] BookingField;
        
        private System.Nullable<System.DateTime> DateField;
        
        private int IdField;
        
        private ServiceReference1.Movie MovieField;
        
        private System.Nullable<int> MovieIDField;
        
        private ServiceReference1.Theater TheaterField;
        
        private System.Nullable<int> TheaterIDField;
        
        private System.Nullable<int> TimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Booking[] Booking
        {
            get
            {
                return this.BookingField;
            }
            set
            {
                this.BookingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Movie Movie
        {
            get
            {
                return this.MovieField;
            }
            set
            {
                this.MovieField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MovieID
        {
            get
            {
                return this.MovieIDField;
            }
            set
            {
                this.MovieIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Theater Theater
        {
            get
            {
                return this.TheaterField;
            }
            set
            {
                this.TheaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TheaterID
        {
            get
            {
                return this.TheaterIDField;
            }
            set
            {
                this.TheaterIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Time
        {
            get
            {
                return this.TimeField;
            }
            set
            {
                this.TimeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/TheaterService")]
    public partial class Movie : object
    {
        
        private string DescriptionField;
        
        private string GenreField;
        
        private int IdField;
        
        private string ImgPathField;
        
        private int RuntimeField;
        
        private string TitleField;
        
        private ServiceReference1.Viewing[] ViewingField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genre
        {
            get
            {
                return this.GenreField;
            }
            set
            {
                this.GenreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImgPath
        {
            get
            {
                return this.ImgPathField;
            }
            set
            {
                this.ImgPathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Runtime
        {
            get
            {
                return this.RuntimeField;
            }
            set
            {
                this.RuntimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Viewing[] Viewing
        {
            get
            {
                return this.ViewingField;
            }
            set
            {
                this.ViewingField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Theater", Namespace="http://schemas.datacontract.org/2004/07/TheaterService")]
    public partial class Theater : object
    {
        
        private int IdField;
        
        private string NameField;
        
        private ServiceReference1.Seat[] SeatField;
        
        private ServiceReference1.Viewing[] ViewingField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Seat[] Seat
        {
            get
            {
                return this.SeatField;
            }
            set
            {
                this.SeatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Viewing[] Viewing
        {
            get
            {
                return this.ViewingField;
            }
            set
            {
                this.ViewingField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Booking", Namespace="http://schemas.datacontract.org/2004/07/TheaterService")]
    public partial class Booking : object
    {
        
        private ServiceReference1.Customer CustomerField;
        
        private System.Nullable<int> CustomerIDField;
        
        private int IdField;
        
        private ServiceReference1.Seat[] SeatField;
        
        private ServiceReference1.Viewing ViewingField;
        
        private System.Nullable<int> ViewingIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Customer Customer
        {
            get
            {
                return this.CustomerField;
            }
            set
            {
                this.CustomerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> CustomerID
        {
            get
            {
                return this.CustomerIDField;
            }
            set
            {
                this.CustomerIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Seat[] Seat
        {
            get
            {
                return this.SeatField;
            }
            set
            {
                this.SeatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Viewing Viewing
        {
            get
            {
                return this.ViewingField;
            }
            set
            {
                this.ViewingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ViewingID
        {
            get
            {
                return this.ViewingIDField;
            }
            set
            {
                this.ViewingIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/TheaterService")]
    public partial class Customer : object
    {
        
        private ServiceReference1.Booking[] BookingField;
        
        private string EmailField;
        
        private int IdField;
        
        private string PasswordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Booking[] Booking
        {
            get
            {
                return this.BookingField;
            }
            set
            {
                this.BookingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Seat", Namespace="http://schemas.datacontract.org/2004/07/TheaterService")]
    public partial class Seat : object
    {
        
        private ServiceReference1.Booking[] BookingField;
        
        private int IdField;
        
        private System.Nullable<int> NumberField;
        
        private System.Nullable<int> RowField;
        
        private ServiceReference1.Theater TheaterField;
        
        private System.Nullable<int> TheaterIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Booking[] Booking
        {
            get
            {
                return this.BookingField;
            }
            set
            {
                this.BookingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Number
        {
            get
            {
                return this.NumberField;
            }
            set
            {
                this.NumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Row
        {
            get
            {
                return this.RowField;
            }
            set
            {
                this.RowField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Theater Theater
        {
            get
            {
                return this.TheaterField;
            }
            set
            {
                this.TheaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TheaterID
        {
            get
            {
                return this.TheaterIDField;
            }
            set
            {
                this.TheaterIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMovies", ReplyAction="http://tempuri.org/IService1/GetMoviesResponse")]
        ServiceReference1.MovieData[] GetMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMovies", ReplyAction="http://tempuri.org/IService1/GetMoviesResponse")]
        System.Threading.Tasks.Task<ServiceReference1.MovieData[]> GetMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMovie", ReplyAction="http://tempuri.org/IService1/GetMovieResponse")]
        ServiceReference1.MovieData GetMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMovie", ReplyAction="http://tempuri.org/IService1/GetMovieResponse")]
        System.Threading.Tasks.Task<ServiceReference1.MovieData> GetMovieAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegisterCustomer", ReplyAction="http://tempuri.org/IService1/RegisterCustomerResponse")]
        void RegisterCustomer(ServiceReference1.Customer newCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegisterCustomer", ReplyAction="http://tempuri.org/IService1/RegisterCustomerResponse")]
        System.Threading.Tasks.Task RegisterCustomerAsync(ServiceReference1.Customer newCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoginCustomer", ReplyAction="http://tempuri.org/IService1/LoginCustomerResponse")]
        bool LoginCustomer(ServiceReference1.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoginCustomer", ReplyAction="http://tempuri.org/IService1/LoginCustomerResponse")]
        System.Threading.Tasks.Task<bool> LoginCustomerAsync(ServiceReference1.Customer customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceReference1.MovieData[] GetMovies()
        {
            return base.Channel.GetMovies();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.MovieData[]> GetMoviesAsync()
        {
            return base.Channel.GetMoviesAsync();
        }
        
        public ServiceReference1.MovieData GetMovie(int id)
        {
            return base.Channel.GetMovie(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.MovieData> GetMovieAsync(int id)
        {
            return base.Channel.GetMovieAsync(id);
        }
        
        public void RegisterCustomer(ServiceReference1.Customer newCustomer)
        {
            base.Channel.RegisterCustomer(newCustomer);
        }
        
        public System.Threading.Tasks.Task RegisterCustomerAsync(ServiceReference1.Customer newCustomer)
        {
            return base.Channel.RegisterCustomerAsync(newCustomer);
        }
        
        public bool LoginCustomer(ServiceReference1.Customer customer)
        {
            return base.Channel.LoginCustomer(customer);
        }
        
        public System.Threading.Tasks.Task<bool> LoginCustomerAsync(ServiceReference1.Customer customer)
        {
            return base.Channel.LoginCustomerAsync(customer);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:32941/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}
