---
title: "VbStrConv.Wide and VbStrConv.Narrow cannot be combined"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a53b4e6a-36b1-4e36-b2c5-8196313ec599
caps.latest.revision: 8
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
# VbStrConv.Wide and VbStrConv.Narrow cannot be combined
Your application is trying to combine the `VbStrConv` enumeration members `Wide` and `Narrow`, which are mutually exclusive.  
  
### To correct this error  
  
1.  Remove either `VbStrConv.Wide` or `VbStrConv.Narrow`.  
  
## See Also  
 <xref:System.Globalization?qualifyHint=False>   
 [NOTINBUILD VbStrConv Enumeration](assetId:///59f83dd9-6361-47df-a836-02ba9d4cb936)   
 [Introduction to International Applications Based on the .NET Framework](../VS_IDE/Introduction-to-International-Applications-Based-on-the-.NET-Framework.md)