---
title: Options dialog
description: Learn about the Options dialog box, its layout, and how Visual Studios applies the options you select to your projects and solutions.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- vs.toolsoptionspages
helpviewer_keywords:
- Tools Options settings
- Options dialog box
- Options dialog box, development environment
- tools [Visual Studio], customizing
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options dialog box (Visual Studio)

The **Options** dialog box enables you to configure the integrated development environment (IDE) to your needs. For example, you can establish a default save location for your projects, alter the default appearance and behavior of windows, and create shortcuts for commonly used commands. There are also options specific to your development language and platform. You can access **Options** from the **Tools** menu.

## Layout of the Options dialog box

The **Options** dialog box is divided into two parts: a navigation pane on the left and a display area on the right. The tree control in the navigation pane includes folder nodes, such as Environment, Text Editor, Projects and Solutions, and Source Control. Expand any folder node to list the pages of options that it contains. When you select the node for a particular page, its options appear in the display area.

Options for an IDE feature do not appear in the navigation pane until the feature is loaded into memory. Therefore, the same options might not be displayed as you begin a new session that were displayed as you ended the last. When you create a project or run a command that uses a particular application, nodes for relevant options are added to the Options dialog box. These added options will then remain available as long as the IDE feature remains in memory.

> [!NOTE]
> Some settings collections scope the number of pages that appear in the navigation pane of the Options dialog box.

## How options are applied

Clicking OK in the **Options** dialog box saves all settings on all pages. Clicking Cancel on any page cancels all change requests, including any just made on other **Options** pages. Some changes to option settings, such as those made on [Fonts and Colors, Environment, Options Dialog Box](../../ide/reference/fonts-and-colors-environment-options-dialog-box.md), will only take effect after you close and reopen Visual Studio.

## See also

- [Customizing the Editor](../how-to-change-text-case-in-the-editor.md)
- [Git settings and preferences](../../version-control/git-settings.md)
