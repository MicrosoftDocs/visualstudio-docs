---
title: "LC Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#LC"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, LC task"
  - "LC task [MSBuild]"
ms.assetid: d5a53472-6f2a-42b8-a6db-593ca99c9790
caps.latest.revision: 18
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# LC Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Wraps LC.exe, which generates a .license file from a .licx file. For more information on LC.exe, see [Lc.exe (License Compiler)](https://msdn.microsoft.com/library/2de803b8-495e-4982-b209-19a72aba0460).  
  
## Parameters  
 The following table describes the parameters for the `LC` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`LicenseTarget`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the executable for which the .licenses files are generated.|  
|`NoLogo`|Optional `Boolean` parameter.<br /><br /> Suppresses the Microsoft startup banner display.|  
|`OutputDirectory`|Optional `String` parameter.<br /><br /> Specifies the directory in which to place the output .licenses files.|  
|`OutputLicense`|Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the name of the .licenses file. If you do not specify a name, the name of the .licx file is used and the .licenses file is placed in the directory that contains the .licx file.|  
|`ReferencedAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the referenced components to load when generating the .license file.|  
|`SdkToolsPath`|Optional `String` parameter.<br /><br /> Specifies the path to the SDK tools, such as resgen.exe.|  
|`Sources`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the items that contain licensed components to include in the .licenses file. For more information, see the documentation for the `/complist` switch in [Lc.exe (License Compiler)](https://msdn.microsoft.com/library/2de803b8-495e-4982-b209-19a72aba0460).|  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../msbuild/tooltaskextension-base-class.md).  
  
## Example  
 The following example uses the `LC` task to compile licenses.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
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
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
