using System;
using System.Collections.Generic;

namespace MarkdownToTodoist.Core.Model
{
	public class TodoistTask
	{
		public string Description { get; set; }
		public string Project { get; set; }
		public DateTime DueTo { get; set; }
		public DateTime? Reminder { get; set; }
		public IEnumerable<TodoistTask> SubTasks { get; set; }
	}
}