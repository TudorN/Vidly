
using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

       
        public Genre Genre { get; set; }

        [Required]
        [Display(Name="Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,20, ErrorMessage = "The field Number in Stock should be between 1 and 20")]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "The field Number available should be between 1 and 20")]
        [Display(Name = "Number Available")]
        public int NumberAvailable { get; set; }

        [Required(ErrorMessage ="The Genre field is required")]
        public byte GenreId { get; set; }


    }
}