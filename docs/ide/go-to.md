---
title: "Find code using Go To commands | Microsoft Docs"
ms.custom: ""
ms.date: "09/26/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 509b2107-23d1-4fb3-987f-ab99ef45b72e
helpviewer_keywords:
  - "code editor, go to"
  - "code editor, go to line"
  - "go to line"
  - "go to"
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---
# Find code using Go To commands  
Visual Studio's **Go To** commands perform a focused search of your code to help you quickly find specified items in code files, file paths and code symbols. You can search for a specific line, type, symbol, file, and member from a simple, unified interface. This feature exists in Visual Studio 2017 and later.  

### How to use it  
* **Keyboard** - Press **Ctrl + ,** or **Ctrl + T**.  

* **Mouse** - Select **Edit**, **Go To**, **Go To All**.  

This will display a small window at the top right of your code editor, by default.  

![Go To All](media/gotoall.png)

From here, there are several ways to proceed:  

* Enter text without a prefix to search all code elements.  

* [Filter](#filtered-searches) the results to a specific type of code element.  

* Specify a [search location](#search-locations) to narrow the search to a specific document(s).

* Enter a question mark (?) to get additional help.  

  ![Go To All Help](media/gotoall_help.png)

### Filtered Searches  
To narrow your search to a specific type of code element, you can either specify a prefix in the search box or select one of the five filter icons:  

Prefix | Icon | Shortcut | Description
:----: | ---- | -------- | ---
#      | ![Symbol Icon](media/gotoall_symbolicon.png) | Ctrl+1, Ctrl+S | Find matching symbols
f      | ![File Icon](media/gotoall_fileicon.png)     | Ctrl+1, Ctrl+F | Find matching file names
m      | ![Member Icon](media/gotoall_membericon.png) | Ctrl+1, Ctrl+M | Find matching members
t      | ![Type Icon](media/gotoall_typeicon.png)     | Ctrl+1, Ctrl+T | Find matching types
:      | ![Line Icon](media/gotoall_lineicon.png)     | Ctrl+G         | Go to the line number entered

### Search Locations  
To narrow your search to a specific location, select one of the two document icons:  

Icon | Description
---- | ---
![Current Document](media/gotoall_currentdocument.png) | Search current document only
![External Documents](media/gotoall_external.png) | Search external documents in addition to those located in the project/solution

### Settings  
Selecting the gear icon ![Gear Icon](media/gotoall_gear.png) lets you change how this feature works:  

Setting | Description
------- | ---
Use preview tab | Display the selected item immediately in the IDE's preview tab
Show details    | Display project, file, line, and summary information from documentation comments in the window
Center window   | Move this window to the top-center of the code editor, instead of the top-right   

## See Also  
[Navigating Code](../ide/navigating-code.md)  
[Go To Definition and Peek Definition](../ide/go-to-and-peek-definition.md)
[How to: View and Edit Code by Using Peek Definition (Alt+F12)](how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md)  