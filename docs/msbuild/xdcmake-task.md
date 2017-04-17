---
title: "XDCMake Task | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vc.task.xdcmake"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords: 
  - "XDCMake task (MSBuild (Visual C++))"
  - "MSBuild (Visual C++), XDCMake task"
ms.assetid: a7de9c64-903a-4a02-85f3-f37672270f25
caps.latest.revision: 7
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# XDCMake Task
Wraps the XML Documentation tool (xdcmake.exe), which merges XML document comment (.xdc) files into an .xml file.  
  
 An .xdc file is created when you provide documentation comments in your Visual C++ source code and compile by using the [/doc](/cpp/build/reference/doc-process-documentation-comments-c-cpp) compiler option. For more information, see [XDCMake Reference](/cpp/ide/xdcmake-reference), [XML Document Generator Tool Property Pages](/cpp/ide/xml-document-generator-tool-property-pages), and command-line help option (**/?**) for xdcmake.exe.  
  
## Remarks  
 By default, the xdcmake.exe tool supports a few command-line options. Additional options are supported when you specify the **/old** command-line option.  
  
## Parameters  
 The following table describes the parameters of the **XDCMake** task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|**AdditionalDocumentFile**|Optional **String[]** parameter.<br /><br /> Specifies one or more additional .xdc files to merge.<br /><br /> For more information, see the **Additional Document Files** description in [XML Document Generator Tool Property Pages](/cpp/ide/xml-document-generator-tool-property-pages). Also see the **/old** and **/Fs** command-line options for xdcmake.exe.|  
|**AdditionalOptions**|Optional **String** parameter.<br /><br /> A list of options as specified on the command line. For example, "*/option1 /option2 /option#*". Use this parameter to specify options that are not represented by any other **XDCMake** task parameter.<br /><br /> For more information, see [XDCMake Reference](/cpp/ide/xdcmake-reference), [XML Document Generator Tool Property Pages](/cpp/ide/xml-document-generator-tool-property-pages), and command-line help (**/?**) for xdcmake.exe.|  
|**DocumentLibraryDependencies**|Optional **Boolean** parameter.<br /><br /> If `true` and the current project has a dependency on a static library (.lib) project in the solution, the .xdc files for that library project are included in the .xml file output for the current project.<br /><br /> For more information, see the **Document Library Dependencies** description in [XML Document Generator Tool Property Pages](/cpp/ide/xml-document-generator-tool-property-pages).|  
|**OutputFile**|Optional **String** parameter.<br /><br /> Overrides the default output file name. The default name is derived from the name of the first .xdc file that is processed.<br /><br /> For more information, see the **/out:**`filename` option in [XDCMake Reference](/cpp/ide/xdcmake-reference). Also see the **/old** and **/Fo** command-line options for xdcmake.exe.|  
|**ProjectName**|Optional **String** parameter.<br /><br /> The name of the current project.|  
|**SlashOld**|Optional **Boolean** parameter.<br /><br /> If `true`, enables additional xdcmake.exe options.<br /><br /> For more information, see the **/old** command-line option for xdcmake.exe.|  
|**Sources**|Required `ITaskItem[]` parameter.<br /><br /> Defines an array of MSBuild source file items that can be consumed and emitted by tasks.|  
|**SuppressStartupBanner**|Optional **Boolean** parameter.<br /><br /> If `true`, prevents the display of the copyright and version number message when the task starts.<br /><br /> For more information, see the **/nologo** option in [XDCMake Reference](/cpp/ide/xdcmake-reference).|  
|**TrackerLogDirectory**|Optional **String** parameter.<br /><br /> Specifies the directory for the tracker log.|  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)