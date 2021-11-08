---
title: IDSymbol Element | Microsoft Docs
description: The IDSymbol element contains the ID of the GUID:ID pair that represents a menu, group, or command.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDSymbol element (VSCT XML schema)
- VSCT XML schema elements, IDSymbol
ms.assetid: 760cfd20-3c06-422c-9103-98bfa1f387f8
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# IDSymbol element
The `IDSymbol` element contains the ID of the GUID:ID pair that represents a menu, group, or command. The GUID comes from the parent `GuidSymbol` element. The `IDSymbol` element has a `name` attribute that provides a friendly name for the ID, which is contained in the `value` attribute.

## Syntax

```xml
<IDSymbol name=ElementName value="0x0010" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|name|Required. Name of the ID symbol.|
|value|Required. Numeric ID value of the ID symbol.|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[GuidSymbol element](../extensibility/guidsymbol-element.md)|Contains the GUID of the GUID:ID pair that represents a menu, group, or command. Groups `IDSymbol` elements.|

## Remarks
 Every `IDSymbol` element in a given `GuidSymbol` element must have a unique `value`. However, `IDSymbol` elements that have identical values can exist in a package as long as they have different parents.

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
