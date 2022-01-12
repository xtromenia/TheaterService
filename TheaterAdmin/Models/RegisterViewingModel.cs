using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterAdmin.Models
{
    public class RegisterViewingModel
    {
        public Viewing Viewing { get; set; }
        public List<MovieData> Movies { get; set; }
        public List<TheaterData> Theaters { get; set; }
    }
}
