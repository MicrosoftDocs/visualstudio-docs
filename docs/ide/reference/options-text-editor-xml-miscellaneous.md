---
title: Options, Text Editor, XML, Miscellaneous
ms.date: 10/29/2018
ms.prod: visual-studio-dev15
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.XML.Miscellaneous"
ms.assetid: b6538cbe-badd-4313-a1fb-39e906736bbe
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Options, Text Editor, XML, Miscellaneous

Use the **Miscellaneous** property page to change the autocompletion and schema settings for the XML Editor. To open the **Options** dialog box, click the **Tools** menu and then click **Options**. To access the **Miscellaneous** property page, expand the **Text Editor** > **XML** > **Miscellaneous** node.

## Auto Insert

**Close tags**

The Text Editor adds close tags when authoring XML elements. If an element start tag is selected, the editor inserts the matching close tag, including a matching namespace prefix. This check box is selected by default.

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

Specifies the location of the schema cache. The Browse button (...) opens the current schema cache location in a new window. The default location is *\<Management Studio install directory>*\Xml\Schemas.

## See also

- [How to: Create XML documentation (Visual Basic)](/dotnet/visual-basic/programming-guide/program-structure/how-to-create-xml-documentation)
- [Code generation](../code-generation-in-visual-studio.md)