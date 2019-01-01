using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesRush.Models;
using MoviesRush.ViewModels;

namespace MoviesRush.Controllers
{
    public class MovieController : Controller

    {

        private MainContext _context;

        //Creating a constructor of the private field and making it an instance of the MainContext 
        public MovieController(MainContext context)
        {
            _context = context;
        }

        [Route("movies/released/{{year}}/{{month:regex(\\d{{4}}):range(1, 12)}}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ViewResult Index()
        {
            var movies = _context.Movie.ToList();

            return View(movies);
        }

        public ActionResult Create()
        {
            var genres = _context.Genre.ToList();
            var viewModel = new NewMovieViewModel
            {
                Genre = genres, 
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movie.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                throw new Exception("could not find customer");
            }
            var viewModel = new NewMovieViewModel
            {
                Name = movie.Name,
                Stock = movie.Stock,
                ReleaseDate = movie.ReleaseDate,
                GenreId = movie.GenreId,
                Genre = _context.Genre.ToList()
        };

            return View("Edit", viewModel);
        }

        public ActionResult CreateMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewMovieViewModel
                {
                    Genre = _context.Genre.ToList()
                };

                return View("Index", viewModel);
            }
            if (movie.Id == 0)
            {
                _context.Add(movie);
            } else
            {
                var movieDbContext = _context.Movie.SingleOrDefault(m => m.Id == movie.Id);
                movieDbContext.Name = movie.Name;
                movieDbContext.Genre = movie.Genre;
                movieDbContext.ReleaseDate = movie.ReleaseDate;
                movieDbContext.Stock = movie.Stock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movie");
        }

        public ActionResult Details(int ID)
        {
            var movies = _context.Movie.SingleOrDefault(c => c.Id == ID);

            if(movies == null)
            {
                throw new Exception("Movies can't be null");
            }
            return View(movies);
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {
                    FirstName = "John",
                    //LastName = "Snow",
                    //Email = "Johnsnow@test.com",
                    //Password = "tester",
                    //ConfirmPassword = "tester",
                    ID = 1,
                    MembershipTypeId = 1
                },
                new Customer {
                    FirstName = "Bob",
                    //LastName = "Brown",
                    //Email = "Bobbrown@test.com",
                    //Password = "tester",
                    //ConfirmPassword = "tester",
                    ID = 2,
                    MembershipTypeId = 2
                }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };

            return View(viewModel);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}