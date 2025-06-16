---
title: VSTextBuffer Object
description: The VSTextBuffer object represents a stream of Unicode text, which is generally associated with a file. This article lists the interfaces of VSTextBuffer.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VSTextBuffer
helpviewer_keywords:
- VSTextBuffer object, reference
- views [Visual Studio SDK], VSTextBuffer object
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# VSTextBuffer object

The text buffer object represents a stream of Unicode text, which is generally associated with a file. A <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer> object can be used outside the context of the core editor, as in, a wizard.

 The following table shows the interfaces of `VSTextBuffer`.

|Method|Description|
|------------|-----------------|
|[IOleCommandTarget](/windows/desktop/api/docobj/nn-docobj-iolecommandtarget)|Standard OLE interface. Used for undo/redo handling in the buffer.|
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
 The `VSTextBuffer` is usually found by a `QueryInterface` call on `IVsTextBuffer`. For more information, see [Text buffer](/previous-versions/visualstudio/visual-studio-2015/extensibility/accessing-the-text-buffer-by-using-the-legacy-api?preserve-view=true&view=vs-2015).

## See also
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer>
- <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextView>
- [Figures edit](https://www.microsoft.com/download/details.aspx?id=55984)