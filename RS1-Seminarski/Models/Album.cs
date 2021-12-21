using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Seminarski.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        public string AlbumName { get; set; }
        public byte[] AlbumCover { get; set; }
        public int AlbumLength { get; set; }

        public Genre Genre { get; set; }

        public Artist Artist { get; set; }

        public Track Track { get; set; }
    }
}
