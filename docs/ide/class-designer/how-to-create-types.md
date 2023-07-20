---
title: 'How to: Create Types by using Class Designer'
description: Learn how to design new types for C# and Visual Basic projects by creating them on a class diagram.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- VS.Clr.ClrAttributesDialog
helpviewer_keywords:
- custom attributes, applying
- class diagrams, creating types
- classes [Visual Studio], creating with Class Designer
- Class Designer [Visual Studio], creating classes
- types [Visual Studio], class diagrams
- attributes [Visual Studio], applying custom
ms.assetid: 94458c31-28bc-40e2-9737-85868788a0e5
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Create types by using Class Designer

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

To design new types for C# and Visual Basic projects, create them on a class diagram. To see existing types, see [View Existing Types](how-to-view-existing-types.md).

## <a name="CreateType"></a> Create a new type

1. In the **Toolbox**, under **Class Designer**, drag one of these onto a class diagram:

    - **Class** or **Abstract Class**

    - **Enum**

    - **Interface**

    - **Structure** (VB) or **Struct** (C#)

    - **Delegate**

    - **Module** (VB only)

1. Name the type. Then select its access level.

1. Select the file where you want to add the initial code for the type:

    - To create a new file and add it to the current project, select **Create new file** and name the file.

    - To add code to an existing file, select **Add to existing file**.

         If your solution has a project that shares code across multiple apps, you can add a new type to a class diagram in the app project, but only if the corresponding class file is in the same app project or is in the shared project.

1. Now add other items to define the type:

    |**For**|**Add**|
    |-|-|
    |Classes, abstract classes, structures or structs|Methods, properties, fields, events, constructors (method), destructors (method), and constants that define the type|
    |Enums|Field values that make up the enumeration|
    |Interfaces|Methods, properties, and events that make up the interface|
    |Delegate|Parameters that define the delegate|
    |Module|Methods, properties, fields, events, constructors (method), and constants that define the module|

     See [Creating Members](creating-and-configuring-type-members.md#create-members).

### <a name="CustAttributeType"></a> Apply a custom attribute to a type

1. Click the type's shape on a class diagram.

1. In **Properties**, next to the **Custom Attributes** property for the type, click the ellipsis (...) button.

1. Add one or more custom attributes with one per line. Don't enclose them in brackets.

   The custom attributes are applied to the type.

### <a name="CustAttributeMember"></a> Apply a custom attribute to a type member

1. Click the member's name in its type's shape on a class diagram, or its row in the Class Details window.

1. In **Properties**, find the member's **Custom Attributes** property.

1. Add one or more custom attributes with one per line. Don't enclose them in brackets.

   The custom attributes are applied to the type.

## Create inheritance between types in Class Designer

To create an inheritance relationship between two types on a class diagram using **Class Designer**, connect the base type with its derived type or types. You can have an inheritance relationship between two classes, between a class and an interface, or between two interfaces.

### To create an inheritance between types

1. From your project in **Solution Explorer**, open a class diagram (.cd) file.

     If you don't have a class diagram, create it. See [How to: Add Class Diagrams to Projects](how-to-add-class-diagrams-to-projects.md).

1. In the **Toolbox**, under **Class Designer**, click **Inheritance**.

1. On the class diagram, draw an inheritance line between the types that you want, starting from:

    - A derived class to the base class

    - An implementing class to the implemented interface

    - An extending interface to the extended interface

1. Optionally, when you have a derived type from a generic type, click the inheritance line. In the **Properties** window, set the **Type Arguments** property to match the type that you want for the generic type.

    > [!NOTE]
    > If a parent abstract class contains at least one abstract member, then all abstract members are implemented as non-abstract inheriting classes.
    >
    >  Although you can visualize existing generic types, you can't create new generic types. You also can't change the type parameters for existing generic types.