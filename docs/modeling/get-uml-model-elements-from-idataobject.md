---
title: "Get UML model elements from IDataObject | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "UML API, copy and paste"
ms.assetid: e0b9cec8-3b93-4a24-8bd3-3e086501d387
caps.latest.revision: 18
author: "alexhomer1"
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
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
# Get UML model elements from IDataObject
When the user drags elements from any source onto a diagram, the dragged elements are encoded in a `System.Windows.Forms.IDataObject`. The encoding depends on the type of source object. The following fragment demonstrates how to retrieve the elements when the source is a UML diagram.  
  
> [!NOTE]
>  Most of the operations that you have to do on UML models can be performed by using the types in defined in the assemblies **Microsoft.VisualStudio.Uml.Interfaces** and **Microsoft.VisualStudio.ArchitectureTools.Extensibility**. But for this purpose, you have to use some classes that are part of the implementation of the UML modeling tools. For example, `ShapeElement` in this fragment is not the same as the UML `IShape`. To reduce the risk of putting the UML model and diagrams into an inconsistent state, it is better to avoid using the methods on these implementation classes, except where there is no alternative.  
  
## Code Sample  
 Your project must reference the following [!INCLUDE[TLA2#tla_net](../modeling/includes/tla2sharptla_net_md.md)] assemblies:  
  
 **Microsoft.VisualStudio.Modeling.Sdk.[version]**  
  
 **Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]**  
  
 **System.Windows.Forms**  
  
```  
using Microsoft.VisualStudio.Modeling;    
  // for ElementGroupPrototype  
using Microsoft.VisualStudio.Modeling.Diagrams;    
  // for ShapeElement, DiagramDragEventArgs, DiagramPointEventArgs  
…   
  /// <summary>  
  /// Retrieves UML IElements from drag arguments.  
  /// Works for drags from UML diagrams.  
  /// </summary>  
  private IEnumerable<IElement> GetModelElementsFromDragEvent  
                  (DiagramDragEventArgs dragEvent)  
  {  
     //ElementGroupPrototype is the container for  
     //dragged and copied elements and toolbox items.  
     ElementGroupPrototype prototype =  
        dragEvent.Data.  
        GetData(typeof(ElementGroupPrototype))  
                     as ElementGroupPrototype;  
     // Locate the originals in the implementation store.  
     IElementDirectory implementationDirectory =   
        dragEvent.DiagramClientView.Diagram.Store.ElementDirectory;  
  
     return  prototype.ProtoElements.Select(  
       prototypeElement =>   
       {  
          ModelElement element = implementationDirectory  
                .FindElement(prototypeElement.ElementId);  
          ShapeElement shapeElement = element as ShapeElement;  
          if (shapeElement != null)  
          {   
            // Dragged from a diagram.  
            return shapeElement.ModelElement as IElement;  
          }  
          else  
          {   
            // Dragged from UML Model Explorer.  
            return element as IElement;  
          }  
        });  
    }  
```  
  
 For more information about `ElementGroupPrototype` and the `Store` in which the UML modeling tools are implemented, see [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md).  
  
## See Also  
 [Programming with the UML API](../modeling/programming-with-the-uml-api.md)   
 [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)