---
title: Options, Text Editor, XAML, Formatting
description: Learn how to use the Formatting options page and its subpages to set options for formatting code in the code editor when you are programming in XAML.
ms.date: 10/29/2018
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.XAML.Formatting.General
- VS.ToolsOptionsPages.Text_Editor.XAML.Formatting.Spacing
helpviewer_keywords:
- element spacing, XAML view settings
- attribute spacing, XAML view settings
- XAML view settings, auto-formatting events
- auto-formatting events, XAML view settings
- XAML view settings, tag wrapping
- XAML view settings, auto insert
- quotation mark style, XAML view settings
- XAML formatting, WPF Designer
- XAML view settings, Toolbox
- XAML view settings, element spacing
- default view, XAML view settings
- auto insert, XAML view settings
- XAML view settings, default view
- XAML view settings, quotation mark style
- tag wrapping, XAML view settings
- WPF Designer, XAML formatting
- XAML view settings, attribute spacing
ms.custom: "ide-ref"
author:maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: general-ide
---
# Options, Text Editor, XAML, Formatting

Use the **Formatting** property page to specify how elements and attributes are formatted in your XAML documents. To open the **Options** dialog box, click the **Tools** menu and then click **Options**. To access the **Formatting** property page, expand the **Text Editor** > **XAML** > **Formatting** node.

## Auto-Formatting Events

Autoformatting may occur when any of the following events is detected.

- Completion of an end tag or simple tag.

- Completion of a start tag.

- Pasting from the clipboard.

- Formatting keyboard commands.

You can specify which events cause autoformatting.

**On completion of end tag or simple tag**

Autoformatting occurs when you finish typing an end tag or a simple tag. A simple tag has no attributes, for example `<Button />`.

**On completion of start tag**

Autoformatting occurs when you finish typing a start tag.

**On paste from clipboard**

Autoformatting occurs when you paste XAML from the clipboard into XAML view.

## Quotation Mark Style

This setting indicates whether attribute values are enclosed in single or double quotation marks. The autoformatter and IntelliSense autocompletion both use this setting.

Once you set this option, only attributes subsequently added either using the designer or manually in the XAML view are affected.

**Double quotes (")**

Attribute values are enclosed in double quotes.
`<Button Name="button1">Hello</Button>`

**Single quotes (')**

Attribute values are enclosed in single quotes.
`<Button Name='button1'>Hello</Button>`

## Tag Wrapping

You can specify a line length for tag wrapping. When tag wrapping is enabled, any XAML subsequently added by using the designer will be wrapped appropriately.

**Wrap tags that exceed specified length**

Specifies whether lines are wrapped at the line length specified by **Length**.

**Length**

The number of characters a line may contain. If necessary, some XAML lines might exceed the specified line length.

## Attribute Spacing

Use this setting to control how attributes are arranged in your XAML document

**Preserve newlines and spaces between attributes**

New lines and spaces between attributes are not affected by autoformatting.

```xml
<Button Height="23"   Name="button1"
Width="75">Hello</Button>
```

**Insert a single space between attributes**

Attributes occupy one line, with one space separating adjacent attributes. Tag wrapping settings are applied.

```xml
<Button Height="23" Name="button1" Width="75">Hello</Button>
```

**Position each attribute on a separate line**

Each attribute occupies its own line, which is useful when many attributes are present.

```xml
<Button
Height="23"
Name="button1"
Width="75">Hello</Button>
```

**Position first attribute on same line as start tag**

When checked, the first attribute appears on the same line as the element's start tag.

```xml
<Button Height="23"
Name="button1"
Width="75">Hello</Button>
```

## Element Spacing

Use this setting to control how elements are arranged in your XAML document.

**Preserve new lines in content**

Empty lines in element content are not removed.

```xml
<Grid>

<Button Name="button1">Hello</Button>

</Grid>
```

**Collapse multiple empty lines in content to a single line**

Empty lines in element content are collapsed to a single line.

```xml
<Grid>

<Button Name="button1">Hello</Button>

</Grid>
```

**Remove empty lines in content**

All empty lines in element content are removed.

```xml
<Grid>
<Button Name="button1">Hello</Button>
</Grid>
```

## See also

- [XAML in WPF](/dotnet/framework/wpf/advanced/xaml-in-wpf)
