---
title: "Sharing Classes between DSLs by using a DSL Library"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 509bd96b-3e66-47f4-8642-771421d0d0d5
caps.latest.revision: 7
ms.author: "awills"
manager: "kamrani"
---
# Sharing Classes between DSLs by using a DSL Library
In the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Visualization and Modeling SDK, you can create an incomplete DSL Definition that you can import into another DSL. This lets you factor common parts of similar models.  
  
## Creating and using DSL Libraries  
  
#### To create a DSL Library  
  
1.  Create a new DSL project, and choose the DSL Library solution template.  
  
     A single DSL project will be created with an empty model.  
  
2.  You can add domain classes, relationships, shapes and so on.  
  
     The elements in the library do not have to form a single embedding tree.  
  
     To define a relationship that importers can use, create two domain classes and create the relationship between them.  
  
     Consider setting the **Inheritance Modifier** of the domain classes to `Abstract`.  
  
3.  You can add elements that you define in DSL Explorer, such as Connection Builders.  
  
4.  You can add customizations that require additional code, such as validation constraints.  
  
5.  Click **Transform All Templates**.  
  
6.  Build the project.  
  
7.  When you distribute the DSL for other people to use, you must provide both the compiled assembly (DLL) and the file `DslDefinition.dsl`. You can find the compiled assembly in a folder under `Dsl\bin\*`  
  
#### To import a DSL Library  
  
1.  In another DSL Definition, in **DSL Explorer**, right-click the root class of the DSL, and then click **Add New DslLibrary Import**.  
  
2.  In the Properties window, set the **File Path** of the library. You can use either a relative or an absolute path.  
  
     The imported library appears in DSL Explorer, in read-only mode.  
  
3.  You can use the imported classes as base classes. Create a domain class in the importing DSL, and in the Properties window, set **Base Class** to an imported class.  
  
4.  Click Transform All Templates.  
  
5.  Add to the DSL project a reference to the assembly (DLL) that was built by the DSL Library project.  
  
6.  Build the solution.  
  
 A DSL Library can import other libraries. When you import a library, its imports also automatically appear in DSL Explorer.  
  
## See Also  
 [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md)