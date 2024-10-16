---
title: 'View Existing Types (Class Designer)'
description: View an existing type and the relationship to its members by adding its shape to a class diagram in Class Designer in Visual Studio.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- types [Visual Studio], visualizing
- types [Visual Studio], class diagrams
- class diagrams, types
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# View types and relationships in Class Designer

With Class Designer, you can manage class diagrams by performing the following actions:

- View [existing types](#view-types-and-relationships-in-class-designer) and its members
- Find an [inheritance relationship](#view-inheritance-between-types-in-class-designer) between a base type and its derived types
- Change the way a class diagram represents an [association relationship](#change-between-member-notation-and-association-notation-in-class-designer) between two types

## View existing types in Class Designer

To see an existing type and its members, add its shape to a class diagram.

You can see local and referenced types. A local type exists in the currently open project and is read/write. A referenced type exists in another project or in a referenced assembly and is read-only.

To design new types on class diagrams, see [Create types by using Class Designer](how-to-create-types.md).

### To see types in a project on a class diagram

1. From a project in **Solution Explorer**, open an existing class diagram (.cd) file. Or if no class diagram exists, add a new class diagram to the project. See [How to: Add Class Diagrams to Projects](how-to-add-class-diagrams-to-projects.md).

1. From the project in **Solution Explorer**, drag a source code file to the class diagram.

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

## View inheritance between types in Class Designer

You can find the inheritance relationship, if it exists, between a base type and its derived types on a class diagram in **Class Designer**. To create an inheritance relationship, if none exists between two types, see [Create inheritance between types](how-to-create-inheritance-between-types.md).

### To find the base type

1. On the class diagram, click the type for which you want to see the base class or interface.

1. On the **Class Diagram** menu, choose **Show Base Class** or **Show Base Interfaces**.

     The type's base class or interface appears selected on the diagram. Any hidden inheritance lines now appear between the two shapes.

You can also right-click the type whose base type you want to display, and choose **Show Base Class** or **Show Base Interfaces**.

### To find the derived types

1. On the class diagram, click the type for which you want to see the derived classes or interfaces.

1. On the **Class Diagram** menu, choose **Show Derived Classes** or **Show Derived Interfaces**.

     The type's derived classes or interfaces appear on the diagram. Any hidden inheritance lines now appear between the shapes.

You can also right-click the type for which you want to see its derived types, and choose **Show Derived Classes** or **Show Derived Interfaces**.

## Change between member notation and association notation in Class Designer

In **Class Designer**, you can change the way the class diagram represents an association relationship between two types from member notation to association notation and vice versa. Members displayed as association lines often provide a useful visualization of how types are related.

> [!NOTE]
> Association relationships can be represented as a member property or field. To change member notation to association notation, one type must have a member of another type. To change association notation to member notation, the two types must be connected by an association line. For more information, see [How to: Create associations between types](how-to-create-associations-between-types.md). If your project contains multiple class diagrams, changes that you make to the way a diagram displays association relationships affect only that diagram. To change the way another diagram displays association relationships, open or display that diagram and perform these steps.

### To change member notation to association notation

1. From the project node in Solution Explorer, open the class diagram (.cd) file.

1. In the type shape on the class diagram, right-click the member property or field representing the association, and choose **Show as Association**.

    > [!TIP]
    > If no properties or fields are visible in the type shape, the compartments in the shape might be collapsed. To expand the type shape, double-click the compartment name or right-click the type shape, and choose **Expand**.

    The member disappears from the compartment in the type shape and an association line appears to connect the two types. The association line is labeled with the name of the property or field.

### To change association notation to member notation

On the class diagram, right-click the association line, and choose **Show as Property** or **Show as Field** as appropriate. The association line disappears, and the property displays in the appropriate compartment within its type shape on the diagram.

## Related content

- [Refactor classes and types in Class Designer](refactoring-classes-and-types.md)
