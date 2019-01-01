using Microsoft.EntityFrameworkCore;
using MoviesRush.ViewModels;


namespace MoviesRush.Models
{
    public class MainContext : DbContext 
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) { }
        public DbSet<MoviesRush.Models.Customer> Customer{ get; set; }
        public DbSet<MoviesRush.Models.Movie> Movie { get; set; }
        public DbSet<MoviesRush.Models.MembershipType> MembershipType { get; set; }
        public DbSet<MoviesRush.Models.Genre> Genre { get; set; }
        public DbSet<MoviesRush.ViewModels.NewMovieViewModel> NewMovieViewModel { get; set; }
        //public DbSet<MoviesRush.ViewModels.RandomMovieViewModel> RandomMovieViewModel { get; set; }
    }
}
