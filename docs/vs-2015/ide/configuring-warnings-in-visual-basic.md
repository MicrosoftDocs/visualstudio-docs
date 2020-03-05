---
title: "Configuring Warnings in Visual Basic | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "errors [Visual Basic], warnings"
  - "run-time errors, warnings"
  - "warnings, configuring"
ms.assetid: 99cf4781-bd4d-47b4-91b9-217933509f82
caps.latest.revision: 37
author: jillre
ms.author: jillfra
manager: jillfra
---
# Configuring Warnings in Visual Basic
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] compiler includes a set of warnings about code that may cause run-time errors. You can use that information to write cleaner, faster, better code with fewer bugs. For example, the compiler will produce a warning when the user attempts to invoke a member of an unassigned object variable, return from a function without setting the return value, or execute a `Try` block with errors in the logic to catch exceptions.

 Sometimes the compiler provides extra logic on the user's behalf so that the user can focus on the task at hand, rather than on anticipating possible errors. In previous versions of [!INCLUDE[vbprvb](../includes/vbprvb-md.md)], `Option Strict` was used to limit the additional logic that the [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] compiler provides. Configuring warnings allows you to limit this logic in a more granular way, at the level of the individual warnings.

 You may want to customize your project and turn off some warnings not pertinent to your application while turning other warnings into errors. This page explains how to turn individual warnings on and off.

## Turning Warnings Off and On
 There are two different ways to configure warnings: you can configure them using the **Project Designer**, or you can use the **/warnaserror** and **/nowarn** compiler options.

 The **Compile** tab of the **Project Designer** page allows you to turn warnings on and off. Select the **Disable All Warnings** check box to disable all warnings; select the **Treat All Warnings as Errors** to treat all warnings as errors. Some individual warnings can be toggled as error or warning as desired in the displayed table.

 When **Option Strict** is set to **Off**, **Option Strict** related warnings cannot be treated independently of each other. When **Option Strict** is set to **On**, the associated warnings are treated as errors, no matter what their status is. When **Option Strict** is set to **Custom** by specifying `/optionstrict:custom` in the command line compiler, **Option Strict** warnings can be toggled on or off independently.

 The **/warnaserror** command-line option of the compiler can also be used to specify whether warnings are treated as errors. You can add a comma delimited list to this option to specify which warnings should be treated as errors or warnings by using + or -. The following table details the possible options.

|Command-line option|Specifies|
|--------------------------|---------------|
|`/warnaserror+`|Treat all warnings as errors|
|`/warnsaserror`-|Do not treat as warnings as errors. This is the default.|
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

## Types of Warnings
 Following is a list of warnings that you might want to treat as errors.

### Implicit Conversion Warning
 Generated for instances of implicit conversion. They do not include implicit conversions from an intrinsic numeric type to a string when using the `&` operator. Default for new projects is off.

 ID: 42016

### Late bound Method Invocation and Overload Resolution Warning
 Generated for instances of late binding. Default for new projects is off.

 ID: 42017

### Operands of Type Object Warnings
 Generated when operands of type `Object` occur that would create an error with `Option Strict On`. Default for new projects is on.

 ID: 42018 and 42019

### Declarations Require 'As' Clause Warnings
 Generated when a variable, function, or property declaration lacking an `As` clause would have created an error with `Option Strict On`. Variables that do not have a type assigned to them are assumed to be type `Object`. Default for new projects is on.

 ID: 42020 (variable declaration), 42021 (function declaration), and 42022 (property declaration).

### Possible Null Reference Exception Warnings
 Generated when a variable is used before it has been assigned a value. Default for new projects is on.

 ID: 42104, 42030

### Unused Local Variable Warning
 Generated when a local variable is declared but never referred to. Default is on.

 ID: 42024

### Access of Shared member through Instance Variable Warning
 Generated when accessing a shared member through an instance may have side effects, or when accessing a shared member through an instance variable is not the right-hand side of an expression or is being passed in as a parameter. Default for new projects is on.

 ID: 42025

### Recursive Operator or Property Access Warnings
 Generated when the body of a routine uses the same operator or property it is defined in. Default for new projects is on.

 ID: 42004 (operator), 42026 (property)

### Function or Operator without Return Value Warning
 Generated when the function or operator does not have a return value specified. This includes omitting a `Set` to the implicit local variable with the same name as the function. Default for new projects is on.

 ID: 42105 (function), 42016 (operator)

### Overloads Modifier Used in a Module Warning
 Generated when `Overloads` is used in a `Module`. Default for new projects is on.

 ID: 42028

### Duplicate or Overlapping Catch Blocks Warnings
 Generated when a `Catch` block is never reached due to its relation to other `Catch` blocks that have been defined. Default for new projects is on.

 ID: 42029, 42031

## See Also
 [Exception Assistant Dialog Box](../debugger/exception-assistant-dialog-box.md)
 [Error Types](https://msdn.microsoft.com/library/3048aabf-8c97-4e13-9150-853769cb5f6f)
 [Try...Catch...Finally Statement](https://msdn.microsoft.com/library/d6488026-ccb3-42b8-a810-0d97b9d6472b)
 [/nowarn](https://msdn.microsoft.com/library/7ebf2106-0652-4fdc-bf60-70fc86465d83)
 [/warnaserror (Visual Basic)](https://msdn.microsoft.com/library/49819f1d-a1bd-4201-affe-5afe6d9712e1)
 [Compile Page, Project Designer (Visual Basic)](../ide/reference/compile-page-project-designer-visual-basic.md)
 [Compiler Warnings That Are Off by Default](https://msdn.microsoft.com/library/69809cfb-a38a-4035-b154-283a61938df8)
