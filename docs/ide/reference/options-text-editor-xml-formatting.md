---
title: Options, Text Editor, XML, Formatting
description: Learn how to use the Formatting page in the XML section to to specify how elements and attributes are formatted in your XML documents.
ms.date: 10/29/2018
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.XML.Formatting
ms.custom: "ide-ref"
author:maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: general-ide
---
# Options, Text Editor, XML, Formatting

Use the **Formatting** options page to specify how elements and attributes are formatted in your XML documents. To access XML formatting options, choose **Tools** > **Options** > **Text Editor** > **XML**, and then choose **Formatting**.

## Attributes

**Preserve manual attribute formatting**

Do not reformat attributes. This setting is the default.

> [!NOTE]
> If the attributes are on multiple lines, the editor indents each line of attributes to match the indentation of the parent element.

**Align attributes each on a separate line**

Align the second and subsequent attributes vertically to match the indentation of the first attribute. The following XML text is an example of how the attributes would be aligned:

```xml
<item id = "123-A"
      name = "hammer"
      price = "9.95">
</item>
```

## Auto Reformat

**On paste from clipboard**

Reformat XML text pasted from the clipboard.

**On completion of end tag**

Reformat the element when the end tag is completed.

## Mixed Content

**Format mixed content by default.**

Attempt to reformat mixed content, except when the content is found in an `xml:space="preserve"` scope. This setting is the default.

If an element contains a mix of text and markup, the contents are considered to be mixed content. Following is an example of an element with mixed content.

```xml
<dir>c:\data\AlphaProject\
  <file readOnly="false">test1.txt</file>
  <file readOnly="false">test2.txt</file>
</dir>
```

## See also

- [XML options - miscellaneous](options-text-editor-xml-miscellaneous.md)
- [XML tools in Visual Studio](../../xml-tools/xml-tools-in-visual-studio.md)
