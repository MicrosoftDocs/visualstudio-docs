---
title: "Visual C++ Typedefs in Class Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.classdesigner.typedef"
  - "vs.classdesigner.aliasofline"
helpviewer_keywords:
  - "Class Designer [Visual Studio], typedefs"
ms.assetid: c1984108-71fc-4d3a-b4d4-3eac2c6b4ebf
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---
# Visual C++ Typedefs in Class Designer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Typedef statements create one or more layers of indirection between a name and its underlying type. The Class Designer supports C++ typedef types, which are declared with the keyword `typedef`, for example:

```
typedef class coord
{
   void P(x,y);
   unsigned x;
   unsigned y;
} COORD;
```

 You can then use this type to declare an instance:

 `COORD OriginPoint;`

 Although you can declare a typedef without a name, Class Designer will not use the tag name that you specify; it will use the name that Class View generates. For example, the following declaration is valid, but it appears in Class View and Class Designer as an object named **__unnamed**:

```
typedef class coord
{
   void P(x,y);
   unsigned x;
   unsigned y;
};
```

 For more information about using the `typedef` type, see [(NOTINBUILD)typedef Specifier](https://msdn.microsoft.com/cc96cf26-ba93-4179-951e-695d1f5fdcf1).

 A C++ typedef shape has the shape of the type specified in the typedef. For example, if the source declares `typedef class`, the shape has rounded corners and the label **Class**. For `typedef struct`, the shape has square corners and the label **Struct**.

 Classes and structures can have nested typedefs declared within them; therefore, class and structure shapes can show nested typedef declarations as nested shapes.

 Typedef shapes support the **Show as Association** and **Show as Collection Association** commands on the context menu.

 The following are some examples of typdef types that the Class Designer supports:

 `typedef type name`

 *name* : *type*

 typedef

 Draws an association line connecting to type *name*, if possible.

 `typedef void (*func)(int)`

 `func: void (*)(int)`

 typedef

 Typedef for function pointers. No association line is drawn.

 Class Designer does not display a typedef if its source type is a function pointer.

```
typedef int MyInt;
class A {
   MyInt I;
};
```

 `MyInt: int`

 typedef

 `A`

 Class

 Draws an association line pointing from the source type shape to the target type shape.

 `Class B {};`

 `typedef B MyB;`

 `B`

 Class

 `MyB : B`

 typedef

 Right-clicking a typedef shape and clicking **Show As Association** displays the typedef or class and an **Alias of** line joining the two shapes (similar to an association line).

 `typedef B MyB;`

 `typedef MyB A;`

 `MyBar : Bar`

 typedef

 Same as above.

```
Class B {};
typedef B MyB;

class A {
   MyB B;
};
```

 `B`

 Class

 `MyB : B`

 typedef

 `A`

 Class

 `MyB` is a nested typedef shape.

 `#include <vector>`

 `...`

 `using namespace std;`

 `...`

 `typedef vector<int> MyIntVect;`

 `vector<T>`Class

 `MyIntVect : vector<int>`

 typedef

 `class B {};`

 `typedef B MyB;`

 `class A : MyB {};`

 `MyB : B`

 typedef

 -> B

 `B`

 `A`

 Class

 -> MyB

 Class Designer does not support displaying this kind of relationship by using a context menu command.

 `#include <vector>`

 `Typedef MyIntVect std::vector<int>;`

 `Class MyVect : MyIntVect {};`

 `std::vector<T>`

 Class

 `MyIntVect : std::vector<int>`

 typedef

 `MyVect`

 Class

 -> MyIntVect

## See Also
 [Working with Visual C++ Code (Class Designer)](../ide/working-with-visual-cpp-code-class-designer.md)
 [(NOTINBUILD)typedef Specifier](https://msdn.microsoft.com/cc96cf26-ba93-4179-951e-695d1f5fdcf1)
