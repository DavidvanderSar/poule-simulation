using System.Collections.Generic;
namespace PouleSim.Models
{
    public class Poule
    {
        public List<Club> Clubs { get; set; }
        public string Name { get; set; }
        public List<Match> Matches { get; set; }

        public Poule(string name = "Poule")
        {
            Clubs = new List<Club>();
            Name = name;
            Matches = new List<Match>();
        }

        public Poule(List<Club> clubs, string name = "Poule")
        {
            Clubs = clubs;
            Name = name;
            Matches = new List<Match>();
        }
    }
}