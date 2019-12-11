---
title: "Analyzing Application Quality by Using Code Analysis Tools | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.analysisresults"
helpviewer_keywords:
  - "application quality, analyzing"
  - "code analysis"
  - "team-based development, analyzing application quality"
ms.assetid: 21680516-ddb5-446d-90d4-19d94f6ec699
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Analyzing Application Quality by Using Code Analysis Tools
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In This Section
 [Analyzing Managed Code Quality](../code-quality/analyzing-managed-code-quality-by-using-code-analysis.md)
 Visual Studio code analysis for managed code provides information about managed assemblies, such as violations of the programming and design rules set forth in the Microsoft .NET Framework Design Guidelines. Warning messages identify any relevant programming and design issues and, when it is possible, supply information about how to fix the problem.

 [Analyzing C/C++ Code Quality by Using Code Analysis](../code-quality/analyzing-c-cpp-code-quality-by-using-code-analysis.md)
 The C/C++ Code Analysis tool provides information to developers about possible defects in their C/C++ source code. Common coding errors reported by the tool include buffer overruns, un-initialized memory, null pointer dereferences, and memory and resource leaks.

 [Using Rule Sets to Group Code Analysis Rules](../code-quality/using-rule-sets-to-group-code-analysis-rules.md)
 Select and create *rule sets* to apply to your project.

 [Code Analysis Application Errors](../code-quality/code-analysis-application-errors.md)
 Fix errors in the code analysis functionality.

 [Enhancing Code Quality with Team Project Check-in Policies](../code-quality/enhancing-code-quality-with-team-project-check-in-policies.md)
 When you use Team Foundation Version Control (TFVC), you can create check-in policies for your team projects that enforce practices that lead to better code and more efficient group development. Check-in policies are rules that are set at the team project level and enforced on developer computers before code is allowed to be checked in.

### Code Analysis for Drivers
 Code analysis tools can help improve the stability and reliability of your driver by systematically analyzing the driver source code.

 [Analyzing Driver Quality by Using Code Analysis Tools](/windows-hardware/drivers/devtest/tools-for-verifying-drivers)
 Code Analysis for Drivers is a compile-time static verification tool that detects basic coding errors in C and C++ programs and includes a specialized module that is designed to detect errors in (primarily) kernel-mode driver code. Static Driver Verifier (SDV) is a static verification tool that systematically analyzes the source code of Windows kernel-mode drivers. SDV determines whether the driver correctly interacts with the Windows operating system kernel.

 [Code Analysis for Drivers Warnings](https://go.microsoft.com/fwlink/?LinkId=225920)
 Describes the warnings that the Code Analysis for Drivers reports when it detects a possible error in driver code.

## Related Tasks
 [Measuring Complexity and Maintainability of Managed Code](../code-quality/measuring-complexity-and-maintainability-of-managed-code.md)
 Insert description here.

 [Unit Test Your Code](../test/unit-test-your-code.md)
 Insert description here.
