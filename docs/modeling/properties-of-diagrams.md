---
title: Properties of diagrams
description: Learn about diagrams and how you can set properties that specify how diagrams will appear in the generated designer.
ms.custom: SEO-VS-2020
ms.date: 10/31/2018
ms.topic: reference
f1_keywords:
- vs.dsltools.dsldesigner.dsldiagram
helpviewer_keywords:
- Domain-Specific Language, diagram
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
- multiple
---
# Properties of diagrams
You can set properties that specify how diagrams will appear in the generated designer. For example, you can specify a default color for text in the diagram.

 For more information, see [How to define a domain-specific language](../modeling/how-to-define-a-domain-specific-language.md). For more information about how to use these properties, see [Customize and extend a domain-specific language](../modeling/customizing-and-extending-a-domain-specific-language.md).

 The following table lists the properties of diagrams.

|Property|Description|Default|
|-|-|-|
|Fill Color|The fill color for the diagram.|White|
|Text Color|The color of the text that is displayed on the diagram.|Black|
|Access Modifier|The access modifier of the class (public or internal).|Public|
|Custom Attributes|Used to add attributes to the generated code class.|\<none>|
|Generates Double Derived|If `True`, both a base class and a partial class (to support customization through overrides) will be generated. For more information, see [Override and extend the generated classes](../modeling/overriding-and-extending-the-generated-classes.md).|False|
|Has Custom Constructor|If `True`, a custom constructor will be provided in the source code. For more information, see [Override and extend the generated classes](../modeling/overriding-and-extending-the-generated-classes.md)..|False|
|Inheritance Modifier|Describes the kind of inheritance of the source code class that is generated from the diagram (`none`, `abstract`, or `sealed`).|None|
|Base Diagram|The base class of this diagram.|(none)|
|Name|The name of this diagram.|Current name|
|Namespace|The namespace that is affiliated with this diagram.|Current namespace|
|Class Represented|The root domain class that this diagram represents.|Current root class if applicable|
|Notes|Informal notes that are associated with this element.|\<none>|
|Exposes Fill Color As Property|If `True`, the user can set the fill color of the diagram of the generated designer. To set this property, right-click the diagram shape and click **Add Exposed**.|False|
|Exposes Text Color As Property|If `True`, the user can set the text color of the diagram in the generated designer. To set this property, right-click the diagram shape and click **Add Exposed**.|False|
|Description|The description that is used to document the generated designer.|\<none>|
|Display Name|The name that will be displayed in the generated designer for this diagram.|\<none>|
|Help Keyword|The keyword that is used to index F1 help for this diagram.|\<none>|

## See also

[Domain-specific language tools glossary](/previous-versions/bb126564(v=vs.100))