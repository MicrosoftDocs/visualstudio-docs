---
title: "MSBuild Task"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 76577f6c-7669-44ad-a840-363e37a04d34
caps.latest.revision: 32
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# MSBuild Task
Builds MSBuild projects from another MSBuild project.  
  
## Parameters  
 The following table describes the parameters of the `MSBuild` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`BuildInParallel`|Optional `Boolean` parameter.<br /><br /> If `true`, the projects specified in the `Projects` parameter are built in parallel if it is possible. Default is `false`.|  
|`Projects`|Required <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the project files to build.|  
|`Properties`|Optional `String` parameter.<br /><br /> A semicolon-delimited list of property name/value pairs to apply as global properties to the child project. When you specify this parameter, it is functionally equivalent to setting properties that have the **/property** switch when you build with [MSBuild.exe](../VS_IDE/MSBuild-Command-Line-Reference.md). For example:<br /><br /> `Properties="Configuration=Debug;Optimize=$(Optimize)"`<br /><br /> When you pass properties to the project through the `Properties` parameter, MSBuild creates a new instance of the project even if the project file has already been loaded. When a new instance of the project has been created, MSBuild treats it as a different project that has different global properties and that can be built in parallel with other instances of the project. For example, a Release configuration could build at the same time as a Debug configuration.|  
|`RebaseOutputs`|Optional `Boolean` parameter.<br /><br /> If `true`, the relative paths of target output items from the built projects have their paths adjusted to be relative to the calling project. Default is `false`.|  
|`RemoveProperties`|Optional `String` parameter.<br /><br /> Specifies the set of global properties to remove.|  
|`RunEachTargetSeparately`|Optional `Boolean` parameter.<br /><br /> If `true`, the MSBuild task invokes each target in the list passed to MSBuild one at a time, instead of at the same time. Setting this parameter to `true` guarantees that subsequent targets are invoked even if previously invoked targets failed. Otherwise, a build error would stop invocation of all subsequent targets. Default is `false`.|  
|`SkipNonexistentProjects`|Optional `Boolean` parameter.<br /><br /> If `true`, project files that do not exist on the disk will be skipped. Otherwise, such projects will cause an error.|  
|`StopOnFirstFailure`|Optional `Boolean` parameter.<br /><br /> If `true`, when one of the projects fails to build, no more projects will be built. Currently this is not supported when building in parallel (with multiple processors).|  
|`TargetAndPropertyListSeparators`|Optional `String[]` parameter.<br /><br /> Specifies a list of targets and properties as `Project` item metadata). Separators will be un-escaped before processing. e.g. %3B (an escaped ';') will be treated as if it were an un-escaped ';'.|  
|`TargetOutputs`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` read-only output parameter.<br /><br /> Returns the outputs of the built targets from all the project files. Only the outputs from the targets that were specified are returned, not any outputs that may exist on targets that those targets depend on.<br /><br /> The `TargetOutputs` parameter also contains the following metadata:<br /><br /> -   `MSBuildSourceProjectFile`: The MSBuild project file that contains the target that set the outputs.<br />-   `MSBuildSourceTargetName`: The target that set the outputs. **Note:**  If you want to identify the outputs from each project file or target separately, run the `MSBuild` task separately for each project file or target. If you run the `MSBuild` task only once to build all the project files, the outputs of all the targets are collected into one array.|  
|`Targets`|Optional `String` parameter.<br /><br /> Specifies the target or targets to build in the project files. Use a semicolon to separate a list of target names. If no targets are specified in the `MSBuild` task, the default targets specified in the project files are built. **Note:**  The targets must occur in all the project files. If they do not, a build error occurs.|  
|`ToolsVersion`|Optional `String` parameter.<br /><br /> Specifies the `ToolsVersion` to use when building projects passed to this task.<br /><br /> Enables an MSBuild task to build a project that targets a different version of the .NET Framework than the one specified in the project. Valid values are `2.0`, `3.0` and `3.5`. Default value is `3.5`.|  
|`UnloadProjectsOnCompletion`|Optional `Boolean` parameter.<br /><br /> If `true`, the project will be unloaded once the operation is complete.|  
|`UseResultsCache`|Optional `Boolean` parameter.<br /><br /> If `true`, the cached result will be returned, if present. If theMSBuild task is run, its result will be cached in a scope (ProjectFileName, GlobalProperties)[TargetNames]<br /><br /> as a list of build items|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
 Unlike using the [Exec Task](../VS_IDE/Exec-Task.md) to start MSBuild.exe, this task uses the same MSBuild process to build the child projects. The list of already-built targets that can be skipped is shared between the parent and child builds. This task is also faster because no new MSBuild process is created.  
  
 This task can process not only project files but also solution files.  
  
 Any configuration that is required by MSBuild to enable projects to build at the same time, even if the configuration involves remote infrastructure (for example, ports, protocols, timeouts, retries, and so forth), must be made configurable by using a configuration file. When possible, configuration items should be able to be specified as task parameters on the `MSBuild` task.  
  
 Beginning in MSBuild 3.5, Solution projects now surface TargetOutputs from all of the sub-projects it builds.  
  
## Passing Properties to Projects  
 In versions of MSBuild prior to MSBuild 3.5, passing different sets of properties to different projects listed in the MSBuild item was challenging. If you used the Properties attribute of the [MSBuild Task](../VS_IDE/MSBuild-Task.md), then its setting was applied to all of the projects being built unless you batched the [MSBuild Task](../VS_IDE/MSBuild-Task.md) and conditionally provided different properties for each project in the item list.  
  
 MSBuild 3.5, however, provides two new reserved metadata items, Properties and AdditionalProperties, that provide you a flexible way to pass different properties for different projects being built using the [MSBuild Task](../VS_IDE/MSBuild-Task.md).  
  
> [!NOTE]
>  These new metadata items are applicable only to items passed in the Projects attribute of the [MSBuild Task](../VS_IDE/MSBuild-Task.md).  
  
## Multi-Processor Build Benefits  
 One of the major benefits of using this new metadata occurs when you build your projects in parallel on a multi-processor system. The metadata allows you to consolidate all projects into a single [MSBuild Task](../VS_IDE/MSBuild-Task.md) call without having to perform any batching or conditional MSBuild tasks. And when you call only a single [MSBuild Task](../VS_IDE/MSBuild-Task.md), all of the projects listed in the Projects attribute will be built in parallel. (Only, however, if the `BuildInParallel=true` attribute is present in the [MSBuild Task](../VS_IDE/MSBuild-Task.md).) For more information, see [Building Multiple Projects in Parallel](../VS_IDE/Building-Multiple-Projects-in-Parallel-with-MSBuild.md).  
  
## Properties Metadata  
 A common scenario is when you are building multiple solution files using the [MSBuild Task](../VS_IDE/MSBuild-Task.md), only using different build configurations. You may want to build solution a1 using the Debug configuration and solution a2 using the Release configuration. In MSBuild 2.0, this project file would look like the following:  
  
> [!NOTE]
>  In the following example, "…" represents additional solution files.  
  
### a.proj  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Target Name="Build">  
        <MSBuild Projects="a1.sln..." Properties="Configuration=Debug"/>  
        <MSBuild Projects="a2.sln" Properties="Configuration=Release"/>  
    </Target>  
</Project>  
```  
  
 By using the Properties metadata, however, you can simplify this to use a single [MSBuild Task](../VS_IDE/MSBuild-Task.md), as shown by the following:  
  
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
 Consider the following scenario where you are building two solution files using the [MSBuild Task](../VS_IDE/MSBuild-Task.md), both using the Release configuration, but one using the x86 architecture and the other using the ia64 architecture. In MSBuild 2.0, you would need to create multiple instances of the [MSBuild Task](../VS_IDE/MSBuild-Task.md): one to build the project using the Release configuration with the x86 Architecture, the other using the Release configuration with the ia64 architecture. Your project file would look like the following:  
  
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
  
 By using the AdditionalProperties metadata, you can simplify this to use a single [MSBuild Task](../VS_IDE/MSBuild-Task.md) by using the following:  
  
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
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)