---
title: "UnregisterAssembly Task"
description: Learn how MSBuild uses the UnregisterAssembly task to unregister specified assemblies for COM interop purposes.
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#UnregisterAssembly"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild, UnregisterAssembly task"
  - "UnregisterAssembly task [MSBuild]"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# UnregisterAssembly task

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

```xml
<Project>
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

## See also

- [RegisterAssembly task](../msbuild/registerassembly-task.md)
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)