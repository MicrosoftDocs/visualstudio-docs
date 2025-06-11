---
title: Combo Element
description: "The Combo element defines commands that appear in a combo box. There are four kinds: DropDownCombo, DynamicCombo, IndexCombo, and MRUCombo."
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Combos element (VSCT XML schema)
- VSCT XML schema elements, Combos
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Combo element

Defines commands that appear in a combo box. There are four kinds of combo boxes, as follows: DropDownCombo, DynamicCombo, IndexCombo, and MRUCombo.

## Syntax

```xml
<combo guid="guidMyCommandSet" id="MyCommand" defaultWidth="20" idCommandList="MyCommandListID" priority="0x102" type="DropDownCombo">
  <Parent>... </Parent
  <CommandFlag>... </CommandFlag>
  <Strings>... </Strings>
</combo>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|guid|Required. GUID of the GUID/ID command identifier.|
|id|Required. ID of the GUID/ID command identifier.|
|defaultWidth|Required. An integer that specifies a pixel width for the combo box.|
|idCommandList|Required. An ID that is sent to the active command target to retrieve the list of items to be displayed in the combo box. The ID will be in the same GUID scope as the control.|
|priority|Optional. A numeric value that specifies the priority.|
|type|Optional. An enumerated value that specifies the type of button.<br /><br /> If not given, uses Button.<br /><br /> DropDownCombo<br /> The VSPackage is responsible for filling in the contents for this combo box. The user cannot type anything in the text box of this drop-down.<br /><br /> DynamicCombo<br /> The VSPackage is responsible for filling in the contents of this combo box. The user can edit this combo and also select items in it.<br /><br /> IndexCombo<br /> The same as DynamicCombo except that it raises the index of the item rather than its text.<br /><br /> MRUCombo<br /> Filled by the integrated development environment (IDE) on behalf of the VSPackage.  The user can edit in this combo box. The IDE remembers up to the last 16 entries per combo box.<br /><br /> When the user selects something in the combo box, or enters something new, the IDE notifies the appropriate VSPackage.|
|Condition|Optional. See [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child elements

|Element|Description|
|-------------|-----------------|
|Parent|Optional. The parent element of the button.|
|CommandFlag|Required. See [Command flag element](../extensibility/command-flag-element.md). The valid CommandFlag values for a Button are as follows.<br /><br /> - CaseSensitive<br /><br /> - CommandWellOnly<br /><br /> - DefaultDisabled<br /><br /> - DefaultInvisible<br /><br /> - DynamicVisibility<br /><br /> - FilterKeys<br /><br /> - IconAndText<br /><br /> - NoAutoComplete<br /><br /> - NoButtonCustomize<br /><br /> - NoCustomize<br /><br /> - NoKeyCustomize<br /><br /> - StretchHorizontally|
|Strings|Required. See [Strings element](../extensibility/strings-element.md). The child ButtonText element must be defined.|
|Annotation|Optional comment.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Commands element](../extensibility/commands-element.md)|Represents the collection of commands on the VSPackage toolbar.|

## Example

```xml
<Combo guid="guidWidgetPackage" id="cmdidInsertOptions"
  defaultWidth="100" idCommandList="cmdidGetInsertOptionsList">
  <CommandFlag>DynamicVisibility</CommandFlag>
  <Strings>
    <ButtonText>Select Insert Options</ButtonText>
  </Strings>
</Combo>

<Combo guid="guidWidgetPackage" id="cmdidInsertOptions"
  priority="0x0500" type="DropDownCombo" defaultWidth="100"
  idCommandList="cmdidGetInsertOptionsList">
  <Parent guid="cmdSetGuidWidgetCommands" id="groupIDFileEdit">
  <CommandFlag>DynamicVisibility</CommandFlag>
  <Strings>
    <ButtonText>Select Insert Options</ButtonText>
  </Strings>
</Combo>
```

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
