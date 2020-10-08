---
title: "How to: Move Around in the IDE | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "environments [Visual Studio], navigation"
  - "documents [Visual Studio], navigating"
  - "IDE, navigation"
  - "navigation [Visual Studio]"
  - "files [Visual Studio], navigating between"
  - "windows [Visual Studio], navigating"
  - "Window.NextDocumentWindowNav"
  - "IDE navigator"
ms.assetid: 6c36b6eb-c93f-496b-af08-4199f7afd8bd
caps.latest.revision: 33
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Move Around in the Visual Studio IDE
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The integrated development environment (IDE) has been designed to allow you to move from window to window and file to file in several different ways, depending on your preference or project requirements. You can choose to cycle through open files in the editor, or cycle through all active tool windows in the IDE. You also can switch directly to any file open in the editor, regardless of the order in which it was last accessed. These features can help increase your productivity when working in the IDE.

> [!NOTE]
> The options available in dialog boxes, and the names and locations of menu commands you see, might differ from what is described in Help depending on your active settings or edition. This Help page was written with **General Development Settings** in mind. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

## Keyboard Shortcuts
 Almost every menu command in Visual Studio has a keyboard shortcut. You can also create your own custom shortcuts. For more information, see [Identifying and Customizing Keyboard Shortcuts](../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md).

## Navigating Among Files in the Editor
 You can use several methods to move through the files open in the editor. You can move among files based on the order in which you access them, use the IDE Navigator to quickly find any file currently open, or pin favorite files to the tab well so that they are always visible.

 Navigate Backward and Navigate Forward cycle through the open files in the editor based on the order in which they were accessed, much like Back and Forward do for your viewing history in Microsoft Internet Explorer.

#### To move through open files in order of use

- To activate open documents in the order they were most recently touched, press CTRL + MINUS SIGN.

- To activate open documents in the reverse order, press CTRL + SHIFT + MINUS SIGN.

  > [!NOTE]
  > **Navigate Backward** and **Navigate Forward** also can be found on the **View** menu.

  You also can switch to a specific file open in the editor, regardless of when you last accessed the file, using the **IDE Navigator**, the **Active Files** list in the editor, or the **Windows** dialog box.

  The **IDE Navigator** works much like the Windows application switcher. It is not available from menus and can be accessed only using shortcut keys. You can use either of two commands to access the **IDE Navigator** (shown below) to cycle through files, depending on the order in which you want to cycle through.

  ![Visual Studio IDE Navigator](../ide/media/vs2015-ide-navigator.png "VS2015_IDE_Navigator")

  `Window.PreviousDocumentWindowNav` allows you to move to the file most recently accessed and `Window.NextDocumentWindowNav` allows you to move in the reverse order. General Development Settings assigns CTRL + SHIFT + TAB to `Window.PreviousDocumentWindowNav` and CTRL + TAB to `Window.NextDocumentWindowNav`.

> [!NOTE]
> If the settings combination you are using does not already have a shortcut key combination assigned to this command, you can assign your own custom command using the **Keyboard** page of the **Options** dialog box. For more information, see [Identifying and Customizing Keyboard Shortcuts](../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md).

#### To switch to specific files in the editor

- Press CTRL + TAB to display the **IDE Navigator**. Hold down the CTRL key and press TAB repeatedly until you select the file you intend to switch to.

    > [!TIP]
    > To reverse the order in which you go through the **Active Files** list, hold down the CTRL + SHIFT keys and press TAB.

     \- or -

- In the upper right corner of the editor, choose the **Active Files** button, and then select a file from the list to switch to.

     \- or -

- On the menu bar, choose **Window**, **Windows**.

- In the list, select the file you want to view and then choose **Activate**.

## Navigating Among Tool Windows in the IDE
 The **IDE Navigator** also lets you cycle through the tool windows you have open in the IDE. You can use either of two commands to access the **IDE Navigator** to cycle through tool windows, depending on the order in which you want to cycle through. `Window.PreviousToolWindowNav` allows you to move to the file most recently accessed and `Window.NextToolWindowNav` allows you to move in the reverse order. General Development Settings assigns SHIFT + ALT + F7 to `Window.PreviousDocumentWindowNav` and ALT + F7 to `Window.NextDocumentWindowNav`.

> [!NOTE]
> If the settings combination you are using does not already have a shortcut key combination assigned to this command, you can assign your own custom command using the **Keyboard** page of the **Options** dialog box. For more information, see [Identifying and Customizing Keyboard Shortcuts](../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md).

#### To switch to a specific tool window in the IDE

- Press ALT+F7 to display the **IDE Navigator**. Hold down the ALT key and press F7 repeatedly until you select the window you intend to switch to.

    > [!TIP]
    > To reverse the order in which you go through the **Active Tool Windows** list, hold down the SHIFT + ALT keys and press F7.

## See Also
 [Customizing window layouts](../ide/customizing-window-layouts-in-visual-studio.md)
 [Default Keyboard Shortcuts](../ide/default-keyboard-shortcuts-in-visual-studio.md)
