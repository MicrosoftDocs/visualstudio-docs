---
title: Define Element
description: The Define element defines a symbol name and value pair. This symbol can be evaluated by conditional attributes.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSCT XML schema elements, Define
- Define element (VSCT XML schema)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Define element

Defines a symbol name and value pair. This symbol can be evaluated by conditional attributes. For more information, see [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md). See also the [Symbols element](../extensibility/symbols-element.md).

## Syntax

```
<Define name="Mode" value="Standard" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|name|Required. The name of the symbol:<br /><br /> name="Mode"|
|value|Required. The value of the symbol:<br /><br /> value="Standard"|
|Condition|Optional. For more information, see [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[CommandTable element](../extensibility/commandtable-element.md)|Defines all the elements that represent commands that a VSPackage provides to the integrated development environment (IDE). For example, menu items, menus, toolbars, and combo boxes.|

## Example

```
<Define name="DEMO_UI"/>
<Define name="MODE" value="Standard"/>
```

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
