---
title: "Outlining | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "outlining"
  - "Visual Studio, expand/collapse code"
  - "Visual Studio, outlining"
  - "expand/collapse code"
  - "code [Visual Studio], outlining"
  - "code [Visual Studio], hiding"
  - "outlining code"
ms.assetid: d1476758-9d35-4d74-b63c-310661932ecd
caps.latest.revision: 38
author: jillre
ms.author: jillfra
manager: jillfra
---
# Outlining
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can choose to hide some code from view by collapsing a region of code so that it appears under a plus sign (+). You expand a collapsed region by clicking the plus sign. (Or you can press CTRL + M + M to collapse a region and then CTRL+ M + M to expand it again.) You can also collapse an outlining region by double-clicking any line in the region on the outlining margin, which appears just to the left of the code. You can see the contents of a collapsed region as a tooltip when you hover over the collapsed region.

 Regions in the outlining margin are also highlighted when you hover over the margin with the mouse. The default highlighting color may seem rather faint in some color configurations. You can change it in **Tools/Options/Environment/Fonts and Colors/Collapsible Region**.

 When you work in outlined code, you can expand the sections you want to work on, collapse them when you are done, and then move to other sections. When you do not wish to have outlining displayed, you can use the **Stop Outlining** command to remove the outline information without disturbing your underlying code.

 The **Undo** and **Redo** commands on the **Edit** menu affect these actions. The **Copy**, **Cut**, **Paste**, and drag-and-drop operations retain outlining information, but not the state of the collapsible region. For example, when you copy a region that is collapsed, the **Paste** operation will paste the copied text as an expanded region.

> [!CAUTION]
> When you change an outlined region, the outlining may be lost. For example, deletions or Find and Replace operations may erase the end of the region.

 The following commands can be found on the **Edit/Outlining** submenu.

|||
|-|-|
|Hide Selection|(CTRL + M , CTRL + H) - Collapses a selected block of code that would not normally be available for outlining, for example an `if` block. To remove the custom region, use **Stop Hiding Current** (or CTRL + M, CTRL + U). Not available in Visual Basic.|
|Toggle Outlining Expansion|- Reverses the current hidden or expanded state of the innermost outlining section when the cursor lies in a nested collapsed section.|
|Toggle All Outlining|(CTRL + M, CTRL + L) - Sets all regions to the same collapsed or expanded state. If some regions are expanded and some collapsed, then the collapsed regions are expanded.|
|Stop Outlining|(CTRL + M, CTRL + P) - Removes all outlining information for the entire document.|
|Stop Hiding Current|(CTRL + M, CTRL + U)  - Removes the outlining information for the currently selected user-defined region. Not available in Visual Basic.|
|Collapse to Definitions|(CTRL + M, CTRL + O) - Collapses the members of all types.|
|Collapse Block:\<logical boundary>|(Visual C++) Collapses a region in the function containing the insertion point. For example, if the insertion point lies inside a loop, the loop is hidden.|
|Collapse All in: \<logical structures>|(Visual C++) Collapses all the structures inside the function.|

 You can also use the Visual Studio SDK to define the text regions you want to expand or collapse. See [Walkthrough: Outlining](../extensibility/walkthrough-outlining.md).
