---
title: "TrackedVCToolTask Class | Microsoft Docs"
ms.date: "03/10/2019"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
author: mikeblome
ms.author: mblome
ms.workload:
  - "multiple"
---
# TrackedVCToolTask base class

Many tasks ultimately inherit from the <xref:Microsoft.Build.Utilities.Task> class and [ToolTask](/dotnet/api/microsoft.build.utilities.tooltask) class. This class adds several parameters to the tasks that derive from [VCToolTask](../msbuild/vctooltask-base-class.md). These parameters are listed in this document.

## Parameters

The following table describes the parameters of the **TrackedVCToolTask** base class.

|Parameter|Description|
|---------------|-----------------|
|**DeleteOutputOnExecute**|Optional **bool** parameter.|
|**EnableExecuteTool**|Optional **bool** parameter.|
|**ExcludedInputPaths**|Optional **ITaskItem[]** parameter.|
|**MinimalRebuildFromTracking**|Optional **bool** parameter.|
|**PathOverride**|Optional **string** parameter.|
|**PostBuildTrackingCleanup**|Optional **bool** parameter.|
|**RootSource**|Optional **string** parameter.|
|**SkippedExecution**|Optional **bool** output parameter.|
|**SourcesCompiled**|Optional **ITaskItem[]** output parameter.|
|**TLogCommandFile**|Optional **ITaskItem** parameter.|
|**TLogReadFiles**|Optional **ITaskItem[]** parameter.|
|**TLogWriteFiles**|Optional **ITaskItem[]** parameter.|
|**ToolArchitecture**|Optional **string** parameter.|
|**TrackCommandLines**|Optional **bool** parameter.|
|**TrackFileAccess**|Optional **bool** parameter.|
|**TrackedInputFilesToIgnore**|Optional **ITaskItem[]** parameter.|
|**TrackedOutputFilesToIgnore**|Optional **ITaskItem[]** parameter.|
|**TrackerFrameworkPath**|Optional **string** parameter.|
|**TrackerSdkPath**|Optional **string** parameter.|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)<br/>
[Tasks](../msbuild/msbuild-tasks.md)