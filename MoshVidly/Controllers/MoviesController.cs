using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoshVidly.Models;//to use the model by creating model
using MoshVidly.ViewModels;
namespace MoshVidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            //var movie = new Movie() { Name = "Bahubali!" };
            //var customers = new List<Customer> {
            //    new Customer { Name = "Customer 1" }, // this is object initialization syntax creating 2 objects
            //    new Customer { Name = "Customer 2" }
            //};
            //now we create a viewModel object
            var viewModel = new RandomMovieViewModel
            {
                //Movie = movie, //initialize the viewModles
                //Customers = customers
                Movie = new Movie {
                    Id = 1,
                    Name = "Bahubali!"
                }, //initialize the viewModles
                Customers = new List<Customer>
                {
                        new Customer { Id=1,Name = "Johns Smith" }, // this is object initialization syntax creating 2 objects
                        new Customer { Id=2,Name = "Mary Williams" }
                }
            };
            return View(viewModel);
        }

        public ActionResult Edit(int Id, string Name) {

            return Content(String.Format("id = {0} & name = {1}", Id, Name));
        }

        public ActionResult ByReleasedDate(int year, int date) {

            return Content(year + "/" + date);
        }

        [Route("Movies/agesex/{age:regex(\\d(2)):range(1,12)}/{sex}")]
        public ActionResult AgeSex(int? age, string sex) {
           
            
            return Content(String.Format("Age={0}&Sex={1}",age,sex));
        }
        public ActionResult Customers()
        {


            return View();
        }
        public ActionResult Movies()
        {


            return View();
        }
    }
}