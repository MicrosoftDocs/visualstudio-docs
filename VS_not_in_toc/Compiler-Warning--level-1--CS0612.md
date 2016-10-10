---
title: "Compiler Warning (level 1) CS0612"
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
ms.assetid: 7695f3b7-ffef-43f7-83db-fc1a9e361f1a
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
# Compiler Warning (level 1) CS0612
'member' is obsolete  
  
 The class designer marked a member with the [Obsolete](assetId:///05e99cd0-bda6-4f79-a890-1ca093b4b488) attribute. This means that the member might not be supported in a future version of the class.  
  
 The following sample shows how accessing an obsolete member generates CS0612:  
  
```  
// CS0612.cs  
// compile with: /W:1  
using System;  
  
class MyClass  
{  
   [Obsolete]  
   public static void ObsoleteMethod()  
   {  
   }  
  
   [Obsolete]  
   public static int ObsoleteField;  
}  
  
class MainClass  
{  
   static public void Main()  
   {  
      MyClass.ObsoleteMethod();    // CS0612 here: method is deprecated  
      MyClass.ObsoleteField = 0;   // CS0612 here: field is deprecated  
   }  
}  
```