---
title: "CLS Compliance Warning CLS01501"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 74361331-3773-48d5-8508-0113f5464a75
caps.latest.revision: 6
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
# CLS Compliance Warning CLS01501
**The varargs constraint is not part of the CLS**  
  
 The varargs constraint is not part of the Common Language Subset (CLS).  The only calling convention supported by the CLS is the standard managed calling convention.  
  
 For more information CLS compliance checking, see [CLS Compliant Assemblies](assetId:///3320b57e-ea55-4697-a17d-f509a36a3c93).  
  
 The following function declaration (using MSIL assembly language) shows what could cause CLS01501:  
  
```  
.method public specialname rtspecialname   
        instance vararg void  .ctor() cil managed  
```  
  
 You can resolve CLS01501 by using a parameter array.  See [Variable Argument Lists (...) (C++/CLI)](../Topic/Variable%20Argument%20Lists%20\(...\)%20\(C++-CLI\).md) for more information.