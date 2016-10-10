---
title: "Compiler Error CS1732"
ms.custom: na
ms.date: 10/02/2016
ms.devlang: 
  - CSharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 72c7f7fc-d5f2-4538-9b02-50dda54d3b1e
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
# Compiler Error CS1732
Expected parameter.  
  
 This error is produced when a lambda expression contains a comma following an input parameter but does not specify the following parameter.  
  
### To correct this error  
  
1.  Either remove the comma, or add the input parameter that the compiler expects to find after the comma.  
  
## Example  
 The following example produces CS1732:  
  
```  
// cs1732.cs  
// compile with: /target:library  
class Test  
    {  
        delegate void D(int x, int y);  
        static void Main()  
        {  
        D d = (x,) => { }; // CS1732  
      }  
    }  
```