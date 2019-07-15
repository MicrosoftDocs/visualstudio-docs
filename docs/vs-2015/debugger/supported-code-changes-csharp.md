---
title: "Supported Code Changes (C#) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Edit and Continue [C#], supported code changes"
ms.assetid: c7a48ea9-5a7f-4328-a9d7-f0e76fac399d
caps.latest.revision: 30
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Supported Code Changes (C#)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Edit and Continue handles most types of code changes within method bodies. Most changes outside method bodies, and a few changes within method bodies, cannot be applied during debugging, however. To apply those unsupported changes, you must stop debugging and restart with a fresh version of the code.  
  
 The following changes cannot be applied to C# code during a debugging session:  
  
- Changes to the current statement or any other active statement.  
  
     Active statements include any statements, in functions on the call stack, that were called to get to the current statement.  
  
     The current statement is marked by a yellow background in the source window. Other active statements are marked by a shaded background and are read-only. These default colors can be changed in the **Options** dialog box.  
  
- Changing the signature of a type.  
  
- Adding an anonymous method that captures a variable that hasn’t been captured before.  
  
- Adding, removing, or changing attributes.  
  
- Adding, removing, or changing `using` directives.  
  
- Adding a `foreach`, `using`, or `lock` around the active statement.  
  
## Unsafe Code  
 Changes to unsafe code have the same limitations as changes to safe code, with one additional restriction: Edit and Continue does not support changes to unsafe code that exits within a method that contains the `stackalloc` operator.  
  
## Exceptions  
 Edit and Continue supports changes to `catch` and `finally` blocks, except that adding a `catch` or `finally` block around the active statement is not allowed.  
  
## Unsupported Scenarios  
 Edit and Continue is not available in the following debugging scenarios:  
  
- Debugging LINQ code in certain circumstances. For more information, see [Debugging LINQ](../debugger/debugging-linq.md).  
  
  - Capturing a variable that hasn’t been captured before.  

  - Changing the type of query expression (e.g., select a => select new { A = a };)  

  - Removing a `where` that contains an active statement.  

  - Removing a `let` that contains an active statement.  

  - Removing a `join` that contains an active statement.  

  - Removing an `orderby` that contains an active statement.  
  
- Mixed-mode (native/managed) debugging.  
  
- SQL debugging.  
  
- Debugging a Dr. Watson dump.  
  
- Editing code after an unhandled exception, when the "**Unwind the call stack on unhandled exceptions**" option is not selected.  
  
- Debugging an embedded runtime application.  
  
- Debugging an application that has **Attach to** instead of running the application by choosing **Start** from the **Debug** menu.  
  
- Debugging optimized code.  
  
- Debugging an old version of your code after a new version failed to build because of build errors.  
  
## See Also  
 [Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md)   
 [How to: Use Edit and Continue (C#)](../debugger/how-to-use-edit-and-continue-csharp.md)
