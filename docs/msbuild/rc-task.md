---
title: "RC Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "VC.Project.VCResourceCompilerTool.UndefineProcessorDefinitions"
  - "vc.task.rc"
  - "VC.Project.VCResourceCompilerTool.SuppressStartupBanner"
  - "VC.Project.VCResourceCompilerTool.NullTerminateStrings"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords:
  - "RC task (MSBuild (C++))"
  - "MSBuild (C++), RC task"
ms.assetid: 2fd26c75-a056-4dda-9f7e-2f90d3748d88
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# RC task
Wraps the Microsoft Windows Resource Compiler tool, *rc.exe*. The **RC** task compiles resources, such as cursors, icons, bitmaps, dialog boxes, and fonts, into a resource (*.res*) file. For more information, see [Resource Compiler](/windows/desktop/menurc/resource-compiler).

## Parameters
 The following table describes the parameters of the RC task. Most task parameters, and a few sets of parameters, correspond to a command-line option.

|Parameter|Description|
|---------------|-----------------|
|**AdditionalIncludeDirectories**|Optional **String[]** parameter.<br /><br /> Adds a directory to the list of directories that are searched for include files.<br /><br /> For more information, see the **/I** option in [Using RC (the RC command line)](/windows/win32/menurc/using-rc-the-rc-command-line-).|
|**AdditionalOptions**|Optional **String** parameter.<br /><br /> A list of command-line options; for example, /\<option1> /\<option2> /\<option#>. Use this parameter to specify command-line options that are not represented by any other **RC** task parameter.<br /><br /> For more information, see the options in [Using RC (the RC command line)](/windows/win32/menurc/using-rc-the-rc-command-line-).|
|**Culture**|Optional **String** parameter.<br /><br /> Specifies a locale ID that represents the culture used in the resources.<br /><br /> For more information, see the **/l** option in [Using RC (the RC command line)](/windows/win32/menurc/using-rc-the-rc-command-line-).|
|**IgnoreStandardIncludePath**|Optional **Boolean** parameter.<br /><br /> If `true`, prevents the resource compiler from checking the INCLUDE environment variable when it searches for header files or resource files.<br /><br /> For more information, see the **/x** option in [Using RC (the RC command line)](/windows/win32/menurc/using-rc-the-rc-command-line-).|
|**NullTerminateStrings**|Optional **Boolean** parameter.<br /><br /> If `true`, null-terminates all strings in the string table.<br /><br /> For more information, see the **/n** option in [Using RC (the RC command line)](/windows/win32/menurc/using-rc-the-rc-command-line-).|
|**PreprocessorDefinitions**|Optional **String[]** parameter.<br /><br /> Define one or more preprocessor symbols for the resource compiler. Specify a list of macro symbols.<br /><br /> For more information, see the **/d** option in [Using RC (the RC command line)](/windows/win32/menurc/using-rc-the-rc-command-line-). Also see **UndefinePreprocessorDefinitions** in this table.|
|**ResourceOutputFileName**|Optional **String** parameter.<br /><br /> Specifies the name of the resource file. Specify a resource file name.<br /><br /> For more information, see the **/fo** option in [Using RC (the RC command line)](/windows/win32/menurc/using-rc-the-rc-command-line-).|
|**ShowProgress**|Optional **Boolean** parameter.<br /><br /> If `true`, displays messages that report on the progress of the compiler.<br /><br /> For more information, see the **/v** option in [Using RC (the RC command line)](/windows/win32/menurc/using-rc-the-rc-command-line-).|
|**Source**|Required `ITaskItem[]` parameter.<br /><br /> Defines an array of MSBuild source file items that can be consumed and emitted by tasks.|
|**SuppressStartupBanner**|Optional **Boolean** parameter.<br /><br /> If `true`, prevents the display of the copyright and version number message when the task starts.<br /><br /> For more information, type the **/?** command-line option and then see the **/nologo** option.|
|**TrackerLogDirectory**|Optional **String** parameter.<br /><br /> Specifies the tracker log directory.|
|**UndefinePreprocessorDefinitions**|Undefine a preprocessor symbol.<br /><br /> For more information, see the **/u** option in [Using RC (the RC command line)](/windows/win32/menurc/using-rc-the-rc-command-line-). Also see **PreprocessorDefinitions** in this table.|

## See also
- [Task reference](../msbuild/msbuild-task-reference.md)