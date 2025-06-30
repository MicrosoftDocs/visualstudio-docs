---
title: Options, Text Editor, C#, Advanced
description: Learn how to use the Advanced page in the C# section to modify the settings for editor formatting, code refactoring, and XML documentation comments for C#.
ms.date: 10/29/2022
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.CSharp.Outlining
- VS.ToolsOptionsPages.Text_Editor.CSharp.Advanced
ms.custom: "ide-ref"
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
---
# Options, Text Editor, C#, Advanced

Use the **Advanced** options page to modify the settings for editor formatting, code refactoring, and XML documentation comments for C#. To access this options page, choose **Tools** > **Options**, and then choose **Text Editor** > **C#** > **Advanced**.

> [!NOTE]
> Not all options may be listed here.

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

## Using Directives

- Place 'System' directives first when sorting usings

   When selected, the **Remove and Sort Usings** command in the right-click menu sorts the `using` directives and places the 'System' namespaces at the top of the list.

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

- Suggest usings for types in .NET Framework assemblies

- Suggest usings for types in NuGet packages

   When these options are selected, a [Quick Action](../quick-actions.md) is available to install a NuGet package and add a `using` directive for unreferenced types.

   ![Quick Action to install NuGet package in Visual Studio](media/nuget-lightbulb.png)

- Add missing using directives on paste

    When this option is selected, `using` directives will automatically get added to your code when you paste a type to a file.

## Highlighting

- Highlight references to symbol under cursor

   When the cursor is positioned inside a symbol, or when you click a symbol, all the instances of that symbol in the code file are highlighted.

## Outlining

- Enter outlining mode when files open

   When selected, automatically outlines the code file, which creates collapsible blocks of code. The first time a file is opened, #regions blocks and inactive code blocks collapse.

- Show procedure line separators

   The text editor indicates visual scope of procedures. A line is drawn in the *.cs* source files of your project at locations listed in the following table:

   |Location in .cs Source File|Example of Line Location|
   |---------------------------------|------------------------------|
   |After the close of a block declaration construct|-   At the end of a class, structure, module, interface, or enum<br />-   After a property, function, or sub<br />-   Not between the get and set clauses in a property|
   |After a set of single line constructs|-   After the import statements, before a type definition in a class file<br />-   After variables declared in a class, before any procedures|
   |After single line declarations (non-block level declarations)|-   Following import statements, inherits statements, variable declarations, event declarations, delegate declarations, and DLL declare statements|

## Block Structure Guides

Select these check boxes to display dotted vertical lines between the curly brackets (**{}**) in your code. You can then easily see individual blocks of code for your declaration level and code level constructs.

## Comments

- Generate XML documentation comments for ///

  When selected, inserts the XML elements for XML documentation comments after you type the `///` comment introduction. For more information about XML documentation, see [XML Documentation Comments (C# Programming Guide)](/dotnet/csharp/programming-guide/xmldoc/).

## Extract Method

- Don't put ref or out on custom struct

   Uncheck this checkbox to avoid potentially unintended cloning of structs by refencing existing struct objects when extracting an expression into a method call.

   ### Example

   Supposed the following `class` and `struct` exist in your code:

   ```csharp
   public struct CustomStruct
   {
      private int Count;

      public int Bump => ++Count;
   }

   public class CustomClass
   {
      public void DoIt()
      {
         CustomStruct cs = new CustomStruct();
         int i = 0;

         i += cs.Bump;   // select this line
      }
   }
   ```

   If the "Don't put ref or out on custom struct" option is **unchecked**, then the "Extract method" feature generates the following:

   ```csharp
   public class CustomClass
   {
      public void DoIt()
      {
         CustomStruct cs = new CustomStruct();
         int i = 0;

         NewMethod(ref cs, ref i);
      }

      private static void NewMethod(ref CustomStruct cs, ref int i)
         => i += cs.Bump;
   }
   ```

   If the "Don't put ref or out on custom struct" option is **checked**, then the "Extract method" feature generates the following:

   ```csharp
   public class CustomClass
   {
      public void DoIt()
      {
         CustomStruct cs = new CustomStruct();
         int i = 0;

         i = NewMethod(cs, i);
      }

      private static int NewMethod(CustomStruct cs, int i)
      {
         i += cs.Bump;
         return i;
      }
   }
   ```

## Inline Hints

- Inline Parameter Name Hints

    When selected, inserts parameter name hints for literals, cast literals, and object instantiations prior to each argument in function calls.

    ![Inline Parameter Name Hints for CSharp](media/inline-parameter-name-hints-csharp.png)

- Inline Type Hints

    When selected, inserts type hints for variables with inferred types and lambda parameter types.

    ![Inline Type Hints for CSharp](media/inline-type-hints-csharp.png)

## Inheritance Margin

- When selected, adds icons to the margins representing your code's implementations and overrides. Clicking on the inheritance margin icons will display inheritance options that you can select to navigate to.

    ![Inheritance Margin](media/inheritance-margin.png)

## See also

- [How to: Insert XML comments for documentation generation](../../ide/reference/generate-xml-documentation-comments.md)
- [Document your code with XML comments (C# Guide)](/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)
- [Set language-specific editor options](../../ide/reference/setting-language-specific-editor-options.md)
- [C# IntelliSense](../../ide/visual-csharp-intellisense.md)
