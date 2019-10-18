---
title: "Supplying Undo Support to Designers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "designers [Visual Studio SDK], undo support"
ms.assetid: 43eb1f14-b129-404a-8806-5bf9b099b67b
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# Supplying Undo Support to Designers
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Designers, like editors, typically need to support undo operations so that users can reverse their recent changes when modifying a code element.  
  
 Most designers implemented in Visual Studio have undo support automatically provided by the environment.  
  
 Designer implementations that need to provide support for the undo feature:  
  
- Provide undo management by implementing the abstract base class <xref:System.ComponentModel.Design.UndoEngine>  
  
- Supply persistence and CodeDOM support by implementing the <xref:System.ComponentModel.Design.Serialization.IDesignerSerializationService> and the <xref:System.ComponentModel.Design.IComponentChangeService> classes.  
  
  For more information on writing designers using [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)], see [Extending Design-Time Support](https://msdn.microsoft.com/library/d6ac8a6a-42fd-4bc8-bf33-b212811297e2).  
  
  The [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] provides a default undo infrastructure by:  
  
- Providing undo management implementations through the <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine> and <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine.UndoUnit> classes.  
  
- Supplying persistence and CodeDOM support through the default <xref:System.ComponentModel.Design.Serialization.CodeDomComponentSerializationService> and <xref:System.ComponentModel.Design.IComponentChangeService> implementations.  
  
## Obtaining Undo Support Automatically  
 Any designer created in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] has automatic and full undo support if, the designer:  
  
- Makes use of a <xref:System.Windows.Forms.Control> based class for its user interface.  
  
- Employs standard CodeDOM-based code generation and parsing system for code generation and persistence.  
  
     For more information on working with Visual Studio CodeDOM support, see [Dynamic Source Code Generation and Compilation](https://msdn.microsoft.com/library/d077a3e8-bd81-4bdf-b6a3-323857ea30fb)  
  
## When to Use Explicit Designer Undo Support  
 Designers must supply their own undo management if they use a graphical user interface, referred to as a view adapter, other than the one supplied by <xref:System.Windows.Forms.Control>.  
  
 An example of this might be creating a product with a web-based graphical design interface rather than a [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] based graphical interface.  
  
 In such cases, one would need to register this view adapter with [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] using <xref:Microsoft.VisualStudio.Shell.Design.ProvideViewAdapterAttribute>, and provide explicit undo management.  
  
 Designers need to provide CodeDOM and persistence support if they do not use the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] code generation model provided in the <xref:System.CodeDom> name space.  
  
## Undo Support Features of the Designer  
 The Environment SDK provides default implementations of interfaces needed to provide undo support that can be used by designers not using <xref:System.Windows.Forms.Control> based classes for their user interfaces or the standard CodeDOM and persistence model.  
  
 The <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine> class derives from the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] <xref:System.ComponentModel.Design.UndoEngine> class using an implementation of the <xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoManager> class to manage undo operations.  
  
 Visual Studio provides the following feature to designer undo:  
  
- Linked undo functionality across multiple designers.  
  
- Child units within a designer can interact with their parents by implementing <xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit> and <xref:Microsoft.VisualStudio.OLE.Interop.IOleParentUndoUnit> on <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine.UndoUnit>.  
  
  The Environment SDK provides CodeDOM and persistence support by supplying:  
  
- <xref:System.ComponentModel.Design.Serialization.CodeDomComponentSerializationService> as an implementations of the <xref:System.ComponentModel.Design.Serialization.IDesignerSerializationService>  
  
  A <xref:System.ComponentModel.Design.IComponentChangeService> provided by the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]``design host.  
  
## Using the Environment SDK Features to Supply Undo Support  
 To obtain undo support, an object implementing a designer must:  
  
- Instantiate and initialize an instance of the <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine> class with a valid <xref:System.IServiceProvider> implementation.  
  
- This <xref:System.IServiceProvider> class must provide the following services:  
  
  - <xref:System.ComponentModel.Design.IDesignerHost>.  
  
  - <xref:System.ComponentModel.Design.Serialization.IDesignerSerializationService>  
  
       Designers using [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] CodeDOM serialization may choose to use <xref:System.ComponentModel.Design.Serialization.CodeDomComponentSerializationService> provided with the [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] as its implementation of the <xref:System.ComponentModel.Design.Serialization.IDesignerSerializationService>.  
  
       In this case, the <xref:System.IServiceProvider> class provided to the <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine> constructor should return this object as an implementation of the <xref:System.ComponentModel.Design.Serialization.IDesignerSerializationService> class.  
  
  - <xref:System.ComponentModel.Design.IComponentChangeService>  
  
       Designers using the default <xref:System.ComponentModel.Design.DesignSurface> provided by the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] design host are guaranteed to have a default implementation of the <xref:System.ComponentModel.Design.IComponentChangeService> class.  
  
  Designers implementing a <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine> based undo mechanism automatically tracks changes if:  
  
- Property changes are made through the <xref:System.ComponentModel.TypeDescriptor> object.  
  
- <xref:System.ComponentModel.Design.IComponentChangeService> events are manually generated when an undoable change is committed.  
  
- Modification on the designer was created within the context of a <xref:System.ComponentModel.Design.DesignerTransaction>.  
  
- The designer chooses to explicitly create undo units using either the standard undo unit provided by an implementation of <xref:System.ComponentModel.Design.UndoEngine.UndoUnit> or the Visual Studio-specific implementation <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine.UndoUnit>, which derives from <xref:System.ComponentModel.Design.UndoEngine.UndoUnit> and also provides an implementation of both <xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit> and <xref:Microsoft.VisualStudio.OLE.Interop.IOleParentUndoUnit>.  
  
## See also  
 <xref:System.ComponentModel.Design.UndoEngine>   
 <xref:Microsoft.VisualStudio.Shell.Design.OleUndoEngine>   
 [Extending Design-Time Support](https://msdn.microsoft.com/library/d6ac8a6a-42fd-4bc8-bf33-b212811297e2)
