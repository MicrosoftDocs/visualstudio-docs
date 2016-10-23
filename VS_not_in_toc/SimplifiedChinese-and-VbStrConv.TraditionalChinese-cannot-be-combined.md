---
title: "SimplifiedChinese and VbStrConv.TraditionalChinese cannot be combined"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d8e6a11b-f549-43b5-8337-0594340e1325
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
# SimplifiedChinese and VbStrConv.TraditionalChinese cannot be combined
Your application is attempting to combine the `VbStrConv` enumeration members `SimplifiedChinese` and `TraditionalChinese`, which are mutually exclusive.  
  
### To correct this error  
  
-   Remove either `VbStrConv.SimplifiedChinese` or `VbStrConv.TraditionalChinese`.  
  
## See Also  
 <xref:System.Globalization?qualifyHint=False>   
 [NOTINBUILD VbStrConv Enumeration](assetId:///59f83dd9-6361-47df-a836-02ba9d4cb936)   
 [Introduction to International Applications Based on the .NET Framework](../VS_IDE/Introduction-to-International-Applications-Based-on-the-.NET-Framework.md)