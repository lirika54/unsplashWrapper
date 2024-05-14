using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    public class Exif
    {
        public string make { get; set; }
        public string model { get; set; } //??
        public string exposure_time { get; set; }
        public string aperture { get; set; }
        public string focal_length { get; set; }
        public int iso { get; set; }
    }
}
