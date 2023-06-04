using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projetoWebPedal.Models;

namespace projetoWebPedal.Controllers
{
    [Authorize(Roles ="Admin, Proponente")]
    public class RoteirosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoteirosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Roteiros
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Roteiros.Include(r => r.Proponente);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Roteiros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roteiro = await _context.Roteiros
                .Include(r => r.Proponente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roteiro == null)
            {
                return NotFound();
            }

            return View(roteiro);
        }

        // GET: Roteiros/Create
        public IActionResult Create()
        {
            ViewData["ProponenteId"] = new SelectList(_context.Proponente, "Id", "Email");
            return View();
        }

        // POST: Roteiros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Local,PontoEncontro,Data,Distancia,Dificuldade,Inicio,Final,ProponenteId")] Roteiro roteiro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roteiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProponenteId"] = new SelectList(_context.Proponente, "Id", "Email", roteiro.ProponenteId);
            return View(roteiro);
        }

        // GET: Roteiros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roteiro = await _context.Roteiros.FindAsync(id);
            if (roteiro == null)
            {
                return NotFound();
            }
            ViewData["ProponenteId"] = new SelectList(_context.Proponente, "Id", "Email", roteiro.ProponenteId);
            return View(roteiro);
        }

        // POST: Roteiros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Local,PontoEncontro,Data,Distancia,Dificuldade,Inicio,Final,ProponenteId")] Roteiro roteiro)
        {
            if (id != roteiro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roteiro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoteiroExists(roteiro.Id))
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
            ViewData["ProponenteId"] = new SelectList(_context.Proponente, "Id", "Email", roteiro.ProponenteId);
            return View(roteiro);
        }

        // GET: Roteiros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roteiro = await _context.Roteiros
                .Include(r => r.Proponente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roteiro == null)
            {
                return NotFound();
            }

            return View(roteiro);
        }

        // POST: Roteiros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roteiro = await _context.Roteiros.FindAsync(id);
            _context.Roteiros.Remove(roteiro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoteiroExists(int id)
        {
            return _context.Roteiros.Any(e => e.Id == id);
        }
    }
}
