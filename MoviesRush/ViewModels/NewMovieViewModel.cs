using MoviesRush.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRush.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public byte? GenreId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? Stock { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Add Movie" : "Edit Movie";
            }
        }
        public NewMovieViewModel()
        {
            Id = 0;
        }
        public NewMovieViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            Stock = movie.Stock;
            GenreId = movie.GenreId;
        }
    }
}
