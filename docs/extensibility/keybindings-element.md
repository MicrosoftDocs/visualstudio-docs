---
title: "KeyBindings Element | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "KeyBindings"
helpviewer_keywords:
  - "VSCT XML schema elements, KeyBindings"
  - "KeyBindings element (VSCT XML schema)"
ms.assetid: 26a15d5c-ddea-4977-af7f-d795ff09c7ad
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# KeyBindings element
The KeyBindings element groups KeyBinding elements and other KeyBindings groupings.

## Syntax

```xml
<KeyBindings>
  <KeyBinding>... </KeyBinding>
  <KeyBinding>... </KeyBinding>
</KeyBindings>
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
|[KeyBinding element](../extensibility/keybinding-element.md)|Specifies keyboard shortcuts for the commands.|
|[KeyBindings](../extensibility/keybindings-element.md)|Groups KeyBinding elements and other KeyBindings groupings.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[CommandTable element](../extensibility/commandtable-element.md)|Defines all the elements that represent commands.|

## Example

```xml
<KeyBindings>
  <KeyBinding guid="guidWidgetPackage" id="cmdidUpdateWidget"
    editor="guidWidgetEditor" key1="VK_F5"/>
  <KeyBinding guid="guidWidgetPackage" id="cmdidRunWidget"
    editor="guidWidgetEditor" key1="VK_F5" mod1="Control"/>
</KeyBindings>
```

## See also
- [KeyBinding element](../extensibility/keybinding-element.md)
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)