---
title: "VCToolTask Class | Microsoft Docs"
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
# VCToolTask base class

Many tasks ultimately inherit from the <xref:Microsoft.Build.Utilities.Task> class and [ToolTask](/dotnet/api/microsoft.build.utilities.tooltask) class. This class adds several parameters to the tasks that derive from them. These parameters are listed in this document.

## Parameters

The following table describes the parameters of the **VCToolTask** base class.

|Parameter|Description|
|---------------|-----------------|
|**ActiveToolSwitchesValues**|Optional **Dictionary\<string, ToolSwitch>** parameter.|
|**AdditionalOptions**|Optional **string** parameter.|
|**EffectiveWorkingDirectory**|Optional **string** parameter.|
|**EnableErrorListRegex**|Optional **bool** parameter.<br/><br/>Default is `true`.|
|**ErrorListRegex**|Optional **ITaskItem[]** parameter.|
|**ErrorListListExclusion**|Optional **ITaskItem[]** parameter.|
|**GenerateCommandLine**|Optional **string** parameter.<br/><br/>Uses values **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog] and **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default].|
|**GenerateCommandLineExceptSwitches**|Optional **string** parameter.<br/><br/>Uses values **string[]** *switchesToRemove*, **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog], and **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default].|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)<br/>
[Tasks](../msbuild/msbuild-tasks.md)