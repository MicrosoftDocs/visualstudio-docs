---
title: "Edit and Continue Errors and Warnings (C#)"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c0e12b0a-8009-4a4a-979f-c804a91a5d9b
caps.latest.revision: 11
manager: douge
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
# Edit and Continue Errors and Warnings (C#)
You have made an edit to a section of code that is not allowed in Visual C# Edit and Continue.  
  
 Visual C# Edit and Continue lets you stop program execution in Break mode, make changes to the executing code, and then resume program execution with the newly incorporated changes.  
  
 Declarative code edits that affect the public structure of a class are generally prohibited, and some edits that you might make to a method, property body, or private declarations within a class are not allowed. Whenever possible, Edit and Continue marks code that cannot be edited as light gray and displays an error message.  
  
 For more information about supported edits in Edit and Continue for Visual C#, see [Supported Code Changes (C#)](../VS_debugger/Supported-Code-Changes--C#-.md). If you need more information about a specific error or warning, you can search or post on the MSDN [Visual C# IDE forum](http://go.microsoft.com/fwlink/?LinkId=214693).  
  
### To correct this error  
  
1.  On the **Debug** menu, choose **Undo** to undo the change.  
  
     -or-  
  
2.  Stop the debugging session, make your edits, and start a new debugging session.  
  
## See Also  
 [Edit and Continue (Visual C#)](../VS_debugger/Edit-and-Continue--Visual-C#-.md)