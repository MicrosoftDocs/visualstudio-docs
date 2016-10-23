---
title: "Compiler Error CS0722"
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
ms.assetid: 85f6854c-581d-482b-b4b0-1e665d9e3e6f
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
# Compiler Error CS0722
'type': static types cannot be used as return types  
  
 A static type as a return type is not meaningful since instances of static types cannot be created.  
  
 The following sample generates CS0722:  
  
```  
// CS0722.cs  
public static class SC  
{  
}  
  
public class CMain  
{  
   public SC F()  // CS0722  
   {  
      return null;  
   }  
  
   public static void Main()  
   {  
   }  
}  
```