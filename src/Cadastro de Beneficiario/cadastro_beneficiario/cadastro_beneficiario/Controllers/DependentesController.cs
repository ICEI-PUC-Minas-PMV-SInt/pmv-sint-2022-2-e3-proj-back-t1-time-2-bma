using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cadastro_beneficiario.Models;

namespace cadastro_beneficiario.Controllers
{
    public class DependentesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DependentesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dependentes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Dependentes.Include(d => d.Beneficiario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Dependentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Dependentes == null)
            {
                return NotFound();
            }

            var dependente = await _context.Dependentes
                .Include(d => d.Beneficiario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dependente == null)
            {
                return NotFound();
            }

            return View(dependente);
        }

        // GET: Dependentes/Create
        public IActionResult Create()
        {
            ViewData["BeneficiarioId"] = new SelectList(_context.Beneficiarios, "Id", "Bairro");
            return View();
        }

        // POST: Dependentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Data_Nascimento,BeneficiarioId")] Dependente dependente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dependente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BeneficiarioId"] = new SelectList(_context.Beneficiarios, "Id", "Bairro", dependente.BeneficiarioId);
            return View(dependente);
        }

        // GET: Dependentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Dependentes == null)
            {
                return NotFound();
            }

            var dependente = await _context.Dependentes.FindAsync(id);
            if (dependente == null)
            {
                return NotFound();
            }
            ViewData["BeneficiarioId"] = new SelectList(_context.Beneficiarios, "Id", "Bairro", dependente.BeneficiarioId);
            return View(dependente);
        }

        // POST: Dependentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Data_Nascimento,BeneficiarioId")] Dependente dependente)
        {
            if (id != dependente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dependente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DependenteExists(dependente.Id))
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
            ViewData["BeneficiarioId"] = new SelectList(_context.Beneficiarios, "Id", "Bairro", dependente.BeneficiarioId);
            return View(dependente);
        }

        // GET: Dependentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dependentes == null)
            {
                return NotFound();
            }

            var dependente = await _context.Dependentes
                .Include(d => d.Beneficiario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dependente == null)
            {
                return NotFound();
            }

            return View(dependente);
        }

        // POST: Dependentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dependentes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Dependentes'  is null.");
            }
            var dependente = await _context.Dependentes.FindAsync(id);
            if (dependente != null)
            {
                _context.Dependentes.Remove(dependente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DependenteExists(int id)
        {
          return _context.Dependentes.Any(e => e.Id == id);
        }
    }
}
