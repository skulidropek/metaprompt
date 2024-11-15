//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\legov\OneDrive\Documents\GitHub\metaprompt\grammar\MetaPrompt.g4 by ANTLR 4.9.3

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

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public partial class MetaPromptParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LB=1, RB=2, EQ_KW=3, META_KW=4, CHAR=5, IF_KW=6, THEN_KW=7, ELSE_KW=8, 
		VAR_NAME=9;
	public const int
		RULE_prompt = 0, RULE_exprs = 1, RULE_expr = 2, RULE_expr1 = 3, RULE_meta_body = 4, 
		RULE_text = 5;
	public static readonly string[] ruleNames = {
		"prompt", "exprs", "expr", "expr1", "meta_body", "text"
	};

	private static readonly string[] _LiteralNames = {
		null, "'['", "']'", "'='", "'$'", null, "':if'", "':then'", "':else'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LB", "RB", "EQ_KW", "META_KW", "CHAR", "IF_KW", "THEN_KW", "ELSE_KW", 
		"VAR_NAME"
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

	public override string GrammarFileName { get { return "MetaPrompt.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static MetaPromptParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public MetaPromptParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public MetaPromptParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class PromptContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprsContext exprs() {
			return GetRuleContext<ExprsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(MetaPromptParser.Eof, 0); }
		public PromptContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prompt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.EnterPrompt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.ExitPrompt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMetaPromptVisitor<TResult> typedVisitor = visitor as IMetaPromptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrompt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PromptContext prompt() {
		PromptContext _localctx = new PromptContext(Context, State);
		EnterRule(_localctx, 0, RULE_prompt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 12;
			exprs();
			State = 13;
			Match(Eof);
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

	public partial class ExprsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ExprsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exprs; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.EnterExprs(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.ExitExprs(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMetaPromptVisitor<TResult> typedVisitor = visitor as IMetaPromptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprs(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprsContext exprs() {
		ExprsContext _localctx = new ExprsContext(Context, State);
		EnterRule(_localctx, 2, RULE_exprs);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 18;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					State = 15;
					expr();
					}
					} 
				}
				State = 20;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
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

	public partial class ExprContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LB() { return GetToken(MetaPromptParser.LB, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Expr1Context expr1() {
			return GetRuleContext<Expr1Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RB() { return GetToken(MetaPromptParser.RB, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TextContext text() {
			return GetRuleContext<TextContext>(0);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMetaPromptVisitor<TResult> typedVisitor = visitor as IMetaPromptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(Context, State);
		EnterRule(_localctx, 4, RULE_expr);
		try {
			State = 28;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 21;
				Match(LB);
				State = 22;
				expr1();
				State = 23;
				Match(RB);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 25;
				text();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 26;
				Match(RB);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 27;
				Match(LB);
				}
				break;
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

	public partial class Expr1Context : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Meta_bodyContext meta_body() {
			return GetRuleContext<Meta_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprsContext exprs() {
			return GetRuleContext<ExprsContext>(0);
		}
		public Expr1Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr1; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.EnterExpr1(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.ExitExpr1(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMetaPromptVisitor<TResult> typedVisitor = visitor as IMetaPromptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr1(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Expr1Context expr1() {
		Expr1Context _localctx = new Expr1Context(Context, State);
		EnterRule(_localctx, 6, RULE_expr1);
		try {
			State = 32;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case META_KW:
			case IF_KW:
			case VAR_NAME:
				EnterOuterAlt(_localctx, 1);
				{
				State = 30;
				meta_body();
				}
				break;
			case LB:
			case RB:
			case CHAR:
				EnterOuterAlt(_localctx, 2);
				{
				State = 31;
				exprs();
				}
				break;
			default:
				throw new NoViableAltException(this);
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

	public partial class Meta_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF_KW() { return GetToken(MetaPromptParser.IF_KW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprsContext[] exprs() {
			return GetRuleContexts<ExprsContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprsContext exprs(int i) {
			return GetRuleContext<ExprsContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THEN_KW() { return GetToken(MetaPromptParser.THEN_KW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE_KW() { return GetToken(MetaPromptParser.ELSE_KW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode META_KW() { return GetToken(MetaPromptParser.META_KW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VAR_NAME() { return GetToken(MetaPromptParser.VAR_NAME, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQ_KW() { return GetToken(MetaPromptParser.EQ_KW, 0); }
		public Meta_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_meta_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.EnterMeta_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.ExitMeta_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMetaPromptVisitor<TResult> typedVisitor = visitor as IMetaPromptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMeta_body(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Meta_bodyContext meta_body() {
		Meta_bodyContext _localctx = new Meta_bodyContext(Context, State);
		EnterRule(_localctx, 8, RULE_meta_body);
		try {
			State = 52;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 34;
				Match(IF_KW);
				State = 35;
				exprs();
				State = 36;
				Match(THEN_KW);
				State = 37;
				exprs();
				State = 38;
				Match(ELSE_KW);
				State = 39;
				exprs();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 41;
				Match(IF_KW);
				State = 42;
				exprs();
				State = 43;
				Match(THEN_KW);
				State = 44;
				exprs();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 46;
				Match(META_KW);
				State = 47;
				exprs();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 48;
				Match(VAR_NAME);
				State = 49;
				Match(EQ_KW);
				State = 50;
				exprs();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 51;
				Match(VAR_NAME);
				}
				break;
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

	public partial class TextContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CHAR() { return GetTokens(MetaPromptParser.CHAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHAR(int i) {
			return GetToken(MetaPromptParser.CHAR, i);
		}
		public TextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_text; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.EnterText(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.ExitText(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMetaPromptVisitor<TResult> typedVisitor = visitor as IMetaPromptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitText(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TextContext text() {
		TextContext _localctx = new TextContext(Context, State);
		EnterRule(_localctx, 10, RULE_text);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 55;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 54;
					Match(CHAR);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 57;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
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

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\v', '>', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', 
		'\t', '\x6', '\x4', '\a', '\t', '\a', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\a', '\x3', '\x13', '\n', '\x3', '\f', '\x3', '\xE', 
		'\x3', '\x16', '\v', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', 
		'\x1F', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', '#', '\n', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', '\x37', 
		'\n', '\x6', '\x3', '\a', '\x6', '\a', ':', '\n', '\a', '\r', '\a', '\xE', 
		'\a', ';', '\x3', '\a', '\x3', '\x14', '\x2', '\b', '\x2', '\x4', '\x6', 
		'\b', '\n', '\f', '\x2', '\x2', '\x2', '\x41', '\x2', '\xE', '\x3', '\x2', 
		'\x2', '\x2', '\x4', '\x14', '\x3', '\x2', '\x2', '\x2', '\x6', '\x1E', 
		'\x3', '\x2', '\x2', '\x2', '\b', '\"', '\x3', '\x2', '\x2', '\x2', '\n', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\f', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\xE', '\xF', '\x5', '\x4', '\x3', '\x2', '\xF', '\x10', '\a', 
		'\x2', '\x2', '\x3', '\x10', '\x3', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'\x13', '\x5', '\x6', '\x4', '\x2', '\x12', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\x13', '\x16', '\x3', '\x2', '\x2', '\x2', '\x14', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x14', '\x12', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x16', '\x14', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x18', '\a', '\x3', '\x2', '\x2', '\x18', '\x19', '\x5', 
		'\b', '\x5', '\x2', '\x19', '\x1A', '\a', '\x4', '\x2', '\x2', '\x1A', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1F', '\x5', '\f', '\a', 
		'\x2', '\x1C', '\x1F', '\a', '\x4', '\x2', '\x2', '\x1D', '\x1F', '\a', 
		'\x3', '\x2', '\x2', '\x1E', '\x17', '\x3', '\x2', '\x2', '\x2', '\x1E', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x1E', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\x1E', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1F', '\a', '\x3', 
		'\x2', '\x2', '\x2', ' ', '#', '\x5', '\n', '\x6', '\x2', '!', '#', '\x5', 
		'\x4', '\x3', '\x2', '\"', ' ', '\x3', '\x2', '\x2', '\x2', '\"', '!', 
		'\x3', '\x2', '\x2', '\x2', '#', '\t', '\x3', '\x2', '\x2', '\x2', '$', 
		'%', '\a', '\b', '\x2', '\x2', '%', '&', '\x5', '\x4', '\x3', '\x2', '&', 
		'\'', '\a', '\t', '\x2', '\x2', '\'', '(', '\x5', '\x4', '\x3', '\x2', 
		'(', ')', '\a', '\n', '\x2', '\x2', ')', '*', '\x5', '\x4', '\x3', '\x2', 
		'*', '\x37', '\x3', '\x2', '\x2', '\x2', '+', ',', '\a', '\b', '\x2', 
		'\x2', ',', '-', '\x5', '\x4', '\x3', '\x2', '-', '.', '\a', '\t', '\x2', 
		'\x2', '.', '/', '\x5', '\x4', '\x3', '\x2', '/', '\x37', '\x3', '\x2', 
		'\x2', '\x2', '\x30', '\x31', '\a', '\x6', '\x2', '\x2', '\x31', '\x37', 
		'\x5', '\x4', '\x3', '\x2', '\x32', '\x33', '\a', '\v', '\x2', '\x2', 
		'\x33', '\x34', '\a', '\x5', '\x2', '\x2', '\x34', '\x37', '\x5', '\x4', 
		'\x3', '\x2', '\x35', '\x37', '\a', '\v', '\x2', '\x2', '\x36', '$', '\x3', 
		'\x2', '\x2', '\x2', '\x36', '+', '\x3', '\x2', '\x2', '\x2', '\x36', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\x36', '\x32', '\x3', '\x2', '\x2', 
		'\x2', '\x36', '\x35', '\x3', '\x2', '\x2', '\x2', '\x37', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x38', ':', '\a', '\a', '\x2', '\x2', '\x39', '\x38', 
		'\x3', '\x2', '\x2', '\x2', ':', ';', '\x3', '\x2', '\x2', '\x2', ';', 
		'\x39', '\x3', '\x2', '\x2', '\x2', ';', '<', '\x3', '\x2', '\x2', '\x2', 
		'<', '\r', '\x3', '\x2', '\x2', '\x2', '\a', '\x14', '\x1E', '\"', '\x36', 
		';',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
