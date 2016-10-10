---
title: "LC Task"
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
ms.assetid: d5a53472-6f2a-42b8-a6db-593ca99c9790
caps.latest.revision: 15
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
# LC Task
Wraps LC.exe, which generates a .license file from a .licx file. For more information on LC.exe, see [Lc.exe (License Compiler)](../Topic/Lc.exe%20\(License%20Compiler\).md).  
  
## Parameters  
 The following table describes the paramters for the `LC` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`LicenseTarget`|Required <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> parameter.<br /><br /> Specifies the executable for which the .licenses files are generated.|  
|`NoLogo`|Optional `Boolean` parameter.<br /><br /> Suppresses the Microsoft startup banner display.|  
|`OutputDirectory`|Optional `String` parameter.<br /><br /> Specifies the directory in which to place the output .licenses files.|  
|`OutputLicense`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> output parameter.<br /><br /> Specifies the name of the .licenses file. If you do not specify a name, the name of the .licx file is used and the .licenses file is placed in the directory that contains the .licx file.|  
|`ReferencedAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the referenced components to load when generating the .license file.|  
|`SdkToolsPath`|Optional `String` parameter.<br /><br /> Specifies the path to the SDK tools, such as resgen.exe.|  
|`Sources`|Required <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the items that contain licensed components to include in the .licenses file. For more information, see the documentation for the `/complist` switch in [Lc.exe (License Compiler)](../Topic/Lc.exe%20\(License%20Compiler\).md).|  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.ToolTaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../VS_IDE/ToolTaskExtension-Base-Class.md).  
  
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
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)