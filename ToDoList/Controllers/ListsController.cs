using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ListsController : Controller
    {
        public IActionResult Index()
        {
            var lists = new List<List>();

            lists.Add(new List { Id = 1, Task = "Wake up", DueDate="June 16",Duetime=7, IsDone = false});
            lists.Add( new List { Id = 2, Task = "Create Daily Time Management", DueDate="June 16",Duetime=9, IsDone = false });
            lists.Add(new List { Id = 3, Task = "Attend classes",DueDate="June 16 ",Duetime=11 , IsDone=false});
            lists.Add(new List { Id = 4, Task = "Send an email update to the team: 9am today", DueDate ="June 16",Duetime=9, IsDone= false});
            lists.Add(new List { Id = 5, Task = "Gym", DueDate ="June 16" ,Duetime=7, IsDone= false});



            return View(lists);
        }
        //get:/lists/details?name=some Details
        public IActionResult Details(string name)
        {
            if (name == null)
            {
                return BadRequest();
            }
            ViewBag.name = name;
            return View();
        }

        //lists/create
        public IActionResult Create()
        {
            
            return View();
        }
    }
}
