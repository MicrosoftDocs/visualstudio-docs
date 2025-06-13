---
title: Bitmaps Element
description: The Bitmaps element groups one or more Bitmap elements. This article contains an example of the Bitmaps element.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSCT XML schema elements, Bitmaps
- Bitmaps element (VSCT XML schema)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Bitmaps element

Groups [Bitmap element](../extensibility/bitmap-element.md) elements.

## Syntax

```
<Bitmaps>
  <Bitmap>... </Bitmap>
  <Bitmap>... </Bitmap>
</Bitmaps>
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
|[Bitmaps element](../extensibility/bitmaps-element.md)|Groups Bitmap elements.|
|[Bitmap element](../extensibility/bitmap-element.md)|Defines a bitmap.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Commands element](../extensibility/commands-element.md)|Represents the collection of commands on the VSPackage toolbar.|

## Example

```
<Bitmaps>
  <Bitmap guid="guidWidgetIcons" href="WidgetToolbarIcons_32.bmp" />
  <Bitmap guid="guidWidgetIcons2" resID="IDBMP_WIDGETICONS"
    usedList="1, 2, 3, 4"/>
</Bitmaps>
```

## See also
- [How VSPackages add user interface elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)
- [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md)
