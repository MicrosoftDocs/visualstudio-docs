---
title: "Visual C++ Structures in Class Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Class Designer [Visual Studio], structures"
ms.assetid: bad18ab6-d956-47a6-a413-811cc26db5f5
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# Visual C++ Structures in Class Designer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Class Designer supports C++ structures, which are declared with the keyword `struct`. Following is an example:

```
struct MyStructure
{
   char a;
   int i;
   long j;
};
```

 For more information about using the `struct` type, see [struct](https://msdn.microsoft.com/library/3c6ba273-e248-4ff1-8c69-d2abcf1263c6).

 A C++ structure shape in a class diagram looks and works like a class shape, except that the label reads **Struct** and it has square corners instead of rounded corners.

|Code element|Class Designer view|
|------------------|-------------------------|
|`struct StructureName {};`|**StructureName**<br /><br /> Struct|

## See Also
 [Working with Visual C++ Code (Class Designer)](../ide/working-with-visual-cpp-code-class-designer.md)
 [Classes and Structs](https://msdn.microsoft.com/library/516dd496-13fb-4f17-845a-e9ca45437873)
 [struct](https://msdn.microsoft.com/library/3c6ba273-e248-4ff1-8c69-d2abcf1263c6)
