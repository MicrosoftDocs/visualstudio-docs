---
title: "TrackedVCToolTask Class | Microsoft Docs"
ms.date: "03/10/2019"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
ms.assetid: 6c3f6238-b9f0-4325-b8b0-de61090bd0a2
author: mikeblome
ms.author: Michael.Blome
ms.workload:
  - "multiple"
---
# TrackedVCToolTask base class

Many tasks ultimately inherit from the <xref:Microsoft.Build.Utilities.Task> class and [ToolTask](/dotnet/api/microsoft.build.utilities.tooltask) class. This class adds several methods to the tasks that derive from [VCToolTask](../msbuild/vctooltask-base-class.md). These methods are listed in this document.

## Methods

The following tables describe the methods of the **TrackedVCToolTask** base class.

### Public

All methods as `public`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**DeleteOutputOnExecute**|(**bool**)|
|**EnableExecuteTool**|(**bool**)|
|**ExcludedInputPaths**|(**ITaskItem[]**)|
|**MinimalRebuildFromTracking**|(**bool**)|
|**PathOverride**|(**string**)|
|**PostBuildTrackingCleanup**|(**bool**)|
|**RootSource**|(**string**)|
|**SkippedExecution**|*output* (**bool**)|
|**SourcesCompiled**|*output* (**ITaskItem[]**)|
|**TLogCommandFile**|(**ITaskItem**)|
|**TLogReadFiles**|(**ITaskItem[]**)|
|**TLogWriteFiles**|(**ITaskItem[]**)|
|**ToolArchitecture**|(**string**)|
|**TrackCommandLines**|(**bool**)|
|**TrackFileAccess**|(**bool**)|
|**TrackedInputFilesToIgnore**|(**ITaskItem[]**)|
|**TrackedOutputFilesToIgnore**|(**ITaskItem[]**)|
|**TrackerFrameworkPath**|(**string**)|
|**TrackerSdkPath**|(**string**)|

#### Public Override

All methods as `public override`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**Execute**|(**bool**)|

#### Public Virtual

All methods as `public virtual`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**ApplyPrecompareCommandFilter**|(**string**)|(string value)
|**AttributeFileTracking**|Default value is `false`. (**bool**)|
|**SourcesPropertyName**|Default value is `Sources`. (**string**)|

### Protected

All methods as `protected`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**MapSourcesToCommandLines**|(**IDictionary<string, string>**)|
|**MergeOutOfDateSourceLists**|(**ITaskItem[]**)<br/><br/>Uses parameters **ITaskItem[]** *sourcesOutOfDateThroughTracking* and **List<ITaskItem>** *sourcesWithChangedCommandLines*.|
|**pathToLog**|Default value is `string.Empty`. (**string**)|
|**RemoveSwitchFromCommandLine**|(**string**)<br/><br/>Uses parameters **string** *removalWord*, **string** *cmdString*, and **bool** *removeMultiple* [default = false].|
|**SourceDependencies**|(**CanonicalTrackedInputFiles**)|
|**SourceOutputs**|(**CanonicalTrackedOutputFiles**)|
|**TrackerExecuteTool**|(**int**)<br/><br/>Uses parameters **string** *pathToTool*, **string** *responseFileCommands*, and **string** *commandLineCommands*.|
|**WriteSourcesToCommandLinesTable**|(**void**)<br/><br/>Uses parameter **IDictionary<string, string>** *sourcesToCommandLines*.|

#### Protected Abstract

All methods as `protected abstract`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**TrackerIntermediateDirectory**|(**string**)|
|**TrackedInputFiles**|(**ITaskItem[]**)|

#### Protected Virtual

All methods as `protected virtual`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**AddTaskSpecificOutputs**|(**void**)<br/><br/>Uses parameters **ITaskItem[]** *sources* and **CanonicalTrackedOutputFiles** *compactOutputs*.|
|**AssignDefaultTLogPaths**|(**void**)|
|**AssignOutOfDateSources**|(**ITaskItem[]**)<br/><br/>Uses parameter **ITaskItem[]** *sources*.|
|**CommandTLogName**|(**string**)|
|**ComputeOutOfDateSources**|*internal* (**bool**)|
|**DeleteTLogNames**|(**string[]**)|
|**ExecutableType**|Default value is `? ToolType => null`. (**bool**)|
|**ForcedRebuildRequired**|(**bool**)|
|**GenerateSourcesOutOfDateDueToCommandLine**|(**List\<ITaskItem>**)|
|**MaintainCompositeRootingMarkers**|Default value is `false`. (**bool**)|
|**PostExecuteTool**|*unsafe* (**int**)<br/><br/>Uses parameter **int** *exitCode*.|
|**ReadTLogNames**|(**string[]**)|
|**RemoveTaskSpecificInputs**|(**void**)<br/><br/>Uses parameter **CanonicalTrackedInputFiles** *compactInputs*.|
|**RemoveTaskSpecificOutputs**|(**void**)<br/><br/>Uses parameter **CanonicalTrackedOutputFiles** *compactOutputs*.|
|**UseMinimalRebuildOptimization**|Default value is `false`. (**bool**)|
|**UseUnicodeOutput**|Default value is `false`. (**bool**)|
|**WriteTLogNames**|(**string[]**)|

#### Protected Override

All methods as `protected override`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**ExecuteTool**|(**int**)<br/><br/>Uses parameters **string** *pathToTool*, **string** *responseFileCommands, and **string** *commandLineCommands*.|
|**LogPathToTool**|(**void**)<br/><br/>Uses parameters **string** *toolName* and **string** *pathToTool*.|
|**SkipTaskExecution**|(**bool**)|

#### Protected Static

All methods as `protected static`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**DeleteEmptyFile**|(**int**)<br/><br/>Uses parameter **ITaskItem[]** *filesToDelete*.|
|**DeleteFiles**|(**int**)<br/><br/>Uses parameter **ITaskItem[]** *filesToDelete*.|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)<br/>
[Tasks](../msbuild/msbuild-tasks.md)