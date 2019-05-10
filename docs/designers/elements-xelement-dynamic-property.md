---
title: Elements (XElement Dynamic Property)
ms.date: 11/04/2016
ms.topic: reference
apiname:
  - "XElement.Elements"
apitype: "Assembly"
ms.assetid: 3d5737f2-d2ed-410a-821c-349dbb2b574f
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Elements (XElement Dynamic Property)

Gets an indexer used to retrieve the child elements of the current element that match the specified expanded name.

## Syntax

```xaml
elem.Elements[{namespaceName}localName]
```

## Property Value/Return Value

An indexer of the type `IEnumerable<XElement> Item(String expandedName)`. This indexer takes the expanded name of the desired child elements and returns the matching child elements in an <xref:System.Collections.IEnumerable>`<`<xref:System.Xml.Linq.XElement>`>` collection.

## Remarks

This property is equivalent to the <xref:System.Xml.Linq.XContainer.Elements(System.Xml.Linq.XName)?displayProperty=fullName> method of the <xref:System.Xml.Linq.XContainer> class.

The elements in the returned collection are in XML source document order.

This property uses deferred execution.

## See also

- [XElement class dynamic properties](../designers/attribute-xelement-dynamic-property.md)
- [Element](../designers/element-xelement-dynamic-property.md)
- [Descendants](../designers/descendants-xelement-dynamic-property.md)