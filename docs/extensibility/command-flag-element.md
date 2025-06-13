---
title: Command Flag Element
description: The Command flag Element modifies its parent element. Review its parent elements and child elements.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- CommandFlag element (VSCT XML schema)
- VSCT XML schema elements, CommandFlag
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Command flag element

Modifies its parent element.

## Syntax

```
<CommandFlag>DynamicVisibility</CommandFlag>
```

## Attributes and elements
 The following section describes valid element values.

### Attributes
 None.

### Child elements

|Value|Description|
|-----------|-----------------|
|AllowParams|Indicates that users can enter command parameters in the **Command** window when they type the canonical name of the command.<br /><br /> Valid for: `Button`|
|AlwaysCreate|Menu is created even if it has no groups or buttons.<br /><br /> Valid for: `Menu`|
|CaseSensitive|User entries are case-sensitive.<br /><br /> Valid for: `Combo`|
|CommandWellOnly|Apply this flag if the command does not appear on the top-level menu and you want to make it available for additional shell customization, for example, for binding it to a keyboard shortcut. After the VSPackage is installed, you can customize these commands by opening the **Options** dialog box and then editing the command placement under the **Keyboard Environment** category. This flag does not affect placement on shortcut menus, toolbars, menu controllers, or submenus.<br /><br /> Valid for: `Button`, `Combo`|
|DefaultDisabled|By default, the command is disabled if the VSPackage that implements it is not loaded or the `QueryStatus` method has not been called.<br /><br /> Valid for: `Button`, `Combo`|
|DefaultDocked|Docked by default. This setting no longer applies to toolbars because they are always docked.|
|DefaultInvisible|By default, the command is invisible if the VSPackage that implements it is not loaded or the `QueryStatus` method has not been called.<br /><br /> We recommend that you combine this with the `DynamicVisibility` flag.<br /><br /> Valid for: `Button`, `Combo`, `Menu`|
|DontCache|The development environment does not cache the `QueryStatus` method results for this command.<br /><br /> For a menu, this tells a menu controller not to cache the text of its menu items. Use this flag when the menu contains dynamic items or items that have dynamic text.<br /><br /> Valid for: `Button`, `Menu`|
|DynamicAutomationName|Specifies your QueryStatus handler will respond to OLECMDTEXTFEXT_AUTOMATIONNAME and return a string to be used as the automation name for your control. If you are using OleMenuCommand you can set the AutomationName property in your BeforeQueryStatus handler if you have this flag set.<br /><br /> When used on a Menu element this flag applies only to menus of type MenuController or MenuControllerLatched.<br /><br /> Valid for: `Button`, `Combo`, `Menu`|
|DynamicItemStart|Indicates the beginning of a dynamic list. This enables the environment to build a list by successively calling the `QueryStatus` method on list items until the OLECMDERR_E_UNSUPPORTED flag is returned. This works well for items such as most recently used (MRU) lists and window lists.<br /><br /> Valid for: `Button`|
|DynamicVisibility|The visibility of the command can be changed through the `QueryStatus` method or through a context GUID that is included in the `VisibilityConstraints` section.<br /><br /> Applies to commands that appear on menus and tool window toolbars, but not on top-level toolbars that appear on the main window. Top-level toolbar items can be disabled but not hidden, when the OLECMDF_INVISIBLE flag is returned from the `QueryStatus` method. Toolbar commands that appear on tool window toolbars can be hidden.<br /><br /> On a menu, this flag also indicates that it should be automatically hidden when all its members are hidden. This flag is typically assigned to submenus because top-level menus already have this behavior.<br /><br /> This flag should be combined with the `DefaultInvisible` flag.<br /><br /> Valid for: `Button`, `Combo`, `Menu`|
|FilterKeys|See the Filtering Keys topic under [Combo Element](../extensibility/combo-element.md).<br /><br /> Valid for: `Combo`|
|FixMenuController|If this command is positioned on a menu controller, the command is always the default; that is, the command is selected whenever the menu controller button itself is selected. If the menu controller has the `TextIsAnchorCommand` flag set, then the menu controller also takes its text from the command that has the `FixMenuController` flag.<br /><br /> Only one command on a menu controller should have the `FixMenuController` flag. If more than one command is so marked, the last command in the menu becomes the default command.<br /><br /> Valid for: `Button`|
|IconAndText|Show an icon and text on menu and toolbar.<br /><br /> Valid for: `Button`, `Combo`, `Menu`|
|NoAutoComplete|Auto-complete feature is disabled.<br /><br /> Valid for: `Combo`|
|NoButtonCustomize|Do not let the user customize this button.<br /><br /> Valid for: `Button`, `Combo`|
|NoKeyCustomize|Do not enable keyboard customization.<br /><br /> Valid for: `Button`, `Combo`|
|NoShowOnMenuController|If this command is positioned on a menu controller, the command does not appear in the drop-down list.<br /><br /> Valid for: `Button`|
|NotInTBList|Does not appear in the list of available toolbars. This is valid only for Toolbar menu types.<br /><br /> Valid for: `Menu`|
|NoToolbarClose|User cannot close the toolbar. This is valid only for Toolbar menu types.<br /><br /> Valid for: `Menu`|
|Pict|Show only an icon on a toolbar, but only text on a menu. If no icon is specified, shows a clickable blank space on a toolbar.<br /><br /> Valid for: `Button`|
|PostExec|Makes the command non-blocking. The development environment defers execution until all pre-processing queries are completed.<br /><br /> Valid for: `Button`|
|RouteToDocs|The command is routed to the active document.<br /><br /> Valid for: `Button`|
|StretchHorizontally|When this flag is set, the width becomes the minimum width for the combo box, and if there is room on the toolbar, the combo box stretches to fill available space. This occurs only if the toolbar is horizontally docked, and only one combo box on the toolbar can use the flag (the flag is ignored on all except the first combo box).<br /><br /> Valid for: `Combo`|
|TextChanges|The command or menu text can be changed at run time, typically through the `QueryStatus` method.<br /><br /> Valid for: `Button`, `Menu`|
|TextChangesButton|Valid for: `Button`|
|TextIsAnchorCommand|For a menu controller, the text of the menu is taken from the default (anchor) command. An anchor command is the last command selected or latched. If this flag is not set, the menu controller uses its own `MenuText` field. However, clicking the menu controller still enables the last selected command from that controller.<br /><br /> We recommend that you combine this flag with the `TextChanges` flag.<br /><br /> This flag applies only to menus of type MenuController or MenuControllerLatched.<br /><br /> Valid for: `Menu`|
|TextMenuCtrlUseMenu|Use the `MenuText` field on menu controllers. The default field is `ButtonText`.<br /><br /> Valid for: `Button`|
|TextMenuUseButton|Use the `ButtonText` field for menus. The default field is `MenuText` if it is specified.<br /><br /> Valid for: `Button`|
|TextOnly|Show only text on a toolbar or a menu but no icon even if the icon is specified.<br /><br /> Valid for: `Button`|
|TogglePatternAvailable|Indicates your button supports being checked/latched (that is, may return OLEMCDF_LATCHED or set the Checked property on OleMenuCommand). This allows the automation layer to expose the toggle pattern so screen readers will read the checked/unchecked state along with your button text.<br /><br /> Valid for: `Button`|

### Parent Elements

|Element|Description|
|-------------|-----------------|
|[Buttons element](../extensibility/buttons-element.md)|Provides a group for [Button element](../extensibility/button-element.md) elements.|
|[Menus element](../extensibility/menus-element.md)|Defines all the menus that a VSPackage implements.|

## See also
- [Visual Studio command table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
