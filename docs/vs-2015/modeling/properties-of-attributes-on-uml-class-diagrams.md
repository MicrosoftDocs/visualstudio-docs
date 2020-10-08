---
title: "Properties of attributes on UML class diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.teamarch.logicalclassdiagram.attribute.properties"
helpviewer_keywords:
  - "UML, element properties"
ms.assetid: ba01e064-7424-4e72-98fa-42fa1c30e153
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of attributes on UML class diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

On a UML class diagram, you can add *attributes* to classes and interfaces. An attribute defines values that can be attached to instances of the class or interface.

 To add an attribute, right-click the class or interface, point to **Add**, and then click **Attribute**.

 If the attributes of a class on the diagram are not visible, click the chevron at the top of the class or interface to expand it. If you can see the **Attributes** header, click **[+]** to expand the attributes section.

## Signature of an Attribute
 An attribute's signature is the line that represents it in a class or interface on a UML class diagram. It has this form:

```
+ AttributeName : TypeName [*]
```

 \+ denotes public Visibility. The other permitted values are - (private), # (protected), ~ (package).

 `AttributeName` is underlined if the attribute is static.

 `: TypeName` is omitted if the attribute has no type.

 `[*]` denotes the multiplicity. It is omitted if the multiplicity is 1.

## Properties
 The following table describes the properties of an attribute in a class or interface on a UML class diagram.

 To see the properties of an attribute, right-click the attribute in the class or interface on the diagram, and then click **Properties**. The properties appear in the Properties window.

 To view the properties of an attribute, right-click it and then click **Properties**.

|   **Property**    | **Default**  |                                                                                                                                                                                                         Description                                                                                                                                                                                                          |
|-------------------|--------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Default Value** |   (empty)    |                                                                                                                                                                               The value of the attribute when the classifier is instantiated.                                                                                                                                                                                |
| **Is Read Only**  |    False     |                                                                                                                                                                                    If true, the value of the attribute cannot be changed.                                                                                                                                                                                    |
|   **Is Static**   |    False     |                                                                                                                    If true, a single value for this attribute is shared between all instances of this type.<br /><br /> If true, the name of the attribute is underlined where it appears on the diagram.                                                                                                                    |
|     **Name**      | (a new name) |                                                                                                                                                                                        Should be unique within the owning classifier.                                                                                                                                                                                        |
|     **Type**      |    (none)    |                                                A primitive type such as **Integer**, or a type that is defined in the model. You cannot use non-primitive types such as **Decimal** because the value must be encoded in the metadata. If you enter a name for a new type in this property, a type will be added to the **Unspecified Types** section of UML Model Explorer.                                                 |
|  **Visibility**   |    Public    |                                     The permitted values, and the characters that appear in the signature are as follows:<br /><br /> **+ Public** - visible globally<br /><br /> **- Private** - not visible outside the owning type<br /><br /> **# Protected** - visible to types derived from the owner<br /><br /> **~ Package** - visible to other types within the same package.                                      |
|  **Work Items**   | 0 associated |                                                                                                                          Count of associated work items. Read-only.<br /><br /> For more information, see [Link model elements and work items](../modeling/link-model-elements-and-work-items.md).                                                                                                                           |
|    **Is Leaf**    |    False     |                                                                                                                                                                    If true, it is not intended to allow redefinition of this attribute in derived types.                                                                                                                                                                     |
|  **Is Derived**   |    False     |                                                                                                              If true, this attribute is calculated from other attributes. For example, Diagonal, calculated from Width and Height. The details should be written in the **Description** or an attached Comment.                                                                                                              |
|  **Description**  |   (empty)    |                                                                                                                                                                        For general notes, or for defining constraints on the values in the attribute.                                                                                                                                                                        |
| **Multiplicity**  |      1       | **1** - this attribute has a single value of the specified Type.<br /><br /> **0..1** - this attribute can have a value of `null`.<br /><br /> **\\**\* - this attribute's value is a collection of values.<br /><br /> **1..\\**\* - this attribute's value is a collection that contains at least one value.<br /><br /> *n* **..** *m* - this attribute's value is a collection that contains between *n* and *m* values. |
|  **Is Ordered**   |    False     |                                                                                                                                                                    If true, the collection forms a sequential list. For **Multiplicity** of more than 1.                                                                                                                                                                     |
|   **Is Unique**   |    False     |                                                                                                                                                                If true, there are no duplicate values in the collection. For **Multiplicity** of more than 1.                                                                                                                                                                |

## See Also
 [UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)
 [Properties of types on UML class diagrams](../modeling/properties-of-types-on-uml-class-diagrams.md)
 [Properties of operations on UML class diagrams](../modeling/properties-of-operations-on-uml-class-diagrams.md)
 [UML Class Diagrams: Guidelines](../modeling/uml-class-diagrams-guidelines.md)
 [UML Class Diagrams: Guidelines](../modeling/uml-class-diagrams-guidelines.md)
