---
title: "Visual C# Code Snippets"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dbea3dd6-e650-4190-b874-c9f097d7de6e
caps.latest.revision: 33
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Visual C# Code Snippets
Code snippets are ready-made snippets of code you can quickly insert into your code. For example, the `for` code snippet creates an empty `for` loop. Some code snippets are surround-with code snippets, which enable you to select lines of code, and then choose a code snippet which incorporates the selected lines of code. For example, when you select lines of code and then activate the `for` code snippet, it creates a `for` loop with those lines of code inside the loop block. Code snippets can make writing program code quicker, easier, and more reliable.  
  
 You can insert a code snippet at the cursor location, or insert a surround-with code snippet around the currently selected code. The Code Snippet Inserter is invoked through the **Insert Code Snippet** or **Surround With** commands on the **IntelliSense** menu, or by using the keyboard shortcuts CTRL+K and then X or CTRL+K and then S respectively.  
  
 The Code Snippet Inserter displays the code snippet name for all available code snippets. The Code Snippet Inserter also includes an input dialog box where you can type the name of the code snippet, or part of the code snippet name. The Code Snippet Inserter highlights the closest match to a code snippet name. Pressing TAB at any time will dismiss the Code Snippet Inserter and insert the currently selected code snippet. Typing ESC or clicking the mouse in the Code Editor will dismiss the Code Snippet Inserter without inserting a code snippet.  
  
## Default Code Snippets  
 By default the following code snippets are included in Visual Studio.  
  
|Name (or shortcut)|Description|Valid locations to insert snippet|  
|--------------------------|-----------------|---------------------------------------|  
|#if|Creates a [#if](../Topic/%23if%20\(C%23%20Reference\).md) directive and a [#endif](../Topic/%23endif%20\(C%23%20Reference\).md) directive.|Anywhere.|  
|#region|Creates a [#region](../Topic/%23region%20\(C%23%20Reference\).md) directive and a [#endregion](../Topic/%23endregion%20\(C%23%20Reference\).md) directive.|Anywhere.|  
|~|Creates a destructor for the containing class.|Inside a class.|  
|attribute|Creates a declaration for a class that derives from <xref:System.Attribute?qualifyHint=False>.|Inside a namespace (including the global namespace), a class, or a struct.|  
|checked|Creates a [checked](../Topic/checked%20\(C%23%20Reference\).md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|class|Creates a class declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|ctor|Creates a constructor for the containing class.|Inside a class.|  
|cw|Creates a call to <xref:System.Console.WriteLine?qualifyHint=False>.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|do|Creates a [do](../Topic/do%20\(C%23%20Reference\).md)`while` loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|else|Creates an [else](../Topic/if-else%20\(C%23%20Reference\).md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|enum|Creates an [enum](../Topic/enum%20\(C%23%20Reference\).md) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|equals|Creates a method declaration that overrides the <xref:System.Object.Equals?qualifyHint=False> method defined in the <xref:System.Object?qualifyHint=False> class.|Inside a class or a struct.|  
|exception|Creates a declaration for a class that derives from an exception (<xref:System.Exception?qualifyHint=False> by default).|Inside a namespace (including the global namespace), a class, or a struct.|  
|for|Creates a [for](../Topic/for%20\(C%23%20Reference\).md) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|foreach|Creates a [foreach](../Topic/foreach,%20in%20\(C%23%20Reference\).md) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|forr|Creates a [for](../Topic/for%20\(C%23%20Reference\).md) loop that decrements the loop variable after each iteration.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|if|Creates an [if](../Topic/if-else%20\(C%23%20Reference\).md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|indexer|Creates an indexer declaration.|Inside a class or a struct.|  
|interface|Creates an [interface](../Topic/interface%20\(C%23%20Reference\).md) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|invoke|Creates a block that safely invokes an event.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|iterator|Creates an iterator.|Inside a class or a struct.|  
|iterindex|Creates a "named" iterator and indexer pair by using a nested class.|Inside a class or a struct.|  
|lock|Creates a [lock](../Topic/lock%20Statement%20\(C%23%20Reference\).md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|mbox|Creates a call to <xref:System.Windows.Forms.MessageBox.Show?qualifyHint=True>. You may have to add a reference to System.Windows.Forms.dll.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|namespace|Creates a [namespace](../Topic/namespace%20\(C%23%20Reference\).md) declaration.|Inside a namespace (including the global namespace).|  
|prop|Creates an [auto-implemented property](../Topic/Auto-Implemented%20Properties%20\(C%23%20Programming%20Guide\).md) declaration.|Inside a class or a struct.|  
ropfull|Creates a property declaration with get and set accessors.|Inside a class or a struct.|  
|propg|Creates a read-only [auto-implemented property](../Topic/Auto-Implemented%20Properties%20\(C%23%20Programming%20Guide\).md) with a private "set" accessor.|Inside a class or a struct.|  
|sim|Creates a [static](../Topic/static%20\(C%23%20Reference\).md)[int](../Topic/int%20\(C%23%20Reference\).md) Main method declaration.|Inside a class or a struct.|  
|struct|Creates a [struct](../Topic/struct%20\(C%23%20Reference\).md) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|  
|svm|Creates a [static](../Topic/static%20\(C%23%20Reference\).md)[void](../Topic/void%20\(C%23%20Reference\).md) Main method declaration.|Inside a class or a struct.|  
|switch|Creates a [switch](../Topic/switch%20\(C%23%20Reference\).md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|try|Creates a [try-catch](../Topic/try-catch%20\(C%23%20Reference\).md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|tryf|Creates a [try-finally](../Topic/try-finally%20\(C%23%20Reference\).md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|unchecked|Creates an [unchecked](../Topic/unchecked%20\(C%23%20Reference\).md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|unsafe|Creates an [unsafe](../Topic/unsafe%20\(C%23%20Reference\).md) block.|Inside a method, an indexer, a property accessor, or an event accessor.|  
|using|Creates a [using](../Topic/using%20Directive%20\(C%23%20Reference\).md) directive.|Inside a namespace (including the global namespace).|  
|while|Creates a [while](../Topic/while%20\(C%23%20Reference\).md) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|  
  
## See Also  
 [Code Snippet Functions](../VS_IDE/Code-Snippet-Functions.md)   
 [Code Snippets](../VS_IDE/Code-Snippets.md)   
 [How to: Create a New Snippet with Replacements](assetId:///8d56d43c-097a-475b-aa85-cae1554b6338)   
 [Template Parameters](../VS_IDE/Template-Parameters.md)   
 [How to: Use Surround-with Code Snippets](../VS_IDE/How-to--Use-Surround-with-Code-Snippets.md)   
 [How to: Restore C# Refactoring Snippets](../VS_IDE/How-to--Restore-C#-Refactoring-Snippets.md)