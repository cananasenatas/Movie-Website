using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebSite.Models
{
    public class Filter
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
