---
title: "Compiler Error CS1667"
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
ms.assetid: 59f64828-58bc-487c-862a-75537e21d4ea
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
# Compiler Error CS1667
Attribute 'attribute' is not valid on property or event accessors. It is valid on 'declaration type' declarations only.  
  
 This error occurs if you use an attribute on a property or event accessor, when it should be on the property or event itself. This error could occur with the attributes <xref:System.CLSCompliantAttribute?qualifyHint=False>, <xref:System.Diagnostics.ConditionalAttribute?qualifyHint=False>, and <xref:System.ObsoleteAttribute?qualifyHint=False>.  
  
## Example  
 The following sample generates CS1670:  
  
```  
// CS1667.cs  
using System;  
  
public class C  
{  
    private int i;  
  
    //Try this instead:  
    //[Obsolete]  
    public int ObsoleteProperty  
    {  
        [Obsolete]  // CS1667  
        get { return i; }  
        set { i = value; }  
    }  
  
    public static void Main()  
    {  
    }  
}  
```