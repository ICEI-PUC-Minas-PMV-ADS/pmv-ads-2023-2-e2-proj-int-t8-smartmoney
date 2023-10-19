using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using smartmoney.Models;

namespace smartmoney.Controllers
{
    public class TransacoesController : Controller
    {
        private readonly AppDbContext _context;

        public TransacoesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Transacoes
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Transacoes.Include(t => t.Carteira).Include(t => t.Categoria);
            var transacoes = await appDbContext.ToListAsync();
            ViewBag.receita = await GetValores(TipoTransacao.Receita);
            ViewBag.despesa = await GetValores(TipoTransacao.Despesa);

            return View(transacoes);
        }

        // GET: Transacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transacoes == null)
            {
                return NotFound();
            }

            var transacao = await _context.Transacoes
                .Include(t => t.Carteira)
                .Include(t => t.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transacao == null)
            {
                return NotFound();
            }

            return View(transacao);
        }

        // GET: Transacoes/Create
        public IActionResult Create()
        {
            ViewData["CarteiraId"] = new SelectList(_context.Carteiras, "Id", "Titulo");
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Titulo");
            return View();
        }

        // POST: Transacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Valor,Data,Descricao,Tipo,CarteiraId,CategoriaId")] Transacao transacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transacao);
                await _context.SaveChangesAsync();

                var carteira = await _context.Carteiras.FindAsync(transacao.CarteiraId);
                if (carteira is not null)
                {
                    if (transacao.Tipo == TipoTransacao.Receita)
                    {
                        carteira.Saldo += transacao.Valor;
                    }
                    else
                    {
                        carteira.Saldo -= transacao.Valor;
                    }
                    _context.Update(carteira);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarteiraId"] = new SelectList(_context.Carteiras, "Id", "Titulo", transacao.CarteiraId);
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Titulo", transacao.CategoriaId);
            return View(transacao);
        }

        // GET: Transacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transacoes == null)
            {
                return NotFound();
            }

            var transacao = await _context.Transacoes.FindAsync(id);
            if (transacao == null)
            {
                return NotFound();
            }
            ViewData["CarteiraId"] = new SelectList(_context.Carteiras, "Id", "Titulo", transacao.CarteiraId);
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Titulo", transacao.CategoriaId);
            return View(transacao);
        }

        // POST: Transacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Valor,Data,Descricao,Tipo,CarteiraId,CategoriaId")] Transacao transacao)
        {
            if (id != transacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransacaoExists(transacao.Id))
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
            ViewData["CarteiraId"] = new SelectList(_context.Carteiras, "Id", "Titulo", transacao.CarteiraId);
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Titulo", transacao.CategoriaId);
            return View(transacao);
        }

        // GET: Transacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Transacoes == null)
            {
                return NotFound();
            }

            var transacao = await _context.Transacoes
                .Include(t => t.Carteira)
                .Include(t => t.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transacao == null)
            {
                return NotFound();
            }

            return View(transacao);
        }

        // POST: Transacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transacoes == null)
            {
                return Problem("Entity set 'AppDbContext.Transacoes'  is null.");
            }
            var transacao = await _context.Transacoes.FindAsync(id);
            if (transacao != null)
            {
                _context.Transacoes.Remove(transacao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransacaoExists(int id)
        {
            return (_context.Transacoes?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private async Task<decimal> GetValores(TipoTransacao tipo)  {
            return _context.Transacoes
                .Where(transacao => transacao.Tipo == tipo)
                .Sum(transacao => transacao.Valor);
        }
    }
}
