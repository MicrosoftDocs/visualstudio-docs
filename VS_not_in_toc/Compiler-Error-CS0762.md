---
title: "Compiler Error CS0762"
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
ms.assetid: 7cedd1af-ffe6-4ca7-82fb-faa9e98014a4
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
# Compiler Error CS0762
Cannot create delegate from method 'method' because it is a partial method without an implementing declaration  
  
 A partial method is not required to have an implementing declaration. However, a delegate does require that its encapsulated method have an implementation.  
  
### To correct this error  
  
1.  Provide an implementation for the method that is used to initialize the delegate.  
  
## Example  
  
```  
public delegate void TestDel();  
  
    public partial class C  
    {  
        partial void Part();  
  
        public static int Main()  
        {  
            C c = new C();  
            TestDel td = new TestDel(c.Part); // CS0762  
            return 1;  
        }  
  
    }  
```