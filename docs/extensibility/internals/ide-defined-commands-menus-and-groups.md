---
title: IDE-Defined Commands, Menus, and Groups
description: Learn about the menus, commands, and command groups, that are defined in the Visual Studio integrated development environment (IDE).
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- commands, environment-defined
- .vsct files, environment-defined constants
- command groups, environment-defined
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# IDE-Defined Commands, Menus, and Groups

Many menus, commands and command groups are already defined for use by the Visual Studio IDE. These commands are also available for your use when you extend Visual Studio.

## Finding Environment-Defined Commands
 The environment commands are defined in a set of four .vsct files:

- SharedCmdDef.vsct

- SharedCmdPlace.vsct

- ShellCmdDef.vsct

- ShellCmdPlace.vsct

  These files are located in *\<Visual Studio SDK installation path>*\VisualStudioIntegration\Common\Inc\\. These files provide the definitions and GUIDs of the menus and groups that you can use in the command table configuration (.vsct) file of your VSPackage as containers for your own menus, groups, and commands.

## In This Section
- [GUIDs and IDs of Visual Studio Menus](../../extensibility/internals/guids-and-ids-of-visual-studio-menus.md)

 Gives the GUID and ID values of menus on the Visual Studio menu bar, and of the groups they contain.

- [GUIDs and IDs of Visual Studio Toolbars](../../extensibility/internals/guids-and-ids-of-visual-studio-toolbars.md)

 Gives the GUID and ID values of toolbars in the Visual Studio IDE, and of the groups they contain.

- [GUIDs and IDs of Visual Studio Commands](../../extensibility/internals/guids-and-ids-of-visual-studio-commands.md)

 Gives the GUID and ID values of commands defined by the Visual Studio IDE.

## Related content
- [Visual Studio Command Table (.Vsct) Files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
- [IDE-Defined Commands for Extending Project Systems](../../extensibility/internals/ide-defined-commands-for-extending-project-systems.md)
- [How VSPackages Add User Interface Elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)
