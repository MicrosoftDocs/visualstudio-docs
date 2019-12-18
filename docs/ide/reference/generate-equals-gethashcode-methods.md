---
title: Generate C# Equals and GetHashCode Method Overrides
ms.date: 01/26/2018
ms.topic: reference
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "dotnet"
---
# Generate Equals and GetHashCode method overrides in Visual Studio

This code generation applies to:

- C#

**What:** Lets you generate **Equals** and **GetHashCode** methods.

**When:** Generate these overrides when you have a type that should be compared by one or more fields, instead of by object location in memory.

**Why:**

- If you are implementing a value type, you should consider overriding the **Equals** method to gain increased performance over the default implementation of the Equals method on ValueType.

- If you are implementing a reference type, you should consider overriding the **Equals** method if your type looks like a base type, such as Point, String, BigNumber, and so on.

- Override the **GetHashCode** method to allow a type to work correctly in a hash table. Read more guidance on [equality operators](/dotnet/standard/design-guidelines/equality-operators).

## How-to

1. Place your cursor somewhere on the line of your type declaration.

   ![Highlighted code](media/overrides-highlight-cs.png)

   > [!TIP]
   > Do not double-click select the type name, or the menu option won't be available. Just place the cursor somewhere on the line.

1. Next, do one of the following:

   - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

   - Right-click and select the **Quick Actions and Refactorings** menu.

   - Click the ![screwdriver](../media/screwdriver-icon.png) icon that appears in the left margin.

   ![Generate overrides preview](media/overrides-preview-cs.png)

1. Select **Generate Equals(object)** or **Generate Equals and GetHashCode** from the drop-down menu.

1. In the **Pick members** dialog box, select the members you want to generate the methods for:

    ![Generate overrides dialog](media/overrides-dialog-cs.png)

    > [!TIP]
    > You can also choose to generate operators from this dialog by using the checkbox near the bottom of the dialog.

   The `Equals` and `GetHashCode` methods are generated with default implementations.

   ![Generate method result](media/overrides-result-cs.png)

## See also

- [Code Generation](../code-generation-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)