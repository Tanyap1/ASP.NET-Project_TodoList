using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{//between list and task
    public class Detail
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public int TaskId { get; set; }
        public int ListId { get; set; }
        //navigation
        public  Task Task { get; set; }
        public List List { get; set; }
    }
}

