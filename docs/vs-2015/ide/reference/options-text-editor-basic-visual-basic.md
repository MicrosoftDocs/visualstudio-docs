---
title: "Options, Text Editor, Basic (Visual Basic) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Visual_Basic.Editor"
  - "VS.ToolsOptionsPages.Text_Editor.Basic.Editor"
  - "VS.ToolsOptionsPages.Visual_Basic_Editor.Editor"
  - "VS.ToolsOptionsPages.Text_Editor.Basic.SimplifiedEditorPage"
  - "VS.ToolsOptionsPages.Text_Editor.Basic"
  - "VS.ToolsOptionsPages.Text_Editor.Basic.VB_Specific"
helpviewer_keywords:
  - "Basic Text Editor Options dialog box"
ms.assetid: 5a8cafca-f7b4-4a2d-92ce-6894a7673d00
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# Options, Text Editor, Basic (Visual Basic)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The **VB Specific** property page, in the **Basic** folder of the **Text Editor** folder of the **Options** (**Tools** menu) dialog box contains the following properties:

 **Automatic insertion of end constructs**
 When you type—for example, the first line of a procedure declaration, `Sub Main—`and press ENTER, the text editor adds a matching `End Sub` line. Similarly, if you add a [For](https://msdn.microsoft.com/library/f5fc0d51-67ce-4c36-9f09-31c9a91c94e9) loop, the text editor adds a matching `Next` statement. When this option is selected, the code editor automatically adds the end construct.

 **Pretty Listing (reformatting) of code**
 The text editor reformats your code as appropriate. When this option is selected, the code editor will:

- Align your code to the correct tab position

- Recase keywords, variables, and objects to the correct case

- Add a missing `Then` to an `If...Then` statement

- Add parenthesis to function calls

- Add missing end quotes to strings

- Reformat exponential notation

- Reformat dates

  **Enable outlining mode**
  When you open a file in the code editor, you can view the document in outlining mode. See [Outlining](../../ide/outlining.md) for more information. When this option is selected, the outlining feature is activated when you open a file.

  **Automatic insertion of Interface and MustOverride members**
  When you commit an `Implements` statement or an `Inherits` statement for a class, the text editor inserts prototypes for the members that have to be implemented or overridden, respectively.

  **Show procedure line separators**
  The text editor indicates visual scope of procedures. A line is drawn in the .vb source files of your project at locations listed in the following table:

|Location in .vb Source File|Example of Line Location|
|---------------------------------|------------------------------|
|After the close of a block declaration construct|-   At the end of a class, structure, module, interface, or enum<br />-   After a property, function, or sub<br />-   Not between the get and set clauses in a property|
|After a set of single line constructs|-   After the import statements, before a type definition in a class file<br />-   After variables declared in a class, before any procedures|
|After single line declarations (non-block level declarations)|-   Following import statements, inherits statements, variable declarations, event declarations, delegate declarations, and DLL declare statements|

 **Enable error correction suggestions**
 The text editor can suggest solutions to common errors and allow you to select the appropriate correction, which is then applied to your code.

 **Enable highlighting of references and keywords**
 The text editor can highlight all instances of a symbol or all of the keywords in a clause such as `If..Then`, `While...End While`, or `Try...Catch...Finally`. You can navigate between highlighted references or keywords by pressing CTRL+SHIFT+DOWN ARROW or CTRL+SHIFT+UP ARROW.

## See Also
 [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
 [Options, Text Editor, All Languages, Tabs](../../ide/reference/options-text-editor-all-languages-tabs.md)
