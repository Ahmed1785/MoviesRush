using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRush.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int Stock { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}
