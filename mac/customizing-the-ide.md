---
title: Customizing the IDE
description: Visual Studio for Mac can be customized in different ways, allowing users to develop apps in an environment that meets both their efficiency and aesthetic needs. This article explores the different ways Visual Studio for Mac can be adapted to suit your needs.
author: jmatthiesen
ms.author: jomatthi
manager: dominicn
ms.date: 03/03/2022
ms.custom: devdivchpfy22
ms.topic: how-to
---
# Customizing the IDE

 [!INCLUDE [Visual Studio for Mac](~/includes/applies-to-version/vs-mac-only.md)]

Visual Studio for Mac can be customized, allowing users to develop apps in an environment that meets their needs for both efficiency and aesthetics. This article explores the variety of ways that Visual Studio for Mac can be adapted to suit your needs.

## Dark theme

![Dark Theme View](media/customizing-the-ide-image7a.png)

You can switch themes in Visual Studio for Mac by browsing to **Visual Studio > Preferences > Environment > Visual Style** and selecting your desired theme from the **User Interface Theme** drop-down, as illustrated in the following image:

![Dark Theme Selection](media/customizing-the-ide-image7b.png)

## Localization

Visual Studio for Mac is localized in the following 14 languages, enabling it to be accessible to more developers:

* Chinese - China
* Chinese - Taiwan
* Czech
* French
* German
* English
* Italian
* Japanese
* Korean
* Polish
* Portuguese - Brazil
* Russian
* Spanish
* Turkish

To change the language displayed by Visual Studio for Mac, browse to  **Visual Studio > Preferences > Environment > Visual Style** and select your desired language from the **User Interface Language** drop-down, as illustrated in the following image:

![Language Selection](media/customizing-the-ide-image11a.png)

## Author information

The author information panel lets you add relevant information about yourself such as your name, email address, the copyright owner for your work, your company, and trademark:

![Edit Author Information section](media/customizing-the-ide-image9a.png)

This information is used to populate standard file headers, such as a license, that you might add to new files:

![Standard Header options](media/customizing-the-ide-image8a.png)

Populated **Name** and **Email** fields will be used in any commit that is made through Version Control in Visual Studio for Mac. If you haven't populated these fields, Visual Studio for Mac will prompt you to do so when you try to use Version Control.

## Key bindings

Key bindings, or keyboard shortcuts, allow you to adapt your development environment so that you can move more efficiently throughout Visual Studio for Mac. It provides familiar key bindings for many popular IDEs, such as Visual Studio (on Windows), ReSharper, Visual Studio Code, and Xcode.

Key bindings can be set by browsing to **Visual Studio > Preferences > Environment > Key Bindings**, as illustrated by the following image:

![Set Key bindings](media/customizing-the-ide-image10a.png)

From here you can search for key binding combinations, view conflicting bindings, add new bindings, and edit the existing bindings.

These bindings can also be set during the initial setup of Visual Studio for Mac, via the **Keyboard Selection** screen:

![Set Key bindings, first run](media/ide-tour-2019-keyboard-shortcut.png)

## Workspace layout

Visual Studio for Mac's workspace consists of a main document area (normally the editor, designer surface, or options file), surrounded by complementary *tool windows* that contain useful information for accessing and managing application files, testing, and debugging.

 ![Workspace layout](media/customizing-the-ide-image1a.png)

### Viewing and arranging tool windows

When you open any new solution or file in Visual Studio for Mac, you should notice some *tool windows* in the workspace, including the Solution Window, Document Outline, and Errors:

![Tool Window](media/customizing-the-ide-image2a.png)

Visual Studio for Mac provides tool windows containing additional information, tools, and navigation aids, all of which can be accessed by browsing the **View** menu item and selecting a tool window to add it:

![Select new tool window](media/customizing-the-ide-image3a.png)

Tool Windows may also be opened automatically by different commands, such as the **Find in Files** (Shift + Cmd + F) command, which opens a detached window of search results.

Tool Windows can be moved and arranged throughout your workflow in whatever way is most useful to you. For example, they can be docked on any side of the document editor, next to another tool window, above or below another window, or as a set of tabbed windows enabling you to quickly switch between them.

For frequently used tool windows, you can also completely detach them from the Visual Studio for Mac window and into their own new window.

Tool Windows can be pinned and closed by the controls in the top-right corner of each window:

:::image type="content" source="media/customizing-the-ide-image5a.png" alt-text="Using controls to pin or close tool windows":::

Pinned windows are docked to the sides of the workspace and remain open for quicker access when you need them. Unpinned windows are docked, but not shown until you hover over the tab for the window with a mouse or focus with the keyboard. They can be hidden when the mouse and keyboard focus leaves them.

### Organizing layouts

The tool windows that are displayed at any time are dependent on the current context. For example, when using the visual designer, the toolbox and property grid windows are most important. When debugging, it's useful to have the debugger windows for viewing the stack and locals.

The state of the open tool windows is represented by a *layout*. You can switch the layouts manually through the View menu, as illustrated in the following image. It's also switched automatically when you carry out an action, such as debugging, or opening a Storyboard:

![Selecting new Layouts](media/customizing-the-ide-image6b.png)

It's possible to create a new layout by using the **View > Layout > Save Current Layout...** menu item. This command will add your current layout to the menu so that you can select it at any time:

![Save Current Layout](media/customizing-the-ide-image6a.png)

### Side-by-side editing support

Visual Studio for Mac allows you to open text editors side by side, or to have an editor as a detached floating window.

Two-column mode can be enabled through the View menu item by selecting **View > Editor Columns > 2 columns**, or by dragging an editor tab to one of the edges of the editor area:

![Two column side-by-side mode](media/customizing-the-ide-sbs.png)

Editor tabs can be dragged out of the document area to create a floating editor window. This floating window also supports side-by-side editors, and can contain several editor tabs:

![Create new window](media/customizing-the-ide-sbs1.png)

![Two columns side by side with additional tabs](media/customizing-the-ide-sbs2.png)

To revert to a single open editor, select **View > Editor Columns > 1 column**.

## Related Video

> [![here](/shows/Visual-Studio-Toolbox/Visual-Studio-for-Mac-Customize-the-Look-and-Feel/player)]

## See also

- [Personalize the Visual Studio IDE (on Windows)](/visualstudio/ide/personalizing-the-visual-studio-ide)
