---
title: How to view errors and warnings
description: Step-by-step instructions for using the Error List window to view, filter, search, navigate, and save errors and warnings in Visual Studio.
ms.date: 8/27/2025
ms.topic: how-to
helpviewer_keywords:
- Task List
- build errors
- Error List window
- errors [Visual Studio], Error List window
ms.custom: "ide-ref"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
ai-usage: ai-assisted
---

# How to view errors and warnings

> [!NOTE]
> The **Error List** displays information about a specific error message. You can copy the error number or error string text from the **Output** window. To display the **Output** window, press **Ctrl**+**Alt**+**O**. See [Output window](output-window.md).

Use the Error List to find and act on errors, warnings, and informational messages while you write and build code. This how-to shows common tasks: displaying the Error List, filtering its contents, searching and sorting entries, navigating to the source of an error, copying or saving results, and getting help online.

## Display the Error List

1. Choose **View** > **Error List**, or press **Ctrl**+**\\**+**E**.
2. Choose one of the tabs to control the level of information shown: **Errors**, **Warnings**, or **Messages**.

## Filter the list by scope and source

Use the toolbar dropdowns to limit which entries appear:

- Left dropdown (scope): **Entire Solution**, **Open Documents**, **Current Project**, **Current Document**. This restricts the set of code files considered by the Error List.
- Right dropdown (source): **Build**, **IntelliSense**, or both. Choose whether to show errors that resulted from a build, from IntelliSense analysis, or both.

> [!NOTE]
> When a filter is applied, the Error List title bar shows the filtered count (for example, "x of y Errors"). If no filter is applied, the title bar displays "Error List".

## Sort and customize columns

- Click any column header to sort by that column. Hold **Shift** and click additional headers to apply a secondary sort.
- To select which columns are visible, right-click any column header and choose **Show Columns**. To change the display order, drag column headers left or right.

## Search the Error List

1. Use the **Search Error List** text box on the right side of the Error List toolbar to find specific entries.
2. You can search for terms that appear in any visible column. Search results are always sorted based on the column that has sort priority, not by the search query or filter.
3. To clear the search, press **Esc** while the focus is in the Error List, or click the **X** on the right side of the Search box.

## Open the file and navigate to an error

- Double-click any entry in the Error List to open the file that contains the problem and move to the error location.

## Copy or save errors

1. Select the errors you want to copy.
2. Right-click the selection and choose **Copy**, or press **Ctrl**+**C**.
3. Paste the copied entries into a text file or an Excel spreadsheet (fields map to columns).

- To copy the entire row for a single entry, right-click and choose **Copy Row**, or press **Ctrl**+**Shift**+**C**.

## Get help online

- Press **F1** to open the documentation page for the selected error code (if available). The page opens in your default browser or Help Viewer.
- In Visual Studio 17.12 and later, copying an error from the Error List using **Ctrl**+**C** also copies the description to the clipboard so you can paste it into a search.
- To open the browser and initiate a Bing search with the error description in one keystroke, press **Ctrl**+**F1**.

## View problem details

- For C++ projects, you can enable the **Details** column, which displays a clickable icon when an entry has additional diagnostic information. Click the icon to open the [Problem Details window](reference/problem-details-window.md).

## Manage the Error List window

- Like any other tool window, you can auto-hide, pin, or close the Error List, and include it in saved window layouts. See [Customize window layouts in Visual Studio - Close and autohide tool windows](customizing-window-layouts-in-visual-studio.md#close-and-autohide-tool-windows).

## UI reference

- **Severity** — Displays the type of entry (Error, Warning, Message, Warning (active/inactive)).
- **Code** — The error or warning code.
- **Description** — The entry text describing the issue.
- **Project** — The project where the error was detected.
- **File** — The file name that contains the issue.
- **Line** — The line number where the problem occurs.
- **Details** — (C++ projects) Click to open the Problem Details window if extra diagnostic information exists.

In addition, you can enable the following other columns. Right-click on the column bar to open the context menu, and choose **Show Columns** to enable them.

- **Project Rank** - The numbers enumerate the projects in the solution (1-based).
- **Path** - Path to the file that contains this code
- **Column** - The column number where the issue was detected.
- **Category** - IntelliSense only. Category of the issue, for example, "Compiler."
- **Source** -  Sources include Build and IntelliSense.
- **Tool** - the executable tool that generated this code

For more information and additional conceptual details about the Error List, see the original documentation for the Error List window.
