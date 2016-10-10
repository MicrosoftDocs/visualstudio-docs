---
title: "Programming with the UML API"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c5937139-49d0-4439-8a9f-89f5e0474618
caps.latest.revision: 19
manager: kamrani
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Programming with the UML API
The UML API of Visual Studio lets you write code to create, read, and update UML models and diagrams. To see which versions of Visual Studio support UML models, see [Version support for architecture and modeling tools](../VS_IDE/What-s-new-for-design-in-Visual-Studio.md#VersionSupport).  
  
 In addition to the API reference pages, the following topics describe the API.  
  
|Topic|Example types and methods described|Features described|  
|-----------|-----------------------------------------|------------------------|  
|[Navigate relationships with the UML API](../VS_IDE/Navigate-relationships-with-the-UML-API.md)|UML elements and their properties and associations. For example, IElement and its descendants, including: IClass, IActivity, IUseCase, IComponent, IInteraction, IModel, IPackage|In Visual Studio, UML models conform to the UML specification version 2.1.2, which can be obtained at the [UML Resource Page](http://go.microsoft.com/fwlink/?LinkId=160796). Each type is an interface that has the same name as the UML type, prefixed with "I".|  
|[Create elements and relationships in UML models](../VS_IDE/Create-elements-and-relationships-in-UML-models.md)|IPackage.CreateClass()<br /><br /> IClass.CreateOperation()|Each element type has methods for creating its children.|  
|[Display a UML model on diagrams](../VS_IDE/Display-a-UML-model-on-diagrams.md)|IShape, IDiagram<br /><br /> IShape.Move()|Each element in a model can be represented as a shape on a diagram. In some cases, you can create new shapes for each object. You can move, resize, color, and collapse or expand these shapes.|  
|[Navigate the UML model](../VS_IDE/Navigate-the-UML-model.md)|IModelStore<br /><br /> IDiagramContext|The Model Store stores the model.<br /><br /> The Diagram Context gives you access to the current diagram and store.|  
|[Link UML model updates by using transactions](../VS_IDE/Link-UML-model-updates-by-using-transactions.md)|ILinkedUndoContext|You can link a series of changes into one transaction.|  
|[Define a menu command on a modeling diagram](../VS_IDE/Define-a-menu-command-on-a-modeling-diagram.md)|IMenuCommand<br /><br /> IGestureExtension<br /><br /> ICommandExtension|You can extend a diagram's functionality by defining commands invoked by double-clicking and by dragging onto the diagram.|  
|[Define validation constraints for UML models](../VS_IDE/Define-validation-constraints-for-UML-models.md)|ValidationContext|You can define validation rules that help you make sure that a model conforms to specified constraints.|  
|[Get UML model elements from IDataObject](../VS_IDE/Get-UML-model-elements-from-IDataObject.md)|IElement, IShape|When an element is dragged from UML Model Explorer or a UML diagram to another diagram or application, it is serialized as an IDataObject.|  
|[Edit UML sequence diagrams by using the UML API](../VS_IDE/Edit-UML-sequence-diagrams-by-using-the-UML-API.md)|IInteraction, ILifeline, IMessage|Creating and updating an interaction diagram is slightly different from working with the other diagram types.|  
|[Extend layer diagrams](../VS_IDE/Extend-layer-diagrams.md)|ILayer, ILayerDiagram|You can write code to create and edit layer diagrams, and also validate program code against them.|  
  
## About the Implementation  
 The UML modeling tools are built on Domain-Specific Language Tools. Each package and each diagram is represented by a Domain-Specific Language Tools model, and a collection of rules and other methods maintains consistency between them.  
  
 Types from that platform are visible in some of the assemblies that you reference in order to write UML extensions. Although you can make extensions to the UML tools by accessing the Domain-Specific Language Tools API, you should bear the following considerations in mind:  
  
-   You might find that some apparently simple changes introduce inconsistencies and unexpected effects.  
  
-   The implementation may change in the future, so that adaptations you make using the Domain-Specific Language Tools API might no longer work.  
  
## The API assemblies  
 This table summarizes the assemblies that provide extensibility for the UML tools, and the namespaces that you are recommended to use.  
  
|Assembly|Namespaces|Provides access to:|  
|--------------|----------------|-------------------------|  
|Microsoft.VisualStudio.Uml.Interfaces|(All)|The UML types.|  
|Microsoft.VisualStudio.ArchitectureTools.Extensibility|<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml?qualifyHint=False>|[Creation methods](../VS_IDE/Create-elements-and-relationships-in-UML-models.md)|  
||<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation?qualifyHint=False>|[Diagrams and Shapes](../VS_IDE/Display-a-UML-model-on-diagrams.md)|  
||<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility?qualifyHint=False>|[The modeling project](../VS_IDE/Read-a-UML-model-in-program-code.md)|  
|Microsoft.VisualStudio.Modeling.Sdk.[version]|<xref:Microsoft.VisualStudio.Modeling.ExtensionEnablement?qualifyHint=False>|[Menu command extension](../VS_IDE/Define-a-menu-command-on-a-modeling-diagram.md).<br /><br /> [Linked Undo transactions](../VS_IDE/Link-UML-model-updates-by-using-transactions.md).|  
||<xref:Microsoft.VisualStudio.Modeling.Validation?qualifyHint=False>|[Validation](../VS_IDE/Define-validation-constraints-for-UML-models.md)|  
||(other namespaces)|Recommended only for advanced use.|  
|Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]|<xref:Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement?qualifyHint=False>|[Gesture handlers](../VS_IDE/Define-a-gesture-handler-on-a-modeling-diagram.md).|  
||(other namespaces)|Recommended only for advanced use.|  
|Microsoft.VisualStudio.TeamFoundation.WorkItemTracking|<xref:Microsoft.VisualStudio.TeamFoundation.WorkItemTracking?qualifyHint=False>|[Links to work items](../VS_IDE/Define-a-work-item-link-handler.md).|  
|Microsoft.TeamFoundation.WorkItemTracking.Client|<xref:Microsoft.TeamFoundation.WorkItemTracking.Client?qualifyHint=False>|[Work items and their fields](../VS_IDE/Define-a-work-item-link-handler.md).|  
|Microsoft.TeamFoundation.Client|<xref:Microsoft.TeamFoundation.Client?qualifyHint=False>|[Work items and their fields](../VS_IDE/Define-a-work-item-link-handler.md).|  
|System.ComponentModel.Composition|<xref:System.ComponentModel.Composition?qualifyHint=False>|[Export and Import for MEF components](../VS_IDE/Define-and-install-a-modeling-extension.md)|  
|System.Linq|<xref:System.Linq?qualifyHint=False>|[Easy manipulation of collections, especially when dealing with relationships](../VS_IDE/Navigate-relationships-with-the-UML-API.md).|  
  
## See Also  
 [Extend UML models and diagrams](../VS_IDE/Extend-UML-models-and-diagrams.md)   
 [API Reference for UML Modeling Extensibility](../VS_IDE/API-Reference-for-UML-Modeling-Extensibility.md)