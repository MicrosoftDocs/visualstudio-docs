---
title: "How to: Restore C# Refactoring Snippets | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "unsafe expansion"
  - "expansions, unsafe"
ms.assetid: 12114273-7f2f-43d0-abcb-2d4711a3a68d
caps.latest.revision: 20
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
# How to: Restore C# Refactoring Snippets
C# refactoring operations rely on code snippets found in the following directory:  
  
 *Installation directory*\Microsoft Visual Studio 14.0\VC#\Snippets\\*language ID*\Refactoring  
  
 If this Refactoring directory, or any files in this directory are deleted or corrupted, then C# refactoring operations may not work in the IDE. The following procedures can help you restore C# refactoring code snippets.  
  
### To verify C# refactoring snippets are available through the Code Snippet Manager  
  
1.  In the **Tools** menu, select **Code Snippet Manager**.  
  
2.  In the **Code Snippet Manager** dialog box, select **Visual C#** from the **Language** drop-down list.  
  
     A **Refactoring** folder should appear in the tree view folder list.  
  
### To restore refactoring see comment in Code Snippet Manager  
  
1.  If the **Refactoring** folder does not appear in the tree view folder list of the Code Snippet Manager, then use this procedure to add refactoring snippets back into Code Snippet Manager.  
  
2.  In the **Tools** menu, select **Code Snippet Manager**.  
  
3.  In the **Code Snippet Manager** dialog box, select **Visual C#** from the **Language** drop-down list.  
  
4.  Click **Add**. The **Code Snippets Directory** dialog box, which helps you locate and specify the directory to add back into the Code Snippet Manager, appears.  
  
5.  Locate the **Refactoring** folder whose directory path is:  
  
     *Installation directory*\Microsoft Visual Studio 14.0\VC#\Snippets\\*language ID*\Refactoring  
  
     The actual path is similar to the following for a default installation:  
  
     C:\Program Files\Microsoft Visual Studio 14.0\VC#\Snippets\1033\Refactoring.  
  
6.  Click **Open** in the **Code Snippets Directory** dialog box, and then click **OK** in the Code Snippets Manager.  
  
## See Also  
 [Visual C# Code Snippets](../ide/visual-csharp-code-snippets.md)   
 [Refactoring (C#)](../csharp-ide/refactoring-csharp.md)   
 [Code Snippets](../ide/code-snippets.md)