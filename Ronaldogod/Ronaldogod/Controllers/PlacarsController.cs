using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ronaldogod.Models;

namespace Ronaldogod.Controllers
{
    public class PlacarsController : Controller
    {
        private readonly RonaldogodContext _context;

        public PlacarsController(RonaldogodContext context)
        {
            _context = context;
        }

        // GET: Placars
        public async Task<IActionResult> Index()
        {
            var ronaldogodContext = _context.Placar.Include(p => p.Jogador);
            return View(await ronaldogodContext.ToListAsync());
        }
        public async Task<IActionResult> Top()
        {
           // var ronaldogodContext = _context.Placar.Include(p => p.Jogador).OrderByDescending(p => p.TotalPontos).Take(10);
            //ronaldogodContext.des
           // ronaldogodContext.OrderByDescending(x => x.TotalPontos);

            return View(await _context.Placar.OrderByDescending(x => x.TotalPontos).Take(10).ToListAsync());
        }

        // GET: Placars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placar = await _context.Placar
                .Include(p => p.Jogador)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (placar == null)
            {
                return NotFound();
            }

            return View(placar);
        }

        // GET: Placars/Create
        public IActionResult Create()
        {
            ViewData["JogadorId"] = new SelectList(_context.Jogador, "Id", "Nome");
            return View();
        }

        // POST: Placars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JogadorId,TotalPontos,Dia")] Placar placar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(placar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["JogadorId"] = new SelectList(_context.Jogador, "Id", "Nome", placar.JogadorId);
            return View(placar);
        }

        // GET: Placars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placar = await _context.Placar.FindAsync(id);
            if (placar == null)
            {
                return NotFound();
            }
            ViewData["JogadorId"] = new SelectList(_context.Jogador, "Id", "Nome", placar.JogadorId);
            return View(placar);
        }

        // POST: Placars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JogadorId,TotalPontos,Dia")] Placar placar)
        {
            if (id != placar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(placar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlacarExists(placar.Id))
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
            ViewData["JogadorId"] = new SelectList(_context.Jogador, "Id", "Nome", placar.JogadorId);
            return View(placar);
        }

        // GET: Placars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placar = await _context.Placar
                .Include(p => p.Jogador)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (placar == null)
            {
                return NotFound();
            }

            return View(placar);
        }

        // POST: Placars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var placar = await _context.Placar.FindAsync(id);
            _context.Placar.Remove(placar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlacarExists(int id)
        {
            return _context.Placar.Any(e => e.Id == id);
        }
    }
}
