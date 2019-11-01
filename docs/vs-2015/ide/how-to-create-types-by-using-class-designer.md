---
title: "How to: Create Types by using Class Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "VS.Clr.ClrAttributesDialog"
helpviewer_keywords:
  - "custom attributes, applying"
  - "class diagrams, creating types"
  - "classes [Visual Studio], creating with Class Designer"
  - "Class Designer [Visual Studio], creating classes"
  - "types [Visual Studio], class diagrams"
  - "attributes [Visual Studio], applying custom"
ms.assetid: 94458c31-28bc-40e2-9737-85868788a0e5
caps.latest.revision: 45
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create Types by using Class Designer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To design new types for Visual C# .NET and Visual Basic .NET projects, create them on a class diagram. To see existing types, see [How to: View Existing Types (Class Designer)](../ide/how-to-view-existing-types-class-designer.md).

- [Create a new type](#CreateType)

- [Apply a custom attribute to a type](#CustAttributeType)

- [Apply a custom attribute to a type member](#CustAttributeMember)

## <a name="CreateType"></a> Create a new type

1. In the Toolbox, under Class Designer, drag one of these onto a class diagram:

    - **Class** or **Abstract Class**

    - **Enum**

    - **Interface**

    - **Structure** (VB) or **Struct** (C#)

    - **Delegate**

    - **Module** (VB only)

2. Name the type. Then select its access level.

3. Select the file where you want to add the initial code for the type:

    - To create a new file and add it to the current project, select **Create new file** and name the file.

    - To add code to an existing file, select **Add to existing file**.

         If your solution has a project that shares code across multiple apps, you can add a new type to a class diagram in the app project, but only if the corresponding class file is in the same app project or is in the shared project.

4. Now add other items to define the type:

    |||
    |-|-|
    |**For**|**Add**|
    |Classes, abstract classes, structures or structs|Methods, properties, fields, events, constructors (method), destructors (method), and constants that define the type|
    |Enums|Field values that make up the enumeration|
    |Interfaces|Methods, properties, and events that make up the interface|
    |Delegate|Parameters that define the delegate|
    |Module|Methods, properties, fields, events, constructors (method), and constants that define the module|

     See [Creating Members](../ide/creating-and-configuring-type-members-class-designer.md#CreateMembers).

## <a name="CustAttributeType"></a> Apply a custom attribute to a type

1. Click the type's shape on a class diagram.

2. In the Properties window, next to the **Custom Attributes** property for the type, click the ellipsis (…) button.

3. Add one or more custom attributes with one per line. Don't enclose them in brackets.

     When you're done, the custom attributes are applied to the type.

## <a name="CustAttributeMember"></a> Apply a custom attribute to a type member

1. Click the member's name in its type's shape on a class diagram, or its row in the Class Details window.

2. In the Properties window, find the member's **Custom Attributes** property.

3. Add one or more custom attributes with one per line. Don't enclose them in brackets.

     When you're done, the custom attributes are applied to the type.

## See Also
 [How to: Create Inheritance Between Types (Class Designer)](../ide/how-to-create-inheritance-between-types-class-designer.md)
 [How to: Create Associations Between Types (Class Designer)](../ide/how-to-create-associations-between-types-class-designer.md)
 [Creating and Configuring Type Members (Class Designer)](../ide/creating-and-configuring-type-members-class-designer.md)
 [Working with Class Diagrams (Class Designer)](../ide/working-with-class-diagrams-class-designer.md)
 [Designing Classes and Types (Class Designer)](../ide/designing-classes-and-types-class-designer.md)
