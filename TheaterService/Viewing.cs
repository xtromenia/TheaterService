namespace TheaterService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Viewing")]
    public partial class Viewing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Viewing()
        {
            Booking = new HashSet<Booking>();
        }

        public int Id { get; set; }

        public int? TheaterID { get; set; }

        public int? MovieID { get; set; }

        public DateTime? Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Theater Theater { get; set; }
    }
}
