---
title: LC Task
description: Learn how MSBuild uses the LC task to wrap LC.exe, which generates a .license file from a .licx file. 
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#LC
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, LC task
- LC task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# LC task

Wraps *LC.exe*, which generates a *.license* file from a *.licx* file. For more information on *LC.exe*, see [Lc.exe (License Compiler)](/dotnet/framework/tools/lc-exe-license-compiler).

## Parameters

The following table describes the parameters for the `LC` task.

|Parameter|Description|
|---------------|-----------------|
|`LicenseTarget`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the executable for which the *.licenses* files are generated.|
|`NoLogo`|Optional `Boolean` parameter.<br /><br /> Suppresses the Microsoft startup banner display.|
|`OutputDirectory`|Optional `String` parameter.<br /><br /> Specifies the directory in which to place the output *.licenses* files.|
|`OutputLicense`|Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the name of the *.licenses* file. If you do not specify a name, the name of the *.licx* file is used and the *.licenses* file is placed in the directory that contains the *.licx* file.|
|`ReferencedAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the referenced components to load when generating the *.license* file.|
|`SdkToolsPath`|Optional `String` parameter.<br /><br /> Specifies the path to the SDK tools, such as *resgen.exe*.|
|`Sources`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the items that contain licensed components to include in the *.licenses* file. For more information, see the documentation for the `/complist` switch in [Lc.exe (License Compiler)](/dotnet/framework/tools/lc-exe-license-compiler).|

[!INCLUDE [ToolTaskExtension arguments](includes/tooltaskextension-base-params.md)]

## Example

The following example uses the `LC` task to compile licenses.

```xml
<Project>
<!-- Item declarations, etc -->

    <Target Name="CompileLicenses">
        <LC
            Sources="@(LicxFile)"
            LicenseTarget="$(TargetFileName)"
            OutputDirectory="$(IntermediateOutputPath)"
            OutputLicenses="$(IntermediateOutputPath)$(TargetFileName).licenses"
            ReferencedAssemblies="@(ReferencePath);@(ReferenceDependencyPaths)">

            <Output
                TaskParameter="OutputLicenses"
                ItemName="CompiledLicenseFile"/>
        </LC>
    </Target>
</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
