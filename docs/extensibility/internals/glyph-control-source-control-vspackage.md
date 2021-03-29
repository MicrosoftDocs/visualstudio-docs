---
title: Glyph Control (Source Control VSPackage) | Microsoft Docs
description: Learn how to display custom glyphs in a source control VSPackage so that you can use your own icons to indicate the status of items under source control.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- glyphs, source control packages
- source control packages, glyphs
ms.assetid: b9413b08-b3c3-4fc3-a6e0-3dc0db3652d7
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Glyph control (source control VSPackage)
Part of the deep integration available to source control VSPackages is the ability to display their own glyphs to indicate the status of items under source control.

## Levels of glyph control
 A state glyph is an icon that indicates the current status of an item when displayed, for example in **Solution Explorer** or in **Class View**. A source control VSPackage can exercise two levels of glyph control. It can limit the choice of glyphs to a predefined set of glyphs provided by the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] IDE, or it can define a custom set of glyphs to be displayed.

### Default set of glyphs
 To determine the state glyphs that are associated with an item in **Solution Explorer**, a project requests the state glyph from source control using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccManager2.GetSccGlyph%2A>. A source control VSPackage may decide to keep the choice of glyphs limited to predefined glyphs provided by the IDE. In this case, the VSPackage passes back an array of values representing the glyph enumerations that are defined in *vsshell.idl*. For more information, see <xref:Microsoft.VisualStudio.Shell.Interop.VsStateIcon>. This is a predefined set of glyphs set by the IDE, such as a padlock for the checked-in glyph, and a check mark for the checked-out glyph.

### Custom set of glyphs
 A source control VSPackage can use its own glyphs for a unique look and feel when it's installed. When a new source control VSPackage is active, it should be able to start using its own glyphs even if a previous source control VSPackage is still loaded but inactive. In this mode, the source control VSPackage still can use the existing icons in order to maintain a look consistent with [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] if it chooses.

 The <xref:Microsoft.VisualStudio.Shell.Interop.SVsSccManager> service supports an interface, <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccGlyphs>, which the VSPackage can optionally implement and which will be asked for by the IDE. When the IDE makes a request, [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] will in turn try to get this interface from the currently registered source control VSPackage. If the interface exists in the registered VSPackage, the IDE's request for custom glyphs succeeds; otherwise, the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] IDE uses its default set of glyphs.

 The <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccGlyphs.GetCustomGlyphList%2A> method is used by [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] to obtain a list of images showing various source control states. The source control VSPackage returns to the IDE a handle to the image list for its custom glyphs. The IDE makes a copy of the image list at this point and uses it later to choose the glyphs to display. If the new interface is not supported or the `IVsSccGlyphs::GetCustomGlyphList` method returns `E_NOTIMPL`, then the IDE gets its glyphs from the default list of glyphs supplied by [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].

## See also
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccGlyphs>
- <xref:Microsoft.VisualStudio.Shell.Interop.VsStateIcon>
- <xref:Microsoft.VisualStudio.Shell.Interop.SVsSccManager>
