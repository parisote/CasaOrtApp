using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaOrtApp.Models;
using Newtonsoft.Json;

namespace CasaOrtApp.Controllers
{
    public class LikesController : Controller
    {
        // GET: Likes
        public ActionResult Index()
        {
            if (TempData["H_Likes"] != null)
                ViewData["H_Likes"] = JsonConvert.DeserializeObject<List<House>>((string)TempData["H_Likes"]);
            else
                ViewData["H_Likes"] = new List<House>();

            if (TempData["E_Likes"] != null)
                ViewData["E_Likes"] = JsonConvert.DeserializeObject<List<Emprendimiento>>((string)TempData["E_Likes"]);
            else
                ViewData["E_Likes"] = new List<Emprendimiento>();

            return View();
        }
    }
}
