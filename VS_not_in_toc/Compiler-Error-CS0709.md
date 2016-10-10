---
title: "Compiler Error CS0709"
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
ms.assetid: 91040f55-a060-4cc3-b830-f6b771af28d7
caps.latest.revision: 9
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
# Compiler Error CS0709
'derived class': cannot derive from static class 'base class'  
  
 A static class cannot be instantiated or derived from. That is, a static class cannot be a base class of any other class.  
  
## Example  
 The following sample generates CS0709.  
  
```  
// CS0709.cs  
// compile with: /target:library  
public static class Base {}  
public class Derived : Base {}   // CS0709  
```