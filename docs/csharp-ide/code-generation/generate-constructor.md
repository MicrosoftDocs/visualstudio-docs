---
title: "Generate a constructor - Code Generation (C#) | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f2280cfa-a9ec-4b56-9d94-c8fd384db980
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

# Generate a constructor in C# #
**What:** Lets you immediately generate the code for a new constructor on a class. 

**When:** You introduce a new constructor and want to properly declare it, automatically.  

**Why:** You could declare the constructor before using it, however this feature will generate it, with the proper parameters, automatically. 

**How:**

1. Place your cursor on the line where there is a red squiggle indicating you've used a constructor that doesn't yet exist.

   ![Highlighted code](media/constructor_highlight.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Generate constructor in '*TypeName*'** from the Preview window popup.
   * **Mouse**
     * Right-click and select the **Quick Actions and Refactorings** menu and select **Generate constructor in '*TypeName*'** from the Preview window popup.
     * Hover over the red squiggle and click the ![Lightbulb](media/bulb.png) icon which appears.
     * Click the ![Lightbulb](media/bulb.png) icon which appears in the left margin if the text cursor is already on the line with the red squiggle.

   ![Generate constructor preview](media/constructor_preview.png)

   >[!TIP]
   >Use the [**Preview changes**](../../ide/preview-changes.md) link at the bottom of the preview window to see all of the changes that will be made before making your selection.

1. The constructor will be created automatically with any parameters inferred from its usage.

   ![Generate constructor result](media/constructor_result.png)
  
## See Also  
[Code Generation (C#)](../code-generation-csharp.md)  
[Preview Changes](../../ide/preview-changes.md)