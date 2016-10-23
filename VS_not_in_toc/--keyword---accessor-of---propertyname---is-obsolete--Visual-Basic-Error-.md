---
title: "&#39;&lt;keyword&gt;&#39; accessor of &#39;&lt;propertyname&gt;&#39; is obsolete (Visual Basic Error)"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f1fa965e-090c-49f3-ab1e-cbb2f9b2a5f0
caps.latest.revision: 10
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# &#39;&lt;keyword&gt;&#39; accessor of &#39;&lt;propertyname&gt;&#39; is obsolete (Visual Basic Error)
A statement attempts to read or write a property for which the corresponding procedure has been marked with the <xref:System.ObsoleteAttribute?qualifyHint=False> attribute and the directive to treat it as an error.  
  
 You can mark any programming element as being no longer in use by applying <xref:System.ObsoleteAttribute?qualifyHint=False> to it. If you do this, you can set the attribute's <xref:System.ObsoleteAttribute.IsError?qualifyHint=False> property to either `True` or `False`. If you set it to `True`, the compiler treats an attempt to use the element as an error. If you set it to `False`, or let it default to `False`, the compiler issues a warning if there is an attempt to use the element.  
  
 **Error ID:** BC30912  
  
### To correct this error  
  
1.  Ensure that the source-code reference is spelling the property name correctly.  
  
2.  Avoid accessing the property in the way (reading or writing) that generated this message.  
  
## See Also  
 [NOT IN BUILD: Attributes Used in Visual Basic](assetId:///22231318-8a40-49af-9245-e0aab723563b)   
 [NOT IN BUILD: Application of Attributes](assetId:///2b1703ed-4437-49b3-bc0b-568094324f47)   
 [Property Procedures](../Topic/Property%20Procedures%20\(Visual%20Basic\).md)