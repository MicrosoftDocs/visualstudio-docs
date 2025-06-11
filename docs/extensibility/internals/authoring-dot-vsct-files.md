---
title: Authoring .Vsct Files
description: Learn how to author .vsct files that add menu items, toolbars, and other UI elements to the Visual Studio integrated development environment (IDE).
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- VSCT files, manual authoring
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Author .vsct files

This document shows how to author a *.vsct* file to add menu items, toolbars, and other user interface (UI) elements to the Visual Studio integrated development environment (IDE). Use these steps when you add UI elements to a Visual Studio package (VSPackage) that does not already have a *.vsct* file.

 For new projects, we recommend that you use the Visual Studio package template because it generates a *.vsct* file that, depending on your selections, already has the required elements for a menu command, a tool window, or a custom editor. You can modify this *.vsct* file to meet the requirements of your VSPackage. For more information about how to modify a *.vsct* file, see the examples in [Extend menus and commands](../../extensibility/extending-menus-and-commands.md).

## Author the file
 Author a *.vsct* file in these phases: Create the structure for files and resources, declare the UI elements, put the UI elements in the IDE, and add any specialized behaviors.

### File structure
 The basic structure of a *.vsct* file is a [CommandTable](../../extensibility/commandtable-element.md) root element that contains a [Commands](../../extensibility/commands-element.md) element and a [Symbols](../../extensibility/symbols-element.md) element.

#### To create the file structure

1. Add a *.vsct* file to your project by following the steps in [How to: Create a .vsct file](../../extensibility/internals/how-to-create-a-dot-vsct-file.md).

2. Add the required namespaces to the `CommandTable` element, as shown in the following example:

    ```xml
    <CommandTable xmlns="http://schemas.microsoft.com/VisualStudio/2005-10-18/CommandTable"
        xmlns:xs="http://www.w3.org/2001/XMLSchema">

    ```

3. In the `CommandTable` element, add a `Commands` element to host all of your custom menus, toolbars, command groups, and commands. So that your custom UI elements can load, the `Commands` element must have its `Package` attribute set to the name of the package.

     After the `Commands` element, add a `Symbols` element to define the GUIDs for the package, and the names and command IDs for your UI elements.

### Include Visual Studio resources
 Use the [Extern](../../extensibility/extern-element.md) element to access the files that define Visual Studio commands and the menus that are required to put your UI elements in the IDE. If you will use commands defined outside your package, use the [UsedCommands](../../extensibility/usedcommands-element.md) element to inform Visual Studio.

#### To include Visual Studio resources

1. At the top of the `CommandTable` element, add one `Extern` element for each external file to be referenced, and set the `href` attribute to the name of the file. You can reference the following header files to access Visual Studio resources:

   - *Stdidcmd.h*: Defines IDs for all commands exposed by Visual Studio.

   - *Vsshlids.h*: Contains command IDs for Visual Studio menus.

2. If your package calls any commands that are defined by Visual Studio or by other packages, add a `UsedCommands` element after the `Commands` element. Populate this element with a [UsedCommand](../../extensibility/usedcommand-element.md) element for each command you call that is not part of your package. Set the `guid` and `id` attributes of the `UsedCommand` elements to the GUID and ID values of the commands to call.

   For more information about how to find the GUIDs and IDs of Visual Studio commands, see [GUIDs and IDs of Visual Studio commands](../../extensibility/internals/guids-and-ids-of-visual-studio-commands.md). To call commands from other packages, use the GUID and the ID of the command as defined in the *.vsct* file for those packages.

### Declare UI elements
 Declare all new UI elements in the `Symbols` section of the *.vsct* file.

#### To declare UI elements

1. In the `Symbols` element, add three [GuidSymbol](../../extensibility/guidsymbol-element.md) elements. Each `GuidSymbol` element has a `name` attribute and a `value` attribute. Set the `name` attribute so that it reflects the purpose of the element. The `value` attribute takes a GUID. (To generate a GUID, on the **Tools** menu, select **Create GUID**, and then select **Registry Format**.)

     The first `GuidSymbol` element represents your package, and typically has no children. The second `GuidSymbol` element represents the command set, and will contain all of the symbols that define your menus, groups, and commands. The third `GuidSymbol` element represents your image store and contains symbols for all of the icons for your commands. If you have no commands that use icons, you can omit the third `GuidSymbol` element.

2. In the `GuidSymbol` element that represents your command set, add one or more [IDSymbol](../../extensibility/idsymbol-element.md) elements. Each of these represent a menu, toolbar, group, or command you are adding to the UI.

     For each `IDSymbol` element, set the `name` attribute to the name you will use to refer to the corresponding menu, group, or command, and then set the `value` element to a hexadecimal number that will represent its command ID. No two `IDSymbol` elements that have the same parent can have the same value.

3. If any of your UI elements require icons, add an `IDSymbol` element for each icon to the `GuidSymbol` element that represents your image store.

### Put UI elements in the IDE
 The [Menus](../../extensibility/menus-element.md), [Groups](../../extensibility/groups-element.md), and [Buttons](../../extensibility/buttons-element.md) elements contain the definitions for all of the menus, groups, and commands that are defined in your package. Put these menus, groups, and commands in the IDE either by using a [Parent](../../extensibility/parent-element.md) element, which is part of the UI element definition, or by using a [CommandPlacement](../../extensibility/commandplacement-element.md) element that is defined elsewhere.

 Each `Menu`, `Group`, and `Button` element has a `guid` attribute and an `id` attribute. Always set the `guid` attribute to match the name of the `GuidSymbol` element that represents your command set, and set the `id` attribute to the name of the `IDSymbol` element that represents your menu, group, or command in the `Symbols` section.

#### To define UI elements

1. If you are defining any new menus, submenus, shortcut menus, or toolbars, add a `Menus` element to the `Commands` element. Then, for each menu to be created, add a [Menu](../../extensibility/menu-element.md) element to the `Menus` element.

    Set the `guid` and `id` attributes of the `Menu` element, and then set the `type` attribute to the kind of menu you want. You may also set the `priority` attribute to establish the relative position of the menu in the parent group.

   > [!NOTE]
   > The `priority` attribute does not apply to toolbars and context menus.

2. All commands in the Visual Studio IDE must be hosted by command groups, which are the direct children of menus and toolbars. If you are adding new menus or toolbars to the IDE, these must contain new command groups. You may also add command groups to existing menus and toolbars so that you can visually group your commands.

    When you add new command groups, you must first create a `Groups` element, and then add to it a [Group](../../extensibility/group-element.md) element for each command group.

    Set the `guid` and `id` attributes of each `Group` element, and then set the `priority` attribute to establish the relative position of the group on the parent menu. For more information, see [Create reusable groups of buttons](../../extensibility/creating-reusable-groups-of-buttons.md).

3. If you are adding new commands to the IDE, add a `Buttons` element to the `Commands` element. Then, for each command, add a [Button](../../extensibility/button-element.md) element to the `Buttons` element.

   1. Set the `guid` and `id` attributes of each `Button` element, and then set the `type` attribute to the kind of button you want. You may also set the `priority` attribute to establish the relative position of the command in the parent group.

       > [!NOTE]
       > Use `type="button"` for standard menu commands and buttons on toolbars.

   2. In the `Button` element, add a [Strings](../../extensibility/strings-element.md) element that contains a [ButtonText](../../extensibility/buttontext-element.md) element and a [CommandName](../../extensibility/commandname-element.md) element. The `ButtonText` element provides the text label for a menu item, or the tooltip for a toolbar button. The `CommandName` element provides the name of the command to use in the command well.

   3. If your command will have an icon, create an [Icon](../../extensibility/icon-element.md) element in the `Button` element, and set its `guid` and `id` attributes to the `Bitmap` element for the icon.

       > [!NOTE]
       > Toolbar buttons must have icons.

   For more information, see [MenuCommands vs. OleMenuCommands](/previous-versions/visualstudio/visual-studio-2015/misc/menucommands-vs-olemenucommands?preserve-view=true&view=vs-2015).

4. If any of your commands require icons, add a [Bitmaps](../../extensibility/bitmaps-element.md) element to the `Commands` element. Then, for each icon, add a [Bitmap](../../extensibility/bitmap-element.md) element to the `Bitmaps` element. This is where you specify the location of the bitmap resource. For more information, see [Add icons to menu commands](../../extensibility/adding-icons-to-menu-commands.md).

   You can rely on the parenting structure to correctly place most menus, groups, and commands. For very large command sets, or when a menu, group, or command must appear in multiple places, we recommend that you specify command placement.

#### To rely on parenting to place UI elements in the IDE

1. For typical parenting, create a `Parent` element in each `Menu`, `Group`, and `Command` element that is defined in your package.

    The target of the `Parent` element is the menu or group that will contain the menu, group, or command.

   1. Set the `guid` attribute to the name of the `GuidSymbol` element that defines the command set. If the target element is not part of your package, use the guid for that command set, as defined in the corresponding *.vsct* file.

   2. Set the `id` attribute to match the `id` attribute of the target menu or group. For a listing of the menus and groups that are exposed by Visual Studio, see [GUIDs and IDs of Visual Studio menus](../../extensibility/internals/guids-and-ids-of-visual-studio-menus.md) or [GUIDs and IDs of Visual Studio toolbars](../../extensibility/internals/guids-and-ids-of-visual-studio-toolbars.md).

   If you have a large number of UI elements to place in the IDE, or if you have elements that should appear in multiple places, define their placements in the [CommandPlacements](../../extensibility/commandplacements-element.md) element, as shown in the following steps.

#### To use command placement to place UI elements in the IDE

1. After the `Commands` element, add a `CommandPlacements` element.

2. In the `CommandPlacements` element, add a `CommandPlacement` element for each menu, group, or command to place.

    Each `CommandPlacement` element or `Parent` element places one menu, group, or command in one IDE location. A UI element can only have one parent, but it can have multiple command placements. To place a UI element in multiple locations, add a `CommandPlacement` element for each location.

3. Set the `guid` and `id` attributes of each `CommandPlacement` element to the hosting menu or group, just as you would for a `Parent` element. You can also set the `priority` attribute to establish the relative position of the UI element.

   You can mix placement by parenting and command placement. However, for very large command sets, we recommend that you use only command placement.

### Add specialized behaviors
 You can use the [CommandFlag](../../extensibility/command-flag-element.md) element to modify the behavior of menus and commands, for example, to change their appearance and visibility. You can also affect when a command is visible by using the [VisibilityConstraints](../../extensibility/visibilityconstraints-element.md) element, or add keyboard shortcuts by using the [KeyBindings](../../extensibility/keybindings-element.md) element. Certain kinds of menus and commands already have specialized behaviors built in.

#### To add specialized behaviors

1. To make a UI element visible only in certain UI contexts, for example, when a solution is loaded, use visibility constraints.

   1. After the `Commands` element, add a `VisibilityConstraints` element.

   2. For each UI item to constrain, add a [VisibilityItem](../../extensibility/visibilityitem-element.md) element.

   3. For each `VisibilityItem` element, set the `guid` and `id` attributes to the menu, group, or command, and then set the `context` attribute to the UI context you want, as defined in the <xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids80> class.

2. To set the visibility or availability of a UI item in code, use one or more of the following command flags:

   - `DefaultDisabled`

   - `DefaultInvisible`

   - `DynamicItemStart`

   - `DynamicVisibility`

   - `NoShowOnMenuController`

   - `NotInTBList`

   For more information, see the [CommandFlag](../../extensibility/command-flag-element.md) element.

3. To change how an element appears, or change its appearance dynamically, use one or more of the following command flags:

   - `AlwaysCreate`

   - `CommandWellOnly`

   - `DefaultDocked`

   - `DontCache`

   - `DynamicItemStart`

   - `FixMenuController`

   - `IconAndText`

   - `Pict`

   - `StretchHorizontally`

   - `TextMenuUseButton`

   - `TextChanges`

   - `TextOnly`

   For more information, see the [CommandFlag](../../extensibility/command-flag-element.md) element.

4. To change how an element reacts when it receives commands, use one or more of the following command flags:

   - `AllowParams`

   - `CaseSensitive`

   - `CommandWellOnly`

   - `FilterKeys`

   - `NoAutoComplete`

   - `NoButtonCustomize`

   - `NoKeyCustomize`

   - `NoToolbarClose`

   - `PostExec`

   - `RouteToDocs`

   - `TextIsAnchorCommand`

   For more information, see the [CommandFlag](../../extensibility/command-flag-element.md) element.

5. To attach a menu-dependent keyboard shortcut to a menu or an item on a menu, add an ampersand character (&) in the `ButtonText` element for the menu or menu item. The character that follows the ampersand is the active keyboard shortcut when the parent menu is open.

6. To attach a menu-independent keyboard shortcut to a command, use the [KeyBindings](../../extensibility/keybindings-element.md) element. For more information, see the [KeyBinding](../../extensibility/keybinding-element.md) element.

7. To localize menu text, use the `LocCanonicalName` element. For more information, see the [Strings](../../extensibility/strings-element.md) element.

   Some menu and button types include specialized behaviors. The following list describes some specialized menu and button types. For other types, see the `types` attribute descriptions in the [Menu](../../extensibility/menu-element.md), [Button](../../extensibility/button-element.md), and [Combo](../../extensibility/combo-element.md) elements.

   - Combo box:
   A combo box is a drop-down list that can be used on a toolbar. To add combo boxes to the UI, create a [Combos](../../extensibility/combos-element.md) element in the `Commands` element. Then add to the `Combos` element a `Combo` element for each combo box to add. `Combo` elements have the same attributes and children as `Button` elements and also have `DefaultWidth` and `idCommandList` attributes. The `DefaultWidth` attribute sets the width in pixels, and the `idCommandList` attribute points to a command ID that is used to populate the combo box.

   - Menu controller:
   A menu controller is a button that has an arrow next to it. Clicking the arrow opens a list. To add a menu controller to the UI, create a `Menu` element and set its `type` attribute to `MenuController` or `MenuControllerLatched`, depending on the behavior you want. To populate a menu controller, set it as the parent of a `Group` element. The menu controller will display all children of that group on its drop-down list.

## Related content
- [Extend menus and commands](../../extensibility/extending-menus-and-commands.md)
- [Visual Studio command table (.vsct) files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
- [VSCT XML schema reference](../../extensibility/vsct-xml-schema-reference.md)