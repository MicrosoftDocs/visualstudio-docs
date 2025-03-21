---
title: "Supported Code Changes (C# and Visual Basic)"
description: Understand what code changes are supported when you're using the Edit and Continue feature while debugging a C# or Visual Basic project in Visual Studio.
ms.date: "3/21/2025"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
helpviewer_keywords:
  - "Edit and Continue [C#], supported code changes"
  - "Edit and Continue [Visual Basic], supported code changes"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Supported code changes (C# and Visual Basic)

::: moniker range=">=vs-2022"
The Hot Reload mechanism, previously called Edit and Continue, handles most types of code changes within method bodies. Most changes outside method bodies, and a few changes within method bodies, can't be applied during debugging, however. To apply those unsupported changes, you must stop debugging and restart with a fresh version of the code.
::: moniker-end

::: moniker range="vs-2019"
The Edit and Continue mechanism handles most types of code changes within method bodies. Most changes outside method bodies, and a few changes within method bodies, can't be applied during debugging, however. To apply those unsupported changes, you must stop debugging and restart with a fresh version of the code.
::: moniker-end

## Supported changes to code

The following table shows the changes that might be made to C# and Visual Basic code during a debugging session without restarting the session.

::: moniker range=">=vs-2022"
| Language element or feature | Supported edit operation | Limitations |
|---|---|---|
| Types |Add methods, fields, constructors, and more |[Yes](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) |
| Iterators | Add or modify | No |
| async/await expressions | Add or modify | [Yes](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) |
| Dynamic objects | Add or modify | No |
| lambda expressions | Add or modify | [Yes](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) |
| LINQ expressions | Add or modify | [Same as lambda expressions](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) |
| Generics | Add or modify | [Yes](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md)
::: moniker-end

::: moniker range="vs-2019"
| Language element or feature | Supported edit operation | Limitations |
|---|---|---|
| Types |Add methods, fields, constructors, and more |[Yes](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) |
| Iterators | Add or modify | No |
| async/await expressions | Add or modify | [Yes](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) |
| Dynamic objects | Add or modify | No |
| lambda expressions | Add or modify | [Yes](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) |
| LINQ expressions | Add or modify | [Same as lambda expressions](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) |
::: moniker-end

> [!NOTE]
> Newer language features such as string interpolation and null-conditional operators are generally supported by Edit and Continue. For the most current information, see the [Enc Supported Edits](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) page.

::: moniker range=">=vs-2022"

## .NET 6+ improvements

Improvements in .NET 6+ and Visual Studio 2022 and later versions include support for more types of edits that go beyond what was originally possible in older versions of Visual Studio. These improvements are available to both Hot Reload and the Edit and Continue experiences.

The .NET 6+ Hot Reload experience is powered by the [Edit and Continue](../debugger/edit-and-continue-visual-csharp.md) mechanism and Roslyn. [Supported Edits](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) lists the types of edits currently supported by Roslyn and potential future enhancements.

::: moniker-end

## Unsupported changes to code

The following changes can't be applied to C# and Visual Basic code during a debugging session.

- Changes to the current statement or any other active statement.

   An active statement is any statement in a function on the call stack that was called to get to the current statement.

   The current statement appears on a yellow background in the source window. Other active statements appear on a shaded background and are read-only. These default colors can be changed in the **Options** dialog box.

- Any unsupported changes to code by language element as outlined in the following table.

   ::: moniker range=">=vs-2022"
   For .NET 6+ and Visual Studio 2022, see [Supported Edits](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md) for the types of edits currently unsupported.
   ::: moniker-end

   ::: moniker range=">=vs-2022"
   | Language element or feature | Unsupported edit operation |
   |---|---|
   | All code elements | Renaming |
   | Namespaces | Add |
   | Namespaces, types, members | Delete |
   | Interfaces | Modify |
   | Types | Add abstract or virtual member, add override (see [details](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md)) |
   | Types | Add destructor |
   | Members | - Modify a member referencing an embedded interop type <br> - Modify a static member after it has already been accessed by executing code |
   | Members (Visual Basic) | - Modify a member with On Error or Resume statement <br> - Modify a member containing an Aggregate, Group By, Simple Join, or Group Join LINQ query clause |
   | Methods | - Modify signatures <br> - Make an abstract method become nonabstract by adding a method body <br> - Delete method body |
   | Attributes | Add or modify |
   | Events or properties | Modify a type parameter, base type, delegate type, or return type |
   | Operators or indexers | Modify a type parameter, base type, delegate type, or return type |
   | catch blocks | Modify when it contains an active statement |
   | try-catch-finally blocks | Modify when it contains an active statement |
   | using statements | Add |
   | async methods/lambdas | Modify an async method/lambda in a project targeting .NET Framework 4 and lower (see [details](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md)) |
   | Iterators | Modify an iterator in a project targeting .NET Framework 4 and earlier (see [details](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md)) |
   ::: moniker-end

   ::: moniker range="vs-2019"
   | Language element or feature | Unsupported edit operation |
   |---|---|
   | All code elements | Renaming |
   | Namespaces | Add |
   | Namespaces, types, members | Delete |
   | Generics | Add or modify |
   | Interfaces | Modify |
   | Types | Add abstract or virtual member, add override (see [details](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md)) |
   | Types | Add destructor |
   | Members | - Modify a member referencing an embedded interop type <br> - Modify a static member after it has already been accessed by executing code |
   | Members (Visual Basic) | - Modify a member with On Error or Resume statement <br> - Modify a member containing an Aggregate, Group By, Simple Join, or Group Join LINQ query clause |
   | Methods | - Modify signatures <br> - Make an abstract method become nonabstract by adding a method body <br> - Delete method body |
   | Attributes | Add or modify |
   | Events or properties | Modify a type parameter, base type, delegate type, or return type |
   | Operators or indexers | Modify a type parameter, base type, delegate type, or return type |
   | catch blocks | Modify when it contains an active statement |
   | try-catch-finally blocks | Modify when it contains an active statement |
   | using statements | Add |
   | async methods/lambdas | Modify an async method/lambda in a project targeting .NET Framework 4 and lower (see [details](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md)) |
   | Iterators | Modify an iterator in a project targeting .NET Framework 4 and earlier (see [details](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md)) |
   ::: moniker-end

## Unsafe code

Changes to unsafe code have the same limitations as changes to safe code, with one extra restriction: Edit and Continue doesn't support changes to unsafe code that exits within a method that contains the `stackalloc` operator.

## Application support

Supported applications include:

- UWP apps in Windows 10 or Windows 11
- x86 and x64 apps that target the .NET Framework 4.6 desktop or later versions (the .NET Framework is a desktop version only)

For .NET 6 and later, editing is supported for the following file types:

- .cshtml
- .razor

### Unsupported apps, platforms, and operations

Unsupported applications or platforms include:

- F#
- .NET Native
- Silverlight 5
- Windows 8.1
- Xamarin.Forms (iOS and Android)

For ASP.NET and ASP.NET Core, editing isn't supported for the following file types:

::: moniker range=">=vs-2022"
- .aspx
- .ascx
::: moniker-end

::: moniker range="vs-2019"
- .aspx
- .ascx
- .cshtml
- .razor
::: moniker-end

## Unsupported scenarios

Edit and Continue isn't available in the following debugging scenarios:

- Mixed-mode (native/managed) debugging.

- Debugging on Arm64 without targeting .NET 7 or later.

- Debugging with the **COR_ENABLE_PROFILING** environment variable set.

- Debugging an application using attach to process (**Debug > Attach to Process**) instead of running the application by choosing **Start** from the **Debug** menu. If you wish to use Edit and Continue when attaching to a process, the **COMPLUS_ForceENC** environment variable must be set prior to launching the process (`set COMPLUS_ForceENC=1`).

- Debugging with nondeterministic (for example, time based) assembly versions. If you wish to use Edit and Continue, consider setting the version only in Release (or CI) builds and keep the version in Debug builds constant.

- Debugging optimized code.

- SQL debugging.

- Debugging a dump file.

- Debugging an embedded runtime application.

- Debugging an old version of your code after a new version failed to build because of build errors.

## Related content

- [Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md)
- [How to: Use Edit and Continue (C#)](../debugger/how-to-use-edit-and-continue-csharp.md)
- [Configure Edit and Continue](../debugger/how-to-enable-and-disable-edit-and-continue.md)
