---
title: "Compiler Error CS1629"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - CSharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 907eae46-0265-4cd0-b27b-ff555d004259
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
# Compiler Error CS1629
Unsafe code may not appear in iterators  
  
 The C# language specification does not allow unsafe code in iterators.  
  
 The following sample generates CS1629:  
  
```  
// CS1629.cs  
// compile with: /unsafe    
using System.Collections.Generic;  
class C   
{  
   IEnumerator<int> IteratorMeth() {  
      int i;  
      unsafe  // CS1629  
      {  
         int *p = &i;  
         yield return *p;  
      }  
   }  
}  
```