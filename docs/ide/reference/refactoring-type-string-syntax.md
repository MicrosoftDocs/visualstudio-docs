---
title: Type, string, and syntax conversion refactorings
description: Learn how to use Quick Actions and Refactorings to convert anonymous types, string literals, typeof/nameof, var/explicit types, and simplify string interpolation in Visual Studio.
ms.date: 04/03/2026
ms.topic: reference
ms.custom: awp-ai
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Type, string, and syntax conversion refactorings

Visual Studio provides several refactorings for converting between types, string formats, and syntax styles. You can access these refactorings through the **Quick Actions and Refactorings** menu (**Ctrl**+**.**).

## Convert anonymous type to class

**Applies to:** C#, Visual Basic

This refactoring converts an anonymous type to a named class, useful when your code grows and you want to continue building on the type.

1. Place your cursor in an anonymous type.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

   ![Screenshot of Convert Anonymous Type to Class.](media/convert-anon-to-class.png)

1. Press **Enter** to accept the refactoring.

   ![Screenshot of Convert Anonymous Type to Class accepted.](media/convert-anon-to-class-complete.png)

## Convert anonymous type to tuple

**Applies to:** C#, Visual Basic

This refactoring converts an anonymous type to a tuple for more lightweight syntax.

1. Place your cursor in an anonymous type.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

   ![Screenshot of Convert Anonymous Type to Tuple.](media/convert-anon-to-tuple.png)

1. Press **Enter** to accept the refactoring.

   ![Screenshot of Convert Anonymous Type to Tuple accepted.](media/convert-anon-to-tuple-complete.png)

## Convert between regular string and verbatim string literals

**Applies to:** C#

This refactoring converts between regular string and verbatim string literals. Converting to a regular string can save space, while converting to a verbatim string can provide more clarity.

1. Place your caret on either the regular string or verbatim string literal.

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

1. Select one of the following options:

    Select **Convert to regular string**.

    ![Screenshot of Convert to regular string.](media/convert-to-regular-string.png)

    Select **Convert to verbatim string**.

    ![Screenshot of Convert to verbatim string.](media/convert-to-verbatim-string.png)

## Convert typeof to nameof

**Applies to:** C#, Visual Basic

This refactoring converts `typeof(<QualifiedType>).Name` to `nameof(<QualifiedType>)` in C# and `GetType(<QualifiedType>).Name` to `NameOf(<QualifiedType>)` in Visual Basic. Using `nameof` avoids the reflection involved with retrieving a `type` object.

1. Place your cursor within the `typeof(<QualifiedType>).Name` instance for C# or the `GetType(<QualifiedType>).Name` in Visual Basic.

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

1. Select from one of the following options:

    - C#
      <br>Select **Convert 'typeof' to 'nameof'**:
      ![Screenshot of the Quick Actions and Refactorings menu in Visual Studio with Convert 'typeof' to 'nameof' selected, and C# code changes shown.](media/convert-type-of.PNG)

    - Visual Basic
      <br>Select **Convert 'GetType' to 'NameOf'**:
      ![Screenshot of the Quick Actions and Refactorings menu in Visual Studio with Convert 'GetType' to 'NameOf' selected and Visual Basic code changes shown.](media/convert-get-type.PNG)

## Use explicit type instead of var

**Applies to:** C#

This refactoring replaces [var](/dotnet/csharp/language-reference/keywords/var) in a local variable declaration with an explicit type, improving readability. However, [var](/dotnet/csharp/language-reference/keywords/var) must be used when a variable is initialized with an anonymous type and the properties of the object are accessed at a later point. For more information, see [Implicitly typed local variables (C#)](/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables).

1. Place the caret on the `var` keyword.

1. Press **Ctrl**+**.** or click the screwdriver ![screwdriver icon](../media/screwdriver-icon.png) icon in the margin of the code file.

   ![Screenshot of Use explicit type quick actions menu.](media/use-explicit-type.png)

1. Select **Use explicit type**. Or, select **Preview changes** to open the [Preview Changes](../../ide/preview-changes.md) dialog, and then select **Apply**.

## Simplify string interpolation

**Applies to:** C#, Visual Basic

This refactoring simplifies a [string interpolation](/dotnet/csharp/tutorials/string-interpolation) expression for more clarity and concise syntax.

1. Place your caret on the string interpolation.

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

1. Select **Simplify interpolation**.

    ![Screenshot of Simplify string interpolation.](media/simplify-string-interpolation.png)

## Related content

- [Refactoring](../refactoring-in-visual-studio.md)
