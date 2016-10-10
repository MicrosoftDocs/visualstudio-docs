---
title: "Compiler Error CS0239"
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
ms.assetid: 2e07bbc2-03a9-44b2-b321-477ca95fff8c
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
# Compiler Error CS0239
'member' : cannot override inherited member 'inherited member' because it is sealed  
  
 A member cannot [override](../Topic/override%20\(C%23%20Reference\).md) a [sealed](../Topic/sealed%20\(C%23%20Reference\).md) inherited member. For more information, see [Checked and Unchecked](../Topic/Checked%20and%20Unchecked%20\(C%23%20Reference\).md).  
  
 The following sample generates CS0239:  
  
```  
// CS0239.cs  
abstract class MyClass  
{  
   public abstract void f();  
}  
  
class MyClass2 : MyClass  
{  
   public static void Main()  
   {  
   }  
  
   public override sealed void f()  
   {  
   }  
}  
  
class MyClass3 : MyClass2  
{  
   public override void f()   // CS0239  
   // Try the following definition instead:  
   // public new void f()  
   {  
   }  
}  
```