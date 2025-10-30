---
title: Command Design
description: Learn how to design a command for a VSPackage in Visual Studio. Including, how to specify where it appears, when it is available, and how it is to be handled.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- commands
- commands, implementation
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Command design

When you add a command to a VSPackage, you must specify where it is to appear, when it is available, and how it is to be handled.

## Define commands
 To define new commands, include a Visual Studio command table (*.vsct*) file in your VSPackage project. If you have created a VSPackage by using the Visual Studio package template, the project includes one of these files. For more information, see [Visual Studio command table (.vsct) files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md).

 Visual Studio merges all the *.vsct* files it finds so that it can display the commands. Because these files are distinct from the VSPackage binary, Visual Studio does not have to load the package to find the commands. For more information, see [How VSPackages add user interface elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md).

 Visual Studio uses the <xref:Microsoft.VisualStudio.Shell.ProvideMenuResourceAttribute> registration attribute to define menu resources and commands. For more information, see [Command implementation](../../extensibility/internals/command-implementation.md).

 Commands can be changed at run time in a number of different ways. They can be displayed or hidden, enabled or disabled. They can display different text or icons, or contain different values. A great deal of customization may be performed before Visual Studio loads your VSPackage. For more information, see [How VSPackages add user interface elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md).

## Command handlers
 When you create a command, you must provide an event handler to execute the command. If the user selects the command, it must be appropriately routed. Routing a command means sending it to the correct VSPackage to enable or disable it, hide or display it, and execute it if the user chooses to do so. For more information, see [Command routing algorithm](../../extensibility/internals/command-routing-algorithm.md).

## Visual Studio command environment
 Visual Studio can host any number of VSPackages, and each can contribute its own command set. The environment displays only the commands that are appropriate to the current task. For more information, see [Command availability](../../extensibility/internals/command-availability.md) and [Selection context objects](../../extensibility/internals/selection-context-objects.md).

 A VSPackage that defines new commands, menus, toolbars, or shortcut menus provides its command information to the Visual Studio at installation time through registry entries that reference resources in native or managed assemblies. Each resource then references a binary data resource (*.cto*) file, which is produced when you compile a Visual Studio command table (*.vsct*) file. This enables Visual Studio to provide merged command sets, menus, and toolbars without having to load every installed VSPackage.

### Command organization
 The environment positions commands by group, priority, and menu.

- Groups are logical collections of related commands, for example, the **Cut**, **Copy**, and **Paste** command group. Groups are the commands that appear on menus.

- Priority determines the order in which individual commands in a group appear on the menu.

- Menus act as containers for groups.

  The environment predefines some commands, groups, and menus. For more information, see [Default command, group, and toolbar placement](../../extensibility/internals/default-command-group-and-toolbar-placement.md).

  A command can be assigned to a primary group. The primary group controls the position of the command in the main menu structure and in the **Customize** dialog box. A command can appear in multiple groups; for example, a command can be on the main menu, on a shortcut menu, and on a toolbar. For more information, see [How VSPackages add user interface elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md).

### Command routing
 The process of invoking and routing commands for VSPackages differs from the process of calling methods on object instances.

 The environment routes commands sequentially from the innermost (local) command context, which is based on current selection, to the outermost (global) context. The first context that is able to execute the command is the one that handles it. For more information, see [Command routing algorithm](../../extensibility/internals/command-routing-algorithm.md).

 In most instances, the environment handles commands by using the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface. Because the command routing scheme enables many different objects to handle commands, <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> can be implemented by any number of objects; these include Microsoft ActiveX controls, window view implementations, document objects, project hierarchies, and VSPackage objects themselves (for global commands). In some specialized cases, for example, routing commands in a hierarchy, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> interface must be implemented.

## Related topics

|Title|Description|
|-----------|-----------------|
|[Command implementation](../../extensibility/internals/command-implementation.md)|Describes how to implement commands in a VSPackage.|
|[Command availability](../../extensibility/internals/command-availability.md)|Describes how Visual Studio context determines which commands are available.|
|[Command routing algorithm](../../extensibility/internals/command-routing-algorithm.md)|Describes how Visual Studio command routing architecture enables commands to be handled by different VSPackages.|
|[Command placement guidelines](../../extensibility/internals/command-placement-guidelines.md)|Suggests how to position commands in the Visual Studio environment.|
|[How VSPackages add user interface elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)|Describes how VSPackages can best utilize the Visual Studio command architecture.|
|[Default command, group, and toolbar placement](../../extensibility/internals/default-command-group-and-toolbar-placement.md)|Describes how VSPackages can best use the commands that are included in Visual Studio.|
|[Manage VSPackages](../../extensibility/managing-vspackages.md)|Describes how Visual Studio loads VSPackages.|
|[Visual Studio command table (.vsct) files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)|Provides information about XML-based *.vsct* files, which are used to describe the layout and appearance of commands in VSPackages.|
