---
title: "Properties of elements on UML use case diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.teamarch.usecasediagram.artifact.properties"
  - "vs.teamarch.usecasediagram.shapes.properties"
helpviewer_keywords:
  - "use case diagrams, properties"
ms.assetid: 2728fb26-a275-4fce-8a2c-5a78af6bee04
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of elements on UML use case diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In a UML Use Case Diagram, each element on the diagram has properties. To see the properties of an element, right-click the element on the diagram or in **UML Model Explorer** and then click **Properties**. The properties appear in the **Properties** window.

> [!NOTE]
> This topic is about the properties of elements in UML Use Case Diagrams. For more information about how to read UML activity diagrams, see [UML Use Case Diagrams: Reference](../modeling/uml-use-case-diagrams-reference.md). For more information about how to draw UML activity diagrams, see [UML Use Case Diagrams: Guidelines](../modeling/uml-use-case-diagrams-guidelines.md).

## Properties of Elements

|Property|Default|Element|Description|
|--------------|-------------|-------------|-----------------|
|**Name**|A default name|All|Identifies the element.|
|**Qualified Name**|Package :: Name|All|Identifies the element uniquely. Prefixed with the qualified name of the package that contains it.|
|**Work Items**|0 associated|All|The number of work items associated with this element. To associate work items, see [Link model elements and work items](../modeling/link-model-elements-and-work-items.md).|
|**Description**|(none)|All|You can make general notes about the element here.|
|**Color**|(default)|All|The color of the shape. Unlike other properties, this is a not a property of the element that the shape displays.|
|**Image Path**|(none)|Actor|The file path of an image that should be used instead of the default actor icon. The icon should be a resource file within the Visual Studio project.|
|**Subjects**|(none)|Use Case|The Subsystem or other type that owns the use case.<br /><br /> You can set it by placing the use case on a Subsystem in the diagram.|
|**Visibility**|Public|Use Case, Actor, Subsystem|**Public** - globally visible.<br /><br /> **Package** - visible within the package.|
|**IsAbstract**|False|Use Case, Actor, Subsystem|If true, the type cannot be instantiated, and is intended as a base for specialization by other definitions.|
|**Is Indirectly Instantiated**|True|Subsystem|The subsystem exists only as a design artifact. At run time, only its parts exist.|
|**Hyperlink**|(none)|Artifact|The URL or file path of the diagram or document to which the artifact provides a link.|

 For a list of the properties of associations, see [Properties of associations on UML class diagrams](../modeling/properties-of-associations-on-uml-class-diagrams.md).

## See Also
 [UML Use Case Diagrams: Reference](../modeling/uml-use-case-diagrams-reference.md)
 [UML Use Case Diagrams: Guidelines](../modeling/uml-use-case-diagrams-guidelines.md)
