---
title: Generate usings
ms.date: 02/19/2019
ms.topic: reference
author: kendrahavens
ms.author: kendrahavens
manager: jillfra
ms.workload:
  - "dotnet"
---
# Generate usings in Visual Studio

This code generation applies to:

- C#

**What:** Lets you immediately add the necessary imports or "usings statements" of copy and pasted code.

**When:** It's common practice to copy and paste code from different places in your project or other code sources. This quick action analyzes missing imports of copy and pasted code and then prompts you to add them.

**Why:** By automatically adding necessary imports, the user doesn't need to go back and also copy the needed using statements.

## How-to

1. Copy and paste code from a different file without including the necessary using statements. The error is now accompanied by a codefix that adds the missing using statements.

    > [!NOTE] This suggestion needs to be turned on in **Tools > Options > Text Editor > C# > Advanced > Using Directives**.

2. Press **Ctrl**+**.** to open the **Quick Actions and Refactorings** menu. 

    ![Generate usings](media/generate-using-codefix.png)

3. Select **using \<your reference\>;** to add the missing reference.

    ![Generate usings result](media/generate-using-result.png)

## See also

- [Code Generation](../code-generation-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)