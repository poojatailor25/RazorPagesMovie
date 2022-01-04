using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; } 
        public string Title { get; set; }=String.Empty;
        public DateTime ReleaseDate { get; set; }   
        public string Type { get; set; }=String.Empty;
        public int Price { get; set; }
    }
}
