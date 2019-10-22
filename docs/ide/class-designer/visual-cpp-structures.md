---
title: C++ Structures in Class Designer
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Class Designer [Visual Studio], structures"
ms.assetid: bad18ab6-d956-47a6-a413-811cc26db5f5
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "cplusplus"
---
# C++ structures in Class Designer

**Class Designer** supports C++ structures, which are declared with the keyword `struct`. Following is an example:

```cpp
struct MyStructure
{
   char a;
   int i;
   long j;
};
```

For more information about using the `struct` type, see [struct](/cpp/cpp/struct-cpp).

A C++ structure shape in a class diagram looks and works like a class shape, except that the label reads **Struct** and it has square corners instead of rounded corners.

|Code element|Class Designer view|
|------------------| - |
|`struct StructureName {};`|**StructureName**<br /><br /> Struct|

## See also

- [Working with C++ Code](working-with-visual-cpp-code.md)
- [Classes and Structs](/cpp/cpp/classes-and-structs-cpp)
- [struct](/cpp/cpp/struct-cpp)