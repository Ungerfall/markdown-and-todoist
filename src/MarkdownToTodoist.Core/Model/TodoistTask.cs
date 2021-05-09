using System;
using System.Collections.Generic;

namespace MarkdownToTodoist.Core.Model
{
    public class TodoistTask
    {
        public string Description { get; set; }

        public DateTime DueTo { get; set; }

        // premium feature
        public DateTime? Reminder { get; set; }

        public IEnumerable<TodoistTask> SubTasks { get; set; }
    }

    public class TodoistProject
    {
        public string Name { get; set; }
        public List<TodoistTask> Tasks { get; set; } = new List<TodoistTask>();
        public DateTime? Date { get; set; }
    }
}