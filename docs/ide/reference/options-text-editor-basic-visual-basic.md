---
title: Options, Text Editor, Basic (VB), Advanced
description: Learn how to use the Advanced page in the Basic section to change the default settings of the Analysis, Import Directives, and Highlighting properties.
ms.date: 05/20/2022
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Visual_Basic.Editor
- VS.ToolsOptionsPages.Text_Editor.Basic.Editor
- VS.ToolsOptionsPages.Visual_Basic_Editor.Editor
- VS.ToolsOptionsPages.Text_Editor.Basic.SimplifiedEditorPage
- VS.ToolsOptionsPages.Text_Editor.Basic
- VS.ToolsOptionsPages.Text_Editor.Basic.Advanced
- VS.ToolsOptionsPages.Text_Editor.Basic.VB_Specific
helpviewer_keywords:
- Basic Text Editor Options dialog box
ms.custom: "ide-ref"
author: akhera99
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
---
# Options, Text Editor, Basic (Visual Basic), Advanced

::: moniker range=">=vs-2022"

The **VB Specific** property page, in the **Visual Basic** folder of the **Text Editor** folder of the **Options** (**Tools** menu) dialog box, includes the following properties:

::: moniker-end

::: moniker range="<=vs-2019"

The **VB Specific** property page, in the **Basic** folder of the **Text Editor** folder of the **Options** (**Tools** menu) dialog box, includes the following properties:

::: moniker-end

## Analysis

::: moniker range=">=vs-2022"

- Run background code analysis for ...

  Choose one of the following options.

  | Option | Description |
  | - | - |
  | None | All analyzers and corresponding code fixes are disabled.<br/><br/>Compiler diagnostics and corresponding code fixes are enabled on *all open* documents. |
  | Current document (default) | All analyzers run just on the currently active document.<br/><br/>Compiler diagnostics are enabled on *all open* documents. |
  | Open documents | All analyzers and compiler diagnostics are enabled on *all open* documents. |
  | Entire solution | All analyzers and compiler diagnostics are enabled on *all* documents in the solution, whether open or closed. |

::: moniker-end

::: moniker range="<=vs-2019"

- Live code analysis or Background analysis scope

   Configure the background analysis scope for managed code. For more information, see [How to: Configure live code analysis scope for managed code](../../code-quality/configure-live-code-analysis-scope-managed-code.md).

::: moniker-end

## Import Directives

- Place 'System' directives first when sorting imports

   When selected, the **Remove and Sort Imports** command in the right-click menu sorts the `import` directives and places the 'System' namespaces at the top of the list.

- Separate import directive groups

   When selected, the **Remove and Sort Imports** command in the right-click menu separates `import` directives by inserting an empty line between groups of directives that have the same root namespace.

- Suggest imports for types in reference assemblies
- Suggest imports for types in NuGet packages

   When these options are selected, a [Quick Action](../quick-actions.md) is available to install a NuGet package and add an `import` directive for unreferenced types.

   ![Quick Action to install NuGet package in Visual Studio](media/nuget-lightbulb.png)

## Highlighting

 **Enable highlighting of references and keywords**

The text editor can highlight all instances of a symbol or all keywords in a clause such as `If..Then`, `While...End While`, or `Try...Catch...Finally`. You can navigate between highlighted references or keywords by pressing **Ctrl** + **Shift** + **Down arrow** or **Ctrl** + **Shift** + **Up arrow**.

## Outlining

**Enable outlining mode**

When you open a file in the code editor, you can view the document in outlining mode. See [Outlining](../../ide/outlining.md) for more information. When this option is selected, the outlining feature is activated when you open a file.

**Show procedure line separators**

The text editor indicates visual scope of procedures. A line is drawn in the *.vb* source files of your project at locations listed in the following table:

|Location in .vb Source File|Example of Line Location|
|---------------------------------|------------------------------|
|After the close of a block declaration construct|-   At the end of a class, structure, module, interface, or enum<br />-   After a property, function, or sub<br />-   Not between the get and set clauses in a property|
|After a set of single line constructs|-   After the import statements, before a type definition in a class file<br />-   After variables declared in a class, before any procedures|
|After single line declarations (non-block level declarations)|-   Following import statements, inherits statements, variable declarations, event declarations, delegate declarations, and DLL declare statements|

## Block Structure Guides

When selected, vertical lines appear in the editor that line up with structured code blocks, which lets you easily identify the individual blocks of code. For example, you would see a line between `Sub` and `EndSub` in a `Sub` statement.

## Editor Help

**Inline Parameter Name Hints**
When selected, inserts parameter name hints for literals, casted literals, and object instantiations prior to each argument in function calls.

![Inline Parameter Name Hints for Visual Basic](media/inline-parameter-name-hints-visualbasic.png)

**Pretty Listing (reformatting) of code**
The text editor reformats your code as appropriate. When this option is selected, the code editor will:

- Align your code to the correct tab position

- Recase keywords, variables, and objects to the correct case

- Add a missing `Then` to an `If...Then` statement

- Add parenthesis to function calls

- Add missing end quotes to strings

- Reformat exponential notation

- Reformat dates

**Automatic insertion of end constructs**

When you type—for example, the first line of a procedure declaration, `Sub Main`—and press **Enter**, the text editor adds a matching `End Sub` line. Similarly, if you add a [For](/dotnet/visual-basic/language-reference/statements/for-next-statement) loop, the text editor adds a matching `Next` statement. When this option is selected, the code editor automatically adds the end construct.

**Automatic insertion of Interface and MustOverride members**

When you commit an `Implements` statement or an `Inherits` statement for a class, the text editor inserts prototypes for the members that have to be implemented or overridden, respectively.

**Enable error correction suggestions**

The text editor can suggest solutions to common errors and allow you to select the appropriate correction, which is then applied to your code.

## See also

- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
- [Options, Text Editor, All Languages, Tabs](../../ide/options-text-editor-all-languages-tabs.md)
