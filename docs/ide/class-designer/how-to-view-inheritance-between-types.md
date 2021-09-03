---
title: View inheritance between types
description: Learn how to find the inheritance relationship between a base type and its derived types on a class diagram in Class Designer.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- vs.classdesigner.AssociationTypeNotFoundError
helpviewer_keywords:
- types [Visual Studio], inheritance
- types [Visual Studio], base
- types [Visual Studio], derived
ms.assetid: ea3f0ada-f53b-4fb1-9fb5-908286f5ec3e
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# How to: View inheritance between types in Class Designer

You can find the inheritance relationship, if it exists, between a base type and its derived types on a class diagram in **Class Designer**. To create an inheritance relationship, if none exist, between two types, see [How to: Create inheritance between types](how-to-create-inheritance-between-types.md).

## To find the base type

1. On the class diagram, click the type for which you want to see the base class or interface.

2. On the **Class Diagram** menu, choose **Show Base Class** or **Show Base Interfaces**.

     The type's base class or interface appears selected on the diagram. Any hidden inheritance lines now appear between the two shapes.

You can also right-click the type whose base type you want to display, and choose **Show Base Class** or **Show Base Interfaces**.

## To find the derived types

1. On the class diagram, click the type for which you want to see the derived classes or interfaces.

2. On the **Class Diagram** menu, choose **Show Derived Classes** or **Show Derived Interfaces**.

     The type's derived classes or interfaces appear on the diagram. Any hidden inheritance lines now appear between the shapes.

You can also right-click the type for which you want to see its derived types, and choose **Show Derived Classes** or **Show Derived Interfaces**.

## See also

- [How to: Create Associations Between Types](how-to-create-associations-between-types.md)
- [Viewing Types and Relationships](designing-and-viewing-classes-and-types.md)
