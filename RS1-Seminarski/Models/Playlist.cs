using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Seminarski.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }
        public string PlaylistName { get; set; }
        public int PlaylistSongNumber { get; set; }
        public Track PlaylistTrack { get; set; }
    }
}
