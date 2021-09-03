---
title: 'How to: View Existing Types (Class Designer)'
description: Learn how to see an existing type and its members by adding its shape to a class diagram.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- vs.classdesigner.CannotShowBaseType
helpviewer_keywords:
- types [Visual Studio], visualizing
- types [Visual Studio], class diagrams
- class diagrams, types
ms.assetid: de110a4e-5b51-4a40-9dee-615df4d8f999
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# How to: View existing types in Class Designer

To see an existing type and its members, add its shape to a class diagram.

You can see local and referenced types. A local type exists in the currently open project and is read/write. A referenced type exists in another project or in a referenced assembly and is read-only.

To design new types on class diagrams, see [How to: Create types by using Class Designer](how-to-create-types.md).

## To see types in a project on a class diagram

1. From a project in **Solution Explorer**, open an existing class diagram (.cd) file. Or if no class diagram exists, add a new class diagram to the project. See [How to: Add Class Diagrams to Projects](how-to-add-class-diagrams-to-projects.md).

2. From the project in **Solution Explorer**, drag a source code file to the class diagram.

    > [!NOTE]
    > If your solution has a project that shares code across multiple apps, you can drag files or code to a class diagram only from these sources:
    >
    > - The app project that contains the diagram
    > - A shared project that was imported by the app project
    > - A referenced project
    > - An assembly

    Shapes representing the types defined in the source code file appear on the diagram at the position where you dragged the file.

You can also view types in the project by dragging one or more types from the project node in **Class View** to the class diagram.

> [!TIP]
> If **Class View** is not open, open **Class View** from the **View** menu.

To display types at default locations on the diagram, select one or more types in **Class View**, right-click the selected types, and choose **View Class Diagram**.

> [!NOTE]
> If a closed class diagram containing the type already exists in the project, the class diagram opens to display the type shape. However, if no class diagram containing the type exists in the project, **Class Designer** creates a new class diagram in the project and opens it to display the type.

When you first display a type on the diagram, its shape appears collapsed by default. You can expand the shape to view its contents.

### To display the contents of a project in a class diagram

In **Solution Explorer** or **Class View**, right-click the project and choose **View**, then choose **View Class Diagram**. An auto-populated Class Diagram is created.

## See also

- [How to: View Inheritance Between Types](how-to-view-inheritance-between-types.md)
- [How to: Customize Class Diagrams](how-to-customize-class-diagrams.md)
- [Viewing Types and Relationships](designing-and-viewing-classes-and-types.md)
