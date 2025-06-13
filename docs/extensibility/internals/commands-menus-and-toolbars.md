---
title: Commands, Menus, and Toolbars
description: Explore the specific commands, menus, and toolbars in Visual Studio, including the available options and how the features work in VSPackages. 
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- menus [Visual Studio SDK], commands
- commands [Visual Studio]
- toolbars [Visual Studio], commands
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Commands, menus, and toolbars

Menus and toolbars are the way users access commands in your VSPackage. Commands are functions that accomplish tasks, such as printing a document, refreshing a view, or creating a new file. Menus and toolbars are convenient graphical ways to present your commands to users. Typically, related commands are clustered together on the same menu or toolbar.

- Menus typically are displayed as one-word strings clustered in a row at the top of the integrated development environment (IDE) or a tool window. Menus also can be displayed as the result of a right-click event, and are referred to as shortcut menus in that context. When clicked, menus expand to display one or more commands. Commands, when clicked, can carry out tasks or launch submenus that contain additional commands. Some well-known menu names are **File**, **Edit**, **View**, and **Window**. For more information, see [Extend menus and commands](../../extensibility/extending-menus-and-commands.md).

- Toolbars typically are rows of buttons and other controls, such as combo boxes, list boxes, text boxes, and menu controllers. All toolbar controls are associated with commands. When you click a toolbar button, its associated command is activated. Toolbar buttons usually have icons that suggest the underlying commands, such as a printer for a Print command. In a drop-down list control, each item in the list is associated with a different command. A menu controller is a hybrid in which one side of the control is a toolbar button and the other side is a down arrow that displays additional commands when clicked. For more information, see [Add a menu controller to a toolbar](../../extensibility/adding-a-menu-controller-to-a-toolbar.md).

- When you create a command, you also must create an event handler for it. The event handler determines when the command is visible or enabled, allows you to modify its text, and ensures that the command responds appropriately ("routes") when activated. In most instances, the IDE handles commands using the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface. Commands in Visual Studio route in a hierarchical manner, starting with the innermost command context, based on the local selection, and proceeding to the outermost context, based on the global selection. Commands added to the main menu are immediately available for scripting. For more information, see [MenuCommands vs. OleMenuCommands](/previous-versions/visualstudio/visual-studio-2015/misc/menucommands-vs-olemenucommands?preserve-view=true&view=vs-2015) and [Selection context objects](../../extensibility/internals/selection-context-objects.md).

  To define new menus and toolbars, you must describe them in a Visual Studio command table (*.vsct*) file. The Visual Studio package template creates this file for you, along with the necessary elements to support whatever commands, toolbars, and editors you selected in the template. Alternatively, you can write your own *.vsct* file, using the XML schema described here: [VSCT XML schema reference](../../extensibility/vsct-xml-schema-reference.md).

  For more information about working with *.vsct* files, see [Visual Studio command table (.vsct) files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md).

  The topics in this section explain how commands, menus, and toolbars work in VSPackages.

## In this section
- [How VSPackages add user interface elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)

 An in-depth description of the command table format specification.

- [Visual Studio command table (.vsct) files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)

 Describes an XML-based syntax and compiler for command tables.

- [Default command, group, and toolbar placement](../../extensibility/internals/default-command-group-and-toolbar-placement.md)

 Describes predefined commands, groups, menus, and toolbars.

- [IDE-defined commands, menus, and groups](../../extensibility/internals/ide-defined-commands-menus-and-groups.md)

 Specifies the predefined menus, commands, and command groups available for use by the Visual Studio IDE.

- [Command design](../../extensibility/internals/command-design.md)

 Explains how to design commands.

- [Optimize menu and toolbar commands](../../extensibility/internals/optimizing-menu-and-toolbar-commands.md)

 Gives guidelines for commands.

- [Make commands available](../../extensibility/internals/making-commands-available.md)

 Explains how to make commands available to Visual Studio.

- [Commands and menus that use interop assemblies](../../extensibility/internals/commands-and-menus-that-use-interop-assemblies.md)

 Explains how to implement commands that use interop assemblies.

## Related sections
- [Command routing in VSPackages](../../extensibility/internals/command-routing-in-vspackages.md)

 Explains command routing in VSPackages.