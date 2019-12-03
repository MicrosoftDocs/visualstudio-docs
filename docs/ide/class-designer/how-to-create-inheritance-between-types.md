---
title: "How to: Create Inheritance Between Types (Class Designer)"
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
  - "vs.classdesigner.inheritanceline"
helpviewer_keywords:
  - "inheritance, relationship defining"
  - "relationships, defining inheritance"
ms.assetid: 3786a21c-8022-4bf5-9d13-740fd354e93c
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Create inheritance between types in Class Designer

To create an inheritance relationship between two types on a class diagram using **Class Designer**, connect the base type with its derived type or types. You can have an inheritance relationship between two classes, between a class and an interface, or between two interfaces.

## To create an inheritance between types

1. From your project in **Solution Explorer**, open a class diagram (.cd) file.

     If you don't have a class diagram, create it. See [How to: Add Class Diagrams to Projects](how-to-add-class-diagrams-to-projects.md).

2. In the **Toolbox**, under **Class Designer**, click **Inheritance**.

3. On the class diagram, draw an inheritance line between the types that you want, starting from:

    - A derived class to the base class

    - An implementing class to the implemented interface

    - An extending interface to the extended interface

4. Optionally, when you have a derived type from a generic type, click the inheritance line. In the **Properties** window, set the **Type Arguments** property to match the type that you want for the generic type.

    > [!NOTE]
    > If a parent abstract class contains at least one abstract member, then all abstract members are implemented as non-abstract inheriting classes.
    >
    >  Although you can visualize existing generic types, you can't create new generic types. You also can't change the type parameters for existing generic types.

## See also

- [Inheritance](/dotnet/csharp/programming-guide/classes-and-structs/inheritance)
- [Inheritance Basics](/dotnet/visual-basic/programming-guide/language-features/objects-and-classes/inheritance-basics)
- [How to: View Inheritance Between Types](how-to-view-inheritance-between-types.md)
- [Visual C++ Classes in Class Designer](visual-cpp-classes.md)