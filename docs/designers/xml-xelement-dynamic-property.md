---
title: Xml (XElement Dynamic Property)
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-designers
ms.topic: reference
apiname:
  - "XElement.Xml"
ms.assetid: 69ab2a33-4fe7-4cfa-97f8-eaf063decb18
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Xml (XElement Dynamic Property)

Gets the unformatted XML content of the element.

## Syntax

```
elem.Xml
```

## Property Value/Return Value

A <xref:System.String> that represents the unformatted XML content of the element.

## Remarks

This property is equivalent to the <xref:System.Xml.Linq.XNode.ToString(System.Xml.Linq.SaveOptions)> method of the <xref:System.Xml.Linq.XNode?displayProperty=fullName> class, with the `SaveOptions` parameter set to <xref:System.Xml.Linq.SaveOptions>.

## See also

- [XElement Class Dynamic Properties](../designers/xelement-class-dynamic-properties.md)
- [Value](../designers/value-xelement-dynamic-property.md)