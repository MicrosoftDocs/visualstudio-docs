---
title: "LINQ to XML Dynamic Properties | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: 0455f47c-4a68-4f2e-a3f8-dd1d85b99012
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# LINQ to XML Dynamic Properties
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This section provides reference information about the dynamic properties in LINQ to XML. Specifically, these properties are exposed by the <xref:System.Xml.Linq.XAttribute> and <xref:System.Xml.Linq.XElement> classes, which are in the <xref:System.Xml.Linq> namespace.

 As explained in the topic [Overview of WPF Data Binding with LINQ to XML](../designers/wpf-data-binding-with-linq-to-xml-overview.md), each of the dynamic properties is equivalent to a standard public property or method in the same class. These standard members should be used for most purposes; dynamic properties are provided specifically for LINQ to XML data binding scenarios. For more information about the standard members of these classes, see the <xref:System.Xml.Linq.XAttribute> and <xref:System.Xml.Linq.XElement> reference topics.

 With respect to their resolved values, the dynamic properties in this section fall into two categories:

- Simple ones, such as the `Value` properties in the <xref:System.Xml.Linq.XAttribute> and <xref:System.Xml.Linq.XElement> classes, that resolve to a single value.

- Indexed values, such as the [Elements](../designers/elements-xelement-dynamic-property.md) and [Descendants](../designers/descendants-xelement-dynamic-property.md) properties of <xref:System.Xml.Linq.XElement>, that resolve into an indexer type. For indexer types to be resolved to the desired value or collection, an expanded name parameter must be passed to them.

  All the dynamic properties that return an indexed value of type <xref:System.Collections.Generic.IEnumerable%601> use deffered execution. For more information about deferred execution, see [Introduction to LINQ Queries (C#)](https://msdn.microsoft.com/library/37895c02-268c-41d5-be39-f7d936fa88a8).

## In This Section

|Topic|Description|
|-----------|-----------------|
|[XAttribute Class Dynamic Properties](../designers/xattribute-class-dynamic-properties.md)|Provides details about the dynamic properties exposed by the <xref:System.Xml.Linq.XAttribute> class.|
|[XElement Class Dynamic Properties](../designers/xelement-class-dynamic-properties.md)|Provides details about the dynamic properties exposed by the <xref:System.Xml.Linq.XElement> class.|

## Reference
 <xref:System.Xml.Linq>

 <xref:System.Xml.Linq.XElement?displayProperty=fullName>

 <xref:System.Xml.Linq.XAttribute?displayProperty=fullName>

## See Also
 [WPF Data Binding with LINQ to XML](../designers/wpf-data-binding-with-linq-to-xml.md)
 [WPF Data Binding with LINQ to XML Overview](../designers/wpf-data-binding-with-linq-to-xml-overview.md)
 [Introduction to LINQ Queries (C#)](https://msdn.microsoft.com/library/37895c02-268c-41d5-be39-f7d936fa88a8)
