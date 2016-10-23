---
title: "Read models and diagrams in other Visual Studio editions"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 46eee279-a9e4-4742-a024-5bd2cf032b86
caps.latest.revision: 20
manager: kamrani
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Read models and diagrams in other Visual Studio editions
When you open a model in a version of Visual Studio that does not support model creation, the model opens in read-only mode. In this mode, you can change the layout of the diagrams, but you cannot change the model.  
  
 To see which versions of Visual Studio support model creation, see [Version support for architecture and modeling tools](../VS_IDE/What-s-new-for-design-in-Visual-Studio.md#VersionSupport).  
  
## Obtaining Access to a Model and Diagrams  
 To read a UML diagram or a layer diagram, you must first use Visual Studio to open the modeling project, and then open the diagram within it.  
  
 For this reason, if you want to read a UML diagram or layer diagram, you must also have access to the modeling project in which it was created. You can do this either by accessing the project from Team Foundation version control, or by obtaining a copy of the project files.  
  
> [!NOTE]
>  This does not apply to code maps and .NET class diagrams generated from code. Those diagrams can be viewed independently of a modeling project.  
  
 To read a UML diagram or a layer diagram, the minimum set of files that you need is as follows:  
  
-   The two diagram files for the diagram that you want to read, for example, **MyDiagram.classdiagram and MyDiagram.classdiagram.layout**.  
  
    > [!NOTE]
    >  For Layer diagrams, you should also have the file that is named *MyDiagram***.layerdiagram.suppressions**.  
  
-   The modeling project file (**MyModel.modelproj**)  
  
-   The root model file (**ModelDefinition\MyModel.uml**)  
  
-   The package files for any package referenced in the diagram (**ModelDefinition\MyPackage.uml**)  
  
## Changes that you can Make in Read-Only Mode  
 If you open a model and its diagrams in a version of Visual Studio that does not support model creation, you cannot change the model. That is, you cannot change the elements and relationships that are displayed on the diagrams or in the model explorer. However, you can make some changes to the layout of the diagrams:  
  
-   Rearrange the shapes and connectors on the diagram.  
  
-   Expand and collapse shapes.  
  
 You can save these changes. If you want to make your changes visible to other users, you must at least send the updated **.layout** files.  
  
##  <a name="RelatedTopics"></a> Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Layer Diagrams: Reference](../VS_IDE/Layer-Diagrams--Reference.md)|A layer diagram shows the structure of an existing or proposed architecture. When code is written, it can be automatically validated against a layer diagram.|  
|[UML Activity Diagrams: Reference](../VS_IDE/UML-Activity-Diagrams--Reference.md)|An activity diagram shows a flow of work, either in a business process or in software.|  
|[UML Class Diagrams: Reference](../VS_IDE/UML-Class-Diagrams--Reference.md)|A class diagram shows types and relationships used in many contexts such as code, database schemas, communications protocols, or the glossary of terms used to describe a business domain.|  
|[UML Component Diagrams: Reference](../VS_IDE/UML-Component-Diagrams--Reference.md)|A component diagram shows separable parts in a software design, and their interfaces.|  
|[UML Sequence Diagrams: Reference](../VS_IDE/UML-Sequence-Diagrams--Reference.md)|A sequence diagram shows interactions between elements in a software design.|  
|[UML Use Case Diagrams: Reference](../VS_IDE/UML-Use-Case-Diagrams--Reference.md)|A use case diagram shows the users of a system and the activities that they can perform to achieve specific goals.|  
  
## See Also  
 [Create models for your app](../VS_IDE/Create-models-for-your-app.md)