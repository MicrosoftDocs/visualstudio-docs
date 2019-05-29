---
title: "Extending Menus and Commands | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "menus, common tasks"
  - "VSPackages, menu tasks"
  - ".vsct files, common menu tasks"
ms.assetid: 7b2be4b9-e3fe-4412-874f-ae72ebc84c4b
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Extend menus and commands
Commands are the way you add actions and processes to Visual Studio. In most cases commands are displayed on menus or toolbars. The VSPackage project template shows how to implement a very basic command. For a slightly longer but still basic implementation, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md).

 For more information about Visual Studio commands, menus and toolbars, see [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md).

 Commands, menus, and toolbars are defined in the *.vsct* file that is part of VSPackage projects. You can find information about the Visual Studio IDE and the *.vsct* file in [How VSPackages add user interface elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md).

 The following topics explain how to add different kinds of commands, menus, and toolbars.

## In this section
- [Add a menu to the Visual Studio menu bar](../extensibility/adding-a-menu-to-the-visual-studio-menu-bar.md)
 Explains how to add a menu to the top Visual Studio menu bar.

- [Bind keyboard shortcuts to menu items](../extensibility/binding-keyboard-shortcuts-to-menu-items.md)
 Explains how to add a keyboard shortcut (such as CTRL + 3) to a menu item.

- [Add a submenu to a menu](../extensibility/adding-a-submenu-to-a-menu.md)
 Explains how to add a submenu to the top menu.

- [Add a most recently used list to a submenu](../extensibility/adding-a-most-recently-used-list-to-a-submenu.md)
 Explains how to add a Most Recently Used list.

- [Create reusable groups of buttons](../extensibility/creating-reusable-groups-of-buttons.md)
 Describes how to group command items so that they can be included on multiple menus.

- [Add icons to menu commands](../extensibility/adding-icons-to-menu-commands.md)
 Describes how to add an icon to a command on both a toolbar and a menu.

- [Change the text of a menu command](../extensibility/changing-the-text-of-a-menu-command.md)
 Describes the use of the `TextChanges` flag to enable a menu item to be changed dynamically.

- [Change the appearance of a command](../extensibility/changing-the-appearance-of-a-command.md)
 Describes how to dynamically enable or disable a command.

- [Update the user interface](../extensibility/updating-the-user-interface.md)
 Describes how to force an update of the user interface to reflect recent changes.

- [Localize menu commands](../extensibility/localizing-menu-commands.md)
 Explains how to localize menu commands.