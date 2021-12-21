using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Seminarski.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public int ArtistAge { get; set; }

        public Genre Genre { get; set; }
    }
}
