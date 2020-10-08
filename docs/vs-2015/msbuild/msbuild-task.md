---
title: "MSBuild Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#MSBuild"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild task [MSBuild]"
  - "MSBuild, MSBuild task"
ms.assetid: 76577f6c-7669-44ad-a840-363e37a04d34
caps.latest.revision: 35
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Builds [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] projects from another [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project.  
  
## Parameters  
 The following table describes the parameters of the `MSBuild` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`BuildInParallel`|Optional `Boolean` parameter.<br /><br /> If `true`, the projects specified in the `Projects` parameter are built in parallel if it is possible. Default is `false`.|  
|`Projects`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the project files to build.|  
|`Properties`|Optional `String` parameter.<br /><br /> A semicolon-delimited list of property name/value pairs to apply as global properties to the child project. When you specify this parameter, it is functionally equivalent to setting properties that have the **/property** switch when you build with [MSBuild.exe](../msbuild/msbuild-command-line-reference.md). For example:<br /><br /> `Properties="Configuration=Debug;Optimize=$(Optimize)"`<br /><br /> When you pass properties to the project through the `Properties` parameter, [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] creates a new instance of the project even if the project file has already been loaded. When a new instance of the project has been created, [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] treats it as a different project that has different global properties and that can be built in parallel with other instances of the project. For example, a Release configuration could build at the same time as a Debug configuration.|  
|`RebaseOutputs`|Optional `Boolean` parameter.<br /><br /> If `true`, the relative paths of target output items from the built projects have their paths adjusted to be relative to the calling project. Default is `false`.|  
|`RemoveProperties`|Optional `String` parameter.<br /><br /> Specifies the set of global properties to remove.|  
|`RunEachTargetSeparately`|Optional `Boolean` parameter.<br /><br /> If `true`, the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] task invokes each target in the list passed to [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] one at a time, instead of at the same time. Setting this parameter to `true` guarantees that subsequent targets are invoked even if previously invoked targets failed. Otherwise, a build error would stop invocation of all subsequent targets. Default is `false`.|  
|`SkipNonexistentProjects`|Optional `Boolean` parameter.<br /><br /> If `true`, project files that do not exist on the disk will be skipped. Otherwise, such projects will cause an error.|  
|`StopOnFirstFailure`|Optional `Boolean` parameter.<br /><br /> If `true`, when one of the projects fails to build, no more projects will be built. Currently this is not supported when building in parallel (with multiple processors).|  
|`TargetAndPropertyListSeparators`|Optional `String[]` parameter.<br /><br /> Specifies a list of targets and properties as `Project` item metadata). Separators will be un-escaped before processing. e.g. %3B (an escaped ';') will be treated as if it were an un-escaped ';'.|  
|`TargetOutputs`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` read-only output parameter.<br /><br /> Returns the outputs of the built targets from all the project files. Only the outputs from the targets that were specified are returned, not any outputs that may exist on targets that those targets depend on.<br /><br /> The `TargetOutputs` parameter also contains the following metadata:<br /><br /> -   `MSBuildSourceProjectFile`: The [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project file that contains the target that set the outputs.<br />-   `MSBuildSourceTargetName`: The target that set the outputs. **Note:**  If you want to identify the outputs from each project file or target separately, run the `MSBuild` task separately for each project file or target. If you run the `MSBuild` task only once to build all the project files, the outputs of all the targets are collected into one array.|  
|`Targets`|Optional `String` parameter.<br /><br /> Specifies the target or targets to build in the project files. Use a semicolon to separate a list of target names. If no targets are specified in the `MSBuild` task, the default targets specified in the project files are built. **Note:**  The targets must occur in all the project files. If they do not, a build error occurs.|  
|`ToolsVersion`|Optional `String` parameter.<br /><br /> Specifies the `ToolsVersion` to use when building projects passed to this task.<br /><br /> Enables an [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] task to build a project that targets a different version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] than the one specified in the project. Valid values are `2.0`, `3.0` and `3.5`. Default value is `3.5`.|  
|`UnloadProjectsOnCompletion`|Optional `Boolean` parameter.<br /><br /> If `true`, the project will be unloaded once the operation is complete.|  
|`UseResultsCache`|Optional `Boolean` parameter.<br /><br /> If `true`, the cached result will be returned, if present. If theMSBuild task is run, its result will be cached in a scope (ProjectFileName, GlobalProperties)[TargetNames]<br /><br /> as a list of build items|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
 Unlike using the [Exec Task](../msbuild/exec-task.md) to start MSBuild.exe, this task uses the same [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] process to build the child projects. The list of already-built targets that can be skipped is shared between the parent and child builds. This task is also faster because no new [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] process is created.  
  
 This task can process not only project files but also solution files.  
  
 Any configuration that is required by [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] to enable projects to build at the same time, even if the configuration involves remote infrastructure (for example, ports, protocols, timeouts, retries, and so forth), must be made configurable by using a configuration file. When possible, configuration items should be able to be specified as task parameters on the `MSBuild` task.  
  
 Beginning in [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] 3.5, Solution projects now surface TargetOutputs from all of the sub-projects it builds.  
  
## Passing Properties to Projects  
 In versions of [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] prior to [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] 3.5, passing different sets of properties to different projects listed in the [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] item was challenging. If you used the Properties attribute of the [MSBuild Task](../msbuild/msbuild-task.md), then its setting was applied to all of the projects being built unless you batched the [MSBuild Task](../msbuild/msbuild-task.md) and conditionally provided different properties for each project in the item list.  
  
 [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] 3.5, however, provides two new reserved metadata items, Properties and AdditionalProperties, that provide you a flexible way to pass different properties for different projects being built using the [MSBuild Task](../msbuild/msbuild-task.md).  
  
> [!NOTE]
> These new metadata items are applicable only to items passed in the Projects attribute of the [MSBuild Task](../msbuild/msbuild-task.md).  
  
## Multi-Processor Build Benefits  
 One of the major benefits of using this new metadata occurs when you build your projects in parallel on a multi-processor system. The metadata allows you to consolidate all projects into a single [MSBuild Task](../msbuild/msbuild-task.md) call without having to perform any batching or conditional [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] tasks. And when you call only a single [MSBuild Task](../msbuild/msbuild-task.md), all of the projects listed in the Projects attribute will be built in parallel. (Only, however, if the `BuildInParallel=true` attribute is present in the [MSBuild Task](../msbuild/msbuild-task.md).) For more information, see [Building Multiple Projects in Parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md).  
  
## Properties Metadata  
 A common scenario is when you are building multiple solution files using the [MSBuild Task](../msbuild/msbuild-task.md), only using different build configurations. You may want to build solution a1 using the Debug configuration and solution a2 using the Release configuration. In [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] 2.0, this project file would look like the following:  
  
> [!NOTE]
> In the following example, "…" represents additional solution files.  
  
### a.proj  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Target Name="Build">  
        <MSBuild Projects="a1.sln..." Properties="Configuration=Debug"/>  
        <MSBuild Projects="a2.sln" Properties="Configuration=Release"/>  
    </Target>  
</Project>  
```  
  
 By using the Properties metadata, however, you can simplify this to use a single [MSBuild Task](../msbuild/msbuild-task.md), as shown by the following:  
  
### a.proj  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <ItemGroup>  
        <ProjectToBuild Include="a1.sln…">  
            <Properties>Configuration=Debug</Properties>  
        </ProjectToBuild>  
        <ProjectToBuild Include="a2.sln">  
            <Properties>Configuration=Release</Properties>  
        </ProjectToBuild>  
    </ItemGroup>  
    <Target Name="Build">  
        <MSBuild Projects="@(ProjectToBuild)"/>  
    </Target>  
</Project>  
```  
  
 \- or -  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <ItemGroup>  
        <ProjectToBuild Include="a1.sln…"/>  
        <ProjectToBuild Include="a2.sln">  
            <Properties>Configuration=Release</Properties>  
        </ProjectToBuild>  
    </ItemGroup>  
    <Target Name="Build">  
        <MSBuild Projects="@(ProjectToBuild)"   
          Properties="Configuration=Debug"/>  
    </Target>  
</Project>  
```  
  
## AdditionalProperties Metadata  
 Consider the following scenario where you are building two solution files using the [MSBuild Task](../msbuild/msbuild-task.md), both using the Release configuration, but one using the x86 architecture and the other using the ia64 architecture. In [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] 2.0, you would need to create multiple instances of the [MSBuild Task](../msbuild/msbuild-task.md): one to build the project using the Release configuration with the x86 Architecture, the other using the Release configuration with the ia64 architecture. Your project file would look like the following:  
  
### a.proj  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Target Name="Build">  
        <MSBuild Projects="a1.sln…" Properties="Configuration=Release;   
          Architecture=x86"/>  
        <MSBuild Projects="a2.sln" Properties="Configuration=Release;   
          Architecture=ia64"/>  
    </Target>  
</Project>  
```  
  
 By using the AdditionalProperties metadata, you can simplify this to use a single [MSBuild Task](../msbuild/msbuild-task.md) by using the following:  
  
### a.proj  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <ItemGroup>  
        <ProjectToBuild Include="a1.sln…">  
            <AdditionalProperties>Architecture=x86  
              </AdditionalProperties>  
        </ProjectToBuild>  
        <ProjectToBuild Include="a2.sln">  
            <AdditionalProperties>Architecture=ia64  
              </AdditionalProperties>  
        </ProjectToBuild>  
    </ItemGroup>  
    <Target Name="Build">  
        <MSBuild Projects="@(ProjectToBuild)"   
          Properties="Configuration=Release"/>  
    </Target>  
</Project>  
```  
  
## Example  
 The following example uses the `MSBuild` task to build the projects specified by the `ProjectReferences` item collection. The resulting target outputs are stored in the `AssembliesBuiltByChildProjects` item collection.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <ItemGroup>  
        <ProjectReferences Include="*.*proj" />  
    </ItemGroup>  
  
    <Target Name="BuildOtherProjects">  
        <MSBuild  
            Projects="@(ProjectReferences)"  
            Targets="Build">  
            <Output  
                TaskParameter="TargetOutputs"  
                ItemName="AssembliesBuiltByChildProjects" />  
        </MSBuild>  
    </Target>  
  
</Project>  
```  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
