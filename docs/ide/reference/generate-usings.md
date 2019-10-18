---
title: Generate usings
ms.date: 02/19/2019
ms.topic: reference
author: kendrahavens
ms.author: kehavens
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "dotnet"
helpviewer_keywords:
  - "add missing usings"
---
# Add missing usings in Visual Studio

This code generation applies to:

- C#

**What:** Lets you immediately add the necessary imports or [using directives](/dotnet/csharp/language-reference/keywords/using-directive) for copy-and-pasted code.

**When:** It's common practice to copy code from different places in your project or other sources and paste it in to new code. This Quick Action finds missing imports directives for copy-and-pasted code and then prompts you to add them.

**Why:** Because the Quick Action automatically adds necessary imports, you don't need to manually copy the `using` directives that your code needs.

## Add missing usings refactoring

1. Copy code from a file and paste it into a new one without including the necessary `using` directives. The resulting error is accompanied by a code fix that adds the missing `using` directives.

    > [!NOTE]
    > You need to enable this suggestion in **Tools > Options > Text Editor > C# > Advanced > Using Directives**.

2. Select Ctrl+. to open the **Quick Actions and Refactorings** menu.

    ![Generate usings](media/generate-using-codefix.png)

3. Select **using \<your reference\>;** to add the missing reference.

    ![Generate usings result](media/generate-using-result.png)

## See also

- [Code generation](../code-generation-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
- [Tips for .NET developers](../csharp-developer-productivity.md)
