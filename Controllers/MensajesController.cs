using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Chat.Data;
using Chat.Data.Entities;
using System.Collections.Generic;
using System.Collections;

namespace Chat.Controllers
{
    public class MensajesController : Controller
    {
        private readonly DataContext _context;

        public MensajesController(DataContext context)
        {
            _context = context;
        }

        // GET: Mensajes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mensajes.ToListAsync());
        }

        // GET: Mensajes/Details/5
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var mensaje = await _context.Mensajes
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (mensaje == null)
            {
                return NotFound();
            }

            return View(mensaje);
        }

        // GET: Mensajes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mensajes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Enviado,MensajeEnviado,UsuarioEmisor")] Mensaje message)
        {
            if (ModelState.IsValid)
            {
                _context.Add(message);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(message);
        }

        // GET: Mensajes/Edit/5
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var mensaje = await _context.Mensajes.FindAsync(Id);
            if (mensaje == null)
            {
                return NotFound();
            }
            return View(mensaje);
        }

        // POST: Mensajes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Enviado,MensajeEnviado,UsuarioEmisor")] Mensaje message)
        {
            if (id != message.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(message);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MensajeExists(message.Id))
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
            return View(message);
        }

        // GET: Mensajes/Delete/5
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var message = await _context.Mensajes
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // POST: Mensajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var message = await _context.Mensajes.FindAsync(Id);
            _context.Mensajes.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MensajeExists(int Id)
        {
            return _context.Mensajes.Any(e => e.Id == Id);
        }
    }
}
