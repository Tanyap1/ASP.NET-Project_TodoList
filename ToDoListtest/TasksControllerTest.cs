using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Controllers;
using ToDoList.Data;
using ToDoList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListtest
{
    [TestClass]
    public class TasksControllerTest
    {
        private ApplicationDbContext _context;
        List<ToDoList.Models.Task> tasks = new List<ToDoList.Models.Task>();
        TasksController controller;


        [TestInitialize]

        public void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            _context = new ApplicationDbContext(options);

            var list = new List { Id = 100, Task = "Test Category" };
            _ = _context.Lists.Add(list);
            _context.SaveChanges();

            tasks.Add(new ToDoList.Models.Task { Id = 101, Name = "name1", ListId = 100 });
            tasks.Add(new ToDoList.Models.Task { Id = 102, Name = "name2", ListId = 101 });
            tasks.Add(new ToDoList.Models.Task { Id = 103, Name = "name3", ListId = 102 });

            foreach (var p in tasks)

            {
                _context.Tasks.Add(p);
            }
            _context.SaveChanges();
            controller = new TasksController(_context);
        }
        [TestMethod]
        public void IndexViewLoads()
        {
            var result = controller.Index();
            var viewResult =  result as ViewResult;
            Assert.AreEqual("Index", viewResult.ViewName);
        }
        [TestMethod]
        public void IndexReturnsTaskData()

        {
            var result = controller.Index();
            var viewResult =
                result as ViewResult;
            var model = (List<ToDoList.Models.Task>)viewResult.Model;
            CollectionAssert.AreEqual(tasks, model);
        }
    }
}