---
title: "Overriding ToolsVersion Settings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "MSBuild, overriding ToolsVersion setting"
  - "MSBuild, building solutions with"
ms.assetid: ccd42c07-0fb6-4e8b-9ebb-a6a6db18aa2e
caps.latest.revision: 27
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Overriding ToolsVersion Settings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can change the Toolset for projects and solutions in one of three ways:  
  
1. by using the `/ToolsVersion` switch (or `/tv`, for short) when you build the project or solution from the command line  
  
2. by setting the `ToolsVersion` parameter on the MSBuild task  
  
3. by setting the `$(ProjectToolsVersion)` property on a project within a solution. This lets you build a project in a solution with a Toolset version that differs from that of the other projects.  
  
## Override the ToolsVersion Settings of Projects and Solutions on Command Line Builds  
 Although Visual Studio projects typically build with the ToolsVersion specified in the project file, you can use the `/ToolsVersion` (or `/tv`) switch on the command line to override that value and build all of the projects and their project-to-project dependencies with a different Toolset. For example:  
  
```  
msbuild.exe someproj.proj /tv:12.0 /p:Configuration=Debug  
```  
  
 In this example, all projects are built using ToolsVersion 12.0. (However, see the section "Order of Precedence" later in this topic.)  
  
 When using the `/tv` switch on the command line, you can optionally use the `$(ProjectToolsVersion)` property in individual projects to build them with a different ToolsVersion value than the other projects in the solution.  
  
## Override the ToolsVersion Settings Using the ToolsVersion Parameter of the MSBuild Task  
 The MSBuild task is the primary means for one project to build another. To enable the MSBuild task to build a project with a different ToolsVersion than the one specified in the project, it provides an optional task parameter named `ToolsVersion`. The following example demonstrates how to use this parameter:  
  
1. Create a file that's named `projectA.proj` and that contains the following code:  
  
    ```  
    <Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"  
    ToolsVersion="12.0">  
  
        <Target Name="go" >   
            <Message Text="projectA.proj" />  
            <Message Text="MSBuildToolsVersion: $(MSBuildToolsVersion)" />  
            <Message Text="MSBuildToolsPath:    $(MSBuildToolsPath)" />  
  
            <MSBuild Projects="projectB.proj"  
                ToolsVersion="2.0"  
                Targets="go" />  
        </Target>  
    </Project>  
    ```  
  
2. Create another file that's named `projectB.proj` and that contains the following code:  
  
    ```  
    <Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"  
    ToolsVersion="12.0">  
  
        <Target Name="go">  
            <Message Text="projectB.proj" />  
            <Message Text="MSBuildToolsVersion: $(MSBuildToolsVersion)" />  
            <Message Text="MSBuildToolsPath:    $(MSBuildToolsPath)" />  
        </Target>  
    </Project>  
    ```  
  
3. Enter the following command at a command prompt:  
  
    ```  
    msbuild projectA.proj /t:go /toolsversion:3.5  
    ```  
  
4. The following output appears. For `projectA`, the `/toolsversion:3.5` setting on the command line overrides the `ToolsVersion=12.0` setting in the `Project` tag.  
  
     `ProjectB` is called by a task in `projectA`. That task has `ToolsVersion=2.0`, which overrides the other `ToolsVersion` settings for `projectB`.  
  
    ```  
    Output:  
      projectA.proj  
      MSBuildToolsVersion: 3.5  
      MSBuildToolsPath:    C:\Windows\Microsoft.NET\Framework\v3.5  
  
      projectB.proj  
      MSBuildToolsVersion: 2.0  
      MSBuildToolsPath:    C:\Windows\Microsoft.NET\Framework\v2.0.50727  
    ```  
  
## Order of Precedence  
 The order of precedence, from highest to lowest, used to determine the `ToolsVersion` is:  
  
1. The `ToolsVersion` attribute on the MSBuild task used to build the project, if any.  
  
2. The `/toolsversion` (or `/tv`) switch that's used in the msbuild.exe command, if any.  
  
3. If the environment variable `MSBUILDTREATALLTOOLSVERSIONSASCURRENT` is set, then use the current `ToolsVersion`.  
  
4. If the environment variable `MSBUILDTREATHIGHERTOOLSVERSIONASCURRENT` is set and the `ToolsVersion` defined in the project file is greater than the current `ToolsVersion`, use the current `ToolsVersion`.  
  
5. If the environment variable `MSBUILDLEGACYDEFAULTTOOLSVERSION` is set, or if `ToolsVersion` is not set, then the following steps are used:  
  
    1. The `ToolsVersion` attribute of the [Project](../msbuild/project-element-msbuild.md) element of the project file. If this attribute doesn’t exist, it is assumed to be the current version.  
  
    2. The default tools version in the MSBuild.exe.config file.  
  
    3. The default tools version in the registry. For more information, see [Standard and Custom Toolset Configurations](../msbuild/standard-and-custom-toolset-configurations.md).  
  
6. If the environment variable `MSBUILDLEGACYDEFAULTTOOLSVERSION` is not set, then the following steps are used:  
  
    1. If the environment variable `MSBUILDDEFAULTTOOLSVERSION` is set to a `ToolsVersion` that exists, use it.  
  
    2. If `DefaultOverrideToolsVersion` is set in MSBuild.exe.config, use it.  
  
    3. If `DefaultOverrideToolsVersion` is set in the registry, use it.  
  
    4. Otherwise, use the current `ToolsVersion`.  
  
## See Also  
 [Multitargeting](../msbuild/msbuild-multitargeting-overview.md)   
 [MSBuild Concepts](../msbuild/msbuild-concepts.md)   
 [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md)   
 [Standard and Custom Toolset Configurations](../msbuild/standard-and-custom-toolset-configurations.md)
