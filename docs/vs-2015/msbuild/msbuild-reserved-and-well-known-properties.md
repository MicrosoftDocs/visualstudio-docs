---
title: "MSBuild Reserved and Well-Known Properties | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, reserved properties"
ms.assetid: 99333e61-83c9-4804-84e3-eda297c2478d
caps.latest.revision: 34
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Reserved and Well-Known Properties
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] provides a set of predefined properties that store information about the project file and the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] binaries. These properties are evaluated in the same manner as other [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] properties. For example, to use the `MSBuildProjectFile` property, you type `$(MSBuildProjectFile)`.  
  
 MSBuild uses the values in the following table to predefine reserved and well-known properties. Reserved properties cannot be overridden, but well-known properties can be overridden by using identically named environment properties, global properties, or properties that are declared in the project file.  
  
## Reserved and Well-Known Properties  
 The following table describes the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] predefined properties.  
  
|Property|Description|Reserved or Well-Known|  
|--------------|-----------------|-----------------------------|  
|`MSBuildBinPath`|The absolute path of the folder where the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] binaries that are currently being used are located (for example, C:\Windows\Microsoft.Net\Framework\\*versionNumber*). This property is useful if you have to refer to files in the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] directory.<br /><br /> Do not include the final backslash on this property.|Reserved|  
|`MSBuildExtensionsPath`|Introduced in the .NET Framework 4: there is no difference between the default values of `MSBuildExtensionsPath` and `MSBuildExtensionsPath32`. You can set the environment variable `MSBUILDLEGACYEXTENSIONSPATH` to a non-null value to enable the behavior of the default value of `MSBuildExtensionsPath` in earlier versions.<br /><br /> In the .NET Framework 3.5 and earlier, the default value of `MSBuildExtensionsPath` points to the path of the MSBuild subfolder under the \Program Files\ or \Program Files (x86) folder, depending on the bitness of the current process. For example, for a 32-bit process on a 64-bit machine, this property points to the \Program Files (x86) folder. For a 64-bit process on a 64-bit machine, this property points to the \Program Files folder.<br /><br /> Do not include the final backslash on this property.<br /><br /> This location is a useful place to put custom target files. For example, your target files could be installed at \Program Files\MSBuild\MyFiles\Northwind.targets and then imported in project files by using this XML code:<br /><br /> `<Import Project="$(MSBuildExtensionsPath)\MyFiles\Northwind.targets"/>`|Well-Known|  
|`MSBuildExtensionsPath32`|The path of the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] subfolder under the \Program Files or \Program Files (x86) folder. This path always points to the 32-bit \Program Files folder on a 32-bit machine and \Program Files (x86) on a 64-bit machine. See also `MSBuildExtensionsPath` and `MSBuildExtensionsPath64`.<br /><br /> Do not include the final backslash on this property.|Well-Known|  
`MSBuildExtensionsPath64`|The path of the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] subfolder under the \Program Files folder. For a 64-bit machine, this path always points to the \Program Files folder. For a 32-bit machine, this path is blank. See also `MSBuildExtensionsPath` and `MSBuildExtensionsPath32`.<br /><br /> Do not include the final backslash on this property.|Well-Known|  
|`MSBuildLastTaskResult`|`true` if the previous task completed without any errors (even if there were warnings), or `false` if the previous task had errors. Typically, when an error occurs in a task, the error is the last thing that happens in that project. Therefore, the value of this property is never `false`, except in these scenarios:<br /><br /> - When the `ContinueOnError` attribute of the [Task Element (MSBuild)](../msbuild/task-element-msbuild.md) is set to `WarnAndContinue` (or `true`) or `ErrorAndContinue`.<br /><br /> - When the `Target` has an [OnError Element (MSBuild)](../msbuild/onerror-element-msbuild.md) as a child element.|Reserved|  
|`MSBuildNodeCount`|The maximum number of concurrent processes that are used when building. This is the value that you specified for **/maxcpucount** on the command line. If you specified **/maxcpucount** without specifying a value, then `MSBuildNodeCount` specifies the number of processors in the computer. For more information, see [Command-Line Reference](../msbuild/msbuild-command-line-reference.md) and [Building Multiple Projects in Parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md).|Reserved|  
|`MSBuildProgramFiles32`|The location of the 32-bit program folder; for example, `C:\Program Files (x86)`.<br /><br /> Do not include the final backslash on this property.|Reserved|  
|`MSBuildProjectDefaultTargets`|The complete list of targets that are specified in the `DefaultTargets` attribute of the `Project` element. For example, the following `Project` element would have an `MSBuildDefaultTargets` property value of `A;B;C`:<br /><br /> `<Project DefaultTargets="A;B;C" >`|Reserved|  
|`MSBuildProjectDirectory`|The absolute path of the directory where the project file is located, for example `C:\MyCompany\MyProduct`.<br /><br /> Do not include the final backslash on this property.|Reserved|  
|`MSBuildProjectDirectoryNoRoot`|The value of the `MSBuildProjectDirectory` property, excluding the root drive.<br /><br /> Do not include the final backslash on this property.|Reserved|  
|`MSBuildProjectExtension`|The file name extension of the project file, including the period; for example, .proj.|Reserved|  
|`MSBuildProjectFile`|The complete file name of the project file, including the file name extension; for example, MyApp.proj.|Reserved|  
|`MSBuildProjectFullPath`|The absolute path and complete file name of the project file, including the file name extension; for example, C:\MyCompany\MyProduct\MyApp.proj.|Reserved|  
|`MSBuildProjectName`|The file name of the project file without the file name extension; for example, MyApp.|Reserved|  
|`MSBuildStartupDirectory`|The absolute path of the folder where [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] is called. By using this property, you can build everything below a specific point in a project tree without creating dirs.proj files in every directory. Instead, you have just one project—for example, c:\traversal.proj, as shown here:<br /><br /> `<Project ...>     <ItemGroup>         <ProjectFiles              Include="$            (MSBuildStartupDirectory)            **\*.csproj"/>     </ItemGroup>     <Target Name="build">         <MSBuild             Projects="@(ProjectFiles)"/>     </Target> </Project>`<br /><br /> To build at any point in the tree, type:<br /><br /> `msbuild c:\traversal.proj`<br /><br /> Do not include the final backslash on this property.|Reserved|  
|`MSBuildThisFile`|The file name and file extension portion of `MSBuildThisFileFullPath`.|Reserved|  
|`MSBuildThisFileDirectory`|The directory portion of `MSBuildThisFileFullPath`.<br /><br /> Include the final backslash in the path.|Reserved|  
|`MSBuildThisFileDirectoryNoRoot`|The directory portion of `MSBuildThisFileFullPath`, excluding the root drive.<br /><br /> Include the final backslash in the path.|Reserved|  
|`MSBuildThisFileExtension`|The file name extension portion of `MSBuildThisFileFullPath`.|Reserved|  
|`MSBuildThisFileFullPath`|The absolute path of the project or targets file that contains the target that is running.<br /><br /> Tip: You can specify a relative path in a targets file that's relative to the targets file and not relative to the original project file.|Reserved|  
|`MSBuildThisFileName`|The file name portion of `MSBuildThisFileFullPath`, without the file name extension.|Reserved|  
|`MSBuildToolsPath`|The installation path of the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] version that's associated with the value of `MSBuildToolsVersion`.<br /><br /> Do not include the final backslash in the path.<br /><br /> This property cannot be overridden.|Reserved|  
|`MSBuildToolsVersion`|The version of the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] Toolset that is used to build the project.<br /><br /> Note: An [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] Toolset consists of tasks, targets, and tools that are used to build an application. The tools include compilers such as csc.exe and vbc.exe. For more information, see [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md), and [Standard and Custom Toolset Configurations](../msbuild/standard-and-custom-toolset-configurations.md).|Reserved|  
  
## See Also  
 [MSBuild Reference](../msbuild/msbuild-reference.md)
 [MSBuild Properties](msbuild-properties1.md)
