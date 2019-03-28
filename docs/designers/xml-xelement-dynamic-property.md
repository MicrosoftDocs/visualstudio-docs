---
title: Xml (XElement Dynamic Property)
ms.date: 11/04/2016
ms.topic: reference
apiname:
  - "XElement.Xml"
ms.assetid: 69ab2a33-4fe7-4cfa-97f8-eaf063decb18
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Xml (XElement dynamic property)

Gets the unformatted XML content of the element.

## Syntax

```xaml
elem.Xml
```

## Property value/return value

A <xref:System.String> that represents the unformatted XML content of the element.

## Remarks

This property is equivalent to the <xref:System.Xml.Linq.XNode.ToString(System.Xml.Linq.SaveOptions)> method of the <xref:System.Xml.Linq.XNode?displayProperty=fullName> class, with the `SaveOptions` parameter set to <xref:System.Xml.Linq.SaveOptions>.

## See also

- [XElement class dynamic properties](../designers/xelement-class-dynamic-properties.md)
- [Value](../designers/value-xelement-dynamic-property.md)