---
title: CommandPlacements Element
description: The CommandPlacements element groups CommandPlacement elements and other CommandPlacements groupings. The CommandPlacements element is optional.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- CommandPlacements
helpviewer_keywords:
- CommandPlacements element (VSCT XML schema)
- VSCT XML schema elements, CommandPlacements
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# CommandPlacements element

The CommandPlacements element groups CommandPlacement elements and other CommandPlacements groupings.

 The CommandPlacements element is optional. If no commands, groups, or menus must be included in a secondary location, you do not have to include this section in your *.vsct* file.

## Syntax

```xml
<CommandPlacements>
  <CommandPlacement>... </CommandPlacement>
  <CommandPlacement>... </CommandPlacement>
</CommandPlacements>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|Condition|Optional. See [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child elements

|Element|Description|
|-------------|-----------------|
|CommandPlacements|Groups CommandPlacement elements and other CommandPlacements groupings.|
|[CommandPlacement element](../extensibility/commandplacement-element.md)|Enables buttons, groups, and menus to be included in more than one group or menu.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[CommandTable element](../extensibility/commandtable-element.md)|Defines all the elements that represent commands.|

## Example

```xml
<CommandPlacements>
  <CommandPlacement guid="guidWidgetPackage" id="cmdidInsertOptions"
    priority="0x0300">
    <Parent guid="cmdGuidWidgetCommands" id="menuIDEditWidget"/>
  </CommandPlacement>
</CommandPlacements>
```

## See also
- [CommandPlacement element](../extensibility/commandplacement-element.md)
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
