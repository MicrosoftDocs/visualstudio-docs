---
title: "Read models and diagrams in other Visual Studio editions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "models, versions of Visual Studio"
ms.assetid: 46eee279-a9e4-4742-a024-5bd2cf032b86
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: jillfra
---
# Read models and diagrams in other Visual Studio editions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you open a model in a version of Visual Studio that does not support model creation, the model opens in read-only mode. In this mode, you can change the layout of the diagrams, but you cannot change the model.

 To see which versions of Visual Studio support model creation, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Obtaining Access to a Model and Diagrams
 To read a UML diagram or a layer diagram, you must first use Visual Studio to open the modeling project, and then open the diagram within it.

 For this reason, if you want to read a UML diagram or layer diagram, you must also have access to the modeling project in which it was created. You can do this either by accessing the project from [!INCLUDE[esprscc](../includes/esprscc-md.md)], or by obtaining a copy of the project files.

> [!NOTE]
> This does not apply to code maps and .NET class diagrams generated from code. Those diagrams can be viewed independently of a modeling project.

 To read a UML diagram or a layer diagram, the minimum set of files that you need is as follows:

- The two diagram files for the diagram that you want to read, for example, **MyDiagram.classdiagram and MyDiagram.classdiagram.layout**.

    > [!NOTE]
    > For Layer diagrams, you should also have the file that is named _MyDiagram_**.layerdiagram.suppressions**.

- The modeling project file (**MyModel.modelproj**)

- The root model file (**ModelDefinition\MyModel.uml**)

- The package files for any package referenced in the diagram (**ModelDefinition\MyPackage.uml**)

## Changes that you can Make in Read-Only Mode
 If you open a model and its diagrams in a version of Visual Studio that does not support model creation, you cannot change the model. That is, you cannot change the elements and relationships that are displayed on the diagrams or in the model explorer. However, you can make some changes to the layout of the diagrams:

- Rearrange the shapes and connectors on the diagram.

- Expand and collapse shapes.

  You can save these changes. If you want to make your changes visible to other users, you must at least send the updated **.layout** files.

## <a name="RelatedTopics"></a> Related Topics

|Title|Description|
|-----------|-----------------|
|[Layer Diagrams: Reference](../modeling/layer-diagrams-reference.md)|A layer diagram shows the structure of an existing or proposed architecture. When code is written, it can be automatically validated against a layer diagram.|
|[UML Activity Diagrams: Reference](../modeling/uml-activity-diagrams-reference.md)|An activity diagram shows a flow of work, either in a business process or in software.|
|[UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)|A class diagram shows types and relationships used in many contexts such as code, database schemas, communications protocols, or the glossary of terms used to describe a business domain.|
|[UML Component Diagrams: Reference](../modeling/uml-component-diagrams-reference.md)|A component diagram shows separable parts in a software design, and their interfaces.|
|[UML Sequence Diagrams: Reference](../modeling/uml-sequence-diagrams-reference.md)|A sequence diagram shows interactions between elements in a software design.|
|[UML Use Case Diagrams: Reference](../modeling/uml-use-case-diagrams-reference.md)|A use case diagram shows the users of a system and the activities that they can perform to achieve specific goals.|

## See Also
 [Create models for your app](../modeling/create-models-for-your-app.md)
