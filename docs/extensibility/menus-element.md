---
title: "Menus Element | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "VSCT XML schema elements, Menus"
  - "Menus element (VSCT XML schema)"
ms.assetid: d825a99b-e05c-4dd9-8933-a180216d667a
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Menus element
Defines all the menus and toolbars that a VSPackage implements.

## Syntax

```xml
<Menus>
  <Menu>... </Menu>
  <Menu>... </Menu>
</Menus>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|Condition|Optional. See [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child Elements

|Element|Description|
|-------------|-----------------|
|[Menus element](../extensibility/menus-element.md)|Defines all the menus and toolbars that a VSPackage implements.|
|[Menu element](../extensibility/menu-element.md)|Represents a single menu or toolbar.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Commands element](../extensibility/commands-element.md)|Represents the collection of commands in the VSPackage.|

## Example

```xml
<Commands package="guidMyPackage">
    <Menus>
      <Menu Condition="'%(DEBUG)' != 'true'"
        guid="cmdSetGuidMyProductCommands" id="menuIDMainMenu"
        priority="0x0000" type="Menu">
        <Annotation>
          <Documentation>this is an annotation</Documentation>
          <AppInfo>
            <CustomData>
              <CustomSubElement>Some data</CustomSubElement>
            </CustomData>
          </AppInfo>
        </Annotation>
        <CommandFlag>AlwaysCreate</CommandFlag>
        <Strings>
          <ButtonText>MainMenu</ButtonText>
        </Strings>
      </Menu>
  </Menus>
<Commands>
```

## See also
- [How VSPackages add user interface elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)
- [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md)