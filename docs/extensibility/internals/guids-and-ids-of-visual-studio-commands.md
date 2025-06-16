---
title: GUIDs and IDs of Visual Studio Commands
description: Learn how to locate the GUID and ID values of the commands included in the Visual Studio integrated development environment (IDE).
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- commands
- id
- command placement
- visual studio command
- guid
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# GUIDs and IDs of Visual Studio commands

The GUID and ID values of the commands included in the Visual Studio integrated development environment (IDE) are defined in .vsct files that are installed as part of the Visual Studio SDK. For more information, see [IDE-defined commands, menus, and groups](../../extensibility/internals/ide-defined-commands-menus-and-groups.md).

 For more information about how to work with IDE objects that are defined in *.vsct* files, see [Extend menus and commands](../../extensibility/extending-menus-and-commands.md).

## Find a command definition
 Because Visual Studio defines more than 1000 commands, it is impractical to list them all here. Instead, follow these steps to locate the definition of a command.

### To locate a command definition

1. In Visual Studio, open the following files in the *<Visual Studio SDK installation path\>\VisualStudioIntegration\Common\Inc\\* folder: *SharedCmdDef.vsct*, *ShellCmdDef.vsct*, *VsDbgCmdUsed.vsct*, *Venusmenu.vsct*.

    Most Visual Studio commands are defined in *SharedCmdDef.vsct* and *ShellCmdDef.vsct*. *VsDbgCmdUsed.vsct* defines commands that pertain to the debugger, and *Venusmenu.vsct* defines commands that are specific to Web development.

2. If the command is a menu item, note the exact text of the menu item. If the command is a button on a toolbar, note the tooltip text that appears when you pause on it.

3. Press **Ctrl**+**F** to open the **Find** dialog box.

4. In the **Find what** box, type the text you noted in step 2.

5. Verify that **All Open Documents** is displayed in the **Look in** box.

6. Click the **Find Next** button until the text is selected in the `<Strings>` section of a [Button element](../../extensibility/button-element.md).

    The `<Button>` element that the command appears in is the command definition.

   When you have found the command definition, you can put a copy of the command on another menu or toolbar by creating a [CommandPlacement element](../../extensibility/commandplacement-element.md) that has the same `guid` and `id` values as the command. For more information, see [Create reusable groups of buttons](../../extensibility/creating-reusable-groups-of-buttons.md).

### Special cases
 In the following cases, the menu text or tooltip text may not exactly match what is in the command definition.

- Menu items that include an underlined character, such as the **Print** command on the **File** menu, in which the *P* is underlined.

     Characters that are preceded by the ampersand (&) character in menu item names are displayed as underlined. However, *.vsct* files are written in XML, which uses the ampersand (&) character to indicate special characters and requires that an ampersand to be displayed must be spelled out as *&amp;amp;*. Therefore, in a *.vsct* file, the **Print** command appears as *&amp;amp;Print*.

- Commands that have dynamic text, such as **Save** \<Current Filename\>, and dynamically generated menu items, such as the items on the **Recent Files** list.

     There is no reliable way to search on dynamic text. Instead, find a group that hosts the desired command by consulting [GUIDs and IDs of Visual Studio menus](../../extensibility/internals/guids-and-ids-of-visual-studio-menus.md) or [GUIDs and IDs of Visual Studio toolbars](../../extensibility/internals/guids-and-ids-of-visual-studio-toolbars.md), and search on the ID of that group. If the command definition does not have the group as its [Parent element](../../extensibility/parent-element.md), search *SharedCmdPlace.vsct* and *ShellCmdPlace.vsct* (or *VsDbgCmdPlace.vsct* for debugger commands) for a `<CommandPlacement>` element that sets the parent of the command. *SharedCmdPlace.vsct*, *ShellCmdPlace.vsct*, and *VsDbgCmdPlace.vsct* are in the *\<Visual Studio SDK installation path\>\VisualStudioIntegration\Common\Inc\\* folder.

## See also

- [Visual Studio command table (.vsct) files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
- [VSCT XML schema reference](../../extensibility/vsct-xml-schema-reference.md)
