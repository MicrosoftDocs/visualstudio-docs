---
title: "Properties of Swimlanes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.dsltools.dsldesigner.swimlane"
helpviewer_keywords:
  - "Domain-Specific Language, swimlane"
ms.assetid: 47edbc2d-09e4-48ac-b4d1-5268a06a27e6
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties of Swimlanes
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can add swimlanes to a diagram. Swimlanes divide a diagram into vertical or horizontal areas. You can define other shapes to be displayed inside swimlanes. For more information, see [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

 Swimlanes have the properties that are listed in the following table.

|Property|Description|Default|
|--------------|-----------------|-------------|
|Body Fill Color|The fill color for the body of the swimlane.|White|
|Header Fill Color|The fill color for the header of the swimlane.|DarkGray|
|Separator Color|The color of the separator line.|LightGray|
|Separator Line Style|The style of the separator line (`Solid`, `Dash`, `Dot`, `DashDot`, `DashDotDot`, or `Custom`).|`Dash`|
|Separator Thickness|The thickness of the separator line in inches.|0.03125|
|Text Color|The color that is used for text decorators that are associated with this swimlane.|Black|
|Access Modifier|The level of access of the class (`public` or `internal`).|Public|
|Custom Attributes|Used to add attributes to the code class that is generated from this swimlane.|\<none>|
|Generates Double Derived|If `True`, both a base class and a partial class (to support customization through overrides) will be generated. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|False|
|Has Custom Constructor|If `True`, a custom constructor will be provided in the source code. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).|False|
|Inheritance Modifier|Describes the kind of inheritance of the source code class that is generated from the swimlane (`none`, `abstract` or `sealed`).|none|
|Base Swimlane|The base class of this swimlane.|(none)|
|Name|The name of this swimlane.|Current name|
|Namespace|The namespace that is affiliated with this swimlane.|Current namespace|
|Tooltip Type|How the tooltip is defined (`fixed`, `variable`, or `none`). If `fixed`, then the value of the `Fixed Tooltip Text` property is used; if `variable`, then the tooltip is defined in custom code.|\<none>|
|Notes|Informal notes that are associated with this swimlane.|\<none>|
|Alignment|Horizontal or vertical alignment.|Vertical|
|Initial Height|The initial height of this swimlane, in inches. Applicable only to horizontal swimlanes.|0|
|Initial Width|The initial width of this swimlane, in inches. Applicable only to vertical swimlanes.|0|
|Exposes Text Color|If `True`, the user can set the color of a swimlane in the generated designer. To set this, right-click the swimlane shape and click **Add Exposed**.|False|
|Description|Used to document the generated designer.|\<none>|
|Display Name|The name that will be displayed in the generated designer to refer to this swimlane class.|\<none>|
|Fixed Tooltip Text|The text that is used for a fixed tooltip.|\<none>|
|Help Keyword|The keyword that is used to index F1 help for this swimlane.|\<none>|

## See Also
 [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)
