﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Seminarski.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Track name")]
        [Required]
        public string TrackName { get; set; }
        [DisplayName("Track length")]
        public string Length { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }

        public Artist Artist { get; set; }

        public Album Album { get; set; }
    }
}
