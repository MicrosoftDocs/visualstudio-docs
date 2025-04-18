---
title: Generate class or type
description: Learn how to use the Quick Actions and Refactorings menu to immediately generate the code for a class or type.
ms.date: 01/26/2018
ms.topic: reference
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
f1_keywords:
- vsl.GenerateFromUsage
dev_langs:
- CSharp
- VB
---
# Generate a class or type in Visual Studio

This code generation applies to:

- C#

- Visual Basic

**What:** Lets you immediately generate the code for a class or type.

**When:** You introduce a new class or type and want to properly declare it, automatically.

**Why:** You could declare the class or type before using it, however this feature will generate the class or type automatically.

## How-to

1. Place your cursor on the line where there is a red squiggle. The red squiggle indicates a class that doesn't yet exist.

   - C#:

       ![Highlighted code C#](media/class-highlight-cs.png)

   - Visual Basic:

       ![Highlighted code VB](media/class-highlight-vb.png)

2. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   - **Mouse**
      - Right-click and select the **Quick Actions and Refactorings** menu.
      - Hover over the red squiggle and click the ![error light bulb](media/error-bulb.png) icon that appears.
      - Click the ![error light bulb](media/error-bulb.png) icon that appears in the left margin if the text cursor is already on the line with the red squiggle.

      ![Generate class preview](media/class-preview-cs.png)

3. Select one of the options from the drop-down menu:

   - Generate class '*TypeName*' in new file&mdash;Creates a class named *TypeName* in a file named *TypeName*.cs/.vb
   - Generate class '*TypeName*'&mdash;Creates a class named *TypeName* in the current file.
   - Generate nested class '*TypeName*'&mdash;Creates a class named *TypeName* nested inside the current class.
   - Generate new type...&mdash;Creates a new class or struct with all of the properties you specify.

   > [!TIP]
   > Use the **Preview changes** link at the bottom of the preview window [to see all of the changes](../../ide/preview-changes.md) that will be made before making your selection.

4. If you selected the **Generate new type** item, the **Generate Type** dialog box opens. Configure the accessibility, kind, and location of the new type.

   ![Generate type](media/class-newtype-cs.png)

   Selection | Description
   --- | ---
   Access | Set the type to have *Default*, *Internal* or *Public* access.
   Kind | This can be set as *class* or *struct*.
   Name | This cannot be changed and will be the name you already typed.
   Project | If there are multiple projects in your solution, you can choose where you want the class/struct to live.
   File Name | You can create a new file or you can add the type to an existing file.

The class or struct is created. For C#, a constructor is also created.

- C#

   ![Generate class result C#](media/class-result-cs.png)

- Visual Basic

   ![Generate class result VB](media/class-result-vb.png)

## See also

- [Code Generation](../code-generation-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
