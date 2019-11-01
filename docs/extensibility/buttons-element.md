---
title: "Buttons Element | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Buttons element (VSCT XML schema)"
  - "VSCT XML schema elements, Buttons"
ms.assetid: 9f2cf94d-dec5-4776-a836-9a89c75f0c87
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Buttons element
Groups [Button](../extensibility/button-element.md) elements, which represent individual commands.

## Syntax

```
<Buttons>
  <Button>... </Button>
  <Button>... </Button>
</Buttons>
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
|[Buttons element](../extensibility/buttons-element.md)|Groups Button elements.|
|[Button element](../extensibility/button-element.md)|Defines a command that the user can interact with.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Commands element](../extensibility/commands-element.md)|Represents the collection of commands on the VSPackage toolbar.|

## Example

```
<Buttons>
  <Button guid="guidMenuAndCommandsCmdSet" id="cmdidMyCommand"     priority="0x100" type="Button">
    <Parent guid="guidMenuAndCommandsCmdSet" id="MyMenuGroup"/>
    <Icon guid="guidGenericCmdBmp" id="bmpArrow"/>
    <Strings>
      <ButtonText>C# Command Sample</ButtonText>
    </Strings>
  </Button>
</Buttons>
```

## See also
- [How VSPackages add user interface elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)
- [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md)