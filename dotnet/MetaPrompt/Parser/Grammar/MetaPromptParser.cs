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
		LB=1, RB=2, EQ_KW=3, META_KW=4, CHAR=5, USE=6, IF_KW=7, THEN_KW=8, ELSE_KW=9, 
		VAR_NAME=10;
	public const int
		RULE_prompt = 0, RULE_exprs = 1, RULE_expr = 2, RULE_expr1 = 3, RULE_meta_body = 4, 
		RULE_parameters = 5, RULE_text = 6;
	public static readonly string[] ruleNames = {
		"prompt", "exprs", "expr", "expr1", "meta_body", "parameters", "text"
	};

	private static readonly string[] _LiteralNames = {
		null, "'['", "']'", "'='", "'$'", null, null, "':if'", "':then'", "':else'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LB", "RB", "EQ_KW", "META_KW", "CHAR", "USE", "IF_KW", "THEN_KW", 
		"ELSE_KW", "VAR_NAME"
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
			State = 14;
			exprs();
			State = 15;
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
			State = 20;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					State = 17;
					expr();
					}
					} 
				}
				State = 22;
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
			State = 30;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 23;
				Match(LB);
				State = 24;
				expr1();
				State = 25;
				Match(RB);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 27;
				text();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 28;
				Match(RB);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 29;
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
			State = 34;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case META_KW:
			case USE:
			case IF_KW:
			case VAR_NAME:
				EnterOuterAlt(_localctx, 1);
				{
				State = 32;
				meta_body();
				}
				break;
			case LB:
			case RB:
			case CHAR:
				EnterOuterAlt(_localctx, 2);
				{
				State = 33;
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USE() { return GetToken(MetaPromptParser.USE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParametersContext parameters() {
			return GetRuleContext<ParametersContext>(0);
		}
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
		int _la;
		try {
			State = 58;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 36;
				Match(IF_KW);
				State = 37;
				exprs();
				State = 38;
				Match(THEN_KW);
				State = 39;
				exprs();
				State = 40;
				Match(ELSE_KW);
				State = 41;
				exprs();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 43;
				Match(IF_KW);
				State = 44;
				exprs();
				State = 45;
				Match(THEN_KW);
				State = 46;
				exprs();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 48;
				Match(USE);
				State = 50;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==VAR_NAME) {
					{
					State = 49;
					parameters();
					}
				}

				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 52;
				Match(META_KW);
				State = 53;
				exprs();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 54;
				Match(VAR_NAME);
				State = 55;
				Match(EQ_KW);
				State = 56;
				exprs();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 57;
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

	public partial class ParametersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] VAR_NAME() { return GetTokens(MetaPromptParser.VAR_NAME); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VAR_NAME(int i) {
			return GetToken(MetaPromptParser.VAR_NAME, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] EQ_KW() { return GetTokens(MetaPromptParser.EQ_KW); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQ_KW(int i) {
			return GetToken(MetaPromptParser.EQ_KW, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprsContext[] exprs() {
			return GetRuleContexts<ExprsContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprsContext exprs(int i) {
			return GetRuleContext<ExprsContext>(i);
		}
		public ParametersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameters; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.EnterParameters(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMetaPromptListener typedListener = listener as IMetaPromptListener;
			if (typedListener != null) typedListener.ExitParameters(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMetaPromptVisitor<TResult> typedVisitor = visitor as IMetaPromptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParameters(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParametersContext parameters() {
		ParametersContext _localctx = new ParametersContext(Context, State);
		EnterRule(_localctx, 10, RULE_parameters);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 63;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 60;
				Match(VAR_NAME);
				State = 61;
				Match(EQ_KW);
				State = 62;
				exprs();
				}
				}
				State = 65;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==VAR_NAME );
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
		EnterRule(_localctx, 12, RULE_text);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 68;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 67;
					Match(CHAR);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 70;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
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
		'\x5964', '\x3', '\f', 'K', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', 
		'\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\a', '\x3', '\x15', 
		'\n', '\x3', '\f', '\x3', '\xE', '\x3', '\x18', '\v', '\x3', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x5', '\x4', '!', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x5', '\x5', '%', '\n', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x5', '\x6', '\x35', '\n', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', 
		'\x6', '=', '\n', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x6', 
		'\a', '\x42', '\n', '\a', '\r', '\a', '\xE', '\a', '\x43', '\x3', '\b', 
		'\x6', '\b', 'G', '\n', '\b', '\r', '\b', '\xE', '\b', 'H', '\x3', '\b', 
		'\x3', '\x16', '\x2', '\t', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', 
		'\x2', '\x2', '\x2', 'P', '\x2', '\x10', '\x3', '\x2', '\x2', '\x2', '\x4', 
		'\x16', '\x3', '\x2', '\x2', '\x2', '\x6', ' ', '\x3', '\x2', '\x2', '\x2', 
		'\b', '$', '\x3', '\x2', '\x2', '\x2', '\n', '<', '\x3', '\x2', '\x2', 
		'\x2', '\f', '\x41', '\x3', '\x2', '\x2', '\x2', '\xE', '\x46', '\x3', 
		'\x2', '\x2', '\x2', '\x10', '\x11', '\x5', '\x4', '\x3', '\x2', '\x11', 
		'\x12', '\a', '\x2', '\x2', '\x3', '\x12', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x13', '\x15', '\x5', '\x6', '\x4', '\x2', '\x14', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x15', '\x18', '\x3', '\x2', '\x2', '\x2', '\x16', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x16', '\x14', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x5', '\x3', '\x2', '\x2', '\x2', '\x18', '\x16', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '\x1A', '\a', '\x3', '\x2', '\x2', '\x1A', 
		'\x1B', '\x5', '\b', '\x5', '\x2', '\x1B', '\x1C', '\a', '\x4', '\x2', 
		'\x2', '\x1C', '!', '\x3', '\x2', '\x2', '\x2', '\x1D', '!', '\x5', '\xE', 
		'\b', '\x2', '\x1E', '!', '\a', '\x4', '\x2', '\x2', '\x1F', '!', '\a', 
		'\x3', '\x2', '\x2', ' ', '\x19', '\x3', '\x2', '\x2', '\x2', ' ', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', ' ', '\x1E', '\x3', '\x2', '\x2', '\x2', ' ', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '!', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\"', '%', '\x5', '\n', '\x6', '\x2', '#', '%', '\x5', '\x4', '\x3', '\x2', 
		'$', '\"', '\x3', '\x2', '\x2', '\x2', '$', '#', '\x3', '\x2', '\x2', 
		'\x2', '%', '\t', '\x3', '\x2', '\x2', '\x2', '&', '\'', '\a', '\t', '\x2', 
		'\x2', '\'', '(', '\x5', '\x4', '\x3', '\x2', '(', ')', '\a', '\n', '\x2', 
		'\x2', ')', '*', '\x5', '\x4', '\x3', '\x2', '*', '+', '\a', '\v', '\x2', 
		'\x2', '+', ',', '\x5', '\x4', '\x3', '\x2', ',', '=', '\x3', '\x2', '\x2', 
		'\x2', '-', '.', '\a', '\t', '\x2', '\x2', '.', '/', '\x5', '\x4', '\x3', 
		'\x2', '/', '\x30', '\a', '\n', '\x2', '\x2', '\x30', '\x31', '\x5', '\x4', 
		'\x3', '\x2', '\x31', '=', '\x3', '\x2', '\x2', '\x2', '\x32', '\x34', 
		'\a', '\b', '\x2', '\x2', '\x33', '\x35', '\x5', '\f', '\a', '\x2', '\x34', 
		'\x33', '\x3', '\x2', '\x2', '\x2', '\x34', '\x35', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '=', '\x3', '\x2', '\x2', '\x2', '\x36', '\x37', '\a', 
		'\x6', '\x2', '\x2', '\x37', '=', '\x5', '\x4', '\x3', '\x2', '\x38', 
		'\x39', '\a', '\f', '\x2', '\x2', '\x39', ':', '\a', '\x5', '\x2', '\x2', 
		':', '=', '\x5', '\x4', '\x3', '\x2', ';', '=', '\a', '\f', '\x2', '\x2', 
		'<', '&', '\x3', '\x2', '\x2', '\x2', '<', '-', '\x3', '\x2', '\x2', '\x2', 
		'<', '\x32', '\x3', '\x2', '\x2', '\x2', '<', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '<', '\x38', '\x3', '\x2', '\x2', '\x2', '<', ';', '\x3', '\x2', 
		'\x2', '\x2', '=', '\v', '\x3', '\x2', '\x2', '\x2', '>', '?', '\a', '\f', 
		'\x2', '\x2', '?', '@', '\a', '\x5', '\x2', '\x2', '@', '\x42', '\x5', 
		'\x4', '\x3', '\x2', '\x41', '>', '\x3', '\x2', '\x2', '\x2', '\x42', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x43', '\x41', '\x3', '\x2', '\x2', 
		'\x2', '\x43', '\x44', '\x3', '\x2', '\x2', '\x2', '\x44', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x45', 'G', '\a', '\a', '\x2', '\x2', '\x46', '\x45', 
		'\x3', '\x2', '\x2', '\x2', 'G', 'H', '\x3', '\x2', '\x2', '\x2', 'H', 
		'\x46', '\x3', '\x2', '\x2', '\x2', 'H', 'I', '\x3', '\x2', '\x2', '\x2', 
		'I', '\xF', '\x3', '\x2', '\x2', '\x2', '\t', '\x16', ' ', '$', '\x34', 
		'<', '\x43', 'H',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
