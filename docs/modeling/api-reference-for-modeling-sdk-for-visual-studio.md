---
title: "API Reference for Modeling SDK for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 590c9a69-4e22-4841-bb23-f32e80ec1e76
caps.latest.revision: 8
author: "alancameronwills"
ms.author: "awills"
manager: "douge"
---
# API Reference for Modeling SDK for Visual Studio
The Visual Studio Visualization and Modeling SDK provides the platform on which your domain-specific languages (DSL) and the UML tools are built.  
  
> [!NOTE]
>  For information about the UML modeling API, see [API Reference for UML Modeling Extensibility](../modeling/api-reference-for-uml-modeling-extensibility.md). For information about text transformation, see [Customizing T4 Text Transformation](../modeling/customizing-t4-text-transformation.md).  
  
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
|<xref:Microsoft.VisualStudio.Modeling.Integration?displayProperty=fullName>|The Modelbus API, which helps you integrate different models.|  
|<xref:Microsoft.VisualStudio.Modeling.Integration.Picker?displayProperty=fullName>|The dialog box that lets users navigate to models and elements to create Modelbus references.|  
|<xref:Microsoft.VisualStudio.Modeling.Integration.Picker.Hosting?displayProperty=fullName>|The Picker service.|  
|<xref:Microsoft.VisualStudio.Modeling.Integration.Shell?displayProperty=fullName>|Modelbus adapter framework for [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].|  
|<xref:Microsoft.VisualStudio.Modeling.Integration.Shell.Picker?displayProperty=fullName>|The Picker dialog box that lets users navigate to models and elements to create Modelbus references.|  
|<xref:Microsoft.VisualStudio.Modeling.Shell?displayProperty=fullName>|The interface between DSLs and [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].|  
|<xref:Microsoft.VisualStudio.Modeling.Shell.ExtensionEnablement?displayProperty=fullName>|Lets you define shortcut (context) menu commands.|  
|<xref:Microsoft.VisualStudio.Modeling.Validation?displayProperty=fullName>|Lets you define validation constraints.|  
  
## See Also  
 [API Reference for UML Modeling Extensibility](../modeling/api-reference-for-uml-modeling-extensibility.md)   
 [Customizing T4 Text Transformation](../modeling/customizing-t4-text-transformation.md)