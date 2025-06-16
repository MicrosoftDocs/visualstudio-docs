---
title: Button Element
description: "The Button element defines an element that the user can interact with. Buttons can be different kinds: Button, MenuButton, and SplitDropDown."
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Buttons element (VSCT XML schema)
- VSCT XML schema elements, Buttons
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Button element

Defines an element that the user can interact with. Buttons can be of different kinds: Button, MenuButton, and SplitDropDown.

## Syntax

```
<Button guid="guidMyCommandSet" id="MyCommand" priority="0x102" type="button">
  <Parent>... </Parent>
  <Icon>... </Icon>
  <CommandFlag>... </CommandFlag>
  <Strings>... </Strings>
</Button>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|guid|Required. GUID of the GUID/ID command identifier.|
|id|Required. ID of the GUID/ID command identifier.|
|priority|Optional. A numeric value that specifies the priority.|
|type|Optional. An enumerated value that specifies the kind of button.<br /><br /> If not given, uses Button.<br /><br /> Button<br /> A standard command that appears on toolbars (typically as an iconic button), menus, and context menus.<br /><br /> MenuButton<br /> A menu item that does not execute a command, but produces another menu.<br /><br /> SplitDropDown<br /> Controls, such as the Undo and Redo buttons on the standard toolbar in Microsoft Word.|
|Condition|Optional. See [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child Elements

|Element|Description|
|-------------|-----------------|
|[Parent element](../extensibility/parent-element.md)|Optional. The parent element of the button.|
|[Icon element](../extensibility/icon-element.md)|Optional. The icon associated with the button.|
|[Command flag element](../extensibility/command-flag-element.md)|Required. The valid CommandFlag values for a Button are as follows.<br /><br /> - AllowParams<br /><br /> - CommandWellOnly<br /><br /> - DefaultDisabled<br /><br /> - DefaultInvisible<br /><br /> - DontCache<br /><br /> - DynamicItemStart<br /><br /> - DynamicVisibility<br /><br /> - FixMenuController<br /><br /> - IconAndText<br /><br /> - NoButtonCustomize<br /><br /> - NoCustomize<br /><br /> - NoKeyCustomize<br /><br /> - NoShowOnMenuController<br /><br /> - Pict<br /><br /> - PostExec<br /><br /> - ProfferedCmd<br /><br /> - RouteToDocs<br /><br /> - TextCascadeUseBtn<br /><br /> - TextMenuUseButton<br /><br /> - TextChanges<br /><br /> - TextChangesButton<br /><br /> - TextContextUseButton<br /><br /> - TextMenuCtrlUseMenu<br /><br /> - TextMenuUseButton<br /><br /> - TextOnly|
|[Strings element](../extensibility/strings-element.md)|Required. The child [ButtonText element](../extensibility/buttontext-element.md) must be defined.|
|Annotation|Optional comment.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Buttons element](../extensibility/buttons-element.md)|Groups Button elements.|

## Example
 The following example defines a button in a *.vsct* file.

 ```xml
<Button guid="guidMenuTextCmdSet" id="cmdidMyCommand" priority="0x0100" type="Button">
    <Parent guid="guidMenuTextCmdSet" id="MyMenuGroup" />
    <Icon guid="guidImages" id="bmpPic1" />
    <CommandFlag>TextChanges</CommandFlag>
    <Strings>
          <CommandName>cmdidMyCommand</CommandName>
          <ButtonText>My Command name</ButtonText>
    </Strings>
</Button>
 ```

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
