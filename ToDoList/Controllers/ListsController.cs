using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ListsController : Controller
    {
        public IActionResult Index()
        {
            var lists = new List<List>();

            lists.Add(new List { Id = 1, Task = "Wake up", DueDate, IsDone = false });
            lists.Add(item: new List { Id = 2, Task = "Create Daily Time Management", DueDate, IsDone = false });
            lists.Add(new List { Id = 3, Task = "Attend classes",DueDate= , IsDone=false});
            lists.Add(new List { Id = 4, Task = "Send an email update to the team: 9am today", DueDate =, IsDone= false});
            lists.Add(new List { Id = 5, Task = "Gym", DueDate = , IsDone= false});



            return View(lists);
        }
        //get:/lists/details?name=some Details
        public IActionResult Details(string name)
        { 
            ViewBag.name = name;
            return View();
        }
    }
}
