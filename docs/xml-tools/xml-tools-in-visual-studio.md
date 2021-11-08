---
title: XML editor and schema designer
description: Learn about the tools in Visual Studio for working with XML, XSLT, and XML schemas, including the XML editor, XML Schema Designer, and the XSLT debugger.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: overview
f1_keywords:
- vb.xmldesigner
helpviewer_keywords:
- XML [Visual Studio], resources
- Enterprise Templates, XML and
- discovery files, XML
- server controls, XML and
- Web server controls, XML
- XSL
- XML [Visual Studio], data sources
- XML schemas
- XML [Visual Studio], SGML relationship to
- CSS, style sheets for XML
- XML [Visual Studio], .NET classes
- data [Visual Studio], XML
- classes [Visual Studio], XML
- style sheets, for XML
- Web services
- SGML, XML
- XML [Visual Studio]
- datasets [Visual Basic], XML Schemas
- XSD schemas
- XSL, style sheets
- XMLDataDocument class
ms.assetid: 1fd5de47-2d61-4180-9539-c2c4bf9ab768
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-xml-tools
ms.workload:
- multiple
---
# Overview of XML tools in Visual Studio

*Extensible Markup Language (XML)* is a markup language that provides a format for describing data. XML separates the data and its presentation by using associated style sheets such as Extensible Stylesheet Language (XSL) and cascading style sheets (CSS). Visual Studio includes tools and features that make it easier to work with XML, XSLT, and XML schemas.

## XML editor

The [XML editor](xml-editor.md) is used to edit XML documents. It provides full XML syntax checking, schema validation while you type, color-coding, and IntelliSense. If a schema or document type definition is provided, it is used by IntelliSense to list allowable elements and attributes.

Additional features include:

- XML snippet support, including schema-generated snippets

- Document outlining so that elements can be expanded and collapsed

- The ability to execute XSLT transformations and to view the results as text, XML, or HTML

- The ability to generate XML Schema definition language (XSD) schemas from the XML instance document

- Support for editing XSLT style sheets, including IntelliSense support

- XML Schema Explorer

## XML Schema Designer

The [XML Schema Designer](xml-schema-designer.md) is integrated with Visual Studio and the XML editor to enable you to work with XML schema definition language (XSD) schemas.

## XSLT debugging

Visual Studio supports [debugging XSLT style sheets](../xml-tools/debugging-xslt.md). Using the debugger, you can set break points in an XSLT style sheet, step into an XSLT style sheet from code, and so on.

> [!NOTE]
> The XSLT debugger is only available in the Enterprise edition of Visual Studio.

## See also

- <xref:System.Xml?displayProperty=fullName>
- [XSLT transformations](/dotnet/standard/data/xml/xslt-transformations)
- [Process XML data using the XPath data model](/dotnet/standard/data/xml/process-xml-data-using-the-xpath-data-model)
- [XML Document Object Model (DOM)](/dotnet/standard/data/xml/xml-document-object-model-dom)
- [XML Schema Object Model (SOM)](/dotnet/standard/data/xml/xml-schema-object-model-som)
