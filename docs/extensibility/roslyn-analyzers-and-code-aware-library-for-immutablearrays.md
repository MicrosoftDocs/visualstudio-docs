---
title: Roslyn analyzers and code-aware libraries for ImmutableArrays
description: Learn how to build a real world Roslyn analyzer to catch common errors when using the System.Collections.Immutable NuGet package.
titleSuffix: ""
ms.date: 11/04/2016
ms.topic: article
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Roslyn analyzers and code-aware library for ImmutableArrays

The [.NET Compiler Platform](https://github.com/dotnet/roslyn) ("Roslyn") helps you build code-aware libraries. A code-aware library provides functionality you can use and tooling (Roslyn analyzers) to help you use the library in the best way or to avoid errors. This topic shows you how to build a real world Roslyn analyzer to catch common errors when using the [System.Collections.Immutable](https://www.nuget.org/packages/System.Collections.Immutable) NuGet package. The example also demonstrates how to provide a code fix for a code issue found by the analyzer. Users see code fixes in the Visual Studio light bulb UI and can apply a fix for the code automatically.

## Get started

You need the following to build this example:

* Visual Studio 2015 (not an Express Edition) or a later version. You can use the free [Visual Studio Community Edition](https://visualstudio.microsoft.com/vs/community/)
* [Visual Studio SDK](../extensibility/visual-studio-sdk.md). You can also, when installing Visual Studio, check **Visual Studio Extensibility Tools** under **Common Tools** to install the SDK at the same time. If you have already installed Visual Studio, you can also install this SDK by going to the main menu **File** > **New** > **Project**, choosing **C#** in the left navigation pane, and then choosing **Extensibility**. When you choose the "**Install the Visual Studio Extensibility Tools**" breadcrumb project template, it prompts you to download and install the SDK.
* [.NET Compiler Platform ("Roslyn") SDK](https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.NETCompilerPlatformSDK). You can also install this SDK by going to the main menu **File** > **New** > **Project**, choosing **C#** in the left navigation pane, and then choosing **Extensibility**. When you choose "**Download the .NET Compiler Platform SDK**" breadcrumb project template, it prompts you to download and install the SDK. This SDK includes the [Roslyn Syntax Visualizer](https://github.com/dotnet/roslyn/blob/main/docs/wiki/Syntax-Visualizer.md). This useful tool helps you figure out what code model types you should look for in your analyzer. The analyzer infrastructure calls into your code for specific code model types, so your code only executes when necessary and can focus only on analyzing relevant code.

## What's the problem?

Imagine you provide a library with ImmutableArray (for example, <xref:System.Collections.Immutable.ImmutableArray%601?displayProperty=fullName>) support. C# developers have lots of experience with .NET arrays. However, due to the nature of ImmutableArrays and optimization techniques used in the implementation, C# developer intuitions cause users of your library to write broken code, as explained below. Furthermore, users do not see their errors until run time, which isn't the quality experience they are used to in Visual Studio with .NET.

Users are familiar with writing code like the following:

```csharp
var a1 = new int[0];
Console.WriteLine("a1.Length = {0}", a1.Length);
var a2 = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("a2.Length = {0}", a2.Length);
```

Creating empty arrays to fill in with subsequent lines of code and using collection initializer syntax are familiar to C# developers. However, writing the same code for an ImmutableArray crashes at run time:

```csharp
var b1 = new ImmutableArray<int>();
Console.WriteLine("b1.Length = {0}", b1.Length);
var b2 = new ImmutableArray<int> { 1, 2, 3, 4, 5 };
Console.WriteLine("b2.Length = {0}", b2.Length);
```

The first error is due to ImmutableArray implementation's using a struct to wrap the underlying data storage. Structs must have parameter-less constructors so that `default(T)` expressions can return structs with all zero or null members. When the code accesses `b1.Length`, there is a run time null dereference error because there is no underlying storage array in the ImmutableArray struct. The correct way to create an empty ImmutableArray is `ImmutableArray<int>.Empty`.

The error with collection initializers happens because the `ImmutableArray.Add` method returns new instances each time you call it. Because ImmutableArrays never change, when you add a new element, you get back a new ImmutableArray object (which may share storage for performance reasons with a previously existing ImmutableArray). Because `b2` points to the first ImmutableArray before calling `Add()` five times, `b2` is a default ImmutableArray. Calling Length on it also crashes with a null dereference error. The correct way to initialize an ImmutableArray without manually calling Add is to use `ImmutableArray.CreateRange(new int[] {1, 2, 3, 4, 5})`.

## Find relevant syntax node types to trigger your analyzer

 To begin to build the analyzer, first figure out what type of SyntaxNode you need to look for. Launch the **Syntax Visualizer** from the menu **View** > **Other Windows** > **Roslyn Syntax Visualizer**.

Place the editor's caret on the line that declares `b1`. You'll see the Syntax Visualizer shows you are in a `LocalDeclarationStatement` node of the syntax tree. This node has a `VariableDeclaration`, which in turn has a `VariableDeclarator`, which in turn has an `EqualsValueClause`, and finally there is an `ObjectCreationExpression`. As you click in the Syntax Visualizer tree of nodes, the syntax in the editor window highlights to show you the code represented by that node. The names of the SyntaxNode sub types match the names used in the C# grammar.

## Create the analyzer project

From the main menu, choose **File** > **New** > **Project**. In the **New Project** dialog, under **C#** projects in the left navigation bar, choose **Extensibility**, and in the right pane choose the **Analyzer with Code Fix** project template. Enter a name and confirm the dialog.

The template opens a *DiagnosticAnalyzer.cs* file. Choose that editor buffer tab. This file has an analyzer class (formed from the name you gave the project) that derives from `DiagnosticAnalyzer` (a Roslyn API type). Your new class has a `DiagnosticAnalyzerAttribute` declaring your analyzer is relevant to the C# language so that the compiler discovers and loads your analyzer.

```csharp
[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class ImmutableArrayAnalyzer : DiagnosticAnalyzer
{}
```

You can implement an analyzer using Visual Basic that targets C# code, and vice versa. It is more important in the DiagnosticAnalyzerAttribute to choose whether your analyzer targets one language or both. More sophisticated analyzers that require detailed modeling of the language can only target a single language. If your analyzer, for example, only checks type names or public member names, it may be possible to use the common language model Roslyn offers across Visual Basic and C#. For example, FxCop warns that a class implements <xref:System.Runtime.Serialization.ISerializable>, but the class does not have the <xref:System.SerializableAttribute> attribute is language-independent and works for both Visual Basic and C# code.

## Initialize the analyzer

 Scroll down a little in the `DiagnosticAnalyzer` class to see the `Initialize` method. The compiler calls this method when activating an analyzer. The method takes an `AnalysisContext` object that allows your analyzer to get at context information and to register callbacks for events for the kinds of code you want to analyze.

```csharp
public override void Initialize(AnalysisContext context) {}
```

Open a new line in this method and type "context." to see an IntelliSense completion list. You can see in the completion list there are many `Register...` methods to handle various kinds of events. For example, the first one, `RegisterCodeBlockAction`, calls back to your code for a block, which is usually code between curly braces. Registering for a block also calls back to your code for the initializer of a field, the value given to an attribute, or the value of an optional parameter.

As another example, `RegisterCompilationStartAction`, calls back to your code at the start of a compilation, which is useful when you need to collect state over many locations. You can create a data structure, say, to collect all symbols used, and each time your analyzer is called back for some syntax or symbol, you can save information about each location in your data structure. When you're called back due to the compilation ending, you can analyze all the locations you saved, for example, to report what symbols the code uses from each `using` statement.

Using the **Syntax Visualizer**, you learned that you want to be called when the compiler processes an ObjectCreationExpression. You use this code to set up the callback:

```csharp
context.RegisterSyntaxNodeAction(c => AnalyzeObjectCreation(c),
                                 SyntaxKind.ObjectCreationExpression);
```

You register for a syntax node and filter for only object creation syntax nodes. By convention, analyzer authors use a lambda when registering actions, which helps to keep analyzers stateless. You can use the Visual Studio feature **Generate From Usage** to create the `AnalyzeObjectCreation` method. This generates the correct type of context parameter for you too.

## Set properties for users of your analyzer

So that your analyzer shows up in Visual Studio UI appropriately, look for and modify the following line of code to identify your analyzer:

```csharp
internal const string Category = "Naming";
```

Change `"Naming"` to `"API Guidance"`.

Next find and open the *Resources.resx* file in your project using the **Solution Explorer**. You can put in a description for your analyzer, title, etc. You can change the value for all of these to `"Don't use ImmutableArray<T> constructor"` for now. You can put string formatting arguments in your string ({0}, {1}, etc.), and later when you call `Diagnostic.Create()`, you can supply a `params` array of arguments to be passed.

## Analyze an object creation expression

The `AnalyzeObjectCreation` method takes a different type of context supplied by the code analyzer framework. The `Initialize` method's `AnalysisContext` allows you to register action callbacks to set up your analyzer. The `SyntaxNodeAnalysisContext`, for example, has a `CancellationToken` that you can pass around. If a user starts typing in the editor, Roslyn will cancel running analyzers to save work and improve performance. As another example, this context has a Node property that returns the object creation syntax node.

Get the node, which you can assume is the type for which you filtered the syntax node action:

```csharp
var objectCreation = (ObjectCreationExpressionSyntax)context.Node;
```

### Launch Visual Studio with your analyzer the first time

Launch Visual Studio by building and executing your analyzer (press **F5**). Because the startup project in the **Solution Explorer** is the VSIX project, running your code builds your code and a VSIX, and then launches Visual Studio with that VSIX installed. When you launch Visual Studio in this way, it launches with a distinct registry hive so that your main use of Visual Studio will not be affected by your testing instances while building analyzers. The first time you launch this way, Visual Studio does several initializations similar to when you first launched Visual Studio after installing it.

Create a console project and then enter the array code into your console applications Main method:

```csharp
var b1 = new ImmutableArray<int>();
Console.WriteLine("b1.Length = {0}", b1.Length);
var b2 = new ImmutableArray<int> { 1, 2, 3, 4, 5 };
Console.WriteLine("b2.Length = {0}", b2.Length);
```

The lines of code with `ImmutableArray` have squiggles because you need to get the immutable NuGet package and add a `using` statement to your code. Press the right pointer button on the project node in the **Solution Explorer** and choose **Manage NuGet Packages**. In the NuGet manager, type "Immutable" into the search box, and choose the item **System.Collections.Immutable** (do not choose **Microsoft.Bcl.Immutable**) in the left pane and press the **Install** button in the right pane. Installing the package adds a reference to your project references.

You still see red squiggles under `ImmutableArray`, so place the caret in that identifier and press **Ctrl**+**.** (period) to bring up the suggested fix menu and choose to add the appropriate `using` statement.

**Save All and Close** the second instance of Visual Studio for now to put you in a clean state to continue.

## Finish the analyzer using edit and continue

In the first instance of Visual Studio, set a breakpoint at the beginning of your `AnalyzeObjectCreation` method by pressing **F9** with the caret on the first line.

Launch your analyzer again with **F5**, and in the second instance of Visual Studio, reopen your console application you created last time.

You return to the first instance of Visual Studio at the breakpoint because the Roslyn compiler saw an Object creation expression and called into your analyzer.

**Get the object creation node.** Step over the line that sets the `objectCreation` variable by pressing **F10**, and in the **Immediate Window** evaluate the expression `"objectCreation.ToString()"`. You see that the syntax node the variable points to is the code `"new ImmutableArray<int>()"`, just what you are looking for.

**Get ImmutableArray<T\> Type object.** You need to check if the type being created is ImmutableArray. First, you get the object that represents this type. You check types using the semantic model to ensure you have exactly the right type, and you don't compare the string from `ToString()`. Enter the following line of code at the end of the function:

```csharp
var immutableArrayOfTType =
    context.SemanticModel
           .Compilation
           .GetTypeByMetadataName("System.Collections.Immutable.ImmutableArray`1");
```

You designate generic types in metadata with backticks (`) and the number of generic parameters. That is why you do not see "...ImmutableArray\<T>" in the metadata name.

The semantic model has many useful things on it that let you ask questions about symbols, data flow, variable lifetime, etc. Roslyn separates syntax nodes from the semantic model for various engineering reasons (performance, modeling erroneous code, etc.). You want the compilation model to look up information contained in references for accurate comparison.

You can drag the yellow execution pointer on the left side of the editor window. Drag it up to the line that sets the `objectCreation` variable and step over your new line of code using **F10**. If you hover the mouse pointer over the variable `immutableArrayOfType`, you see that we found the exact type in the semantic model.

**Get the object creation expression's type.** "Type" is used in a few ways in this article, but this means if you have "new Foo" expression, you need to get a model of Foo. You need to get the type of the object creation expression to see if it is the ImmutableArray\<T> type. Use the semantic model again to get symbol information for the type symbol (ImmutableArray) in the object creation expression. Enter the following line of code at the end of the function:

```csharp
var symbolInfo = context.SemanticModel.GetSymbolInfo(objectCreation.Type).Symbol as INamedTypeSymbol;
```

Because your analyzer needs to handle incomplete or incorrect code in editor buffers (for example, there is a missing `using` statement), you should check for `symbolInfo` being `null`. You need to get a named type (INamedTypeSymbol) from the symbol information object to finish the analysis.

**Compare the Types.** Because there is an open generic type of T that we are looking for, and the type in the code is a concrete generic type, you query the symbol information for what the type is constructed from (an open generic type) and compare that result with `immutableArrayOfTType`. Enter the following at the end of the method:

```csharp
if (symbolInfo != null &&
    symbolInfo.ConstructedFrom.Equals(immutableArrayOfTType))
{}
```

**Report the Diagnostic.** Reporting the diagnostic is pretty easy. You use the Rule created for you in the project template, which is defined before the Initialize method. Because this situation in the code is an error, you can change the line that initialized Rule to replace `DiagnosticSeverity.Warning` (green squiggle) with `DiagnosticSeverity.Error` (red squiggle). The rest of the Rule initializes from the resources you edited near the beginning of the walkthrough. You also need to report the location for the squiggle, which is the location of the object creation expression's type specification. Enter this code in the `if` block:

```csharp
context.ReportDiagnostic(Diagnostic.Create(Rule, objectCreation.Type.GetLocation()));
```

Your function should look like this (perhaps formatted differently):

```csharp
private void AnalyzeObjectCreation(SyntaxNodeAnalysisContext context)
{
    var objectCreation = (ObjectCreationExpressionSyntax)context.Node;
    var immutableArrayOfTType =
        context.SemanticModel
               .Compilation
               .GetTypeByMetadataName(
                   "System.Collections.Immutable.ImmutableArray`1");
    var symbolInfo = context.SemanticModel.GetSymbolInfo(objectCreation.Type).Symbol as
        INamedTypeSymbol;
    if (symbolInfo != null &&
        symbolInfo.ConstructedFrom.Equals(immutableArrayOfTType))
    {
        context.ReportDiagnostic(
            Diagnostic.Create(Rule, objectCreation.Type.GetLocation()));
    }
}
```

Remove the breakpoint so that you can see your analyzer working (and stop returning to the first instance of Visual Studio). Drag the execution pointer to the beginning of your method, and press **F5** to continue execution. When you switch back to the second instance of Visual Studio, the compiler will start to examine the code again, and it will call into your analyzer. You can see a squiggle under `ImmutableType<int>`.

## Adding a "Code Fix" for the Code Issue

Before you begin, close the second instance of Visual Studio and stop debugging in the first instance of Visual Studio (where you are developing the analyzer).

**Add a new class.** Use the shortcut menu (right pointer button) on your project node in the **Solution Explorer** and choose to add a new item. Add a class called `BuildCodeFixProvider`. This class needs to derive from `CodeFixProvider`, and you will need to use **Ctrl**+**.** (period) to invoke the code fix that adds the correct `using` statement. This class also needs to be annotated with `ExportCodeFixProvider` attribute, and you will need to add a `using` statement to resolve the `LanguageNames` enum. You should have a class file with the following code in it:

```csharp
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;

namespace ImmutableArrayAnalyzer
{
    [ExportCodeFixProvider(LanguageNames.CSharp)]
    class BuildCodeFixProvider : CodeFixProvider
    {}
```

**Stub out derived members.** Now, place the editor's caret in the identifier `CodeFixProvider` and press **Ctrl**+**.** (period) to stub out the implementation for this abstract base class. This generates a property and a method for you.

**Implement the property.** Fill in the `FixableDiagnosticIds` property's `get` body with the following code:

```csharp
return ImmutableArray.Create(ImmutableArrayAnalyzer.DiagnosticId);
```

Roslyn brings together diagnostics and fixes by matching these identifiers, which are just strings. The project template generated a diagnostic ID for you, and you are free to change it. The code in the property just returns the ID from the analyzer class.

**The RegisterCodeFixAsync method takes a context.** The context is important because a code fix can apply to multiple diagnostics, or there could be more than one issue on a line of code. If you type "context." in the body of the method, the IntelliSense completion list will show you some useful members. There's a CancellationToken member that you can check to see if something wants to cancel the fix. There's a Document member that has lots of useful members and lets you get to the project and solution model objects. There's a Span member that is the start and end of the code location specified when you reported the diagnostic.

**Make the method be async.** The first thing you need to do is fix the generated method declaration to be an `async` method. The code fix for stubbing out the implementation of an abstract class doesn't include the `async` keyword even though the method returns a `Task`.

**Get the root of the syntax tree.** To modify code you need to produce a new syntax tree with the changes your code fix makes. You need the `Document` from the context to call `GetSyntaxRootAsync`. This is an async method because there is unknown work to get the syntax tree, possibly including getting the file from disk, parsing it, and building the Roslyn code model for it. The Visual Studio UI should be responsive during this time, which using `async` enables. Replace the line of code in the method with the following:

```csharp
var root = await context.Document
                        .GetSyntaxRootAsync(context.CancellationToken);
```

**Find the node with the issue.** You pass in the context's span, but the node you find may not be the code you have to change. The reported diagnostic only provided the span for the type identifier (where the squiggle belonged), but you need to replace the entire object creation expression, including the `new` keyword at the beginning and the parentheses at the end. Add the following code to your method (and use **Ctrl**+**.** to add a `using` statement for `ObjectCreationExpressionSyntax`):

```csharp
var objectCreation = root.FindNode(context.Span)
                         .FirstAncestorOrSelf<ObjectCreationExpressionSyntax>();
```

**Register your code fix for the light bulb UI.** When you register your code fix, Roslyn plugs into the Visual Studio light bulb UI automatically. End users will see they can use **Ctrl**+**.** (period) when your analyzer squiggles a bad `ImmutableArray<T>` constructor use. Because your code fix provider only executes when there is an issue, you can assume you have the object creation expression you were looking for. From the context parameter, you can register the new code fix by adding the following code to the end of `RegisterCodeFixAsync` method:

```csharp
context.RegisterCodeFix(
            CodeAction.Create("Use ImmutableArray<T>.Empty",
                              c => ChangeToImmutableArrayEmpty(objectCreation,
                                                               context.Document,
                                                               c)),
            context.Diagnostics[0]);
```

You need to place the editor's caret in the identifier, `CodeAction`, then use **Ctrl**+**.** (period) to add the appropriate `using` statement for this type.

Then place the editor's caret in the `ChangeToImmutableArrayEmpty` identifier and use **Ctrl**+**.** again to generate this method stub for you.

This last code snippet you added registers the code fix by passing a `CodeAction` and the diagnostic ID for the kind of issue found. In this example, there is only one diagnostic ID that this code provides fixes for, so you can just pass the first element of the diagnostic IDs array. When you create the `CodeAction`, you pass in the text that the light bulb UI should use as a description of the code fix. You also pass in a function that takes a CancellationToken and returns a new Document. The new Document has a new syntax tree that includes your patched code that calls `ImmutableArray.Empty`. This code snippet uses a lambda so that it can close over the objectCreation node and the context's Document.

**Construct the new syntax tree.** In the `ChangeToImmutableArrayEmpty` method whose stub you generated earlier, enter the line of code: `ImmutableArray<int>.Empty;`. If you view the **Syntax Visualizer** tool window again, you can see this syntax is a SimpleMemberAccessExpression node. That's what this method needs to construct and return in a new Document.

The first change to `ChangeToImmutableArrayEmpty` is to add `async` before `Task<Document>` because the code generators cannot assume the method should be async.

Fill in the body with the following code so that your method looks similar to the following:

```csharp
private async Task<Document> ChangeToImmutableArrayEmpty(
    ObjectCreationExpressionSyntax objectCreation, Document document,
    CancellationToken c)
{
    var generator = SyntaxGenerator.GetGenerator(document);
    var memberAccess =
        generator.MemberAccessExpression(objectCreation.Type, "Empty");
    var oldRoot = await document.GetSyntaxRootAsync(c);
    var newRoot = oldRoot.ReplaceNode(objectCreation, memberAccess);
    return document.WithSyntaxRoot(newRoot);
}
```

You will need to put the editor's caret in the `SyntaxGenerator` identifier and use **Ctrl**+**.** (period) to add the appropriate `using` statement for this type.

This code uses `SyntaxGenerator`, which is a useful type for constructing new code. After getting a generator for the document that has the code issue, `ChangeToImmutableArrayEmpty` calls `MemberAccessExpression`, passing the type that has the member we want to access and passing the name of the member as a string.

Next, the method fetches the root of the document, and because this can involve arbitrary work in the general case, the code awaits this call and passes the cancellation token. Roslyn code models are immutable, like working with a .NET string; when you update the string, you get a new string object in return. When you call `ReplaceNode`, you get back a new root node. Most of the syntax tree is shared (because it is immutable), but the `objectCreation` node is replaced with the `memberAccess` node, as well as all the parent nodes up to the syntax tree root.

## Try your code fix

You can now press **F5** to execute your analyzer in a second instance of Visual Studio. Open the console project you used before. Now you should see the light bulb appear where your new object creation expression is for `ImmutableArray<int>`. If you press **Ctrl**+**.** (period), then you will see your code fix, and you will see an automatically generated code difference preview in the light bulb UI. Roslyn creates this for you.

**Pro Tip:** If you launch the second instance of Visual Studio, and you don't see the light bulb with your code fix, then you may need to clear the Visual Studio component cache. Clearing the cache forces Visual Studio to re-examine the components, so Visual Studio should then pick up your latest component. First, shut down the second instance of Visual Studio. Then, in **Windows Explorer**, navigate to *%LOCALAPPDATA%\Microsoft\VisualStudio\16.0Roslyn\\*. (The "16.0" changes from version to version with Visual Studio.) Delete the subdirectory *ComponentModelCache*.

## Talk video and finish code project

You can see all the finished code [here](https://github.com/DustinCampbell/CoreFxAnalyzers/tree/master/Source/CoreFxAnalyzers). The sub folders *DoNotUseImmutableArrayCollectionInitializer* and *DoNotUseImmutableArrayCtor* each have a C# file for finding issues and a C# file that implements the code fixes that show up in the Visual Studio light bulb UI. Note, the finished code has a little more abstraction to avoid fetching the ImmutableArray\<T> type object over and over. It uses nested registered actions to save the type object in a context that is available whenever the sub actions (analyze object creation and analyze collection initializations) execute.

## Related content

* \\\Build 2015 talk
* [Completed code on GitHub](https://github.com/DustinCampbell/CoreFxAnalyzers/tree/master/Source/CoreFxAnalyzers)
* [Several examples on GitHub, grouped into three kinds of analyzers](https://github.com/dotnet/roslyn/blob/main/docs/analyzers/Analyzer%20Samples.md)
* [Other docs on the GitHub OSS site](https://github.com/dotnet/roslyn/tree/main/docs/analyzers)
* [FxCop rules implemented with Roslyn analyzers on GitHub](https://github.com/dotnet/roslyn/tree/main/src/Features/Core/Portable/Diagnostics/Analyzers)
