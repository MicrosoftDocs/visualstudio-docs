---
title: "Command Placement Guidelines | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "commands, small command sets"
  - "small command sets"
  - "command sets"
ms.assetid: 63b3478e-e08a-420b-a0ec-76767e0cb289
caps.latest.revision: 29
ms.author: gregvanl
manager: jillfra
---
# Command Placement Guidelines
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Best practices for positioning commands in the Visual Studio integrated development environment (IDE) vary depending on the size of the command set. Commands are defined and positioned according to the information in .vsct files.  
  
## Best Practices for All Command Sets  
 For every set of commands, follow these guidelines:  
  
- Prepare a chart of the command structure in advance. Identify the commands, combo boxes, command groups, and shortcut menus that will be used in more than one location.  
  
- Commands that appear in the same group should be related.  
  
- Groups that contain just one command are acceptable.  
  
- Packages should not add lots of commands to existing Visual Studio menus. Instead, they should create menus or submenus to host the new commands.  
  
- When you put a command on an existing menu, name the command so that its purpose is clear and it will not be confused with existing commands.  
  
## Best Practices for Small Command Sets  
 If you are developing a VSPackage that has just a few commands, also follow these guidelines:  
  
- When possible, use the [Parent Element](../../extensibility/parent-element.md) of a command, combo box, group, or child menu to put it in the appropriate group.  
  
- Assign these groups to menus displayed by the VSPackage.  
  
- The parent of a child menu or a command must be a [Group Element](../../extensibility/group-element.md). Assign commands and child menus to groups, and then assign the groups to parent menus.  
  
- You can put a command in additional groups by adding a [CommandPlacements Element](../../extensibility/commandplacements-element.md) section after the definition of the command, and then adding to the `CommandPlacements Element` a [CommandPlacement Element](../../extensibility/commandplacement-element.md) for each additional group.  
  
## Best Practices for Large Command Sets  
 If your VSPackage will have many commands that will appear in multiple contexts, also follow these guidelines:  
  
- Make menus, groups, and commands self-parenting. That is, do not assign a `Parent Element` in the definition of the item.  
  
- Use `CommandPlacement Element` entries in the `CommandPlacements Element` section to put menus, groups, and commands in their parent menus and groups.  
  
- In the `CommandPlacements` section, the entries that populate a given menu or group should be adjacent to one another. This aids readability and makes the `Priority` rankings easier to determine.  
  
## See Also  
 [How VSPackages Add User Interface Elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)   
 [Visual Studio Command Table (.Vsct) Files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
