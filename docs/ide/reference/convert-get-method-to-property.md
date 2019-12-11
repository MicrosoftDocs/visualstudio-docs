---
title: Convert Get method to property; convert property to Get method
ms.date: 01/26/2018
ms.topic: reference
ms.devlang: csharp
author: jillre
ms.author: jillfra
manager: jillfra
f1_keywords:
  - "vs.csharp.refactoring.convertmethodtoproperty"
dev_langs:
  - CSharp
ms.workload:
  - "dotnet"
---
# Convert Get method to property / Convert property to Get method refactorings

These refactorings apply to:

- C#

## Convert Get method to property

**What:** Lets you convert a Get method into a property (and optionally your Set method).

**When:** You have a Get method that does not contain any logic.

### How-to

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

## Convert property to Get method

**What:** Lets you convert a property to a Get method

**When:** You have a property that involves more than immediately setting and getting a value

### How-to

1. Place your cursor in your Get method name.

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu and select **Replace property with methods** from the Preview window popup.
   - **Mouse**
      - Right-click the code, select the **Quick Actions and Refactorings** menu and select **Replace property with methods** from the Preview window popup.

1. If you are happy with the change in the code preview, press **Enter** or click the fix from the menu and the changes will be committed.

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)