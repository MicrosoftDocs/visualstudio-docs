---
title: "Move Type to Matching File | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
    - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 40f58c34-c50f-4297-91b2-2e243380dcc9
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

# Move Type to Matching File
**What:** Lets you move the selected type to a separate file with the same name.

**When:** You have multiple classes, structs, interfaces, etc. in the same file which you want to separate.  

**Why:** Placing multiple types in the same file can make it difficult to find these types.  By moving types to files with the same name, code becomes more readable and easier to navigate.

**How:**

1. Highlight or place the text cursor inside the name of the type to move:

   ![Highlighted code](media/movetype_highlight.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Move type to *TypeName*.cs** from the Preview window popup, where *TypeName* is the name of the type you have selected.
   * **Mouse**
     * Right-click the code, select the **Quick Actions and Refactorings** menu and select **Move type to *TypeName*.cs** from the Preview window popup, where *TypeName* is the name of the type you have selected.

   The type will instantly moved to a new file with that name inside of your solution.

   ![Inline result](media/movetype_result.png)
