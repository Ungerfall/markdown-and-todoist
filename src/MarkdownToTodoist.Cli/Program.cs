using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using MarkdownToTodoist.Parser;
using System;
using System.Text.Json;

namespace MarkdownToTodoist.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"# ANLTR4 event %2021-05-12T18:00:00%
1. Create presentation %2021-04-14T23:59:59%
2. Create an abstract %2021-04-21T23:59:59%";

            ICharStream stream = CharStreams.fromString(input);
            ITokenSource lexer = new TodoistGrammarLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            var parser = new TodoistGrammarParser(tokens);
            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ConsoleErrorListener());
            parser.BuildParseTree = true;
            var visitor = new Visitor();
            IParseTree tree = parser.project();
            var project = visitor.Visit(tree);

            Console.WriteLine(JsonSerializer.Serialize(
                project,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }));

            Console.ReadLine();
        }
    }
}
