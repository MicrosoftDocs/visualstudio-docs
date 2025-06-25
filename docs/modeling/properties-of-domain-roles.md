---
title: Properties of Domain Roles
description: Learn about the properties that are associated with a domain role, like Collection Type, Custom Attributes, and Is Property Browsable.
ms.date: 11/04/2016
ms.topic: reference
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Properties of Domain Roles

The properties in the following table are associated with a domain role. For information about domain roles, see [Understanding Models, Classes and Relationships](../modeling/understanding-models-classes-and-relationships.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

|Property|Description|Default|
|-|-|-|
|Collection Type|If this role has multiplicity of 0..* or 1..\*, this property customizes the generic type that is used to store the collection of links.|`(none)` - <xref:Microsoft.VisualStudio.Modeling.LinkedElementCollection%601> is used|
|Custom Attributes|Attributes that you specify here will be added as attributes to the generated code class.|<none\>|
|Is Property Browsable|If `True`, and if the multiplicity of the relationship is 0..1 or 1..1, the role property can be browsed by the user in the **Properties** window. The property displays the name of the element at the other end of the relationship link.|`True`|
|Is Property Generator|If `True`, a role property is generated for this role, which you can use to traverse the relationship in program code. If you set this false, you can traverse the relationship in a less efficient manner by using static methods of the domain relationship.|`True`|
|Property Getter Access Modifier|The access modifier for the getter for the generated property (`public`, `internal`, `private`, `protected`, or `protected internal`).|`public`|
|Property Setter Access Modifier|The access modifier for the setter for the generated property (`public`, `internal`, `private`, `protected`, or `protected internal`).|`public`|
|Multiplicity|The number of model elements which can play the opposite role (`0..1`, `1..1`, `0..*`, or `1..*`). If the multiplicity is `0..*` or `1..*`, then the generated property represents a collection; otherwise, the generated property represents a single model element.|Depends on the relationship type and whether this is the source or target role in the relationship.|
|Name|The name of the domain role. This property can't contain whitespace.|The name of the domain class of the role player for this role.|
|Propagates Copy|`DoNotPropagateCopy` - The copied role player will have no copy of this link.<br /><br /> `PropagateCopyToLinkOnly` - The copied link points to the existing opposite role player.<br /><br /> `PropagateCopyToLinkAndOppositeRolePlayer` - The copied link points to a copy of the opposite role player.|`PropagateCopyToLinkAndOppositeRolePlayer` for the source roles of embeddings.<br /><br /> `DoNotPropagateCopy` for other roles.<br /><br /> For more information, see [Customizing Copy Behavior](../modeling/customizing-copy-behavior.md)|
|Propagates Delete|`True` to delete the element that plays this role when the associated link is deleted.|`True` for the target of an embedding role.<br /><br /> `False` for other roles.|
|Property Name|The name of the property generated in the code of the role player. This name cannot contain whitespace.|The name of the opposite role if this role has a zero-to-one or a one-to-one multiplicity; otherwise, the pluralized name of the opposite role.|
|Role Player|The domain class of the element that can play this role in the relationship. This property is read-only.|The domain class of the role player for this role.|
|Notes|Informal notes that are associated with the domain role.|<none\>|
|Category|The category under which the generated property appears in the **Properties** window in the generated designer. If this property is empty, then the generated property appears under the **Misc** category|<none\>|
|Description|The description that is used to document code and is used in the UI of the generated designer.<br /><br /> The description appears in the IntelliSense tooltip for the generated property on the role player class.|`Description for` *the full name of the role*|
|Display Name|The name that is displayed in the generated designer for the domain role.|The adjusted value of the Name property.|
|Help Keyword|The optional keyword that is used to index F1 help for the domain role.|\<none>|
|Property Display Name|The name that is displayed in the generated designer for the generated role property.|The adjusted value of the Property Name property.|

> [!NOTE]
> The default value of a display name is based on the associated property value by inserting spaces before each upper-case character that is preceded by a lower-case character and that is not followed by another upper-case character.

## See also

- [Properties of Domain Relationships](../modeling/properties-of-domain-relationships.md)