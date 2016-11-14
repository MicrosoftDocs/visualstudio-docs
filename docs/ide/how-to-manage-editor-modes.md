---
title: "How to: Manage Editor Modes | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "word wrap"
  - "views, virtual space"
  - "line numbers, displaying"
  - "virtual space mode"
  - "line numbers"
  - "Code Editor, view and display options"
  - "full screen mode"
  - "Code Editor, modes"
  - "views, splitting"
  - "views, word wrapping"
  - "fonts and size"
  - "views, creating new windows"
  - "views, line numbers"
  - "views, changing mode"
  - "views, outlining"
ms.assetid: 1fb48027-d870-439f-8b72-4a0321390748
caps.latest.revision: 20
author: "kempb"
ms.author: "kempb"
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
# How to: Manage Editor Modes
You can display the Visual Studio Code Editor in various display modes.  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Enabling Full Screen mode  
 You can choose to hide all tool windows and view only document windows by enabling **Full Screen** mode.  
  
#### To enable Full Screen mode  
  
-   Press ALT+SHIFT+ENTER to enter or exit **Full Screen** mode.  
  
     -- or --  
  
-   Issue the command `View.Fullscreen` in the **Command** window.  
  
## Enabling Virtual Space mode  
 In **Virtual Space** mode, spaces are inserted at the end of each line of code. Select this option to position comments at a consistent point next to your code.  
  
#### To enable Virtual Space mode  
  
1.  Select **Options** from the **Tools** menu.  
  
2.  Expand the **Text Editor** folder, and choose **All Languages** to set this option globally, or choose a specific language folder. (For example, to turn on line numbers only in Visual Basic, choose the Basic, Text Editor options.)  
  
3.  Select **General** options, and under **Settings**, select **Enable Virtual Space**.  
  
    > [!NOTE]
    >  **Virtual Space** is enabled in **Column Selection** mode. When **Virtual Space** mode is not enabled, the insertion point moves from the end of one line directly to the first character of the next.  
  
## See Also  
 [Customizing the Editor](../ide/customizing-the-editor.md)   
 [How to: Arrange and Dock Windows](../misc/how-to-arrange-and-dock-windows.md)   
 [Fonts and Colors, Environment, Options Dialog Box](../ide/reference/fonts-and-colors-environment-options-dialog-box.md)