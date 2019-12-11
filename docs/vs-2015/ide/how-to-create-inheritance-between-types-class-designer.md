---
title: "How to: Create Inheritance Between Types (Class Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.classdesigner.inheritanceline"
helpviewer_keywords:
  - "inheritance, relationship defining"
  - "relationships, defining inheritance"
ms.assetid: 3786a21c-8022-4bf5-9d13-740fd354e93c
caps.latest.revision: 34
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create Inheritance Between Types (Class Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To create an inheritance relationship between two types on a class diagram using Class Designer, connect the base type with its derived type or types. You can have an inheritance relationship between two classes, between a class and an interface, or between two interfaces.

### To create an inheritance between types

1. From your project in Solution Explorer, open a class diagram (.cd) file.

     If you don't have a class diagram, create it. See [How to: Add Class Diagrams to Projects (Class Designer)](../ide/how-to-add-class-diagrams-to-projects-class-designer.md).

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

## See Also
 [Inheritance](https://msdn.microsoft.com/library/81d64ee4-50f9-4d6c-a8dc-257c348d2eea)
 [Inheritance Basics](https://msdn.microsoft.com/library/dfc8deba-f5b3-4d1d-a937-7cb826446fc5)
 [How to: View Inheritance Between Types (Class Designer)](../ide/how-to-view-inheritance-between-types-class-designer.md)
 [Visual C++ Classes in Class Designer](../ide/visual-cpp-classes-in-class-designer.md)
