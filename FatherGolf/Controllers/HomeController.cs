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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
