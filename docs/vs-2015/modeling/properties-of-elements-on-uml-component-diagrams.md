---
title: "Properties of elements on UML component diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.teamarch.componentdiagram.shapes.properties"
helpviewer_keywords:
  - "component diagrams, properties"
  - "UML, element properties"
ms.assetid: fa0a9460-6675-4642-aa00-50f8719a892d
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of elements on UML component diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In a UML component diagram, each element on the diagram has properties. To see the properties of an element, right-click the element on the diagram or in **UML Model Explorer** and then click **Properties**. The properties appear in the **Properties** window.

> [!NOTE]
> This topic is about the properties of elements in UML Component Diagrams. For more information about how to read UML Component Diagrams, see [UML Component Diagrams: Reference](../modeling/uml-component-diagrams-reference.md). For more information about how to draw UML Component Diagrams, see [UML Component Diagrams: Guidelines](../modeling/uml-component-diagrams-guidelines.md).

## Properties of Elements

|Property|Default|Element|Description|
|--------------|-------------|-------------|-----------------|
|**Name**|A default name|All|Identifies the element.|
|**Qualified Name**|Namespace :: Name|All|Identifies the element uniquely.<br /><br /> A component or type's name is prefixed with the qualified name of the package that contains it.<br /><br /> A part or port's name is prefixed with the qualified name of the component that owns it.|
|**Work Items**|0 associated|All|The number of work items associated with this element. To associate work items, see [Link model elements and work items](../modeling/link-model-elements-and-work-items.md).|
|**Description**|(none)|All|You can make general notes about the element here.|
|**Color**|(default for the type)|Component, Part, Delegation, Part assembly|The color of the shape. Unlike other properties, this is the color of the shape rather than the model element that the shape displays.|
|**Is Indirectly Instantiated**|True|Component|The component exists only as a design artifact. At run time, only its parts exist.|
|**Is Abstract**|False|Component|The component definition can be used only as a generalization from which other components can be specialized.|
|**Visibility**|Public|Component, Part, Port|**Public** - globally visible.<br /><br /> **Package** - visible within the package.<br /><br /> **Private** - visible within the owning component.<br /><br /> **Protected** - visible to components derived from the owner.|
|**Type**|Type on creation|Part<br /><br /> Port|The type of a part is a component or class.<br /><br /> The type of a Port is an interface.|
|**Multiplicity**|1|Part<br /><br /> Port|Indicates how many instances of the specified type form part of the parent component.<br /><br /> `1` - exactly one.<br /><br /> `0..1` - one or none.<br /><br /> `*` - a collection of any number.<br /><br /> `n..m` - a collection of from n to m instances.|
|**Is Behavior**|False|Port|If true, messages to this port are handled by activities or operations that are described as part of the component, instead of its parts.|
|**Is Service**|False|Port|If true, this port is part of the published interface of this component.|
|**LinkedPackage**|Model|Diagram|The default namespace for elements added to this diagram.|

## See Also
 [UML Use Case Diagrams: Reference](../modeling/uml-use-case-diagrams-reference.md)
 [UML Use Case Diagrams: Guidelines](../modeling/uml-use-case-diagrams-guidelines.md)
