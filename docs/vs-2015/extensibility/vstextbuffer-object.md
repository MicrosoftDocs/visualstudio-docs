---
title: "VSTextBuffer Object | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
f1_keywords: 
  - "VSTextBuffer"
helpviewer_keywords: 
  - "VSTextBuffer object, reference"
  - "views [Visual Studio SDK], VSTextBuffer object"
ms.assetid: c5f94b45-7249-4e1f-a53d-1d2a1c61e0ef
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# VSTextBuffer Object
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The text buffer object represents a stream of Unicode text, which is generally associated with a file. A <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer> object can be used outside the context of the core editor, as in the case of a wizard.  
  
 The following table shows the interfaces of `VSTextBuffer`.  
  
|Method|Description|  
|------------|-----------------|  
|[IOleCommandTarget](/windows/desktop/api/docobj/nn-docobj-iolecommandtarget)|Standard OLE interface. Mainly used for undo/redo handling in the buffer.|  
|[IPersistFile](/windows/desktop/api/objidl/nn-objidl-ipersistfile)|Standard OLE interface.|  
|[IPersistStream](/windows/desktop/api/objidl/nn-objidl-ipersiststream)|Standard OLE interface.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompoundAction>|Enables the creation of compounds actions (that is, actions that are grouped in a single undo/redo unit).|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData>|Enables persistence of document data managed by the text buffer.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer>|Provides basic services; used by many clients.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextFind>|Used to search a buffer.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines>|Provides read and write capabilities using two-dimensional coordinates. Inherits from `IVsTextBuffer`.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextStream>|Provides read and write capabilities using one-dimensional coordinates. Inherits from `IVsTextBuffer`.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextScanner>|Provides fast, stream-oriented, sequential access to text in the buffer.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsUserData>|Provides access to a generic collection of properties. The most important property is the name, or moniker, of the buffer. You can store your own random data in the buffer with this interface by creating a GUID and using it as a key.|  
|<xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer>|Supports connection points for events.|  
  
## Remarks  
 The `VSTextBuffer` is usually found by a `QueryInterface` call on `IVsTextBuffer`. For more information, see [Text Buffer](../extensibility/accessing-the-text-buffer-by-using-the-legacy-api.md).  
  
## See Also  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer>   
 <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextView>   
 [Figures Edit](https://msdn.microsoft.com/f08872bd-fd9c-4e36-8cf2-a2a2622ef986)
