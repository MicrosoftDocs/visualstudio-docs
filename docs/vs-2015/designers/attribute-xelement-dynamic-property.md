---
title: "Attribute (XElement Dynamic Property) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: 8440fc7d-b3b4-4726-8ec8-492e6af79642
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# Attribute (XElement Dynamic Property)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Gets an indexer used to retrieve the attribute instance that corresponds to the specified expanded name.

## Syntax

```
elem.Attribute[{namespaceName}attribName]
```

## Property Value/Return Value
 An indexer of the type `XAttribute Item(String expandedName)`. This indexer takes the expanded name of the specified attribute and returns the corresponding <xref:System.Xml.Linq.XAttribute>, or `null` if there is no attribute with the specified name.

## Remarks
 This property is equivalent to the <xref:System.Xml.Linq.XElement.Attribute%2A> method of the <xref:System.Xml.Linq.XElement?displayProperty=fullName> class.

## See Also
 <xref:System.Xml.Linq.XElement.Attribute%2A?displayProperty=fullName>
 [XElement Class Dynamic Properties](../designers/xelement-class-dynamic-properties.md)
 [Value](../designers/value-xattribute-dynamic-property.md)
