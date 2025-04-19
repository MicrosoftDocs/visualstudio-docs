---
title: Go to File, Go to Symbol, Go to Line
description: Explore how you can use Go To commands in Visual Studio to perform focused and filtered searches of your code.
ms.date: 04/03/2025
ms.topic: conceptual
helpviewer_keywords:
- code editor, go to
- code editor, go to line
- go to line
- go to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to explore Go To commands in Visual Studio so that I can quickly find specific items. 
---

# Find code by using Go To commands

The Visual Studio **Go To** commands perform a focused search of your code to help you quickly find specific items. You can go to a specific line, type, symbol, file, or member by using a simple, unified interface.

:::moniker range=">=vs-2022"

In Visual Studio 2022, a new search experience replaces much of the functionality described here. For example, **Go to type** (**Ctrl**+**T**) goes, by default, to the new search experience in Visual Studio 2022 rather than opening the **Go to type** window. For information about the new search experience, see [Visual Studio search](visual-studio-search.md).

:::moniker-end

## How to use Go To

Input method | Steps
------------ | ---
**Keyboard** | Select **Ctrl**+**T** or **Ctrl**+**,**
**Mouse** | Select **Edit** > **Go To** > **Go To All**

A small window is displayed in the top right corner of the code editor:

:::image type="content" source="media/go-to-all.png" alt-text="Screenshot that shows the Go to All window.":::

As you type in the text box, the results appear in a drop-down list below the text box. To go to an element, select it.

:::image type="content" source="../ide/media/vside_navigatetowindow.png" alt-text="Screenshot that shows the Navigate To window." lightbox="../ide/media/vside_navigatetowindow.png":::

You can also enter a question mark (**?**) to get additional help:

:::image type="content" source="media/go-to-all-help.png" alt-text="Screenshot that shows the Go to All Help window.":::

## Filtered searches

By default, the specified item is searched for among all solution items. However, you can limit your code search to specific element types by prefacing the search terms with certain characters. You can also quickly change the search filter by selecting buttons on the toolbar of the **Go To** dialog. Buttons that change the type filters are on the left side, and buttons that change the scope of the search are on the right side:

:::image type="content" source="../ide/media/vside_navigation_toolbar.png" alt-text="Screenshot that shows the filter and scope buttons in the toolbar." lightbox="../ide/media/vside_navigation_toolbar.png":::

### Filter by a specific type of code element

To narrow your search to return only a specific type of code element, you can either specify a prefix in the search box or select one of the five filter icons:

Prefix | Icon | Shortcut | Description
:-: | - | - | -
:| :::image type="icon" source="media/gotoall-line-icon.png":::| **Ctrl**+**G** | Go to the specified line number
f| :::image type="icon" source="media/gotoall-files-icon.png"::: | **Ctrl**+**1**, **Ctrl**+**F** | Go to the specified file
r| :::image type="icon" source="media/gotoall-recent-files-icon.png":::| **Ctrl**+**1**, **Ctrl**+**R** | Go to the specified recently visited file
t| :::image type="icon" source="media/gotoall-types-icon.png":::| **Ctrl**+**1**, **Ctrl**+**T** | Go to the specified type
m| :::image type="icon" source="media/gotoall-members-icon.png"::: | **Ctrl**+**1**, **Ctrl**+**M** | Go to the specified member
\#| :::image type="icon" source="media/gotoall-symbols-icon.png"::: | **Ctrl**+**1**, **Ctrl**+**S** | Go to the specified symbol

### Filter by a specific location

To narrow your search to return only items from a specific location, select one of the two document icons:

Icon | Description
---- | ---
|:::image type="icon" source="media/gotoall_currentdocument.png":::| Search current document only|
|:::image type="icon" source="media/gotoall_external.png"::: | Search external documents in addition to those located in the project/solution|

## Camel casing

If you use [camel casing](https://en.wikipedia.org/wiki/Camel_case) in your code, you can find code elements faster by entering only the capital letters of the code element name. For example, if your code has a type called `CredentialViewModel`, you can narrow the search by selecting the **Type** filter (**t**) and then entering just the capital letters of the name (**CVM**) in the **Go To** dialog. This feature can be helpful if your code has long names.

:::image type="content" source="../ide/media/vside_uppercasesearch.png" alt-text="Screenshot that shows how to search with uppercase letters." lightbox="../ide/media/vside_uppercasesearch.png":::

## Settings

You can select the gear icon :::image type="icon" source="media/gotoall_gear.png"::: to change how this feature works:

Setting | Description
------- | ---
Use preview tab | Display the selected item immediately in the IDE's preview tab
Show details | Display project, file, line, and summary information from documentation comments in the window
Center window | Move the window to the center of the top of the code editor, instead of the top-right corner

## Related content

- [Navigate code](../ide/navigating-code.md)
- [Go To Line dialog box](../ide/reference/go-to-line.md)
- [Go To Definition and Peek Definition](../ide/go-to-and-peek-definition.md)
