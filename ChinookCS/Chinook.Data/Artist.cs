using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace Chinook.Data
{
    [Table("Artists")]
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(120,ErrorMessage = "Name is limited to 120 characters")]
        public string Name { get; set; }
    }

    [Table("Albums")]
    public class Albums
    {
        [Key]
        public int AlbumID { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(160, ErrorMessage = "Title is limited to 160 characters")]
        public string Title { get; set; }
        public int ArtistID { get;set;}
        public int ReleaseYear { get; set; }
        [StringLength(50, ErrorMessage = "ReleaseLabel is limited to 50 characters")]
        public string ReleaseLabel { get; set; }
    }

}