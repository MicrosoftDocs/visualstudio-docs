---
title: Descendants (XElement Dynamic Property)
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 9611d00f-23bf-444b-ab0c-f30701bfc13d
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Descendants (XElement Dynamic Property)

Gets an indexer used to retrieve all the descendant elements of the current element that match the specified expanded name.

## Syntax

```xaml
elem.Descendants[{namespaceName}localName]
```

## Property Value/Return Value

An indexer of the type `IEnumerable<XElement> Item(String expandedName)`. This indexer takes the expanded name of the specified descendant elements and returns the matching child elements in an <xref:System.Collections.IEnumerable>`<`<xref:System.Xml.Linq.XElement>`>` collection.

## Remarks

This property is equivalent to the <xref:System.Xml.Linq.XContainer.Descendants(System.Xml.Linq.XName)?displayProperty=fullName> method of the <xref:System.Xml.Linq.XContainer> class.

The elements in the returned collection are in XML source document order.

This property uses deferred execution.

## See also

- [XElement class dynamic properties](/visualstudio/designers/attribute-xelement-dynamic-property)
- [Elements](../designers/elements-xelement-dynamic-property.md)