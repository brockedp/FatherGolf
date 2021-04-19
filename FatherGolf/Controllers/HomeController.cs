using FatherGolf.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FatherGolf.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //  //  _logger = logger;
        //}

        private readonly FatherGolfContext _context;
        public HomeController(FatherGolfContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var theGripper = GetTeam().Result;

            return View(theGripper);
        }


        #region Scorecard
        public IActionResult DisplayAllRounds()
        {
            List<GolfScoreCard> scorecards = new List<GolfScoreCard>();
            scorecards = _context.GolfScoreCards.ToList();

            return View(scorecards);
        }

        public IActionResult AddScorecard()
        {
           // List<Golfer> golfers = _context.Golfers.ToList();

            //return View(golfers);
            //todo - need to update handicap of golfer after scorecard is submitted

            return View();

        }
        [HttpPost]
        public IActionResult AddScorecard(GolfScoreCard newGolfScorecard, string played)
        {
           
            if (ModelState.IsValid)
            {
                //todo - look of it. Going to use drop down list 
                if (newGolfScorecard.CourseId != null && newGolfScorecard.PlayerId != null)
                {
                    if (played == "18")
                    {
                        newGolfScorecard.Total = newGolfScorecard.Hole1 + newGolfScorecard.Hole2 + newGolfScorecard.Hole3 + newGolfScorecard.Hole4 +
                           newGolfScorecard.Hole5 + newGolfScorecard.Hole6 + newGolfScorecard.Hole7 + newGolfScorecard.Hole8 + newGolfScorecard.Hole9 +
                           newGolfScorecard.Hole10 + newGolfScorecard.Hole11 + newGolfScorecard.Hole12 + newGolfScorecard.Hole13 + newGolfScorecard.Hole14 +
                           newGolfScorecard.Hole15 + newGolfScorecard.Hole16 + newGolfScorecard.Hole17 + newGolfScorecard.Hole18;
                    }
                    else
                    {
                        if (newGolfScorecard.Hole1 != null)
                        {
                            newGolfScorecard.Total = newGolfScorecard.Hole1 + newGolfScorecard.Hole2 + newGolfScorecard.Hole3 + newGolfScorecard.Hole4 +
                          newGolfScorecard.Hole5 + newGolfScorecard.Hole6 + newGolfScorecard.Hole7 + newGolfScorecard.Hole8 + newGolfScorecard.Hole9;
                            newGolfScorecard.Hole10 = 0;
                            newGolfScorecard.Hole11 = 0;
                            newGolfScorecard.Hole12 = 0;
                            newGolfScorecard.Hole13 = 0;
                            newGolfScorecard.Hole14 = 0;
                            newGolfScorecard.Hole15 = 0;
                            newGolfScorecard.Hole16 = 0;
                            newGolfScorecard.Hole17 = 0;
                            newGolfScorecard.Hole18 = 0;
                        }
                        else
                        {
                            newGolfScorecard.Total = newGolfScorecard.Hole10 + newGolfScorecard.Hole11 + newGolfScorecard.Hole12 + newGolfScorecard.Hole13 + newGolfScorecard.Hole14 +
                        newGolfScorecard.Hole15 + newGolfScorecard.Hole16 + newGolfScorecard.Hole17 + newGolfScorecard.Hole18;
                            newGolfScorecard.Hole1 = 0;
                            newGolfScorecard.Hole2 = 0;
                            newGolfScorecard.Hole3 = 0;
                            newGolfScorecard.Hole4 = 0;
                            newGolfScorecard.Hole5 = 0;
                            newGolfScorecard.Hole6 = 0;
                            newGolfScorecard.Hole7 = 0;
                            newGolfScorecard.Hole8 = 0;
                            newGolfScorecard.Hole9 = 0;
                        }
                    }

                    newGolfScorecard.Date = DateTime.Now.ToShortDateString();
                    _context.Add(newGolfScorecard);
                    _context.SaveChanges();
                    return RedirectToAction("DisplayAllRounds");
                }
                else
                {
                    ViewBag.NotEnoughInfo = "You did not have a player name or course name";
                    return View("AddScorecard");
                }
            }
            else
            {
                return View("AddScorecard");
            }
        }

        public IActionResult DeleteScorecard(int id)
        {
            GolfScoreCard found = _context.GolfScoreCards.Find(id);
            if (ModelState.IsValid && found != null)
            {
                _context.Remove(found);
                _context.SaveChanges();
                return RedirectToAction("DisplayAllRounds");
              //todo - associate player id with scorecard
              //todo - update players total rounds when deleting a scorecard
            }
            else
            {
                return RedirectToAction("DisplayAllRounds");
            }
        }
        #endregion
        #region Golfer
        public IActionResult ViewGolfers()
        {
            List<Golfer> golfers = new List<Golfer>();
            golfers = _context.Golfers.ToList();

            return View(golfers);
        }

        public IActionResult AddGolfer()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddGolfer(Golfer golfer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(golfer);
                _context.SaveChanges();
                return RedirectToAction("ViewGolfers");
            }
            else
            {
                return View("ViewGolfers");
            }
        }

        public IActionResult UpdateGolfer(int id)
        {
            Golfer found = _context.Golfers.Find(id);
            if (found != null)
            {
                return View(found);
            }
            else
            {
                return RedirectToAction("ViewGolfers");
            }
        }
        [HttpPost]
        public IActionResult UpdateGolfer(Golfer golfer)
        {
            Golfer found = _context.Golfers.Find(golfer.Id);
            if (ModelState.IsValid && found != null)
            {
                found.Id = golfer.Id;
                found.Firstname = golfer.Firstname;
                found.Lastname = golfer.Lastname;
                found.Totalrounds = golfer.Totalrounds;
                found.Handicap = golfer.Handicap;

                _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(found);
                _context.SaveChanges();
            }
            return RedirectToAction("ViewGolfers");
        }

        public IActionResult DeleteGolfer(int id)
        {
            Golfer found = _context.Golfers.Find(id);
            if (ModelState.IsValid && found != null)
            {
                _context.Remove(found);
                _context.SaveChanges();
                //todo - delete associated golf rounds as well
                //todo - set golfer to deleted and round to deleted instead of deleting
            }
            return RedirectToAction("ViewGolfers");

        }

        #endregion
        #region Course

        public IActionResult ViewCourses()
        {
            List<Course> Courses = new List<Course>();
            Courses = _context.Courses.ToList();

            return View(Courses);
        }

        public IActionResult AddCourse()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddCourse(Course Course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Course);
                _context.SaveChanges();
                return RedirectToAction("ViewCourses");
            }
            else
            {
                return View("ViewCourses");
            }
        }

        public IActionResult UpdateCourse(int id)
        {
            Course found = _context.Courses.Find(id);
            if (found != null)
            {
                return View(found);
            }
            else
            {
                return RedirectToAction("ViewCourses");
            }
        }
        [HttpPost]
        public IActionResult UpdateCourse(Course Course)
        {
            Course found = _context.Courses.Find(Course.Id);
            if (ModelState.IsValid && found != null)
            {
                found.Id = Course.Id;
                found.Name = Course.Name;
                found.FrontNinePar = Course.FrontNinePar;
                found.BackNinePar = Course.BackNinePar;
                found.Par = Course.Par;
                found.Slope = Course.Slope;
                found.CourseRating = Course.CourseRating;
                found.PhoneNumber = Course.PhoneNumber;
                found.Address = Course.Address;

                _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(found);
                _context.SaveChanges();
            }
            return RedirectToAction("ViewCourses");
        }


        #endregion
        public IActionResult Privacy()
        {
            return View();
        }


        public static HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            // httpClient.BaseAddress = new Uri("https://www.themealdb.com");
            client.BaseAddress = new Uri("https://www.thesportsdb.com");
            return client;
        }

        public async Task<Players> GetTeam()
        {
            var client = GetHttpClient();
            //var response = await client.GetAsync($"api/json/v1/{_apiKey}/random.php");
            var response = await client.GetAsync($"api/v1/json/1/searchplayers.php?p=John%20Daly");
            var players = await response.Content.ReadAsAsync<Players>();
            return players;
        }

       //4.19.2021 - trying to calculate handicap
        private float CalculateHandicapForCourse(int golferId, int courseId)
        {
            Golfer golfer = _context.Golfers.Find(golferId);
            Course golfCourse = _context.Courses.Find(courseId);

            float golferHandicap = (float)(golfer.Handicap * (golfCourse.Slope / 113) + (golfCourse.CourseRating + golfCourse.Par));

            return golferHandicap;
        }

        private float CalculateHandicapDifferential(int score, int courseId)
        {
            float handicapDiff;
            Course golfCourse = _context.Courses.Find(courseId);
            handicapDiff = (float)((score - golfCourse.CourseRating) * 113 / golfCourse.Slope);

            return handicapDiff;
        }

        private float SetGolferHandicap(int golferId)
        {
            float handicap = 0;
            Golfer golfer = _context.Golfers.Find(golferId);
            List<GolfScoreCard> golfScoreCards = _context.GolfScoreCards.ToList();
            List<GolfScoreCard> theirScorecards = golfScoreCards.Where(c => c.PlayerId == golferId).ToList();
            List < float> differientals = new List<float>();
            //float[] differientals = new float[theirScorecards.Count];
            for (int i = 0; i < theirScorecards.Count; i++)
            {
                float differential = CalculateHandicapDifferential((int)theirScorecards[i].Total, (int)theirScorecards[i].CourseId);
                differientals.Add(differential);
               // differientals[i] = differential;
            }
            differientals.Sort();
            if (differientals.Count <= 10)
            {
                handicap = differientals.Min() * (float)0.96;
            }
            else if (differientals.Count > 10 && differientals.Count < 20)
            {
                float total = 0;
                for (int i = 0; i < 5; i++)
                {
                    total += differientals[i];
                }
                handicap = (float)(total/5) * (float)0.96;
            }
            else
            {
                float total = 0;
                for (int i = 0; i < 10; i++)
                {
                    total += differientals[i];
                }
                handicap = (float)(total / 10) * (float)0.96;
            }
            return handicap;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
                                                                                                                     