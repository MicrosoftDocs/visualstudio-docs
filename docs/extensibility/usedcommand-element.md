---
title: UsedCommand Element
description: The UsedCommand element enables a VSPackage to access a command that is defined in another .vsct file.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- UsedCommands element (VSCT XML schema)
- VSCT XML schema elements, UsedCommands
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# UsedCommand Element

Enables a VSPackage to access a command that is defined in another .vsct file. For example, if your VSPackage uses the standard **Copy** command, which is defined by the Visual Studio shell, you can add the command to a menu or toolbar without re-implementing it.

## Syntax

```
<UsedCommand guid="guidMyCommandGroup" id="MyCommand" />
```

## Attributes and Elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|guid|Required. The GUID of the GUID ID pair that identifies the command.|
|id|Required. The ID of the GUID ID pair that identifies the command.|
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child Elements

|Element|Description|
|-------------|-----------------|
|None||

### Parent Elements

|Element|Description|
|-------------|-----------------|
|[UsedCommands Element](../extensibility/usedcommands-element.md)|Groups UsedCommand elements and other UsedCommands groupings.|

## Remarks
 By adding a command to the `<UsedCommands>` element, a VSPackage informs the Visual Studio environment that the VSPackage requires the command. You should add a `<UsedCommand>` element for any command your package requires that might not be included in all versions and configurations of Visual Studio. For example, if your package calls a command that is specific to Visual C++, the command will not be available to users of Visual Web Developer unless you include a `<UsedCommand>` element for the command.

## Example

```
<UsedCommands>
  <UsedCommand guid="guidVSStd97" id="cmdidCut"/>
  <UsedCommand guid="guidVSStd97" id="cmdidCopy"/>
  <UsedCommand guid="guidVSStd97" id="cmdidPaste"/>
</UsedCommands>
```

## See also
- [UsedCommands Element](../extensibility/usedcommands-element.md)
- [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
