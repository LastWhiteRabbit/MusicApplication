using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Artist name")]
        [Required]
        public string ArtistName { get; set; }
        public int ArtistAge { get; set; }

    }
}
