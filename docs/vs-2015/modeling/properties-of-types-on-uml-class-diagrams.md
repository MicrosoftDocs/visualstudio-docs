---
title: "Properties of types on UML class diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.teamarch.logicalclassdiagram.shapes.properties"
helpviewer_keywords:
  - "UML, element properties"
ms.assetid: 6e1ef2d0-d67a-401a-bd64-d5e034decd2c
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of types on UML class diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In a UML Class Diagram, a *type* is a class, an interface, or an enumeration.

> [!NOTE]
> This topic is about the properties of types in UML Class Diagrams. For more information, see the following topics:

- [UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)

- [UML Class Diagrams: Guidelines](../modeling/uml-class-diagrams-guidelines.md)

- [Properties of attributes on UML class diagrams](../modeling/properties-of-attributes-on-uml-class-diagrams.md)

- [Properties of operations on UML class diagrams](../modeling/properties-of-operations-on-uml-class-diagrams.md)

- [Properties of associations on UML class diagrams](../modeling/properties-of-associations-on-uml-class-diagrams.md)

## Properties
 These are the properties of a class, interface or enumeration.

 To see the properties of a type, right-click the type in the diagram or in **UML Model Explorer**, and then click **Properties**. The properties appear in the **Properties** window.

|**Property**|**Default**|Appears in|Description|
|------------------|-----------------|----------------|-----------------|
|**Name**|A default name|All elements|Identifies the element.|
|**Qualified Name**|Containing Package :: Type Name|All elements|Identifies the element uniquely. Prefixed with the qualified name of the package that contains it.|
|**Color**|Default for the kind of type|All elements|The color of this shape. Unlike the other properties, this is not a property of the underlying model element. Different views of the same type can have different colors.|
|**Is Abstract**|False|Class|If true, the class cannot be instantiated, and is intended for use as a base class.|
|**Is Leaf**|False|Class, Interface|If true, the type is not intended to have derived types.|
|**Is Active**|False|Class|If true, each instance of this type is associated with a thread of control.|
|**Visibility**|Public|Class, Interface, Enumeration|-   Public - globally visible.<br />-   Private - this type is visible within the package that owns it.<br />-   Package - visible within the package.|
|**Work Items**|0 associated|All elements|The number of work items associated with this element. To associate work items, see [Link model elements and work items](../modeling/link-model-elements-and-work-items.md).|
|**Description**|(blank)|All elements|You can make general notes about the item here.|
|**Template Binding**|(none)|Class, Interface, Enumeration|If not empty, this type is defined by binding parameter values to this template class. Expand the property to see the bindings of the template parameters.|
|**Template Parameters**|(none)|Class, Interface, Enumeration|If not empty, this is a template class that has the parameters listed here. To add parameters or view the properties of individual parameters, click **[…]**.|

## See Also
 [Properties of attributes on UML class diagrams](../modeling/properties-of-attributes-on-uml-class-diagrams.md)
 [Properties of operations on UML class diagrams](../modeling/properties-of-operations-on-uml-class-diagrams.md)
 [Properties of associations on UML class diagrams](../modeling/properties-of-associations-on-uml-class-diagrams.md)
 [UML Class Diagrams: Guidelines](../modeling/uml-class-diagrams-guidelines.md)
