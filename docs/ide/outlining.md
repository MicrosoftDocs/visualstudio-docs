---
title: Collapse and expand regions of code
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "outlining"
  - "Visual Studio, expand/collapse code"
  - "Visual Studio, outlining"
  - "expand/collapse code"
  - "code [Visual Studio], outlining"
  - "code [Visual Studio], hiding"
  - "outlining code"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Outlining

You can choose to hide some code from view by collapsing a region of code so that it appears under a plus sign (**+**). You expand a collapsed region by clicking the plus sign. If you are a keyboard user, you can choose **Ctrl**+**M**+**M** to collapse and expand. You can also collapse an outlining region by double-clicking any line in the region on the outlining margin, which appears just to the left of the code. You can see the contents of a collapsed region as a tooltip when you hover over the collapsed region.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Source editor (Visual Studio for Mac)](/visualstudio/mac/source-editor).

Regions in the outlining margin are also highlighted when you hover over the margin with the mouse. The default highlighting color may seem rather faint in some color configurations. You can change it in **Tools** > **Options** > **Environment** > **Fonts and Colors** > **Collapsible Region**.

When you work in outlined code, you can expand the sections you want to work on, collapse them when you are done, and then move to other sections. When you do not wish to have outlining displayed, you can use the **Stop Outlining** command to remove the outline information without disturbing your underlying code.

The **Undo** and **Redo** commands on the **Edit** menu affect these actions. The **Copy**, **Cut**, **Paste**, and drag-and-drop operations retain outlining information, but not the state of the collapsible region. For example, when you copy a region that is collapsed, the **Paste** operation will paste the copied text as an expanded region.

> [!CAUTION]
> When you change an outlined region, the outlining may be lost. For example, deletions or Find and Replace operations may erase the end of the region.

The following commands can be found on the **Edit** > **Outlining** submenu.

|||
|-|-|
|Hide Selection|(**Ctrl**+**M**, **Ctrl**+**H**) - Collapses a selected block of code that would not normally be available for outlining, for example an `if` block. To remove the custom region, use **Stop Hiding Current** (or **Ctrl**+**M**, **Ctrl**+**U**). Not available in Visual Basic.|
|Toggle Outlining Expansion|- Reverses the current hidden or expanded state of the innermost outlining section when the cursor lies in a nested collapsed section.|
|Toggle All Outlining|(**Ctrl**+**M**, **Ctrl**+**L**) - Sets all regions to the same collapsed or expanded state. If some regions are expanded and some collapsed, then the collapsed regions are expanded.|
|Stop Outlining|(**Ctrl**+**M**, **Ctrl**+**P**) - Removes all outlining information for the entire document.|
|Stop Hiding Current|(**Ctrl**+**M**, **Ctrl**+**U**)  - Removes the outlining information for the currently selected user-defined region. Not available in Visual Basic.|
|Collapse to Definitions|(**Ctrl**+**M**, **Ctrl**+**O**) - Collapses the members of all types.|
|Collapse Block:\<logical boundary>|(C++) Collapses a region in the function containing the insertion point. For example, if the insertion point lies inside a loop, the loop is hidden.|
|Collapse All in: \<logical structures>|(C++) Collapses all the structures inside the function.|

You can also use the Visual Studio SDK to define the text regions you want to expand or collapse. See [Walkthrough: Outlining](../extensibility/walkthrough-outlining.md).

## See also

- [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md)
- [Source editor (Visual Studio for Mac)](/visualstudio/mac/source-editor)