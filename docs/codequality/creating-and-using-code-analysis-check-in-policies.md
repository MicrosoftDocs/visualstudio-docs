---
title: "Creating and Using Code Analysis Check-In Policies"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "code analysis, check-in policies"
ms.assetid: 3fa5a849-e05f-4e31-8ba3-b014c889d94d
caps.latest.revision: 39
ms.author: "susanno"
manager: "douge"
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
# Creating and Using Code Analysis Check-In Policies
When you use Team Foundation Version Control (TFVC), you can create a code analysis check-in policy for the .NET Framework and native (C/C++) code projects in a team project. You can use the code analysis check-in policy to control and improve the quality of code that is checked into the code base.  
  
 The policy passes when the local build is up to date and code analysis has been run on the most recent source files. At a minimum, the code analysis rules that are enabled in the code project must contain the same rules as those that are defined in the team project check-in policy. Rules that have been specified as errors in the Team Project Settings must also be specified as errors in the code project  
  
> [!IMPORTANT]
>  Code analysis check-in policies cannot be applied to web site projects. They can be applied to web application projects.  
  
 You create code analysis check-in policies by using the Team Project Settings of [!INCLUDE[esprscc](../codequality/includes/esprscc_md.md)]. Check-in policies are specified and enforced for a team project, but code analysis runs are configured and run for individual code projects on local development computers. This section describes how to specify code analysis check-in policies for a team project and how to implement custom code analysis policies for managed code.  
  
## In This Section  
 [How to: Create or Update Standard Code Analysis Check-in Policies](../codequality/how-to--create-or-update-standard-code-analysis-check-in-policies.md)  
 Explains the steps that you use to set and modify a code analysis policy for a team project.  
  
 [Implementing Custom Check-in Policies for Managed Code](../codequality/implementing-custom-code-analysis-check-in-policies-for-managed-code.md)  
 Explains the steps that you use to create a custom rule set for the check-in policy of a team project, and to synchronize the code projects of the team project with the check-in policy.  
  
 [Version Compatibility for Code Analysis Check-In Policies](../codequality/version-compatibility-for-code-analysis-check-in-policies.md)  
 Explains code analysis check-in compatibility issues between versions of [!INCLUDE[vstsLong](../codequality/includes/vstslong_md.md)].  
  
 [How to: Customize the Code Analysis Dictionary](../codequality/how-to--customize-the-code-analysis-dictionary.md)  
 Explains how to add words and tokens to the dictionary that is referenced in code analysis naming rules.  
  
## Related Sections  
 [Set and Enforce Quality Gates](../Topic/Set%20and%20Enforce%20Quality%20Gates.md)  
  
 [Enhancing Code Quality with Team Project Check-in Policies](../codequality/enhancing-code-quality-with-team-project-check-in-policies.md)