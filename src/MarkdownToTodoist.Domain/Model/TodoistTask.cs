using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MarkdownToTodoist.Domain.Model
{
    public class TodoistTask
    {
        public TodoistTask(string parserId)
        {
            ParserId = parserId;
        }

        [JsonIgnore]
        public string ParserId { get; set; }

        public string Description { get; set; }

        public DateTime? DueTo { get; set; }

        public bool? IsCompleted { get; set; }

        // premium feature
        [JsonIgnore]
        public DateTime? Reminder { get; set; }

        public List<TodoistTask> SubTasks { get; set; } = new List<TodoistTask>();
    }
}