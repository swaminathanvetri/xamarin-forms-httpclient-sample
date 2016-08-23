using System;

namespace demo_web_api.Models
{
    public class TodoItem
    {
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool isDone { get; set; }
    }
}