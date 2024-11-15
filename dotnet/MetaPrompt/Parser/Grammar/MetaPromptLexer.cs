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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public partial class MetaPromptLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LB=1, RB=2, EQ_KW=3, META_KW=4, CHAR=5, IF_KW=6, THEN_KW=7, ELSE_KW=8, 
		VAR_NAME=9;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LB", "RB", "EQ_KW", "META_KW", "CHAR", "IF_KW", "THEN_KW", "ELSE_KW", 
		"VAR_NAME"
	};


	public MetaPromptLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MetaPromptLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static MetaPromptLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\v', '\x37', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\a', '\n', '\x33', '\n', '\n', '\f', '\n', '\xE', '\n', 
		'\x36', '\v', '\n', '\x2', '\x2', '\v', '\x3', '\x3', '\x5', '\x4', '\a', 
		'\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', 
		'\x13', '\v', '\x3', '\x2', '\x4', '\x4', '\x2', '\x43', '\\', '\x63', 
		'|', '\x5', '\x2', '\x32', ';', '\x43', '\\', '\x63', '|', '\x2', '\x37', 
		'\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x3', '\x15', '\x3', '\x2', '\x2', '\x2', '\x5', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\a', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\x1B', '\x3', '\x2', '\x2', '\x2', '\v', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\r', '\x1F', '\x3', '\x2', '\x2', '\x2', '\xF', '#', '\x3', 
		'\x2', '\x2', '\x2', '\x11', ')', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'/', '\x3', '\x2', '\x2', '\x2', '\x15', '\x16', '\a', ']', '\x2', '\x2', 
		'\x16', '\x4', '\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\a', '_', 
		'\x2', '\x2', '\x18', '\x6', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', 
		'\a', '?', '\x2', '\x2', '\x1A', '\b', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'\x1C', '\a', '&', '\x2', '\x2', '\x1C', '\n', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '\x1E', '\v', '\x2', '\x2', '\x2', '\x1E', '\f', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', ' ', '\a', '<', '\x2', '\x2', ' ', '!', '\a', 'k', 
		'\x2', '\x2', '!', '\"', '\a', 'h', '\x2', '\x2', '\"', '\xE', '\x3', 
		'\x2', '\x2', '\x2', '#', '$', '\a', '<', '\x2', '\x2', '$', '%', '\a', 
		'v', '\x2', '\x2', '%', '&', '\a', 'j', '\x2', '\x2', '&', '\'', '\a', 
		'g', '\x2', '\x2', '\'', '(', '\a', 'p', '\x2', '\x2', '(', '\x10', '\x3', 
		'\x2', '\x2', '\x2', ')', '*', '\a', '<', '\x2', '\x2', '*', '+', '\a', 
		'g', '\x2', '\x2', '+', ',', '\a', 'n', '\x2', '\x2', ',', '-', '\a', 
		'u', '\x2', '\x2', '-', '.', '\a', 'g', '\x2', '\x2', '.', '\x12', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x30', '\a', '<', '\x2', '\x2', '\x30', '\x34', 
		'\t', '\x2', '\x2', '\x2', '\x31', '\x33', '\t', '\x3', '\x2', '\x2', 
		'\x32', '\x31', '\x3', '\x2', '\x2', '\x2', '\x33', '\x36', '\x3', '\x2', 
		'\x2', '\x2', '\x34', '\x32', '\x3', '\x2', '\x2', '\x2', '\x34', '\x35', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'\x36', '\x34', '\x3', '\x2', '\x2', '\x2', '\x4', '\x2', '\x34', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
