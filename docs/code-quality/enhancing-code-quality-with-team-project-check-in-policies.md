---
title: "Enhancing Code Quality with Team Project Check-in Policies | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "code quality, using check-in policies"
  - "team-based development, enhancing code quality"
ms.assetid: 0ab72c33-148a-4a8a-a7bf-046995514c84
caps.latest.revision: 25
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Enhancing Code Quality with Team Project Check-in Policies
When you use Team Foundation Version Control (TFVC), you can create check-in policies for your team projects. to enforce practices that lead to better code and more efficient group development. Check-in policies are rules that are set at the team project level and enforced on developer computers before code is allowed to be checked in.  
  
 You can specify these team project check-in policies:  
  
-   **Builds**: Requires that build breaks that were created during a build must be fixed before a new check-in.  
  
-   **Changeset Comments**: Requires that users provide comments when checking in changes.  
  
-   **Code Analysis**: Requires that code analysis is run before check-in.  
  
-   **Work Items**: Requires that one or more work items be associated with the check- in.  
  
> [!IMPORTANT]
>  To use check-in policies, you must be connected to [!INCLUDE[vststfsLong](../code-quality/includes/vststfslong_md.md)].  
  
## Common Tasks  
  
|Task|Supporting Content|  
|----------|------------------------|  
|**Create and use check-in policies:** You create check-in policies by using the Team Project Settings of [!INCLUDE[esprscc](../code-quality/includes/esprscc_md.md)].|[Set and Enforce Quality Gates](../Topic/Set%20and%20Enforce%20Quality%20Gates.md)|  
|**Create and use code analysis check-in policies:** You can choose from a standard set of code analysis rules, or you can create a custom set.|[Creating and Using Code Analysis Check-In Policies](../code-quality/creating-and-using-code-analysis-check-in-policies.md)|  
  
## Related Tasks  
  
|Task|Supporting Content|  
|----------|------------------------|  
|**Set up your development environment:** Before you can create or modify code, you must set up your development and test environments by using the appropriate source code. If you are working with databases, you must also have access to their offline representation.|[Setting Up Development Environments](http://msdn.microsoft.com/en-us/7b686610-d379-4ca0-9608-73ef0e576e3a)|  
|**Use Code Analysis in development process:** Team members run code analysis on their development computers. In Visual Studio, developers configure and run code analysis runs for individual code projects, view and analyze issues found by the runs, and create work items for warnings.|[Analyzing Application Quality](../code-quality/analyzing-application-quality-by-using-code-analysis-tools.md)|  
|**Create and run unit tests:** Unit tests give developers and testers a quick way to look for logic errors in the methods of classes in C#, Visual Basic .NET, and C++ projects. A unit test can be created one time and run every time that source code is changed to make sure that no bugs are introduced.|[Unit Test Your Code](../test/unit-test-your-code.md)|  
|**Track work items and defects:** You can use work items to track and manage both your work and information about your team project. A work item is a database record that [!INCLUDE[esprfound](../code-quality/includes/esprfound_md.md)] uses to track the assignment and progress of work. You can use different types of work items to track different types of work, such as customer requirements, product bugs, and development tasks.|[Track work and manage workflow &#91;redirected&#93;](http://msdn.microsoft.com/en-us/d2d8637d-0ef8-4ca3-874e-a04713344032)|  
  
## External resources  
  
### Guidance  
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 2: Unit Testing: Testing the Inside](http://go.microsoft.com/fwlink/?LinkID=255188)