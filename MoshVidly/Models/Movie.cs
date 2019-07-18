using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoshVidly.Models
{
    public class Movie
    {
        //the below are the properties and they are used to represent the state
       public int Id { get; set; }
        public string Name { get; set; }

        //create a page where u can randomly pick a movie and render the content
        //like Movies/Random  -->for this create a movie controller and action as random

    }
}