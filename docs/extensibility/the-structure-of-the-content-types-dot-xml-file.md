---
title: The Structure of the [Content_types].xml File
description: Learn about the structure of the content types file, which contains information about the kinds of content in a VSIX package.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- content_types
- content types
- opc
- vsix
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# The Structure of the [Content_types].xml File

Contains information about the kinds of content in a VSIX package. Visual Studio uses the [Content_Types].xml file to install the package, but it does not install the file itself.

> [!NOTE]
> Although this topic applies only to [Content_Type].xml files that are used in VSIX packages, the [Content_Types].xml file type is part of the *Open Packaging Conventions (OPC)* standard. For more information, see [OPC: A New Standard For Packaging Your Data](/archive/msdn-magazine/2007/august/opc-a-new-standard-for-packaging-your-data) on the MSDN Web site.

## Attributes and Elements
 The following sections describe the root element and its attributes and child elements.

### Root Element

|Element|Description|
|-------------|-----------------|
|`Types`|Contains child elements that enumerate the file types in the VSIX package.|

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Xmlns`|(Required.) The location of the schema used for this [Content_Types].xml file.|

### {Attribute name} Attribute

| Value | Description |
| - | - |
| `http://schemas.openformats.org/package/2006/content-types` | The location of the content types schema. |

### Child Elements
 The `Types` element can contain any number of `Default` elements.

|Element|Description|
|-------------|-----------------|
|`Default`|Describes a content type in the VSIX package. Every file type in the package must have its own `Default` element.|

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Extension`|The file name extension of a file in the VSIX package.|
|`ContentType`|Describes the kind of content that is associated with the file name extension.|

### {Attribute name} Attribute
 Visual Studio recognizes the following `ContentType` values for the associated `Extension` types.

|Extension|ContentType|
|---------------|-----------------|
|txt|text/plain|
|pkgdef|text/plain|
|xml|text/xml|
|vsixmanifest|text/xml|
|htm or html|text/html|
|rtf|application/rtf|
|pdf|application/pdf|
|gif|image/gif|
|jpg or jpeg|image/jpg|
|tiff|image/tiff|
|vsix|application/zip|
|zip|application/zip|
|dll|application/octet-stream|
|all other file types|application/octet-stream|

## Example

### Description
 The following [Content_Types].xml file describes a typical VSIX package.

### Code

```
<?xml version="1.0" encoding="utf-8" ?>
<Types xmlns="http://schemas.openxmlformats.org/package/2006/content-types">
    <Default Extension="vsixmanifest" ContentType="text/xml" />
    <Default Extension="dll" ContentType="application/octet-stream" />
    <Default Extension="png" ContentType="application/octet-stream" />
    <Default Extension="txt" ContentType="text/plain" />
    <Default Extension="pkgdef" ContentType="text/plain" />
</Types>
```

## See also
- [Anatomy of a VSIX Package](../extensibility/anatomy-of-a-vsix-package.md)
- [VSIX Extension Schema 1.0 Reference](/previous-versions/dd393700(v=vs.110))
- [OPC: A New Standard For Packaging Your Data](/archive/msdn-magazine/2007/august/opc-a-new-standard-for-packaging-your-data)