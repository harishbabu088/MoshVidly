﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoshVidly.Models;//to use the model by creating model

namespace MoshVidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie =  new Movie() { Name = "Shrek!" };
            return View(movie);
        }
    }
}