---
title: "How to: Use the Finder Tool | Microsoft Docs"
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
  - "Window Finder Tool"
ms.assetid: 5841926b-08c3-4e43-88bd-4223d04f9aef
caps.latest.revision: 6
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
# How to: Use the Finder Tool
You can use the Finder Tool in the **Find Window** dialog box to display window properties or messages. The Finder Tool can also locate disabled child windows, and discern which window to highlight if disabled child windows overlap.  
  
 ![Spy&#43;&#43; Find Window Dialog Box](../debugger/media/icon_spy--_find.png "Icon_Spy++_Find")  
Finder Tool in the Find Window dialog box  
  
 The figure above shows the Find Window dialog box after step 3 below.  
  
### To display window properties or messages  
  
1.  Arrange your windows so that both Spy++ and the target window are visible.  
  
2.  From the **Spy** menu, choose **Find Window**.  
  
     The [Find Window Dialog Box](../debugger/find-window-dialog-box.md) opens.  
  
3.  Drag the **Finder Tool** over the target window.  
  
     As you drag the tool, the **Find Window** dialog box displays details on the selected window.  
  
     – or –  
  
     If you have the handle of the window you want to examine (for example, copied from the debugger), type it into the **Handle** text box.  
  
    > [!TIP]
    >  To reduce screen clutter, select the **Hide Spy** option. This option conceals the main Spy++ window, leaving only the **Find Window** dialog box visible on top of your other applications. The Spy++ main window is restored when you click **OK** or **Cancel**, or when you clear the **Hide Spy++** option.  
  
4.  Under **Show**, select either **Properties** or **Messages**.  
  
5.  Press **OK**.  
  
     If you selected **Properties**, the [Window Properties Dialog Box](../debugger/window-properties-dialog-box.md) opens. If you selected **Messages**, a [Messages View](../debugger/messages-view.md) window opens.  
  
## See Also  
 [Spy++ Views](../debugger/spy-increment-views.md)   
 [Using Spy++](../debugger/using-spy-increment.md)   
 [Spy++ Reference](../debugger/spy-increment-reference.md)