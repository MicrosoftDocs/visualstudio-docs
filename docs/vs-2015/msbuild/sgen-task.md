---
title: "SGen Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#SGen"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "SGen task [MSBuild]"
  - "MSBuild, SGen task"
ms.assetid: 22c5ade4-4159-4667-b891-0c1aa06f4df5
caps.latest.revision: 14
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# SGen Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Creates an XML serialization assembly for types in the specified assembly. This task wraps the XML Serializer Generator Tool (Sgen.exe). For more information, see [XML Serializer Generator Tool (Sgen.exe)](https://msdn.microsoft.com/library/cc1d1f1c-fb26-4be9-885a-3fe84c81cec6).  
  
## Parameters  
 The following table describes the parameters of the `SGen` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`BuildAssemblyName`|Required `String` parameter.<br /><br /> The assembly to generate serialization code for.|  
|`BuildAssemblyPath`|Required `String` parameter.<br /><br /> The path to the assembly to generate serialization code for.|  
|`DelaySign`|Optional `Boolean` parameter.<br /><br /> If `true`, specifies that you want a fully signed assembly. If `false`, specifies that you only want to place the public key in the assembly.<br /><br /> This parameter has no effect unless used with either the `KeyFile` or `KeyContainer` parameter.|  
|`KeyContainer`|Optional `String` parameter.<br /><br /> Specifies a container that holds a key pair. This will sign the assembly by inserting a public key into the assembly manifest. The task will then sign the final assembly with the private key.|  
|`KeyFile`|Optional `String` parameter.<br /><br /> Specifies a key pair or a public key to use to sign an assembly. The compiler inserts the public key in the assembly manifest and then signs the final assembly with the private key.|  
|`Platform`|Optional `String` parameter.<br /><br /> Gets or Sets the Compiler Platform used to generate the output assembly. This parameter can have a value of `x86`, `x64`, or `anycpu`. Default is `anycpu`.|  
|`References`|Optional `String[]` parameter.<br /><br /> Specifies the assemblies that are referenced by the types requiring XML serialization.|  
|`SdkToolsPath`|Optional `String` parameter.<br /><br /> Specifies the path to the SDK tools, such as resgen.exe.|  
|`SerializationAssembly`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the generated serialization assembly.|  
|`SerializationAssemblyName`|Optional `String` parameter.<br /><br /> Specifies the name of the generated serialization assembly.|  
|`ShouldGenerateSerializer`|Required `Boolean` parameter.<br /><br /> If `true`, the SGen task should generate a serialization assembly.|  
|`Timeout`|Optional `Int32` parameter.<br /><br /> Specifies the amount of time, in milliseconds, after which the task executable is terminated. The default value is `Int.MaxValue`, indicating that there is no time out period.|  
|`ToolPath`|Optional `String` parameter.<br /><br /> Specifies the location from where the task will load the underlying executable file (sgen.exe). If this parameter is not specified, the task uses the SDK installation path corresponding to the version of the framework that is running [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)].|  
|`Types`|Optional `String[]` parameter.<br /><br /> Gets or sets a list of specific Types to generate serialization code for. SGen will generate serialization code only for those types.|  
|`UseProxyTypes`|Required `Boolean` parameter.<br /><br /> If `true`, the SGen task generates serialization code only for the XML Web service proxy types.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../msbuild/tooltaskextension-base-class.md).  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [Tasks](../msbuild/msbuild-tasks.md)   
 [MSBuild Concepts](../msbuild/msbuild-concepts.md)
