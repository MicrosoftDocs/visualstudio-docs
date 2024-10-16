---
title: 'Implement an Interface (Class Designer)'
description: Learn how to implement an interface on the class diagram by connecting it to a class that provides code for the interface methods.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- interfaces [Visual Studio], implementing
- interfaces [Visual Studio]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Implement an interface in Class Designer

In **Class Designer**, you can implement an interface on the class diagram by connecting it to a class that provides code for the interface methods. **Class Designer** generates an interface implementation and displays the relationship between the interface and the class as an inheritance relationship. You can implement an interface by drawing an inheritance line between the interface and the class or by dragging the interface from Class View.

> [!TIP]
> You can create interfaces the same way you create other types. If the interface exists but does not appear on the class diagram, then first display it. For more information, see [Create types by using Class Designer](how-to-create-types.md) and [View existing types](how-to-view-existing-types.md).

## To implement an interface by drawing an inheritance line

1. On the class diagram, display the interface and the class that will implement the interface.

1. Draw an inheritance line from the class and the interface.

     A lollipop appears attached to the class and a label with the interface name identifies the inheritance relationship. Visual Studio generates stubs for all interface members.

For more information, see [Create inheritance between types](how-to-create-inheritance-between-types.md).

## To implement an interface from the Class View window

1. On the class diagram, display the class that you want to implement the interface.

1. Open **Class View** and locate the interface.

    > [!TIP]
    > If **Class View** is not open, open **Class View** from the **View** menu or press **Ctrl**+**Shift**+**C**.

1. Drag the interface node to the class shape on the diagram.

     A lollipop appears attached to the class and a label with the interface name identifies the inheritance relationship. Visual Studio generates stubs for all interface members; at this point, the interface is implemented.

## Related content

- [Create Types by using Class Designer](how-to-create-types.md)
- [Refactoring Classes and Types](refactoring-classes-and-types.md)
