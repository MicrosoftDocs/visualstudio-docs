---
title: Configuring Warnings in Visual Basic
description: Configure warnings like 'warn as error' and 'no warn' in Visual Basic to help you write cleaner, faster, better code with fewer bugs.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- errors [Visual Basic], warnings
- run-time errors, warnings
- warnings, configuring
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Configuring warnings in Visual Basic

The Visual Basic compiler includes a set of warnings about code that may cause run-time errors. You can use that information to write cleaner, faster, better code with fewer bugs. For example, the compiler will produce a warning when the user attempts to invoke a member of an unassigned object variable, return from a function without setting the return value, or execute a `Try` block with errors in the logic to catch exceptions.

Sometimes the compiler provides extra logic on the user's behalf so that the user can focus on the task at hand, rather than on anticipating possible errors. In previous versions of Visual Basic, **Option Strict** was used to limit the additional logic that the Visual Basic compiler provides. Configuring warnings allows you to limit this logic in a more granular way, at the level of the individual warnings.

You may want to customize your project and turn off some warnings not pertinent to your application while turning other warnings into errors. This page explains how to turn individual warnings on and off.

## Turning warnings off and on

There are several different ways to configure warnings: you can configure them using the **Project Designer**, you can use the **/warnaserror** and **/nowarn** compiler options, or you can edit the project file (`vbproj` file) and use the `NoWarn` MSBuild property. To use the MSBuild property, see [Suppress specific warnings for an entire Visual Basic project](how-to-suppress-compiler-warnings.md#to-suppress-specific-warnings-for-an-entire-visual-basic-project).

:::moniker range=">=vs-2022"
The **Project Designer** experience differs depending on whether you're working with a .NET Framework project or a .NET Core (or .NET 5 or later) project.

In .NET Core (or .NET 5 and later) projects, the **Compile** section of the **Project Designer** contains a setting called **Warning severity** that you can use to disable all warnings, promote all warnings to errors, or you can choose to control each category of warning separately (the default). The warning category settings appear in the same area of the **Project Designer**.

In .NET Framework projects, in the **Compile** tab of the **Project Designer**, select the **Disable All Warnings** check box to disable all warnings; select the **Treat All Warnings as Errors** to treat all warnings as errors. Some individual warnings can be toggled as error or warning as desired in the displayed table.

:::moniker-end

:::moniker range="<=vs-2019"
The **Compile** tab of the **Project Designer** page allows you to turn warnings on and off. Select the **Disable All Warnings** check box to disable all warnings; select the **Treat All Warnings as Errors** to treat all warnings as errors. Some individual warnings can be toggled as error or warning as desired in the displayed table.
:::moniker-end

When **Option Strict** is set to **Off**, **Option Strict** related warnings cannot be treated independently of each other. When **Option Strict** is set to **On**, the associated warnings are treated as errors, no matter what their status is. When **Option Strict** is set to **Custom** by specifying `/optionstrict:custom` in the command line compiler, **Option Strict** warnings can be toggled on or off independently.

The **/warnaserror** command-line option of the compiler can also be used to specify whether warnings are treated as errors. You can add a comma delimited list to this option to specify which warnings should be treated as errors or warnings by using + or -. The following table details the possible options.

|Command-line option|Specifies|
| - |---------------|
|`/warnaserror+` or `/warnaserror`|Treat all warnings as errors|
|`/warnsaserror-`|Do not treat warnings as errors. This setting is the default.|
|`/warnaserror+:<warning list` `>`|Treat specific warnings as errors, listed by their error ID number in a comma delimited list r.|
|`/warnaserror-:<warning list>`|Do not treat specific warnings as errors, listed by their error ID number in a comma delimited list.|
|`/nowarn`|Do not report warnings.|
|`/nowarn:<warning list>`|Do not report specified warnings, listed by their error ID number in a comma delimited list.|

The warning list contains the error ID numbers of the warnings that should be treated as errors, which can be used with the command-line options to turn specific warnings on or off. If the warning list contains an invalid number, an error is reported.

## Examples
This table of examples of command line arguments describes what each argument does.

|Argument|Description|
|--------------|-----------------|
|`vbc /warnaserror`|Specifies that all warnings should be treated as errors.|
|`vbc /warnaserror:42024`|Specifies that warning 42024 should be treated as an error.|
|`vbc /warnaserror:42024,42025`|Specifies that warnings 42024 and 42025 should be treated as errors.|
|`vbc /nowarn`|Specifies that no warnings should be reported.|
|`vbc /nowarn:42024`|Specifies that warning 42024 should not be reported.|
|`vbc /nowarn:42024,42025`|Specifies that warnings 42024 and 42025 should not be reported.|

## Types of warnings
Following is a list of warnings that you might want to treat as errors.

### Implicit conversion warning
Generated for instances of implicit conversion. They do not include implicit conversions from an intrinsic numeric type to a string when using the `&` operator. Default for new projects is off.

ID: 42016

### Late bound method invocation and overload resolution warning
Generated for instances of late binding. Default for new projects is off.

ID: 42017

### Operands of type 'Object' warnings
Generated when operands of type `Object` occur that would create an error with **Option Strict On**. Default for new projects is on.

ID: 42018 and 42019

### Declarations require 'As' clause warnings
Generated when a variable, function, or property declaration lacking an `As` clause would have created an error with **Option Strict On**. Variables that do not have a type assigned to them are assumed to be type `Object`. Default for new projects is on.

ID: 42020 (variable declaration), 42021 (function declaration), and 42022 (property declaration).

### Possible null reference exception warnings
Generated when a variable is used before it has been assigned a value. Default for new projects is on.

ID: 42104, 42030

### Unused local variable warning
Generated when a local variable is declared but never referred to. Default is on.

ID: 42024

### Access of shared member through instance variable warning
Generated when accessing a shared member through an instance may have side effects, or when accessing a shared member through an instance variable is not the right-hand side of an expression or is being passed in as a parameter. Default for new projects is on.

ID: 42025

### Recursive operator or property access warnings
Generated when the body of a routine uses the same operator or property it is defined in. Default for new projects is on.

ID: 42004 (operator), 42026 (property)

### Function or operator without return value warning
Generated when the function or operator does not have a return value specified. This includes omitting a `Set` to the implicit local variable with the same name as the function. Default for new projects is on.

ID: 42105 (function), 42016 (operator)

### Overloads modifier used in a module warning
Generated when `Overloads` is used in a `Module`. Default for new projects is on.

ID: 42028

### Duplicate or overlapping catch blocks warnings
Generated when a `Catch` block is never reached due to its relation to other `Catch` blocks that have been defined. Default for new projects is on.

ID: 42029, 42031

## Related content

- [Error types](/dotnet/visual-basic/programming-guide/language-features/error-types)
- [Try...Catch...Finally statement](/dotnet/visual-basic/language-reference/statements/try-catch-finally-statement)
- [/nowarn](/dotnet/visual-basic/reference/command-line-compiler/nowarn)
- [/warnaserror (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/warnaserror)
- [Compile page, Project Designer (Visual Basic)](../ide/reference/compile-page-project-designer-visual-basic.md)
- [Compiler warnings that are off by default](/cpp/preprocessor/compiler-warnings-that-are-off-by-default)
