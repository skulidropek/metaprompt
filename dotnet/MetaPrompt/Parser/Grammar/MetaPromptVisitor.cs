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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MetaPromptParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public interface IMetaPromptVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaPromptParser.prompt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrompt([NotNull] MetaPromptParser.PromptContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaPromptParser.exprs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprs([NotNull] MetaPromptParser.ExprsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaPromptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] MetaPromptParser.ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaPromptParser.expr1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr1([NotNull] MetaPromptParser.Expr1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaPromptParser.meta_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMeta_body([NotNull] MetaPromptParser.Meta_bodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaPromptParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitText([NotNull] MetaPromptParser.TextContext context);
}
