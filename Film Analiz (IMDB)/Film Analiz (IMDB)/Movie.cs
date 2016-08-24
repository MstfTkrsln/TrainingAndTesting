using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Film_Analiz__IMDB_
{
    public class Movie
    {
        public string ImdbId { get; set; }
        public string Url { get; set; }
        public string Genres { get; set; }
        public string Languages { get; set; }
        public string Country { get; set; }
        public string Votes { get; set; }
        public string Rating { get; set; }
        public string Runtime { get; set; }
        public string Title { get; set; }
        public string Year { get; set; } 
    }
}
