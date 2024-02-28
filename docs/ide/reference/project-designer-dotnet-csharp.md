---
title: Project Designer for .NET C# project properties
description: Learn how to use the C# Project Designer to specify the project's application settings and properties.
ms.date: 02/27/2024
ms.topic: reference
f1_keywords:
- cs.ProjectPropertiesApplicationWPF
- cs.ProjectPropertiesApplication
helpviewer_keywords:
- Project Designer
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.subservice: general-ide
---
# .NET Project Designer (C#)

Use the **Project Designer** to specify the project's settings and properties.

To access the Project Designer, choose a project node (not the **Solution** node) in **Solution Explorer**. Then choose **Project** > **Properties** on the menu bar. The **Project Designer** appears.

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

## Application, General settings

The following options enable you to configure general settings for the application.

**Output type**

Specifies the type of application to build. The values are different depending on the project type. For example, for a **Console App** project, you can specify **Windows Application**, **Console Application**, or **Class Library** as the output type.

For more information about the **Output type** property, see [/target (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/target-compiler-option).

For information about how to access this property programmatically, see <xref:VSLangProj.ProjectProperties.OutputType%2A>.

**Target Framework**

Specifies the version of .NET that the application targets. This option can have different values depending on which versions of .NET are installed on your computer.

For .NET Framework projects, the default value matches the target framework that you specified when you created the project.

For a project that targets .NET Core or .NET 5+, the available versions might appear as follows:

::: moniker range="vs-2022"

:::image type="content" source="../media/vs-2022/application-target-framework.png" alt-text="Screenshot of the target framework versions for a .NET Core project in Visual Studio 2022.":::

::: moniker-end

::: moniker range="<=vs-2019"

![Target framework versions for a .NET Core project](../media/application-target-framework.png)

::: moniker-end

> [!NOTE]
> For ClickOnce applications, the prerequisite packages listed in the [Prerequisites Dialog Box](../../ide/reference/prerequisites-dialog-box.md) are set automatically the first time that you open the dialog box. If you subsequently change the project's target framework, you must select the prerequisites manually to match the new target framework.

For more information, see [Framework targeting overview](../../ide/visual-studio-multi-targeting-overview.md).

**Target OS**

Specifies the operating system that the project will target. Combined with the target framework, this generates a [.NET 5+ OS-specific TF](/dotnet/standard/frameworks#net-5-os-specific-tfms).

**Startup object**

Defines the entry point to be called when the application loads. Generally this is set either to the main form in your application or to the `Main` procedure that should run when the application starts. Because class libraries do not have an entry point, their only option for this property is **(Not set)**.

By default, in a WPF app project, this option is set to **(Not set)**. The other option is \[projectname].App. In a WPF project, you must set the startup URI to load a UI resource when the application starts. To do this, open the *Application.xaml* file in your project and set the `StartupUri` property to a *.xaml* file in your project, such as *Window1.xaml*. For a list of acceptable root elements, see <xref:System.Windows.Application.StartupUri%2A>. You must also define a `public static void Main()` method in a class in the project. This class will appear in the **Startup object** list as *ProjectName.ClassName*. You can then select the class as the startup object.

See [/main (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/main-compiler-option) for more information. To access this property programmatically, see <xref:VSLangProj.ProjectProperties.StartupObject%2A>.

**Assembly name**

Specifies the name of the output file that will hold the assembly manifest. Changing this property also changes the **Output Name** property.

You can also make this change from the command line by using [/out (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/out-compiler-option).

To access this property programmatically, see <xref:VSLangProj.ProjectProperties.AssemblyName%2A>.

**Default namespace**

Specifies the base namespace for files added to the project.

See [namespace](/dotnet/csharp/language-reference/keywords/namespace) for more information about creating namespaces in your code.

To access this property programmatically, see <xref:VSLangProj.ProjectProperties.RootNamespace%2A>.

## Application, Win32 Resources settings

**Icon**

Sets the *.ico* file that you want to use as your program icon. Click **Browse** to browse for an existing graphic, or type the name of the file that you want. See [/win32icon (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/win32icon-compiler-option) for more information.

To access this property programmatically, see <xref:VSLangProj.ProjectProperties.ApplicationIcon%2A>.

For information about creating an icon, see [Image editor for icons](/cpp/windows/image-editor-for-icons).

**Resources**

The **Resources** option helps you configure resource settings for your app. By default, the **Icon** and **Manifest** options are enabled. This enables you to select your own icon or to select different manifest generation options. Leave this radio button selected unless you're providing a resource file for the project.

**Manifest**

Selects a manifest generation option when the application runs on Windows under User Account Control (UAC). This option can have the following values:

- **Embed manifest with default settings**. Supports the typical manner in which Visual Studio operates on Windows, which is to embed security information in the application's executable file, specifying that `requestedExecutionLevel` be `AsInvoker`. This is the default option.

- **Create application without a manifest**. This method is known as *virtualization*. Use this option for compatibility with earlier applications.

- **Properties\app.manifest**. This option is required for applications deployed by ClickOnce or Registration-Free COM. If you publish an application by using ClickOnce deployment, **Manifest** is automatically set to this option.

## Global Usings settings

**Implicit global usings** 

Enables or disables [global usings](/dotnet/csharp/language-reference/keywords/using-directive#global-modifier), which allow you to use types defined in a namespace without specifying the fully qualified namespace.

**Manage Implicit Global Usings**

Manually add and delete global usings for use in your projects.

## Build, General settings

**Conditional compilation symbols**

Specifies symbols on which to perform conditional compilation. Separate symbols with a semi-colon (";"). For more information, see [/define (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/define-compiler-option).

**Debug Custom Symbols**

Specifies symbols for conditional compilation for Debug builds. The default debug symbols are displayed in a string, separated by semi-colons.

**Release Custom Symbols**

Specifies symbols for conditional compilation for Release builds. The default release symbols are displayed in a string, separated by semi-colons.

**Platform Target**

Specifies the processor to be targeted by the output file. Choose **x86** for any 32-bit Intel-compatible processor, choose **x64** for any 64-bit Intel-compatible processor, choose **ARM** for ARM processors, or choose **Any CPU** to specify that any processor is acceptable. **Any CPU** is the default value for projects, because it allows the application to run on the broadest range of hardware.

For more information, see [/platform (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/platform-compiler-option).

**Nullable**

Specifies the project-wide C# nullable context. This UI option was introduced in Visual Studio 16.5, and is only enabled for projects that use C# 8.0 or later.

For more information, see [Nullable Contexts](/dotnet/csharp/nullable-references#nullable-contexts).

**Generate assembly info**

Specifies whether [package-related project properties](/dotnet/core/project-sdk/msbuild-props#package-properties) are transformed into assembly attributes. For more information, see the [GenerateAssemblyInfo](/dotnet/core/project-sdk/msbuild-props#generateassemblyinfo) property.

**Unsafe code**

Allows code that uses the [unsafe](/dotnet/csharp/language-reference/keywords/unsafe) keyword to compile. For more information, see [/unsafe (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/unsafe-compiler-option).

**Optimize code**

Enable or disable optimizations performed by the compiler to make your output file smaller, faster, and more efficient. For more information, see [/optimize (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/optimize-compiler-option).

**Debug symbols**

Specifies the type of debugging information generated by the compiler. For information on how to configure the debug performance of an application, see [Making an Image Easier to Debug](/dotnet/framework/debug-trace-profile/making-an-image-easier-to-debug). This setting has the following options:

- **none**

   Specifies that no debugging information will be generated.

- **full**

   Enables attaching a debugger to the running program.

- **pdbonly**

   Allows source code debugging when the program is started in the debugger but will only display assembler when the running program is attached to the debugger.

- **portable**

   Produces a .PDB file, a non-platform-specific, portable symbol file that provides other tools, especially debuggers, information about what is in the main executable file and how it was produced. See [Portable PDB](https://github.com/dotnet/core/blob/master/Documentation/diagnostics/portable_pdb.md) for more information.

- **embedded**

   Embeds portable symbol information into the assembly. No external .PDB file is produced.

For more information, see [/debug (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/debug-compiler-option).

## Build, Errors and warnings settings

The following settings are used to configure the error and warning options for the build process.

**Warning level**

Specifies the level to display for compiler warnings. For more information, see [/warn (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/warn-compiler-option).

**Suppress specific warnings**

Blocks the compiler's ability to generate one or more specific warnings. Separate multiple warning numbers with a comma or semicolon. For more information, see [/nowarn (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/nowarn-compiler-option).

**Treat warnings as errors**

Select whether warnings are treated as errors during the build process. For more information, see [/warnaserror (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/warnaserror-compiler-option).

**Treat specific warnings as errors**

Specify which warnings are treated as errors. Separate multiple warning numbers with a comma or semicolon.

> [!TIP]
> If you don't want code analysis warnings to be treated as errors, see [Code analysis FAQ](/visualstudio/code-quality/analyzers-faq#treat-warnings-as-errors).






// Below are from old Application Settings


**Auto-generate binding redirects**

Binding redirects are added to your project if your app or its components reference more than one version of the same assembly. If you want to manually define binding redirects in the project file, deselect **Auto-generate binding redirects**.

For more information about redirection, see [Redirecting assembly versions](/dotnet/framework/configure-apps/redirect-assembly-versions).

**Assembly Information**

This button opens the [Assembly Information](../../ide/reference/assembly-information-dialog-box.md) dialog box.




**Resource file**

Select this radio button when you're providing a resource file for the project. Selecting this option disables the **Icon** and **Manifest** options.

Enter a path name or use the Browse button (**...**) to add a Win32 resource file to the project.

For more information, see [Create resource files for .NET apps](/dotnet/framework/resources/creating-resource-files-for-desktop-apps).

## See also

[Revamped Project Properties UI](https://devblogs.microsoft.com/visualstudio/revamped-project-properties-ui/)