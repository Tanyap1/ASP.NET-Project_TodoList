using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class List
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
        }
     public class ToDoList
    {
        public List<List>List { get; set; }
    }
        }
    