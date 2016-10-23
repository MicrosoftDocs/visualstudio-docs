---
title: "Compiler Error CS0712"
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
ms.assetid: cde64c0c-3953-4563-8c24-8b646230bbb8
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
# Compiler Error CS0712
Cannot create an instance of the static class 'static class'  
  
 It is not possible to create instances of static classes. Static classes are designed to contain static fields and methods, but may not be instantiated.  
  
## Example  
 The following sample generates CS0712:  
  
```  
// CS0712.cs  
public static class SC  
{  
}  
  
public class CMain  
{  
    public static void Main()  
    {  
        SC sc = new SC();  // CS0712  
    }  
}  
```