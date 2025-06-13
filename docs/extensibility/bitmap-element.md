---
title: Bitmap Element
description: The Bitmap element defines a bitmap. The bitmap is loaded either from a resource or from a file. This article contains an example.
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
# Bitmap element

Defines a bitmap. The bitmap is loaded either from a resource or from a file.

## Syntax

```
<Bitmap guid="guidImages" href="images\MyImage.bmp" usedList="bmp1, bmp2, bmp3" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|guid|Required. GUID of the GUID/ID command identifier.<br /><br /> The guid attribute for a bitmap is not associated with any VSPackage or other command group.  It should be unique to the bitmap definition and should not be used for any other purpose.|
|resID|ID of the GUID/ID command identifier. Either the resID or the href attribute is required.<br /><br /> The resID attribute is an integer resource ID that determines the bitmap strip that is to be loaded during command table merging.  When the command table is being loaded, the bitmaps specified by the resource ID will be loaded from the resource of the same module.|
|usedList|Required if the resID attribute is present. Selects the available images in the bitmap strip.|
|href|Path to the bitmap. Either the resID or the href attribute is required.<br /><br /> The include path is searched for the indicated image file, which is embedded in the resulting binary.  During the command table merge, the image is copied and no additional resource lookup or load is required.  If the usedList attribute is not present, all images in the strip are available. **Note:**  Images may be supplied in one of several formats that include *.bmp*, *.png*, and *.gif*.  Earlier versions of the compiler did not support 32-bit bitmap images that had alpha information for partial transparency. The workaround for these versions is to use the *.png* format.|
|Condition|Optional. See [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Bitmaps element](../extensibility/bitmaps-element.md)|Groups Bitmap elements.|

## Example

```
<Bitmap guid="guidWidgetIcons" href="WidgetToolbarIcons_32.bmp" />
<Bitmap guid="guidWidgetIcons2" resID="IDBMP_WIDGETICONS"
  usedList="1, 2, 3, 4"/>
```

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
