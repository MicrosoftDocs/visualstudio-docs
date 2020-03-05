---
title: "Properties of Diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.dsltools.dsldesigner.dsldiagram"
helpviewer_keywords:
  - "Domain-Specific Language, diagram"
ms.assetid: 00bba4b8-6aa6-4027-96cb-4f4c41a77d3c
caps.latest.revision: 27
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of Diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can set properties that specify how diagrams will appear in the generated designer. For example, you can specify a default color for text in the diagram.

 For more information, see [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

 The following table lists the properties of diagrams.

|Property|Description|Default|
|--------------|-----------------|-------------|
|Fill Color|The fill color for the diagram.|White|
|Text Color|The color of the text that is displayed on the diagram.|Black|
|Access Modifier|The access modifier of the class (public or internal).|Public|
|Custom Attributes|Used to add attributes to the generated code class.|\<none>|
|Generates Double Derived|If `True`, both a base class and a partial class (to support customization through overrides) will be generated. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|False|
|Has Custom Constructor|If `True`, a custom constructor will be provided in the source code. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md)..|False|
|Inheritance Modifier|Describes the kind of inheritance of the source code class that is generated from the diagram (`none`, `abstract` or `sealed`).|None|
|Base Diagram|The base class of this diagram.|(none)|
|Name|The name of this diagram.|Current name|
|Namespace|The namespace that is affiliated with this diagram.|Current namespace|
|Class Represented|The root domain class that this diagram represents.|Current root class if applicable|
|Notes|Informal notes that are associated with this element.|\<none>|
|Exposes Fill Color As Property|If `True`, the user can set the fill color of the diagram of the generated designer. To set this, right click the diagram shape and click **Add Explosed**.|False|
|Exposes Text Color As Property|If `True`, the user can set the text color of the diagram in the generated designer. To set this, right click the diagram shape and click **Add Explosed**.|False|
|Description|The description that is used to document the generated designer.|\<none>|
|Display Name|The name that will be displayed in the generated designer for this diagram.|\<none>|
|Help Keyword|The keyword that is used to index F1 help for this diagram.|\<none>|

## See Also
 [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)
