---
title: Refactor a field to a property
description: Learn how to use the Quick Actions and Refactorings menu to convert a field into a property.
ms.date: 01/26/2018
ms.topic: reference
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
f1_keywords:
- vs.csharp.refactoring.encapsulatefield
dev_langs:
- CSharp
- VB
---
# Encapsulate a field refactoring

This refactoring applies to:

- C#

- Visual Basic

**What:** Lets you turn a field into a property, and update all usages of that field to use the newly created property.

**When:** You want to move a field into a property, and update all references to that field.

**Why:** You want to give other classes access to a field, but don't want those classes to have direct access.  By wrapping the field in a property, you could write code to verify the value being assigned, for example.

## How-to

1. Highlight or place the text cursor inside the name of the field to encapsulate:

   - C#:

       ![Highlighted code - C#](media/encapsulate-highlight-cs.png)

   - Visual Basic:

       ![Highlighted code - Visual Basic](media/encapsulate-highlight-vb.png)

2. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl+R**, then **Ctrl+E**.  (Note that your keyboard shortcut may be different based on which profile you've selected.)
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

      ![Encapsulate Property result - C#](media/encapsulate-result-cs.png)

   - Visual Basic:

      ![Encapsulate Property result - Visual Basic](media/encapsulate-result-vb.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
