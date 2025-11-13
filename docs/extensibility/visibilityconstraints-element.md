---
title: VisibilityConstraints Element
description: The VisibilityConstraints element determines the static visibility of groups of commands and toolbars.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VisibilityConstraints
helpviewer_keywords:
- VSCT XML schema elements, VisibilityConstraints
- VisibilityConstraints element (VSCT XML schema)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# VisibilityConstraints element

The VisibilityConstraints element determines the static visibility of groups of commands and toolbars. The visibility is first controlled by the Visual Studio integrated development environment (IDE) without loading the VSPackage.

## Syntax

```xml
<VisibilityConstraints>
  <VisibilityItem />
  <VisibilityItem />
</VisibilityConstraints>
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
|[VisibilityItem element](../extensibility/visibilityitem-element.md)|Determines the static visibility of commands and toolbars.|
|[VisibilityConstraints](../extensibility/visibilityconstraints-element.md)|Determines the static visibility of groups of commands and toolbars.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[CommandTable element](../extensibility/commandtable-element.md)|Defines all the elements that represent the commands (for example, menu items, menus, toolbars, and combo boxes) that a VSPackage provides to the IDE.|

## Example

```xml
<VisibilityConstraints>
  <VisibilityItem guid="cmdSetGuidMyProductCommands"     id="cmdidAddWidget"
    context="guidNotViewSourceMode"/>
</VisibilityConstraints>
```

## See also
- [VisibilityItem element](../extensibility/visibilityitem-element.md)
- [Visual Studio command table (.Vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
