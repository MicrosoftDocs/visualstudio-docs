---
title: "Compiler Error CS0718"
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
ms.assetid: f18ea7b7-7495-4039-9876-409e9fe98ba1
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
# Compiler Error CS0718
'type': static types cannot be used as type arguments  
  
 Because a static type cannot be instantiated, it cannot be used as a generic argument. To resolve this error, remove the static type from the generic argument.  
  
## Example  
 The following sample generates CS0718:  
  
```  
// CS0718.cs  
public static class SC  
{  
    public static void F()  
    {  
    }  
}  
  
public class G<T>  
{  
}  
  
public class CMain  
{  
    public static void Main()  
    {  
        G<SC> gsc = new G<SC>();  // CS0718  
    }  
}  
```