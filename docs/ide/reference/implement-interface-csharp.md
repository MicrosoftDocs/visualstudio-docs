---
title: "Implement an interface - Code Generation (C#) | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: bebff2ad-25b6-4adc-8762-60d23bdd639a
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "dotnet"
---

# Implement an interface in C# #
**What:** Lets you immediately generate the code required to implement an interface. 

**When:** You want to inherit from an interface.  

**Why:** You could manually implement all interface one-by-one, however this feature will generate all method signatures automatically. 

**How:**

1. Place your cursor on the line where there is a red squiggle indicating you have referenced an interface but have not implemented all required members.

   ![Highlighted code](media/interface-highlight-cs.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Implement interface (explicitly)** from the Preview window popup.
   * **Mouse**
     * Right-click and select the **Quick Actions and Refactorings** menu and select **Implement interface (explicitly)** from the Preview window popup.
     * Hover over the red squiggle and click the ![Lightbulb](media/bulb-cs.png) icon which appears.
     * Click the ![Lightbulb](media/bulb-cs.png) icon which appears in the left margin if the text cursor is already on the line with the red squiggle.

   ![Implement class preview](media/interface-preview-cs.png)

   >[!TIP]
   >Use the [**Preview changes**](../../ide/preview-changes.md) link at the bottom of the preview window to see all of the changes that will be made before making your selection.
   >
   >Additionally, you can use the **Document**, **Project**, and **Solution** links at the bottom of the preview window to create the proper method signatures across multiple classes which implement the interface.

1. The interface's method signatures will be created automatically, ready to be implemented.

   ![Implement class result](media/interface-result-cs.png)

   >[!TIP]
   >Use the **Implement interface explicitly** option to preface each generated method with the interface name to avoid name collisions.
   >
   >![Implement interface explicitly result](media/interface-explicitresult-cs.png); 

## See also

[Code Generation](../code-generation-in-visual-studio.md)  
[Preview Changes](../../ide/preview-changes.md)  
