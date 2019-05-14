---
title: "Using Text Markers with the Legacy API | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - text markers"
ms.assetid: 937a0b19-1216-45d5-a7ad-4fe1d6f73097
caps.latest.revision: 17
ms.author: gregvanl
manager: jillfra
---
# Using Text Markers with the Legacy API
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A text marker is a floating range of text in a buffer that can affect the display and behavior of a region of text. Markers include breakpoints, bookmarks, wavy underlines, and read-only regions. Text markers are basically different from syntax coloring. Syntax coloring is a quick way to communicate the language syntax that is associated with a region of text. Syntax coloring is generally requested when Windows repaints the screen, when speed is important. Syntax coloring changes only the color of text. Text markers can change many other text properties. Text markers can "float" and apply special behavior and coloring.  
  
 Because of the performance overhead associated with text markers, do not create many markers for your text buffers. Each marker is updated every time that a user edits the buffer contents.  
  
> [!NOTE]
> Users can change the color of a visible marker type but not its shape and style. For more information, see [Fonts and Colors, Environment, Options Dialog Box](../ide/reference/fonts-and-colors-environment-options-dialog-box.md).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[How to: Add Standard Text Markers](../extensibility/how-to-add-standard-text-markers.md)|Describes how to add a standard text marker type provided by the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] core editor to a text view.|  
|[How to: Implement Error Markers](../extensibility/how-to-implement-error-markers.md)|Describes how to implement an instance of the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] marker that is used to indicate errors by using red wavy underlines.|  
|[How to: Create Custom Text Markers](../extensibility/how-to-create-custom-text-markers.md)|Describes how to create and add a custom text marker type to a text view.|  
|[How to: Use Text Markers](../extensibility/how-to-use-text-markers.md)|Explains how to add text markers.|  
|[Inside the Core Editor](../extensibility/inside-the-core-editor.md)|Describes the features of the core editor and provides details about how to customize the core editor.|  
|[Editor Features](https://msdn.microsoft.com/bdac940d-1f14-4019-a01f-fd0bb3dc7198)|Describes the features available in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] core editor.|  
  
## Reference  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsPackageDefinedTextMarkerType>  
 Provides a uniform mechanism for obtaining information about a specific text marker type, whether predefined by the editor or registered by a VSPackage.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLineMarker>  
 Provides access to and adjusts the position of a text marker in a text buffer by using two-dimensional coordinates.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarker>  
 Provides methods for managing text markers.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient>  
 Provides callbacks to the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] IDE and other processes that are used to adjust a text marker.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClientAdvanced>  
 Extends the functionality that is available through the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient> interface by providing additional callbacks.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClientEx>  
 Extends the functionality that is available through the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient> interface by providing additional callbacks.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerColorSet>  
 Enables a marker type to determine whether other marker types share the same set of colors.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerContextProvider>  
 Provides context for text markers in the core editor. For each text marker type that is in the core editor, the IDE creates a separate <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerContextProvider> object.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerGlyphDropHandler>  
 A handler that is provided for markers whose glyphs support drag-and-drop editing. A glyph is an icon that indicates the position of a marker.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerTypeProvider>  
 Returns an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsPackageDefinedTextMarkerType> interface from a service that provides a text markers to other VSPackages.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextStreamMarker>  
 Provides access to and adjusts the position of a text marker in a text buffer by using one-dimensional coordinates. If it is possible, do not use this interface.
