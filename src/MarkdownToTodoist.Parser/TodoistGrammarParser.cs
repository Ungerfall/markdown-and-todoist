//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ../../development/markdown-to-todoist/src/grammar/TodoistGrammar.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class TodoistGrammarParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, ID=2, WS=3;
	public const int
		RULE_r = 0;
	public static readonly string[] ruleNames = {
		"r"
	};

	private static readonly string[] _LiteralNames = {
		null, "'hello'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "ID", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "TodoistGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static TodoistGrammarParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public TodoistGrammarParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public TodoistGrammarParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class RContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(TodoistGrammarParser.ID, 0); }
		public RContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_r; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.EnterR(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.ExitR(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITodoistGrammarVisitor<TResult> typedVisitor = visitor as ITodoistGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitR(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RContext r() {
		RContext _localctx = new RContext(Context, State);
		EnterRule(_localctx, 0, RULE_r);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2;
			Match(T__0);
			State = 3;
			Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x5', '\b', '\x4', '\x2', '\t', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x2', '\x2', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x6', '\x2', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'\x4', '\x5', '\a', '\x3', '\x2', '\x2', '\x5', '\x6', '\a', '\x4', '\x2', 
		'\x2', '\x6', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
