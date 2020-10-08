---
title: "Properties of a DSL Definition | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
helpviewer_keywords:
  - "Domain-Specific Language, definition file"
ms.assetid: 38debcfe-e1a6-4a3f-9d69-3ab07520f2b6
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of a DSL Definition
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

DslDefinition properties define *domain-specific language* definition properties such as version numbering. The DslDefinition properties appear in the **Properties** window when you click an open area of the diagram in the *Domain-Specific Language Designer*.

 For more information, see [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

 DslDefinition has the properties in the following table:

|Property|Description|Default|
|--------------|-----------------|-------------|
|Access Modifier|Determines if the access modifier for the domain class is public or internal.|public|
|Custom Attributes|Custom defined attributes for the domain class.<br /><br /> **Note** Use the browse button to add an attribute.|\<none>|
|Company Name|The name of the current company name in the system registry.|Current company name|
|Name|The name of this domain class.|Current name|
|Namespace|The namespace affiliated with this domain class.|Current namespace|
|Package Guid|The guid for the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] package generated for this DSL.|\<none>|
|Package Namespace|The namespace for the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] package generated for this DSL.|\<none>|
|Product Name|The name of the product that will be registered for the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] package generated for this DSL.|\<none>|
|Notes|Notes associated with this domain class.|\<none>|
|Description|Description for this domain class.|\<none>|
|Display Name|The name that will be displayed in the generated designer for this domain class.|\<none>|
|Help Keyword|The help keyword associated with this domain class.|\<none>|
|Build|The incremental build number for this domain-specific language definition.|0|
|Major Version|The incremental major build number for this domain-specific language definition.|1|
|Minor Version|The incremental minor build number for this domain-specific language definition.|0|
|Revision|The incremental revision build number for this domain-specific language definition.|0|

## See Also
 [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)
