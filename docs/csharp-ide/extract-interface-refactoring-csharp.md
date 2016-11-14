---
title: "Extract Interface Refactoring (C#) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.csharp.refactoring.extractinterface"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "refactoring [C#], Extract Interface"
  - "Extract Interface refactoring operation [C#]"
ms.assetid: 7d0aa225-3b33-4331-9652-5a67cac6f3d0
caps.latest.revision: 25
author: "BillWagner"
ms.author: "wiwagn"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Extract Interface Refactoring (C#)
Extract Interface is a refactoring operation that provides an easy way to create a new interface with members that originate from an existing class, struct, or interface.  
  
 When several clients use the same subset of members from a class, struct, or interface, or when multiple classes, structs, or interfaces have a subset of members in common, it can be useful to embody the subset of members in an interface. For more information about using interfaces, see [Interfaces](/dotnet/csharp/programming-guide/interfaces/index).  
  
 Extract Interface generates an interface in a new file and positions the cursor at the beginning of the new file. You can specify which members to extract into the new interface, the name of the new interface, and the name of the generated file using the **Extract Interface** dialog box.  
  
### To use Extract Interface  
  
1.  Create a console application named `ExtractInterface`, and then replace `Program` with the following code  
  
    ```c#  
    // Invoke Extract Interface on ProtoA.  
    // Note:  the extracted interface will be created in a new file.  
    class ProtoA  
    {  
        public void MethodB(string s) { }  
    }  
    ```  
  
2.  With the cursor positioned in `MethodB`, and click **Extract Interface** on the **Refactor** menu.  
  
     The **Extract Interface** dialog box appears.  
  
     You can also type the keyboard shortcut CTRL+R, I to display the **Extract Interface** dialog box.  
  
     You can also right-click the mouse, point to **Refactor**, and then click **Extract Interface** to display the **Extract Interface** dialog box.  
  
3.  Click **Select All**.  
  
4.  Click **OK**.  
  
     You see the new file, IProtoA.cs, and the following code:  
  
    ```c#  
    using System;  
    namespace TopThreeRefactorings  
    {  
        interface IProtoA  
        {  
            void MethodB(string s);  
        }  
    }  
    ```  
  
## Remarks  
 This feature is only accessible when the cursor is positioned in the class, struct, or interface that contains the members that you would like to extract. When the cursor is in this position, invoke the Extract Interface refactoring operation.  
  
 When you invoke extract interface on a class or on a struct, the bases and interfaces list is modified to include the new interface name. When you invoke extract interface on an interface, the bases and interfaces list is not modified.  
  
## See Also  
 [Refactoring (C#)](../csharp-ide/refactoring-csharp.md)