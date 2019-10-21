---
title: Properties of Connectors
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
  - "Domain-Specific Language, connectors"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Properties of Connectors
Connectors represent domain relationships in a generated designer.

 For more information, see [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

 Connectors have the properties that are listed in the following table.

|Property|Description|Default|
|-|-|-|
|Color|The color of this connector.|Black|
|Dash Style|The dash style for the line for this connector (Solid, Dash, Dot, DashDot, DashDotDot, or Custom).|Solid|
|Source End Style|The source end style for this connector (HollowArrow, EmptyArrow, FilledArrow, EmptyDiamond, FilledDiamond, or None).|None|
|Target End Style|The target end style for this connector (HollowArrow, EmptyArrow, FilledArrow, EmptyDiamond, FilledDiamond, or None).|None|
|Text Color|The color that is used for text decorators that are associated with this connector.|Black|
|Thickness|The thickness of the line for this connector, measured in inches.|0.03125|
|Access Modifier|The level of access of the class (`public` or `internal`).|Public|
|Custom Attributes|Used to add attributes to the source code class that is generated from this connector.|\<none>|
|Generates Double Derived|If `True`, both a base class and a partial class (to support customization through overrides) will be generated. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|False|
|Has Custom Constructor|If `True`, a custom constructor will be provided in the source code. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|False|
|Inheritance Modifier|Describes the kind of inheritance of the source code class that is generated from the connector (`none`, `abstract` or `sealed`).|none|
|Base Connector|The base class of this connector.|(none)|
|Name|The name of this connector.|Current name|
|Namespace|The namespace that is affiliated with this connector.|Current namespace|
|Tooltip Type|How the tooltip is defined (fixed, variable, or none). If fixed, then the value of the `Fixed Tooltip Text` property is used as the tooltip; if variable, then the tooltip is defined in custom code.|\<none>|
|Notes|Informal notes that are associated with this connector.|\<none>|
|Routing Style|The style that is used for routing the connector. A `Rectilinear` connector makes right-angled turns as required; a `Straight` connector does not.|Rectilinear|
|Exposed Color As Property<br /><br /> Exposed Dash Style As Property<br /><br /> Exposed Thickness As Property<br /><br /> Exposes Text Color|If `True`, the user can set the stated property of a shape. To set this, right-click the shape definition and click **Add Exposed**.|False|
|Description|Used to document the generated designer.|\<none>|
|Display Name|The name that will be displayed in the generated designer for this connector.|\<none>|
|Fixed Tooltip Text|The text that is used for a fixed tooltip.|\<none>|
|Help Keyword|The keyword that is used to index F1 help for this element.|\<none>|

## See also

- [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)