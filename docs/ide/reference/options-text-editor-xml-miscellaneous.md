---
title: Options, Text Editor, XML, Miscellaneous
description: Learn how to use the Miscellaneous page in the XAML section to to change the autocompletion and schema settings for the XML Editor.
ms.date: 10/29/2018
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.XML.Miscellaneous
ms.custom: "ide-ref"
author:maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: general-ide
---
# Options, Text Editor, XML, Miscellaneous

Use the **Miscellaneous** options page to change the autocompletion and schema settings for the XML Editor. To access miscellaneous XML options, choose **Tools** > **Options** > **Text Editor** > **XML**, and then choose **Miscellaneous**.

## Auto Insert

**Close tags**

The text editor adds close tags when authoring XML elements. If an element start tag is selected, the editor inserts the matching close tag, including a matching namespace prefix. This check box is selected by default.

**Attribute quotes**

When authoring XML attributes, the editor inserts the `="` and `"` characters and positions the caret (**^**) inside the quotation marks. This check box is selected by default.

**Namespace declarations**

The editor automatically inserts namespace declarations wherever they are needed. This check box is selected by default.

**Other markup (Comments, CDATA)**

Comments, CDATA, DOCTYPE, processing instructions, and other markup is autocompleted. This check box is selected by default.

## Network

**Automatically download DTDs and schemas**

Schemas and document type definitions (DTDs) are automatically downloaded from HTTP locations. This feature uses System.Net with autoproxy server detection enabled. This check box is selected by default.

## Outlining

**Enter outlining mode when files open**

Turns on the outlining feature when a file is opened. This check box is selected by default.

## Caching

**Schemas**

Specifies the location of the schema cache. The **Browse** button opens the current schema cache location in a new window. The default location is *%VsInstallDir%\xml\Schemas*.

## See also

- [XML options - formatting](options-text-editor-xml-formatting.md)
- [XML tools in Visual Studio](../../xml-tools/xml-tools-in-visual-studio.md)
