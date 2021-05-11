//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from F:/development/markdown-to-todoist/src/grammar/TodoistGrammar.g4 by ANTLR 4.9.2

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
		SHARP=1, PERCENT=2, DATETIMESEPARATOR=3, OPEN_SB=4, CLOSE_SB=5, X_LETTER=6, 
		HYPHEN=7, COLON=8, DIGIT=9, INT2=10, INT4=11, NEWLINE=12, PERIOD=13, SPACE=14, 
		TEXT=15;
	public const int
		RULE_project = 0, RULE_task = 1, RULE_subtask = 2, RULE_checkbox = 3, 
		RULE_description = 4, RULE_date = 5, RULE_inline = 6;
	public static readonly string[] ruleNames = {
		"project", "task", "subtask", "checkbox", "description", "date", "inline"
	};

	private static readonly string[] _LiteralNames = {
		null, "'#'", "'%'", "'T'", "'['", "']'", "'x'", "'-'", "':'", null, null, 
		null, null, "'.'", "' '"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SHARP", "PERCENT", "DATETIMESEPARATOR", "OPEN_SB", "CLOSE_SB", 
		"X_LETTER", "HYPHEN", "COLON", "DIGIT", "INT2", "INT4", "NEWLINE", "PERIOD", 
		"SPACE", "TEXT"
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

	public partial class ProjectContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHARP() { return GetToken(TodoistGrammarParser.SHARP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SPACE() { return GetToken(TodoistGrammarParser.SPACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DescriptionContext description() {
			return GetRuleContext<DescriptionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(TodoistGrammarParser.NEWLINE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Eof() { return GetTokens(TodoistGrammarParser.Eof); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof(int i) {
			return GetToken(TodoistGrammarParser.Eof, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DateContext date() {
			return GetRuleContext<DateContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TaskContext[] task() {
			return GetRuleContexts<TaskContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TaskContext task(int i) {
			return GetRuleContext<TaskContext>(i);
		}
		public ProjectContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_project; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.EnterProject(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.ExitProject(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITodoistGrammarVisitor<TResult> typedVisitor = visitor as ITodoistGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProject(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProjectContext project() {
		ProjectContext _localctx = new ProjectContext(Context, State);
		EnterRule(_localctx, 0, RULE_project);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14;
			Match(SHARP);
			State = 15;
			Match(SPACE);
			State = 17;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
			case 1:
				{
				State = 16;
				date();
				}
				break;
			}
			State = 19;
			description();
			State = 20;
			_la = TokenStream.LA(1);
			if ( !(_la==Eof || _la==NEWLINE) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 24;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==DIGIT) {
				{
				{
				State = 21;
				task();
				}
				}
				State = 26;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 28;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				{
				State = 27;
				Match(Eof);
				}
				break;
			}
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

	public partial class TaskContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERIOD() { return GetToken(TodoistGrammarParser.PERIOD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SPACE() { return GetTokens(TodoistGrammarParser.SPACE); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SPACE(int i) {
			return GetToken(TodoistGrammarParser.SPACE, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CheckboxContext checkbox() {
			return GetRuleContext<CheckboxContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DescriptionContext description() {
			return GetRuleContext<DescriptionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DIGIT() { return GetTokens(TodoistGrammarParser.DIGIT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT(int i) {
			return GetToken(TodoistGrammarParser.DIGIT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DateContext date() {
			return GetRuleContext<DateContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(TodoistGrammarParser.NEWLINE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SubtaskContext[] subtask() {
			return GetRuleContexts<SubtaskContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SubtaskContext subtask(int i) {
			return GetRuleContext<SubtaskContext>(i);
		}
		public TaskContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_task; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.EnterTask(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.ExitTask(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITodoistGrammarVisitor<TResult> typedVisitor = visitor as ITodoistGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTask(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TaskContext task() {
		TaskContext _localctx = new TaskContext(Context, State);
		EnterRule(_localctx, 2, RULE_task);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 31;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 30;
				Match(DIGIT);
				}
				}
				State = 33;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==DIGIT );
			State = 35;
			Match(PERIOD);
			State = 36;
			Match(SPACE);
			State = 37;
			checkbox();
			State = 38;
			Match(SPACE);
			State = 40;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
			case 1:
				{
				State = 39;
				date();
				}
				break;
			}
			State = 42;
			description();
			State = 44;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NEWLINE) {
				{
				State = 43;
				Match(NEWLINE);
				}
			}

			State = 49;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==SPACE) {
				{
				{
				State = 46;
				subtask();
				}
				}
				State = 51;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
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

	public partial class SubtaskContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SPACE() { return GetTokens(TodoistGrammarParser.SPACE); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SPACE(int i) {
			return GetToken(TodoistGrammarParser.SPACE, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERIOD() { return GetToken(TodoistGrammarParser.PERIOD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CheckboxContext checkbox() {
			return GetRuleContext<CheckboxContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DescriptionContext description() {
			return GetRuleContext<DescriptionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DIGIT() { return GetTokens(TodoistGrammarParser.DIGIT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT(int i) {
			return GetToken(TodoistGrammarParser.DIGIT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DateContext date() {
			return GetRuleContext<DateContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(TodoistGrammarParser.NEWLINE, 0); }
		public SubtaskContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_subtask; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.EnterSubtask(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.ExitSubtask(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITodoistGrammarVisitor<TResult> typedVisitor = visitor as ITodoistGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSubtask(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SubtaskContext subtask() {
		SubtaskContext _localctx = new SubtaskContext(Context, State);
		EnterRule(_localctx, 4, RULE_subtask);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 52;
			Match(SPACE);
			State = 53;
			Match(SPACE);
			State = 55;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 54;
				Match(DIGIT);
				}
				}
				State = 57;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==DIGIT );
			State = 59;
			Match(PERIOD);
			State = 60;
			Match(SPACE);
			State = 61;
			checkbox();
			State = 62;
			Match(SPACE);
			State = 64;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,8,Context) ) {
			case 1:
				{
				State = 63;
				date();
				}
				break;
			}
			State = 66;
			description();
			State = 68;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NEWLINE) {
				{
				State = 67;
				Match(NEWLINE);
				}
			}

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

	public partial class CheckboxContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_SB() { return GetToken(TodoistGrammarParser.OPEN_SB, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_SB() { return GetToken(TodoistGrammarParser.CLOSE_SB, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SPACE() { return GetToken(TodoistGrammarParser.SPACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode X_LETTER() { return GetToken(TodoistGrammarParser.X_LETTER, 0); }
		public CheckboxContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_checkbox; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.EnterCheckbox(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.ExitCheckbox(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITodoistGrammarVisitor<TResult> typedVisitor = visitor as ITodoistGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCheckbox(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CheckboxContext checkbox() {
		CheckboxContext _localctx = new CheckboxContext(Context, State);
		EnterRule(_localctx, 6, RULE_checkbox);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 70;
			Match(OPEN_SB);
			State = 71;
			_la = TokenStream.LA(1);
			if ( !(_la==X_LETTER || _la==SPACE) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 72;
			Match(CLOSE_SB);
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

	public partial class DescriptionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InlineContext[] inline() {
			return GetRuleContexts<InlineContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InlineContext inline(int i) {
			return GetRuleContext<InlineContext>(i);
		}
		public DescriptionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_description; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.EnterDescription(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.ExitDescription(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITodoistGrammarVisitor<TResult> typedVisitor = visitor as ITodoistGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDescription(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DescriptionContext description() {
		DescriptionContext _localctx = new DescriptionContext(Context, State);
		EnterRule(_localctx, 8, RULE_description);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 75;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 74;
					inline();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 77;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,10,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
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

	public partial class DateContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] PERCENT() { return GetTokens(TodoistGrammarParser.PERCENT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERCENT(int i) {
			return GetToken(TodoistGrammarParser.PERCENT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT4() { return GetToken(TodoistGrammarParser.INT4, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] HYPHEN() { return GetTokens(TodoistGrammarParser.HYPHEN); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HYPHEN(int i) {
			return GetToken(TodoistGrammarParser.HYPHEN, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INT2() { return GetTokens(TodoistGrammarParser.INT2); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT2(int i) {
			return GetToken(TodoistGrammarParser.INT2, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DATETIMESEPARATOR() { return GetToken(TodoistGrammarParser.DATETIMESEPARATOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COLON() { return GetTokens(TodoistGrammarParser.COLON); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON(int i) {
			return GetToken(TodoistGrammarParser.COLON, i);
		}
		public DateContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_date; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.EnterDate(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.ExitDate(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITodoistGrammarVisitor<TResult> typedVisitor = visitor as ITodoistGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDate(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DateContext date() {
		DateContext _localctx = new DateContext(Context, State);
		EnterRule(_localctx, 10, RULE_date);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 79;
			Match(PERCENT);
			State = 80;
			Match(INT4);
			State = 81;
			Match(HYPHEN);
			State = 82;
			Match(INT2);
			State = 83;
			Match(HYPHEN);
			State = 84;
			Match(INT2);
			State = 85;
			Match(DATETIMESEPARATOR);
			State = 86;
			Match(INT2);
			State = 87;
			Match(COLON);
			State = 88;
			Match(INT2);
			State = 89;
			Match(COLON);
			State = 90;
			Match(INT2);
			State = 91;
			Match(PERCENT);
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

	public partial class InlineContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(TodoistGrammarParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHARP() { return GetToken(TodoistGrammarParser.SHARP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERCENT() { return GetToken(TodoistGrammarParser.PERCENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DATETIMESEPARATOR() { return GetToken(TodoistGrammarParser.DATETIMESEPARATOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HYPHEN() { return GetToken(TodoistGrammarParser.HYPHEN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(TodoistGrammarParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT() { return GetToken(TodoistGrammarParser.DIGIT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT2() { return GetToken(TodoistGrammarParser.INT2, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT4() { return GetToken(TodoistGrammarParser.INT4, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERIOD() { return GetToken(TodoistGrammarParser.PERIOD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SPACE() { return GetToken(TodoistGrammarParser.SPACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode X_LETTER() { return GetToken(TodoistGrammarParser.X_LETTER, 0); }
		public InlineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inline; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.EnterInline(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ITodoistGrammarListener typedListener = listener as ITodoistGrammarListener;
			if (typedListener != null) typedListener.ExitInline(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITodoistGrammarVisitor<TResult> typedVisitor = visitor as ITodoistGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInline(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InlineContext inline() {
		InlineContext _localctx = new InlineContext(Context, State);
		EnterRule(_localctx, 12, RULE_inline);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 93;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << SHARP) | (1L << PERCENT) | (1L << DATETIMESEPARATOR) | (1L << X_LETTER) | (1L << HYPHEN) | (1L << COLON) | (1L << DIGIT) | (1L << INT2) | (1L << INT4) | (1L << PERIOD) | (1L << SPACE) | (1L << TEXT))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
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
		'\x5964', '\x3', '\x11', '\x62', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x5', '\x2', '\x14', '\n', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\a', '\x2', '\x19', 
		'\n', '\x2', '\f', '\x2', '\xE', '\x2', '\x1C', '\v', '\x2', '\x3', '\x2', 
		'\x5', '\x2', '\x1F', '\n', '\x2', '\x3', '\x3', '\x6', '\x3', '\"', '\n', 
		'\x3', '\r', '\x3', '\xE', '\x3', '#', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '+', '\n', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x5', '\x3', '/', '\n', '\x3', '\x3', '\x3', '\a', 
		'\x3', '\x32', '\n', '\x3', '\f', '\x3', '\xE', '\x3', '\x35', '\v', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x6', '\x4', ':', '\n', '\x4', 
		'\r', '\x4', '\xE', '\x4', ';', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '\x43', '\n', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x5', '\x4', 'G', '\n', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x6', '\x6', 'N', '\n', 
		'\x6', '\r', '\x6', '\xE', '\x6', 'O', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x2', '\x2', '\t', '\x2', 
		'\x4', '\x6', '\b', '\n', '\f', '\xE', '\x2', '\x5', '\x3', '\x3', '\xE', 
		'\xE', '\x4', '\x2', '\b', '\b', '\x10', '\x10', '\x5', '\x2', '\x3', 
		'\x5', '\b', '\r', '\xF', '\x11', '\x2', '\x65', '\x2', '\x10', '\x3', 
		'\x2', '\x2', '\x2', '\x4', '!', '\x3', '\x2', '\x2', '\x2', '\x6', '\x36', 
		'\x3', '\x2', '\x2', '\x2', '\b', 'H', '\x3', '\x2', '\x2', '\x2', '\n', 
		'M', '\x3', '\x2', '\x2', '\x2', '\f', 'Q', '\x3', '\x2', '\x2', '\x2', 
		'\xE', '_', '\x3', '\x2', '\x2', '\x2', '\x10', '\x11', '\a', '\x3', '\x2', 
		'\x2', '\x11', '\x13', '\a', '\x10', '\x2', '\x2', '\x12', '\x14', '\x5', 
		'\f', '\a', '\x2', '\x13', '\x12', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '\x14', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x15', '\x16', '\x5', '\n', '\x6', '\x2', '\x16', '\x1A', '\t', 
		'\x2', '\x2', '\x2', '\x17', '\x19', '\x5', '\x4', '\x3', '\x2', '\x18', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\x1A', '\x18', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x1C', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1F', '\a', '\x2', '\x2', 
		'\x3', '\x1E', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1E', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x3', '\x2', '\x2', '\x2', ' ', '\"', 
		'\a', '\v', '\x2', '\x2', '!', ' ', '\x3', '\x2', '\x2', '\x2', '\"', 
		'#', '\x3', '\x2', '\x2', '\x2', '#', '!', '\x3', '\x2', '\x2', '\x2', 
		'#', '$', '\x3', '\x2', '\x2', '\x2', '$', '%', '\x3', '\x2', '\x2', '\x2', 
		'%', '&', '\a', '\xF', '\x2', '\x2', '&', '\'', '\a', '\x10', '\x2', '\x2', 
		'\'', '(', '\x5', '\b', '\x5', '\x2', '(', '*', '\a', '\x10', '\x2', '\x2', 
		')', '+', '\x5', '\f', '\a', '\x2', '*', ')', '\x3', '\x2', '\x2', '\x2', 
		'*', '+', '\x3', '\x2', '\x2', '\x2', '+', ',', '\x3', '\x2', '\x2', '\x2', 
		',', '.', '\x5', '\n', '\x6', '\x2', '-', '/', '\a', '\xE', '\x2', '\x2', 
		'.', '-', '\x3', '\x2', '\x2', '\x2', '.', '/', '\x3', '\x2', '\x2', '\x2', 
		'/', '\x33', '\x3', '\x2', '\x2', '\x2', '\x30', '\x32', '\x5', '\x6', 
		'\x4', '\x2', '\x31', '\x30', '\x3', '\x2', '\x2', '\x2', '\x32', '\x35', 
		'\x3', '\x2', '\x2', '\x2', '\x33', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x33', '\x34', '\x3', '\x2', '\x2', '\x2', '\x34', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x35', '\x33', '\x3', '\x2', '\x2', '\x2', '\x36', '\x37', 
		'\a', '\x10', '\x2', '\x2', '\x37', '\x39', '\a', '\x10', '\x2', '\x2', 
		'\x38', ':', '\a', '\v', '\x2', '\x2', '\x39', '\x38', '\x3', '\x2', '\x2', 
		'\x2', ':', ';', '\x3', '\x2', '\x2', '\x2', ';', '\x39', '\x3', '\x2', 
		'\x2', '\x2', ';', '<', '\x3', '\x2', '\x2', '\x2', '<', '=', '\x3', '\x2', 
		'\x2', '\x2', '=', '>', '\a', '\xF', '\x2', '\x2', '>', '?', '\a', '\x10', 
		'\x2', '\x2', '?', '@', '\x5', '\b', '\x5', '\x2', '@', '\x42', '\a', 
		'\x10', '\x2', '\x2', '\x41', '\x43', '\x5', '\f', '\a', '\x2', '\x42', 
		'\x41', '\x3', '\x2', '\x2', '\x2', '\x42', '\x43', '\x3', '\x2', '\x2', 
		'\x2', '\x43', '\x44', '\x3', '\x2', '\x2', '\x2', '\x44', '\x46', '\x5', 
		'\n', '\x6', '\x2', '\x45', 'G', '\a', '\xE', '\x2', '\x2', '\x46', '\x45', 
		'\x3', '\x2', '\x2', '\x2', '\x46', 'G', '\x3', '\x2', '\x2', '\x2', 'G', 
		'\a', '\x3', '\x2', '\x2', '\x2', 'H', 'I', '\a', '\x6', '\x2', '\x2', 
		'I', 'J', '\t', '\x3', '\x2', '\x2', 'J', 'K', '\a', '\a', '\x2', '\x2', 
		'K', '\t', '\x3', '\x2', '\x2', '\x2', 'L', 'N', '\x5', '\xE', '\b', '\x2', 
		'M', 'L', '\x3', '\x2', '\x2', '\x2', 'N', 'O', '\x3', '\x2', '\x2', '\x2', 
		'O', 'M', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\x3', '\x2', '\x2', '\x2', 
		'P', '\v', '\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\a', '\x4', '\x2', '\x2', 
		'R', 'S', '\a', '\r', '\x2', '\x2', 'S', 'T', '\a', '\t', '\x2', '\x2', 
		'T', 'U', '\a', '\f', '\x2', '\x2', 'U', 'V', '\a', '\t', '\x2', '\x2', 
		'V', 'W', '\a', '\f', '\x2', '\x2', 'W', 'X', '\a', '\x5', '\x2', '\x2', 
		'X', 'Y', '\a', '\f', '\x2', '\x2', 'Y', 'Z', '\a', '\n', '\x2', '\x2', 
		'Z', '[', '\a', '\f', '\x2', '\x2', '[', '\\', '\a', '\n', '\x2', '\x2', 
		'\\', ']', '\a', '\f', '\x2', '\x2', ']', '^', '\a', '\x4', '\x2', '\x2', 
		'^', '\r', '\x3', '\x2', '\x2', '\x2', '_', '`', '\t', '\x4', '\x2', '\x2', 
		'`', '\xF', '\x3', '\x2', '\x2', '\x2', '\r', '\x13', '\x1A', '\x1E', 
		'#', '*', '.', '\x33', ';', '\x42', '\x46', 'O',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}