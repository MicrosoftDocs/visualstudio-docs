---
title: "Context Menus | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - context menus"
ms.assetid: 44fd9e6a-6d42-4aba-80ba-f37fa0070f1d
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Context Menus
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Context menus are displayed when a user right-clicks in an active region of the client area and clear when the right mouse button is released.  
  
## Editor Context Menus  
 By intercepting `ECMD_SHOWCONTEXTMENU`, your language service can control the context menus that will display in the editor. To display your own context menu, handle this command when it is passed into your <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ShowContextMenu%2A>. If you do not handle this command, then the IDE displays a standard context menu provided for the editor. You can also control the content of the context menu on a per-marker basis. For more information about this, see [Using Text Markers with the Legacy API](../extensibility/using-text-markers-with-the-legacy-api.md) and [Intercepting Legacy Language Service Commands](../extensibility/internals/intercepting-legacy-language-service-commands.md).  
  
## See Also  
 [Developing a Legacy Language Service](../extensibility/internals/developing-a-legacy-language-service.md)   
 [Extending Menus and Commands](../extensibility/extending-menus-and-commands.md)
