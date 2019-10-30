---
title: "Properties of associations on UML class diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.teamarch.common.association.properties"
helpviewer_keywords:
  - "UML, element properties"
ms.assetid: f82bcd34-7903-4c00-8da1-613efa07d223
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of associations on UML class diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In a UML class diagram, you can draw *associations* between any pair of types. A type is a class, interface, or enumeration.

 An association indicates that the system you are developing stores links of some kind between the instances of the associated types. Generally, it does not imply anything about the implementation of the links. For example, they might be pointers, rows in a table, cross-referenced names in XML, and so on.

 An association is a diagrammatic method of showing an attribute or pair of attributes. For example, if you have defined a class Restaurant to have an attribute of type Menu, you can state the same definition by drawing an association between Restaurant and Menu.

 To draw an association, click **Association** in the toolbox, click the first type, then the second. You can click the same type two times to show that instances can be linked with other instances of the same type.

## Properties
 These are the properties of an association on a UML Class Diagram.

 To see the properties of an association, right-click the association and then click **Properties**. The properties will appear in the Properties window.

 Some of the properties are also visible on the diagram, as shown in the following illustration.

 ![Properties on assocations](../modeling/media/uml-classprop.png "UML_ClassProp")

|**Property**|Description|
|------------------|-----------------|
|**Name (1)**|Identifies the association. Also appears on the diagram near the mid-point of the association.|
|**Qualified Name**|Identifies the association uniquely. Prefixed with the qualified name of the package that contains the association's first role.|
|**Work Items**|The number of work items linked to this association. To link work items, see [Link model elements and work items](../modeling/link-model-elements-and-work-items.md).|
|**Color**|The color of the connector. Unlike the other properties, this is a property of this view of the association, not a property of the underlying relationship in the model.|
|**First Role**<br /><br /> **Second Role**|Each end of the association is called a role. Each role describes the properties of the equivalent attribute on the class at the opposite end of the association.<br /><br /> In the example diagram, the association between Menu and Menu Item has roles called Menu and Contents.<br /><br /> Contents is the name of an attribute on the Menu class.|

### Properties of Each Role
 To see the properties of each role, expand the **First Role** or **Second Role** property.

|     **Property**     |          **Default**          |                                                                                                                                                                                                                                                                                                                                        Description                                                                                                                                                                                                                                                                                                                                         |
|----------------------|-------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|  **Role Name (2)**   | Name of the type at this role |                                                                                                                                                                                                                                                                                                       The name of the role. Appears near the end of the association on the diagram.                                                                                                                                                                                                                                                                                                        |
|   **Aggregation**    |             None              |                                                                        **None** (4) - represents a general relationship between instances of the classes.<br /><br /> **Composite** (5) - the object at this role contains the object at the opposite role. You can use the **Composite** tool to create an association with Composite aggregation.<br /><br /> **Shared** (6) - object at this role contains references to the object at the other role. You can use the **Aggregation** tool to create an association with Shared aggregation.<br /><br /> The exact interpretation is open to local convention.                                                                         |
|    **Is Derived**    |             False             |                                                                                                                                                                                                                          If true, the object at this end of the link is calculated from other attributes and associations. For example, MyWorkPlace calculated from MyEmployer.WorkPlace. The details should be typed in the Description or an attached Comment.                                                                                                                                                                                                                           |
| **Is Derived Union** |             False             |                                                                                                                                                                                                                                                                                                             If true, the role is the union of a set of roles in derived types.                                                                                                                                                                                                                                                                                                             |
|   **Is Navigable**   |             True              |                                                 The association can be read in this direction. Given an instance of the opposite role, the software that you are describing can efficiently determine the associated instance in this role.<br /><br /> If one role is Navigable and the other is not, an arrow appears (7) on the association in the navigable direction.<br /><br /> By default, the association tool creates an association that is navigable in one direction. To convert it to a bidirectional association, you can select the association, click the Action tag that appears, and then click **Make Bidirectional**.                                                 |
|   **Is Read Only**   |             False             |                                                                                                                                                                                                                                                                                   If true, an instance of the association cannot be changed after it is created. The link is always to the same object.                                                                                                                                                                                                                                                                                    |
| **Multiplicity (3)** |               1               | **1** - this end of the association always links to one object. In the figure, every Menu Item has one Menu.<br /><br /> **0..1** - either this end of the association links to one object, or there is no link.<br /><br /> **\\**\* - every object at the other end of the association is linked to a collection of objects at this end, and the collection may be empty.<br /><br /> **1..\\**\* - every object at the other end of the association is linked to at least one object at this end. In the figure, every Menu has at least one Menu Item.<br /><br /> *n* **..** *m* - each object at the other end has a collection of between *n* and *m* links to objects at this end. |
|    **Is Ordered**    |             False             |                                                                                                                                                                                                                                                                                                  If true, the returned collection forms a sequential list. For Multiplicity more than 1.                                                                                                                                                                                                                                                                                                   |
|    **Is Unique**     |             False             |                                                                                                                                                                                                                                                                                              If true, there are no duplicate values in the returned collection. For Multiplicity more than 1.                                                                                                                                                                                                                                                                                              |
|    **Visibility**    |            Public             |                                                                                                                                                                                                                                 Public - visible globally<br /><br /> Private - not visible outside the owning type<br /><br /> Protected - visible to types derived from the owner<br /><br /> Package - visible to other types within the same package.                                                                                                                                                                                                                                  |

## See Also
 [UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)
 [Properties of types on UML class diagrams](../modeling/properties-of-types-on-uml-class-diagrams.md)
 [Properties of attributes on UML class diagrams](../modeling/properties-of-attributes-on-uml-class-diagrams.md)
 [Properties of operations on UML class diagrams](../modeling/properties-of-operations-on-uml-class-diagrams.md)
 [UML Class Diagrams: Guidelines](../modeling/uml-class-diagrams-guidelines.md)
