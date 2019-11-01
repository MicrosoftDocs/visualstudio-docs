---
title: "How to: Configure projects to target platforms"
ms.date: 08/16/2019
ms.technology: vs-ide-compile
ms.topic: conceptual
helpviewer_keywords:
  - "project settings [Visual Studio], targeting platforms"
  - "platforms, targeting specific CPUs"
  - "project properties [Visual Studio], targeting platforms"
  - "projects [Visual Studio], targeting platforms"
  - "64-bit [Visual Studio]"
  - "64-bit programming [Visual Studio]"
  - "CPUs, targeting specific"
  - "64-bit applications [Visual Studio]"
ms.assetid: 845302fc-273d-4f81-820a-7296ce91bd76
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Configure projects to target platforms

Visual Studio enables you to set up your applications to target different platforms, including 64-bit platforms. For more information on 64-bit platform support in Visual Studio, see [64-bit applications](/dotnet/framework/64-bit-apps).

## Target platforms with the Configuration Manager

The **Configuration Manager** provides a way for you to quickly add a new platform to target with your project. If you select one of the platforms included with Visual Studio, the properties for your project are modified to build your project for the selected platform.

### To configure a project to target a 64-bit platform

1. On the menu bar, choose **Build** > **Configuration Manager**.

2. In the **Active solution platform** list, choose a 64-bit platform for the solution to target, and then choose the **Close** button.

    1. If the platform that you want doesn't appear in the **Active solution platform** list, choose **New**.

         The **New Solution Platform** dialog box appears.

    2. In the **Type or select the new platform** list, choose **x64**.

        > [!NOTE]
        > If you give your configuration a new name, you may have to modify the settings in the **Project Designer** to target the correct platform.

    3. If you want to copy the settings from a current platform configuration, choose it, and then choose the **OK** button.

The properties for all projects that target the 64-bit platform are updated, and the next build of the project will be optimized for 64-bit platforms.

## Target platforms in the Project Designer

The **Project Designer** also provides a way to target different platforms with your project. If selecting one of the platforms included in the list in the **New Solution Platform** dialog box does not work for your solution, you can create a custom configuration name and modify the settings in the **Project Designer** to target the correct platform.

Performing this task varies based on the programming language you are using. See the following links for more information:

- For [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] projects, see [/platform (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/platform).

- For [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] projects, see [Build page, Project Designer (C#)](../ide/reference/build-page-project-designer-csharp.md).

- For [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] projects, see [/clr (Common Language Runtime compilation)](/cpp/build/reference/clr-common-language-runtime-compilation).

## Manually editing the project file

Sometimes, you need to manually edit the project file for some custom configuration. An example is when you have conditions that can't be specified in the IDE, such as a reference that is different for two different platforms, as in the following example.

### Example: Referencing x86 and x64 assemblies and DLLs

You might have a .NET assembly or DLL that has both x86 and x64 versions. To set up your project to use these references, first add the reference, and then open the project file and edit it to add an `ItemGroup` with a condition that references both the configuration, and the target platform.  For example, suppose the binary you are referencing is ClassLibrary1 and there are different paths for Debug and Release configurations, as well as x86 and x64 versions.  Then, use four `ItemGroup` elements with all combinations of settings, as follows:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <Platforms>AnyCPU;x64;x86</Platforms>
  </PropertyGroup>

  <ItemGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x64'">
    <Reference Include="ClassLibrary1">
      <HintPath>..\..\ClassLibrary1\ClassLibrary1\bin\x64\Debug\netstandard2.0\ClassLibrary1.dll</HintPath>
    </Reference>
  </ItemGroup>

  <ItemGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x64'">
    <Reference Include="ClassLibrary1">
      <HintPath>..\..\ClassLibrary1\ClassLibrary1\bin\x64\Release\netstandard2.0\ClassLibrary1.dll</HintPath>
    </Reference>
  </ItemGroup>

  <ItemGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86'">
    <Reference Include="ClassLibrary1">
      <HintPath>..\..\ClassLibrary1\ClassLibrary1\bin\x86\Debug\netstandard2.0\ClassLibrary1.dll</HintPath>
    </Reference>
  </ItemGroup>
  
  <ItemGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86'">
    <Reference Include="ClassLibrary1">
      <HintPath>..\..\ClassLibrary1\ClassLibrary1\bin\x86\Release\netstandard2.0\ClassLibrary1.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

::: moniker range="vs-2017"
> [!NOTE]
> In Visual Studio 2017, you need to unload the project before you can edit the project file. To unload the project, right-click on the project node, and choose **Unload project**. When done editing, save your changes and reload the project by right-clicking the project node and choosing **Reload project**.
::: moniker-end

For more information about the project file, see [MSBuild project file schema reference](../msbuild/msbuild-project-file-schema-reference.md).

## See also

- [Understand build platforms](../ide/understanding-build-platforms.md)
- [/platform (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/platform-compiler-option)
- [64-bit applications](/dotnet/framework/64-bit-apps)
- [Visual Studio IDE 64-Bit support](../ide/visual-studio-ide-64-bit-support.md)
- [Understanding the project file](/aspnet/web-forms/overview/deployment/web-deployment-in-the-enterprise/understanding-the-project-file)
