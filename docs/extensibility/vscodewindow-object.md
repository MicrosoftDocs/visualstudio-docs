---
title: VSCodeWindow Object | Microsoft Docs
description: Learn about code windows, which are specialized document windows that can include one or more text views, usually the VsTextView object.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VSCodeWindow
helpviewer_keywords:
- views [Visual Studio SDK], VSCodeWindow object
- VsCodeWindow object
ms.assetid: cf5fe926-e784-4098-bc01-cac49c7c55c6
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# VSCodeWindow object
A code window is a specialized document window that can include one or more text views, usually the <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextView> object.

 Architecturally, the code window is a document window that's within a window frame. Functionally, the code window is simply a document window with additional features. In the multiple-document interface (MDI) mode, the code window is the MDI child frame. For more information, see [Customizing code windows by using the legacy API](/previous-versions/visualstudio/visual-studio-2015/extensibility/customizing-code-windows-by-using-the-legacy-api?preserve-view=true&view=vs-2015).

 The following table includes the interfaces in the <xref:Microsoft.VisualStudio.TextManager.Interop.VsCodeWindow> object.

|Method|Description|
|------------|-----------------|
|<xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider>|Provides a generic access mechanism to locate a service that a globally unique identifier (GUID) identifies.|
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow>|Represents a multiple document interface (MDI) child containing one or more code views.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane>|Fills a window frame.|

## See also
- <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider>
- [Figures edit](https://www.microsoft.com/download/details.aspx?id=55984)