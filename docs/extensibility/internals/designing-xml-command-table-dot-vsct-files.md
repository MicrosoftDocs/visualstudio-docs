---
title: Designing XML Command Table (.Vsct) Files
description: Learn how to design an XML command table (.vsct) file that describes the layout and appearance of command items, including buttons, combo boxes, menus, and toolbars. 
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- VSCT files, designing
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Design XML command table (.vsct) files

An XML command table (*.vsct*) file describes the layout and appearance of command items for a VSPackage. Command items include buttons, combo boxes, menus, toolbars, and groups of command items. This article describes XML command table files, how they affect command items and menus, and how to create them.

## Commands, menus, groups, and the .vsct file
 The *.vsct* files are organized around commands, menus, and command groups. XML tags in the *.vsct* file represent each of these items, along with other associated items such as command buttons, command placement, and bitmaps.

 When you create a new VSPackage by running the Visual Studio package template, the template generates a *.vsct* file with the necessary elements for a menu command, tool window, or custom editor, depending on your selections. This *.vsct* file can then be modified to meet the requirements of a specific VSPackage. For examples of how to modify a *.vsct* file, see [Extend menus and commands](../../extensibility/extending-menus-and-commands.md).

 To create a new, blank *.vsct* file, see [How to: Create a *.vsct* file](../../extensibility/internals/how-to-create-a-dot-vsct-file.md). Once created, you add XML elements, attributes, and values to the file to describe the command item layout. For a detailed XML schema, see the [VSCT XML schema reference](../../extensibility/vsct-xml-schema-reference.md).

## Differences between .ctc and .vsct files
 While the meaning behind the XML tags in a *.vsct* file are the same as those tags in the now deprecated *.ctc* file format, their implementation is a bit different:

- The new **\<extern>** tag is where you reference other *.h* files to be compiled, such as those files for the Visual Studio toolbar.

- While *.vsct* files support the **/include** statement, as *.ctc* files do, it also features a new **\<import>** element. The difference is, **/include** brings in *all* of the information, while **\<import>** brings in only the names.

- While *.ctc* files require a header file in which you define your preprocessor directives, one is not required for *.vsct* files. Instead, place your directives in the symbol table, located in the **\<Symbol>** elements, located at the bottom of the *.vsct* file.

- *.vsct* files feature an **\<Annotation>** tag, which allows you to embed any information you like, such as notes or even pictures.

- Values are stored as attributes on the item.

- Command flags can be stored individually or stacked.  IntelliSense, however, does not work on stacked command flags. For more information about command flags, see the [CommandFlag element](../../extensibility/command-flag-element.md).

- You can specify multiple types, such as split dropdowns, combos, etc.

- GUIDs don't validate.

- Each UI element has a string that represents the text that is displayed with it.

- The parent is optional. If omitted, the value *Group Unknown* is used.

- The *Icon* argument is optional.

- Bitmap section: This section is the same as in a *.ctc* file, except that you can now specify a file name via Href that will be pulled in by the *vsct.exe* compiler at compile time.

- ResID: The old bitmap resource ID can be used and still works the same as in *.ctc* files.

- HRef: A new method that allows you to specify a file name for the bitmap resource. It assumes that all are used, so you can omit the Used section. The compiler will first search for local resources for the file, then on any net shares, and any resources defined by the **/I** switch.

- Keybinding: You no longer have to specify an emulator. If you do specify one, the compiler will assume that the editor and the emulator are the same.

- Keychord: Keychord has been dropped. The new format is *Key1,Mod1,Key2,Mod2*.  You can specify either a character, hexadecimal, or VK constant.

The new compiler, *vsct.exe*, compiles both *.ctc* and *.vsct* files. The old *ctc.exe* compiler, however, will not recognize or compile *.vsct* files.

You can use the *vsct.exe* compiler to convert an existing *.cto* file into a *.vsct* file. For more information, see [How to: Create a .vsct file from an existing .cto file](../../extensibility/internals/how-to-create-a-dot-vsct-file.md#how-to-create-a-dot-vsct-file-from-an-existing-dot-cto-file).

## The .vsct file elements
 The command table has the following hierarchy and elements:

- [CommandTable element](../../extensibility/commandtable-element.md): Represents all of the commands, menu groups, and menus associated with the VSPackage.

- [Extern element](../../extensibility/extern-element.md): References any external .h files you want to merge with the *.vsct* file.

- [Include element](../../extensibility/include-element.md): References any additional header (.h) files you want to compile along with your *.vsct* file. A *.vsct* file can include *.h* files containing constants that define commands, menu groups, and menus that the IDE or another VSPackage provides.

- [Commands element](../../extensibility/commands-element.md): Represents all of the individual commands that can be executed. Each command has the following four child elements:

- [Menus element](../../extensibility/menus-element.md): Represents all of the menus and toolbars in the VSPackage. Menus are containers for groups of commands.

- [Groups element](../../extensibility/groups-element.md): Represents all of the groups in the VSPackage. Groups are collections of individual commands.

- [Buttons element](../../extensibility/buttons-element.md): Represents all of the command buttons and menu items in the VSPackage. Buttons are visual controls that can be associated with commands.

- [Bitmaps element](../../extensibility/bitmaps-element.md): Represents all of the bitmaps for all of the buttons in the VSPackage. Bitmaps are pictures that display next to or on the command buttons, depending on the context.

- [CommandPlacements element](../../extensibility/commandplacements-element.md): Indicates additional locations where the individual commands should be sited in the menus of your VSPackage.

- [VisibilityConstraints element](../../extensibility/visibilityconstraints-element.md): Specifies whether or not a command displays at all times, or only in certain contexts, such as when a particular dialog box or window is displayed. Menus and commands that have a value for this element will display only when the specified context is active. The default behavior is to display the command at all times.

- [KeyBindings element](../../extensibility/keybindings-element.md): Specifies any key bindings for the commands. That is, one or more key combinations that must be pressed to execute the command, such as **Ctrl**+**S**.

- [UsedCommands element](../../extensibility/usedcommands-element.md): Informs the Visual Studio environment that although the specified command is implemented by other code, when the current VSPackage is active, it provides the command implementation.

- [Symbols element](../../extensibility/symbols-element.md): Contains the symbol names and GUID IDs for all of your commands in the package.

## .vsct file design guidelines
 To successfully design a *.vsct* file, follow these guidelines.

- Commands can be placed only in groups, groups can be placed only in menus, and menus can be placed only in groups. Only menus are actually displayed in the IDE, groups and commands are not.

- Submenus cannot be directly assigned to a menu, but must be assigned to a group, which is in turn assigned to a menu.

- Commands, submenus, and groups can be assigned to one parenting group or menu using the parent field of their defining directive.

- Organizing a command table solely through the parent fields in the directives has a significant limitation. The directives that define objects can take only one parent argument.

- Reusing commands, groups, or submenus requires the use of a new directive to create a new instance of the object with its own `GUID:ID` pair.

- Each `GUID:ID` pair must be unique. Reusing a command that has, for example, been placed on a menu, a toolbar, or on a context menu, is handled by the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface.

- Commands and submenus can also be assigned to multiple groups, and groups can be assigned to multiple menus using the [Commands element](../../extensibility/commands-element.md).

## .vsct file notes
 If you make any changes to a *.vsct* file after you both compile it and place it in a native satellite DLL, you should run **devenv.exe /setup /nosetupvstemplates**. Doing so forces the VSPackage resources specified in the experimental registry to be reread and the internal database that describes Visual Studio to be rebuilt.

 During development, it is possible for multiple VSPackage projects to be created and registered in the experimental registry hive that can lead to confusing clutter in the IDE. To fix this, you can reset the experimental hive to the default settings to remove all registered VSPackages and any changes they may have made to the IDE. To reset the experimental hive, use the CreateExpInstance.exe tool that comes with the Visual Studio SDK. You can find it at:

 *%PROGRAMFILES(x86)%\Visual Studio\\\<version> SDK\VisualStudioIntegration\Tools\Bin\CreateExpInstance.exe*

 Run the tool by using the command **CreateExpInstance /Reset**. Remember that this tool removes from the experimental hive all the registered VSPackages not normally installed with Visual Studio.

## Related content
- [Extend menus and commands](../../extensibility/extending-menus-and-commands.md)
