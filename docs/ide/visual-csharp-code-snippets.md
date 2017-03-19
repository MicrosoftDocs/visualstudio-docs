---
title: "Visual C# Code Snippets | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "snippets [C#], default snippets"
  - "snippets [C#], Code Snippet Inserter"
  - "Code Snippet Inserter [J#]"
  - "Code Snippet Inserter [C#]"
  - "Visual C#, default snippets"
ms.assetid: dbea3dd6-e650-4190-b874-c9f097d7de6e
caps.latest.revision: 33
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Visual C# Code Snippets
Code snippets are ready-made snippets of code you can quickly insert into your code. For example, the `for` code snippet creates an empty `for` loop. Some code snippets are surround-with code snippets, which enable you to select lines of code, and then choose a code snippet which incorporates the selected lines of code. For example, when you select lines of code and then activate the `for` code snippet, it creates a `for` loop with those lines of code inside the loop block. Code snippets can make writing program code quicker, easier, and more reliable.  
  
 You can insert a code snippet at the cursor location, or insert a surround-with code snippet around the currently selected code. The Code Snippet Inserter is invoked through the **Insert Code Snippet** or **Surround With** commands on the **IntelliSense** menu, or by using the keyboard shortcuts CTRL+K and then X or CTRL+K and then S respectively.  
  
 The Code Snippet Inserter displays the code snippet name for all available code snippets. The Code Snippet Inserter also includes an input dialog box where you can type the name of the code snippet, or part of the code snippet name. The Code Snippet Inserter highlights the closest match to a code snippet name. Pressing TAB at any time will dismiss the Code Snippet Inserter and insert the currently selected code snippet. Typing ESC or clicking the mouse in the Code Editor will dismiss the Code Snippet Inserter without inserting a code snippet.  
  
## Default Code Snippets  
 By default the following code snippets are included in Visual Studio.  
  
|Name (or shortcut)|Description|Valid locations to insert snippet|  
|--------------------------|-----------------|---------------------------------------|  
|#if|Creates a [#if](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-if) directive and a [#endif](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-endif) directive.|Anywhere.|  
|#region|Creates a [#region](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-region) directive and a [#endregion](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-endregion) directive.|Anywhere.|  
|~|Creates a destructor for the containing class.|Inside a class.|  
|attribute|Creates a declaration for a class that derives from <xref:System.Attribute>.|Inside a namespace (including the global namespace), a class, or a struct.|  
|checked|Creates a [checked](/dotnet/csharp/language-reference/keywords/checked) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|class|Creates a class declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|ctor|Creates a constructor for the containing class.|Inside a class.|  
|cw|Creates a call to <xref:System.Console.WriteLine%2A>.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|do|Creates a [do](/dotnet/csharp/language-reference/keywords/do)`while` loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|else|Creates an [else](/dotnet/csharp/language-reference/keywords/if-else) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|enum|Creates an [enum](/dotnet/csharp/language-reference/keywords/enum) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|equals|Creates a method declaration that overrides the <xref:System.Object.Equals%2A> method defined in the <xref:System.Object> class.|Inside a class or a struct.|  
|exception|Creates a declaration for a class that derives from an exception (<xref:System.Exception> by default).|Inside a namespace (including the global namespace), a class, or a struct.|  
|for|Creates a [for](/dotnet/csharp/language-reference/keywords/for) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|foreach|Creates a [foreach](/dotnet/csharp/language-reference/keywords/foreach-in) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|forr|Creates a [for](/dotnet/csharp/language-reference/keywords/for) loop that decrements the loop variable after each iteration.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|if|Creates an [if](/dotnet/csharp/language-reference/keywords/if-else) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|indexer|Creates an indexer declaration.|Inside a class or a struct.|  
|interface|Creates an [interface](/dotnet/csharp/language-reference/keywords/interface) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|invoke|Creates a block that safely invokes an event.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|iterator|Creates an iterator.|Inside a class or a struct.|  
|iterindex|Creates a "named" iterator and indexer pair by using a nested class.|Inside a class or a struct.|  
|lock|Creates a [lock](/dotnet/csharp/language-reference/keywords/lock-statement) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|mbox|Creates a call to <xref:System.Windows.Forms.MessageBox.Show%2A?displayProperty=fullName>. You may have to add a reference to System.Windows.Forms.dll.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|namespace|Creates a [namespace](/dotnet/csharp/language-reference/keywords/namespace) declaration.|Inside a namespace (including the global namespace).|  
|prop|Creates an [auto-implemented property](/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties) declaration.|Inside a class or a struct.|  
propfull|Creates a property declaration with get and set accessors.|Inside a class or a struct.|  
|propg|Creates a read-only [auto-implemented property](/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties) with a private "set" accessor.|Inside a class or a struct.|  
|sim|Creates a [static](/dotnet/csharp/language-reference/keywords/static)[int](/dotnet/csharp/language-reference/keywords/int) Main method declaration.|Inside a class or a struct.|  
|struct|Creates a [struct](/dotnet/csharp/language-reference/keywords/struct) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|svm|Creates a [static](/dotnet/csharp/language-reference/keywords/static)[void](/dotnet/csharp/language-reference/keywords/void) Main method declaration.|Inside a class or a struct.|  
|switch|Creates a [switch](/dotnet/csharp/language-reference/keywords/switch) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|try|Creates a [try-catch](/dotnet/csharp/language-reference/keywords/try-catch) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|tryf|Creates a [try-finally](/dotnet/csharp/language-reference/keywords/try-finally) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|unchecked|Creates an [unchecked](/dotnet/csharp/language-reference/keywords/unchecked) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|unsafe|Creates an [unsafe](/dotnet/csharp/language-reference/keywords/unsafe) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|using|Creates a [using](/dotnet/csharp/language-reference/keywords/using-directive) directive.|Inside a namespace (including the global namespace).|  
|while|Creates a [while](/dotnet/csharp/language-reference/keywords/while) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
  
## See Also  
 [Code Snippet Functions](../ide/code-snippet-functions.md)   
 [Code Snippets](../ide/code-snippets.md)   
 [How to: Create a New Snippet with Replacements](http://msdn.microsoft.com/en-us/8d56d43c-097a-475b-aa85-cae1554b6338)   
 [Template Parameters](../ide/template-parameters.md)   
 [How to: Use Surround-with Code Snippets](../ide/how-to-use-surround-with-code-snippets.md)   
 
