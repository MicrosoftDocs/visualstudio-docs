---
title: "Supported Code Changes (C# and Visual Basic) | Microsoft Docs"
description: Understand what code changes are supported when you are using the Edit and Continue feature while debugging a C# or Visual Basic project in Visual Studio.
ms.date: "01/18/2023"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
helpviewer_keywords:
  - "Edit and Continue [C#], supported code changes"
  - "Edit and Continue [Visual Basic], supported code changes"
ms.assetid: c7a48ea9-5a7f-4328-a9d7-f0e76fac399d
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "dotnet"
---
# Supported code changes (C# and Visual Basic)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Edit and Continue handles most types of code changes within method bodies. Most changes outside method bodies, and a few changes within method bodies, can't be applied during debugging, however. To apply those unsupported changes, you must stop debugging and restart with a fresh version of the code.

## Supported changes to code

The table below shows the changes that may be made to C# and Visual Basic code during a debugging session without restarting the session.

|Language element/feature|Supported edit operation|Limitations|
|-|-|-|
|Types|Add methods, fields, constructors, et al|[Yes](https://github.com/dotnet/roslyn/blob/master/docs/wiki/EnC-Supported-Edits.md)|
|Iterators|Add or modify|No|
|async/await expressions|Add or modify|[Yes](https://github.com/dotnet/roslyn/blob/master/docs/wiki/EnC-Supported-Edits.md)|
|Dynamic objects|Add or modify|No|
|lambda expressions|Add or modify|[Yes](https://github.com/dotnet/roslyn/blob/master/docs/wiki/EnC-Supported-Edits.md)|
|LINQ expressions|Add or modify|[Same as lambda expressions](https://github.com/dotnet/roslyn/blob/master/docs/wiki/EnC-Supported-Edits.md)|

> [!NOTE]
> Newer language features such as string interpolation and null-conditional operators are generally supported by Edit and Continue. For the most current information, see the [Enc Supported Edits](https://github.com/dotnet/roslyn/blob/master/docs/wiki/EnC-Supported-Edits.md) page.

::: moniker range=">=vs-2022"

## .NET 6+ improvements

Improvements in .NET 6+ and Visual Studio 2022 and later versions include support for more types of edits that go beyond what was originally possible in older versions of Visual Studio. Improvements include:

[!INCLUDE [dotnet-hot-reload-and-edit-continue](../debugger/includes/dotnet-hot-reload-and-edit-continue.md)]

The preceding improvements are available to both Hot Reload and the Edit and Continue experiences.
::: moniker-end

## Unsupported changes to code

 The following changes can't be applied to C# and Visual Basic code during a debugging session:

- Changes to the current statement or any other active statement.

     Active statements include any statements, in functions on the call stack, that were called to get to the current statement.

     The current statement is marked by a yellow background in the source window. Other active statements are marked by a shaded background and are read-only. These default colors can be changed in the **Options** dialog box.

- The following table shows unsupported changes to code by language element.

|Language element or feature|Unsupported edit operation|
|-|-|
|All code elements|Renaming|
|Namespaces|Add|
|Namespaces, types, members|Delete|
|Generics|Add or modify|
|Interfaces|Modify|
|Types|Add abstract or virtual member, add override (see [details](https://github.com/dotnet/roslyn/blob/master/docs/wiki/EnC-Supported-Edits.md))|
|Types|Add destructor|
|Members|Modify a member referencing an embedded interop type|
|Members|Modify a static member after it has already been accessed by executing code|
|Members (Visual Basic)|Modify a member with On Error or Resume statement|
|Members (Visual Basic)|Modify a member containing an Aggregate, Group By, Simple Join, or Group Join LINQ query clause|
|Methods|Modify signatures|
|Methods|Make an abstract method become non-abstract by adding a method body|
|Methods|Delete method body|
|Attributes|Add or modify|
|Events or properties|Modify a type parameter, base type, delegate type, or return type |
|Operators or indexers|Modify a type parameter, base type, delegate type, or return type |
|catch blocks|Modify when it contains an active statement|
|try-catch-finally blocks|Modify when it contains an active statement|
|using statements|Add|
|async methods/lambdas|Modify an async method/lambda in a project targeting .NET Framework 4 and lower (see [details](https://github.com/dotnet/roslyn/blob/master/docs/wiki/EnC-Supported-Edits.md))|
|Iterators|Modify an iterator in a project targeting .NET Framework 4 and lower (see [details](https://github.com/dotnet/roslyn/blob/master/docs/wiki/EnC-Supported-Edits.md))|

## Unsafe code

 Changes to unsafe code have the same limitations as changes to safe code, with one additional restriction: Edit and Continue doesn't support changes to unsafe code that exits within a method that contains the `stackalloc` operator.

## Unsupported app scenarios

Unsupported apps and platforms include Silverlight 5 and Windows 8.1. Unsupported scenarios in ASP.NET and ASP.NET Core include editing *_.aspx_*, *_.ascx_*, *_.cshtml_*, and *_.razor_* files. Editing *_.cshtml_* and *_.razor_* files is supported in .NET 6 and later apps.

> [!NOTE]
> Apps that are supported include UWP in Windows 10 or Windows 11, and x86 and x64 apps that target the .NET Framework 4.6 desktop or later versions (the .NET Framework is a desktop version only).

## Unsupported scenarios

 Edit and Continue isn't available in the following debugging scenarios:

- Mixed-mode (native/managed) debugging.

- SQL debugging.

- Debugging a Dr. Watson dump.

- Debugging an embedded runtime application.

- Debugging an application using attach to process (**Debug > Attach to Process**) instead of running the application by choosing **Start** from the **Debug** menu.

- Debugging optimized code.

- Debugging an old version of your code after a new version failed to build because of build errors.

## See also

- [Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md)
- [How to: Use Edit and Continue (C#)](../debugger/how-to-use-edit-and-continue-csharp.md)
