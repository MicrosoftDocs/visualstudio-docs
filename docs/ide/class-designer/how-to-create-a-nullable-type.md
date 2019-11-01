---
title: "How to: Create a Nullable Type (Class Designer)"
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "nullable types, Class Designer"
  - "Class Designer [Visual Studio], nullable types"
ms.assetid: 84673a89-3f6d-4668-919e-1c0f56182fe5
author: jillre
ms.author: jillfra
manager: jillfra
dev_langs:
 - CSharp
 - VB
ms.workload:
  - "multiple"
---
# How to: Create a nullable type in Class Designer

Certain value types do not always have (or need) a defined value. This is common practice in databases, where some fields might not be assigned any value. For example, you might assign a null value to a database field to signify that it has not yet been assigned a value.

A *nullable type* is a value type that you extend so that it takes the typical range of values for that type and also a null value. For example, a nullable of `Int32`, also denoted as Nullable\<Int32>, can be assigned any value from -2147483648 to 2147483647, or it can be assigned a null value. A Nullable\<bool> can be assigned the values `True`, `False`, or null (no value at all).

Nullable types are instances of the <xref:System.Nullable%601> structure. Each instance of a nullable type has two public read-only properties, `HasValue` and `Value`:

- `HasValue` is of type `bool` and indicates whether the variable contains a defined value. `True` means that the variable contains a non-null value. You can test for a defined value by using a statement such as `if (x.HasValue)` or `if (y != null)`.

- `Value` is of the same type as the underlying type. If `HasValue` is `True`, `Value` contains a meaningful value. If `HasValue` is `False`, accessing `Value` will throw an invalid operation exception.

By default, when you declare a variable as a nullable type, it has no defined value (`HasValue` is `False`), other than the default value of its underlying value type.

Class Designer displays a nullable type just as it displays its underlying type.

For more information about nullable types in C#, see [Nullable Types](/dotnet/csharp/programming-guide/nullable-types/index). For more information about nullable types in Visual Basic, see [Nullable Value Types](/dotnet/visual-basic/programming-guide/language-features/data-types/nullable-value-types).

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

## To add a nullable type by using the Class Designer

1. In the class diagram, expand an existing class or create a new class.

2. To add a class to the project, on the **Class Diagram** menu, click **Add** > **Add Class**.

3. To expand the class shape, on the **Class Diagram** menu, click **Expand**.

4. Select the class shape. On the **Class Diagram** menu, click **Add** > **Field**. A new field that has the default name **Field** will appear in the class shape and also in the **Class Details** window.

5. In the **Name** column of the **Class Details** window (or in the class shape itself), change the name of the new field to a valid and meaningful name.

6. In the **Type** column of the **Class Details** window, declare the type as a nullable type by specifying the following:

    - `int?` (Visual C#)
    - `Nullable(Of Integer)` (Visual Basic)

## To add a nullable type by using the Code Editor

1. Add a class to the project. Select the project node in **Solution Explorer**, and, on the **Project** menu, click **Add Class**.

2. In the .cs or .vb file for the new class, add one or more nullable types in the new class to the class declaration.

    ```csharp
    // Declare a nullable type in Visual C#:
    class Test
    {
       int? building_number = 5;
    }
    ```

    ```vb
    ' Declare a nullable type in Visual Basic:
    Class Test
       Dim buildingNumber As Nullable(Of Integer) = 5
    End Class
    ```

3. From Class View, drag the new class icon to the Class Designer design surface. A class shape appears in the class diagram.

4. Expand the details for the class shape and move the mouse pointer over the class members. The tooltip displays the declaration of each member.

5. Right-click the class shape and click **Class Details**. You can view or modify the new type's properties in the **Class Details** window.

## See also

- <xref:System.Nullable%601>
- [Nullable Types](/dotnet/csharp/programming-guide/nullable-types/index)
- [Using Nullable Types](/dotnet/csharp/programming-guide/nullable-types/using-nullable-types)
- [How to: Identify a Nullable Type](/dotnet/csharp/programming-guide/nullable-types/how-to-identify-a-nullable-type)
- [Nullable Value Types](/dotnet/visual-basic/programming-guide/language-features/data-types/nullable-value-types)
