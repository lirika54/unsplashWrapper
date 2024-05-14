using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    internal class CurrentUserCollections
    {
        public int id { get; set; }
        public string title { get; set; }
        public string published_at { get; set; }
        public string last_collected_at { get; set; }
        public int? cover_photo { get; set; }
        public int? user { get; set; }
    }
}
