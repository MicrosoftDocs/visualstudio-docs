---
title: RegisterAssembly Task
description: Learn how MSBuild uses the RegisterAssembly task to read the metadata within a specified assembly and add the necessary entries to the registry.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#RegisterAssembly
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, RegisterAssembly task
- RegisterAssembly task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# RegisterAssembly task

Reads the metadata within the specified assembly and adds the necessary entries to the registry, which allows COM clients to create .NET Framework classes transparently. The behavior of this task is similar, but not identical, to that of the [Regasm.exe (Assembly Registration tool)](/dotnet/framework/tools/regasm-exe-assembly-registration-tool).

## Parameters

 The following table describes the parameters of the `RegisterAssembly` task.

|Parameter|Description|
|---------------|-----------------|
|`Assemblies`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the assemblies to be registered with COM.|
|`AssemblyListFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Contains information about the state between the `RegisterAssembly` task and the [UnregisterAssembly](../msbuild/unregisterassembly-task.md) task. This information prevents the `UnregisterAssembly` task from attempting to unregister an assembly that failed to register in the `RegisterAssembly` task.|
|`CreateCodeBase`|Optional `Boolean` parameter.<br /><br /> If `true`, creates a codebase entry in the registry, which specifies the file path for an assembly that is not installed in the global assembly cache. You should not specify this option if you will subsequently install the assembly that you are registering into the global assembly cache.|
|`TypeLibFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the type library to generate from the specified assembly. The generated type library contains definitions of the accessible types defined within the assembly. The type library is only generated if one of the following conditions is true:<br /><br /> -   A type library of that name does not exist at that location.<br />-   A type library exists but it's older than the assembly being passed in.<br /><br /> If the type library is newer than the assembly being passed, a new one won't be created, but the assembly will still be registered.<br /><br /> If this parameter is specified, it must have the same number of items as the `Assemblies` parameter or the task will fail. If no inputs are specified, the task will default to the name of the assembly and change the extension of the item to *.tlb*.|

## Remarks

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

 The following example uses the `RegisterAssembly` task to register the assembly specified by the `MyAssemblies` item collection.

```xml
<Project>

    <ItemGroup>
        <MyAssemblies Include="MyAssembly.dll" />
    <ItemGroup>

    <Target Name="RegisterAssemblies">
        <RegisterAssembly
            Assemblies="@(MyAssemblies)" >
    </Target>

</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
