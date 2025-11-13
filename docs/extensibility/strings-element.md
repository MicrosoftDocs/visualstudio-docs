---
title: Strings Element
description: The Strings element contains a ButtonText child element and other optional child elements. An ampersand in the text string specifies a keyboard shortcut.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Strings element (VSCT XML schema)
- VSCT XML schema elements, Strings
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Strings Element

The Strings element must contain at least a **ButtonText** child element. All other child elements are optional. Invalid XML characters such as '&' and '<' must be coded as entities ('&amp;' and '&lt;' and so on).

 An ampersand in the text string specifies the keyboard shortcut for the command.

## Syntax

```
<Strings>
  <ButtonText>... </ButtonText>
  <CommandName>... </CommandName>
</Strings>
```

## Attributes and Elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|language|Optional. Language=".".|

### Child Elements

|Element|Description|
|-------------|-----------------|
|ButtonText|This field and the five following text fields in a command definition let you specify the text that appears in various menus. By default, the `ButtonText` field appears in menu controllers. The `ButtonText` field also becomes the default if the other text fields are blank. The `ButtonText` field cannot be blank even if the other text fields are specified.|
|ToolTipText|The `ToolTipText` field specifies the text that appears in the tooltip for a menu item.<br /><br /> If the `ToolTipText` field is blank, the `ButtonText` field is used.|
|MenuText|The `MenuText` field specifies the text that is displayed for a command if it is on the main menu, a toolbar, in a shortcut menu, or in a submenu. If the `MenuText` field is blank, the integrated development environment (IDE) uses the `ButtonText` field. The `MenuText` field can also be used for localization.<br /><br /> For shortcut menus, the `MenuText` field is the name that is displayed in the Shortcut Menus toolbar, which enables customization of shortcut menus in the IDE. Therefore, be specific in what you name your shortcut menu; for example, use "Widget Package Shortcut Menu" instead of "Shortcut".<br /><br /> If the `MenuText` field is not specified, the `ButtonText` field is used.|
|CommandName|The `CommandName` field specifies the text that appears in the keyboard category in the **Commands** tab in the **Customize** dialog box (available by clicking **Customize** on the **Tools** menu).|
|CanonicalName|The English `CanonicalName` field specifies the name of the command in English text that can be entered in the **Command** window to execute the menu item. The IDE strips out any characters that are not letters, digits, underscores, or embedded periods. This text is then concatenated to the `ButtonText` field to define the command. For example, **New Project** on the **File** menu becomes the command, File.NewProject.<br /><br /> If the English `CanonicalName` field is not specified, the IDE uses the `ButtonText` field, and strips out all except letters, digits, underscores, and embedded periods. For example, the Button Text "&Define Commands..." becomes DefineCommands, where the ampersand, the space, and the ellipsis are removed.<br /><br /> If the `TextChanges` flag is specified and the text of the command is changed, the corresponding command recognized by the **Command** window does not change; it remains the canonical form of the original `ButtonText` or English `CanonicalName` fields.|
|LocCanonicalName|The `LocCanonicalName` field behaves identically to the English `CanonicalName` field but enables localized command text to be specified. Both canonical fields can be specified. Because the IDE just parses text entered in the **Command** window and associates it with a command, both English and non-English text can be associated with the same command.|

### Parent Elements

|Element|Description|
|-------------|-----------------|
|[Button Element](../extensibility/button-element.md)|Defines an element that the user can interact with.|
|[Menu Element](../extensibility/menu-element.md)|Defines a single menu item.|
|[Combo Element](../extensibility/combo-element.md)|Defines commands that appear in a combo box.|

## See also
- [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
