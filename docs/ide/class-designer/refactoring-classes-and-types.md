---
title: Rename and move classes and types in Class Designer
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
  - "vs.ClassDesigner.OverrideMembersDialog"
helpviewer_keywords:
  - "members, overriding"
  - "overriding members"
  - "classes [Visual Studio], refactoring"
  - "type members, overriding"
  - "refactoring, types"
  - "types [Visual Studio], refactoring"
  - "Class Designer [Visual Studio], refactoring classes"
  - "refactoring, classes"
ms.assetid: dcf07bb4-fa3b-4224-9dec-566fd924a8ce
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Refactor classes and types in Class Designer

When you refactor code, you make it easier to understand, maintain, and more efficient by changing its internal structure and how its objects are designed, not its external behavior. Use Class Designer and the Class Details window to reduce the work that you have to do and the chance of introducing bugs when you refactor C#, Visual Basic, or C++ code in your Visual Studio project.

> [!NOTE]
> The files of a project might be read-only because the project is under source-code control and is not checked out, it is a referenced project, or its files are marked as read-only on disk. When you work in a project in one of these states, you will be presented with various ways to save your work depending on the project's state. This applies to refactoring code and also to code that you change in another way, such as directly editing it.

## Common tasks

|Task|Supporting Content|
|----------| - |
|**Refactoring classes:** You can use refactoring operations to split a class into partial classes or to implement an abstract base class.|-   [How to: Split a Class into Partial Classes](how-to-split-a-class-into-partial-classes.md)|
|**Working with interfaces:** In Class Designer, you can implement an interface on the class diagram by connecting it to a class that provides code for the interface methods.|-   [How to: Implement an Interface](how-to-implement-an-interface.md)|
|**Refactoring types, type members, and parameters:** By using Class Designer, you can rename types, override type members, or move them from one type to another. You can also create nullable types.|-   [Rename types and type members](#rename-types-and-type-members)<br />-   [Move type members from one type to another](#move-type-members-from-one-type-to-another)<br />-   [How to: Create a Nullable Type](how-to-create-a-nullable-type.md)|

## Rename types and type members

In Class Designer, you can rename a type or a member of a type on the class diagram or in the **Properties** window. In the **Class Details** window, you can change the name of a member but not a type. Renaming a type or type member propagates to all windows and code locations where the old name appeared.

### Rename in the Class Designer

1. On the class diagram, select the type or member and select the name.

     The name of the member becomes editable.

2. Type the new name for the type or type member

### Rename in the Class Details window

1. To display the **Class Details** window, right-click the type or type member and select **Class Details**.

     The **Class Details** window appears.

2. In the **Name** column, change the name of the type member

3. To move focus away from the cell, press the **Enter** key or click away from the cell.

    > [!NOTE]
    > In the **Class Details** window, you can change the name of a member but not a type.

### Rename in the Properties window

1. On the class diagram or the **Class Details** window, right-click the type or member and then select **Properties**.

     The **Properties** window appears and displays properties for the type or type member.

2. In the **Name** property, change the name of the type or type member.

     The new name propagates to all windows and code locations in the current project where the old name appeared.

## Move type members from one type to another

Using **Class Designer**, you can move a type member from one type to another type. Both types must be visible in the current class diagram.

1. In a type that is visible on the design surface, right-click the member you want to move to another type, and then select **Cut**.

2. Right-click the destination type and select **Paste**.

     The property is removed from the source type and appears in the destination type.

## See also

- [Designing Classes and Types](designing-and-viewing-classes-and-types.md)