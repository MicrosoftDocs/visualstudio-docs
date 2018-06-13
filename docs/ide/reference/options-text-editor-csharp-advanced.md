---
title: Options, Text Editor, C#, Advanced
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Outlining"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Advanced"
helpviewer_keywords:
  - "XML comments"
  - "XML documentation, generating"
  - "outlining options [C#]"
  - "XML documentation, creating"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "dotnet"
---
# Options, Text Editor, C#, Advanced

Use the **Advanced** options page to modify the settings for editor formatting, code refactoring, and XML documentation comments for C#. To access this options page, choose **Tools** > **Options**, and then choose **Text Editor** > **C#** > **Advanced**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).

## Analysis

- Enable full solution analysis

   Enables code analysis on all files in the solution, not just open code files. For more information, see [Full solution analysis](../../code-quality/how-to-enable-and-disable-full-solution-analysis-for-managed-code.md).

- Perform editor feature analysis in external process (experimental)

## Using Directives

- Place 'System' directives first when sorting usings

- Separate using directive groups

- Suggest usings for types in reference assemblies

- Suggest usings for types in NuGet packages

## Highlighting

- Highlight references to symbol under cursor

   When the cursor is positioned inside a symbol, or when you click a symbol, all the instances of that symbol in the code file are highlighted.

- Highlight related keywords under cursor

## Outlining

- Enter outlining mode when files open

   When selected, automatically outlines the code file, which creates collapsible blocks of code. The first time a file is opened, #regions blocks and inactive code blocks collapse.

- Show procedure line separators

- Show outlining for declaration level constructs

- Show outlining for code level constructs

- Show outlining for comments and preprocessor regions

- Collapse #regions when collapsing to definitions

## Fading

- Fade out unused usings

- Fade out unreachable code

## Block Structure Guides

- Show guides for declaration level constructs

- Show guides for code level constructs

## Editor Help

- Generate XML documentation comments for ///

   When selected, inserts the XML elements for XML documentation comments after you type the `///` comment introduction. For more information about XML documentation, see [XML Documentation Comments (C# Programming Guide)](/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments).

- Insert \* at the start of new lines when writing /\* \*/ comments

- Show preview for rename tracking

- Split string literals on enter

- Report invalid placeholders in 'string.Format' calls

## Extract Method

- Don't put ref or out on custom struct

## Implement Interface or Abstract Class

- When inserting properties, events and methods, place them with other members of the same kind, or at the end

- When generating properties, prefer throwing properties or prefer auto properties

## See also

- [How to: Insert XML comments for documentation generation](../../ide/reference/generate-xml-documentation-comments.md)
- [XML Documentation Comments (C# Programming Guide)](/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)
- [Documenting your code with XML comments (C# Guide)](/dotnet/csharp/codedoc)
- [Setting language-specific editor options](../../ide/reference/setting-language-specific-editor-options.md)
- [C# IntelliSense](../../ide/visual-csharp-intellisense.md)