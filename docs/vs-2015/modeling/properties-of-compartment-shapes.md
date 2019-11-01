---
title: "Properties of Compartment Shapes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.dsltools.dsldesigner.compartmentshape"
helpviewer_keywords:
  - "Domain-Specific Language, compartment shape"
ms.assetid: 9a9e112d-210d-413b-a44f-0e976a4a78bc
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of Compartment Shapes
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Compartment shapes are one of the shapes you can use to display a domain class in a domain-specific language. You can expand and collapse the compartments.

 For more information, see [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

 Compartment shapes have the properties that are listed in the following table.

|Property|Description|Default|
|--------------|-----------------|-------------|
|Default Expand Collapse State|If `Expanded`, the compartments are shown on creation. If `Collapsed`, they are not.|Expanded|
|Fill Color|The fill color of this shape.|White|
|Fill Gradient Mode|The fill gradient mode of this shape.|Horizontal|
|Geometry|The geometry of this shape (Rectangle or Rounded Rectangle).|Rectangle|
|Has Default Connection Points|If `True`, the shape will use top, bottom, left, and right connection points in the generated designer.|False|
|Is Single Compartment Header Visible|If `False`, and the shape has a single compartment, the header of the compartment is not visible.|True|
|Outline Color|The outline color of this shape.|Black|
|Outline Dash Style|The outline dash style of this shape (Solid, Dash, Dot, DashDot, DashDotDot, Custom).|Solid|
|Outline Thickness|The outline thickness of this shape.|0.03125|
|Text Color|The color used for text decorators that are associated with this shape.|Black|
|Access Modifier|The level of access of the compartment shape (`public` or `internal`).|Public|
|Custom Attributes|Used to add attributes to the source code class that is generated from this compartment shape|\<none>|
|Generates Double Derived|If `True`, both a base class and a partial class (to support customization through overrides) will be generated. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|False|
|Has Custom Constructor|If `True`, a custom constructor will be provided in the source code. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|False|
|Inheritance Modifier|Describes the kind of inheritance of the source code class that is generated from the compartment shape (`none`, `abstract` or `sealed`).|None|
|Base Compartment Shape|The base class of this shape.|(none)|
|Name|The name of this shape.|Current name|
|Namespace|The namespace that is affiliated with this shape.|Current namespace|
|Tooltip Type|How the tooltip is defined (fixed, variable, or none). If fixed, then the value of the `Fixed Tooltip Text` property is used as the tooltip; if variable, then the tooltip is defined in custom code.|none|
|Notes|Informal notes that are associated with this shape.|\<none>|
|Initial Height|The initial height of this shape, in inches. For compartment shapes, this is the height of the header section only and it cannot be resized.|1|
|Initial Width|The initial width of this shape, in inches.|1.5|
|Exposed Fill Color As Property<br /><br /> Exposed Fill Gradient Mode<br /><br /> Exposed Outline Color As Property<br /><br /> Exposed Outline Dash Style As Property<br /><br /> Exposed Outline Thickness As Property<br /><br /> Exposes Text Color|If `True`, the user can set the stated property of a shape. To set this, right-click the shape definition and click **Add Exposed**.|False|
|Description|Used to document the generated designer.|\<none>|
|Display Name|The name that will be displayed in the generated designer for this shape.|\<none>|
|Fixed Tooltip Text|The text that is used for a fixed tooltip.|\<none>|
|Help Keyword|The keyword that is used to index F1 help for this shape.|\<none>|

## See Also
 [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)
