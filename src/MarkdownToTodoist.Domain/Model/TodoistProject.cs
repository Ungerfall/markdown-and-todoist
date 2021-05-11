using System;
using System.Collections.Generic;
using System.Linq;

namespace MarkdownToTodoist.Domain.Model
{
    public class TodoistProject
    {
        public string Name { get; set; }
        public List<TodoistTask> Tasks { get; set; } = new List<TodoistTask>();
        public DateTime? Date { get; set; }

        public TodoistTask this[string index]
        {
            get
            {
                return Tasks
                    .SelectMany(x => x.SubTasks)
                    .Union(Tasks)
                    .FirstOrDefault(x => x.ParserId == index);
            }
        }
    }
}