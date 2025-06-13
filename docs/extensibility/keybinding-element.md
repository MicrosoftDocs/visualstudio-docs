---
title: KeyBinding Element
description: The KeyBinding element specifies keyboard shortcuts for the commands. Commands can have both single and dual key bindings associated with them.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSCT XML schema elements, KeyBindings
- KeyBinding element (VSCT XML schema)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# KeyBinding element

The KeyBinding element specifies keyboard shortcuts for the commands.

 Commands can have both single and dual key bindings associated with them. An example of a single key binding is **Ctrl**+**S** for the **Save** command. Dual key bindings require two successive key combinations to trigger a command. An example of a dual key binding is **Ctrl+K**,**Ctrl+K** to set a bookmark.

## Syntax

```
<KeyBinding guid="MyGuid" id="MyId" editor="MyEditor" key1="B" key2="x" mod1="Control" mod2="Alt" />
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
|mod1|Optional. Any combination of **Control**, **Alt**, and **Shift** separated by space.|
|key2|Optional. Valid values include all typable alphanumerics, and also two-digit hexadecimal values preceded by 0x and [VK_constants](/windows/desktop/inputdev/virtual-key-codes).|
|mod2|Optional. Any combination of **Control**, **Alt**, and **Shift** separated by space.|
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
