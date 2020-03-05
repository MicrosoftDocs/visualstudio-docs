---
title: "Options, Text Editor, XAML, Formatting | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.XAML.Formatting.General"
  - "VS.ToolsOptionsPages.Text_Editor.XAML.Miscellaneous"
  - "VS.ToolsOptionsPages.Text_Editor.XAML.Formatting.Spacing"
helpviewer_keywords:
  - "element spacing, XAML view settings"
  - "attribute spacing, XAML view settings"
  - "XAML view settings, auto-formatting events"
  - "auto-formatting events, XAML view settings"
  - "XAML view settings, tag wrapping"
  - "XAML view settings, auto insert"
  - "quotation mark style, XAML view settings"
  - "XAML formatting, WPF Designer"
  - "XAML view settings, Toolbox"
  - "XAML view settings, element spacing"
  - "default view, XAML view settings"
  - "auto insert, XAML view settings"
  - "XAML view settings, default view"
  - "XAML view settings, quotation mark style"
  - "tag wrapping, XAML view settings"
  - "WPF Designer, XAML formatting"
  - "XAML view settings, attribute spacing"
ms.assetid: ad3820b1-0d94-4807-a74c-c3467ed973a2
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# Options, Text Editor, XAML, Formatting
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Use the **Formatting** property page to specify how elements and attributes are formatted in your XAML documents. To open the **Options** dialog box, click the **Tools** menu and then click **Options**. To access the **Formatting** property page, expand the **Text Editor**, **XAML**, **Formatting** node.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

## Auto-Formatting Events
Auto-formatting may occur when any of the following events is detected.

- Completion of an end tag or simple tag.

- Completion of a start tag.

- Pasting from the clipboard.

- Formatting keyboard commands.

  You can specify which events cause auto-formatting.

|||
|-|-|
|**On completion of end tag or simple tag**|Auto-formatting occurs when you finish typing an end tag or a simple tag. A simple tag has no attributes, for example `<Button />`.|
|**On completion of start tag**|Auto-formatting occurs when you finish typing a start tag.|
|**On paste from clipboard**|Auto-formatting occurs when you paste XAML from the clipboard into XAML view.|

## Quotation Mark Style
This setting indicates whether attribute values are enclosed in single or double quotation marks. The auto-formatter and IntelliSense auto-completion both use this setting.

Once you set this option, only attributes subsequently added either using the designer or manually in the XAML view are affected.

|||
|-|-|
|**Double quotes (")**|Attribute values are enclosed in double quotes.<br /><br /> `<Button Name="button1">Hello</Button>`|
|**Single quotes (')**|Attribute values are enclosed in single quotes.<br /><br /> `<Button Name='button1'>Hello</Button>`|

## Tag Wrapping
You can specify a line length for tag wrapping. When tag wrapping is enabled, any XAML subsequently added by using the designer will be wrapped appropriately.

|||
|-|-|
|**Wrap tags that exceed specified length**|Specifies whether lines are wrapped at the line length specified by **Length**.|
|**Length**|The number of characters a line may contain. If necessary, some XAML lines might exceed the specified line length.|

## Attribute Spacing
Use this setting to control how attributes are arranged in your XAML document

|||
|-|-|
|**Preserve newlines and spaces between attributes**|New lines and spaces between attributes are not affected by auto-formatting.<br /><br /> `<Button Height="23" Name="button1"`<br /><br /> `Width="75">Hello</Button>`|
|**Insert a single space between attributes**|Attributes occupy one line, with one space separating adjacent attributes. Tag wrapping settings are applied.<br /><br /> `<Button Height="23" Name="button1" Width="75">Hello</Button>`|
|**Position each attribute on a separate line**|Each attribute occupies its own line. This is useful when many attributes are present.<br /><br /> `<Button`<br /><br /> `Height="23"`<br /><br /> `Name="button1"`<br /><br /> `Width="75">Hello</Button>`|
|**Position first attribute on same line as start tag**|When checked, the first attribute appears on the same line as the element's start tag.<br /><br /> `<Button Height="23"`<br /><br /> `Name="button1"`<br /><br /> `Width="75">Hello</Button>`|

## Element Spacing
Use this setting to control how elements are arranged in your XAML document

|                                                               |                                                                                                                                                                                       |
|---------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Preserve new lines in content**                             | Empty lines in element content are not removed.<br /><br /> `<Grid>`<br /><br /><br /><br /><br /><br /> `<Button Name="button1">Hello</Button>`<br /><br /><br /><br /> `</Grid>\`   |
| **Collapse multiple empty lines in content to a single line** | Empty lines in element content are collapsed to a single line.<br /><br /> `<Grid>`<br /><br /><br /><br /> `<Button Name="button1">Hello</Button>`<br /><br /><br /><br /> `</Grid>` |
| **Remove empty lines in content**                             | All empty lines in element content are removed.<br /><br /> `<Grid>`<br /><br /> `<Button Name="button1">Hello</Button>`<br /><br /> `</Grid>`                                        |

## Auto Insert
Use this setting to control when tags and quotes are automatically generated.

|||
|-|-|
|**Closing tags**|Specifies whether an element's closing tag is automatically generated when you close the opening tag with the greater than character (>).|
|**Attribute quotes**|Specifies whether enclosing quotes are generated when an attribute value is selected from the statement completion drop-down list.|
|**Closing braces for MarkupExtensions**|Specifies whether a markup extension's closing brace (}) is automatically generated when you type the opening brace character ({).|
|**Commas to separate MarkupExtension parameters**|Specifies whether commas are generated when you type more than one parameter in a markup extension.|

## Default View
Use this setting to control whether Design view appears when XAML documents are loaded.

|||
|-|-|
|**Always open documents in full XAML view**|Specifies whether XAML documents appear only in XAML view, without Design view. Useful for loading large documents.|

## Toolbox
Use this setting to specify whether user controls and custom controls are shown in the Toolbox.

|||
|-|-|
|**Automatically populate toolbox items**|Specifies whether user controls and custom controls in the current solution are shown in the Toolbox automatically.|

## See Also
[XAML in WPF](https://msdn.microsoft.com/library/5d858575-a83b-42df-ad3f-047ed2d6e3c8)
[How to: Change XAML View Settings](https://msdn.microsoft.com/aee87c79-ca01-4f84-8fb7-a9e47048ee47)
[XAML and Code Walkthroughs](https://msdn.microsoft.com/b3ff41a0-a2a3-4f61-b698-ac88ec8f799c)
