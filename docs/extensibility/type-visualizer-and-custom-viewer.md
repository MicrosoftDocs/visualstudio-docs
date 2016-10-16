---
title: "Type Visualizer and Custom Viewer"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], custom viewer"
  - "debugging [Debugging SDK], type visualizer"
ms.assetid: fd3691e6-9c78-4767-846f-43f85ada4375
caps.latest.revision: 13
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
# Type Visualizer and Custom Viewer
A type visualizer is a component that displays a piece of data in a very specific format. This format is entirely up to the implementer of the visualizer, be it the end user or a third-party supplier of visualizers.  
  
 A custom viewer is the part of a custom expression evaluator that displays a piece of data in a very specific format. This format is entirely up to the implementer of the custom viewer, which means that the format is up to the implementer of the expression evaluator (EE).  
  
## Support for Type Visualizers in an Expression Evaluator  
 An EE can support type visualizers by supporting a set of interfaces accessible to visualizers: interfaces such as [IEEVisualizerService](../extensibility/ieevisualizerservice.md) and [IEEVisualizerDataProvider](../extensibility/ieevisualizerdataprovider.md). Note, however, that the EE is not responsible for implementing the type visualizer itself: the EE merely allows external visualizers access to its type information. Such visualizers might be shipped along with the EE and installed in the appropriate place in Visual Studio, supplied by another third-party vendor or even by the end user.  
  
## Support for Custom Viewers in an Expression Evaluator  
 An EE can also support custom viewers in which the EE itself supplies the code for viewing the data type. A custom viewer implements the [IDebugCustomViewer](../extensibility/idebugcustomviewer.md) interface, which handles all the duties of showing the data in whatever format is desired; the viewer has full control over the display and can even allow the data to be modified. Any custom viewers supplied by the EE come with the EE when the product is shipped.  
  
## See Also  
 [Debugger Components](../extensibility/debugger-components.md)   
 [Expression Evaluator](../extensibility/expression-evaluator.md)   
 [Debug Engine](../extensibility/debug-engine.md)   
 [IDebugCustomViewer](../extensibility/idebugcustomviewer.md)   
 [IEEVisualizerService](../extensibility/ieevisualizerservice.md)   
 [IEEVisualizerDataProvider](../extensibility/ieevisualizerdataprovider.md)