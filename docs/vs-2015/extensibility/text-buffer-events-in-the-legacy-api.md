---
title: "Text Buffer Events in the Legacy API | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - text buffer events"
ms.assetid: 9be49e9f-1864-41c2-8a3c-f66895881341
caps.latest.revision: 17
ms.author: gregvanl
manager: jillfra
---
# Text Buffer Events in the Legacy API
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The text buffer object emits several different events that allow you to respond to different situations.  
  
 When you are using the legacy API, you should implement the following interfaces in order to receive notification of changes to the text buffer. Expose the interfaces to the text buffer using the `IConnectionPointContainer` interface on the text buffer to receive notification of line changes from the buffer. For more information, see [How to: Register for Text Buffer Events with the Legacy API](../extensibility/how-to-register-for-text-buffer-events-with-the-legacy-api.md). In the case of `IVsTextStreamEvents` or `IVsTextLinesEvents` interfaces, changes are returned in either one- or two-dimensional coordinates, respectively.  
  
## Text Buffer Interfaces  
 Following are the interfaces implemented by the text buffer object.  
  
|Interface|Description|  
|---------------|-----------------|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompoundAction>|Enables the creation of compound actions (that is, actions that are grouped in a single undo/redo unit).|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData>|Enables persistence of document data managed by the text buffer.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer>|Provides basic services; used by many clients.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines>|Provides read and write capabilities using two-dimensional coordinates. Inherits from `IVsTextBuffer`.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextScanner>|Provides fast, stream-oriented, sequential access to text in the buffer.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextStream>|Provides read and write capabilities using one-dimensional coordinates. Inherits from `IVsTextBuffer`.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsUserData>|Provides access to a generic collection of properties. The most important property is the name, or moniker, of the buffer. You can store your own random data in the buffer with this interface by creating a GUID and using it as a key.|  
|<xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer>|Supports connection points for events.|  
  
## Text Buffer Event Interfaces  
 Following are the interfaces for text buffer event notification.  
  
|Interface|Description|  
|---------------|-----------------|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferEvents>|Notifies clients when a new language service is associated with a text buffer.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferDataEvents>|Notifies clients when a text buffer is initialized and when changes are made to data in the text buffer.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextStreamEvents>|Notifies clients of changes to the underlying text buffer in one-dimensional coordinates.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLinesEvents>|Notifies clients of changes to the underlying text buffer in two-dimensional coordinates.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsUserDataEvents>|Notifies clients of changes to user data.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsPreliminaryTextChangeCommitEvents>|Notifies clients of the last commit gesture to trigger the event and provides the range of text changed. The `IVsPreliminaryTextChangeCommitEvents` interface is not fired in response to Undo or Redo commands. Events only fire for buffers that have an undo manager. `IVsPreliminaryTextChangeCommitEvents` is fired prior to other events, such as pretty listing, in order to make sure the other events do not alter the text before the changes are committed. Your VSPackage must monitor either the `IVsPreliminaryTextChangeCommitEvents` interface or the `IVsFinalTextChangeCommitEvents` interface, but not both.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsFinalTextChangeCommitEvents>|Notifies clients of the last commit gesture to trigger the event and provides the range of text changed. The `IVsFinalTextChangeCommitEvents` interface is not fired in response to Undo or Redo commands. Events only fire for buffers that have an undo manager. `IVsFinalTextChangeCommitEvents` is intended for use only by language services or other objects that have complete control over editing. Your VSPackage must monitor either the `IVsPreliminaryTextChangeCommitEvents` interface or the `IVsFinalTextChangeCommitEvents` interface, but not both.|  
  
## See Also  
 [Accessing the Text Buffer by Using the Legacy API](../extensibility/accessing-the-text-buffer-by-using-the-legacy-api.md)   
 [How to: Register for Text Buffer Events with the Legacy API](../extensibility/how-to-register-for-text-buffer-events-with-the-legacy-api.md)
