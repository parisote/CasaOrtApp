using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaOrtApp.Models;
using Newtonsoft.Json;
using CasaOrtApp.Data;

namespace CasaOrtApp.Controllers
{
    public class LikesController : Controller
    {

        private readonly CasaOrtAppContext _context;

        public LikesController(CasaOrtAppContext context)
        {
            _context = context;
        }

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

        public void Dislike(int id, bool house)
        {
            if (house)
            {
                //List<House> l = ViewData["H_Likes"];
                HousesController h = new HousesController(_context);
                bool result = h.Dislike(id);
            } else
            {
                EmprendimientoController e = new EmprendimientoController(_context);
                bool result = e.Dislike(id);
            }
        }
    }
}
