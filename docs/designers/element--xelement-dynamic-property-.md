---
title: "Element (XElement Dynamic Property)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "XElement.Element"
apitype: "Assembly"
ms.assetid: c6c25b8d-a1da-41ff-aeff-867ff1dcf749
caps.latest.revision: 2
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Element (XElement Dynamic Property)
Gets an indexer used to retrieve the child element instance that corresponds to the specified expanded name.  
  
## Syntax  
  
```  
elem.Element[{namespaceName}localName]  
```  
  
## Property Value/Return Value  
 An indexer of the type `XElement Item(String expandedName)`. This indexer takes an expanded name parameter and returns the corresponding \<xref:System.Xml.Linq.XElement>, or `null` if there is no element with the specified name.  
  
## Remarks  
 This property is equivalent to \<xref:System.Xml.Linq.XContainer.Element*> method of the \<xref:System.Xml.Linq.XContainer?displayProperty=fullName> class.  
  
## See Also  
 \<xref:System.Xml.Linq.XContainer.Element*?displayProperty=fullName>   
 [XElement Class Dynamic Properties](../designers/xelement-class-dynamic-properties.md)   
 [Elements](../designers/elements--xelement-dynamic-property-.md)