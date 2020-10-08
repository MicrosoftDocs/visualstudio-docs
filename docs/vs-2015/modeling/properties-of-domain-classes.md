---
title: "Properties of Domain Classes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
helpviewer_keywords:
  - "Domain-Specific Language, domain class"
ms.assetid: a3993995-19e7-4761-a972-b1de89131a1b
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of Domain Classes
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Domain classes have the properties in the following table. For information about domain classes, see [Understanding Models, Classes and Relationships](../modeling/understanding-models-classes-and-relationships.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

|Property|Description|Default|
|--------------|-----------------|-------------|
|Access Modifier|The level of access of the domain class (`public` or `internal`).|`public`|
|Custom Attributes|Used to add attributes to the source code class that is generated from this domain class.|\<none>|
|Generates Double Derived|If `True`, both a base class and a partial class (to support customization through overrides) will be generated. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|`False`|
|Has Custom Constructor|If `True`, a custom constructor will be provided in the source code. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|`False`|
|Inheritance Modifier|Describes the kind of inheritance of the source code class that is generated from the domain class (`none`, `abstract` or `sealed`).|`none`|
|Base Class|If this domain class is derived, the name of the base class.|\<none>|
|Name|The name of this domain class.|Current name|
|Namespace|The namespace of this domain class.|Current namespace|
|Notes|Informal notes that are associated with this domain class.|\<none>|
|Description|The description that is used to document the UI of the generated designer.|\<none>|
|Display Name|The name that will be displayed in the generated designer for this domain class.|\<none>|
|Help Keyword|The optional keyword that is used to index F1 help for this domain class.|\<none>|

## See Also
 [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)
