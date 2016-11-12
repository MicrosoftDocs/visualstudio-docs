---
title: "Supplying Undo Support to Designers | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "designers [Visual Studio SDK], undo support"
ms.assetid: 43eb1f14-b129-404a-8806-5bf9b099b67b
caps.latest.revision: 17
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Supplying Undo Support to Designers
Designers, like editors, typically need to support undo operations so that users can reverse their recent changes when modifying a code element.  
  
 Most designers implemented in Visual Studio have undo support automatically provided by the environment.  
  
 Designer implementations that need to provide support for the undo feature:  
  
-   Provide undo management by implementing the abstract base class <xref:System.ComponentModel.Design.UndoEngine>  
  
-   Supply persistence and CodeDOM support by implementing the <xref:System.ComponentModel.Design.Serialization.IDesignerSerializationService> and the <xref:System.ComponentModel.Design.IComponentChangeService> classes.  
  
 For more information on writing designers using [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)], see [Extending Design-Time Support](../Topic/Extending%20Design-Time%20Support.md).  
  
 The [!INCLUDE[vsipsdk](../extensibility/includes/vsipsdk_md.md)] provides a default undo infrastructure by:  
  
-   Providing undo management implementations through the <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine> and <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine.UndoUnit> classes.  
  
-   Supplying persistence and CodeDOM support through the default <xref:System.ComponentModel.Design.Serialization.CodeDomComponentSerializationService> and <xref:System.ComponentModel.Design.IComponentChangeService> implementations.  
  
## Obtaining Undo Support Automatically  
 Any designer created in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] has automatic and full undo support if, the designer:  
  
-   Makes use of a <xref:System.Windows.Forms.Control> based class for its user interface.  
  
-   Employs standard CodeDOM-based code generation and parsing system for code generation and persistence.  
  
     For more information on working with Visual Studio CodeDOM support, see [Dynamic Source Code Generation and Compilation](../Topic/Dynamic%20Source%20Code%20Generation%20and%20Compilation.md)  
  
## When to Use Explicit Designer Undo Support  
 Designers must supply their own undo management if they use a graphical user interface, referred to as a view adapter, other than the one supplied by <xref:System.Windows.Forms.Control>.  
  
 An example of this might be creating a product with a web-based graphical design interface rather than a [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] based graphical interface.  
  
 In such cases, one would need to register this view adapter with [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] using <xref:Microsoft.VisualStudio.Shell.Design.ProvideViewAdapterAttribute>, and provide explicit undo management.  
  
 Designers need to provide CodeDOM and persistence support if they do not use the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] code generation model provided in the <xref:System.CodeDom> name space.  
  
## Undo Support Features of the Designer  
 The Environment SDK provides default implementations of interfaces needed to provide undo support that can be used by designers not using <xref:System.Windows.Forms.Control> based classes for their user interfaces or the standard CodeDOM and persistence model.  
  
 The <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine> class derives from the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] <xref:System.ComponentModel.Design.UndoEngine> class using an implementation of the <xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoManager> class to manage undo operations.  
  
 Visual Studio provides the following feature to designer undo:  
  
-   Linked undo functionality across multiple designers.  
  
-   Child units within a designer can interact with their parents by implementing <xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit> and <xref:Microsoft.VisualStudio.OLE.Interop.IOleParentUndoUnit> on <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine.UndoUnit>.  
  
 The Environment SDK provides CodeDOM and persistence support by supplying:  
  
-   <xref:System.ComponentModel.Design.Serialization.CodeDomComponentSerializationService> as an implementations of the <xref:System.ComponentModel.Design.Serialization.IDesignerSerializationService>  
  
 A <xref:System.ComponentModel.Design.IComponentChangeService> provided by the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]``design host.  
  
## Using the Environment SDK Features to Supply Undo Support  
 To obtain undo support, an object implementing a designer must:  
  
-   Instantiate and initialize an instance of the <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine> class with a valid <xref:System.IServiceProvider> implementation.  
  
-   This <xref:System.IServiceProvider> class must provide the following services:  
  
    -   <xref:System.ComponentModel.Design.IDesignerHost>.  
  
    -   <xref:System.ComponentModel.Design.Serialization.IDesignerSerializationService>  
  
         Designers using [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] CodeDOM serialization may choose to use <xref:System.ComponentModel.Design.Serialization.CodeDomComponentSerializationService> provided with the [!INCLUDE[vsipsdk](../extensibility/includes/vsipsdk_md.md)] as its implementation of the <xref:System.ComponentModel.Design.Serialization.IDesignerSerializationService>.  
  
         In this case, the <xref:System.IServiceProvider> class provided to the <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine> constructor should return this object as an implementation of the <xref:System.ComponentModel.Design.Serialization.IDesignerSerializationService> class.  
  
    -   <xref:System.ComponentModel.Design.IComponentChangeService>  
  
         Designers using the default <xref:System.ComponentModel.Design.DesignSurface> provided by the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] design host are guaranteed to have a default implementation of the <xref:System.ComponentModel.Design.IComponentChangeService> class.  
  
 Designers implementing a <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine> based undo mechanism automatically tracks changes if:  
  
-   Property changes are made through the <xref:System.ComponentModel.TypeDescriptor> object.  
  
-   <xref:System.ComponentModel.Design.IComponentChangeService> events are manually generated when an undoable change is committed.  
  
-   Modification on the designer was created within the context of a <xref:System.ComponentModel.Design.DesignerTransaction>.  
  
-   The designer chooses to explicitly create undo units using either the standard undo unit provided by an implementation of <xref:System.ComponentModel.Design.UndoEngine.UndoUnit> or the Visual Studio-specific implementation <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine.UndoUnit>, which derives from <xref:System.ComponentModel.Design.UndoEngine.UndoUnit> and also provides an implementation of both <xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit> and <xref:Microsoft.VisualStudio.OLE.Interop.IOleParentUndoUnit>.  
  
## See Also  
 <xref:System.ComponentModel.Design.UndoEngine>   
 <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine>   
 [Extending Design-Time Support](../Topic/Extending%20Design-Time%20Support.md)