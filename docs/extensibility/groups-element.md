---
title: "Groups Element | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "VSCT XML schema elements, Groups"
  - "Groups element (VSCT XML schema)"
ms.assetid: 740ca4ec-79fa-4b98-8f9a-2a137f9f7f98
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Groups element
Contains entries that define the command groups of a VSPackage.

## Syntax

```xml
<Groups>
  <Group>... </Group>
  <Group>... </Group>
</Groups>
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
|[Group element](../extensibility/group-element.md)|Represents a single command group.|
|[Groups element](../extensibility/groups-element.md)|Contains entries that define the command groups of a VSPackage.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Commands element](../extensibility/commands-element.md)|Represents the collection of commands on the VSPackage toolbar.|

## Example

```xml
<Groups>
  <Group guid="cmdSetGuidWidgetCommands" id="groupIDFileEdit">
    <Parent guid="guidSHLMainMenu" id="IDM_VS_TOOL_MAINMENU"/>
  </Group>
</Groups>
```

## See also
- [How VSPackages add user interface elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)
- [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md)