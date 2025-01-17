using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBList
{
    internal class Film
    {
        public string MovieName { get; set; }

        public double ImdbScore { get; set; }

        public Film(string movieName, double imdbScore)
        {
            MovieName = movieName;
            ImdbScore = imdbScore;
        }
    }
}
