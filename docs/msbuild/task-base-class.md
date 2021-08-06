---
title: Task Base Class | Microsoft Docs
description: Learn about the parameters that the Microsoft.Build.Utilities.Task base class adds to the tasks that inherit from it.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
ms.assetid: 6c3f6238-b9f0-4325-b8b0-de61090bd0a2
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Task base class

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

- [Task reference](../msbuild/msbuild-task-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)
