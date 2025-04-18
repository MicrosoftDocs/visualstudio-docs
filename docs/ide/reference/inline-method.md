---
title: Inline method
description: Learn how to use the Quick Actions and Refactorings menu in Visual Studio to refactor inline method declarations and provide a clearer syntax. 
ms.date: 11/03/2020
ms.topic: reference
ms.custom: "ide-ref"
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Inline method

This refactoring applies to:

- C#

- Visual Basic

**What:** Inline method refactoring. 

**When:** You want to replace usages of a static, instance, and extension method within a single statement body with an option to remove the original method declaration.

**Why:**  This refactoring will provide a more clear syntax.

## How-to

1. Place your caret on the usage of the method.

2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

3. Select from one of the following options: 
    
   Select **Inline `<QualifiedMethodName>`** to remove the inline method declaration:

    ![Screenshot of the Quick Actions and Refactorings menu in Visual Studio with Convert 'Inline 'CreateWidget()' selected and C# code changes shown.](media/inline-method-remove-declaration.png)

   Select **Inline and keep `<QualifiedMethodName>`** to preserve the original method declaration:

    ![Screenshot of the Quick Actions and Refactorings menu in Visual Studio with Convert 'Inline and keep 'CreateWidget()' selected and C# code changes shown.](media/inline-method-preserve-declaration.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
