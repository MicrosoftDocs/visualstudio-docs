---
title: Split a class into partial classes
description: Learn how to use the Partial keyword to divide the declaration of a class or structure among several declarations in Class Designer.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Class Designer, partial classes
- partial classes, Class Designer
ms.assetid: 6f6b0b30-3996-4569-9200-20482b3adf90
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
dev_langs:
- CSharp
- VB
ms.workload:
- multiple
---
# How to: Split a class into partial classes in Class Designer

You can use the `partial` keyword (`Partial` in Visual Basic) to divide the declaration of a class or structure among several declarations. You can use as many partial declarations as you want.

The declarations can be in one or in multiple source files. All the declarations must be in the same assembly and the same namespace.

Partial classes are useful in several situations. On a large project, for example, separating a class into multiple files enables more than one programmer to work on the project at same time. When you're working with code that Visual Studio generates, you can change the class without having to re-create the source file. (Examples of code that Visual Studio generates include Windows Forms and web service wrapper code.) You can thus create code that uses auto-generated classes without having to modify the file that Visual Studio creates.

There are two kinds of partial methods. In C#, they are called declaring and implementing; in Visual Basic, they are called declaration and implementation.

**Class Designer** supports partial classes and methods. The type shape in the class diagram refers to a single declaration location for the partial class. If the partial class is defined in multiple files, you can specify which declaration location **Class Designer** will use by setting the **New Member Location** property in the **Properties** window. That is, when you double-click a class shape, **Class Designer** goes to the source file that contains the class declaration identified by the **New Member Location** property. When you double-click a partial method in a class shape, **Class Designer** goes to the partial method declaration. Also, in the **Properties** window, the **File Name** property refers to the declaration location. For partial classes, **File Name** lists all of the files that contain declaration and implementation code for that class. However, for partial methods, **File Name** lists only the file that contains the partial method declaration.

The following examples split the definition of class `Employee` into two declarations, each of which defines a different procedure. The two partial definitions in the examples could be in one source file or in two different source files.

> [!NOTE]
> Visual Basic uses partial-class definitions to separate Visual Studio-generated code from user-authored code. The code is separated into discrete source files. For example, the **Windows Form Designer** defines partial classes for controls such as `Form`. You should not modify the generated code in these controls.

For more information about partial types in Visual Basic, see [Partial](/dotnet/visual-basic/language-reference/modifiers/partial).

## Example

To split a class definition, use the `partial` keyword (`Partial` in Visual Basic), as shown in the following example:

```csharp
// First part of class definition.
public partial class Employee
{
    public void CalculateWorkHours()
    {
    }
}

// Second part of class definition.
public partial class Employee
{
    public void CalculateTaxes()
    {
    }
}
```

```vb
' First part of class definition.
Partial Public Class Employee
    Public Sub CalculateWorkHours()
    End Sub
End Class

' Second part of class definition.
Partial Public Class Employee
    Public Sub CalculateTaxes()
    End Sub
End Class
```

## See also

- [Partial classes and methods](/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods)
- [partial (Type) (C# Reference)](/dotnet/csharp/language-reference/keywords/partial-type)
- [partial (Method) (C# Reference)](/dotnet/csharp/language-reference/keywords/partial-method)
- [Partial (Visual Basic)](/dotnet/visual-basic/language-reference/modifiers/partial)
