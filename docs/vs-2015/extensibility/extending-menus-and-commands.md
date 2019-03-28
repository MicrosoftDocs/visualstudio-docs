---
title: "Extending Menus and Commands | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "menus, common tasks"
  - "VSPackages, menu tasks"
  - ".vsct files, common menu tasks"
ms.assetid: 7b2be4b9-e3fe-4412-874f-ae72ebc84c4b
caps.latest.revision: 50
ms.author: gregvanl
manager: jillfra
---
# Extending Menus and Commands
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Commands are the way you add actions and processes to Visual Studio. In most cases commands are displayed on menus or toolbars. The VSPackage project template shows how to implement a very basic command. For a slightly longer but still basic implementation, see [Creating an Extension with a Menu Command](../extensibility/creating-an-extension-with-a-menu-command.md).  
  
 For more information about Visual Studio commands, menus and toolbars, see [Commands, Menus, and Toolbars](../extensibility/internals/commands-menus-and-toolbars.md).  
  
 Commands, menus, and toolbars are defined in the .vsct file that is part of VSPackage projects. You can find information about the Visual Studio IDE and the .vsct file in [How VSPackages Add User Interface Elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md).  
  
 The following topics explain how to add different kinds of commands, menus, and toolbars.  
  
## In This Section  
 [Adding a Menu to the Visual Studio Menu Bar](../extensibility/adding-a-menu-to-the-visual-studio-menu-bar.md)  
 Explains how to add a menu to the top Visual Studio menu bar.  
  
 [Binding Keyboard Shortcuts to Menu Items](../extensibility/binding-keyboard-shortcuts-to-menu-items.md)  
 Explains how to add a keyboard shortcut (such as CTRL + 3) to a menu item.  
  
 [Adding a Submenu to a Menu](../extensibility/adding-a-submenu-to-a-menu.md)  
 Explains how to add a submenu to the top menu.  
  
 [Adding a Most Recently Used List to a Submenu](../extensibility/adding-a-most-recently-used-list-to-a-submenu.md)  
 Explains how to add a Most Recently Used list.  
  
 [Creating Reusable Groups of Buttons](../extensibility/creating-reusable-groups-of-buttons.md)  
 Describes how to group command items so that they can be included on multiple menus.  
  
 [Adding Icons to Menu Commands](../extensibility/adding-icons-to-menu-commands.md)  
 Describes how to add an icon to a command on both a toolbar and a menu.  
  
 [Changing the Text of a Menu Command](../extensibility/changing-the-text-of-a-menu-command.md)  
 Describes the use of the `TextChanges` flag to enable a menu item to be changed dynamically.  
  
 [Changing the Appearance of a Command](../extensibility/changing-the-appearance-of-a-command.md)  
 Describes how to dynamically enable or disable a command.  
  
 [Updating the User Interface](../extensibility/updating-the-user-interface.md)  
 Describes how to force an update of the user interface to reflect recent changes.  
  
 [Localizing Menu Commands](../extensibility/localizing-menu-commands.md)  
 Explains how to localize menu commands.  
  
## Related Sections
