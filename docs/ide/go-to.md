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
manager: ghogen
ms.workload: 
  - "multiple"
---
# Find code using Go To commands  
Visual Studio's **Go To** commands perform a focused search of your code to help you quickly find specified items. You can go to a specific line, type, symbol, file, and member from a simple, unified interface. This feature exists in Visual Studio 2017 and later.  

### How to use it  

Input        | Function 
------------ | ---
**Keyboard** | Press **Ctrl + t** or **Ctrl + ,**     
**Mouse**    | Select **Edit**, **Go To**, **Go To All**  

This will display a small window at the top right of your code editor, by default.  

![Go To All](media/gotoall.png)

As you type in the text box, the results appear in a drop-down list below the text box. To go to an element, choose it in the list.    

![Navigate To window](../ide/media/vside_navigatetowindow.png "Navigate To window")  

You can also enter a question mark (?) to get additional help.  

  ![Go To All Help](media/gotoall_help.png)

### Filtered Searches  
By default, the specified item is searched for in all solution items. However, you can limit your code search to specific element types by prefacing the search terms with certain characters. You can also quickly change the search filter by choosing buttons on the Go To dialog box toolbar. Buttons that change the type filters are on the left side, and buttons that change the scope of the search are on the right side.  

![Go to members](../ide/media/vside_navigation_toolbar.png)

#### Filter to a specific type of code element  
To narrow your search to a specific type of code element, you can either specify a prefix in the search box, or select one of the five filter icons:  

Prefix | Icon | Shortcut | Description
:----: | ---- | -------- | ---
\#      | ![Symbol Icon](media/gotoall_symbolicon.png) | Ctrl+1, Ctrl+S | Go to the specified symbol
f      | ![File Icon](media/gotoall_fileicon.png)     | Ctrl+1, Ctrl+F | Go to the specified file
m      | ![Member Icon](media/gotoall_membericon.png) | Ctrl+1, Ctrl+M | Go to the specified member
t      | ![Type Icon](media/gotoall_typeicon.png)     | Ctrl+1, Ctrl+T | Go to the specified type
:      | ![Line Icon](media/gotoall_lineicon.png)     | Ctrl+G         | Go to the specified line number

#### Filter to a specific location    
To narrow your search to a specific location, select one of the two document icons:  

Icon | Description
---- | ---
![Current Document](media/gotoall_currentdocument.png) | Search current document only
![External Documents](media/gotoall_external.png) | Search external documents in addition to those located in the project/solution  

### Camel casing  
If you use [camel casing](https://en.wikipedia.org/wiki/Camel_case) in your code, you can find code elements faster by entering only the capital letters of the code element name. For example, if your code has a type called `CredentialViewModel`, you can narrow down the search by choosing the Type filter ("t") and then entering just the capital letters of the name (`CVM`) in the Go To dialog box. This feature can be helpful if your code has long names.  

![Navigate To window - searching with capitals](../ide/media/vside_capitalsearch.png)

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