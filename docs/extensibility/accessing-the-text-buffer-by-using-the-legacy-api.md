---
title: "Accessing the Text Buffer by Using the Legacy API | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], legacy - text buffers"
ms.assetid: cd6cf4ae-fff5-4e23-b293-7cbafdb8aed2
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# Access the text buffer by using the legacy API
The text is responsible for managing text streams and file persistence. Although the buffer can read or write other formats, all ordinary communication with the buffer is performed by using Unicode. In the legacy APIs, the text buffer can use either a one- or a two-dimensional coordinate system to identify character locations in the buffer.

## One- and two-dimension coordinate systems
 A one-dimensional coordinate position is based on a character's position from the first character in the buffer, such as 147. You use the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextStream> interface to access a one-dimensional location in the buffer. A two-dimensional coordinate system is based on line and index pairs. For example, a character in the buffer at 43, 5 would be on line 43, five characters to the right of the first character in that line. You access a two-dimensional location in the buffer using the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines> interface. Both the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines> and the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextStream> interfaces are implemented by the text buffer object (<xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer>) and can be accessed from each other by using `QueryInterface`. The following diagram shows these and other key interfaces on <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer>.

 ![Text Buffer Object](../extensibility/media/vstextbuffer.gif "vsTextBuffer")
Text buffer object

 Although either coordinate system works in the text buffer, it is optimized to use two-dimensional coordinates. A one-dimensional coordinate system can create performance overhead. Therefore, use the two-dimensional coordinate system whenever possible.

 The text buffer's second responsibility is file persistence. To do this, the text buffer object implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2> and acts as the document data object component for project items and other environment components involved in persistence. For more information, see [Opening and Saving Project Items](../extensibility/internals/opening-and-saving-project-items.md).

## In this section
- [Change view settings by using the legacy API](../extensibility/changing-view-settings-by-using-the-legacy-api.md)
 Explains how to change view settings using the legacy API.

- [Use the text manager to monitor global settings](../extensibility/using-the-text-manager-to-monitor-global-settings.md)
 Explains how to use the text manager to monitor global settings.

## See also
- [Inside the core editor](../extensibility/inside-the-core-editor.md)