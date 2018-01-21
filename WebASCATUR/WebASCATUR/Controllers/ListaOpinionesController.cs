using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebASCATUR.Data.Models;
using WebASCATUR.Data;

namespace WebASCATUR.Controllers
{
    public class ListaOpinionesController : Controller
    {
        private readonly AdmWebASCATUR_Default_v1Context _context;

        public ListaOpinionesController(AdmWebASCATUR_Default_v1Context context)
        {
            _context = context;
        }

        // GET: ListaOpiniones
        public ActionResult Index()
        {
            IEnumerable<Opinion> opiniones;
            opiniones = _context.Opinion.ToList();
            return View(opiniones);
        }
        // GET: ListaOpiniones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opinion = await _context.Opinion
                .Include(o => o.IdComercioNavigation)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (opinion == null)
            {
                return NotFound();
            }

            return View(opinion);
        }

        // GET: ListaOpiniones/Create
        public IActionResult Create()
        {
            ViewData["IdComercio"] = new SelectList(_context.Comercio, "Id", "Cedula");
            return View();
        }

        // POST: ListaOpiniones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdComercio,Detalle,NombreUsuario,FechaIngreso")] Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opinion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdComercio"] = new SelectList(_context.Comercio, "Id", "Cedula", opinion.IdComercio);
            return View(opinion);
        }

        // GET: ListaOpiniones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opinion = await _context.Opinion.SingleOrDefaultAsync(m => m.Id == id);
            if (opinion == null)
            {
                return NotFound();
            }
            ViewData["IdComercio"] = new SelectList(_context.Comercio, "Id", "Cedula", opinion.IdComercio);
            return View(opinion);
        }

        // POST: ListaOpiniones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdComercio,Detalle,NombreUsuario,FechaIngreso")] Opinion opinion)
        {
            if (id != opinion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opinion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpinionExists(opinion.Id))
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
            ViewData["IdComercio"] = new SelectList(_context.Comercio, "Id", "Cedula", opinion.IdComercio);
            return View(opinion);
        }

        // GET: ListaOpiniones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opinion = await _context.Opinion
                .Include(o => o.IdComercioNavigation)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (opinion == null)
            {
                return NotFound();
            }

            return View(opinion);
        }

        // POST: ListaOpiniones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opinion = await _context.Opinion.SingleOrDefaultAsync(m => m.Id == id);
            _context.Opinion.Remove(opinion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpinionExists(int id)
        {
            return _context.Opinion.Any(e => e.Id == id);
        }
    }
}
