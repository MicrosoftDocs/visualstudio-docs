---
title: Properties of Image Shapes
description: Learn about about image shapes and how you can use image shapes to specify how domain classes appear in a generated designer.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "vs.dsltools.dsldesigner.selectimagedialog"
  - "vs.dsltools.dsldesigner.imageshape"
helpviewer_keywords:
  - "Domain-Specific Language, image shape"
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
  - "multiple"
---
# Properties of Image Shapes

You can use image shapes to specify how domain classes appear in a generated designer. Define an image shape by setting the `Image` property of the class to a predefined image file. The following formats are supported:

- .gif

- .jpg

- .jpeg

- .bmp

- .wmf

- .emf

- .png

By default, designer resource files, such as image files, are located in the **Resources** folder in the **Dsl** project.

For more information, see [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

Image shapes have the properties that are listed in the following table.

|Property|Description|Default|
|-|-|-|
|Fill Color|The fill color of this shape.|White|
|Fill Gradient Mode|The fill gradient mode of this shape.|Horizontal|
|Has Default Connection Points|If `True`, the shape will use top, bottom, left, and right connection points in the generated designer.|False|
|Outline Color|The outline color of this shape.|Black|
|Outline Dash Style|The outline dash style of this shape (Solid, Dash, Dot, DashDot, DashDotDot, or Custom).|Solid|
|Outline Thickness|The outline thickness of this shape.|0.03125|
|Text Color|The color that is used for text decorators that are associated with this shape.|Black|
|Access Modifier|The access modifier of the geometry shape (public or internal).|Public|
|Custom Attributes|Used to add attributes to the source code class that is generated from this shape.|\<none>|
|Generates Double Derived|If `True`, both a base class and a partial class (to support customization through overrides) will be generated. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|False|
|Has Custom Constructor|If `True`, a custom constructor will be provided in the source code. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|False|
|Inheritance Modifier|Describes the kind of inheritance of the source code class that is generated from the image shape (`none`, `abstract` or `sealed`).|none|
|Base Image Shape|The base class of this shape.|(none)|
|Name|The name of this shape.|Current name|
|Namespace|The namespace that is affiliated with this shape.|Current namespace|
|Tooltip Type|The place where the tooltip is defined (fixed, variable, or none). If fixed, then the value of the `Fixed Tooltip Text` property is used as the tooltip; if variable, then the tooltip is defined in custom code.|none|
|Notes|Informal notes that are associated with this shape.|\<none>|
|Initial Height|The initial height of this shape, in inches.|1|
|Initial Width|The initial width of this shape, in inches.|1.5|
|Exposed Fill Color As Property<br /><br /> Exposed Fill Gradient Mode<br /><br /> Exposed Outline Color As Property<br /><br /> Exposed Outline Dash Style As Property<br /><br /> Exposed Outline Thickness As Property<br /><br /> Exposes Text Color|If `True`, the user can set the stated property of a shape. To set this, right-click the shape definition and click **Add Exposed**.|False|
|Description|Used to document the generated designer.|\<none>|
|Display Name|The name that will be displayed in the generated designer for this shape.|\<none>|
|Fixed Tooltip Text|The text that is used for a fixed tooltip.|\<none>|
|Help Keyword|The keyword that is used to index F1 help for this element.|\<none>|
|Image|The path to the image file that is used for this shape.|\<none>|

## See also

- [Domain-Specific Language Tools Glossary](/previous-versions/bb126564(v=vs.100))