---
title: Generate a method override
description: Learn how to immediately generate the code for any method which can be overridden from a base class.
ms.date: 01/26/2018
ms.topic: reference
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Generate an override in Visual Studio

This code generation applies to:

- C#

- Visual Basic

**What:** Lets you immediately generate the code for any method which can be overridden from a base class.

**When:** You want to override a base class method and generate the signature automatically.

**Why:** You could write the method signature yourself, however this feature will generate the signature automatically.

## How-to

1. Type `override` in C# or `Overrides` in Visual Basic, followed by a space, where you would like to insert an override method.

   - C#:

      ![Override IntelliSense C#](media/override-intellisense-cs.png)

   - Visual Basic:

      ![Override IntelliSense VB](media/override-intellisense-vb.png)

2. Select the method you want to override from the base class.

   > [!TIP]
   > - Use the property icon ![Property icon](media/override-property-cs.png) to show or hide properties in the list.
   > - Use the method icon ![Method icon](media/override-method-cs.png) to show or hide methods in the list.

   The selected method or property is added to the class as an override, ready to be implemented.

   - C#:

       ![Override result C#](media/override-result-cs.png)

   - Visual Basic:

       ![Override result VB](media/override-result-vb.png)

## See also

- [Code Generation](../code-generation-in-visual-studio.md)
