---
title: "Descendants (XElement Dynamic Property)"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9611d00f-23bf-444b-ab0c-f30701bfc13d
caps.latest.revision: 2
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Descendants (XElement Dynamic Property)
Gets an indexer used to retrieve all the descendant elements of the current element that match the specified expanded name.  
  
## Syntax  
  
```  
elem.Descendants[{namespaceName}localName]  
```  
  
## Property Value/Return Value  
 An indexer of the type `IEnumerable<XElement> Item(String expandedName)`. This indexer takes the expanded name of the specified descendant elements and returns the matching child elements in an <xref:System.Collections.IEnumerable?qualifyHint=False>`<`<xref:System.Xml.Linq.XElement?qualifyHint=False>`>` collection.  
  
## Remarks  
 This property is equivalent to the <xref:System.Xml.Linq.XContainer.Descendants(System.Xml.Linq.XName)?qualifyHint=True> method of the <xref:System.Xml.Linq.XContainer?qualifyHint=False> class.  
  
 The elements in the returned collection are in XML source document order.  
  
 This property uses deferred execution.  
  
## See Also  
 [XElement Class Dynamic Properties](../VS_IDE/XElement-Class-Dynamic-Properties.md)   
 [Elements](../VS_IDE/Elements--XElement-Dynamic-Property-.md)