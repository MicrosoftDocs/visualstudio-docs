---
title: "Value (XAttribute Dynamic Property)"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - XAttribute.Value
apitype: Assembly
ms.assetid: 019733d2-e050-4120-b537-831cd3fc008e
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
# Value (XAttribute Dynamic Property)
Gets or sets the value of the XML attribute.  
  
## Syntax  
  
```  
attrib.Value   
```  
  
## Property Value/Return Value  
 A <xref:System.String?qualifyHint=False> containing the value of this attribute.  
  
## Exceptions  
  
|Exception type|Condition|  
|--------------------|---------------|  
|<xref:System.ArgumentNullException?qualifyHint=False>|When setting, the `value` is `null`.|  
  
## Remarks  
 This property is equivalent to the <xref:System.Xml.Linq.XAttribute.Value?qualifyHint=False> property of the <xref:System.Xml.Linq.XAttribute?qualifyHint=True> class, but this dynamic property also supports change notifications.  
  
## See Also  
 <xref:System.Xml.Linq.XAttribute.Value?qualifyHint=True>   
 [XAttribute Class Dynamic Properties](../VS_IDE/XAttribute-Class-Dynamic-Properties.md)   
 [Attribute](../VS_IDE/Attribute--XElement-Dynamic-Property-.md)