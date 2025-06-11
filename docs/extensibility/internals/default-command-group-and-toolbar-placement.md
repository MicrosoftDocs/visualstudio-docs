---
title: Default Command, Group, and Toolbar Placement
description: Learn about the IDE commands, product commands, and editor commands, that the Visual Studio user interface displays by default.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- commands [Visual Studio], default groups
- toolbars [Visual Studio], default
- commands [Visual Studio], default editor
- command groups
- commands [Visual Studio], default IDE
- commands [Visual Studio], default product
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Default command, group, and toolbar placement

For product uniformity and stability, the UI displays certain command groups by default, and Visual Studio provides definitions for commands and command groups. VSPackages can also use the standard commands and command groups.

 The default command groups fall into three categories: IDE commands, product commands, and editor commands.

## Default IDE commands
 The default IDE toolbar includes commands shared by all products contained in Visual Studio. These include commands relating to generic project operations, such as the **Save** command and the **Add Item** command. VSPackages should not add to or subtract from this toolbar, with one exception: If the product or VSPackage adds a new tool window, then the window should be added to the list of available tool windows on the **View** menu. New products or VSPackages can add their own toolbar.

## Default product commands
 Each product can provide the IDE with its own default toolbar that contains important and frequently used commands. It is best, however, to use existing menus and toolbars whenever possible and supplement them with other task-specific toolbars as needed.

 The priority field for a toolbar determines its row placement. Zero priority places the toolbar on the third row (row 3), beneath the menu bar (row 1) and the **Standard** toolbar (row 2). Therefore, other toolbars appear at row (priority + 3). Subsequent toolbars are placed on the same row, if there is room; otherwise, they are automatically moved to the next row.

## Default editor commands
 A VSPackage that provides a custom editor should provide a default toolbar that contains the most important and frequently used commands in that editor. The editor toolbar should appear when the editor is active and should be hidden when the editor is not active. This visibility is controlled in the `VisibilityConstraints` element of the *.vsct* file.

 Editor toolbars should be placed below IDE and product toolbars.

## Related content
- [IDE-defined commands, menus, and groups](../../extensibility/internals/ide-defined-commands-menus-and-groups.md)
- [How VSPackages add user interface elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)
