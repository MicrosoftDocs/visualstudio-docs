---
title: "How to: View Inheritance Between Types (Class Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.classdesigner.AssociationTypeNotFoundError"
helpviewer_keywords:
  - "types [Visual Studio], inheritance"
  - "types [Visual Studio], base"
  - "types [Visual Studio], derived"
ms.assetid: ea3f0ada-f53b-4fb1-9fb5-908286f5ec3e
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: View Inheritance Between Types (Class Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can find the inheritance relationship, if it exists, between a base type and its derived types on a class diagram in Class Designer. To create an inheritance relationship, if none exist, between two types, see [How to: Create Inheritance Between Types (Class Designer)](../ide/how-to-create-inheritance-between-types-class-designer.md).

### To find the base type

1. On the class diagram, click the type for which you want to see the base class or interface.

2. On the **Class Diagram** menu, choose **Show Base Class** or **Show Base Interfaces**.

    The type's base class or interface appears selected on the diagram. Any hidden inheritance lines now appear between the two shapes.

   You can also right-click the type whose base type you want to display, and choose **Show Base Class** or **Show Base Interfaces**.

### To find the derived types

1. On the class diagram, click the type for which you want to see the derived classes or interfaces.

2. On the **Class Diagram** menu, choose **Show Derived Classes** or **Show Derived Interfaces**.

    The type’s derived classes or interfaces appear on the diagram. Any hidden inheritance lines now appear between the shapes.

   You can also right-click the type for which you want to see its derived types, and choose **Show Derived Classes** or **Show Derived Interfaces**.

## See Also
 [How to: Create Associations Between Types (Class Designer)](../ide/how-to-create-associations-between-types-class-designer.md)
 [Viewing Types and Relationships (Class Designer)](../ide/viewing-types-and-relationships-class-designer.md)
