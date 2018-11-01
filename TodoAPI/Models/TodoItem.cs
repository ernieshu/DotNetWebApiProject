using System;
namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public String name { get; set; }
        public bool IsComplete { get; set; }

        public TodoItem()
        {
        }
    }
}
