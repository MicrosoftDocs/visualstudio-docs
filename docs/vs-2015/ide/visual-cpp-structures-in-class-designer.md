---
title: "Visual C++ Structures in Class Designer | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Class Designer [Visual Studio], structures"
ms.assetid: bad18ab6-d956-47a6-a413-811cc26db5f5
caps.latest.revision: 15
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
---
# Visual C++ Structures in Class Designer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [Visual C++ Structures in Class Designer](https://docs.microsoft.com/visualstudio/ide/visual-cpp-structures-in-class-designer).  
  
Class Designer supports C++ structures, which are declared with the keyword `struct`. Following is an example:  
  
```  
struct MyStructure  
{  
   char a;  
   int i;  
   long j;  
};  
```  
  
 For more information about using the `struct` type, see [struct](../Topic/struct%20\(C++\).md).  
  
 A C++ structure shape in a class diagram looks and works like a class shape, except that the label reads **Struct** and it has square corners instead of rounded corners.  
  
|Code element|Class Designer view|  
|------------------|-------------------------|  
|`struct StructureName {};`|**StructureName**<br /><br /> Struct|  
  
## See Also  
 [Working with Visual C++ Code (Class Designer)](../ide/working-with-visual-cpp-code-class-designer.md)   
 [Classes and Structs](../Topic/Classes%20and%20Structs%20\(C++\).md)   
 [struct](../Topic/struct%20\(C++\).md)



