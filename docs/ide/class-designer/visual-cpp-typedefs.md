---
title: C++ Typedefs in Class Designer
description: Learn about how Class Designer supports C++ typedef types declared with the keyword typedef.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
- vs.classdesigner.typedef
- vs.classdesigner.aliasofline
helpviewer_keywords:
- Class Designer [Visual Studio], typedefs
ms.assetid: c1984108-71fc-4d3a-b4d4-3eac2c6b4ebf
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- cplusplus
---
# C++ typedefs in Class Designer

[Typedef](/cpp/cpp/aliases-and-typedefs-cpp#typedefs) statements create one or more layers of indirection between a name and its underlying type. **Class Designer** supports C++ typedef types, which are declared with the keyword `typedef`, for example:

```cpp
typedef class coord
{
   void P(x,y);
   unsigned x;
   unsigned y;
} COORD;
```

You can then use this type to declare an instance:

`COORD OriginPoint;`

## Class and struct shapes

In **Class Designer**, a C++ typedef has the shape of the type specified in the typedef. If the source declares `typedef class`, the shape has rounded corners and the label **Class**. For `typedef struct`, the shape has square corners and the label **Struct**.

Classes and structures can have nested typedefs declared within them. In **Class Designer**, class and structure shapes can show nested typedef declarations as nested shapes.

Typedef shapes support the **Show as Association** and **Show as Collection Association** commands on the right-click menu (context menu).

### Class typedef example

```cpp
class B {};
typedef B MyB;
```

![C++ class typedef in Class Designer](media/cpp-class-typedef.png)

### Struct typedef example

```cpp
typedef struct mystructtag
{
    int   i;
    double f;
} mystruct;
```

![C++ struct typedef in Class Designer](media/cpp-struct-typedef.png)

## Unnamed typedefs

Although you can declare a typedef without a name, **Class Designer** doesn't use the tag name that you specify. **Class Designer** uses the name that **Class View** generates. For example, the following declaration is valid, but it appears in **Class View** and **Class Designer** as an object named **__unnamed**:

```cpp
typedef class coord
{
   void P(x,y);
   unsigned x;
   unsigned y;
};
```

> [!NOTE]
> **Class Designer** does not display typedefs whose source type is a function pointer.

## See also

- [Work with C++ Code](working-with-visual-cpp-code.md)
- [Typedefs](/cpp/cpp/aliases-and-typedefs-cpp#typedefs)
