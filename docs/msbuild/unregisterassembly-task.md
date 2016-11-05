---
title: "UnregisterAssembly Task | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#UnregisterAssembly"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, UnregisterAssembly task"
  - "UnregisterAssembly task [MSBuild]"
ms.assetid: 04f549dd-3591-4dda-9c3a-cf6ede9df2c3
caps.latest.revision: 21
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# UnregisterAssembly Task
Unregisters the specified assemblies for COM interop purposes. Performs the reverse of the [RegisterAssembly task](../msbuild/registerassembly-task.md).  
  
## Parameters  
 The following table describes the parameters of the `UnregisterAssembly` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Assemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the assemblies to be unregistered.|  
|`AssemblyListFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Contains information about the state between the `RegisterAssembly` task and the `UnregisterAssembly` task. This prevents the task from attempting to unregister an assembly that failed to register in the `RegisterAssembly` task.<br /><br /> If this parameter is specified, the `Assemblies` and `TypeLibFiles` parameters are ignored.|  
|`TypeLibFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Unregisters the specified type library from the specified assembly. **Note:**  This parameter is only necessary if the type library file name is different than the assembly name.|  
  
## Remarks  
 It is not required that the assembly exists for this task to be successful. If you attempt to unregister an assembly that does not exist, the task will succeed with a warning. This occurs because it is the job of this task to remove the assembly registration from the registry. If the assembly does not exist, it is not in the registry, and therefore, the task succeeded.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension> class, which itself inherits from the <xref:System.MarshalByRefObject> class. The `MarshalByRefObject` class provides the same functionality as the <xref:Microsoft.Build.Utilities.Task> class, but it can be instantiated in its own application domain.  
  
## Example  
 The following example uses the `UnregisterAssembly` task to unregister the assembly at the path specified by the `OutputPath` and `FileName` properties, if it exists.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <PropertyGroup>  
        <OutputPath>\Output\</OutputPath>  
        <FileName>MyFile.dll</FileName>  
    </PropertyGroup>  
    <Target Name="UnregisterAssemblies">  
        <UnregisterAssembly  
            Condition="Exists('$(OutputPath)$(FileName)')"  
            Assemblies="$(OutputPath)$(FileName)" />  
    </Target>  
  
</Project>  
```  
  
## See Also  
 [RegisterAssembly Task](../msbuild/registerassembly-task.md)   
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)