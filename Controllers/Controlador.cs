using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuanAlvarez_ExamenP1.Data;
using JuanAlvarez_ExamenP1.Models;

namespace JuanAlvarez_ExamenP1.Controllers
{
    public class JuanAlvarez_tablaController : Controller
    {
        private readonly JuanAlvarez_ExamenP1Context _context;

        public JuanAlvarez_tablaController(JuanAlvarez_ExamenP1Context context)
        {
            _context = context;
        }

        // GET: JuanAlvarez_tabla
        public async Task<IActionResult> Index()
        {
              return _context.JuanAlvarez_tabla != null ? 
                          View(await _context.JuanAlvarez_tabla.ToListAsync()) :
                          Problem("Entity set 'JuanAlvarez_ExamenP1Context.JuanAlvarez_tabla'  is null.");
        }

        // GET: JuanAlvarez_tabla/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.JuanAlvarez_tabla == null)
            {
                return NotFound();
            }

            var juanAlvarez_tabla = await _context.JuanAlvarez_tabla
                .FirstOrDefaultAsync(m => m.jaCedula == id);
            if (juanAlvarez_tabla == null)
            {
                return NotFound();
            }

            return View(juanAlvarez_tabla);
        }

        // GET: JuanAlvarez_tabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JuanAlvarez_tabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("jaEdad,jaNombre,jaAñosEmpresa,jaSalario,jaCedula,jaCorreo,jaNacimiento")] JuanAlvarez_tabla juanAlvarez_tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(juanAlvarez_tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(juanAlvarez_tabla);
        }

        // GET: JuanAlvarez_tabla/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.JuanAlvarez_tabla == null)
            {
                return NotFound();
            }

            var juanAlvarez_tabla = await _context.JuanAlvarez_tabla.FindAsync(id);
            if (juanAlvarez_tabla == null)
            {
                return NotFound();
            }
            return View(juanAlvarez_tabla);
        }

        // POST: JuanAlvarez_tabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("jaEdad,jaNombre,jaAñosEmpresa,jaSalario,jaCedula,jaCorreo,jaNacimiento")] JuanAlvarez_tabla juanAlvarez_tabla)
        {
            if (id != juanAlvarez_tabla.jaCedula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(juanAlvarez_tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JuanAlvarez_tablaExists(juanAlvarez_tabla.jaCedula))
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
            return View(juanAlvarez_tabla);
        }

        // GET: JuanAlvarez_tabla/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.JuanAlvarez_tabla == null)
            {
                return NotFound();
            }

            var juanAlvarez_tabla = await _context.JuanAlvarez_tabla
                .FirstOrDefaultAsync(m => m.jaCedula == id);
            if (juanAlvarez_tabla == null)
            {
                return NotFound();
            }

            return View(juanAlvarez_tabla);
        }

        // POST: JuanAlvarez_tabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.JuanAlvarez_tabla == null)
            {
                return Problem("Entity set 'JuanAlvarez_ExamenP1Context.JuanAlvarez_tabla'  is null.");
            }
            var juanAlvarez_tabla = await _context.JuanAlvarez_tabla.FindAsync(id);
            if (juanAlvarez_tabla != null)
            {
                _context.JuanAlvarez_tabla.Remove(juanAlvarez_tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JuanAlvarez_tablaExists(string id)
        {
          return (_context.JuanAlvarez_tabla?.Any(e => e.jaCedula == id)).GetValueOrDefault();
        }
    }
}
