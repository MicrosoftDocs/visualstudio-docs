---
title: "Options, Text Editor, C#, Advanced | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Outlining"
  - "VS.ToolsOptionsPages.Text_Editor.Visual_JSharp.Advanced"
  - "VS.ToolsOptionsPages.Text_Editor.Visual_JSharp.Outlining"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Advanced"
helpviewer_keywords: 
  - "XML comments"
  - "XML documentation, generating"
  - "outlining options [C#]"
  - "outlining options [J#]"
  - "XML documentation, creating"
ms.assetid: 947f9d9a-b0f3-408d-9866-d82895bcee31
caps.latest.revision: 22
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Options, Text Editor, C#, Advanced
Use this dialog box to modify the settings for editor formatting, code refactoring, and XML documentation comments for Visual C#. To access this dialog box, click **Options** on the **Tools** menu, expand the **Text Editor** folder, expand **C#**, and then click **Advanced**.  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Outlining  
 Enter outlining mode when files open  
 When selected, automatically outlines the code file, which creates collapsible blocks of code. The first time a file is opened, #regions blocks and inactive code blocks collapse.  
  
## Editor Help  
 Underline errors in the editor  
 Identifies build errors in code. When this option is selected, wavy underlines appear in colors that have specific meanings:  
  
-   Parse errors are red.  
  
-   Build errors are blue.  
  
-   Build warnings are green.  
  
-   Invalid [Edit and Continue](../../debugger/edit-and-continue.md) edits are purple.  
  
 Move the pointer over the underlined code segment to see a ToolTip with information about the error.  
  
 Show live semantic errors  
 Identifies certain compile errors without explicit compilation, for example, declaring and using an unknown type or referencing an unknown property.  
  
 Highlight references to symbol under cursor  
 When the cursor is positioned inside a symbol, or when you click a symbol, all the instances of that symbol in the code file are highlighted.  
  
## Refactoring  
 Verify results of refactoring  
 Displays the **Verification Results** dialog box when you try to refactor code that contains build errors, or when refactoring would cause a code reference to bind to something different from its original binding.  
  
 Warn on members with compiler generated references  
 Displays a warning dialog when you try to refactor a member that has the same name as a compiler generated reference.  
  
## XML Documentation Comments  
 Generate XML documentation comments for ///  
 When selected, inserts the \<summary> start and end tags automatically for XML documentation comments after you type the /// comment introduction. For more information about XML documentation, see [XML Documentation Comments](/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments).  
  
## Implement Interface  
 Surround generated code with #region  
 Inserts a #region \<*interface name*> Member around the methods when Implement Interface or Implement Interface Explicitly is used.  
  
## Organize Usings  
 Place 'System' directives first when sorting usings  
 When selected, `System` using directives appear before other using directives. For more information, see [Sort Usings](../../misc/sort-usings.md).  
  
## See Also  
 [XML Documentation Comments](/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)   
 [Setting Language-Specific Editor Options](../../ide/reference/setting-language-specific-editor-options.md)   
 [Visual C# IntelliSense](../../ide/visual-csharp-intellisense.md)