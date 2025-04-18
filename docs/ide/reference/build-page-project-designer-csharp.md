---
title: Build Page, Project Designer (C#)
description: Learn how to use the Build page of the Project Designer in Visual Studio to specify the project's build configuration properties.
ms.date: 06/20/2017
ms.subservice: compile-build
ms.topic: reference
f1_keywords:
- cs.ProjectPropertiesBuild
helpviewer_keywords:
- Build options [C#]
- Project Designer, Build page
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
monikerRange: 'vs-2019'
---
# Build Page, Project Designer (C#)

Use the **Build** page of the **Project Designer** to specify the project's build configuration properties. This page applies to Visual C# projects only.

To access the **Build** page, choose a project node (not the **Solution** node) in **Solution Explorer**. Then choose **View**, **Property Pages** on the menu. When the Project Designer appears, choose the **Build** tab.

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

## Configuration and Platform

The following options enable you to select the configuration and platform to display or modify.

> [!NOTE]
> With simplified build configurations, the project system determines whether to build a debug or release version. Therefore, these options are not displayed. For more information, see [How to: Set debug and release configurations](../../debugger/how-to-set-debug-and-release-configurations.md).

**Configuration**

Specifies which configuration settings to display or modify. The settings can be **Active (Debug)** (this is the default), **Debug**, **Release**, or **All Configurations**.

**Platform**

Specifies which platform settings to display or modify. The default setting is **Active (Any CPU)**. You can change the active platform using the **Configuration Manager**. For more information, see [How to: Create and Edit Configurations](../../ide/how-to-create-and-edit-configurations.md).

## General

The following options enable you to configure several C# compiler settings.

**Conditional compilation symbols**

Specifies symbols on which to perform conditional compilation. Separate symbols with a semi-colon (";"). For more information, see [/define (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/define-compiler-option).

**Define DEBUG constant**

Defines DEBUG as a symbol in all source code files in your app. Selecting this is equivalent to using the `/define:DEBUG` command-line option.

**Define TRACE constant**

Defines TRACE as a symbol in all source code files in your app. Selecting this is equivalent to using the `/define:TRACE` command-line option.

**Platform Target**

Specifies the processor to be targeted by the output file. Choose **x86** for any 32-bit Intel-compatible processor, choose **x64** for any 64-bit Intel-compatible processor, choose **ARM** for ARM processors, or choose **Any CPU** to specify that any processor is acceptable. **Any CPU** is the default value for projects, because it allows the application to run on the broadest range of hardware.

For more information, see [/platform (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/platform-compiler-option).

**Nullable**

Specifies the project-wide C# nullable context. This UI option was introduced in Visual Studio 16.5, and is only enabled for projects that use C# 8.0 or later.

For more information, see [Nullable Contexts](/dotnet/csharp/nullable-references#nullable-contexts).

**Prefer 32-bit**

If the **Prefer32-bit** check box is selected, the application runs as a 32-bit application on both 32-bit and 64-bit versions of Windows. If the check box is cleared, the application runs as a 32-bit application on 32-bit versions of Windows and as a 64-bit application on 64-bit versions of Windows.

If you run an application as a 64-bit application, the pointer size doubles, and compatibility problems can occur with other libraries that are exclusively 32-bit. It is useful to run a 64-bit application only if it needs more than 4 GB of memory or 64-bit instructions provide a significant performance improvement.

This check box is available only if all of the following conditions are true:

- On the **Build Page**, the **Platform target** list is set to **Any CPU**.

- On the **Application Page**, the **Output type** list specifies that the project is an application.

- On the **Application Page**, the **Target framework** list specifies the .NET Framework 4.5.

**Allow unsafe code**

Allows code that uses the [unsafe](/dotnet/csharp/language-reference/keywords/unsafe) keyword to compile. For more information, see [/unsafe (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/unsafe-compiler-option).

**Optimize code**

Enable or disable optimizations performed by the compiler to make your output file smaller, faster, and more efficient. For more information, see [/optimize (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/optimize-compiler-option).

## Errors and Warnings

The following settings are used to configure the error and warning options for the build process.

**Warning level**

Specifies the level to display for compiler warnings. For more information, see [/warn (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/warn-compiler-option).

**Suppress warnings**

Blocks the compiler's ability to generate one or more warnings. Separate multiple warning numbers with a comma or semicolon. For more information, see [/nowarn (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/nowarn-compiler-option).

## Treat Warnings as Errors

The following settings are used to specify which warnings are treated as errors. Select one of the following options to indicate under what conditions to return an error when the build encounters a warning. For more information, see [/warnaserror (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/warnaserror-compiler-option).

**None** - Treats no warnings as errors.

**All** - Treats all warnings as errors.

**Specific warnings** - Treats the specified warnings as errors. Separate multiple warning numbers with a comma or semicolon.

> [!TIP]
> If you don't want code analysis warnings to be treated as errors, see [Code analysis FAQ](/visualstudio/code-quality/analyzers-faq#treat-warnings-as-errors).

## Output

The following settings are used to configure the output options for the build process.

**Output path**

Specifies the location of the output files for this project's configuration. Enter the path of the build output in this box, or choose the **Browse** button to specify a path. The path is relative; if you enter an absolute path, it will be saved as relative. The default path is bin\Debug or bin\Release\\.

With simplified build configurations, the project system determines whether to build a debug or release version. The **Build** command from the **Debug** menu (F5) will put the build in the debug location regardless of the **Output path** you specify. However, the **Build** command from the **Build** menu puts it in the location you specify. For more information, see [Understanding Build Configurations](../../ide/understanding-build-configurations.md).

**XML documentation file**

Specifies the name of a file into which documentation comments will be processed. For more information, see [/doc (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/doc-compiler-option).

**Register for COM interop**

Indicates that your managed application will expose a COM object (a COM callable wrapper) that allows a COM object to interact with your managed application. The **Output type** property in the [Application page](../../ide/reference/application-page-project-designer-visual-basic.md) of the **Project Designer** for this application must be set to **Class Library** in order for the **Register for COM interop** property to be available. For an example class that you might include in your Visual C# application and expose as a COM object, see [Example COM Class](/dotnet/csharp/programming-guide/interop/example-com-class).

**Generate serialization assembly**

Specifies whether the compiler will use the XML Serializer Generator Tool (Sgen.exe) to create XML serialization assemblies. Serialization assemblies can improve the startup performance of <xref:System.Xml.Serialization.XmlSerializer> if you have used that class to serialize types in your code. By default, this option is set to **Auto**, which specifies that serialization assemblies be generated only if you have used <xref:System.Xml.Serialization.XmlSerializer> to encode types in your code to XML. **Off** specifies that serialization assemblies never be generated, regardless of whether your code uses <xref:System.Xml.Serialization.XmlSerializer>. **On** specifies that serialization assemblies always be generated. Serialization assemblies are named `TypeName`.XmlSerializers.dll. For more information, see [XML Serializer Generator Tool (Sgen.exe)](/dotnet/framework/serialization/xml-serializer-generator-tool-sgen-exe).

**Advanced**

Click to display the [Advanced Build Settings Dialog Box (C#)](../../ide/reference/advanced-build-settings-dialog-box-csharp.md) dialog box.

## See also

- [Project Properties Reference](../../ide/reference/project-properties-reference.md)
- [C# Compiler Options](/dotnet/csharp/language-reference/compiler-options/index)
