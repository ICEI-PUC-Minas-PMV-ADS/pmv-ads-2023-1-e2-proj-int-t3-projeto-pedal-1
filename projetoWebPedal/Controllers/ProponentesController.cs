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
    [Authorize]
    public class ProponentesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProponentesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Proponentes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Proponente.ToListAsync());
        }

        // GET: Proponentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proponente = await _context.Proponente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proponente == null)
            {
                return NotFound();
            }

            return View(proponente);
        }

        // GET: Proponentes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Proponentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Altura,login,Senha,Perfil")] Proponente proponente)
        {
            if (ModelState.IsValid)
            {
                proponente.Senha = BCrypt.Net.BCrypt.HashPassword(proponente.Senha);
                _context.Add(proponente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proponente);
        }

        // GET: Proponentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proponente = await _context.Proponente.FindAsync(id);
            if (proponente == null)
            {
                return NotFound();
            }
            return View(proponente);
        }

        // POST: Proponentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Altura,login,Senha,Perfil")] Proponente proponente)
        {
            if (id != proponente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    proponente.Senha = BCrypt.Net.BCrypt.HashPassword(proponente.Senha);
                    _context.Update(proponente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProponenteExists(proponente.Id))
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
            return View(proponente);
        }

        // GET: Proponentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proponente = await _context.Proponente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proponente == null)
            {
                return NotFound();
            }

            return View(proponente);
        }

        // POST: Proponentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proponente = await _context.Proponente.FindAsync(id);
            _context.Proponente.Remove(proponente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProponenteExists(int id)
        {
            return _context.Proponente.Any(e => e.Id == id);
        }
    }
}
