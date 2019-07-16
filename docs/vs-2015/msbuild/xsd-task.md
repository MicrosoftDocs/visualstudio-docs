---
title: "XSD Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "vc.task.xsd"
  - "VC.Project.VCXMLDataGeneratorTool.Namespace"
  - "VC.Project.VCXMLDataGeneratorTool.GenerateFromSchema"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "XSD task (MSBuild (Visual C++))"
  - "MSBuild (Visual C++), XSD task"
ms.assetid: 15c99f5c-7124-4bbc-bc03-70c7bcce8893
caps.latest.revision: 16
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# XSD Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Wraps the XML Schema Definition tool (xsd.exe), which generates schema or class files from a source.  
  
## Parameters  
 The following table describes the parameters of the **XSD** task.  
  
- **AdditionalOptions**  
  
     Optional **String** parameter.  
  
     A list of options as specified on the command line. For example, "*/option1 /option2 /option#*". Use this parameter to specify options that are not represented by any other **XSD** task parameter.  
  
- **GenerateFromSchema**  
  
  Optional **String** parameter.  

  Specifies the types that are generated from the specified schema.  

  Specify one of the following values, each of which corresponds to an XSD option.  

  - **classes** - **/classes**  

  - **dataset** - **/dataset**  
  
- **Language**  
  
     Optional **String** parameter.  
  
     Specifies the programming language to use for the generated code.  
  
     Choose from **CS** (C#, which is the default), **VB** (Visual Basic), or **JS** (JScript). You can also specify a fully qualified name for a class that implements `System.CodeDom.Compiler.CodeDomProvider Class`.  
  
- **Namespace**  
  
     Optional **String** parameter.  
  
     Specifies the runtime namespace for the generated types.  
  
- **Sources**  
  
     Required `ITaskItem[]` parameter.  
  
     Defines an array of MSBuild source file items that can be consumed and emitted by tasks.  
  
- **SuppressStartupBanner**  
  
     Optional **Boolean** parameter.  
  
     If `true`, prevents the display of the copyright and version number message when the task starts.  
  
- **TrackerLogDirectory**  
  
     Optional **String** parameter.  
  
     Specifies the directory for the tracker log.  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)
