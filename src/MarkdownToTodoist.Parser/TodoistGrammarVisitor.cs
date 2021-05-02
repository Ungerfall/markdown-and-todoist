namespace MarkdownToTodoist.Parser
{
    public class TodoistGrammarVisitor : TodoistGrammarBaseVisitor<string>
    {
        public override string VisitR(TodoistGrammarParser.RContext context)
        {
            var id = context.ID();
            return base.VisitR(context);
        }
    }
}