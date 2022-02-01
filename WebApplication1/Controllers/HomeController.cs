using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult GuessingGame()
        {
           int rnd = new Random().Next(1,100);
            
            HttpContext.Session.Set("RandomNumber", BitConverter.GetBytes(rnd));
            return View();
        }
        [HttpPost]
        public IActionResult GuessingGame(int Guess)
        {
            byte[] sessionValue;
            HttpContext.Session.TryGetValue("RandomNumber", out sessionValue);
            if (sessionValue == null)
            {
                return RedirectToAction("GuessingGame");
            }
           
            int randomNumber  =BitConverter.ToInt32(sessionValue);
            ViewBag.Message = GuessModel.CheckGuess(Guess,randomNumber);
            ViewBag.Random = randomNumber;
            ViewBag.Attempts = GuessModel.AttemptCounter;

            if (ViewBag.Message.Contains("You have won the game"))
            {
                HttpContext.Session.Clear();
                GuessModel.AttemptCounter = 0;
                ViewBag.Random = null;
            }
            return View();
        }
    }
}
