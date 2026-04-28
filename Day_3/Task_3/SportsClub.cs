using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class SportsClub
    {
        public Athlete[] Athletes { get; set; }

        public SportsClub(Athlete[] athletes)
        {
            Athletes = athletes;
        }

        public Athlete GetMostAwardedAthlete()
        {
            if (Athletes == null || Athletes.Length == 0) return null;

            return Athletes.OrderByDescending(a => a.Medals).First();
        }

        public List<Athlete> GetAthletesBySport(string sport)
        {
            return Athletes
                .Where(a => a.Sport.Equals(sport, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
