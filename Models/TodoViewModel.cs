using System.Collections.Generic;

namespace AspNet.Models
{
    public class TodoViewModel
    {
        public IEnumerable<TodoItem> Items {get; set;}
    }
}