---
title: "XDCMake Task | Microsoft Docs"
description: Learn how MSBuild uses the XDCMake task to wrap the XML Documentation tool xdcmake.exe, which merges XML document comment files into an .xml file.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "vc.task.xdcmake"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords:
  - "XDCMake task (MSBuild (C++))"
  - "MSBuild (C++), XDCMake task"
ms.assetid: a7de9c64-903a-4a02-85f3-f37672270f25
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# XDCMake task

Wraps the XML Documentation tool (*xdcmake.exe*), which merges XML document comment (*.xdc*) files into an *.xml* file.

 An *.xdc* file is created when you provide documentation comments in your C++ source code and compile by using the [/doc](/cpp/build/reference/doc-process-documentation-comments-c-cpp) compiler option. For more information, see [XDCMake reference](/cpp/build/reference/xdcmake-reference), [XML Document Generator Tool property pages](/cpp/build/reference/xml-document-generator-tool-property-pages), and command-line help option (**/?**) for *xdcmake.exe*.

## Remarks

 By default, the *xdcmake.exe* tool supports a few command-line options. Additional options are supported when you specify the **/old** command-line option.

## Parameters

 The following table describes the parameters of the **XDCMake** task.

|Parameter|Description|
|---------------|-----------------|
|**AdditionalDocumentFile**|Optional **String[]** parameter.<br /><br /> Specifies one or more additional *.xdc* files to merge.<br /><br /> For more information, see the **Additional Document Files** description in [XML Document Generator Tool property pages](/cpp/build/reference/xml-document-generator-tool-property-pages). Also see the **/old** and **/Fs** command-line options for *xdcmake.exe*.|
|**AdditionalOptions**|Optional **String** parameter.<br /><br /> A list of options as specified on the command line. For example, /\<option1> /\<option2> /\<option#>. Use this parameter to specify options that are not represented by any other **XDCMake** task parameter.<br /><br /> For more information, see [XDCMake reference](/cpp/build/reference/xdcmake-reference), [XML Document Generator Tool property pages](/cpp/build/reference/xml-document-generator-tool-property-pages), and command-line help (**/?**) for *xdcmake.exe*.|
|**DocumentLibraryDependencies**|Optional **Boolean** parameter.<br /><br /> If `true` and the current project has a dependency on a static library (*.lib*) project in the solution, the *.xdc* files for that library project are included in the *.xml* file output for the current project.<br /><br /> For more information, see the **Document Library Dependencies** description in [XML Document Generator Tool property pages](/cpp/build/reference/xml-document-generator-tool-property-pages).|
|**OutputFile**|Optional **String** parameter.<br /><br /> Overrides the default output file name. The default name is derived from the name of the first *.xdc* file that is processed.<br /><br /> For more information, see the **/out:\<filename>** option in [XDCMake reference](/cpp/build/reference/xdcmake-reference). Also see the **/old** and **/Fo** command-line options for *xdcmake.exe*.|
|**ProjectName**|Optional **String** parameter.<br /><br /> The name of the current project.|
|**SlashOld**|Optional **Boolean** parameter.<br /><br /> If `true`, enables additional *xdcmake.exe* options.<br /><br /> For more information, see the **/old** command-line option for *xdcmake.exe*.|
|**Sources**|Required `ITaskItem[]` parameter.<br /><br /> Defines an array of MSBuild source file items that can be consumed and emitted by tasks.|
|**SuppressStartupBanner**|Optional **Boolean** parameter.<br /><br /> If `true`, prevents the display of the copyright and version number message when the task starts.<br /><br /> For more information, see the **/nologo** option in [XDCMake reference](/cpp/build/reference/xdcmake-reference).|
|**TrackerLogDirectory**|Optional **String** parameter.<br /><br /> Specifies the directory for the tracker log.|

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)