using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Genre")]
        [Required]
        public string GenreName { get; set; }

    }
}
