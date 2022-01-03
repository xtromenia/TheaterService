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
    }
}
