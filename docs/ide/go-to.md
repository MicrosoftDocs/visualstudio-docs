---
title: "Go To | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
    - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 509b2107-23d1-4fb3-987f-ab99ef45b72e
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

# Go To
There are many ways to easily navigate your code inside of the Visual Studio IDE, both from the keyboard and the mouse.

<!-- VERSIONLESS -->
## Go To All
This feature exists in Visual Studio 2017 and later.  It allows you to navigate through your code to find the specific bits you are looking for.  You can search for a specific line, type, symbol, file, and more from a simple, unified interface.

### How to use
* **Keyboard**
  * Press **Ctrl+,** or **Ctrl+T**.  (Note that your keyboard shortcut may be different based on which profile you've selected.)
* **Mouse**
  * Select **Edit > Go To > Go To All**.

This will display a small window at the top right of your IDE, by default.

![Go To All](media/gotoall.png)

From here, there are several ways to proceed:
* Enter text without a prefix to search using the [filter icons](#filtered-searches) selected below the text box.
* Enter a [prefix](#filtered-searches) followed by the text to search.
* Enter a question mark (?) to get additional help.
  ![Go To All Help](media/gotoall_help.png)

### Filtered Searches
To narrow your search to a specific type, you can either use a prefix when typing, or use the icons below the search window as shown below.

Prefix | Icon | Shortcut | Description
:----: | ---- | -------- | ---
#      | ![Symbol Icon](media/gotoall_symbolicon.png) | Ctrl+1, Ctrl+S | Find matching symbols
f      | ![File Icon](media/gotoall_fileicon.png)     | Ctrl+1, Ctrl+F | Find matching file names
m      | ![Member Icon](media/gotoall_membericon.png) | Ctrl+1, Ctrl+M | Find matching members
t      | ![Type Icon](media/gotoall_typeicon.png)     | Ctrl+1, Ctrl+T | Find matching types
:      | ![Line Icon](media/gotoall_lineicon.png)     | Ctrl+G         | Go to the line number entered

### Search Locations
To narrow your search to specific locations, use the two document icons.

Icon | Description
---- | ---
![Current Document](media/gotoall_currentdocument.png) | Search current document only
![External Documents](media/gotoall_external.png) | Search external documents in addition to those located in the project/solution

### Settings
Clicking the gear icon ![Gear Icon](media/gotoall_gear.png) at the lower-right lets you change how this feature works.

Setting | Description
------- | ---
Use preview tab | Display the selected item immediately in the IDE's preview tab
Show details    | Display project, file, line and summary information from documentation comments in the window
Center window   | Move this window to the center of the IDE instead of the top-right
<!-- END VERSIONLESS -->

## Go To Definition
Navigate to the source of a type and open the result in a new tab:

Input        | Function 
------------ | ---
**Keyboard** | Place your text cursor somewhere inside the type name, and press **F12**
**Mouse**    | Right-click on the type name and select **Go To Definition**

## Peek Definition
Preview the definition of a type in a popup window instead of a new tab:

Input        | Function 
------------ | ---
**Keyboard** | Place your text cursor somewhere inside the type name, and press **Alt+F12**
**Mouse**    | Right-click on the type name and select **Peek Definition**

If you peek another definition from the popup window, you will start a breadcrumb path which you can navigate using the circles and arrows which appear above the popup.  For more information, see [How to: View and Edit Code by Using Peek Definition (Alt+F12)](how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md).

## Go To Implementation
Navigate from a base class or type to its implementations.  If there are multiple implementations, you will see them listed in the **Find Symbol Results** window:

Input        | Function 
------------ | ---
**Keyboard** | Place your text cursor somewhere inside the type name, and press **Ctrl+F12**
**Mouse**    | Right-click on the type name and select **Go To Implementation**

## Find All References
Find all places where a method/property/variable is being used.  You can use this to verify dead code and check possible side-effects of a large refactoring.  Press **F8** to jump between results.

Input        | Function 
------------ | ---
**Keyboard** | Place your text cursor somewhere inside the type name, and press **Ctrl+K, R**
**Mouse**    | Right-click on the type name and select **Find All References**

## Navigating Results
When using the navigation features of Visual Studio, you can navigate forward and backward through the stack:

Input        | Function 
------------ | ---
**Ctrl+-**          | Navigate backward through the stack
**Ctrl+Shift+-**    | Navigate forward through the stack

You can also use the **View > Navigate Backward** and **View > Navigate Forward** menu items.