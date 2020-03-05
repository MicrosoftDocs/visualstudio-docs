--- 
title: Generate private field from constructor
ms.date: 02/19/2020 
ms.topic: reference 
author: mikadumont
ms.author: midumont
manager: jillfra 
dev_langs: 
  - CSharp 
ms.workload:  
  - "dotnet" 
--- 
# Generate private field from constructor

This refactoring applies to: 

- C# 

**What:** Generate a private field from a constructor. 

**When:** You want to quickly add a private field from a constructor.

**Why:** Writing private fields can be time consuming and repetitive. Using this refactoring is quick and makes the program more robust.

## How-to 

1. Place your cursor on the parameter name within the constructor.

2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   
3. Select the option to **Create and initialize field**.

   ![Generate private field from constructor](media/generate-private-field-from-constructor.png)

## See also 

- [Refactoring](../refactoring-in-visual-studio.md)
