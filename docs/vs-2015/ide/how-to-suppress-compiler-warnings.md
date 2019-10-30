---
title: "How to: Suppress Compiler Warnings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: 31827b17-f933-413d-b28a-b19f903b64ca
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Suppress Compiler Warnings

[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can declutter a build log by specifying one or more kinds of compiler warnings that you don’t want it to contain. For example, you might use this technique to review some but not all of the information that’s generated automatically when you set the build-log verbosity to Normal, Detailed, or Diagnostic. For more information about verbosity, see [How to: View, Save, and Configure Build Log Files](../ide/how-to-view-save-and-configure-build-log-files.md).

### To suppress specific warnings for Visual C# or F\#

1. In **Solution Explorer**, choose the project in which you want to suppress warnings.

2. On the menu bar, choose **View**, **Property Pages**.

3. Choose the **Build** page.

4. In the **Suppress warnings** box, specify the error codes of the warnings that you want to suppress, separated by semicolons, and then rebuild the solution.

### To suppress specific warnings for Visual C++

1. In **Solution Explorer**, choose the project or source file in which you want to suppress warnings.

2. On the menu bar, choose **View**, **Property Pages**.

3. Choose the **Configuration Properties** category, choose the **C/C++** category, and then choose the **Advanced** page.

4. Perform one of the following steps:

    - In the **Disable Specific Warnings** box, specify the error codes of the warnings that you want to suppress, separated by a semicolon.

    - In the **Disable Specific Warnings** box, choose **Edit** to display more options.

5. Choose the **OK** button, and then rebuild the solution.

## Suppressing Warnings for Visual Basic

You can hide specific compiler warnings for Visual Basic by editing the .vbproj file for the project. You can also use the [Compile Page, Project Designer](../ide/reference/compile-page-project-designer-visual-basic.md) to suppress warnings by category. For more information, see [Configuring Warnings in Visual Basic](../ide/configuring-warnings-in-visual-basic.md).

#### To suppress specific warnings for Visual Basic

1. In **Solution Explorer**, choose the project in which you want to suppress warnings.

2. On the menu bar, choose **Project**, **Unload Project**.

3. In **Solution Explorer**, open the shortcut menu for the project, and then choose **Edit**_ProjectName_**.vbproj**.

    The project file is opened in the code editor.

4. Locate the `<NoWarn></NoWarn>` element in the build configuration with which you’re building.

    The following example shows the `<NoWarn></NoWarn>` element in bold text for the Debug build configuration on an x86 platform:

   ```xml
   <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
       <PlatformTarget>x86</PlatformTarget>
       <DebugSymbols>true</DebugSymbols>
       <DebugType>full</DebugType>
       <Optimize>false</Optimize>
       <OutputPath>bin\Debug\</OutputPath>
       <DefineDebug>true</DefineDebug>
       <DefineTrace>true</DefineTrace>
       <ErrorReport>prompt</ErrorReport>
       <NoWarn></NoWarn>
       <WarningLevel>1</WarningLevel>
     </PropertyGroup>
   ```

5. Add one or more warning numbers as the value of the `<NoWarn>` element. If you specify multiple warning numbers, separate them with a comma, as the following example shows.

   ```xml
   <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
       <PlatformTarget>x86</PlatformTarget>
       <DebugSymbols>true</DebugSymbols>
       <DebugType>full</DebugType>
       <Optimize>false</Optimize>
       <OutputPath>bin\Debug\</OutputPath>
       <DefineDebug>true</DefineDebug>
       <DefineTrace>true</DefineTrace>
       <ErrorReport>prompt</ErrorReport>
       <NoWarn>40059,42024</NoWarn>
       <WarningLevel>1</WarningLevel>
     </PropertyGroup>
   ```

6. Save the changes to the .vbproj file.

7. On the menu bar, choose **Project**, **Reload Project**.

8. On the menu bar, choose **Build**, **Rebuild Solution**.

    The **Output** window no longer shows the warnings that you specified.

   For more information, see [/nowarn](https://msdn.microsoft.com/library/7ebf2106-0652-4fdc-bf60-70fc86465d83).

## See Also

- [Walkthrough: Building an Application](../ide/walkthrough-building-an-application.md)
- [How to: View, Save, and Configure Build Log Files](../ide/how-to-view-save-and-configure-build-log-files.md)
- [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)
