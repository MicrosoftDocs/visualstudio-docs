---
title: "FormatVersion Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
ms.assetid: 96e692f6-b581-46ca-8cc9-441a1861e371
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# FormatVersion task
Appends the revision number to the version number.

- Case #1: Input: Version=\<undefined>;  Revision=\<don't care>;   Output: OutputVersion="1.0.0.0"

- Case #2: Input: Version="1.0.0.*"  Revision="5"  Output: OutputVersion="1.0.0.5"

- Case #3: Input: Version="1.0.0.0"  Revision=\<don't care>;  Output: OutputVersion="1.0.0.0"

## Parameters
 The following table describes the parameters of the `FormatVersion` task.

|Parameter|Description|
|---------------|-----------------|
|`FormatType`|Optional `String` parameter.<br /><br /> Specifies the format type.<br /><br /> -   "Version" = version.<br />-   "Path" = replace "." with "_";|
|`OutputVersion`|Optional `String` output parameter.<br /><br /> Specifies the output version that includes the revision number.|
|`Revision`|Optional `Int32` parameter.<br /><br /> Specifies the revision to append to the version.|
|`Version`|Optional `String` parameter.<br /><br /> Specifies the version number string to format.|

## Remarks
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)