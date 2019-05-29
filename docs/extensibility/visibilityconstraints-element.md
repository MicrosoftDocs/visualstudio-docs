---
title: "VisibilityConstraints Element | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "VisibilityConstraints"
helpviewer_keywords:
  - "VSCT XML schema elements, VisibilityConstraints"
  - "VisibilityConstraints element (VSCT XML schema)"
ms.assetid: d6dcd314-6fe4-4693-a189-91fa026c7b34
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# VisibilityConstraints element
The VisibilityConstraints element determines the static visibility of groups of commands and toolbars. The visibility is first controlled by the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE) without loading the VSPackage.

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
