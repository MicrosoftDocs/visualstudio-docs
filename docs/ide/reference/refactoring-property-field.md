---
title: Property and field refactorings
description: Learn how to use Quick Actions and Refactorings to encapsulate fields, convert between auto and full properties, and convert between Get methods and properties in Visual Studio.
ms.date: 04/03/2026
ms.topic: reference
ms.custom: awp-ai
f1_keywords:
  - vs.csharp.refactoring.encapsulatefield
  - vs.csharp.refactoring.convertmethodtoproperty
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Property and field refactorings

Visual Studio provides several refactorings for working with properties and fields. You can access these refactorings through the **Quick Actions and Refactorings** menu (**Ctrl**+**.**).

## Encapsulate field

**Applies to:** C#, Visual Basic

This refactoring turns a field into a property, and updates all usages of that field to use the newly created property. This enables you to control access by writing validation code in the property.

1. Highlight or place the text cursor inside the name of the field to encapsulate:

   - C#:

       ![Screenshot of Highlighted code - C#.](media/encapsulate-highlight-cs.png)

   - Visual Basic:

       ![Screenshot of Highlighted code - Visual Basic.](media/encapsulate-highlight-vb.png)

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl+R**, then **Ctrl+E**. (Your keyboard shortcut may be different based on which profile you've selected.)
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu and select either **Encapsulate field** entry from the Preview window popup.
   - **Mouse**
      - Select **Edit > Refactor > Encapsulate Field**.
      - Right-click the code, select the **Quick Actions and Refactorings** menu and select either **Encapsulate field** entry from the Preview window popup.

   Selection | Description
   --------- | -----------
   **Encapsulate field (and use property)** | Encapsulates the field with a property, and updates all usages of the field to use the generated property
   **Encapsulate field (but still use field)** | Encapsulates the field with a property, but leaves all usages of the field untouched

   The property is created and references to the field are updated, if selected.

   > [!TIP]
   > Use the **Preview changes** link in the popup window [to see what the result will be](../../ide/preview-changes.md) before committing to it.

   - C#:

      ![Screenshot of Encapsulate Property result - C#.](media/encapsulate-result-cs.png)

   - Visual Basic:

      ![Screenshot of Encapsulate Property result - Visual Basic.](media/encapsulate-result-vb.png)

## Convert between auto property and full property

**Applies to:** C#

This refactoring converts between an auto-implemented property and a full property, useful when the logic of the property has changed and you need a backing field.

1. Place your cursor on the property name.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
1. Select from the following two options:

    Select **Convert to full property**.

    ![Screenshot of Convert auto property to full property.](media/convert-auto-property-to-full-property.png)

    Select **Use auto property**.

    ![Screenshot of Convert full property to auto property.](media/convert-full-property-to-auto-property.png)

## Convert between Get method and property

**Applies to:** C#, Visual Basic

This section covers bidirectional conversion between Get methods and properties.

### Convert Get method to property

This refactoring converts a Get method into a property (and optionally the Set method), useful when a Get method doesn't contain any logic.

1. Place your cursor in your Get method name.

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu, and select **Replace method with property** from the Preview window popup.
   - **Mouse**
      - Right-click the code, select the **Quick Actions and Refactorings** menu, and select **Replace method with property** from the Preview window popup.

1. (Optional) If you have a Set method, you can also convert your Set method at this time by selecting **Replace Get method and Set method with property**.

1. If you are happy with the change in the code preview, press **Enter** or click the fix from the menu and the changes will be committed.

Example:

```csharp
private int MyValue;

// Before
public int GetMyValue()
{
    return MyValue;
}

// Replace 'GetMyValue' with property

// After
public int MyValue
{
    get { return MyValue; }
}
```

### Convert property to Get method

This refactoring converts a property to a Get method, useful when a property involves more than immediately setting and getting a value.

1. Place your cursor in your Get method name.

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu and select **Replace property with methods** from the Preview window popup.
   - **Mouse**
      - Right-click the code, select the **Quick Actions and Refactorings** menu and select **Replace property with methods** from the Preview window popup.

1. If you are happy with the change in the code preview, press **Enter** or click the fix from the menu and the changes will be committed.

## Related content

- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
