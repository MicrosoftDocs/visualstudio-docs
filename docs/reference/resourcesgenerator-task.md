---
title: "ResourcesGenerator Task"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "embedding resources into a .resources file [WPF MSBuild]"
  - "ResourcesGenerator task [WPF MSBuild]"
  - "ResourcesGenerator task [WPF MSBuild], parameters"
ms.assetid: e782bbac-9ee6-472b-8171-3ee008c77b4e
caps.latest.revision: 6
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
# ResourcesGenerator Task
The \<xref:Microsoft.Build.Tasks.Windows.ResourcesGenerator> task embeds one or more resources (.jpg, .ico, .bmp, [!INCLUDE[TLA2#tla_xaml](../reference/includes/tla2sharptla_xaml_md.md)] in binary format, and other extension types) into a .resources file.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`OutputPath`|Required **String** parameter.<br /><br /> Specifies the path of the output directory. If the path is not an absolute path, it is treated as a path that is relative to the root project directory.|  
|`OutputResourcesFile`|Required **ITaskItem[]** output parameter.<br /><br /> Specifies the path and name of the generated .resources file. If the path is not an absolute path, the .resources file is generated relative to the root project directory.|  
|`ResourcesFiles`|Required **ITaskItem[]** parameter.<br /><br /> Specifies one or more resources to embed in the generated .resources file.|  
  
## Example  
 The following example generates a .resources file with a single .bmp resource. The .bmp resource is generated to a directory that is relative to the project root directory.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  <UsingTask   
    TaskName="Microsoft.Build.Tasks.Windows.ResourcesGenerator"   
    AssemblyFile="C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationBuildTasks.dll" />  
  <Target Name="ResourcesGeneratorTask">  
    <ResourcesGenerator  
      ResourceFiles="Resource1.bmp"  
      OutputPath="myresources"  
      OutputResourcesFile="myresources\my.resources" />  
  </Target>  
</Project>  
```  
  
## See Also  
 [WPF MSBuild Reference](../reference/wpf-msbuild-reference.md)   
 [Task Reference](../reference/wpf-msbuild-task-reference.md)   
 [MSBuild Reference](../reference/msbuild-reference.md)   
 [Task Reference](../reference/msbuild-task-reference.md)   
 [Building a WPF Application (WPF)](../Topic/Building%20a%20WPF%20Application%20\(WPF\).md)