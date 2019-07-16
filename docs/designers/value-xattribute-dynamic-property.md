---
title: Value (XAttribute Dynamic Property)
ms.date: 11/04/2016
ms.topic: reference
apiname:
  - "XAttribute.Value"
apitype: "Assembly"
ms.assetid: 019733d2-e050-4120-b537-831cd3fc008e
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Value (XAttribute Dynamic Property)

Gets or sets the value of the XML attribute.

## Syntax

```xaml
attrib.Value
```

## Property value/return value

A <xref:System.String> containing the value of this attribute.

## Exceptions

|Exception type|Condition|
| - |---------------|
|<xref:System.ArgumentNullException>|When setting, the `value` is `null`.|

## Remarks

This property is equivalent to the <xref:System.Xml.Linq.XAttribute.Value%2A> property of the <xref:System.Xml.Linq.XAttribute?displayProperty=fullName> class, but this dynamic property also supports change notifications.

## See also

- <xref:System.Xml.Linq.XAttribute.Value%2A?displayProperty=fullName>
- [XAttribute class dynamic properties](../designers/value-xattribute-dynamic-property.md)
- [Attribute](../designers/attribute-xelement-dynamic-property.md)