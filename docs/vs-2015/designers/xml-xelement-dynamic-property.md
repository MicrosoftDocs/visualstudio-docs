---
title: "Xml (XElement Dynamic Property) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
api_name:
  - "XElement.Xml"
ms.assetid: 69ab2a33-4fe7-4cfa-97f8-eaf063decb18
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# Xml (XElement Dynamic Property)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Gets the unformatted XML content of the element.

## Syntax

```
elem.Xml
```

## Property Value/Return Value
 A <xref:System.String> that represents the unformatted XML content of the element.

## Remarks
 This property is equivalent to the <xref:System.Xml.Linq.XNode.ToString%28System.Xml.Linq.SaveOptions%29> method of the <xref:System.Xml.Linq.XNode?displayProperty=fullName> class, with the `SaveOptions` parameter set to <xref:System.Xml.Linq.SaveOptions>.

## See Also
 [XElement Class Dynamic Properties](../designers/xelement-class-dynamic-properties.md)
 [Value](../designers/value-xelement-dynamic-property.md)
