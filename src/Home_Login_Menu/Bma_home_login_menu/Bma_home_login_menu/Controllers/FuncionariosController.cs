using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bma_home_login_menu.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Bma_home_login_menu.Controllers
{
    [Authorize]
    public class FuncionariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FuncionariosController(ApplicationDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([Bind("Cpf,Senha")] Funcionario funcionario)
        {
            var user = await _context.Funcionarios
              .FirstOrDefaultAsync(m => m.Cpf == funcionario.Cpf);

            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou Senha inválidos!";
                return View();
            }

           // bool senhaOk = BCrypt.Net.BCrypt.Verify(funcionario.Senha, user.Senha);

            //if (senhaOk)
            {
                //Criar a credencial, a utenticação ficará no cache da aplicação.
                var claims = new List<Claim>
                {
                  new Claim (ClaimTypes.Name, user.Nome),
                  new Claim (ClaimTypes.NameIdentifier, user.Nome),
                  new Claim (ClaimTypes.Role, user.Perfil_acesso.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                //Quando vai expirar a senha
                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(1),
                    IsPersistent = true,

                };

                //Inserindo o usuário na sessão da aplicação
                await HttpContext.SignInAsync(principal, props);

                return Redirect("Logado");

            }

            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Funcionarios");
        }
   
        public async Task<IActionResult> Logado()
        {
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }

        // GET: Funcionarios
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Index()
        {
              return View(await _context.Funcionarios.ToListAsync());
        }

        // GET: Funcionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Funcionarios == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // GET: Funcionarios/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,Data_nascimento,Email,Telefone,Cep,Logradouro,Numero,Complemento,Bairro,Cidade,Uf,Situacao,Perfil_acesso,Senha")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                //funcionario.Senha = BCrypt.Net.BCrypt.HashPassword(funcionario.Senha);
                _context.Add(funcionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        // GET: Funcionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Funcionarios == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios.FindAsync(id);
            if (funcionario == null)
            {
                return NotFound();
            }
            return View(funcionario);
        }

        // POST: Funcionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cpf,Data_nascimento,Email,Telefone,Cep,Logradouro,Numero,Complemento,Bairro,Cidade,Uf,Situacao,Perfil_acesso,Senha")] Funcionario funcionario)
        {
            if (id != funcionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    funcionario.Senha = BCrypt.Net.BCrypt.HashPassword(funcionario.Senha);
                    _context.Update(funcionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionarioExists(funcionario.Id))
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
            return View(funcionario);
        }

        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Funcionarios == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Funcionarios == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Funcionarios'  is null.");
            }
            var funcionario = await _context.Funcionarios.FindAsync(id);
            if (funcionario != null)
            {
                _context.Funcionarios.Remove(funcionario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionarioExists(int id)
        {
          return _context.Funcionarios.Any(e => e.Id == id);
        }
    }
}
