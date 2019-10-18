---
title: "Element (XElement Dynamic Property) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
api_name:
  - "XElement.Element"
api_type:
  - "Assembly"
ms.assetid: c6c25b8d-a1da-41ff-aeff-867ff1dcf749
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# Element (XElement Dynamic Property)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Gets an indexer used to retrieve the child element instance that corresponds to the specified expanded name.

## Syntax

```
elem.Element[{namespaceName}localName]
```

## Property Value/Return Value
 An indexer of the type `XElement Item(String expandedName)`. This indexer takes an expanded name parameter and returns the corresponding <xref:System.Xml.Linq.XElement>, or `null` if there is no element with the specified name.

## Remarks
 This property is equivalent to <xref:System.Xml.Linq.XContainer.Element%2A> method of the <xref:System.Xml.Linq.XContainer?displayProperty=fullName> class.

## See Also
 <xref:System.Xml.Linq.XContainer.Element%2A?displayProperty=fullName>
 [XElement Class Dynamic Properties](../designers/xelement-class-dynamic-properties.md)
 [Elements](../designers/elements-xelement-dynamic-property.md)
