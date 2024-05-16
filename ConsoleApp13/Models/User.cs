using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    internal class User
    {
        public string? Id { get; set; }
        public string? UpdatedAt { get; set; }
        public string? Username { get; set; }
        public string? Name { get; set; }
        public string? Portfolio_url { get; set; }
        public string? Bio { get; set; }
        public string? Location { get; set; }
        public int TotalLikes { get; set; }
        public int TotalPhoto { get; set; }
        public int TotalCollections { get; set; }
        public string? InstagramUsername { get; set; }
        public string? TwitterUsername { get; set; }
        public User User { get; set; }
    }
}
