---
title: "Compiler Warning (level 1) CS1581"
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
ms.assetid: b7ac7586-a724-492c-887f-795af1c3bcc4
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
# Compiler Warning (level 1) CS1581
Invalid return type in XML comment cref attribute  
  
 When attempting to reference a method, the compiler detected an error due to an invalid return type.  
  
## Example  
 The following sample generates CS1581:  
  
```  
// CS1581.cs  
// compile with: /W:1 /doc:x.xml  
  
/// <summary>help text</summary>  
public class MyClass  
{  
    /// <summary>help text</summary>  
    public static void Main()  
    {  
    }  
  
    /// <summary>help text</summary>  
    public static explicit operator int(MyClass f)  
    {  
        return 0;  
    }  
}  
  
/// <seealso cref="MyClass.explicit operator intt(MyClass)"/>  // CS1581  
// try the following line instead  
// /// <seealso cref="MyClass.explicit operator int(MyClass)"/>  
public class MyClass2  
{  
}  
```