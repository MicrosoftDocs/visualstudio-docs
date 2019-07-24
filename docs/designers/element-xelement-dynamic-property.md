---
title: Element (XElement Dynamic Property)
ms.date: 11/04/2016
ms.topic: reference
apiname:
  - "XElement.Element"
apitype: "Assembly"
ms.assetid: c6c25b8d-a1da-41ff-aeff-867ff1dcf749
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Element (XElement Dynamic Property)

Gets an indexer used to retrieve the child element instance that corresponds to the specified expanded name.

## Syntax

```xaml
elem.Element[{namespaceName}localName]
```

## Property Value/Return Value

An indexer of the type `XElement Item(String expandedName)`. This indexer takes an expanded name parameter and returns the corresponding <xref:System.Xml.Linq.XElement>, or `null` if there is no element with the specified name.

## Remarks

This property is equivalent to <xref:System.Xml.Linq.XContainer.Element%2A> method of the <xref:System.Xml.Linq.XContainer?displayProperty=fullName> class.

## See also

- <xref:System.Xml.Linq.XContainer.Element%2A?displayProperty=fullName>
- [XElement class dynamic properties](../designers/attribute-xelement-dynamic-property.md)
- [Elements](../designers/elements-xelement-dynamic-property.md)