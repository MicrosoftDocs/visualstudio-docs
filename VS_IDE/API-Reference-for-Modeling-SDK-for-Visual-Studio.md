---
title: "API Reference for Modeling SDK for Visual Studio"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 590c9a69-4e22-4841-bb23-f32e80ec1e76
caps.latest.revision: 8
manager: kamrani
---
# API Reference for Modeling SDK for Visual Studio
The Visual Studio Visualization and Modeling SDK provides the platform on which your domain-specific languages (DSL) and the UML tools are built.  
  
> [!NOTE]
>  For information about the UML modeling API, see [API Reference for UML Modeling Extensibility](../VS_IDE/API-Reference-for-UML-Modeling-Extensibility.md). For information about text transformation, see [Customizing T4 Text Transformation](../VS_IDE/Customizing-T4-Text-Transformation.md).  
  
 This section contains reference material for namespaces that have names that begin with "Microsoft.VisualStudio.Modeling".  
  
|Namespace|Content|  
|---------------|-------------|  
|<xref:Microsoft.VisualStudio.Modeling?qualifyHint=True>|Classes such as ModelElement, which is the base class of all domain classes that you define in a DSL.|  
|<xref:Microsoft.VisualStudio.Modeling.Design?qualifyHint=True>|Classes that form part of a DSL definition.|  
|<xref:Microsoft.VisualStudio.Modeling.Diagnostics?qualifyHint=True>|The model Store Viewer and performance measurement tools.|  
|<xref:Microsoft.VisualStudio.Modeling.Diagrams?qualifyHint=True>|Classes such as ShapeElement, which is the base class of all shapes that you define in a DSL.|  
|<xref:Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement?qualifyHint=True>|Gesture and Selection methods.|  
|<xref:Microsoft.VisualStudio.Modeling.DslDefinition?qualifyHint=True>|The API of the DSL Definition designer.|  
|<xref:Microsoft.VisualStudio.Modeling.DslDefinition.Design?qualifyHint=True>|Internal classes of the DSL Definition designer.|  
|<xref:Microsoft.VisualStudio.Modeling.DslDefinition.ExtensionEnablement?qualifyHint=True>|Attributes that allow you to extend the DSL designer with commands, gestures and validation.|  
|<xref:Microsoft.VisualStudio.Modeling.Extensibility?qualifyHint=True>|Extension methods for ModelElement that implement DSL Extensibility.|  
|<xref:Microsoft.VisualStudio.Modeling.ExtensionEnablement?qualifyHint=True>|Extensibility attributes|  
|<xref:Microsoft.VisualStudio.Modeling.Immutability?qualifyHint=True>|Lets you make parts of a model read-only.|  
|<xref:Microsoft.VisualStudio.Modeling.Integration?qualifyHint=True>|The Modelbus API, which helps you integrate different models.|  
|<xref:Microsoft.VisualStudio.Modeling.Integration.Picker?qualifyHint=True>|The dialog box that lets users navigate to models and elements to create Modelbus references.|  
|<xref:Microsoft.VisualStudio.Modeling.Integration.Picker.Hosting?qualifyHint=True>|The Picker service.|  
|<xref:Microsoft.VisualStudio.Modeling.Integration.Shell?qualifyHint=True>|Modelbus adapter framework for Visual Studio.|  
|<xref:Microsoft.VisualStudio.Modeling.Integration.Shell.Picker?qualifyHint=True>|The Picker dialog box that lets users navigate to models and elements to create Modelbus references.|  
|<xref:Microsoft.VisualStudio.Modeling.Shell?qualifyHint=True>|The interface between DSLs and Visual Studio.|  
|<xref:Microsoft.VisualStudio.Modeling.Shell.ExtensionEnablement?qualifyHint=True>|Lets you define shortcut (context) menu commands.|  
|<xref:Microsoft.VisualStudio.Modeling.Validation?qualifyHint=True>|Lets you define validation constraints.|  
  
## See Also  
 [API Reference for UML Modeling Extensibility](../VS_IDE/API-Reference-for-UML-Modeling-Extensibility.md)   
 [Customizing T4 Text Transformation](../VS_IDE/Customizing-T4-Text-Transformation.md)