---
title: "Icon Element | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "VSCT XML schema elements, Icon"
  - "Icon element (VSCT XML schema)"
ms.assetid: 73c58fe3-d53c-4f4e-b025-29567c6cbb7c
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
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