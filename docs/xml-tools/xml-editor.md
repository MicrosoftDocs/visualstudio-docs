---
title: "XML editor"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-xml-tools
ms.topic: conceptual
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# XML editor

The XML editor is based on the Visual Studio text editor, and includes additional support for the XML languages. The XML editor includes the following features:

- XML 1.0 syntax checking.

- Schema validation while you type.

- XML snippets support, including schema-generated snippets.

- Support for Document Type Definition (DTD).

- Support for XML Schema definition language (XSD) schema.

- Creating an XML Schema from an XML instance document.

- Converting a DTD or XML-Data Reduced (XDR) schema into an XML Schema.

- XSLT 1.0 syntax checking.

- Document outlining, so that elements can be expanded and collapsed.

- Integration with the [XML Schema Explorer](../xml-tools/xml-schema-explorer.md). This provides a hierarchal view of XML schemas.

The XML editor is invoked for well-known file extensions, such as .xml, .xsd, .xsl, and .config. It is also invoked on any unknown file extension if the file appears to contain XML. You can also open any file with the XML editor by using the **Open With** option and selecting the XML editor from the list.

## XSLT IntelliSense

[XSLT IntelliSense](../xml-tools/xml-editor-intellisense-features.md) allows you to auto-complete attribute set names, template modes and names, and parameter names for a specified mode or a specified named template.

## XSLT profiler

The [XSLT profiler](../xml-tools/walkthrough-xslt-profiler.md) creates detailed XSLT performance reports that help you measure, evaluate, and target performance-related problems in XSLT code. The XSLT Profiler also includes useful hints for XSL and XSLT style sheet optimizations.

## XSLT hierarchy

The [XSLT hierarchy tool](../xml-tools/walkthrough-using-xslt-hierarchy.md) allows you to add breakpoints in included style sheets and/or built-in template rules.

## See also

- [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md) provides information about the text editor.
- [XML standards reference](http://msdn.microsoft.com/79c78508-c9d0-423a-a00f-672e855de401) provides information about XML technologies, including XML, Document Type Definition (DTD), XML Schema Definition language (XSD), and XSLT.
- [XML Tools in Visual Studio](../xml-tools/xml-tools-in-visual-studio.md)