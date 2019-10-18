---
title: "Code Analysis Policy Errors | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.policyfailures"
helpviewer_keywords:
  - "policy errors, code analysis"
ms.assetid: d1f221cd-68c0-4277-9397-b76ad0dbae77
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Code Analysis Policy Errors
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The following errors occur if the code analysis policy is not satisfied at check-in:

 **The Code Analysis settings for one or more projects are not compatible with Code Analysis policy.**

 The code analysis requirements checking in to the team project source control was not met for one or more code projects. This error can be caused by one or more of the following conditions:

1. Code Analysis is not enabled on build for all of the projects in the solution.

2. The local rule set for the project in Visual Studio has a less restrictive **Action** setting than the team project rule set for example, a rule that is set to **Action**=**Error** on the server has its **Action** set to **Warning** or **None** in the rule set being run in Visual Studio).

3. The rule set specified in Visual Studio does not contain all of the rules that are specified in the rule set specified in the Code Analysis check-in policy for the team project.

   **The Code Analysis policy failed. There are errors in project {0} or the build is not up to date.**

   Either the build contains errors or the errors were fixed, but code analysis was not performed after the fix.

   **Check-in failed. The Code Analysis Policy requires that you check in through Visual Studio with an open solution.**

   The code analysis policy requires that all files being checked in must be in the currently open solution. To correct this error, open the solution that contains the file to be checked in.

   **Not all files in the pending check-in are within the currently open solution.**

   The code analysis policy requires that all files being checked in must be in the currently open solution. This error is raised when there is an open solution, but some files in the "pending check in" view are not part of the currently opened solution. To correct this error, open the solution that contains the file to be checked in.

   **The version of '{0}' is not correct. The strong-name specified in the policy is '{1}'.**

   This error applies to .NET projects. A rule .dll required by the code analysis policy exists on the local computer, but the version/public key does not match. To correct this error, the policy creator must update the .dlls in *C:\Program Files\Microsoft Visual Studio 8\Team Tools\Static Analysis Tools\FxCop\Rules\\* directory on their computer.

   **'{0}' assembly specified in the policy does not exist.**

   This error applies to .NET projects. A rule required by the code analysis policy does not have the corresponding dll installed on the client computer. To correct this error, the policy creator must update the dll in *C:\Program Files\Microsoft Visual Studio 8\Team Tools\Static Analysis Tools\FxCop\Rules\\* directory on their computer.

   **Project {0} rule settings are not in conformance with Code Analysis policy.**

   This error applies to .NET projects. The managed code rules settings are not as strict as the policy requires. To correct this error, the client setting must be the same or stricter than the policy requirement on the server.

   **Code Analysis is not enabled on active configuration. Switch to configuration {0} and build project {1} before checking in.**

   In [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], the active configuration does not have code analysis enabled, but there is at least one code analysis enabled.

   **You must enable Code Analysis for managed binaries in project {0} properties and build before checking in.**

   This error applies to [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] .NET applications. The policy requires managed code analysis to be performed, but it is not enabled in the current project on the client.

   **You must enable Code Analysis in project {0} properties and build before checking in.**

   This error applied to [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] projects and Web projects. The policy requires managed code analysis to be performed, but it is not enabled in the current project on the client.

   **You must enable C/C++ Code Analysis in project {0} properties and build before checking in.**

   This error applies to unmanaged projects. The code analysis policy requires Code Analysis for C/C++, but it is not enabled in the current project on the client.

## See Also
 [Code Analysis Application Errors](../code-quality/code-analysis-application-errors.md)
