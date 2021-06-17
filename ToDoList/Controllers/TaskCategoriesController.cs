using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TaskCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TaskCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.TaskCategories.ToListAsync());
        }

        // GET: TaskCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskCategory = await _context.TaskCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taskCategory == null)
            {
                return NotFound();
            }

            return View(taskCategory);
        }

        // GET: TaskCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaskCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TaskName")] TaskCategory taskCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taskCategory);
        }

        // GET: TaskCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskCategory = await _context.TaskCategories.FindAsync(id);
            if (taskCategory == null)
            {
                return NotFound();
            }
            return View(taskCategory);
        }

        // POST: TaskCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TaskName")] TaskCategory taskCategory)
        {
            if (id != taskCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskCategoryExists(taskCategory.Id))
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
            return View(taskCategory);
        }

        // GET: TaskCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskCategory = await _context.TaskCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taskCategory == null)
            {
                return NotFound();
            }

            return View(taskCategory);
        }

        // POST: TaskCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskCategory = await _context.TaskCategories.FindAsync(id);
            _context.TaskCategories.Remove(taskCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskCategoryExists(int id)
        {
            return _context.TaskCategories.Any(e => e.Id == id);
        }
    }
}
