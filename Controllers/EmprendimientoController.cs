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
    public class EmprendimientoController : Controller
    {
        private readonly CasaOrtAppContext _context;
        private static List<Emprendimiento> array_like = new List<Emprendimiento>();

        public EmprendimientoController(CasaOrtAppContext context)
        {
            _context = context;
        }

        // GET: Emprendimiento
        public async Task<IActionResult> Index()
        {
            ViewData["title"] = "Nuestros emprendimientos";
            return View(await _context.Emprendimiento.ToListAsync());
        }

        // GET: Emprendimiento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendimiento = await _context.Emprendimiento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emprendimiento == null)
            {
                return NotFound();
            }

            return View(emprendimiento);
        }

        // GET: Emprendimiento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Emprendimiento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Street,Number,Size,Garden,SwimmingPool,Path,Price,etapa,ReleaseDate")] Emprendimiento emprendimiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emprendimiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emprendimiento);
        }

        // GET: Emprendimiento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendimiento = await _context.Emprendimiento.FindAsync(id);
            if (emprendimiento == null)
            {
                return NotFound();
            }
            return View(emprendimiento);
        }

        // POST: Emprendimiento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Street,Number,Size,Garden,SwimmingPool,Path,Price,etapa,ReleaseDate")] Emprendimiento emprendimiento)
        {
            if (id != emprendimiento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emprendimiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmprendimientoExists(emprendimiento.Id))
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
            return View(emprendimiento);
        }

        // GET: Emprendimiento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendimiento = await _context.Emprendimiento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emprendimiento == null)
            {
                return NotFound();
            }

            return View(emprendimiento);
        }

        // POST: Emprendimiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emprendimiento = await _context.Emprendimiento.FindAsync(id);
            _context.Emprendimiento.Remove(emprendimiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmprendimientoExists(int id)
        {
            return _context.Emprendimiento.Any(e => e.Id == id);
        }

        public void AddLike(int id, string street, int number, int size, string path, decimal price, string date)
        {
            Emprendimiento e = new Emprendimiento();
            e.Id = id;
            e.Street = street;
            e.Number = number;
            e.Size = size;
            e.Path = path;
            e.Price = price;
            e.ReleaseDate = Convert.ToDateTime(date);

            Emprendimiento emp = containEmprendimiento(e);
            if (emp == null)
                array_like.Add(e);
            else
                array_like.Remove(emp);

            array_like.Add(e);
            try { 
                TempData["E_Likes"] = JsonConvert.SerializeObject(array_like);
                TempData.Keep();
            } catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private Emprendimiento containEmprendimiento(Emprendimiento e)
        {
            Emprendimiento result = null;

            foreach (Emprendimiento emp in array_like)
            {
                if (emp.Id == e.Id)
                {
                    result = emp;
                    break;
                }
            }
            return result;
        }

        public bool Dislike(int id)
        {
            Emprendimiento e = new Emprendimiento();
            e.Id = id;

            Emprendimiento emp = containEmprendimiento(e);
            if (emp != null)
                array_like.Remove(emp);

            return emp != null;
        }
    }
}
