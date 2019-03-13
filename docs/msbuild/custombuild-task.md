---
title: "CustomBuild Task | Microsoft Docs"
ms.date: "03/10/2019"
ms.topic: "reference"
f1_keywords:
  - "vc.task.custombuild"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild (Visual C++), CustomBuild task"
  - "CustomBuild task (MSBuild (Visual C++))"
ms.assetid: b62a482e-8fb5-4999-b50b-6605a078e291
author: mikeblome
ms.author: Michael.Blome
ms.workload:
  - "multiple"
---
# CustomBuild task

Wraps the Visual C++ compiler tool, cmd.exe.

## Methods

The following tables describe the methods of the **CustomBuild** task.

### Protected

All methods as `protected`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**BuildExecutionGraph**|(**bool**)|
|**BuildExecutionPlan**|(**bool**)|
|**BuildExecutionPlan**|(**bool**)|(ITaskItem[] outOfDateSources)
|**GetInputs**|(**string[]**)|(ITaskItem item)
|**GetOutputs**|(**string[]**)|(ITaskItem item)
|**GetSourceCommandLine**|(**string**)|(ITaskItem item)

#### Protected Override

All methods as `protected override`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**AddTaskSpecificOutputs**|(**void**)<br/><br/>Use parameters **ITaskItem[]** *sources* and **CanonicalTrackedOutputFiles** *compactOutputs*.|
|**AssignOutOfDateSources**|(**ITaskItem\[]**)<br/><br/>Use parameter **ITaskItem[]** *sources*.|
|**CommandTLogName**|Default value is `custombuild.command.1.tlog`. (**string**)|
|**ExecuteTool**|*unsafe* (**int**)<br/><br/>Use parameters **string** *pathToTool*, **string** *responseFileCommands*, and **string** *commandLineCommands*.|
|**GenerateCommandLineCommands**|(**string**)<br/><br/>Use parameters **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog] and  **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default].|
|**GenerateFullPathToTool**|(**string**)|
|**GenerateResponseFileCommands**|(**string**)<br/><br/>Use parameters **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog] and **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default].|
|**GenerateSourcesOutOfDateDueToCommandLine**|(**List\<ITaskItem>**)|
|**LogToolCommand**|(**void**)<br/><br/>Use parameter **string** *message*.|
|**ReadTLogNames**|Default value is `new string[1]`. (**string[]**)|
|**ToolName**|Default value is `cmd.exe`. (**string**)|
|**TrackedInputFiles**|Default value is `Sources`. (**ITaskItem[]**)|
|**TrackerIntermediateDirectory**|Default value is `TrackerLogDirectory ?? string.Empty`. (**string**)|
|**UseMinimalRebuildOptimization**|Default value is `true`. (**bool**)|
|**WriteTLogNames**|Default value is `new string[1]`. (**string[]**)|

### Public

All methods as `public`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**BuildSuffix**|(**string**)|

#### Public Virtual

All methods as `public virtual`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**Sources**|*required* (**ITaskItem[]**)|
|**TrackerLogDirectory**|(**string**)|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)