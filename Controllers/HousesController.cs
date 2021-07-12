using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CasaOrtApp.Data;
using CasaOrtApp.Models;
using Newtonsoft.Json;

namespace CasaOrtApp.Controllers
{
    public class HousesController : Controller
    {
        private readonly CasaOrtAppContext _context;
        private static List<House> array_like = new List<House>();

        public HousesController(CasaOrtAppContext context)
        {
            _context = context;
        }

        // GET: Houses
        public async Task<IActionResult> Index(Tipo TipoOperacion)
        {
            IQueryable<Tipo> tipoQuery = from m in _context.House
                                            orderby m.tipoDeOperacion
                                            select m.tipoDeOperacion;

            var houses = from m in _context.House
                         select m;

             if (Tipo.Alquiler.Equals(TipoOperacion))
            {
                houses = houses.Where(x => x.tipoDeOperacion.Equals(TipoOperacion));
            } else
            {
                houses = houses.Where(x => x.tipoDeOperacion.Equals(TipoOperacion));
            }

            var tipoVM = new TipoViewModel
            {
                Tipo = new SelectList(await tipoQuery.Distinct().ToListAsync()),
                Houses = await houses.ToListAsync()
            };

            return View(tipoVM);
        }

        // GET: Houses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var house = await _context.House
                .FirstOrDefaultAsync(m => m.Id == id);
            if (house == null)
            {
                return NotFound();
            }

            return View(house);
        }

        // GET: Houses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Houses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Street,Number,Size,Garden,SwimmingPool,Path,Price,ReleaseDate,tipoDeOperacion")] House house)
        {
            if (ModelState.IsValid)
            {
                _context.Add(house);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(house);
        }

        // GET: Houses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var house = await _context.House.FindAsync(id);
            if (house == null)
            {
                return NotFound();
            }
            return View(house);
        }

        // POST: Houses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Street,Number,Size,Garden,SwimmingPool,Path,Price,ReleaseDate,tipoDeOperacion")] House house)
        {
            if (id != house.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(house);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HouseExists(house.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(house);
        }

        // GET: Houses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var house = await _context.House
                .FirstOrDefaultAsync(m => m.Id == id);
            if (house == null)
            {
                return NotFound();
            }

            return View(house);
        }

        // POST: Houses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var house = await _context.House.FindAsync(id);
            _context.House.Remove(house);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HouseExists(int id)
        {
            return _context.House.Any(e => e.Id == id);
        }

        public void AddLike(int id, string street, int number, int size, string path, string price, string date)
        {
            House h = new House();
            h.Id = id;
            h.Street = street;
            h.Number = number;
            h.Size = size;
            h.Path = path;
            h.Price = Convert.ToDecimal(price);
            h.ReleaseDate = Convert.ToDateTime(date);

            House house = containHouse(h);
            if (house == null)
                array_like.Add(h);
            else
                array_like.Remove(house);

            try
            {
                TempData["H_Likes"] = JsonConvert.SerializeObject(array_like);
                TempData.Keep();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private House containHouse(House h)
        {
            House result = null;

            foreach(House house in array_like)
            {
                if(house.Id == h.Id) { 
                    result = house;
                    break;
                }
            }
            return result;
        }

        public bool GetState(int id) {
            House h = new House();
            h.Id = id;

            House house = containHouse(h);

            return house != null;
        }

        public bool Dislike(int id)
        {
            House h = new House();
            h.Id = id;

            House house = containHouse(h);
            if (house != null)
                array_like.Remove(house);

            return house != null;
        }
    }
}
