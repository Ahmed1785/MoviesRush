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
    public class CustomersController : Controller
    {
        private MainContext _context;

        //Creating a constructor of the private field and making it an instance of the MainContext 
        public CustomersController(MainContext context)
        {
            _context = context;
        }

        //this is needed for the cleanup
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Create()
        {
            var membershipType = _context.MembershipType.ToList();
            var viewModel = new NewCustomerViewModel
            {
                Customer = new Customer(),
                MembershipType = membershipType
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateUser(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    MembershipType = _context.MembershipType.ToList()
                };

                return View("Index", viewModel);
            }

            if (customer.ID < 1)
                _context.Customer.Add(customer);
            else
            {
                var customerInDb = _context.Customer.Single(c => c.ID == customer.ID);
                customerInDb.FirstName = customer.FirstName;
                customerInDb.LastName = customer.LastName;
                customerInDb.Password = customer.Password;
                customerInDb.ConfirmPassword = customer.ConfirmPassword;
                customerInDb.Email = customer.Email;
                customerInDb.Birthday = customer.Birthday;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit (int id)
        {
            var customer = _context.Customer.SingleOrDefault(m => m.ID == id);

            if(customer == null)
            {
                throw new Exception("could not find customer");
            }
            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipType = _context.MembershipType.ToList()
            };
            return View("Create", viewModel);
        }

        public ViewResult Index()
        {
            var customers = _context.Customer.Include(d => d.MembershipType).ToList();
            return View(customers);

        }

        public ActionResult Details(int id, DateTime? birthday)
        {
            var customer = _context.Customer.Include(c => c.MembershipType).SingleOrDefault(c => c.ID == id);

            if (customer == null)
                throw new Exception("customer not found");
            return View(customer);
        }
    }
}
