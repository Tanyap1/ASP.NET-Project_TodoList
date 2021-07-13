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
    public class TaskListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskListController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TaskList
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Tasks.Include(t => t.List);
            return View(await applicationDbContext.ToListAsync());
        }

       
    }
}
