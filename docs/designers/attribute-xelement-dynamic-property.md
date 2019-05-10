---
title: Attribute (XElement Dynamic Property)
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 8440fc7d-b3b4-4726-8ec8-492e6af79642
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Attribute (XElement Dynamic Property)

Gets an indexer used to retrieve the attribute instance that corresponds to the specified expanded name.

## Syntax

```xaml
elem.Attribute[{namespaceName}attribName]
```

## Property Value/Return Value

An indexer of the type `XAttribute Item(String expandedName)`. This indexer takes the expanded name of the specified attribute and returns the corresponding <xref:System.Xml.Linq.XAttribute>, or `null` if there is no attribute with the specified name.

## Remarks

This property is equivalent to the <xref:System.Xml.Linq.XElement.Attribute%2A> method of the <xref:System.Xml.Linq.XElement?displayProperty=fullName> class.

## See also

- <xref:System.Xml.Linq.XElement.Attribute%2A?displayProperty=fullName>
- [XElement Class Dynamic Properties](/visualstudio/designers/attribute-xelement-dynamic-property)
- [Value](../designers/value-xattribute-dynamic-property.md)