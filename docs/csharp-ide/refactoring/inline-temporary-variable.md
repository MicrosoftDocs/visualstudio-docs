---
title: "Inline Temporary Variable | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
    - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0182179f-f74f-47a2-a1dc-b60c86f9abaf
author: "BrianPeek"
ms.author: "brpeek"
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

# Inline Temporary Variable
**What:** Lets you remove the use of a temporary variable and replace it with the actual code instead.

**When:** The use of the temporary variable makes the code harder to understand.  

**Why:** Removing a temporary variable may make the code easier to read in certain situations

**How:**

1. Highlight or place the text cursor inside the temporary variable to be inlined:

   ![Highlighted code](media/inline_highlight.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Inline temporary variable** from the Preview window popup.
   * **Mouse**
     * Right-click the code, select the **Quick Actions and Refactorings** menu and select **Inline temporary variable** from the Preview window popup.

   The variable will be removed and its usages replaced by the value of the variable immediately.

   ![Inline result](media/inline_result.png)
