---
title: "How to: Restore C# Refactoring Snippets | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "unsafe expansion"
  - "expansions, unsafe"
ms.assetid: 12114273-7f2f-43d0-abcb-2d4711a3a68d
caps.latest.revision: 24
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Restore C# Refactoring Snippets
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

C# refactoring operations rely on code snippets found in the following directory:

 *Installation directory*\Microsoft Visual Studio 14.0\VC#\Snippets\\*language ID*\Refactoring

 If this Refactoring directory, or any files in this directory are deleted or corrupted, then C# refactoring operations may not work in the IDE. The following procedures can help you restore C# refactoring code snippets.

### To verify C# refactoring snippets are available through the Code Snippet Manager

1. In the **Tools** menu, select **Code Snippet Manager**.

2. In the **Code Snippet Manager** dialog box, select **Visual C#** from the **Language** drop-down list.

     A **Refactoring** folder should appear in the tree view folder list.

### To restore refactoring see comment in Code Snippet Manager

1. If the **Refactoring** folder does not appear in the tree view folder list of the Code Snippet Manager, then use this procedure to add refactoring snippets back into Code Snippet Manager.

2. In the **Tools** menu, select **Code Snippet Manager**.

3. In the **Code Snippet Manager** dialog box, select **Visual C#** from the **Language** drop-down list.

4. Click **Add**. The **Code Snippets Directory** dialog box, which helps you locate and specify the directory to add back into the Code Snippet Manager, appears.

5. Locate the **Refactoring** folder whose directory path is:

     *Installation directory*\Microsoft Visual Studio 14.0\VC#\Snippets\\*language ID*\Refactoring

     The actual path is similar to the following for a default installation:

     C:\Program Files\Microsoft Visual Studio 14.0\VC#\Snippets\1033\Refactoring.

6. Click **Open** in the **Code Snippets Directory** dialog box, and then click **OK** in the Code Snippets Manager.

## See Also
 [Visual C# Code Snippets](../ide/visual-csharp-code-snippets.md)
 [Refactoring (C#)](../csharp-ide/refactoring-csharp.md)
 [Code Snippets](../ide/code-snippets.md)
