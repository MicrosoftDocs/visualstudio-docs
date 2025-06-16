---
title: Extern Element
description: The Extern element references any external header (.h) files to merge with the .vsct file at compile time. 
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- Extern
helpviewer_keywords:
- VSCT XML schema elements, Extern
- Extern element (VSCT XML schema)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Extern element

The Extern element references any external header (*.h*) files to merge with the *.vsct* file at compile time. The files to be merged must be on the Include path given to the VSCT compiler or referenced by an [Include element](../extensibility/include-element.md). The files may be other *.vsct* files or C++ header files.

 Definitions in header files must be of the form "#define [Symbol] [Value]"  The value may be another symbol if it is previously defined. Definitions may be used in conditional statements of command items. Any symbol not actually used will be discarded.

 CommandTable Element
Extern Element

## Syntax

```xml
<Extern href="stdidcmd.h" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|href|Required. The path to the header file:<br /><br /> href="stdidcmd.h"|
|Condition|Optional. See [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|
|language|Optional. The default language of all [\<Strings>](../extensibility/strings-element.md) elements in the command table:<br /><br /> language="en-us"|

### Child elements

|Element|Description|
|-------------|-----------------|
|None.|None.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[CommandTable element](../extensibility/commandtable-element.md)|Defines all of the elements that represent commands — that is, menu items, menus, toolbars, and combo boxes — that a VSPackage provides to the IDE.|

## Example

```xml
<?xml version="1.0" encoding="utf-8"?>
<CommandTable xmlns="http://schemas.microsoft.com/VisualStudio/2005-10-
  18/CommandTable" xmlns:xs="http://www.w3.org/2001/XMLSchema">
    <Extern href="C:\VSCore\vscommon\inc\vsshlids.h"/>
    ...
  <Commands package="guidMyPackage">
</CommandTable>
```

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
- [How VSPackages add user interface elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)
- [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md)
