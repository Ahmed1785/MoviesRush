using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesRush.Models;
using System.Web;

namespace MoviesRush.ViewModels
{
    public class RandomMovieViewModel
    {
        //public int ID { get; set; }
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}
