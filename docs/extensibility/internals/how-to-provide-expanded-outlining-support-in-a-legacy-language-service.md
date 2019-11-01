---
title: "Provide Outlining Support in a Language Service | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], outlining support"
  - "language services, supporting outlining"
  - "outlining, supporting"
ms.assetid: df759e89-8193-418c-8038-6626304d387b
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# How to: Provide expanded outlining support in a legacy language service
There are two options for extending outlining support for your language beyond supporting the **Collapse to Definitions** command. You can add editor-controlled outline regions and add client-controlled outline regions.

## Adding editor-controlled outline regions
 Use this approach to create an outline region and then allow the editor to handle whether the region is expanded, collapsed, and so forth. Of the two options for providing outlining support, this option is the least robust. For this option, you create a new outline region over a specified span of text using <xref:Microsoft.VisualStudio.TextManager.Interop.IVsOutliningSession.AddOutlineRegions%2A>. After this region is created, its behavior is controlled by the editor. Use the following procedure to implement editor-controlled outline regions.

### To implement an editor-controlled outline region

1. Call `QueryService` for <xref:Microsoft.VisualStudio.TextManager.Interop.SVsTextManager>

     This returns a pointer to <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextManager>.

2. Call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextManager.GetHiddenTextSession%2A>, passing in a pointer for a given text buffer. This returns a pointer to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession> object for the buffer.

3. Call <xref:System.Runtime.InteropServices.Marshal.QueryInterface%2A> on <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession> for a pointer to <xref:Microsoft.VisualStudio.TextManager.Interop.IVsOutliningSession>.

4. Call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsOutliningSession.AddOutlineRegions%2A> to add one or more new outline regions at a time.

     This method allows you to specify the span of text to outline, whether existing outline regions are removed or preserved, and whether the outline region is expanded or collapsed by default.

## Add client-controlled outline regions
 Use this approach to implement client-controlled (or smart) outlining like that used by the [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] and [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] language services. A language service that manages its own outlining monitors the text buffer contents in order to destroy old outline regions when they become invalid and to create new outline regions as needed.

### To implement a client-controlled outline region

1. Call `QueryService` for <xref:Microsoft.VisualStudio.TextManager.Interop.SVsTextManager>. This returns a pointer to <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextManager>.

2. Call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextManager.GetHiddenTextSession%2A>, passing in a pointer for a given text buffer. This determines whether a hidden text session already exists for the buffer.

3. If a text session already exists, then you do not need to create one, and a pointer to the existing <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession> object is returned. Use this pointer to enumerate and create outline regions. Otherwise, call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextManager.CreateHiddenTextSession%2A> to create a hidden text session for the buffer. A pointer to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession> object is returned.

    > [!NOTE]
    > When you call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextManager.CreateHiddenTextSession%2A>, you can specify a hidden text client (that is, an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextClient> object). This client notifies you when a hidden text or outline region is expanded or collapsed by the user.

4. Call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession.AddHiddenRegions%2A> structure) parameter: Specify a value of <xref:Microsoft.VisualStudio.TextManager.Interop.HIDDEN_REGION_TYPE> in the `iType` member of the <xref:Microsoft.VisualStudio.TextManager.Interop.NewHiddenRegion> structure to indicate that you are creating an outline region, rather than a hidden region. Specify whether the region is client-controlled or editor-controlled in the `dwBehavior` member of the <xref:Microsoft.VisualStudio.TextManager.Interop.NewHiddenRegion> structure. Your smart outlining implementation can contain a mix of editor- and client-controlled outline regions. Specify the banner text that is displayed when your outline region is collapsed, such as "...", in the `pszBanner` member of the <xref:Microsoft.VisualStudio.TextManager.Interop.NewHiddenRegion> structure. The editor's default banner text for a hidden region is "...".