---
title: "RegisterAssembly Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#RegisterAssembly"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, RegisterAssembly task"
  - "RegisterAssembly task [MSBuild]"
ms.assetid: ba5f19ac-6764-4d28-9b79-a86de58f8987
caps.latest.revision: 19
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# RegisterAssembly Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Reads the metadata within the specified assembly and adds the necessary entries to the registry, which allows COM clients to create [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] classes transparently. The behavior of this task is similar, but not identical, to that of the [Regasm.exe (Assembly Registration Tool)](https://msdn.microsoft.com/library/e190e342-36ef-4651-a0b4-0e8c2c0281cb).  
  
## Parameters  
 The following table describes the parameters of the `RegisterAssembly` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Assemblies`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the assemblies to be registered with COM.|  
|`AssemblyListFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Contains information about the state between the `RegisterAssembly` task and the [UnregisterAssembly](../msbuild/unregisterassembly-task.md) task. This prevents the `UnregisterAssembly` task from attempting to unregister an assembly that failed to register in the `RegisterAssembly` task.|  
|`CreateCodeBase`|Optional `Boolean` parameter.<br /><br /> If `true`, creates a codebase entry in the registry, which specifies the file path for an assembly that is not installed in the global assembly cache. You should not specify this option if you will subsequently install the assembly that you are registering into the global assembly cache.|  
|`TypeLibFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the type library to generate from the specified assembly. The generated type library contains definitions of the accessible types defined within the assembly. The type library is only generated if one of the following is true:<br /><br /> -   A type library of that name does not exist at that location.<br />-   A type library exists but it is older than the assembly being passed in.<br /><br /> If the type library is newer than the assembly being passed, a new one will not be created, but the assembly will still be registered.<br /><br /> If this parameter is specified, it must have the same number of items as the `Assemblies` parameter or the task will fail. If no inputs are specified, the task will default to the name of the assembly and change the extension of the item to .tlb.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## Example  
 The following example uses the `RegisterAssembly` task to register the assembly specified by the `MyAssemblies` item collection.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <ItemGroup>  
        <MyAssemblies Include="MyAssembly.dll" />  
    <ItemGroup>  
  
    <Target Name="RegisterAssemblies">  
        <RegisterAssembly  
            Assemblies="@(MyAssemblies)" >  
    </Target>  
  
</Project>  
```  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
