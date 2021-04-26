using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using PouleSim.Data;
using PouleSim.Models;
using PouleSim.Utilities;


namespace PouleSim.Controllers
{
    public class PouleSetupController : Controller
    {
        // 
        // GET: /PouleSetup/
        private readonly ClubContext _context;

        public PouleSetupController(ClubContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Club.ToListAsync());
        }

        // 
        // GET: /PouleSetup/EasterEgg/ 

        public string EasterEgg()
        {
            return "This is an extra page...";
        }

        // 
        // GET: /PouleSetup/EasterEgg/
        public IActionResult SimulateMatchExample(int homeLevel, int awayLevel, int times)
        {
            int homeWins = 0, awayWins = 0, draws = 0;

            Club testClub1 = new Club();
            testClub1.Name = "Ajax";
            testClub1.Powerlevel = homeLevel;
            Club testClub2 = new Club();
            testClub2.Name = "Feyenoord";
            testClub2.Powerlevel = awayLevel;

            for(int i = 0; i < times; i++)
            {
                Match simulatedMatch = MatchSimulator.SimulateMatch(testClub1,testClub2);
                if(simulatedMatch.MatchResult == MatchResult.Home)
                {
                    homeWins++;
                }
                else if (simulatedMatch.MatchResult == MatchResult.Away)
                {
                    awayWins++;
                }
                else
                {
                    draws++;
                }
                ViewData[$"Match{i}"] = HtmlEncoder.Default.Encode($"Match simulated: {simulatedMatch.HomeClub.Name} vs. {simulatedMatch.AwayClub.Name}, Final score is: {simulatedMatch.HomeGoals}-{simulatedMatch.AwayGoals}");
            }

            ViewData["HomeWins"] = homeWins;
            ViewData["AwayWins"] = awayWins;
            ViewData["Draws"] = draws;
            ViewData["Times"] = times;
            return View();
        }

        public async Task<IActionResult> TestPoule()
        {
            Poule testPoule = new Poule();

            var clubs = await _context.Club.ToListAsync();

            if( clubs.Count == 0 )
            {
                Club testClub1 = new Club();
                testClub1.Name = "Ajax";
                testClub1.Powerlevel = 80;

                testPoule.Clubs.Add(testClub1);

                Club testClub2 = new Club();
                testClub2.Name = "Feyenoord";
                testClub2.Powerlevel = 80;

                testPoule.Clubs.Add(testClub2);

                Club testClub3 = new Club();
                testClub3.Name = "PSV";
                testClub3.Powerlevel = 75;

                testPoule.Clubs.Add(testClub3);

                Club testClub4 = new Club();
                testClub4.Name = "AZ";
                testClub4.Powerlevel = 75;

                testPoule.Clubs.Add(testClub4);
            }
            else
            {
                testPoule.Clubs = clubs;
            }

            var testPouleScore = PouleSimulator.SimulatePoule(testPoule);

            for(int i = 0; i < testPouleScore.PouleScoreRows.Count; i++)
            {
                ViewData[$"PouleScoreRow{i}"] = testPouleScore.PouleScoreRows[i];
            }

            for(int i = 0; i < testPoule.Matches.Count; i++)
            {
                ViewData[$"Match{i}"] = testPoule.Matches[i].ToString();
            }

            ViewData["ClubCount"] = testPouleScore.PouleScoreRows.Count;
            ViewData["MatchCount"] = testPoule.Matches.Count;

            return View();
        }
    }
}