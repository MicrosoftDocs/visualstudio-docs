---
title: "TaskExtension Base Class"
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
ms.assetid: 08bb8059-b7e2-4565-89ba-d9034d4f0e16
caps.latest.revision: 6
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
# TaskExtension Base Class
Many tasks inherit from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. This inheritance chain adds several parameters to the tasks that derive from them. These parameters are listed in this document.  
  
## Parameters  
 The following table describes the parameters of the base classes.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<xref:Microsoft.Build.Utilities.Task.BuildEngine?qualifyHint=False>|Optional <xref:Microsoft.Build.Framework.IBuildEngine?qualifyHint=False> parameter.<br /><br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.|  
|<xref:Microsoft.Build.Utilities.Task.BuildEngine2?qualifyHint=False>|Optional <xref:Microsoft.Build.Framework.IBuildEngine2?qualifyHint=False> parameter.<br /><br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.<br /><br /> This is a convenience property so that task authors inheriting from this class do not have to cast the value from `IBuildEngine` to `IBuildEngine2`.|  
|<xref:Microsoft.Build.Utilities.Task.BuildEngine3?qualifyHint=False>|Optional <xref:Microsoft.Build.Framework.IBuildEngine3?qualifyHint=False> parameter.<br /><br /> Specifies the build engine interface provided by the host.|  
|<xref:Microsoft.Build.Utilities.Task.HostObject?qualifyHint=False>|Optional <xref:Microsoft.Build.Framework.ITaskHost?qualifyHint=False> parameter.<br /><br /> Specifies the host object instance (can be null). The build engine sets this property if the host IDE has associated a host object with this particular task.|  
|<xref:Microsoft.Build.Tasks.TaskExtension.Log?qualifyHint=False>|Optional <xref:Microsoft.Build.Utilities.TaskLoggingHelper?qualifyHint=False> read-only parameter.<br /><br /> Gets a `TaskLoggingHelperExtension` object that contains task logging methods.|  
  
## See Also  
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)   
 [Tasks](../VS_IDE/MSBuild-Tasks.md)