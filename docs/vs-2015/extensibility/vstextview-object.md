---
title: "VSTextView Object | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
f1_keywords: 
  - "VSTextView"
helpviewer_keywords: 
  - "VSTextView object, reference"
  - "views [Visual Studio SDK], reference"
ms.assetid: 78272ddc-9718-4c65-a94e-a44a2e8d54f4
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# VSTextView Object
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The text view is a window that allows users to view and edit the Unicode text of the text buffer. Essentially, the view is what most users refer to as the editor. Because the view is separated from the buffer by various text layers (word wrap, outlining text, and so on), the view is not guaranteed to be an exact representation of the text in the buffer. For more information about the text view, see [Accessing theText View by Using the Legacy API](../extensibility/accessing-thetext-view-by-using-the-legacy-api.md)  
  
 The following table shows the interfaces in the <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextView> object.  
  
|Interface|Description|  
|---------------|-----------------|  
|[IDropSource](/windows/desktop/api/oleidl/nn-oleidl-idropsource)|Standard OLE interface.|  
|<xref:Microsoft.VisualStudio.OLE.Interop.IDropTarget>|Standard OLE interface.|  
|<xref:Microsoft.VisualStudio.OLE.Interop.IObjectWithSite>|Standard OLE interface.|  
|<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>|Standard OLE interface.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompoundAction>|Enables the creation of compound actions (that is, actions that are grouped in a single undo/redo unit).|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView>|Provides the basic methods for managing and accessing the view. `IVsTextView` is not thread safe.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane>|Creates and manages a window pane.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsLayeredTextView>|Interacts with text layers.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsThreadSafeTextView>|Performs operations on the view from a different thread.|  
  
## See Also  
 [Figures Edit](https://msdn.microsoft.com/f08872bd-fd9c-4e36-8cf2-a2a2622ef986)   
 [VSTextBuffer Object](../extensibility/vstextbuffer-object.md)   
 [Accessing theText View by Using the Legacy API](../extensibility/accessing-thetext-view-by-using-the-legacy-api.md)
