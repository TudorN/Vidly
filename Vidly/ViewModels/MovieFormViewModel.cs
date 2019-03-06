using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Released Date")]
        public DateTime? ReleasedDate { get; set; }

        [Required]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "The field Number is Stock should be between 1 and 20")]
        [Display(Name = "Number in Stock")]
        public int? NumberInStock { get; set; }

        [Required(ErrorMessage = "The Genre field is required")]
        public byte? GenreId { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {

            Id = movie.Id;
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            DateAdded = movie.DateAdded;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

        public string Title
        {

            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
    }
}