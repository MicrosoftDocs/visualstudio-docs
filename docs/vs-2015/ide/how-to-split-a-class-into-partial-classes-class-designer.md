---
title: "How to: Split a Class into Partial Classes (Class Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Class Designer, partial classes"
  - "partial classes, Class Designer"
ms.assetid: 6f6b0b30-3996-4569-9200-20482b3adf90
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Split a Class into Partial Classes (Class Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can divide the declaration of a class or structure among several declarations by using the `Partial` keyword in Visual Basic or the `partial` keyword in Visual C#. You can use as many partial declarations as you want, in as many different source files as you want, or in one source file. However, all the declarations must be in the same assembly and the same namespace.

 Partial classes are useful in several situations. For example, when you are working on large projects, separating a class into more than one file enables more than one programmer to work on it at the same time. When you are working with code that Visual Studio generates, you can change the class without having to re-create the source file. (Examples of code that Visual Studio generates include Windows Forms and Web Service wrapper code.) You can thus create code that uses auto-generated classes without having to modify the file that Visual Studio creates.

 There are two kinds of partial methods. In Visual C#, they are called declaring and implementing; in Visual Basic, they are called declaration and implementation.

 Class Designer supports partial classes and methods. The type shape in the class diagram refers to a single declaration location for the partial class. If the partial class is defined in multiple files, you can specify which declaration location Class Designer will use by setting the **New Member Location** property in the **Properties** window. That is, when you double-click a class shape, Class Designer goes to the source file that contains the class declaration identified by the **New Member Location** property. When you double-click a partial method in a class shape, Class Designer goes to the partial method declaration. Also, in the **Properties** window, the **File Name** property refers to the declaration location. For partial classes, **File Name** lists all of the files that contain declaration and implementation code for that class. However, for partial methods, **File Name** lists only the file that contains the partial method declaration.

 The following examples split the definition of class `Employee` into two declarations, each of which defines a different procedure. The two partial definitions in the examples could be in one source file or in two different source files.

> [!NOTE]
> Visual Basic uses partial-class definitions to separate Visual Studio—generated code from user-authored code. The code is separated into discrete source files. For example, the **Windows Form Designer** defines partial classes for controls such as `Form`. You should not modify the generated code in these controls.

 For more information about partial types in Visual Basic, see [Partial](https://msdn.microsoft.com/library/7adaef80-f435-46e1-970a-269fff63b448).

## Example
 To split a class definition in Visual Basic, use the `Partial` keyword, as shown in the following example.

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

## Example
 To split a class definition in Visual C#, use the `partial` keyword, as shown in the following example.

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

## See Also
 [Partial Classes and Methods](https://msdn.microsoft.com/library/804cecb7-62db-4f97-a99f-60975bd59fa1)
 [partial (Type)](https://msdn.microsoft.com/library/27320743-a22e-4c7b-b0b3-53afe3607334)
 [partial (Method) (C# Reference)](https://msdn.microsoft.com/library/43f40242-17e0-4452-8573-090503ad3137)
 [Partial](https://msdn.microsoft.com/library/7adaef80-f435-46e1-970a-269fff63b448)
