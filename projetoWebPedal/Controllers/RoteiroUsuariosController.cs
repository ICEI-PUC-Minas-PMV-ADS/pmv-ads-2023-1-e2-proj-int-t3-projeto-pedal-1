using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projetoWebPedal.Models;

namespace projetoWebPedal.Controllers
{
    [Authorize]
    public class RoteiroUsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;
        //private object _httpContextAccessor;

        public RoteiroUsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoteiroUsuarios
        public async Task<IActionResult> Index()
        {
            // string nomeUsuario = _httpContextAccessor.HttpContext.User.Identity.Name;
            var applicationDbContext = _context.RoteiroUsuarios.Include(r => r.Roteiro).Include(r => r.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RoteiroUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roteiroUsuario = await _context.RoteiroUsuarios
                .Include(r => r.Roteiro)
                .Include(r => r.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roteiroUsuario == null)
            {
                return NotFound();
            }

            return View(roteiroUsuario);
        }

        // GET: RoteiroUsuarios/Create
        public IActionResult Create()
        {
            ViewData["RoteiroId"] = new SelectList(_context.Roteiros, "Id", "Local");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome");
            return View();
        }

        // POST: RoteiroUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoteiroId,UsuarioId,Peso")] RoteiroUsuario roteiroUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roteiroUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoteiroId"] = new SelectList(_context.Roteiros, "Id", "Local", roteiroUsuario.RoteiroId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", roteiroUsuario.UsuarioId);
            return View(roteiroUsuario);
        }

        // GET: RoteiroUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roteiroUsuario = await _context.RoteiroUsuarios.FindAsync(id);
            if (roteiroUsuario == null)
            {
                return NotFound();
            }
            ViewData["RoteiroId"] = new SelectList(_context.Roteiros, "Id", "Local", roteiroUsuario.RoteiroId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", roteiroUsuario.UsuarioId);
            return View(roteiroUsuario);
        }

        // POST: RoteiroUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoteiroId,UsuarioId,Peso")] RoteiroUsuario roteiroUsuario)
        {
            if (id != roteiroUsuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roteiroUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoteiroUsuarioExists(roteiroUsuario.Id))
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
            ViewData["RoteiroId"] = new SelectList(_context.Roteiros, "Id", "Local", roteiroUsuario.RoteiroId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", roteiroUsuario.UsuarioId);
            return View(roteiroUsuario);
        }

        // GET: RoteiroUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roteiroUsuario = await _context.RoteiroUsuarios
                .Include(r => r.Roteiro)
                .Include(r => r.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roteiroUsuario == null)
            {
                return NotFound();
            }

            return View(roteiroUsuario);
        }

        // POST: RoteiroUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roteiroUsuario = await _context.RoteiroUsuarios.FindAsync(id);
            _context.RoteiroUsuarios.Remove(roteiroUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoteiroUsuarioExists(int id)
        {
            return _context.RoteiroUsuarios.Any(e => e.Id == id);
        }
    }
}
