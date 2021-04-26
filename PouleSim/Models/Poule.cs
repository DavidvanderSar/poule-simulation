using System.Collections.Generic;
namespace PouleSim.Models
{
    public class Poule
    {
        public List<Club> Clubs { get; set; }
        public string Name { get; set; }
        public List<Match> Matches { get; set; }

        public Poule()
        {
            Clubs = new List<Club>();
            Name = "Poule";
            Matches = new List<Match>();
        }
    }
}