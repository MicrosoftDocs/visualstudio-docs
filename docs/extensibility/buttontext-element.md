---
title: ButtonText Element | Microsoft Docs
description: The ButtonText element lets you specify the text that appears in various menus. The ButtonText element cannot be blank even if other text fields are specified.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- ButtonText element (VSCT XML schema)
- VSCT XML schema elements, ButtonText
ms.assetid: 56aba884-0356-4894-ae4e-32d3938f6865
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# ButtonText element
This field lets you specify the text that appears in various menus. By default, the `ButtonText` element appears in menu controllers. The `ButtonText` element also becomes the default if the other text fields are blank. The `ButtonText` element cannot be blank even if the other text fields are specified.

## Syntax

```xml
<ButtonText>My Command</ButtonText>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Strings Element](../extensibility/strings-element.md)|Groups text elements, such as `ButtonText` and `CommandName`.|

## Text value
 The text value of the `ButtonText` element provides the text that is displayed for menu items, combos, and other user interface (UI) elements that have visible text.

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
