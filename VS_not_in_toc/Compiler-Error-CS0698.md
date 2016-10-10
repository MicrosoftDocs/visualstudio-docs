---
title: "Compiler Error CS0698"
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
ms.assetid: 68211652-fdfa-4d37-9451-f0b4238f9fe6
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
# Compiler Error CS0698
A generic type cannot derive from 'class' because it is an attribute class  
  
 Any class that derives from an attribute class is an attribute. Attributes are not allowed to be generic types.  
  
 The following sample generates CS0698:  
  
```  
// CS0698.cs  
class C<T> : System.Attribute  // CS0698  
{  
}  
```