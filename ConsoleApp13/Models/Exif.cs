using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    public class Exif
    {
        public string? Make { get; set; }
        public string? Model { get; set; } //??
        public string? ExposureTime { get; set; }
        public string? Aperture { get; set; }
        public string? FocalLength { get; set; }
        public int Iso { get; set; }
    }
}
