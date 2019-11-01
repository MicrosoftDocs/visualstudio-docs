---
title: "GUIDs and IDs of Commands | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords:
  - "commands"
  - "id"
  - "command placement"
  - "visual studio command"
  - "guid"
ms.assetid: 2ea4bee2-0259-4675-8e65-2023b312b516
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# GUIDs and IDs of Visual Studio Commands
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The GUID and ID values of the commands included in the Visual Studio integrated development environment (IDE) are defined in .vsct files that are installed as part of the Visual Studio SDK. For more information, see [IDE-Defined Commands, Menus, and Groups](../../extensibility/internals/ide-defined-commands-menus-and-groups.md).

 For more information about how to work with IDE objects that are defined in .vsct files, see [Extending Menus and Commands](../../extensibility/extending-menus-and-commands.md).

## Finding a Command Definition
 Because Visual Studio defines more than one thousand commands, it is impractical to list them all here. Instead, follow these steps to locate the definition of a command.

#### To locate a command definition

1. In Visual Studio, open the following files in the *Visual Studio SDK installation path*\VisualStudioIntegration\Common\Inc\ folder: SharedCmdDef.vsct, ShellCmdDef.vsct, VsDbgCmdUsed.vsct, Venusmenu.vsct.

    Most Visual Studio commands are defined in SharedCmdDef.vsct and ShellCmdDef.vsct. VsDbgCmdUsed.vsct defines commands that pertain to the debugger, and Venusmenu.vsct defines commands that are specific to Web development.

2. If the command is a menu item, note the exact text of the menu item. If the command is a button on a toolbar, note the tooltip text that appears when you pause on it.

3. Press CTRL+F to open the **Find** dialog box.

4. In the **Find what** box, type the text you noted in step 2.

5. Verify that **All Open Documents** is displayed in the **Look in** box.

6. Click the **Find Next** button until the text is selected in the `<Strings>` section of a [Button Element](../../extensibility/button-element.md).

    The `<Button>` element that the command appears in is the command definition.

   When you have found the command definition, you can put a copy of the command on another menu or toolbar by creating a [CommandPlacement Element](../../extensibility/commandplacement-element.md) that has the same `guid` and `id` values as the command. For more information, see [Creating Reusable Groups of Buttons](../../extensibility/creating-reusable-groups-of-buttons.md).

### Special Cases
 In the following cases, the menu text or tooltip text may not exactly match what is in the command definition.

- Menu items that include an underlined character, such as the **Print** command on the **File** menu, in which the P is underlined.

     Characters that are preceded by the '&' character in menu item names are displayed as underlined. However, .vsct files are written in XML, which uses the '&' character to indicate special characters and requires that an ampersand that is to be displayed must be spelled out as '&amp;'. Therefore, in a .vsct file, the **Print** command appears as '&amp;Print'.

- Commands that have dynamic text, such as **Save** *Current Filename*, and dynamically generated menu items, such as the items on the **Recent Files** list.

     There is no reliable way to search on dynamic text. Instead, find a group that hosts the desired command by consulting [GUIDs and IDs of Visual Studio Menus](../../extensibility/internals/guids-and-ids-of-visual-studio-menus.md) or [GUIDs and IDs of Visual Studio Toolbars](../../extensibility/internals/guids-and-ids-of-visual-studio-toolbars.md), and search on the ID of that group. If the command definition does not have the group as its [Parent Element](../../extensibility/parent-element.md), search SharedCmdPlace.vsct and ShellCmdPlace.vsct (or VsDbgCmdPlace.vsct for debugger commands) for a `<CommandPlacement>` element that sets the parent of the command. SharedCmdPlace.vsct, ShellCmdPlace.vsct, andVsDbgCmdPlace.vsct are in the *Visual Studio SDK installation path*\VisualStudioIntegration\Common\Inc\ folder.

## See Also
 [MenuCommands Vs. OleMenuCommands](../../misc/menucommands-vs-olemenucommands.md)
 [Visual Studio Command Table (.Vsct) Files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
 [VSCT XML Schema Reference](../../extensibility/vsct-xml-schema-reference.md)
