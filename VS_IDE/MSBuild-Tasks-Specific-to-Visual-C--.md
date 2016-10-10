---
title: "MSBuild Tasks Specific to Visual C++"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 05410f0c-7356-4692-bc00-20664421c9ff
caps.latest.revision: 7
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# MSBuild Tasks Specific to Visual C++
Tasks provide the code that runs during the build process. When Visual C++ is installed, the following tasks are available, in addition to those that are installed with MSBuild. For more information, see [MSBuild (Visual C++) Overview](../Topic/MSBuild%20\(Visual%20C++\)%20Overview.md).  
  
 In addition to the parameters for each task, every task also has the following parameters.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Condition`|Optional `String` parameter.<br /><br /> A `Boolean` expression that the MSBuild engine uses to determine whether this task will be executed. For information about the conditions that are supported by MSBuild, see [Conditions](../VS_IDE/MSBuild-Conditions.md).|  
|`ContinueOnError`|Optional parameter. Can contain one of the following values:<br /><br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../VS_IDE/Target-Element--MSBuild-.md) element and the build continue to execute, and all errors from the task are treated as warnings<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the`Target` element and the build aren't executed, and the entire `Target` element and the build are considered to have failed.<br /><br /> Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.<br /><br /> For more information, see [How to: Ignore Errors in Tasks](../VS_IDE/How-to--Ignore-Errors-in-Tasks.md).|  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[BscMake Task](../VS_IDE/BscMake-Task.md)|Wraps the Microsoft Browse Information Maintenance Utility tool (bscmake.exe).|  
|[CL Task](../VS_IDE/CL-Task.md)|Wraps the Visual C++ compiler tool (cl.exe).|  
|[CPPClean Task](../VS_IDE/CPPClean-Task.md)|Deletes the temporary files that MSBuild creates when a Visual C++ project is built.|  
|[LIB Task](../VS_IDE/LIB-Task.md)|Wraps the Microsoft 32-Bit Library Manager tool (lib.exe).|  
|[Link Task](../VS_IDE/Link-Task.md)|Wraps the Visual C++ linker tool (link.exe).|  
|[MIDL Task](../VS_IDE/MIDL-Task.md)|Wraps the Microsoft Interface Definition Language (MIDL) compiler tool (midl.exe).|  
|[MT Task](../VS_IDE/MT-Task.md)|Wraps the Microsoft Manifest Tool (mt.exe).|  
|[RC Task](../VS_IDE/RC-Task.md)|Wraps the Microsoft Windows Resource Compiler tool (rc.exe).|  
|[SetEnv Task](../VS_IDE/SetEnv-Task.md)|Sets or deletes the value of a specified environment variable.|  
|[VCMessage Task](../VS_IDE/VCMessage-Task.md)|Logs warning messages and error messages during a build.|  
|[XDCMake Task](../VS_IDE/XDCMake-Task.md)|Wraps the XML Documentation tool (xdcmake.exe), which merges XML document comment (.xdc) files into an .xml file.|  
|[XSD Task](../VS_IDE/XSD-Task.md)|Wraps the XML Schema Definition tool (xsd.exe), which generates schema or class files from a source.|  
|[MSBuild Reference](../VS_IDE/MSBuild-Reference.md)|Describes the elements of the MSBuild system.|  
|[Tasks](../VS_IDE/MSBuild-Tasks.md)|Describes tasks, which are units of code that can be combined to produce a build.|  
|[Task Writing](../VS_IDE/Task-Writing.md)|Describes how to create a task.|