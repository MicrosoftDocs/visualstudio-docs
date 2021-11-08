---
title: How to move around in the IDE
description: Learn how to move around in the Visual Studio IDE from window to window and file to file in several different ways.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- environments [Visual Studio], navigation
- documents [Visual Studio], navigating
- IDE, navigation
- navigation [Visual Studio]
- files [Visual Studio], navigating between
- windows [Visual Studio], navigating
- Window.NextDocumentWindowNav
- IDE navigator
ms.assetid: 6c36b6eb-c93f-496b-af08-4199f7afd8bd
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# How to: Move around in the Visual Studio IDE

The integrated development environment (IDE) has been designed to allow you to move from window to window and file to file in several different ways, depending on your preference or project requirements. You can choose to cycle through open files in the editor, or cycle through all active tool windows in the IDE. You also can switch directly to any file open in the editor, regardless of the order in which it was last accessed. These features can help increase your productivity when working in the IDE.

> [!NOTE]
> The options available in dialog boxes, and the names and locations of menu commands you see, might differ from what is described in this article, depending on your active settings or edition. This article was written with **General** settings in mind. To change your settings, for example to **General** or **Visual C++** settings, choose **Tools** > **Import and Export Settings**, and then choose **Reset all settings**.

## Keyboard shortcuts

Almost every menu command in Visual Studio has a keyboard shortcut. You can also create your own custom shortcuts. For more information, see [Identify and customize keyboard shortcuts](../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md).

## Navigate among files in the editor

You can use several methods to move through the files open in the editor. You can move among files based on the order in which you access them, use the IDE Navigator to quickly find any file currently open, or pin favorite files to the tab well so that they are always visible.

Navigate backward and navigate forward cycle through the open files in the editor based on the order in which they were accessed, much like back and forward do for your viewing history in Microsoft Internet Explorer.

### To move through open files in order of use

- To activate open documents in the order they were most recently touched, press **Ctrl**+**-** (hyphen).

- To activate open documents in the reverse order, press **Ctrl**+**Shift**+**-** (hyphen).

    > [!NOTE]
    > **Navigate Backward** and **Navigate Forward** also can be found on the **View** menu.

You also can switch to a specific file open in the editor, regardless of when you last accessed the file, using the **IDE Navigator**, the **Active Files** list in the editor, or the **Windows** dialog box.

The **IDE Navigator** works much like the Windows application switcher. It is not available from menus and can be accessed only using shortcut keys. You can use either of two commands to access the **IDE Navigator** (shown below) to cycle through files, depending on the order in which you want to cycle through.

![Visual Studio IDE Navigator](../ide/media/vs2015_ide_navigator.png)

`Window.PreviousDocumentWindowNav` allows you to move to the file most recently accessed and `Window.NextDocumentWindowNav` allows you to move in the reverse order. **General Development Settings** assigns **Shift**+**Alt**+**F7** to `Window.PreviousDocumentWindowNav` and **Alt**+**F7** to `Window.NextDocumentWindowNav`.

> [!NOTE]
> If the settings combination you are using does not already have a shortcut key combination assigned to this command, you can assign your own custom command using the **Keyboard** page of the **Options** dialog box. For more information, see [Identify and customize keyboard shortcuts](../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md).

### To switch to specific files in the editor

- Press **Ctrl**+**Tab** to display the **IDE Navigator**. Hold down the **Ctrl** key and press **Tab** repeatedly until you select the file you intend to switch to.

    > [!TIP]
    > To reverse the order in which you go through the **Active Files** list, hold down the **Ctrl**+**Shift** keys and press **Tab**.

    \- or -

- In the upper right corner of the editor, choose the **Active Files** button, and then select a file from the list to switch to.

    \- or -

- On the menu bar, choose **Window** > **Windows**.

- In the list, select the file you want to view and then choose **Activate**.

## Navigate among tool windows in the IDE

The **IDE Navigator** also lets you cycle through the tool windows you have open in the IDE. You can use either of two commands to access the **IDE Navigator** to cycle through tool windows, depending on the order in which you want to cycle through. `Window.PreviousToolWindowNav` allows you to move to the file most recently accessed and `Window.NextToolWindowNav` allows you to move in the reverse order. **General Development Settings** assigns **Shift**+**Alt**+**F7** to `Window.PreviousDocumentWindowNav` and **Alt**+**F7** to `Window.NextDocumentWindowNav`.

> [!NOTE]
> If the settings combination you are using does not already have a shortcut key combination assigned to this command, you can assign your own custom command using the **Keyboard** page of the **Options** dialog box. For more information, see [Identify and customize keyboard shortcuts](../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md).

### To switch to a specific tool window in the IDE

- Press **Alt**+**F7** to display the **IDE Navigator**. Hold down the **Alt** key and press **F7** repeatedly until you select the window you intend to switch to.

    > [!TIP]
    > To reverse the order in which you go through the **Active Tool Windows** list, hold down the **Shift**+**Alt** keys and press **F7**.

## See also

- [Customize window layouts](../ide/customizing-window-layouts-in-visual-studio.md)
- [Default keyboard shortcuts](../ide/default-keyboard-shortcuts-in-visual-studio.md)
