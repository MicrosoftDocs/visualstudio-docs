---
title: Commands Element
description: "The Commands element represents the collection of commands on the VSPackage toolbar and can have these sections: menus, groups, buttons, combos, and bitmaps."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- Commands
helpviewer_keywords:
- Commands element (VSCT XML schema)
- VSCT XML schema elements, Commands
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Commands element

Represents the collection of commands on the VSPackage toolbar. The collection can have up to five subsections, as follows: menus, groups, buttons, combos, and bitmaps.

 Each subsection child element, for example, \<Menu>, is identified by a unique command ID that is a GUID and numeric identifier pair. The GUID identifies the "command set" and is used to group logically related commands. The VSPackage should define its own command set to avoid collisions with command IDs that are defined by other VSPackages.

## Syntax

```xml
<Commands package="GuidMyPackage" >
  <Menus>... </Menus>
  <Groups>... </Groups>
  <Buttons>... </Buttons>
  <Combos>... </Combos>
  <Bitmaps>... </Bitmaps>
</Commands>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|package|A GUID that identifies the VSPackage that provides the commands.<br /><br /> For example, package="guidVsPackage1Pkg".|

### Child elements

|Element|Description|
|-------------|-----------------|
|[Menus element](../extensibility/menus-element.md)|Defines all the menus that a VSPackage implements.|
|[Groups element](../extensibility/groups-element.md)|Contains entries that define the command groups in a VSPackage.|
|[Buttons element](../extensibility/buttons-element.md)|Groups Button elements.|
|[Bitmaps element](../extensibility/bitmaps-element.md)|Groups Bitmap elements.|
|[Combos element](../extensibility/combos-element.md)|Groups Combo elements.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[CommandTable element](../extensibility/commandtable-element.md)|Defines all the elements that represent the commands that a VSPackage provides to the IDE. Possible elements are menu items, menus, toolbars, and combo boxes.|

## Example
 The following example shows how to use a [Commands Element](../extensibility/commands-element.md).

```
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
