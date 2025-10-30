---
title: "Security Considerations when Working with XML Data"
description: Learn about security considerations when working with XML data in the XML editor or the XSLT debugger.
ms.date: 11/04/2016
ms.topic: article
author: dzsquared
ms.author: drskwier
manager: mijacobs
ms.subservice: xml-tools
---
# Security considerations when working with XML data

This topic discusses security issues that you need to know about when working with the XML editor or the XSLT debugger.

## XML editor

The XML editor is based on the Visual Studio Text Editor. It relies on the <xref:System.Xml> and <xref:System.Xml.Xsl> classes to handle many of the XML processes.

- XSLT transformations are executed in a new application domain. The XSLT transformations are *sandboxed*; that is, the code access security policy of your computer is used to determine the restricted permissions based on where the XSLT style sheet is located. For example, style sheets from an Internet location have the most restricted permissions, whereas style sheets copied to your hard drive run with Full Trust.

- The <xref:System.Xml.Xsl.XslCompiledTransform> class is used to compile the XSLT to Microsoft intermediate language for faster performance during execution.

- Schemas that point to an external location in the catalog file are automatically downloaded when the XML editor first loads. The <xref:System.Xml.Schema.XmlSchemaSet> class is used to compile the schemas. The catalog file that ships with the XML editor does not have links to any external schemas. The user has to explicitly add a reference to the external schema before the XML editor downloads the schema file. HTTP downloading can be disabled via the **Miscellaneous Tools Options** page for the XML editor.

- The XML editor uses the <xref:System.Net> classes to download schemas

## XSLT debugger

The XSLT debugger utilizes the Visual Studio managed debug engine and classes from the <xref:System.Xml> and <xref:System.Xml.Xsl> namespace.

- The XSLT debugger runs each XSLT transformation in a sandboxed application domain. The code access security policy of your computer is used to determine the restricted permissions based on where the XSLT style sheet is located. For example, style sheets from an Internet location have the most restricted permissions, whereas style sheets copied to your hard drive run with Full Trust.

- The XSLT style sheet is compiled using the <xref:System.Xml.Xsl.XslCompiledTransform> class.

- The XSLT expression evaluator is loaded by the managed debug engine. The managed debug engine assumes that all code is run from the user's local computer. Accordingly, the <xref:System.Xml.Xsl.XslCompiledTransform> class downloads the XSLT file to the user's local computer. The possibility that an elevation in execution privilege could occur is mitigated by executing all XSLT transformations in a new application domain with restricted permissions

## Related content

- [Application domains](/dotnet/framework/app-domains/application-domains)
