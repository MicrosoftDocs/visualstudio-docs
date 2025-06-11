---
title: Icon Element
description: Learn about the Icon element, which represents icons used in Visual Studio IDE extensions, which includes attributes for the bitmap used and the slot in the bitmap strip.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSCT XML schema elements, Icon
- Icon element (VSCT XML schema)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Icon element

The guid attribute of the Icon tag is the guid of a defined bitmap. The `id` attribute selects the slot in the bitmap strip. This element is optional. If this element is not included the value of **guidOfficeIcon:msotcidNoIcon** will be implied.

## Syntax

```xml
<Icon guid="guidImages" id="bmpPic1" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|guid|Required. The guid of a defined bitmap.|
|id|Required. Selects the slot in the bitmap strip.|

### Child elements

|Element|Description|
|-------------|-----------------|
|None.|None.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Buttons element](../extensibility/buttons-element.md)||

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
