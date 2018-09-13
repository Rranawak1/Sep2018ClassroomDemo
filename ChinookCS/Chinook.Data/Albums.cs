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
    [Table("Albums")]
    public class Albums
    {
        [Key]
        public int AlbumID { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(160, ErrorMessage = "Title is limited to 160 characters")]
        public string Title { get; set; }
        public int ArtistID { get; set; }
        public int ReleaseYear { get; set; }
        [StringLength(50, ErrorMessage = "ReleaseLabel is limited to 50 characters")]
        public string ReleaseLabel { get; set; }
    }
}
