using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    public class CurrentUserCollections
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? PublishedAt { get; set; }
        public string? LastCollectedAt { get; set; }
        public int? CoverPhoto { get; set; }
        public int? User { get; set; }
    }
}
