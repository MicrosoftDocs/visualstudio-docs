---
title: "MSBuild Tasks Specific to Visual C++"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, tasks specific to Visual C++"
ms.assetid: 05410f0c-7356-4692-bc00-20664421c9ff
caps.latest.revision: 7
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
# MSBuild Tasks Specific to Visual C++
Tasks provide the code that runs during the build process. When Visual C++ is installed, the following tasks are available, in addition to those that are installed with [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)]. For more information, see [MSBuild (Visual C++) Overview](../Topic/MSBuild%20\(Visual%20C++\)%20Overview.md).  
  
 In addition to the parameters for each task, every task also has the following parameters.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Condition`|Optional `String` parameter.<br /><br /> A `Boolean` expression that the [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] engine uses to determine whether this task will be executed. For information about the conditions that are supported by [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)], see [Conditions](../reference/msbuild-conditions.md).|  
|`ContinueOnError`|Optional parameter. Can contain one of the following values:<br /><br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../reference/target-element--msbuild-.md) element and the build continue to execute, and all errors from the task are treated as warnings<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the`Target` element and the build aren't executed, and the entire `Target` element and the build are considered to have failed.<br /><br /> Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.<br /><br /> For more information, see [How to: Ignore Errors in Tasks](../reference/how-to--ignore-errors-in-tasks.md).|  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[BscMake Task](../reference/bscmake-task.md)|Wraps the Microsoft Browse Information Maintenance Utility tool (bscmake.exe).|  
|[CL Task](../reference/cl-task.md)|Wraps the Visual C++ compiler tool (cl.exe).|  
|[CPPClean Task](../reference/cppclean-task.md)|Deletes the temporary files that MSBuild creates when a Visual C++ project is built.|  
|[LIB Task](../reference/lib-task.md)|Wraps the Microsoft 32-Bit Library Manager tool (lib.exe).|  
|[Link Task](../reference/link-task.md)|Wraps the Visual C++ linker tool (link.exe).|  
|[MIDL Task](../reference/midl-task.md)|Wraps the Microsoft Interface Definition Language (MIDL) compiler tool (midl.exe).|  
|[MT Task](../reference/mt-task.md)|Wraps the Microsoft Manifest Tool (mt.exe).|  
|[RC Task](../reference/rc-task.md)|Wraps the Microsoft Windows Resource Compiler tool (rc.exe).|  
|[SetEnv Task](../reference/setenv-task.md)|Sets or deletes the value of a specified environment variable.|  
|[VCMessage Task](../reference/vcmessage-task.md)|Logs warning messages and error messages during a build.|  
|[XDCMake Task](../reference/xdcmake-task.md)|Wraps the XML Documentation tool (xdcmake.exe), which merges XML document comment (.xdc) files into an .xml file.|  
|[XSD Task](../reference/xsd-task.md)|Wraps the XML Schema Definition tool (xsd.exe), which generates schema or class files from a source.|  
|[MSBuild Reference](../reference/msbuild-reference.md)|Describes the elements of the MSBuild system.|  
|[Tasks](../reference/msbuild-tasks.md)|Describes tasks, which are units of code that can be combined to produce a build.|  
|[Task Writing](../reference/task-writing.md)|Describes how to create a task.|