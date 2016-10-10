---
title: "Compiler Error CS0681"
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
ms.assetid: aa51ad94-df0a-481d-aaea-5b4291ebc41c
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
# Compiler Error CS0681
The modifier 'abstract' is not valid on fields. Try using a property instead  
  
 You cannot make a field abstract. You can, however, have an abstract property that accesses the field.  
  
## Example  
 The following sample generates CS0681:  
  
```  
// CS0681.cs  
// compile with: /target:library  
abstract class C  
{  
    abstract int num;  // CS0681  
}  
  
```  
  
## Example  
 Try the following code instead:  
  
```  
// CS0681b.cs  
// compile with: /target:library  
abstract class C  
{  
    public abstract int num  
    {  
       get;  
       set;  
    }  
}  
```