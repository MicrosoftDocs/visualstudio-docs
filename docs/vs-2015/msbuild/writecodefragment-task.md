---
title: "WriteCodeFragment Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, WriteCodeFragment task"
  - "WriteCodeFragment task [MSBuild]"
ms.assetid: 1d2514b4-5bef-43bb-bebe-496da8ef063c
caps.latest.revision: 9
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# WriteCodeFragment Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Generates a temporary code file from the specified generated code fragment. Does not delete the file.  
  
## Parameters  
 The following table describes the parameters of the `WriteCodeFragment` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AssemblyAttributes`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Description of the attributes to write. The item `Include` value is the full type name of the attribute, for example, "System.AssemblyVersionAttribute".<br /><br /> Each metadata is the name-value pair of a parameter, which must be of type `String`. Some attributes only allow positional constructor arguments. However, you can use such arguments in any attribute. To set positional constructor attributes, use metadata names that resemble "_Parameter1", "_Parameter2", and so on.<br /><br /> A parameter index cannot be skipped.|  
|`Language`|Required `String` parameter.<br /><br /> Specifies the language of the code to generate.<br /><br /> `Language` can be any language for which a CodeDom provider is available, for example, "C#" or "VisualBasic". The emitted file will have the default file name extension for that language.|  
|`OutputDirectory`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the destination folder for the generated code, typically the intermediate folder.|  
|`OutputFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the path of the file that was generated. If this parameter is set by using a file name, the destination folder is prepended to the file name. If it is set by using a root, the destination folder is ignored.<br /><br /> If this parameter is not set, the output file name is the destination folder, an arbitrary file name, and the default file name extension for the specified language.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
