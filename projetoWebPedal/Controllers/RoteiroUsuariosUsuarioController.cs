using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projetoWebPedal.Models;

namespace projetoWebPedal.Controllers
{
    [Authorize]
    public class RoteiroUsuariosUsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoteiroUsuariosUsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoteiroUsuariosUsuario
        public async Task<IActionResult> Index()
        {
            string nomeUsuario = User.Identity.Name;
            ViewData["Usuario"] = nomeUsuario;

            var applicationDbContext = _context.RoteiroUsuarios.Include(r => r.Roteiro).Include(r => r.Usuario);
            //var applicationDbContext = _context.RoteiroUsuarios.Include(r => r.Roteiro);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RoteiroUsuariosUsuario/Details/5
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

        // GET: RoteiroUsuariosUsuario/Create
        public IActionResult Create()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            string nomeUsuario = User.Identity.Name;
            var usuarioLogado = _context.Usuarios
                .FirstOrDefault(u => u.Nome == userId);
            //ViewData["Usuario"] = nomeUsuario;
            ViewData["RoteiroId"] = new SelectList(_context.Roteiros, "Id", "Local");
            ViewData["UsuarioId"] = new SelectList(new[] { usuarioLogado }, "Id", "Nome");
            //ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome");
            return View();
        }

        // POST: RoteiroUsuariosUsuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoteiroId,UsuarioId,Peso")] RoteiroUsuario roteiroUsuario)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            string nomeUsuario = User.Identity.Name;
            var usuarioLogado = _context.Usuarios
                .FirstOrDefault(u => u.Nome == userId);

            if (ModelState.IsValid)
            {
                _context.Add(roteiroUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoteiroId"] = new SelectList(_context.Roteiros, "Id", "Local", roteiroUsuario.RoteiroId);
            //ViewData["UsuarioId"] = roteiroUsuario.UsuarioId;
            ViewData["UsuarioId"] = usuarioLogado.Id;
            //ViewData["UsuarioId"] = new SelectList(new[] { usuarioLogado }, "Id", "Nome");
            return View(roteiroUsuario);
        }

        // GET: RoteiroUsuariosUsuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            string nomeUsuario = User.Identity.Name;
            var usuarioLogado = _context.Usuarios
                .FirstOrDefault(u => u.Nome == userId);

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
            ViewData["UsuarioId"] = new SelectList(new[] { usuarioLogado }, "Id", "Nome");
            return View(roteiroUsuario);
        }

        // POST: RoteiroUsuariosUsuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoteiroId,UsuarioId,Peso")] RoteiroUsuario roteiroUsuario)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            string nomeUsuario = User.Identity.Name;
            var usuarioLogado = _context.Usuarios
                .FirstOrDefault(u => u.Nome == userId);

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
            ViewData["UsuarioId"] = new SelectList(new[] { usuarioLogado }, "Id", "Nome");
            return View(roteiroUsuario);
        }

        // GET: RoteiroUsuariosUsuario/Delete/5
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

        // POST: RoteiroUsuariosUsuario/Delete/5
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
