using MarkdownToTodoist.Domain.Model;
using System;
using System.Globalization;

namespace MarkdownToTodoist.Parser
{
    public class Visitor : TodoistGrammarBaseVisitor<TodoistProject>
    {
        protected override TodoistProject DefaultResult { get; } = new TodoistProject();

        public override TodoistProject VisitDate(TodoistGrammarParser.DateContext context)
        {
            char percent = TodoistGrammarLexer.DefaultVocabulary.GetLiteralName(TodoistGrammarParser.PERCENT).Trim('\'')[0];
            var datetimeString = context.GetText().Trim(percent);
            var date = DateTime.ParseExact(datetimeString, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            var project = base.VisitDate(context);

            if (context.Parent.RuleIndex == TodoistGrammarParser.RULE_project)
            {
                project.Date = date;
            }
            else if (context.Parent.RuleIndex == TodoistGrammarParser.RULE_task)
            {
                var taskContext = (TodoistGrammarParser.TaskContext)context.Parent;
                var task = GetTask(project, taskContext.Start.Line.ToString());
                task.DueTo = date;
            }
            else if (context.Parent.RuleIndex == TodoistGrammarParser.RULE_subtask)
            {
                var subtaskContext = (TodoistGrammarParser.SubtaskContext)context.Parent;
                var taskContext = (TodoistGrammarParser.TaskContext)context.Parent.Parent;
                var subTask = GetSubTask(project, subtaskContext.Start.Line.ToString(), taskContext.Start.Line.ToString());
                subTask.DueTo = date;
            }

            return project;
        }

        private TodoistTask GetTask(TodoistProject project, string id)
        {
            var task = project[id];
            if (task == null)
            {
                var newTask = new TodoistTask(id);
                project.Tasks.Add(newTask);
                return newTask;
            }

            return task;
        }

        private TodoistTask GetSubTask(TodoistProject project, string id, string taskId)
        {
            var task = GetTask(project, taskId);
            var subTask = project[id];
            if (subTask == null)
            {
                var newSubTask = new TodoistTask(id);
                task.SubTasks.Add(newSubTask);
                return newSubTask;
            }

            return subTask;
        }
    }
}