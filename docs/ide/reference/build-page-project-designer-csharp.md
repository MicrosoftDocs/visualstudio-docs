---
title: Build Page, Project Designer (C#)
description: Learn how to use the Build page of the Project Designer in Visual Studio to specify the project's build configuration properties.
ms.custom: SEO-VS-2020
ms.date: 06/20/2017
ms.technology: vs-ide-compile
ms.topic: reference
f1_keywords:
- cs.ProjectPropertiesBuild
helpviewer_keywords:
- Build options [C#]
- Project Designer, Build page
ms.assetid: 77ff1bfc-d633-4634-ba29-9afdb6d7e362
author: ghogen
ms.author: ghogen
manager: jmartens
ms.workload:
- dotnet
---
# Build Page, Project Designer (C#)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Use the **Build** page of the **Project Designer** to specify the project's build configuration properties. This page applies to [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] projects only.

:::moniker range="<=vs-2019"
To access the **Build** page, right-click on a project node (not the **Solution** node) in **Solution Explorer**. Then choose **Properties** on the menu. When the Project Designer appears, choose the **Build** tab.
:::moniker-end
:::moniker range=">=vs-2022"
To access the **Build** page, right-click on a project node (not the **Solution** node) in **Solution Explorer**. Then choose **Properties** on the menu. When the Project Designer appears, choose the **Build** tab (**Build** in the left pane for .NET 5 and later) to open the build settings. The project designer is different for .NET 5 and later. 

For .NET 5 and later projects, the **Build** section contains several subsections: [General](#general-net-5-and-later), [Errors and warnings](#errors-and-warnings-net-5-and-later), [Output](#output-net-5-and-later), [Strong name](#strong-naming-net-5-and-later), and [Advanced](#advanced-net-5-and-later).
:::moniker-end

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

## Configuration and platform

The following options enable you to select the configuration and platform to display or modify.

> [!NOTE]
> With simplified build configurations, the project system determines whether to build a debug or release version. Therefore, these options are not displayed. For more information, see [How to: Set debug and release configurations](../../debugger/how-to-set-debug-and-release-configurations.md).

**Configuration**

Specifies which configuration settings to display or modify. The settings can be **Active (Debug)** (this is the default), **Debug**, **Release**, or **All Configurations**.

**Platform**

Specifies which platform settings to display or modify. The default setting is **Active (Any CPU)**. You can change the active platform using the **Configuration Manager**. For more information, see [How to: Create and Edit Configurations](../../ide/how-to-create-and-edit-configurations.md).

:::moniker range=">=vs-2022"
## Configuration and Platform (.NET 5 and later)

You can set some settings in the **Build** section differently, depending on the project configuration (for example, **Debug** or **Release**), or the platform. The settings that can be set independently have a gear icon that appears next to the name of the setting when you hover over it with the pointing device. Click on the gear icon to bring up a menu item that you can use to specify whether you want different settings for each configuration, each platform, or both.

![Screenshot showing project properties that are dependent on the configuration and platform.][(./media/vs-2022/project-properties-build.png)

:::moniker-end

## General (.NET Framework or .NET Core 3.x and earlier)

The following options enable you to configure several C# compiler settings.

**Conditional compilation symbols**

Specifies symbols on which to perform conditional compilation. Separate symbols with a semi-colon (";"). For more information, see [/define (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/define-compiler-option).

**Define DEBUG constant**

Defines DEBUG as a symbol in all source code files in your app. Selecting this is equivalent to using the `/define:DEBUG` command-line option.

**Define TRACE constant**

Defines TRACE as a symbol in all source code files in your app. Selecting this is equivalent to using the `/define:TRACE` command-line option.

**Platform Target**

Specifies the processor to be targeted by the output file. Choose **x86** for any 32-bit Intel-compatible processor, choose **x64** for any 64-bit Intel-compatible processor, choose **ARM** for ARM processors, or choose **Any CPU** to configure the project's output to run on all of the above platforms. **Any CPU** is the default value for projects, because it allows the application to run on the broadest range of hardware.

This setting determines the value used for the [/platform](/dotnet/csharp/language-reference/compiler-options/platform-compiler-option) C# compiler option.

The **Platform target** setting is not the same thing as the project platform and active solution platform, although it typically has the same value as the project platform and active solution platform. When you change the platform in Visual Studio toolbar, you're changing the active solution platform, which changes all the project's platforms according to what's set in the **Configuration Manager**. The project platform determines the *default setting* of the **Platform target**, but you can override the default by changing the **Platform target** to build a different binary than the project platform would suggest. There are scenarios where this is necessary. For example, suppose you want most of your projects to be built for **Any CPU**, regardless of whether the active solution configuration is **x86**, **x64**, or **Any CPU**, but you have one or two projects that you need to build **x86** or **x64**, matching the solution platform (and the associated project platforms). In that case, you can set the **Platform target** to **Any CPU** on the appropriate projects. To avoid confusion, avoid setting the **Platform target** to a value that would not be expected based on the active solution and project platforms. See also [How to: Configure projects to target platforms](how-to-configure-projects-to-target-platforms.md).

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

:::moniker range=">=vs-2022"
## General (.NET 5 and later)

**Conditional compilation symbols**

Specifies symbols on which to perform conditional compilation. Separate symbols with a semi-colon (";"). For more information, see [/define (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/define-compiler-option). This setting can vary based on the configuration and platform.

**Platform target**

Specifies the processor to be targeted by the output file. Choose **x86** for any 32-bit Intel-compatible processor, choose **x64** for any 64-bit Intel-compatible processor, choose **ARM** for ARM processors, or choose **Any CPU** to configure the project's output to run on all of the above platforms. **Any CPU** is the default value for projects, because it allows the application to run on the broadest range of hardware.

This setting determines the value used for the [/platform](/dotnet/csharp/language-reference/compiler-options/platform-compiler-option) C# compiler option.

The **Platform target** setting is not the same thing as the project platform and active solution platform, although it typically has the same value as the project platform and active solution platform. When you change the platform in Visual Studio toolbar, you're changing the active solution platform, which changes all the project's platforms according to what's set in the **Configuration Manager**. The project platform determines the *default setting* of the **Platform target**, but you can override the default by changing the **Platform target** to build a different binary than the project platform would suggest. There are scenarios where this is necessary. For example, suppose you want most of your projects to be built for **Any CPU**, regardless of whether the active solution configuration is **x86**, **x64**, or **Any CPU**, but you have one or two projects that you need to build **x86** or **x64**, matching the solution platform (and the associated project platforms). In that case, you can set the **Platform target** to **Any CPU** on the appropriate projects. To avoid confusion, avoid setting the **Platform target** to a value that would not be expected based on the active solution and project platforms. See also [How to: Configure projects to target platforms](how-to-configure-projects-to-target-platforms.md).

**Nullable**

Specifies the project-wide C# nullable context. This UI option was introduced in Visual Studio 16.5, and is only enabled for projects that use C# 8.0 or later.

For more information, see [Nullable Contexts](/dotnet/csharp/nullable-references#nullable-contexts).

**Implicit global usings**

Enables types defined in some commonly used namespaces without having to specify their fully qualified name or manually add a using directive. The list of what namespaces are implicitly referenced depends on the project type. See [Implicit using directives](/dotnet/core/project-sdk/overview#implicit-using-directives).

**Unsafe code**

Allows code that uses the [unsafe](/dotnet/csharp/language-reference/keywords/unsafe) keyword to compile. For more information, see [/unsafe (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/unsafe-compiler-option).

**Optimize code**

Enable or disable optimizations performed by the compiler to make your output file smaller, faster, and more efficient. For more information, see [/optimize (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/optimize-compiler-option). This setting can vary based on the configuration and platform.

**Debug symbols**

Specifies the kind of debug symbols produced during build. When you generate debug symbols in a PDB file, they can be platform-specific or you can produce the same symbol file for all platforms. You can also choose to generate symbols embedded directly in the assembly. See [/debug (C# compiler options)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/code-generation#debugtype). This setting can vary based on the configuration and platform.

:::moniker-end

## Errors and warnings (.NET Framework and .NET Core 3.x and earlier)

The following settings are used to configure the error and warning options for the build process.

**Warning level**

Specifies the level to display for compiler warnings. For more information, see [/warn (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/warn-compiler-option).

**Suppress warnings**

Blocks the compiler's ability to generate one or more warnings. Separate multiple warning numbers with a comma or semicolon. For more information, see [/nowarn (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/nowarn-compiler-option).

**Treat Warnings as Errors**

The following settings are used to specify which warnings are treated as errors. Select one of the following options to indicate under what conditions to return an error when the build encounters a warning. For more information, see [/warnaserror (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/warnaserror-compiler-option).

- **None** - Treats no warnings as errors.
- **All** - Treats all warnings as errors.
- **Specific warnings** - Treats the specified warnings as errors. Separate multiple warning numbers with a comma or semicolon.

> [!TIP]
> If you don't want code analysis warnings to be treated as errors, see [Code analysis FAQ](/visualstudio/code-quality/analyzers-faq#treat-warnings-as-errors).

:::moniker range=">=vs-2022"

## Errors and warnings (.NET 5 and later)

**Warning level**

Specifies the level to display for compiler warnings. For more information, see [/warn (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/warn-compiler-option).

**Suppress specific warnings**

Blocks the compiler's ability to generate one or more warnings. Separate multiple warning numbers with a comma or semicolon. For more information, see [/nowarn (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/nowarn-compiler-option).

**Treat warnings as errors**

This setting affects all warnings.

**Treat specific warnings as errors**

Treats the specified warnings as errors. Separate multiple warning numbers with a comma or semicolon.

:::moniker-end

:::moniker range="<=vs-2019"
## Output (.NET Framework and .NET Core 3.x and earlier)

The following settings are used to configure the output options for the build process.

**Output path**

Specifies the location of the output files for this project's configuration. Enter the path of the build output in this box, or choose the **Browse** button to specify a path. The path is relative; if you enter an absolute path, it will be saved as relative. The default path is bin\Debug or bin\Release\\.

With simplified build configurations, the project system determines whether to build a debug or release version. The **Build** command from the **Debug** menu (F5) will put the build in the debug location regardless of the **Output path** you specify. However, the **Build** command from the **Build** menu puts it in the location you specify. For more information, see [Understanding Build Configurations](../../ide/understanding-build-configurations.md).

**XML documentation file**

Specifies the name of a file into which documentation comments will be processed. For more information, see [/doc (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/doc-compiler-option).

**Register for COM interop**

Indicates that your managed application will expose a COM object (a COM callable wrapper) that allows a COM object to interact with your managed application. The **Output type** property in the [Application page](../../ide/reference/application-page-project-designer-visual-basic.md) of the **Project Designer** for this application must be set to **Class Library** in order for the **Register for COM interop** property to be available. For an example class that you might include in your [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] application and expose as a COM object, see [Example COM Class](/dotnet/csharp/programming-guide/interop/example-com-class).

**Generate serialization assembly**

Specifies whether the compiler will use the XML Serializer Generator Tool (Sgen.exe) to create XML serialization assemblies. Serialization assemblies can improve the startup performance of <xref:System.Xml.Serialization.XmlSerializer> if you have used that class to serialize types in your code. By default, this option is set to **Auto**, which specifies that serialization assemblies be generated only if you have used <xref:System.Xml.Serialization.XmlSerializer> to encode types in your code to XML. **Off** specifies that serialization assemblies never be generated, regardless of whether your code uses <xref:System.Xml.Serialization.XmlSerializer>. **On** specifies that serialization assemblies always be generated. Serialization assemblies are named `TypeName`.XmlSerializers.dll. For more information, see [XML Serializer Generator Tool (Sgen.exe)](/dotnet/framework/serialization/xml-serializer-generator-tool-sgen-exe).

**Advanced**

Click to display the [Advanced Build Settings Dialog Box (C#)](../../ide/reference/advanced-build-settings-dialog-box-csharp.md) dialog box.

:::moniker range=">=vs-2022"

## Output (.NET 5 and later)

The following settings are used to configure the output options for the build process.

**Base output path**

Specifies the location of the output files for this project's configuration. Enter the path of the build output in this box, or choose the **Browse** button to specify a path. The path is relative; if you enter an absolute path, it will be saved as relative. The default path is `bin`.

**Base intermediate output path**

Specifies the location of the intermediate files for this project's configuration. Enter the path of the build output in this box, or choose the **Browse** button to specify a path. The path is relative; if you enter an absolute path, it will be saved as relative. The default path is `obj`.

**Reference assembly**

Specifies whether or not to generate a reference assembly for the public APIs in this project. See [Reference assemblies](/dotnet/standard/assembly/reference-assemblies).

**Documentation file**

Specifies whether or not to generate an XML documentation file.

**XML documentation file path**

This setting only appears if the **Documentation file** setting is enabled. Specifies the path of a file into which documentation comments will be processed. For more information, see [/doc (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/doc-compiler-option).

## Events

See [Build Events page, Project Designer (C#)](build-events-page-project-designer-csharp.md).

:::moniker range=">=vs-2022"
## Strong naming (.NET 5 and later)

**Sign the assembly**

Select this check box to sign the assembly and create a strongly named key file. For more information about signing the assembly by using the **Project Designer**, see [How to: Sign an Assembly (Visual Studio)](../managing-assembly-and-manifest-signing.md#how-to-sign-an-assembly-in-visual-studio).

This option uses the Al.exe tool provided by the Windows Software Development Kit (SDK) to sign the assembly. For more information about Al.exe, see [How to: Sign an Assembly with a Strong Name](/dotnet/framework/app-domains/how-to-sign-an-assembly-with-a-strong-name).

**Strong name key file**

Enables you to specify an existing strongly named key file that is used to sign the assembly. Select **\<Browse...>** to select an existing key file.

**Delay sign only**

Select this check box to enable delay signing.

Note that a delay signed project will not run and cannot be debugged. You can, however, use the [Sn.exe (Strong Name Tool)](/dotnet/framework/tools/sn-exe-strong-name-tool) with the `-Vr` option to skip verification during development.

> [!NOTE]
> When you sign an assembly, you might not always have access to a private key. For example, an organization might have a closely guarded key pair that developers don't have access to on a daily basis. The public key might be available, but access to the private key is restricted to a few individuals. In such a case, you can use *delayed* or *partial signing* to provide the public key, deferring the addition of the private key until the assembly is handed off.

## Advanced (.NET 5 and later)

**Language version**

Determines the value used for the [/langversion](/csharp/language-reference/compiler-options/language#langversion) compiler option, which provides information about how a default language version is chosen based on a project's target framework. This might not be editable, depending on the project type.

**Check for arithmetic overflow**

Specifies whether an integer arithmetic statement that is not in the scope of the [checked](/dotnet/csharp/language-reference/keywords/checked) or [unchecked](/dotnet/csharp/language-reference/keywords/unchecked) keywords and that results in a value outside the range of the data type will cause a run-time exception. For more information, see [/checked (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/checked-compiler-option).

**Deterministic**

Enables the [/deterministic](/dotnet/csharp/language-reference/compiler-options/code-generation#deterministic) C# compiler option to force the compiler to produce the same output, byte-for-byte, when given the same inputs and the same settings. Without this option, the built output includes some data that varies from one compilation to the next, such as the timestamp and certain IDs.

**Internal compiler error reporting**

Specifies whether to report compiler errors to Microsoft. If set to **Prompt before sending** (the default), you will receive a prompt if an internal compiler error occurs, giving you the option of sending an error report electronically to Microsoft. If set to **Send**, an error report will be sent automatically. If set to **Queue**, error reports will be queued. If set to **Never send**, the error will be reported only in the compiler's text output. For more information, see [/errorreport (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/errorreport-compiler-option).

**File alignment**

Specifies the size of sections in the output file. Valid values are **512**, **1024**, **2048**, **4096**, and **8192**. These values are measured in bytes. Each section will be aligned on a boundary that is a multiple of this value, affecting the size of the output file. For more information, see [/filealign (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/filealign-compiler-option).

:::moniker-end

## See also

- [Project Properties Reference](../../ide/reference/project-properties-reference.md)
- [C# Compiler Options](/dotnet/csharp/language-reference/compiler-options/index)
