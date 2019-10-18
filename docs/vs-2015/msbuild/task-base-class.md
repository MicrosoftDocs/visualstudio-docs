---
title: "Task Base Class | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
ms.assetid: 6c3f6238-b9f0-4325-b8b0-de61090bd0a2
caps.latest.revision: 9
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Task Base Class
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Many tasks ultimately inherit from the <xref:Microsoft.Build.Utilities.Task> class. This class adds several parameters to the tasks that derive from them. These parameters are listed in this document.  
  
## Parameters  
 The following table describes the parameters of this base class.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<xref:Microsoft.Build.Utilities.Task.BuildEngine%2A>|Optional <xref:Microsoft.Build.Framework.IBuildEngine> parameter.<br /><br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.|  
|<xref:Microsoft.Build.Utilities.Task.BuildEngine2%2A>|Optional <xref:Microsoft.Build.Framework.IBuildEngine2> parameter.<br /><br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.<br /><br /> This is a convenience property so that task authors inheriting from this class do not have to cast the value from `IBuildEngine` to `IBuildEngine2`.|  
|<xref:Microsoft.Build.Utilities.Task.BuildEngine3%2A>|Optional <xref:Microsoft.Build.Framework.IBuildEngine3> parameter.<br /><br /> Specifies the build engine interface provided by the host.|  
|<xref:Microsoft.Build.Utilities.Task.HostObject%2A>|Optional <xref:Microsoft.Build.Framework.ITaskHost> parameter.<br /><br /> Specifies the host object instance (can be null). The build engine sets this property if the host IDE has associated a host object with this particular task.|  
|<xref:Microsoft.Build.Utilities.Task.Log%2A>|Optional <xref:Microsoft.Build.Utilities.TaskLoggingHelper> read-only parameter.<br /><br /> The logging helper object..|  
  
## See also  
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [Tasks](../msbuild/msbuild-tasks.md)
