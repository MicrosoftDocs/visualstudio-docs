---
title: "Conflict between the default property and the &#39;DefaultMemberAttribute&#39; defined on &#39;|1&#39;"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 42803d13-ff1d-40ed-a4a8-269e2fb4aa01
caps.latest.revision: 7
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
# Conflict between the default property and the &#39;DefaultMemberAttribute&#39; defined on &#39;|1&#39;
A class, structure, or interface declares a default property with the [Default](../Topic/Default%20\(Visual%20Basic\).md) keyword but also applies the <xref:System.Reflection.DefaultMemberAttribute?qualifyHint=False> to designate a different member as the default member.  
  
 A type can have at most one default member. When you declare a default property, Visual Basic automatically applies the <xref:System.Reflection.DefaultMemberAttribute?qualifyHint=False> to the class, structure, or interface designating that property.  
  
 **Error ID:** BC32304  
  
### To correct this error  
  
1.  Decide which member should be the default member of the class, structure, or interface.  
  
2.  Remove the conflicting declaration (either the `Default` keyword or the <xref:System.Reflection.DefaultMemberAttribute?qualifyHint=False>).  
  
## See Also  
 <xref:System.Reflection.DefaultMemberAttribute?qualifyHint=False>   
 [Default](../Topic/Default%20\(Visual%20Basic\).md)   
 [NOT IN BUILD: Default Properties](assetId:///a70f2a27-8176-4858-935e-f25afdd43ab5)   
 [How to: Declare and Call a Default Property in Visual Basic](../Topic/How%20to:%20Declare%20and%20Call%20a%20Default%20Property%20in%20Visual%20Basic.md)