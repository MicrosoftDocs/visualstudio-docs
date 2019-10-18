---
title: "Warning: the dependency &#39;file&#39; in project &#39;project&#39; cannot be copied to the run directory because it would overwrite the reference &#39;file.&#39; | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
f1_keywords: 
  - "vs.tasklisterror.copy_version_warning"
ms.assetid: 116819f3-a4d4-48b5-9e71-7c54660d38ef
caps.latest.revision: 11
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Warning: the dependency &#39;file&#39; in project &#39;project&#39; cannot be copied to the run directory because it would overwrite the reference &#39;file.&#39;
There is a conflict between dependencies; more than one distinct assembly files with the same name should be copied to the bin directory for the application to run. The run directory is able to resolve the conflict since one of the dependencies is a primary reference.  
  
 Double-clicking this Task List item will take you to the primary reference node that is conflicting.  
  
 This warning occurs when you have a dependency conflict but have worked around it by adding one of the conflicting dependencies as a reference. Or you may have had a version 1 reference, and then added a second reference which itself references the version 2 of the first reference.  
  
 That is, this error occurs because the projects in your solution have references to each other, but the references were created as file references (using the **Browse** button in the [Add Reference](https://msdn.microsoft.com/2feb0fe2-0805-4cc9-8cba-b0315849dfb7) dialog box), rather than project to project references (using the **Project** tab on the **Add Reference** dialog box). The advantage of a project to project reference is that it creates a dependency between the projects in the build system so that the dependent project will be built if it has changed since the last time the referencing project was built. A file reference does not create a build dependency so it is possible to build the referencing project without building the dependent project, and so a reference can become obsolete; a project can reference a previously built version of the project. This can result in several versions of a single DLL being required in the bin directory, which is not possible, and results in this error message.  
  
 This message appears every time there is a conflict in the bin directory and the application may not work properly. Even though you may have worked around this problem, this warning will still appear because the project system cannot determine whether the version of a dependency will work correctly with all components.  
  
 **To correct this error**  
  
- Copy one (or zero) assembly files to the bin directory, which can be done by putting the assembly files into the global assembly cache. The global assembly cache resolves file name conflicts. No local copies of the assembly file will be made because the common language runtime knows how to find assemblies in the global assembly cache. For more information, see [Working with Assemblies and the Global Assembly Cache](https://msdn.microsoft.com/library/8a18e5c2-d41d-49ef-abcb-7c27e2469433) and [Error: the dependency 'file' in project 'project' cannot be copied to the run directory because it would conflict with dependency 'file'](/visualstudio/misc/error-dependency-file?view=vs-2015).  
  
## See also  
 [Managing references in a project](../ide/managing-references-in-a-project.md)   
 [Global Assembly Cache](https://msdn.microsoft.com/library/cf5eacd0-d3ec-4879-b6da-5fd5e4372202)   
 [How to: Create and Remove Project Dependencies](../ide/how-to-create-and-remove-project-dependencies.md)