---
title: "Descendants (XElement Dynamic Property) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-designers"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9611d00f-23bf-444b-ab0c-f30701bfc13d
caps.latest.revision: 2
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Descendants (XElement Dynamic Property)
Gets an indexer used to retrieve all the descendant elements of the current element that match the specified expanded name.  
  
## Syntax  
  
```  
elem.Descendants[{namespaceName}localName]  
```  
  
## Property Value/Return Value  
 An indexer of the type `IEnumerable<XElement> Item(String expandedName)`. This indexer takes the expanded name of the specified descendant elements and returns the matching child elements in an <xref:System.Collections.IEnumerable>`<`<xref:System.Xml.Linq.XElement>`>` collection.  
  
## Remarks  
 This property is equivalent to the <xref:System.Xml.Linq.XContainer.Descendants(System.Xml.Linq.XName)?displayProperty=fullName> method of the <xref:System.Xml.Linq.XContainer> class.  
  
 The elements in the returned collection are in XML source document order.  
  
 This property uses deferred execution.  
  
## See Also  
 [XElement Class Dynamic Properties](../designers/xelement-class-dynamic-properties.md)   
 [Elements](../designers/elements-xelement-dynamic-property.md)