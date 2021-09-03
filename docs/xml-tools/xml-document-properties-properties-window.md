---
title: XML Document Properties, Properties Window
description: Learn about the XML document properties in the Properties window that provide basic information about the active document in the XML editor.
ms.custom: SEO-VS-2020
ms.date: 03/05/2019
ms.topic: reference
ms.assetid: 9dbb34d9-02ea-4201-b445-c98a0eb0d6db
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-xml-tools
ms.workload:
- multiple
---
# XML document properties, Properties window

The **Properties** window provides basic information about the document that is active in the XML editor. The properties that are available vary depending on the type of XML document that is currently active.

> [!NOTE]
> All XML document properties are saved in the solution. As a result, you do not have to reenter these values the next time you open the solution.

**Encoding**

The character encoding for the file. Changing this property also changes the encoding attribute on the XML declaration, and vice versa. The new encoding is used to encode the file when you save the file.

**Input**

The input document associated with the XSLT style sheet. It is used by the **Start XSLT** commands, for example, **XML** > **Start XSLT Without Debugging**. A document can be selected using the browse (**...**) button.

This property is visible only when an XSLT file is open in the editor.

**Output**

The file that is generated when transforming an XML document.

If a file is not specified, a default file name is generated based on the `method` attribute on the `xsl:output` element, which determines the file extension. The default file is located in the current user's temporary directory.

**Schemas**

The schemas to use for validation. The button opens the **XSD Schemas** dialog box, which can be used to select the schemas to use.

You can also enter the path to the schemas. If multiple schemas are specified, each schema path must be enclosed in double quotes.

**Stylesheet**

The XSLT file that is used to transform the document when the **Start XSLT Debugging** and **Start XSLT Without Debugging** commands are used. If this field is blank, the editor uses the value provided in the `xml-stylesheet` processing instruction of the document or it prompts you for a filename.

When editing an XSLT file, this property can be used to specify that a different style sheet should be used when the **Start XSLT Debugging** or **Start XSLT Without Debugging** command is selected. For example, you may want to do this when you're editing a style sheet that's included in a parent style sheet.

## See also

- [XML editor](../xml-tools/xml-editor.md)
