---
title: "Compiler Error CS0720"
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
ms.assetid: 1a8e7613-6bfb-4178-a8b4-f4591316c0b8
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
# Compiler Error CS0720
'static class': cannot declare indexers in a static class  
  
 Indexers are not meaningful in static classes, since they can only be used with instances, and it is not possible to create instances of a static type.  
  
## Example  
 The following sample generates CS0720:  
  
```  
// CS0720.cs  
  
public static class Test  
{  
    public int this[int index]  // CS0720  
    {  
        get { return 1; }  
        set {}  
    }  
  
    static void Main() {}  
}  
```