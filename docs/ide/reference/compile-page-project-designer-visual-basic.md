---
title: Compile Page, Project Designer (Visual Basic)
description: Learn how to specify compilation instructions in Visual Studio. You can also specify advanced compiler options and pre-build or post-build events on this page.
ms.date: 2/7/2025
ms.subservice: compile-build
ms.topic: reference
f1_keywords:
- vb.ProjectPropertiesCompile
helpviewer_keywords:
- compilation, Visual Basic projects
- compilation, options [Visual Basic]
- compilers, Visual Basic options
- compilation, instructions [Visual Basic]
- compiler options, Visual Basic
- Project Designer, Compile page
- Compile page in Project Designer
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
monikerRange: 'vs-2019'
---
# Compile Page, Project Designer (Visual Basic)

> [!NOTE]
> This page refers to the Project Designer experience in Visual Studio 2019 and for .NET Framework projects with Visual Studio 2022.

Use the **Compile** page of the Project Designer to specify compilation instructions. You can also specify advanced compiler options and pre-build or post-build events on this page.

To access the **Compile** page, choose a project node (not the **Solution** node) in **Solution Explorer**. Then choose **Project**, **Properties** on the menu bar. When the Project Designer appears, click the **Compile** tab.

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

## Configuration and Platform

The following settings enable you to select the configuration and platform to display or modify.

> [!NOTE]
> With simplified build configurations, the project system determines whether to build a debug or release version. Therefore, the **Configuration** and **Platform** lists are not displayed.

**Configuration**

Specifies which configuration settings to display or modify. The settings are **Debug** (default), **Release**, or **All Configurations**. For more information, see [Understanding Build Configurations](../../ide/understanding-build-configurations.md) and [How to: Create and Edit Configurations](../../ide/how-to-create-and-edit-configurations.md).

**Platform**

Specifies which platform settings to display or modify. You can specify **Any CPU** (default), **x64**, or **x86**.

## Compiler Configuration Options

The following settings enable you to set the compiler configuration options.

**Build output path**

Specifies the location of the output files for this project's configuration. Type the path of the build output in this box, or click the **Browse** button to select a path. Note that the path is relative; if you enter an absolute path, it will be saved as relative. The default path is bin\Debug\ or bin\Release\\.

With simplified build configurations, the project system determines whether to build a debug or release version. The **Build** command from the **Debug** menu (F5) will put the build in the debug location regardless of the **Output path** you specify. However, the **Build** command from the **Build** menu puts it in the location you specify.

**Option explicit**

Specifies whether to allow implicit declaration of variables. Select **On** to require explicit declaration of variables. This causes the compiler to report errors if variables are not declared before they are used. Select **Off** to allow implicit declaration of variables.

This setting corresponds to the [/optionexplicit](/dotnet/visual-basic/reference/command-line-compiler/optionexplicit) compiler option.

If a source code file contains an [Option Explicit Statement](/dotnet/visual-basic/language-reference/statements/option-explicit-statement), the `On` or `Off` value in the statement overrides the **Option Explicit** setting on the **Compile page**.

When you create a new project, the **Option Explicit** setting on the **Compile page** is set to the value of the **Option Explicit** setting in the **Options** dialog box. To view or change the setting in this dialog box, on the **Tools** menu, click **Options**. In the **Options** dialog box, expand **Projects and Solutions**, and then click **VB Defaults**. The initial default setting of **Option Explicit** in **VB Defaults** is **On**.

Setting **Option Explicit** to `Off` is generally not a good practice. You could misspell a variable name in one or more locations, which would cause unexpected results when the program is run.

**Option strict**

Specifies whether to enforce strict type semantics. When **Option Strict** is **On**, the following conditions cause a compile-time error:

- Implicit narrowing conversions

- Late binding

- Implicit typing that results in an `Object` type

Implicit narrowing conversion errors occur when there is an implicit data type conversion that is a narrowing conversion. For more information, see [Option Strict Statement](/dotnet/visual-basic/language-reference/statements/option-strict-statement), [Implicit and Explicit Conversions](/dotnet/visual-basic/programming-guide/language-features/data-types/implicit-and-explicit-conversions), and [Widening and Narrowing Conversions](/dotnet/visual-basic/programming-guide/language-features/data-types/widening-and-narrowing-conversions).

An object is late bound when it is assigned to a property or method of a variable that is declared to be of type `Object`. For more information, see [Option Strict Statement](/dotnet/visual-basic/language-reference/statements/option-strict-statement) and [Early and Late Binding](/dotnet/visual-basic/programming-guide/language-features/early-late-binding).

Implicit object type errors occur when an appropriate type cannot be inferred for a declared variable, so a type of `Object` is inferred. This primarily occurs when you use a `Dim` statement to declare a variable without using an `As` clause, and `Option Infer` is off. For more information, see [Option Strict Statement](/dotnet/visual-basic/language-reference/statements/option-strict-statement), [Option Infer Statement](/dotnet/visual-basic/language-reference/statements/option-infer-statement), and the [Visual Basic Language Specification](/dotnet/visual-basic/reference/language-specification).

The **Option Strict** setting corresponds to the [/optionstrict](/dotnet/visual-basic/reference/command-line-compiler/optionstrict) compiler option.

If a source code file contains an [Option Strict Statement](/dotnet/visual-basic/language-reference/statements/option-strict-statement), the `On` or `Off` value in the statement overrides the **Option Strict** setting on the **Compile page**.

When you create a project, the **Option Strict** setting on the **Compile page** is set to the value of the **Option Strict** setting in the **Options** dialog box. To view or change the setting in this dialog box, on the **Tools** menu, click **Options**. In the **Options** dialog box, expand **Projects and Solutions**, and then click **VB Defaults**. The initial default setting of **Option Strict** in **VB Defaults** is **Off**.

**Option Strict Individual Warnings**

The **Warning configurations** section of the **Compile page** has settings that correspond to the three conditions that cause a compile-time error when `Option Strict` is on. Following are these settings:

- **Implicit conversion**

- **Late binding; call could fail at run time**

- **Implicit type; object assumed**

When you set **Option Strict** to **On**, all three of these warning configuration settings are set to **Error**. When you set **Option Strict** to **Off**, all three settings are set to **None**.

You can individually change each warning configuration setting to **None**, **Warning**, or **Error**. If all three warning configuration settings are set to **Error**, `On` appears in the `Option strict` box. If all three are set to **None**, `Off` appears in this box. For any other combination of these settings, **(custom)** appears.

**Option compare**

Specifies the type of string comparison to use. Select **Binary** to instruct the compiler to use binary, case-sensitive string comparisons. Select **Text** to use locale-specific, case-insensitive text string comparisons.

This setting corresponds to the [/optioncompare](/dotnet/visual-basic/reference/command-line-compiler/optioncompare) compiler option.

If a source code file contains an [Option Compare Statement](/dotnet/visual-basic/language-reference/statements/option-compare-statement), the `Binary` or `Text` value in the statement overrides the **Option Compare** setting on the **Compile page**.

When you create a project, the **Option Compare** setting on the **Compile page** is set to the value of the **Option Compare** setting in the **Options** dialog box. To view or change the setting in this dialog box, on the **Tools** menu, click **Options**. In the **Options** dialog box, expand **Projects and Solutions**, and then click **VB Defaults**. The initial default setting of **Option Compare** in **VB Defaults** is **Binary**.

**Option infer**

Specifies whether to allow local type inference in variable declarations. Select **On** to allow the use of local type inference. Select **Off** to block local type inference.

This setting corresponds to the [/optioninfer](/dotnet/visual-basic/reference/command-line-compiler/optioninfer) compiler option.

If a source code file contains an [Option Infer Statement](/dotnet/visual-basic/language-reference/statements/option-infer-statement), the `On` or `Off` value in the statement overrides the **Option Infer** setting on the **Compile page**.

When you create a project, the **Option Infer** setting on the **Compile page** is set to the value of the **Option Infer** setting in the **Options** dialog box. To view or change the setting in this dialog box, on the **Tools** menu, click **Options**. In the **Options** dialog box, expand **Projects and Solutions**, and then click **VB Defaults**. The initial default setting of **Option Infer** in **VB Defaults** is **On**.

**Target CPU**

Specifies the processor to be targeted by the output file. Specify **x86** for any 32-bit Intel-compatible processor, **x64** for any 64-bit Intel-compatible processor, **ARM** for any ARM processor, or **Any CPU** to specify that any processor is acceptable. **Any CPU** is the default value for new projects because it allows the application to run on the largest number of hardware types.

For more information, see [/platform (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/platform).

**Prefer 32-bit**

If the **Prefer32-bit** check box is selected, the application runs as a 32-bit application on both 32-bit and 64-bit versions of Windows. Otherwise, the application runs as a 32-bit application on 32-bit versions of Windows and as a 64-bit application on 64-bit versions of Windows.

Running as a 64-bit application doubles the pointer size, and it can cause compatibility problems with libraries that are exclusively 32-bit. It makes sense to run an application as 64-bit only if it runs significantly faster or needs more than 4 GB of memory.

This check box is available only if all of the following conditions are true:

- On the **Compile Page**, the **Target CPU** list is set to **Any CPU**.

- On the **Application Page**, the **Application type** list specifies that the project is an application.

- On the **Application Page**, the **Target framework** list specifies the .NET Framework 4.5.

**Warning configurations**

This table lists build conditions and the corresponding notification level of **None**, **Warning**, or **Error** for each.

By default, all compiler warnings are added to the Task List during compilation. Select **Disable all warnings** to instruct the compiler not to issue warnings or errors. Select **Treat all warnings as errors** if you want the compiler to treat warnings as errors that must be fixed.

**Disable all warnings**

Specifies whether to allow the compiler to issue notifications as specified in the **Condition and Notification** table described earlier in this document. By default, this check box is cleared. Select this check box to instruct the compiler not to issue warnings or errors.

This setting corresponds to the [/nowarn](/dotnet/visual-basic/reference/command-line-compiler/nowarn) compiler option.

**Treat all warnings as errors**

Specifies how to treat warnings. By default, this check box is cleared, so that all warning notifications remain set to **Warning**. Select this check box to change all warning notifications to **Error**.

This option is available only if **Disable all warnings** is cleared.

**Generate XML documentation file**

Specifies whether to generate documentation information. By default, this check box is selected, instructing the compiler to generate documentation information and include it in an XML file. Clear this check box to instruct the compiler not to create documentation.

This setting corresponds to the [/doc](/dotnet/visual-basic/reference/command-line-compiler/doc) compiler option.

**Register for COM interop**

Specifies whether your managed application will expose a COM object (a COM-callable wrapper) that enables a COM object to interact with the application.

By default, this check box is cleared, which specifies that the application will not allow COM interop. Select this check box to allow COM interop.

This option is not available for Windows Application or Console Application projects.

**Build Events**

Click this button to access the **Build Events** dialog box. Use this dialog box to specify pre-build and post-build configuration instructions for the project. This dialog box applies to Visual Basic projects only. For more information, see [Build Events Dialog Box (Visual Basic)](../../ide/reference/build-events-dialog-box-visual-basic.md).

**Advanced Compile Options**

Click this button to access the **AdvancedCompiler Settings** dialog box. Use the **AdvancedCompiler Settings** dialog box to specify a project's advanced build configuration properties. This dialog box applies to Visual Basic projects only. For more information, see [Advanced Compiler Settings Dialog Box (Visual Basic)](../../ide/reference/advanced-compiler-settings-dialog-box-visual-basic.md).

## See also

- [How to: Specify Build Events (Visual Basic)](../../ide/how-to-specify-build-events-visual-basic.md)
- [Visual Basic Command-Line Compiler](/dotnet/visual-basic/reference/command-line-compiler/index)
- [How to: Create and Edit Configurations](../../ide/how-to-create-and-edit-configurations.md)
