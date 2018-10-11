---
title: "Descendants (XElement Dynamic Property) | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9611d00f-23bf-444b-ab0c-f30701bfc13d
caps.latest.revision: 4
author: gewarren
ms.author: gewarren
manager: "ghogen"
---
# Descendants (XElement Dynamic Property)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Gets an indexer used to retrieve all the descendant elements of the current element that match the specified expanded name.  
  
## Syntax  
  
```  
elem.Descendants[{namespaceName}localName]  
```  
  
## Property Value/Return Value  
 An indexer of the type `IEnumerable<XElement> Item(String expandedName)`. This indexer takes the expanded name of the specified descendant elements and returns the matching child elements in an <xref:System.Collections.IEnumerable>`<`<xref:System.Xml.Linq.XElement>`>` collection.  
  
## Remarks  
 This property is equivalent to the <xref:System.Xml.Linq.XContainer.Descendants%28System.Xml.Linq.XName%29?displayProperty=fullName> method of the <xref:System.Xml.Linq.XContainer> class.  
  
 The elements in the returned collection are in XML source document order.  
  
 This property uses deferred execution.  
  
## See Also  
 [XElement Class Dynamic Properties](../designers/xelement-class-dynamic-properties.md)   
 [Elements](../designers/elements-xelement-dynamic-property.md)



