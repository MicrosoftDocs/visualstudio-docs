---
title: Error List Window
description: Learn about the Error List window and how to use it to perform tasks related to resolving the errors it displays.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Task List
- build errors
- Error List window
- errors [Visual Studio], Error List window
ms.assetid: b7f6d45a-733b-4ad8-bc2f-737a37509e56
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Error List Window

> [!NOTE]
> The **Error List** displays information about a specific error message. You can copy the error number or error string text from the **Output** window. To display the **Output** window, press **Ctrl**+**Alt**+**O**. See [Output window](../../ide/reference/output-window.md).

The **Error List** window lets you perform the following tasks:

- Display the errors, warnings, and messages produced while you write code.

- Find syntax errors noted by IntelliSense.

- Find deployment errors, certain Static Analysis errors, and errors detected while applying Enterprise Template policies.

- Double-click any error message entry to open the file where the problem occurs, and move to the error location.

- Filter which entries are displayed, and which columns of information appear for each entry.

- Search for specific terms and scope the search to just the current project or document.

To display the **Error List**, choose **View** > **Error List**, or press **Ctrl**+**\\**+**E**.

You can choose the **Errors**, **Warnings**, and **Messages** tabs to see different levels of information.

To sort the list, click any column header. To sort again by an additional column, hold down the **Shift** key and click another column header. To select which columns are displayed and which are hidden, choose **Show Columns** from the shortcut menu. To change the order in which columns are displayed, drag any column header to the left or right.

## Error List Filters

There are two types of filter in two dropdown boxes, one on the right side of the toolbar and one to the left of the toolbar. The dropdown list on the left side of the toolbar specifies the set of code files to use (**Entire Solution**, **Open Documents**, **Current Project**, **Current Document**).

You can restrict the scope of the search to analyze and act on groups of errors. For example, you might want to focus on core errors that are preventing a project from compiling. The scoping options include:

1. **Open Documents**: Show errors, warnings, and messages for the open documents.

2. **Current Project**: Show errors, warnings, and messages from the project of the currently selected document in the **Editor** or the selected project in **Solution Explorer**.

    > [!NOTE]
    > The filtered list of errors, warnings, and messages will change if the project of the currently selected document is different from the project selected in **Solution Explorer**.

3. **Current Document**: Show errors, warnings, and messages for the currently selected document in the **Editor** or **Solution Explorer**.

If a filter is currently applied to the search result, the name of the filter appears in the **Error List** title bar. The **Errors**, **Warnings**, and **Messages** buttons then display the number of filtered items being shown along with the total number of items. For example, the buttons show "x of y Errors". If no filter is applied, the title bar says only "Error List".

The list on the right side of the toolbar specifies whether to show errors from the build (errors resulting from a build operation) or from IntelliSense (errors detected before running a build), or from both.

## Search

Use the **Search Error List** text box on the right side of the **Error List** toolbar to find specific errors in the error list. You can search on any visible column in the error list, and search results are always sorted based on the column that has sort priority instead of on the query or the filter applied. If you choose the **Esc** key while the focus is in the **Error List**, you can clear the search term and filtered search results. You can also click the **X** on the right side of the text box to clear it.

## Save

You can copy the error list and save it to a file. Select the errors you want to copy and right-click the selection, then on the context menu select **Copy**. You can then paste the errors into a file. If you paste the errors to an Excel spreadsheet, the fields appear as different columns.

## UI Element List

Severity

Displays the different types of **Error List** entry (**Error**, **Message**, **Warning**, **Warning (active)**, **Warning (inactive)**.

Code

Displays the error code.

Description

Displays the text of the entry.

Project

Displays the name of the current project.

File

Displays the file name.

Line

Displays the line where the problem occurs.
