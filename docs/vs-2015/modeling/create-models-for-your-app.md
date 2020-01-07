---
title: "Create models for your app | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
f1_keywords:
  - "vs.teamarch.common.commentlink.properties"
  - "vs.teamarch.UMLModelExplorer.dependency"
  - "vs.teamarch.UMLModelExplorer.commentlink"
  - "vs.teamarch.common.dependency.properties"
  - "Microsoft.VisualStudio.Uml.Diagrams.CommentShape.IsTransparent"
  - "vs.teamarch.common.comment.properties"
  - "vs.teamarch.UMLModelExplorer.comment"
helpviewer_keywords:
  - "diagrams - modeling, sequence"
  - "software design"
  - "diagrams - modeling, use case"
  - "diagrams - modeling, component"
  - "diagrams - modeling, UML component"
  - "UML model"
  - "diagrams - modeling, UML use case"
  - "diagrams - modeling, class"
  - "diagrams - modeling, activity"
  - "diagrams - modeling, UML activity"
  - "software modeling"
  - "diagrams - modeling, UML sequence"
  - "UML"
  - "diagrams - modeling, UML"
  - "diagrams - modeling, layer"
  - "software, designing"
  - "diagrams - modeling, UML class"
  - "software, modeling"
  - "UML diagrams"
ms.assetid: b69d9d91-c7e7-4dee-8eb6-706076eecb85
caps.latest.revision: 60
author: jillre
ms.author: jillfra
manager: jillfra
---
# Create models for your app
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Modeling diagrams help you understand, clarify, and communicate ideas about your code and the user requirements that your software system must support. For example, to describe and communicate user requirements, you can use Unified Modeling Language (UML) use case, activity, class, and sequence diagrams. To describe and communicate the functionality of your system, you can use UML component, class, activity, and sequence diagrams.

 See [Channel 9 Video: Improve architecture through modeling](https://go.microsoft.com/fwlink/?LinkID=252078).

 You can create the following UML diagrams in this release:

|**Diagram**|**Shows**|
|-----------------|---------------|
|[UML Activity Diagrams: Reference](../modeling/uml-activity-diagrams-reference.md)|Flow of work between actions and participants in a business process|
|[UML Component Diagrams: Reference](../modeling/uml-component-diagrams-reference.md)|Components of a system, their interfaces, ports, and relationships|
|[UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)|Types that are used to store and exchange data in the system and their relationships|
|[UML Sequence Diagrams: Reference](../modeling/uml-sequence-diagrams-reference.md)|Sequences of interactions between objects, components, systems, or actors|
|[UML Use Case Diagrams: Reference](../modeling/uml-use-case-diagrams-reference.md)|User goals and tasks that a system supports|

 To see which versions of Visual Studio support each type of diagram, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

 To visualize the architecture of a system or existing code, create the following diagrams:

|**Diagram**|**Shows**|
|-----------------|---------------|
|[Layer Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)<br /><br /> [Layer Diagrams: Reference](../modeling/layer-diagrams-reference.md)|High-level architecture of the system|
|Code maps<br /><br /> [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)<br /><br /> [Find potential problems using code map analyzers](../modeling/find-potential-problems-using-code-map-analyzers.md)|Dependencies and other relationships in existing code|
|Code-generated class diagrams<br /><br /> [Working with Class Diagrams (Class Designer)](../ide/working-with-class-diagrams-class-designer.md)|Types and their relationships in .NET code|

## Common Tasks

|**Topic**|**Task**|
|---------------|--------------|
|[Create UML modeling projects and diagrams](../modeling/create-uml-modeling-projects-and-diagrams.md)|**Create models** and add diagrams.|
|[Edit UML models and diagrams](../modeling/edit-uml-models-and-diagrams.md)|**Draw diagrams** to edit the model.|
|[Define packages and namespaces](../modeling/define-packages-and-namespaces.md)|**Create packages** to divide a model into units that different team members can work on.|
|[Generate code from UML class diagrams](../modeling/generate-code-from-uml-class-diagrams.md)|**Generate C# code from class diagrams** to start your implementation.|
|[Customize your model with profiles and stereotypes](../modeling/customize-your-model-with-profiles-and-stereotypes.md)|**Customize model elements** using stereotypes, to extend the standard UML model elements for specific purposes.|
|[Link model elements and work items](../modeling/link-model-elements-and-work-items.md)|**Create links between model elements and work items** to help you track tasks, test cases, bugs, requirements, issues, or other kinds of work that are associated with specific parts of your model.|
|[Export diagrams as images](../modeling/export-diagrams-as-images.md)|**Save your model and diagrams** so that you can share them with other users, including those who do not use [!INCLUDE[vsUltShort](../includes/vsultshort-md.md)].|

## Related Tasks

|**Topic**|**Task**|
|---------------|--------------|
|[Visualize code](../modeling/visualize-code.md)|Create code maps and layer diagrams to better understand unfamiliar code.|
|[Model user requirements](../modeling/model-user-requirements.md)|Use models to clarify and communicate the users' needs.|
|[Model your app's architecture](../modeling/model-your-app-s-architecture.md)|Use models to describe the overall structure and behavior of your system and to make sure that it meets the users' needs.|
|[Validate your system during development](../modeling/validate-your-system-during-development.md)|Make sure that your software stays consistent with your users' needs and the overall architecture of your system.|
|[Use models in your development process](../modeling/use-models-in-your-development-process.md)<br /><br /> [Use models in Agile development](https://msdn.microsoft.com/592ac27c-3d3e-454a-9c38-b76658ed137f)|Use models to help you understand and change your system during its development.|
|[Structure your modeling solution](../modeling/structure-your-modeling-solution.md)|Organize models in a large or medium project.|

## External Resources

|**Category**|**Links**|
|------------------|---------------|
|**Forums**|-   [Visual Studio Visualization & Modeling Tools](https://go.microsoft.com/fwlink/?LinkId=184720)<br />-   [Visual Studio Visualization & Modeling SDK (DSL Tools)](https://go.microsoft.com/fwlink/?LinkId=184721)|
