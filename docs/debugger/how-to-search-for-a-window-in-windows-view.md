---
title: "How to: Search for a Window in Windows View | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "windows, searching in Windows view"
ms.assetid: 30306970-b861-4315-acf8-f86a43d4e73b
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
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
# How to: Search for a Window in Windows View
You can search for a specific window in Windows view by using its handle, caption, class, or a combination of its caption and class as search criteria. You can also specify the initial direction of the search. The fields in the dialog box will show the attributes of the selected window in the window tree.  
  
 Start with the tree expanded to the second level (all windows that are children of the desktop), so that you can identify desktop-level windows by their class name and title. Once you have chosen a desktop-level window, you can expand that level to find a specific child window.  
  
### To search for a window in Windows view  
  
1.  Arrange your windows so that Spy++, the [Windows View](../debugger/windows-view.md) window, and the target window are visible.  
  
2.  From the **Search** menu, choose **Find Window**.  
  
     The [Window Search Dialog Box](../debugger/window-search-dialog-box.md) opens.  
  
    > [!TIP]
    >  To reduce screen clutter, select the **Hide Spy** option. This option conceals the main Spy++ window and leaves only the **Window Search** dialog box visible on top of your other applications. The Spy++ main window is restored when you click **OK** or **Cancel**, or when you clear the **Hide Spy++** option.  
  
3.  Drag the **Finder Tool** over the target window. As you drag the tool, the **Window Search** dialog box displays details on the selected window.  
  
     – or –  
  
     If you know the handle of the window you want (for example, from the debugger), you can type it in the **Handle** box.  
  
     – or –  
  
     If you know the caption and/or class of the window you want, you can type them in the **Caption** and **Class** text boxes, and clear the **Handle** text box.  
  
4.  Choose **Up** or **Down** for the initial direction of the search.  
  
5.  Click **OK**.  
  
     If a matching window is found, it is highlighted in the [Windows View](../debugger/windows-view.md) window.