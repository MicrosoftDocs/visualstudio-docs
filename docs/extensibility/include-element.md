---
title: "Include Element | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "Include"
helpviewer_keywords:
  - "Include element (VSCT XML schema)"
  - "VSCT XML schema elements, Include"
ms.assetid: c923dfe6-084a-4105-aec1-f0a3f8399c54
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Include element
The Include element specifies a file that can be located on the supplied include path for insertion into the current file.  All symbols and types defined will become part of the compiled result.

## Syntax

```csharp
<Include href="stdidcmd.h" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|href|Required. The path to the header file:<br /><br /> href="stdidcmd.h"|
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child elements

|Element|Description|
|-------------|-----------------|
|None.|None.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[CommandTable element](../extensibility/commandtable-element.md)|Defines all of the elements that represent commands — that is, menu items, menus, toolbars, and combo boxes — that a VSPackage provides to the IDE.|

## Example

```
<Include href="PackagePlacements.vsct"/>
```

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)