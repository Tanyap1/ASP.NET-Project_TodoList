using System;
using System.Threading.Tasks;

namespace ToDoList.Controllers
{
    public class IformFile
    {
        public string FileName { get; internal set; }

        internal Task CopyToAsync(object stream)
        {
            throw new NotImplementedException();
        }
    }
}