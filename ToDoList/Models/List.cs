using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class List
    {
        public int Id { get; set; }
        [Required]

        public string Task { get; set; }
        public String DueDate { get; set; }

        public int Duetime { get; set; }
        public bool IsDone { get; set; }
        }
    
        }
    