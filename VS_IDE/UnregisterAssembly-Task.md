---
title: "UnregisterAssembly Task"
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
ms.assetid: 04f549dd-3591-4dda-9c3a-cf6ede9df2c3
caps.latest.revision: 21
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# UnregisterAssembly Task
Unregisters the specified assemblies for COM interop purposes. Performs the reverse of the [RegisterAssembly task](../VS_IDE/RegisterAssembly-Task.md).  
  
## Parameters  
 The following table describes the parameters of the `UnregisterAssembly` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Assemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the assemblies to be unregistered.|  
|`AssemblyListFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> parameter.<br /><br /> Contains information about the state between the `RegisterAssembly` task and the `UnregisterAssembly` task. This prevents the task from attempting to unregister an assembly that failed to register in the `RegisterAssembly` task.<br /><br /> If this parameter is specified, the `Assemblies` and `TypeLibFiles` parameters are ignored.|  
|`TypeLibFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Unregisters the specified type library from the specified assembly. **Note:**  This parameter is only necessary if the type library file name is different than the assembly name.|  
  
## Remarks  
 It is not required that the assembly exists for this task to be successful. If you attempt to unregister an assembly that does not exist, the task will succeed with a warning. This occurs because it is the job of this task to remove the assembly registration from the registry. If the assembly does not exist, it is not in the registry, and therefore, the task succeeded.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension?qualifyHint=False> class, which itself inherits from the <xref:System.MarshalByRefObject?qualifyHint=False> class. The `MarshalByRefObject` class provides the same functionality as the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class, but it can be instantiated in its own application domain.  
  
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
 [RegisterAssembly Task](../VS_IDE/RegisterAssembly-Task.md)   
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)