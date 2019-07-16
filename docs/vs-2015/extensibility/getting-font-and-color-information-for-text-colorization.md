---
title: "Getting Font and Color Information for Text Colorization | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "text, coloring"
  - "font and color control [Visual Studio SDK], coloring"
ms.assetid: d1f985bd-743e-40b7-9458-d9af53647c91
caps.latest.revision: 23
ms.author: gregvanl
manager: jillfra
---
# Getting Font and Color Information for Text Colorization
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The process that renders or displays colorized text in user interface (UI) elements depends on the type of project, its technology, and developer preferences. The **Fonts and Colors** property page stores the settings.  
  
 Most implementations that display colorized text need the `T:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults` and associated interfaces for presenting, retrieving, and storing text display settings.  
  
> [!NOTE]
> When customizing the core editor (which supports the **Text EditorCategory**), it is strongly recommended that you use the coloring technology in the language service. For more information, see [Font and Color Overview](../extensibility/font-and-color-overview.md).  
  
## Getting Default Font and Color Information  
 All the **Fonts and Colors** settings of any window displaying text should be specified in the **Display Items** of one **Category**. For more information, see [Fonts and Colors, Environment, Options Dialog Box](../ide/reference/fonts-and-colors-environment-options-dialog-box.md).  
  
 To colorize, a VSPackage must obtain current **Fonts and Colors** settings. A VSPackage can accomplish this in the following ways, depending on its needs:  
  
- Use the font and color persistence mechanism to retrieve the stored or current state. For more information, see [Accessing Stored Font and Color Settings](../extensibility/accessing-stored-font-and-color-settings.md).  
  
- Use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaultsProvider> interface of a service providing font and color data to get an instance of <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults>, if the VSPackage is not also the font and color provider.  
  
- Implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorEvents> interface.  
  
  To ensure that the results obtained by polling are up-to date, it may be useful to use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorCacheManager> interface to determine if an update is needed prior to calling the retrieval methods of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage> interface.  
  
  After you have obtained font and color information, parse the text to be displayed to identify elements requiring colorization and then display the text in the window using the appropriate fonts and colors.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaultsProvider>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults>   
 [Using Fonts and Text](https://msdn.microsoft.com/library/d43640f3-da94-4df2-a29d-a9d021a1c069)   
 [Working with Color](https://msdn.microsoft.com/library/d34ff96f-241d-494f-abdd-13811ada8cd3)   
 [GDI (graphics device interface)](https://msdn.microsoft.com/7e1d4540-bb2e-4257-8eee-eee376acba83)
