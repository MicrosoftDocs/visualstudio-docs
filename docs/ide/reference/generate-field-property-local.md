---
title: "Generate a field, property, or local - Code Generation (C#) | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c11888e0-31b1-44cc-9037-98d3f8b3623b
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "dotnet"
---

# Generate a field, property, or local in C# #
**What:** Lets you immediately generate the code for a previously undeclared field, property, or local. 

**When:** You introduce a new field, property or local while typing and want to properly declare it, automatically.  

**Why:** You could declare the field, property or local before using it, however this feature will generate the declaration and type automatically. 

**How:**

1. Place your cursor on the line where there is a red squiggle indicating you've used a field, local or property that doesn't yet exist.

   ![Highlighted code](media/field-highlight-cs.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Generate field/property/local** from the Preview window popup.
   * **Mouse**
     * Right-click and select the **Quick Actions and Refactorings** menu and select **Generate field/property/local** from the Preview window popup.
     * Hover over the red squiggle and click the ![Lightbulb](media/bulb-cs.png) icon which appears.
     * Click the ![Lightbulb](media/bulb-cs.png) icon which appears in the left margin if the text cursor is already on the line with the red squiggle.

   ![Generate field/property/local preview](media/field-preview-cs.png)

   >[!TIP]
   >Use the [**Preview changes**](../../ide/preview-changes.md) link at the bottom of the preview window to see all of the changes that will be made before making your selection.

1. The field, property or local will be created automatically with the type inferred from its usage.

   ![Generate field/property/local result](media/field-result-cs.png)

## See also

[Code Generation](../code-generation-in-visual-studio.md)  
[Preview Changes](../../ide/preview-changes.md)
