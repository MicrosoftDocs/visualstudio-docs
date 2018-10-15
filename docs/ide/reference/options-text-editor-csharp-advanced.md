---
title: Options, Text Editor, C#, Advanced
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Outlining"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Advanced"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "dotnet"
---
# Options, Text Editor, C#, Advanced

Use the **Advanced** options page to modify the settings for editor formatting, code refactoring, and XML documentation comments for C#. To access this options page, choose **Tools** > **Options**, and then choose **Text Editor** > **C#** > **Advanced**.

> [!NOTE]
> Not all options may be listed here.

## Analysis

- Enable full solution analysis

   Enables code analysis on all files in the solution, not just open code files. For more information, see [Full solution analysis](../../code-quality/how-to-enable-and-disable-full-solution-analysis-for-managed-code.md).

## Using Directives

- Place 'System' directives first when sorting usings

   When selected, the **Remove and Sort Usings** command in the right-click menu sorts the `using` directives and places the 'System' namespaces at the top of the list

   Before sorting:

   ```csharp
   using AutoMapper;
   using FluentValidation;
   using System.Collections.Generic;
   using System.Linq;
   using Newtonsoft.Json;
   using System;
   ```
   
   After sorting:

   ```csharp
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using AutoMapper;
   using FluentValidation;
   using Newtonsoft.Json;
   ```
   
- Separate using directive groups

   When selected, the **Remove and Sort Usings** command in the right-click menu separates `using` directives by inserting an empty line between groups of directives that have the same root namespace.

   Before sorting:

   ```csharp
   using AutoMapper;
   using FluentValidation;
   using System.Collections.Generic;
   using System.Linq;
   using Newtonsoft.Json;
   using System;
   ```
   
   After sorting:
   
   ```csharp
   using AutoMapper;
   
   using FluentValidation;
   
   using Newtonsoft.Json;
   
   using System;
   using System.Collections.Generic;
   using System.Linq;
   ```
   
- Add usings for types in reference assemblies and NuGet packages 

   When selected, a [Quick Action](../quick-actions.md) is available to install a NuGet package and add a `using` directive for unreferenced types.

   ![Quick Action to install NuGet package in Visual Studio](/docs/ide/references/media/nuget-lightbulb.png)
  
## Highlighting

- Highlight references to symbol under cursor

   When the cursor is positioned inside a symbol, or when you click a symbol, all the instances of that symbol in the code file are highlighted.

## Outlining

- Enter outlining mode when files open

   When selected, automatically outlines the code file, which creates collapsible blocks of code. The first time a file is opened, #regions blocks and inactive code blocks collapse.

## Editor Help

- Generate XML documentation comments for ///

   When selected, inserts the XML elements for XML documentation comments after you type the `///` comment introduction. For more information about XML documentation, see [XML Documentation Comments (C# Programming Guide)](/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments).

## See also

- [How to: Insert XML comments for documentation generation](../../ide/reference/generate-xml-documentation-comments.md)
- [XML Documentation Comments (C# Programming Guide)](/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)
- [Document your code with XML comments (C# Guide)](/dotnet/csharp/codedoc)
- [Set language-specific editor options](../../ide/reference/setting-language-specific-editor-options.md)
- [C# IntelliSense](../../ide/visual-csharp-intellisense.md)
