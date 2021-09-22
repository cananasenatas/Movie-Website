using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebSite.Models
{
    public class Website
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
        public string Director { get; set; }
        public string Link { get; set; }
        public int GenresId { get; set; }
        public Genres Genres { get; set; }
        public string Actors { get; set; }
        public string WatchTime { get; set; }
        public int ChooseId { get; set; }
        public Choose Choose { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int FilterId { get; set; }
        public Filter Filter { get; set; }

    }
}
