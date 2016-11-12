---
title: "Using Fonts and Colors | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "fonts, controlling in IDE"
  - "IDE, controlling text color and fonts"
  - "Fonts and Colors property page"
  - "font and color control [Visual Studio SDK]"
  - "text, IDE"
ms.assetid: d1a9b99f-fbdc-45ed-920a-e08c3d931ac9
caps.latest.revision: 27
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Using Fonts and Colors
The [!INCLUDE[vsipsdk](../extensibility/includes/vsipsdk_md.md)] provides support for using fonts and colors to display text.  
  
## In This Section  
 [Font and Color Overview](../extensibility/font-and-color-overview.md)  
 Discusses text font and color settings in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE). Also introduces the concepts of Categories and Display Items, and describes how VSPackages and the core editor use text attributes.  
  
 [Getting Font and Color Information for Text Colorization](../extensibility/getting-font-and-color-information-for-text-colorization.md)  
 Provides guidelines for implementing text colorization in VSPackages that manage **Categories** other than **Text Editor**.  
  
 [Accessing Stored Font and Color Settings](../extensibility/accessing-stored-font-and-color-settings.md)  
 Explains how current font and color settings can be stored, retrieved, and applied.  
  
 [Implementing Custom Categories and Display Items](../extensibility/implementing-custom-categories-and-display-items.md)  
 Describes the basic steps by which a window can create and use its own of **Display Items** and **Categories** to support text display.  
  
 This approach requires a VSPackage to implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaultsProvider> interface and related interfaces.  
  
 [How to: Access the Built-in Fonts and Color Scheme](../extensibility/how-to-access-the-built-in-fonts-and-color-scheme.md)  
 Discusses how to define and register a category by using built-in fonts and colors, and initiate the use of system-provided fonts and colors.  
  
## Reference  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaultsProvider>  
 Provides an instance of the `IVsFontAndColorDefaults` or the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorGroup> interface that corresponds to a particular item listed in the **Show Settings For** list in the **Fonts and Colors** page of the **Options** dialog box.  
  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults>  
 Enables a VSPackage to support the IDE **Fonts and Colors** page by defining default fonts and colors for a window or UI component.  
  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorGroup>  
 Provides a mechanism by which a VSPackage that provides font and color support can specify a Display Item group - a super-category that represents the union of two or more categories.  
  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage>  
 Enables a VSPackage to retrieve font and color data, or save it to the registry.  
  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorEvents>  
 Notifies VSPackages that are using font and color information about changes in font and color settings.  
  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorUtilities>  
 Provides tools for working with the input and output data that is used by the methods of the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] **Font and Color** mechanism.  
  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorCacheManager>  
 Controls the caching of font and color settings.  
  
## Related Sections  
 [Developing a Legacy Language Service](../extensibility/internals/developing-a-legacy-language-service.md)  
 Discusses how VSPackages can use language services to customize the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] editor.  
  
 [Syntax Coloring in Custom Editors](../extensibility/syntax-coloring-in-custom-editors.md)  
 Descries how the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] editor uses language services to implement syntax coloring.  
  
 [Extending Other Parts of Visual Studio](../extensibility/extending-other-parts-of-visual-studio.md)  
 Explains how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] services to create UI elements that match the rest of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].