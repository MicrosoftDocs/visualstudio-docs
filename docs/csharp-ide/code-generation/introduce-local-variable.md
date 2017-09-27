---
title: "Introduce a local variable - Code Generation (C#) | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1490d6ac-ed56-4d03-95db-c23f23cba70d
author: "gewarren"
ms.author: "gewarren"
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

# Introduce a local variable in C# #
**What:** Lets you immediately generate a local variable to replace an existing expression.

**When:** You have code which could be easily reused later if it were in a local variable.  

**Why:** You could copy and paste the code multiple times to use it in various locations, however it would be better to perform the operation once, store the result in a local variable, and use the local variable throughought. 

**How:**

1. Highlight the expression that you want to assign to a new local variable.

   ![Highlighted code](media/local_highlight.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Introduce local for (all occurrences of) '*expression*'** from the Preview window popup, where *expression* is the code you have highlighted.
   * **Mouse**
     * Right-click and select the **Quick Actions and Refactorings** menu and select **Introduce local for (all occurrences of) '*expression*'** from the Preview window popup, where *expression* is the code you have highlighted.
     * Click the ![Lightbulb](media/bulb.png) icon which appears in the left margin if the text cursor is already on the line with the red squiggle.

   ![Introduce local preview](media/local_preview.png)

   >[!TIP]
   >Use the [**Preview changes**](../../ide/preview-changes.md) link at the bottom of the preview window to see all of the changes that will be made before making your selection.

1. The local variable will be created automatically with the type inferred from its usage.  Give the new local variable a new name by typing it.

   ![Introduce local result](media/local_result.png)

   >[!NOTE]
   >You can use the **...all occurences of...** menu option to replace every instance of the selected expression found, not just the one you have specifically highlighted.

## See Also  
[Code Generation (C#)](../code-generation-csharp.md)  
[Preview Changes](../../ide/preview-changes.md) 
