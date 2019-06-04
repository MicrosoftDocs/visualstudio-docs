---
title: "How to: Add Standard Text Markers | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], legacy - standard text markers"
ms.assetid: a39fca69-0014-474c-933f-51f0e9b9617e
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# How to: Add standard text markers
Use the following procedure to create one of the default text marker types provided with the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] core editor.

## To create a text marker

1. Depending on whether you are using a one- or two-dimensional coordinate system, call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines.CreateLineMarker%2A> method or the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextStream.CreateStreamMarker%2A> method to create a new text marker.

     In this method call, specify a marker type, a range of text to create the marker over, and an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient> interface. This method then returns a pointer to the newly created text marker. Marker types are taken from the <xref:Microsoft.VisualStudio.TextManager.Interop.MARKERTYPE> enumeration. Specify an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient> interface if you want to be informed of marker events.

    > [!NOTE]
    > Create text markers on the main UI thread only. The core editor relies on the contents of the text buffer to create text markers and the text buffer is not thread safe.

## Add a custom command
 Implementing the `IVsTextMarkerClient` interface and providing a pointer to it from a marker enhances marker behavior in several ways. First, this allows you to provide tips for your marker and to execute commands. This also allows you to receive event notifications for individual markers and to create a custom context menu over the marker. Use the following procedure to add a custom command to the marker context menu.

### To add a custom command to the context menu

1. Before the Context menu is displayed, the environment calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient.GetMarkerCommandInfo%2A> method and passes you a pointer to the text marker affected and the number of the command item in the context menu.

     For example, the breakpoint-specific commands on the context menu include **Remove Breakpoint** through **New Breakpoint**, as displayed in the following screenshot.

     ![Marker Context Menu](../extensibility/media/vsmarkercontextmenu.gif "vsMarkercontextmenu")

2. Pass back some text identifying the name of the custom command. For example, **Remove Breakpoint** might be a custom command if the environment did not already provide it. You also pass back whether the command is supported, available and enabled, and/or an on-off toggle. The environment uses this information to display the custom command in the context menu in the correct way.

3. To execute the command, the environment calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient.ExecMarkerCommand%2A> method, passing you a pointer to the text marker and the number of the command selected from the context menu.

     Use this information from this call to execute whatever actions of the text marker your custom command dictates.

## See also
- [Use text markers with the legacy API](../extensibility/using-text-markers-with-the-legacy-api.md)
- [How to: Implement error markers](../extensibility/how-to-implement-error-markers.md)
- [How to: Create custom text markers](../extensibility/how-to-create-custom-text-markers.md)
- [How to: Use text markers](../extensibility/how-to-use-text-markers.md)