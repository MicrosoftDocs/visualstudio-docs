---
title: "How to: Use Text Markers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - using text markers"
ms.assetid: 76eed51c-eecb-4579-823e-13df2f0526b9
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# How to: Use Text Markers
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Text markers can be applied to edit a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer> object.  
  
## Procedures  
  
#### To apply text markers  
  
1. Obtain an instance of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> class.  
  
    > [!NOTE]
    > The core editor automatically applies standard text markers to any document that it is editing, and it should not be necessary to apply standard text markers explicitly.  
  
2. Obtain a marker type ID of the marker you are interested in by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextManager.GetRegisteredMarkerTypeID%2A> method with the `GUID` of the text marker you wish to work with.  
  
    > [!NOTE]
    > Do not use the `GUID` of the VSPackage or of the service that provides the text marker.  
  
3. Use the marker type ID obtained by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextManager.GetRegisteredMarkerTypeID%2A> method as a parameter to call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines.CreateLineMarker%2A> method or the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextStream.CreateStreamMarker%2A> method to apply a text marker to a given region of text.  
  
#### To add features to text markers  
  
1. It may be desirable to add additional features to a text marker, such as tool tips, a special context menu, or handler for special circumstances. To do so:  
  
2. Create an object implementing the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient> interface.  
  
3. If additional functionality is desired, implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClientEx>, and the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClientAdvanced> interfaces on the same object that implements the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient> interface.  
  
4. Pass the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient> interface that you create, to the call to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines.CreateLineMarker%2A> method or the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextStream.CreateStreamMarker%2A> method used to apply the text marker to a given region of text.  
  
5. When adding context menu support to a text marker region it is necessary to create the menu.  
  
     For more information on how to create a context menu see, [Context Menus](../extensibility/context-menus.md).  
  
6. The [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] environment calls the methods of the supplied interfaces, such as the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient.GetTipText%2A> method, or the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient.ExecMarkerCommand%2A> method as needed.  
  
## See Also  
 [Using Text Markers with the Legacy API](../extensibility/using-text-markers-with-the-legacy-api.md)   
 [How to: Add Standard Text Markers](../extensibility/how-to-add-standard-text-markers.md)   
 [How to: Create Custom Text Markers](../extensibility/how-to-create-custom-text-markers.md)   
 [How to: Implement Error Markers](../extensibility/how-to-implement-error-markers.md)
