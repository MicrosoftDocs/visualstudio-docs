---
title: GuidSymbol Element
description: The GuidSymbol element contains the GUID of the GUID:ID pair that represents a menu, group, or command.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSCT XML schema elements, GuidSymbol
- GuidSymbol element (VSCT XML schema)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# GuidSymbol element

The `GuidSymbol` element contains the GUID of the GUID:ID pair that represents a menu, group, or command. The ID comes from an `IDSymbol` element in the `GuidSymbol` element. The `GuidSymbol` element has a `name` attribute that provides a friendly name for the GUID, which is contained in the `value` attribute.

## Syntax

```xml
<GuidSymbol name="guidMyCommandSet" value="{xxxxxxxxxxxxx-xxxx-xxxx-xxxxxxxxxxxx}">
  <IDSymbol>... </IDSymbol>
  <IDSymbol>... </IDSymbol>
</GuidSymbol>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|name|Required. Name of the GUID symbol.|
|value|Required. GUID of the GUID symbol.|

### Child elements

|Element|Description|
|-------------|-----------------|
|[IDSymbol element](../extensibility/idsymbol-element.md)|Contains the ID of the GUID:ID pair that represents a menu, group, or command.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Symbols element](../extensibility/symbols-element.md)|Groups `GuidSymbol` elements in a *.vsct* file.|

## Remarks
 Typically, a *.vsct* file contains three `GuidSymbol` elements in its `Symbols` section, one for the package itself, one for the command set (the collection of menus, groups, and commands that the package makes available), and one for the bitmaps that provide icons for buttons and other visual components. Every `IDSymbol` element in a given `GuidSymbol` element must have a unique `value`.However, `IDSymbol` elements that have identical values can exist in a package as long as they have different parents.

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
