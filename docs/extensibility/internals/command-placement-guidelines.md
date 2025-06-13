---
title: Command Placement Guidelines
description: Learn the guidelines and best practices for positioning commands in the Visual Studio integrated development environment (IDE). 
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- commands, small command sets
- small command sets
- command sets
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Command placement guidelines

Best practices for positioning commands in the Visual Studio integrated development environment (IDE) vary depending on the size of the command set. Commands are defined and positioned according to the information in *.vsct* files.

## Best practices for all command sets
 For every set of commands, follow these guidelines:

- Prepare a chart of the command structure in advance. Identify the commands, combo boxes, command groups, and shortcut menus that will be used in more than one location.

- Commands that appear in the same group should be related.

- Groups that contain just one command are acceptable.

- Packages should not add lots of commands to existing Visual Studio menus. Instead, they should create menus or submenus to host the new commands.

- When you put a command on an existing menu, name the command so that its purpose is clear and it will not be confused with existing commands.

## Best practices for small command sets
 If you are developing a VSPackage that has just a few commands, also follow these guidelines:

- When possible, use the [Parent](../../extensibility/parent-element.md) element of a command, combo box, group, or child menu to put it in the appropriate group.

- Assign these groups to menus displayed by the VSPackage.

- The parent of a child menu or a command must be a [Group](../../extensibility/group-element.md) element. Assign commands and child menus to groups, and then assign the groups to parent menus.

- You can put a command in additional groups by adding a [CommandPlacements](../../extensibility/commandplacements-element.md) element section after the definition of the command, and then adding to the `CommandPlacements` element a [CommandPlacement](../../extensibility/commandplacement-element.md) element for each additional group.

## Best practices for large command sets
 If your VSPackage will have many commands that will appear in multiple contexts, also follow these guidelines:

- Make menus, groups, and commands self-parenting. That is, do not assign a `Parent` element in the definition of the item.

- Use `CommandPlacement` element entries in the `CommandPlacements` element section to put menus, groups, and commands in their parent menus and groups.

- In the `CommandPlacements` element section, the entries that populate a given menu or group should be adjacent to one another. This aids readability and makes the `Priority` rankings easier to determine.

## Related content
- [How VSPackages add user interface elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)
- [Visual Studio command table (.vsct) files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
