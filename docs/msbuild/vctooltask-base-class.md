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
ms.author: Michael.Blome
ms.workload:
  - "multiple"
---
# VCToolTask base class

Many tasks ultimately inherit from the <xref:Microsoft.Build.Utilities.Task> class and [ToolTask](/dotnet/api/microsoft.build.utilities.tooltask) class. This class adds several methods to the tasks that derive from them. These methods are listed in this document.

## Parameters

The following tables describe the parameters of the **VCToolTask** base class.

|Parameter|Description|
|---------------|-----------------|
|**ActiveToolSwitchesValues**|(**Dictionary\<string, ToolSwitch>** parameter.|
|**AdditionalOptions**|(**string** parameter.|
|**EffectiveWorkingDirectory**|(**string** parameter.|
|**EnableErrorListRegex**|Default is `true`. (**bool** parameter.|
|**ErrorListRegex**|(**ITaskItem[]** parameter.|
|**ErrorListListExclusion**|(**ITaskItem[]** parameter.|
|**GenerateCommandLine**|(**string**)<br/><br/>Use parameters **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog] and **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default].|
|**GenerateCommandLineExceptSwitches**|(**string**)<br/><br/>Use parameters **string[]** *switchesToRemove*, **CommandLineFormat** *format* [default = CommandLineFormat.ForBuildLog], and **EscapeFormat** *escapeFormat* [default = EscapeFormat.Default].|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)<br/>
[Tasks](../msbuild/msbuild-tasks.md)