---
title: "API Reference for Modeling SDK"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
ms.assetid: 590c9a69-4e22-4841-bb23-f32e80ec1e76
caps.latest.revision: 10
author: jillre
ms.author: jillfra
manager: jillfra
---
# API Reference for Modeling SDK for Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Visual Studio Visualization and Modeling SDK provides the platform on which your domain-specific languages (DSL) and the UML tools are built.

> [!NOTE]
> For information about the UML modeling API, see [API Reference for UML Modeling Extensibility](../modeling/api-reference-for-uml-modeling-extensibility.md). For information about text transformation, see [Customizing T4 Text Transformation](../modeling/customizing-t4-text-transformation.md).

 This section contains reference material for namespaces that have names that begin with "Microsoft.VisualStudio.Modeling".

|Namespace|Content|
|---------------|-------------|
|<xref:Microsoft.VisualStudio.Modeling?displayProperty=fullName>|Classes such as ModelElement, which is the base class of all domain classes that you define in a DSL.|
|<xref:Microsoft.VisualStudio.Modeling.Design?displayProperty=fullName>|Classes that form part of a DSL definition.|
|<xref:Microsoft.VisualStudio.Modeling.Diagnostics?displayProperty=fullName>|The model Store Viewer and performance measurement tools.|
|<xref:Microsoft.VisualStudio.Modeling.Diagrams?displayProperty=fullName>|Classes such as ShapeElement, which is the base class of all shapes that you define in a DSL.|
|<xref:Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement?displayProperty=fullName>|Gesture and Selection methods.|
|<xref:Microsoft.VisualStudio.Modeling.DslDefinition?displayProperty=fullName>|The API of the DSL Definition designer.|
|<xref:Microsoft.VisualStudio.Modeling.DslDefinition.Design?displayProperty=fullName>|Internal classes of the DSL Definition designer.|
|<xref:Microsoft.VisualStudio.Modeling.DslDefinition.ExtensionEnablement?displayProperty=fullName>|Attributes that allow you to extend the DSL designer with commands, gestures and validation.|
|<xref:Microsoft.VisualStudio.Modeling.Extensibility?displayProperty=fullName>|Extension methods for ModelElement that implement DSL Extensibility.|
|<xref:Microsoft.VisualStudio.Modeling.ExtensionEnablement?displayProperty=fullName>|Extensibility attributes|
|<xref:Microsoft.VisualStudio.Modeling.Immutability?displayProperty=fullName>|Lets you make parts of a model read-only.|
|[Microsoft.VisualStudio.Modeling.Integration](/previous-versions/ee904412(v=vs.140))|The Modelbus API, which helps you integrate different models.|
|[Microsoft.VisualStudio.Modeling.Integration.Picker](/previous-versions/ee904394(v=vs.140))|The dialog box that lets users navigate to models and elements to create Modelbus references.|
|`Microsoft.VisualStudio.Modeling.Integration.Picker.Hosting`|The Picker service.|
|[Microsoft.VisualStudio.Modeling.Integration.Shell](/previous-versions/ee869435(v=vs.140))|Modelbus adapter framework for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|
|[Microsoft.VisualStudio.Modeling.Integration.Shell.Picker](/previous-versions/ee886769(v=vs.140))|The Picker dialog box that lets users navigate to models and elements to create Modelbus references.|
|<xref:Microsoft.VisualStudio.Modeling.Shell?displayProperty=fullName>|The interface between DSLs and [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|
|<xref:Microsoft.VisualStudio.Modeling.Shell.ExtensionEnablement?displayProperty=fullName>|Lets you define shortcut (context) menu commands.|
|<xref:Microsoft.VisualStudio.Modeling.Validation?displayProperty=fullName>|Lets you define validation constraints.|

## See also

- [API Reference for UML Modeling Extensibility](../modeling/api-reference-for-uml-modeling-extensibility.md)
- [Customizing T4 Text Transformation](../modeling/customizing-t4-text-transformation.md)
