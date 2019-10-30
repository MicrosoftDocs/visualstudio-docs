---
title: "Visual C# Code Snippets | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "snippets [C#], default snippets"
  - "snippets [C#], Code Snippet Inserter"
  - "Code Snippet Inserter [J#]"
  - "Code Snippet Inserter [C#]"
  - "Visual C#, default snippets"
ms.assetid: dbea3dd6-e650-4190-b874-c9f097d7de6e
caps.latest.revision: 37
author: jillre
ms.author: jillfra
manager: jillfra
---
# Visual C# Code Snippets
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Code snippets are ready-made snippets of code you can quickly insert into your code. For example, the `for` code snippet creates an empty `for` loop. Some code snippets are surround-with code snippets, which enable you to select lines of code, and then choose a code snippet which incorporates the selected lines of code. For example, when you select lines of code and then activate the `for` code snippet, it creates a `for` loop with those lines of code inside the loop block. Code snippets can make writing program code quicker, easier, and more reliable.

 You can insert a code snippet at the cursor location, or insert a surround-with code snippet around the currently selected code. The Code Snippet Inserter is invoked through the **Insert Code Snippet** or **Surround With** commands on the **IntelliSense** menu, or by using the keyboard shortcuts CTRL+K and then X or CTRL+K and then S respectively.

 The Code Snippet Inserter displays the code snippet name for all available code snippets. The Code Snippet Inserter also includes an input dialog box where you can type the name of the code snippet, or part of the code snippet name. The Code Snippet Inserter highlights the closest match to a code snippet name. Pressing TAB at any time will dismiss the Code Snippet Inserter and insert the currently selected code snippet. Typing ESC or clicking the mouse in the Code Editor will dismiss the Code Snippet Inserter without inserting a code snippet.

## Default Code Snippets
 By default the following code snippets are included in Visual Studio.

|Name (or shortcut)|Description|Valid locations to insert snippet|
|--------------------------|-----------------|---------------------------------------|
|#if|Creates a [#if](https://msdn.microsoft.com/library/48cabbff-ca82-491f-a56a-eeccd528c7c2) directive and a [#endif](https://msdn.microsoft.com/library/6a5fca55-5aee-441f-86f6-1c99fbe9ec05) directive.|Anywhere.|
|#region|Creates a [#region](https://msdn.microsoft.com/library/672c87d1-9771-4f64-ab3f-0ad3d4ffb2b4) directive and a [#endregion](https://msdn.microsoft.com/library/16099660-91b2-49e5-9646-77f9ef069526) directive.|Anywhere.|
|~|Creates a destructor for the containing class.|Inside a class.|
|attribute|Creates a declaration for a class that derives from <xref:System.Attribute>.|Inside a namespace (including the global namespace), a class, or a struct.|
|checked|Creates a [checked](https://msdn.microsoft.com/library/718a1194-988d-48a3-b089-d6ee8bd1608d) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|class|Creates a class declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|ctor|Creates a constructor for the containing class.|Inside a class.|
|cw|Creates a call to <xref:System.Console.WriteLine%2A>.|Inside a method, an indexer, a property accessor, or an event accessor.|
|do|Creates a [do](https://msdn.microsoft.com/library/50725f79-9ba6-4898-aa78-6e331568a1bb)`while` loop.|Inside a method, an indexer, a property accessor, or an event accessor.|
|else|Creates an [else](https://msdn.microsoft.com/library/d9a1d562-8cf5-4bd4-9ba7-8ad970cd25b2) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|enum|Creates an [enum](https://msdn.microsoft.com/library/bbeb9a0f-e9b3-41ab-b0a6-c41b1a08974c) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|equals|Creates a method declaration that overrides the <xref:System.Object.Equals%2A> method defined in the <xref:System.Object> class.|Inside a class or a struct.|
|exception|Creates a declaration for a class that derives from an exception (<xref:System.Exception> by default).|Inside a namespace (including the global namespace), a class, or a struct.|
|for|Creates a [for](https://msdn.microsoft.com/library/34041a40-2c87-467a-9ffb-a0417d8f67a8) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|
|foreach|Creates a [foreach](https://msdn.microsoft.com/library/5a9c5ddc-5fd3-457a-9bb6-9abffcd874ec) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|
|forr|Creates a [for](https://msdn.microsoft.com/library/34041a40-2c87-467a-9ffb-a0417d8f67a8) loop that decrements the loop variable after each iteration.|Inside a method, an indexer, a property accessor, or an event accessor.|
|if|Creates an [if](https://msdn.microsoft.com/library/d9a1d562-8cf5-4bd4-9ba7-8ad970cd25b2) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|indexer|Creates an indexer declaration.|Inside a class or a struct.|
|interface|Creates an [interface](https://msdn.microsoft.com/library/7da38e81-4f99-4bc5-b07d-c986b687eeba) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|invoke|Creates a block that safely invokes an event.|Inside a method, an indexer, a property accessor, or an event accessor.|
|iterator|Creates an iterator.|Inside a class or a struct.|
|iterindex|Creates a "named" iterator and indexer pair by using a nested class.|Inside a class or a struct.|
|lock|Creates a [lock](https://msdn.microsoft.com/library/656da1a4-707e-4ef6-9c6e-6d13b646af42) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|mbox|Creates a call to <xref:System.Windows.Forms.MessageBox.Show%2A?displayProperty=fullName>. You may have to add a reference to System.Windows.Forms.dll.|Inside a method, an indexer, a property accessor, or an event accessor.|
|namespace|Creates a [namespace](https://msdn.microsoft.com/library/0a788423-9110-42e0-97d9-bda41ca4870f) declaration.|Inside a namespace (including the global namespace).|
|prop|Creates an [auto-implemented property](https://msdn.microsoft.com/library/aa55fa97-ccec-431f-b5e9-5ac789fd32b7) declaration.|Inside a class or a struct.|
|propfull|Creates a property declaration with get and set accessors.|Inside a class or a struct.|
|propg|Creates a read-only [auto-implemented property](https://msdn.microsoft.com/library/aa55fa97-ccec-431f-b5e9-5ac789fd32b7) with a private "set" accessor.|Inside a class or a struct.|
|sim|Creates a [static](https://msdn.microsoft.com/library/5509e215-2183-4da3-bab4-6b7e607a4fdf)[int](https://msdn.microsoft.com/library/212447b4-5d2a-41aa-88ab-84fe710bdb52) Main method declaration.|Inside a class or a struct.|
|struct|Creates a [struct](https://msdn.microsoft.com/library/ff3dd9b7-dc93-4720-8855-ef5558f65c7c) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|svm|Creates a [static](https://msdn.microsoft.com/library/5509e215-2183-4da3-bab4-6b7e607a4fdf)[void](https://msdn.microsoft.com/library/0d2d8a95-fe20-4fbd-bf5d-c1e54bce71d4) Main method declaration.|Inside a class or a struct.|
|switch|Creates a [switch](https://msdn.microsoft.com/library/44bae8b8-8841-4d85-826b-8a94277daecb) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|try|Creates a [try-catch](https://msdn.microsoft.com/library/cb5503c7-bfa1-4610-8fc2-ddcd2e84c438) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|tryf|Creates a [try-finally](https://msdn.microsoft.com/library/c27623fb-7261-4464-862c-7a369d3c8f0a) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|unchecked|Creates an [unchecked](https://msdn.microsoft.com/library/0c021f7c-923f-4b3d-a58f-55336f5ac27e) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|unsafe|Creates an [unsafe](https://msdn.microsoft.com/library/7e818009-1c6e-4b9e-b769-3728a01586a0) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|using|Creates a [using](https://msdn.microsoft.com/library/b42b8e61-5e7e-439c-bb71-370094b44ae8) directive.|Inside a namespace (including the global namespace).|
|while|Creates a [while](https://msdn.microsoft.com/library/72a0765c-6852-4aca-b327-4a11cb7f5c59) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|

## See Also
 [Code Snippet Functions](../ide/code-snippet-functions.md)
 [Code Snippets](../ide/code-snippets.md)
 [How to: Create a New Snippet with Replacements](https://msdn.microsoft.com/8d56d43c-097a-475b-aa85-cae1554b6338)
 [Template Parameters](../ide/template-parameters.md)
 [How to: Use Surround-with Code Snippets](../ide/how-to-use-surround-with-code-snippets.md)
 [How to: Restore C# Refactoring Snippets](../ide/how-to-restore-csharp-refactoring-snippets.md)
