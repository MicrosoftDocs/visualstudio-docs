---
title: Code generation features in Visual Studio | Microsoft Docs
ms.custom: ""
ms.date: "01/11/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.topic: article
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload:
  - "dotnet"
---
# Code generation features in Visual Studio

There are numerous ways to have Visual Studio generate code for you in the editor. By using these code generation features, you can save time and keystrokes, reduce syntax errors, and improve consistency across your code. Some of the features in Visual Studio that generate code for you include [code snippets](../ide/code-snippets.md), [Quick Actions](../ide/quick-actions.md), and [T4 text templates](../modeling/code-generation-and-t4-text-templates.md).

Some common code generation features include:

* Generating classes, methods, types, etc.
* Generating XML Documentation Comments
* Implementing abstract classes or interfaces
* Introducing a local variable into a complex expression

Because the logic of code generation is closely tied to language syntax, each language service in Visual Studio provides its own code generation capabilities.

Additionally, by typing certain characters you can:

- generate [XML-formatted comment blocks]() for your code that can later be processed to produce documentation automatically

- generate [method override]() signatures

## See also

[Quick Actions](../ide/quick-actions.md)  
[Code Snippets](../ide/code-snippets.md)  
[Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md)