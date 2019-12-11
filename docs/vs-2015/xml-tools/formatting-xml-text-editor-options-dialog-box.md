---
title: "Formatting, XML, Text Editor, Options Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-xml-tools
ms.topic: conceptual
ms.assetid: bb539b3a-027c-4b2f-906e-403e0e22ba8d
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# Formatting, XML, Text Editor, Options Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This dialog box allows you to specify the formatting settings for the XML Editor. You can access the **Options** dialog box from the **Tools** menu.

> [!NOTE]
> These settings are available when you select the **Text Editor** folder, the **XML** folder, and then the **Formatting** option from the **Options** dialog box.

## Attributes
 **Preserve manual attribute formatting**
 Attributes are not reformatted. This is the default.

> [!NOTE]
> If the attributes are on multiple lines, the editor indents each line of attributes to match the indentation of the parent element.

 **Align attributes each on their own line**
 Aligns the second and subsequent attributes vertically to match the indentation of the first attribute. The following XML text is an example of how the attributes would be aligned.

```
<item id = "123-A"
      name = "hammer"
      price = "9.95">
</item>
```

## Auto Reformat
 **On paste from the Clipboard**
 Reformats XML text pasted from the Clipboard.

 **On completion of end tag**
 Reformats the element when the end tag is completed.

## Mixed Content
 **Preserve mixed content by default**
 Determines whether the editor reformats mixed content. By default, the editor attempts to reformat mixed content, except when the content is found in an `xml:space="preserve"` scope.

 If an element contains a mix of text and markup, the contents are considered to be mixed content. The following is an example of an element with mixed content.

```
<dir>c:\data\AlphaProject\
  <file readOnly="false">test1.txt</file>
  <file readOnly="false">test2.txt</file>
</dir>
```

## See Also
 [XML Document Properties, Properties Window](../xml-tools/xml-document-properties-properties-window.md)
 [XML Editor Components](../xml-tools/xml-editor-components.md)
