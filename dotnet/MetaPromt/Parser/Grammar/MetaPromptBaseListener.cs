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


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IMetaPromptListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class MetaPromptBaseListener : IMetaPromptListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MetaPromptParser.prompt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrompt([NotNull] MetaPromptParser.PromptContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MetaPromptParser.prompt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrompt([NotNull] MetaPromptParser.PromptContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MetaPromptParser.exprs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprs([NotNull] MetaPromptParser.ExprsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MetaPromptParser.exprs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprs([NotNull] MetaPromptParser.ExprsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MetaPromptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] MetaPromptParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MetaPromptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] MetaPromptParser.ExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MetaPromptParser.expr1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr1([NotNull] MetaPromptParser.Expr1Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MetaPromptParser.expr1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr1([NotNull] MetaPromptParser.Expr1Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MetaPromptParser.meta_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMeta_body([NotNull] MetaPromptParser.Meta_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MetaPromptParser.meta_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMeta_body([NotNull] MetaPromptParser.Meta_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MetaPromptParser.text"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterText([NotNull] MetaPromptParser.TextContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MetaPromptParser.text"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitText([NotNull] MetaPromptParser.TextContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
