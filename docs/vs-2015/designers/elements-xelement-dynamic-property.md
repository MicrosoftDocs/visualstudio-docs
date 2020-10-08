---
title: "Elements (XElement Dynamic Property) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
api_name:
  - "XElement.Elements"
api_type:
  - "Assembly"
ms.assetid: 3d5737f2-d2ed-410a-821c-349dbb2b574f
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# Elements (XElement Dynamic Property)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Gets an indexer used to retrieve the child elements of the current element that match the specified expanded name.

## Syntax

```
elem.Elements[{namespaceName}localName]
```

## Property Value/Return Value
 An indexer of the type `IEnumerable<XElement> Item(String expandedName)`. This indexer takes the expanded name of the desired child elements and returns the matching child elements in an <xref:System.Collections.IEnumerable>`<`<xref:System.Xml.Linq.XElement>`>` collection.

## Remarks
 This property is equivalent to the <xref:System.Xml.Linq.XContainer.Elements%28System.Xml.Linq.XName%29?displayProperty=fullName> method of the <xref:System.Xml.Linq.XContainer> class.

 The elements in the returned collection are in XML source document order.

 This property uses deferred execution.

## See Also
 [XElement Class Dynamic Properties](../designers/xelement-class-dynamic-properties.md)
 [Element](../designers/element-xelement-dynamic-property.md)
 [Descendants](../designers/descendants-xelement-dynamic-property.md)
