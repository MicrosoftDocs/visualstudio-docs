---
title: KeyBinding Element | Microsoft Docs
description: The KeyBinding element specifies keyboard shortcuts for the commands. Commands can have both single and dual key bindings associated with them.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSCT XML schema elements, KeyBindings
- KeyBinding element (VSCT XML schema)
ms.assetid: e55a1098-15df-42a9-9f87-e3a99cf437dd
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# KeyBinding element
The KeyBinding element specifies keyboard shortcuts for the commands.

 Commands can have both single and dual key bindings associated with them. An example of a single key binding is **Ctrl**+**S** for the **Save** command. Dual key bindings require two successive key combinations to trigger a command. An example of a dual key binding is <strong>Ctrl*+</strong>K<strong>,</strong>Ctrl<strong>+</strong>K** to set a bookmark.

## Syntax

```
<Keybinding guid="MyGuid" id="MyId" Editor="MyEditor" key1="B" key2="x" mod1="Control" mod2="Alt" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|guid|Required.|
|id|Required.|
|editor|Required. The editor GUID indicates the editing context for which this keyboard shortcut will be active. The global binding scope value is "guidVSStd97".|
|key1|Required. Valid values include all typable alphanumerics, and also two-digit hexadecimal values preceded by 0x and [VK_constants](/windows/desktop/inputdev/virtual-key-codes).|
|mod1|Optional. Any combination of **Ctrl**, **Alt**, and **Shift** separated by space.|
|key2|Optional. Valid values include all typable alphanumerics, and also two-digit hexadecimal values preceded by 0x and [VK_constants](/windows/desktop/inputdev/virtual-key-codes).|
|mod2|Optional. Any combination of **Ctrl**, **Alt**, and **Shift** separated by space.|
|emulator|Optional.|
|Condition|Optional. See [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child elements

|Element|Description|
|-------------|-----------------|
|Parent||
|Annotation||

### Parent elements

|Element|Description|
|-------------|-----------------|
|[KeyBindings element](../extensibility/keybindings-element.md)|Groups KeyBinding elements and other KeyBindings groupings.|

## Example

```
<KeyBindings>
  <KeyBinding guid="guidWidgetPackage" id="cmdidUpdateWidget"
    editor="guidWidgetEditor" key1="VK_F5"/>
  <KeyBinding guid="guidWidgetPackage" id="cmdidRunWidget"
    editor="guidWidgetEditor" key1="VK_F5" mod1="Control"/>
</KeyBindings>
```

## See also
- [KeyBindings element](../extensibility/keybindings-element.md)
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
