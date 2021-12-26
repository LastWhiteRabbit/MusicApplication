using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Seminarski.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Genre")]
        public string GenreName { get; set; }

    }
}
