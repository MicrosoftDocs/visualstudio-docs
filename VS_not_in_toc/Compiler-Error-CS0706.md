---
title: "Compiler Error CS0706"
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
ms.assetid: bc3ac5c0-8c96-43c8-b10a-69bd31b38e4a
caps.latest.revision: 11
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
# Compiler Error CS0706
Invalid constraint type. A type used as a constraint must be an interface, a non-sealed class or a type parameter.  
  
 This error occurs when an invalid construct is used in a constraint clause. To avoid this error, use an interface or non-sealed class instead of the construct that caused the error.  
  
## Example  
 The following sample generates CS0706.  
  
```  
// CS0706.cs  
// compile with: /target:library  
class A {}  
class C<T> where T : int[] {}  // CS0706  
class D<T> where T : A {}  // OK  
```