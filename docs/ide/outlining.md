---
title: Collapse and Expand Regions of Code
description: Use the expand and collapse commands in the Visual Studio integrated development environment (IDE) to work in outline mode.
ms.date: 08/25/2025
ms.topic: concept-article
helpviewer_keywords:
- outlining
- Visual Studio, expand/collapse code
- Visual Studio, outlining
- expand/collapse code
- code [Visual Studio], outlining
- code [Visual Studio], hiding
- outlining code
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
#customer intent: As a developer, I want to learn how to collapse and expand code in Visual Studio to make it easier to write and maintain code.
---

# Outlining

This article describes the outlining feature in Visual Studio. To hide a region of code from view, you can collapse it so that it appears under a caret sign (`>`) in the code editor. Then, to expand a collapsed region, select the caret sign.

You can also select **Ctrl**+**M**+**M** to collapse and expand code.

To collapse an outlining region, double-click any line in the region on the outlining margin, which appears just to the left of the code. You can see the contents of a collapsed region as a tooltip when you hover over the collapsed region.

:::image type="content" source="media/outlining-example-2022.png" alt-text="Screenshot of an example of collapsed code that shows the outlining margin and the expanded code visible in a tooltip.":::

Regions in the outlining margin are also highlighted when you hover over the margin with the mouse. The default highlighting color might be hard to see in some color configurations. You can change it in **Tools** > **Options** > **Environment** > **Fonts and Colors** > **Display items** > **Collapsible Region**.

When you work in outlined code, you can expand the sections you want to work on, collapse them when you're done, and then move to other sections. When you don't want to use outlining, you can use the **Stop Outlining** command to remove the outline information without disturbing your underlying code.

The **Undo** and **Redo** commands on the **Edit** menu affect these actions. The **Copy**, **Cut**, **Paste**, and drag-and-drop operations retain outlining information, but not the state of the collapsible region. For example, when you copy a collapsed region, the **Paste** operation pastes the copied text as an expanded region.

> [!CAUTION]
> When you change an outlined region, the outlining might be lost. For example, deletions or **Find and Replace** operations can erase the end of a region.

You can use these commands from the **Edit** > **Outlining** menu:

| Name | Keyboard shortcut | Description |
|:-----|:---------|:------------|
| Hide Selection | **Ctrl**+**M**, **Ctrl**+**H** | Collapses a selected block of code that wouldn't normally be available for outlining. Example: an `if` block. To remove the custom region, use **Stop Hiding Current** or **Ctrl**+**M**, **Ctrl**+**U**.  |
| Toggle Outlining Expansion | **Ctrl**+**M**, **Ctrl**+**M** | Reverses the current hidden or expanded state of the innermost outlining section when the cursor is in a nested collapsed section. |
| Toggle All Outlining | **Ctrl**+**M**, **Ctrl**+**L** | Sets all regions to the same collapsed or expanded state. If some regions are expanded and some collapsed, the collapsed regions are expanded.|
| Stop Outlining | **Ctrl**+**M**, **Ctrl**+**P** | Removes all outlining information for the entire document. To turn outlining back on, go to **Edit** > **Outlining** and select **Start Automatic Outlining**. |
| Stop Hiding Current | **Ctrl**+**M**, **Ctrl**+**U** | Removes the outlining information for the currently selected user-defined region.   |
| Collapse to Definitions | **Ctrl**+**M**, **Ctrl**+**O** | Collapses the members of all types. |

> [!TIP]
> For more information on how to use the keyboard, see [Keyboard shortcuts in Visual Studio](default-keyboard-shortcuts-in-visual-studio.md).

You can also use the Visual Studio SDK to define the text regions that you want to expand or collapse. For more information, see [Walkthrough: Outlining](../extensibility/walkthrough-outlining.md).

## Related content

- [Features of the code editor](writing-code-in-the-code-and-text-editor.md)
