---
title: "Navigate and update layer models in program code"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c60edc87-33ee-4964-a954-40069f9febf3
caps.latest.revision: 20
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
# Navigate and update layer models in program code
This topic describes the elements and relationships in layer models, which you can navigate and update by using program code. For more information about layer diagrams from the user's point of view, see [Layer Diagrams: Reference](../VS_IDE/Layer-Diagrams--Reference.md) and [Layer Diagrams: Guidelines](../VS_IDE/Layer-Diagrams--Guidelines.md).  
  
 The <xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer?qualifyHint=False> model described in this topic is a façade on a more general <xref:Microsoft.VisualStudio.GraphModel?qualifyHint=False> model. If you are writing a [menu command or gesture extension](../VS_IDE/Add-commands-and-gestures-to-layer-diagrams.md), use the `Layer` model. If you are writing a [layer validation extension](../VS_IDE/Add-custom-architecture-validation-to-layer-diagrams.md), it is easier to use the `GraphModel`.  
  
## Transactions  
 When you update a model, consider enclosing the changes in a `ILinkedUndoTransaction`. This groups your changes into one transaction. If any of the changes fails, the whole transaction will be rolled back. If the user undoes a change, all the changes will be undone together.  
  
 For more information, see [Link UML model updates by using transactions](../VS_IDE/Link-UML-model-updates-by-using-transactions.md).  
  
```  
using (ILinkedUndoTransaction t =  
        LinkedUndoContext.BeginTransaction("a name"))  
{   
    // Make changes here ....  
    t.Commit(); // Don't forget this!  
}  
```  
  
## Containment  
 ![ILayer and ILayerModel can both contain ILayers.](../VS_IDE/media/LayerApi_Containment.png "LayerApi_Containment")  
  
 Layers (<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.ILayer?qualifyHint=False>) and the layer model (<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.ILayerModel?qualifyHint=False>) can contain Comments and Layers.  
  
 A layer (`ILayer`) can be contained in a layer model (`ILayerModel`) or it can be nested within another `ILayer`.  
  
 To create a comment or a layer, use the creation methods on the appropriate container.  
  
## Dependency Links  
 A dependency link is represented by an object. It can be navigated in either direction:  
  
 ![An ILayerDependencyLink connects two ILayers.](../VS_IDE/media/LayerApi_Dependency.png "LayerApi_Dependency")  
  
 To create a dependency link, call `source.CreateDependencyLink(target)`.  
  
## Comments  
 Comments can be contained inside layers or the layer model, and can also be linked to any layer element:  
  
 ![Comments can be attached to any layer element.](../VS_IDE/media/LayerApi_Comments.png "LayerApi_Comments")  
  
 A comment can be linked to any number of elements, including none.  
  
 To get the comments that are attached to a layer element, use:  
  
```c#  
ILayerModel model = diagram.GetLayerModel();   
IEnumerable<ILayerComment> comments =   
   model.Comments.Where(comment =>   
      comment.Links.Any(link => link.Target == layerElement));  
  
```  
  
> [!CAUTION]
>  The `Comments` property of an `ILayer` gets comments that are contained within the `ILayer`. It does not get the comments that are linked to it.  
  
 Create a comment by invoking `CreateComment()` on the appropriate container.  
  
 Create a link by using `CreateLink()` on the comment.  
  
## Layer Elements  
 All the types of element that can be contained in a model are layer elements:  
  
 ![Layer diagram contents are ILayerElements.](../VS_IDE/media/LayerApi_LayerElements.png "LayerApi_LayerElements")  
  
## Properties  
 Each `ILayerElement` has a string dictionary named `Properties`. You can use this dictionary to attach arbitrary information to any layer element.  
  
## Artifact References  
 An artifact reference (<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.ILayerArtifactReference?qualifyHint=False>) represents the link between a layer and a project item such as a file, class, or folder. The user creates artifacts when they create a layer or add to it by dragging items from Solution Explorer, Class View, or Object Browser onto a layer diagram. Any number of artifact references can be linked to a layer.  
  
 Each row in Layer Explorer displays an artifact reference. For more information, see [Create layer diagrams from your code](../VS_IDE/Create-layer-diagrams-from-your-code.md).  
  
 The principal types and methods concerned with artifact references are as follows:  
  
 <xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.ILayerArtifactReference?qualifyHint=False>. The Categories property indicates what kind of artifact is referenced, such as a class, executable file, or assembly. Categories determines how the Identifier identifies the target artifact.  
  
 <xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.ArtifactReferenceExtensions.CreateArtifactReferenceAsync?qualifyHint=False> creates an artifact reference from an <xref:EnvDTE.Project?qualifyHint=False> or <xref:EnvDTE.ProjectItem?qualifyHint=False>. This is an asynchronous operation. Therefore, you usually provide a callback that is called when the creation is complete.  
  
 Layer Artifact References should not be confused with Artifacts in use case diagrams.  
  
## Shapes and Diagrams  
 Two objects are used to represent each element in a layer model: an <xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.ILayerElement?qualifyHint=False>, and an <xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation.IShape?qualifyHint=False>. The `IShape` represents the position and size of the shape on the diagram. In layer models, every `ILayerElement` has one `IShape`, and every `IShape` on a layer diagram has one `ILayerElement`. `IShape` is also used for UML models. Therefore, not every `IShape` has a layer element.  
  
 In the same manner, the <xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.ILayerModel?qualifyHint=False> is displayed on one <xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation.IDiagram?qualifyHint=False>.  
  
 In the code of a custom command or gesture handler, you can get the current diagram and the current selection of shapes from the `DiagramContext` import:  
  
```  
public class ... {  
[Import]  
    public IDiagramContext DiagramContext { get; set; }  
...  
public void ... (...)   
{ IDiagram diagram = this.DiagramContext.CurrentDiagram;  
  ILayerModel model = diagram.GetLayerModel();  
  if (model != null)  
  { foreach (ILayer layer in model.Layers) { ... }}  
  foreach (IShape selected in diagram.SelectedShapes)  
  { ILayerElement element = selected.GetLayerElement();  
    if (element != null) ... }}  
```  
  
 ![Each ILayerElement is presented by an IShape.](../VS_IDE/media/LayerApi_Shapes.png "LayerApi_Shapes")  
  
 <xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation.IShape?qualifyHint=False> and <xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation.IDiagram?qualifyHint=False> are also used to display UML models. For more information, see [Display a UML model on diagrams](../VS_IDE/Display-a-UML-model-on-diagrams.md).  
  
## See Also  
 [Add commands and gestures to layer diagrams](../VS_IDE/Add-commands-and-gestures-to-layer-diagrams.md)   
 [Add custom architecture validation to layer diagrams](../VS_IDE/Add-custom-architecture-validation-to-layer-diagrams.md)   
 [Add custom properties to layer diagrams](../VS_IDE/Add-custom-properties-to-layer-diagrams.md)   
 [Layer Diagrams: Reference](../VS_IDE/Layer-Diagrams--Reference.md)   
 [Layer Diagrams: Guidelines](../VS_IDE/Layer-Diagrams--Guidelines.md)   
 [Extend UML models and diagrams](../VS_IDE/Extend-UML-models-and-diagrams.md)