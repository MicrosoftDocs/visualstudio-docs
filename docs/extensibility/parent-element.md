---
title: "Parent Element | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "VSCT XML schema elements, Parent"
  - "Parent element (VSCT XML schema)"
ms.assetid: e4624ac8-1b9a-4940-910a-528a661cefad
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Parent element
The parent of a button or combo box may only be a group. The parent of a menu or group may be any other menu or group. In a [CommandPlacement element](../extensibility/commandplacement-element.md), this element is required; in all other instances it is optional. If this element is omitted, the parent of `Group_Undefined:0` will be implied.

## Syntax

```xml
<Parent guid="guidMyCommandSet" id="MyParentGroupOrMenu" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|guid|Required. GUID of GUID/ID command identifier.|
|id|Required. ID of GUID/ID command identifier.|

### Child elements
 None

### Parent elements

|Element|Description|
|-------------|-----------------|
|[CommandTable element](../extensibility/commandtable-element.md)|Defines all the elements that represent commands that a VSPackage provides to the integrated development environment (IDE). For example, menu items, menus, toolbars, and combo boxes.|
|[Buttons element](../extensibility/buttons-element.md)|Groups [Button element](../extensibility/button-element.md) elements.|
|[Menus element](../extensibility/menus-element.md)|Defines all the menus that a VSPackage implements.|
|[Groups element](../extensibility/groups-element.md)|Contains entries that define the command groups of a VSPackage.|

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)