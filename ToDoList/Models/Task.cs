using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(0,10)]
        public int Importance { get; set; }
        public string Image { get; set; }

        //foreign key
        public int ListId { get; set;}
        public int TaskCategoryId { get; set; }
        //naming convention
        public List List { get; set; }
        public TaskCategory TaskCategory { get; set; }
    }
}
