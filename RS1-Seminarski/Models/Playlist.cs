using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Seminarski.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Playlist name")]
        [Required]
        public string PlaylistName { get; set; }
        [DisplayName("Number of songs")]
        public int PlaylistSongNumber { get; set; }
        public int TrackId { get; set; }
        [ForeignKey("TrackId")]
        public virtual Track PlaylistTrack { get; set; }
    }
}
