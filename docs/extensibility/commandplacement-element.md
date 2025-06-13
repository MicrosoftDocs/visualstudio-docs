---
title: CommandPlacement Element
description: The CommandPlacement element enables buttons, groups, and menus to be included in more than one group or menu. 
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- CommandPlacements element (VSCT XML schema)
- VSCT XML schema elements, CommandPlacements
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# CommandPlacement element

The CommandPlacement element enables buttons, groups, and menus to be included in more than one group or menu. By using the CommandPlacement element, you do not have to completely redefine these items in order to modify the look of a user interface.

 For more information, see [Create reusable groups of buttons](../extensibility/creating-reusable-groups-of-buttons.md).

## Syntax

```
<CommandPlacement guid="guidMyCommandSet" id="MyCommand" priority="0x001" >
  <Parent>... </Parent>
</CommandPlacement>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|guid|Required. The guid of the command set, as defined in the [Symbols element](../extensibility/symbols-element.md).|
|id|Required. The id of the menu, group, or command to be placed, as defined in the `Symbols Element`.|
|priority|Required. Determines the visual position of the item in its parent element.|
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child elements

|Element|Description|
|-------------|-----------------|
|Parent|Required. The menu or group that hosts the item to be placed.|

### Parent Elements

|Element|Description|
|-------------|-----------------|
|[CommandPlacements element](../extensibility/commandplacements-element.md)|Specifies groups of CommandPlacements and CommandPlacement elements.|

## Example

```
<CommandPlacements>
  <CommandPlacement guid="guidWidgetPackage" id="cmdidInsertOptions"
    priority="0x0300">
    <Parent guid="cmdGuidWidgetCommands" id="menuIDEditWidget"/>
  </CommandPlacement>
</CommandPlacements>
```

## See also
- [CommandPlacements element](../extensibility/commandplacements-element.md)
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
