---
title: "Code Analysis for C/C++ Overview | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "annotations, code analysis"
  - "build integration, code analysis"
  - "C/C++ code analysis"
  - "IDE, code analysis"
  - "pragma directive, code analysis"
  - "code analysis, C/C++"
  - "code analysis tool"
  - "command line, code analysis"
  - "C++, code analysis"
  - "check-in policies, code analysis"
  - "#pragma directives, code analysis"
  - "C, code analysis"
ms.assetid: 81f0c9e8-f471-4de5-aac4-99db336a8809
caps.latest.revision: 25
author: mikeblome
ms.author: mblome
manager: ghogen
ms.workload: 
  - "cplusplus"
---
# Code Analysis for C/C++ Overview
The C/C++ Code Analysis tool provides information to developers about possible defects in their C/C++ source code. Common coding errors reported by the tool include buffer overruns, un-initialized memory, null pointer dereferences, and memory and resource leaks.  
  
## IDE (integrated development environment) Integration  
 To make it natural for developers to use the analysis tool, it is fully integrated within the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE. During the build process, any warnings generated for the source code appear in the Error List. You can navigate to source code that caused the warning, and you can view additional information about the cause and possible solutions of the issue.  
  
## #pragma Support  
 Developers can use the `#pragma` directive to treat warnings as errors; enable or disable warnings, and suppress warnings for individual lines of code. For more information, see [How to: Set Code Analysis Properties for C/C++ Projects    ](how-to-set-code-analysis-properties-for-c-cpp-projects.md).  
  
## Annotation Support  
 Annotations improve the accuracy of the code analysis. Annotations provide additional information about pre- and post- conditions on function parameters and return types. For more information, see [How to: Specify Additional Code Information by Using __analysis_assume](../code-quality/how-to-specify-additional-code-information-by-using-analysis-assume.md)  
  
## Run analysis tool as part of check-in policy  
 You might want to require that all source code check-ins satisfy certain policies. In particular, you want to make sure that analysis was run as a step of the most recent local build. For more information about enabling a code analysis check-in policy, see [Creating and Using Code Analysis Check-In Policies](../code-quality/creating-and-using-code-analysis-check-in-policies.md)  
  
## Team Build Integration  
 You can use the integrated features of the build system to run code analysis tool as a step of the [!INCLUDE[esprtfs](../code-quality/includes/esprtfs_md.md)] build process. For more information, see [Build and release](/vsts/build-release/index).  
  
## Command-line support  
 In addition to the full integration within the development environment, developers can also use the analysis tool from the command line, as shown in the following example:  
  
 `C:\>cl /analyze Sample.cpp`