using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TaskCategory
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public List<Task> Tasks { get; set; }

    }
}
