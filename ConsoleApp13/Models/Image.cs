using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    public class Image
    {
        public string Id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string color { get; set; }
        public string blur_hash { get; set; }
        public int downloads { get; set; }
        public int likes { get; set; }
        public bool liked_by_user { get; set; }
        public string description { get; set; }
        public Exif Exif { get; set; }
        public Location Location { get; set; }
        public CurrentUserCollections[] CurrentUserCollections { get; set; }
        public Urls Urls { get; set; }
        public Links Links { get; set; }
        public User User { get; set; }

    }


}
