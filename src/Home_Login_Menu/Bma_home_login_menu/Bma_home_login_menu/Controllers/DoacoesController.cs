using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bma_home_login_menu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace Bma_home_login_menu.Controllers
{
    public class DoacoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoacoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Doacoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Doacoes.Include(d => d.Beneficiario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Doacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacoes
                .Include(d => d.Beneficiario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doacao == null)
            {
                return NotFound();
            }

            return View(doacao);
        }

        // GET: Doacoes/Create
        public IActionResult Create()
        {
            ViewData["BeneficiarioId"] = new SelectList(_context.Beneficiarios, "Id", "CPF");
            return View();
        }

        // POST: Doacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BeneficiarioId,Tipo,Data")] Doacao doacao)
        {
           // if (ModelState.IsValid)
           // {
                _context.Add(doacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           // }
            ViewData["BeneficiarioId"] = new SelectList(_context.Beneficiarios, "Id", "CPF", doacao.BeneficiarioId);
            return View(doacao);
        }

        // GET: Doacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacoes.FindAsync(id);
            if (doacao == null)
            {
                return NotFound();
            }
            ViewData["BeneficiarioId"] = new SelectList(_context.Beneficiarios, "Id", "CPF", doacao.BeneficiarioId);
            return View(doacao);
        }

        // POST: Doacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BeneficiarioId,Tipo,Data")] Doacao doacao)
        {
            if (id != doacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoacaoExists(doacao.Id))
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
            ViewData["BeneficiarioId"] = new SelectList(_context.Beneficiarios, "Id", "CPF", doacao.BeneficiarioId);
            return View(doacao);
        }

        // GET: Doacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacoes
                .Include(d => d.Beneficiario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doacao == null)
            {
                return NotFound();
            }

            return View(doacao);
        }

        // POST: Doacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doacao = await _context.Doacoes.FindAsync(id);
            _context.Doacoes.Remove(doacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoacaoExists(int id)
        {
            return _context.Doacoes.Any(e => e.Id == id);
        }
    }
}
