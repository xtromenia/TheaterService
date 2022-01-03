using System;
using System.Collections.Generic;
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
    }

    [ServiceContract]
    public class MovieData
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public void Movie()
        {
            Viewing = new HashSet<Viewing>();
        }
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viewing> Viewing { get; set; }
    }
}
