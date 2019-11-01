---
title: "Properties of operations on UML class diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.teamarch.logicalclassdiagram.operation.properties"
helpviewer_keywords:
  - "UML, element properties"
ms.assetid: 4128f3e2-3a51-4edf-b3e4-b7f170a32f6b
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of operations on UML class diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

On a UML class diagram, you can add *operations* to classes and interfaces. An operation is a method or function that can be performed by an instance of a class or interface.

 To add an operation, right-click the class or interface, point to **Add**, and then click **Operation**.

 If the operations of a class on the diagram are not visible, click the expand chevron at the top of the class or interface. If you can see the **Operation** header, click **[+]** to expand the operations section.

## Signature of an Operation
 The signature of an operation is the line of text that represents it in a class or interface on a UML class diagram. It has the following form:

 \+ OperationName (parameter1 : Type1 [*], ...) : ReturnType [\*]

 \+ denotes public Visibility. The other permitted values are - (private), # (protected), ~ (package).

 `OperationName` is underlined if the **Is Static** property is true, and is italic if the **Is Abstract** property is true.

 `: ReturnType` is omitted if no return type is defined.

 `[*]` denotes the multiplicity of a parameter or return type. It is omitted if the multiplicity is 1.

 See the next section for a full description of these properties.

## Properties
 These are the properties of an operation in a class or interface on a UML class diagram.

 To see the properties of an operation, right-click the operation in the class or interface on the diagram, and then click **Properties**. The properties appear in the **Properties** window.

|      Property       |   Default    |                                                                                                                                                                                 Description                                                                                                                                                                                 |
|---------------------|--------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|      **Name**       | (a new name) |                                                                                                                                                                Should be unique within the containing type.                                                                                                                                                                 |
|   **Parameters**    |    (none)    |      A list that has the form <em>name</em>**:**<em>Type</em>**,** <em>name</em>**:**<em>Type</em>**, ….** Click **[…]** to edit the list.<br /><br /> The types can be primitive types, or types that are defined in the model. If you enter a name for a new type in this property, a type will be added to the **Unspecified Types** section of UML Model Explorer.      |
|   **Return Type**   |    (none)    |                                                                               **(none)**, or a primitive type, or a type that is defined in the model. If you enter a name for a new type in this property, a type will be added to the **Unspecified Types** section of UML Model Explorer.                                                                                |
| **Postconditions**  |    (none)    |                                                                                                                         An optional condition specifying a relationship between the state of the system before and after the operation's execution.                                                                                                                         |
|  **Preconditions**  |    (none)    |                                                                                                                            An optional condition specifying the assumptions about the state of the system before the operation begins execution.                                                                                                                            |
| **Body Conditions** |    (none)    |                                                                                                                                                       An optional constraint on the values returned by the operation.                                                                                                                                                       |
|   **Visibility**    |    Public    |                  The permitted values, and the characters that appear in the signature are:<br /><br /> **+ Public** - visible globally<br /><br /> **- Private** - not visible outside the owning type<br /><br /> **# Protected** - visible to types derived from the owner<br /><br /> **~ Package** - visible to other types within the same package.                   |
|    **Signature**    |  +*Name*()   |                                                                                      Summarizes the visibility, name, parameters, and return type of this operation. You can change these properties by editing the signature on the diagram, or by editing the individual properties.                                                                                      |
|   **Work Items**    | 0 associated |                                                                                                  Count of associated work items. Read-only.<br /><br /> For more information, see [Link model elements and work items](../modeling/link-model-elements-and-work-items.md).                                                                                                  |
|   **Concurrency**   |  Sequential  | **Sequential** - The operation is or will be designed without concurrency control. Calling this operation concurrently might result in failures.<br /><br /> **Guarded** - The operation will automatically block until other instances of it have completed.<br /><br /> **Concurrent** - The operation is designed so that multiple calls to it can execute concurrently. |
|    **Is Static**    |    False     |                                                                                                  If true, this operation is shared between all instances of this type.<br /><br /> If true, the name of the operation will be underlined where it appears on the diagram.                                                                                                   |
|   **Is Abstract**   |    False     |                                                                                                                                        If true, no code is associated with this operation. Therefore, the owning class is abstract.                                                                                                                                         |
|     **Is Leaf**     |    False     |                                                                                                                                              The designer intends that this operation cannot be overridden in derived classes.                                                                                                                                              |
|    **Is Query**     |    False     |                                                                                                 If true, no significant changes to the state of the system are made by this operation. Therefore, it can be used, for example, in a test to check the state of the system.                                                                                                  |
|  **Multiplicity**   |      1       |                                 **1** - a single value of the specified type.<br /><br /> **0..1** - can be `null`.<br /><br /> \* - a collection of values of the specified type.<br /><br /> **1..\\**\* - a collection containing at least one value.<br /><br /> *n* `..` *m* - a collection that contains between `n` and `m` values.                                  |
|   **Is Ordered**    |    False     |                                                                                                                                             If true, the collection forms a sequential list. For **Multiplicity** more than 1.                                                                                                                                              |
|    **Is Unique**    |    False     |                                                                                                                                         If true, there are no duplicate values in the collection. For **Multiplicity** more than 1.                                                                                                                                         |

## See Also
 [UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)
 [Properties of types on UML class diagrams](../modeling/properties-of-types-on-uml-class-diagrams.md)
 [Properties of attributes on UML class diagrams](../modeling/properties-of-attributes-on-uml-class-diagrams.md)
 [Properties of associations on UML class diagrams](../modeling/properties-of-associations-on-uml-class-diagrams.md)
 [UML Class Diagrams: Guidelines](../modeling/uml-class-diagrams-guidelines.md)
