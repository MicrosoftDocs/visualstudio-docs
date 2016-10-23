---
title: "Properties of Domain Classes"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a3993995-19e7-4761-a972-b1de89131a1b
caps.latest.revision: 21
manager: kamrani
---
# Properties of Domain Classes
Domain classes have the properties in the following table. For information about domain classes, see [Understanding Models, Classes and Relationships](../VS_IDE/Understanding-Models--Classes-and-Relationships.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../VS_IDE/Customizing-and-Extending-a-Domain-Specific-Language.md).  
  
|Property|Description|Default|  
|--------------|-----------------|-------------|  
|Access Modifier|The level of access of the domain class (`public` or `internal`).|`public`|  
|Custom Attributes|Used to add attributes to the source code class that is generated from this domain class.|<none\>|  
|Generates Double Derived|If `True`, both a base class and a partial class (to support customization through overrides) will be generated. For more information, see [Overriding and Extending the Generated Classes](../VS_IDE/Overriding-and-Extending-the-Generated-Classes.md).|`False`|  
|Has Custom Constructor|If `True`, a custom constructor will be provided in the source code. For more information, see [Overriding and Extending the Generated Classes](../VS_IDE/Overriding-and-Extending-the-Generated-Classes.md).|`False`|  
|Inheritance Modifier|Describes the kind of inheritance of the source code class that is generated from the domain class (`none`, `abstract` or `sealed`).|`none`|  
|Base Class|If this domain class is derived, the name of the base class.|<none\>|  
|Name|The name of this domain class.|Current name|  
|Namespace|The namespace of this domain class.|Current namespace|  
|Notes|Informal notes that are associated with this domain class.|<none\>|  
|Description|The description that is used to document the UI of the generated designer.|<none\>|  
|Display Name|The name that will be displayed in the generated designer for this domain class.|<none\>|  
|Help Keyword|The optional keyword that is used to index F1 help for this domain class.|<none\>|  
  
## See Also  
 [Domain-Specific Language Tools Glossary](assetId:///ca5e84cb-a315-465c-be24-76aa3df276aa)