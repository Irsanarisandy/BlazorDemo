using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Data
{
    public class TodoItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
    }
}
