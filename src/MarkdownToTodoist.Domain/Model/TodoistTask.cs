using System;
using System.Collections.Generic;

namespace MarkdownToTodoist.Domain.Model
{
    public class TodoistTask
    {
        public TodoistTask(string parserId)
        {
            ParserId = parserId;
        }

        public string ParserId { get; set; }

        public string Description { get; set; }

        public DateTime DueTo { get; set; }

        // premium feature
        public DateTime? Reminder { get; set; }

        public List<TodoistTask> SubTasks { get; set; } = new List<TodoistTask>();
    }
}