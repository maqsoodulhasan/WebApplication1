using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Doctor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(int temp, string TempUnit)
        {
            ViewBag.Message = DoctorModel.CheckFeber(temp, TempUnit);
            return View();
        }

    }
}
