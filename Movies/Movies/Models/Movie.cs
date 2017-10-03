using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Genre { get; set; }

        public string Rating { get; set; }
        
        public int Score { get; set; }

        public int TicketCost { get; set; }

        public string PeoplesOpinion { get; set; }

        public string MyOpinion { get; set; }

        public IEnumerable<Actor> Actors { get; set; }

        public IEnumerable<string> Photos { get; set; }
    }
}
