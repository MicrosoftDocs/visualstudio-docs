---
title: "Compiler Warning (level 2) CS1571"
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
ms.assetid: 23b08885-9f69-4376-a952-4820b065a5c0
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
# Compiler Warning (level 2) CS1571
XML comment on 'construct' has a duplicate param tag for 'parameter'  
  
 When using the [/doc](../Topic/-doc%20\(C%23%20Compiler%20Options\).md) compiler option, multiple comments were found for the same method parameter. Remove one of the duplicate lines.  
  
 The following sample generates CS1571:  
  
```  
// CS1571.cs  
// compile with: /W:2 /doc:x.xml  
  
/// <summary>help text</summary>  
public class MyClass  
{  
   /// <param name='Int1'>Used to indicate status.</param>  
   /// <param name='Char1'>An initial.</param>  
   /// <param name='Int1'>Used to indicate status.</param> // CS1571  
   public static void MyMethod(int Int1, char Char1)  
   {  
   }  
  
   /// <summary>help text</summary>  
   public static void Main ()  
   {  
   }  
}  
```