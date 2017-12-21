---
title: "XML Tools in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vb.xmldesigner"
helpviewer_keywords: 
  - "XML [Visual Studio], resources"
  - "Enterprise Templates, XML and"
  - "discovery files, XML"
  - "server controls, XML and"
  - "Web server controls, XML"
  - "XSL"
  - "XML [Visual Studio], data sources"
  - "XML schemas"
  - "XML [Visual Studio], SGML relationship to"
  - "CSS, style sheets for XML"
  - "XML [Visual Studio], .NET Framework classes"
  - "data [Visual Studio], XML"
  - "classes [Visual Studio], XML"
  - "style sheets, for XML"
  - "Web services"
  - "SGML, XML"
  - "XML [Visual Studio]"
  - "datasets [Visual Basic], XML Schemas"
  - "XSD schemas"
  - "XSL, style sheets"
  - "XMLDataDocument class"
ms.assetid: 1fd5de47-2d61-4180-9539-c2c4bf9ab768
caps.latest.revision: 21
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# XML Tools in Visual Studio
*Extensible Markup Language (XML)* is a markup language that provides a format for describing data. This facilitates more precise declarations of content and more meaningful search results across multiple platforms. In addition, XML enables the separation of presentation from data. For example, in HTML you use tags to tell the browser to display data as bold or italic; in XML you use tags only to describe data, such as city name, temperature, and barometric pressure. In XML you use style sheets such as Extensible Stylesheet Language (XSL) and cascading style sheets (CSS) to present the data in a browser. XML separates the data from the presentation and the process. This enables you to display and process the data as you want to, by applying different style sheets and applications.  
  
 XML is a subset of SGML that is optimized for delivery over the Web. It is defined by the World Wide Web Consortium (W3C). This standardization guarantees that structured data will be uniform and independent of applications or vendors.  
  
 XML is at the core of many features of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)]. The following topic list names the tools and features related to XML that are offered in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)].  
  
 For more information, see the [XML Developer Center](http://go.microsoft.com/fwlink/?LinkID=100176), which provides the latest documentation, technical information, downloads, newsgroups, and other resources for XML developers.  
  
## In This Section  
 [Working with XML Data](../xml-tools/working-with-xml-data.md)  
 Discusses the role of XML in the way data is handled in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
 [Debugging XSLT](../xml-tools/debugging-xslt.md)  
 Provides links to topics about using the Visual Studio debugger to debug XSLT.  
  
## Reference  
 [Microsoft.VisualStudio.XmlEditor](http://go.microsoft.com/fwlink/?LinkID=165699)  
 Exposes the [XML Editor](http://go.microsoft.com/fwlink/?LinkId=228249) parse tree through [System.Xml.Linq](http://go.microsoft.com/fwlink/?LinkId=228250) for any XML documents.  
  
 [XML Standards Reference](http://msdn.microsoft.com/en-us/79c78508-c9d0-423a-a00f-672e855de401)  
 Provides information about XML technologies, including XML, Document Type Definition (DTD), XML Schema definition language (XSD), and XSLT.  
  
 <xref:System.Xml?displayProperty=fullName>  
 Describes the classes and other elements that make up the <xref:System.Xml> namespace and provides links to more detailed information on each item.  
  
 <xref:System.Xml.Serialization?displayProperty=fullName>  
 Describes the classes and other elements that make up the <xref:System.Xml.Serialization> namespace and provides links to more detailed information about each item.  
  
## Related Sections  
 [XML Document Object Model (DOM)](/dotnet/standard/data/xml/xml-document-object-model-dom)  
 Describes how the <xref:System.Xml.XmlDocument> and its associated classes comply with the W3C Document Object Model (Core) Level 1 and Level 2 namespace support specifications.  
  
 [Reading XML with the XmlReader](http://msdn.microsoft.com/en-us/3029834c-a27e-4331-b7aa-711924062182)  
 Describes how the <xref:System.Xml.XmlReader> provides noncached, forward only, read-only access to XML data over an XML stream.  
  
 [Writing XML with the XmlWriter](http://msdn.microsoft.com/en-us/ea41f72c-e1d3-4e0a-ab0f-f0eb1c27ab86)  
 Describes how the <xref:System.Xml.XmlWriter> provides noncached, forward only, way of generating XML streams and helps you build XML documents that comply with the W3C standard.  
  
 [XSLT Transformations](/dotnet/standard/data/xml/xslt-transformations)  
 Describes how the <xref:System.Xml.Xsl.XslCompiledTransform> class implements the XSLT 1.0 recommendation.  
  
 [Process XML Data Using the XPath Data Model](/dotnet/standard/data/xml/process-xml-data-using-the-xpath-data-model)  
 Describes how the <xref:System.Xml.XPath.XPathNavigator> class can process XML data stored in an <xref:System.Xml.XPath.XPathDocument> or an <xref:System.Xml.XmlDocument> object. The <xref:System.Xml.XPath.XPathNavigator> class is based on the XQuery 1.0 and XPath 2.0 Data Model and can be used to navigate and edit XML data.  
  
 [XML Schema Object Model (SOM)](/dotnet/standard/data/xml/xml-schema-object-model-som)  
 Describes the classes used for creating and manipulating XML Schemas, by providing an <xref:System.Xml.Schema.XmlSchema> class to load and edit a schema.