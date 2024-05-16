using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    public class Image
    {
        public string? Id { get; set; }
        public string? CreatedAt { get; set; }
        public string? UpdatedAt { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string? Color { get; set; }
        public string? BlurHash { get; set; }
        public int Downloads { get; set; }
        public int Likes { get; set; }
        public bool LikedByUser { get; set; }
        public string? Description { get; set; }
        public Exif Exif { get; set; }
        public Location Location { get; set; }
        public CurrentUserCollections[] CurrentUserCollections { get; set; }
        public Urls Urls { get; set; }
        public Links Links { get; set; }
        public User User { get; set; }

    }


}
