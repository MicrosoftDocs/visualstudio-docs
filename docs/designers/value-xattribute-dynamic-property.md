---
title: Value (XAttribute Dynamic Property)
ms.date: "11/04/2016"
ms.technology: vs-ide-designers
ms.topic: "conceptual"
apiname:
  - "XAttribute.Value"
apitype: "Assembly"
ms.assetid: 019733d2-e050-4120-b537-831cd3fc008e
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Value (XAttribute Dynamic Property)
Gets or sets the value of the XML attribute.

## Syntax

```
attrib.Value
```

## Property Value/Return Value
 A <xref:System.String> containing the value of this attribute.

## Exceptions

|Exception type|Condition|
|--------------------|---------------|
|<xref:System.ArgumentNullException>|When setting, the `value` is `null`.|

## Remarks
 This property is equivalent to the <xref:System.Xml.Linq.XAttribute.Value%2A> property of the <xref:System.Xml.Linq.XAttribute?displayProperty=fullName> class, but this dynamic property also supports change notifications.

## See Also
 <xref:System.Xml.Linq.XAttribute.Value%2A?displayProperty=fullName>
 [XAttribute Class Dynamic Properties](../designers/xattribute-class-dynamic-properties.md)
 [Attribute](../designers/attribute-xelement-dynamic-property.md)