---
title: "Error: the dependency &#39;file&#39; in project &#39;project&#39; cannot be copied to the run directory because it would conflict with dependency &#39;file&#39; | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
f1_keywords:
  - "vs.tasklisterror.copy_version_conflict"
ms.assetid: cd7de1eb-7d58-4e2c-9811-a7201f7817be
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# Error: the dependency &#39;file&#39; in project &#39;project&#39; cannot be copied to the run directory because it would conflict with dependency &#39;file&#39;
There is a conflict between references; more than one distinct dependency with the same file name being copied to the bin directory for the application to run. The run directory cannot resolve the conflict because none of the dependencies are primary references.

 This error will cause the build to fail.

 Double-clicking this Task List item will take you to the references node of the project in which the conflict is occurring.

 **To correct this error**

- Make one of the assemblies a direct reference of your project. A possible downside to this approach is that the assembly you choose is not guaranteed to work with assemblies that require some other version of the referenced assembly.

     \- or -

- Make sure that both copies of the assembly are strong-named and in the global assembly cache. This eliminates the need to copy the assemblies to the bin directory.

## See Also
 [Managing references in a project](../ide/managing-references-in-a-project.md)
 [Global Assembly Cache](https://msdn.microsoft.com/library/cf5eacd0-d3ec-4879-b6da-5fd5e4372202)
 [Strong-Named Assemblies](https://msdn.microsoft.com/library/d4a80263-f3e0-4d81-9b61-f0cbeae3797b)
 [Assembly Versioning](https://msdn.microsoft.com/library/775ad4fb-914f-453c-98ef-ce1089b6f903)
 [How to: Create and Remove Project Dependencies](../ide/how-to-create-and-remove-project-dependencies.md)