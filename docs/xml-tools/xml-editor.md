---
title: XML editor
description: Learn about the XML editor in Visual Studio that is based on the text editor and includes additional support for the XML languages.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: overview
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-xml-tools
ms.workload:
- multiple
---
# XML editor

The XML editor in Visual Studio is based on the text editor and includes additional support for the XML languages. When you open an XML file in Visual Studio, it opens in the XML editor.

The XML editor includes the following features:

- XML 1.0 syntax checking.

- Schema validation while you type.

- XML snippets support, including schema-generated snippets.

- Support for Document Type Definition (DTD).

- Support for XML Schema definition language (XSD) schema.

- Creating an XML Schema from an XML instance document.

- Converting a DTD or XML-Data Reduced (XDR) schema into an XML Schema.

- XSLT syntax checking.

- Document outlining, so that elements can be expanded and collapsed.

- Integration with the [XML Schema Explorer](../xml-tools/xml-schema-explorer.md). This provides a hierarchal view of XML schemas.

The XML editor is invoked for well-known file extensions, such as *.xml*, *.xsd*, *.xsl*, and *.config*. It is also invoked on any unknown file extension if the file appears to contain XML.

## XSLT IntelliSense

[XSLT IntelliSense](../xml-tools/xml-editor-intellisense-features.md) allows you to auto-complete attribute set names, template modes and names, and parameter names for a specified mode or a specified named template.

## XSLT profiler

The [XSLT profiler](../xml-tools/xslt-profiler.md) creates detailed XSLT performance reports that help you measure, evaluate, and target performance-related problems in XSLT code. The XSLT Profiler also includes useful hints for XSL and XSLT style sheet optimizations.

## XSLT hierarchy

The [XSLT hierarchy tool](../xml-tools/walkthrough-using-xslt-hierarchy.md) allows you to add breakpoints in included style sheets and/or built-in template rules.

## See also

- [XML editor options - formatting](../ide/reference/options-text-editor-xml-formatting.md)
- [XML editor options - miscellaneous](../ide/reference/options-text-editor-xml-miscellaneous.md)
- [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md)
- [XML standards reference](/previous-versions/dotnet/netframework-4.0/ms256177(v=vs.100))
- [XML tools in Visual Studio](../xml-tools/xml-tools-in-visual-studio.md)