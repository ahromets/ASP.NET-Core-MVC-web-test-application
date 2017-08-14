using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieRatingViewModel
    {
		public List<Movie> movies;
		public SelectList ratings;
		public string movieRating { get; set; }
    }
}
