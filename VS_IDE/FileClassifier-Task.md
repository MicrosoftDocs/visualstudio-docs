---
title: "FileClassifier Task"
ms.custom: na
ms.date: 10/07/2016
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
ms.assetid: 14e03310-fcc0-4bb2-a84d-cda12be66367
caps.latest.revision: 7
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
# FileClassifier Task
The <xref:Microsoft.Build.Tasks.Windows.FileClassifier?qualifyHint=False> task classifies a set of source resources as those that will be embedded into an assembly. If a resource is not localizable, it is embedded into the main application assembly; otherwise, it is embedded into a satellite assembly.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`CLREmbeddedResource`|Unused.|  
|`CLRResourceFiles`|Unused.|  
|`CLRSatelliteEmbeddedResource`|Unused.|  
|`Culture`|Optional **String** parameter.<br /><br /> Specifies the culture for the build. This value can be **null** if the build is non-localizable. If **null**, the default value is the lowercase value that **CultureInfo.InvariantCulture** returns.|  
|`MainEmbeddedFiles`|Optional **ITaskItem[]** output parameter.<br /><br /> Specifies the non-localizable resources that are embedded into the main assembly.|  
|`OutputType`|Required **String** parameter.<br /><br /> Specifies the type of file to embed the specified source files into. The valid values are **exe**, **winexe**, or **library**.|  
|`SatelliteEmbeddedFiles`|Optional **ITaskItem[]** output parameter.<br /><br /> Specifies the localizable files that are embedded into the satellite assembly for the culture specified by the **Culture** parameter.|  
|`SourceFiles`|Required **ITaskItem[]** parameter.<br /><br /> Specifies the list of files to classify.|  
  
## Remarks  
 If the **Culture** parameter is not set, all resources that are specified by using the **SourceFiles** parameter are non-localizable; otherwise, they are localizable, unless they are associated with a **Localizable** attribute that is set to **false**.  
  
## Example  
 The following example classifies a single source file as a resource and then embeds it in a satellite assembly for the French-Canadian (fr-CA) culture.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  <UsingTask  
    TaskName="Microsoft.Build.Tasks.Windows.FileClassifier"   
    AssemblyFile="C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationBuildTasks.dll" />  
  <ItemGroup>  
    <Resource Include="Resource1.bmp" />  
  </ItemGroup>  
  <Target Name="FileClassifierTask">  
    <FileClassifier  
      SourceFiles="Resource1.bmp"  
      Culture="fr-CA"  
      OutputType="exe" />  
  </Target>  
</Project>  
```  
  
## See Also  
 [WPF MSBuild Reference](../VS_IDE/WPF-MSBuild-Reference.md)   
 [Task Reference](../VS_IDE/WPF-MSBuild-Task-Reference.md)   
 [MSBuild Reference](../VS_IDE/MSBuild-Reference.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)   
 [Building a WPF Application (WPF)](../Topic/Building%20a%20WPF%20Application%20\(WPF\).md)