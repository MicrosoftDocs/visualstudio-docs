---
title: Properties of Domain Relationships
description: Learn about the properties that are associated with a domain relationship, like Access Modifier, Custom Attributes, and Generates Double Derived.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
  - "Domain-Specific Language, domain relationships"
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Properties of Domain Relationships

The properties in the following table are associated with a domain relationship. For information about domain relationships, see [Understanding Models, Classes and Relationships](../modeling/understanding-models-classes-and-relationships.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

|Property|Description|Default|
|-|-|-|
|Access Modifier|The level of access of the domain relationship (`public` or `internal`).|`public`|
|Custom Attributes|Used to add attributes to the source code class that is generated from the domain relationship.|\<none>|
|Generates Double Derived|If `True`, both a base class and a partial class (to support customization through overrides) is generated. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|`False`|
|Has Custom Constructor|If `True`, indicates that a custom constructor is provided in the source code. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|`False`|
|Inheritance Modifier|Describes the kind of inheritance of the source code class that is generated from the domain relationship (`none`, `abstract` or `sealed`).|\<none>|
|Allows Duplicates|If `True`, duplicate links of the domain relationship may be created between the same two elements.|`False`|
|Base Relationships|If the domain relationship is derived, the base relationship of the domain relationship.|\<none>|
|Is Embedding|If `True`, the domain relationship is an embedding relationship. If `False`, the relationship is a reference relationship.|\<both>|
|Name|The name of the domain relationship.|Current name|
|Namespace|The namespace that is affiliated with the domain relationship.|Current namespace|
|Notes|Informal notes that are associated with the domain relationship.|\<none>|
|Description|The description that is used to document code and is used in the UI of the generated designer.|\<none>|
|Display Name|The name that is displayed in the generated designer for the domain relationship.|\<none>|
|Help Keyword|The optional keyword that is used to index F1 help for the domain relationship.|\<none>|

## See also

- [Domain-Specific Language Tools Glossary](/previous-versions/bb126564(v=vs.100))