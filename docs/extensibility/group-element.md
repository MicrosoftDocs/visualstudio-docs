---
title: Group Element
description: The Group element defines a VSPackage command group. This article describes attributes, child elements, and parent elements.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSCT XML schema elements, Groups
- Groups element (VSCT XML schema)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Group element

Defines a VSPackage command group.

## Syntax

```xml
<Group guid="guidMyCommandSet" id="MyGroup" priority="0x101">
  <Parent>... </Parent>
</Group>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|guid|Required. GUID of the GUID/ID command identifier.|
|id|Required. ID of the GUID/ID command identifier.|
|priority|Optional. A numeric value that specifies the priority.|
|Condition|Optional. See [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child elements

|Element|Description|
|-------------|-----------------|
|Parent|Optional. The parent element of the button.|
|Annotation|Optional comment.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Groups element](../extensibility/groups-element.md)|Contains entries that define the command groups of a VSPackage.|

## Example

```xml
<Group guid="cmdSetGuidWidgetCommands" id="groupIDFileEdit">
  <Parent guid="guidSHLMainMenu" id="IDM_VS_TOOL_MAINMENU"/>
</Group>
```

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
