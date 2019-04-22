---
title: "How to: Use Built-In Colorable Items | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "colorable items"
  - "language services, built-in colorable items"
ms.assetid: 5e5f3436-6bad-4fd2-8823-6a30353ba648
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# How to: Use Built-In Colorable Items
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Before you use the built-in colorable items, you must first signal to the integrated development environment (IDE) that you are not providing your own custom colorable items, which in this case would be <xref:Microsoft.VisualStudio.TextManager.Interop.IVsProvideColorableItems> objects. You do this by setting a registry entry for the language service.  
  
### To use built-in colorable items  
  
1. Under HKEY_LOCAL_MACHINE\VisualStudio\\*X.Y*\Languages\Language Services\\*Language Name*, where *X.Y* is a version of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] and *Language Name* is the name of your language, create a DWORD registry entry value called `RequestStockColors`.  
  
2. Set the `RequestStockColors` registry entry value to 1.  
  
     After you create the registry entry, your colorizer's <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer.ColorizeLine%2A> method can use the members of the <xref:Microsoft.VisualStudio.TextManager.Interop.DEFAULTITEMS> enumeration to fill in the array of color attributes for use by the editor.  
  
    > [!NOTE]
    > Do not set this registry entry if you are providing custom colorable items. For more information, see [Custom Colorable Items](../../extensibility/internals/custom-colorable-items.md).  
  
## See Also  
 [Syntax Coloring in Custom Editors](../../extensibility/syntax-coloring-in-custom-editors.md)   
 [Syntax Coloring in a Legacy Language Service](../../extensibility/internals/syntax-coloring-in-a-legacy-language-service.md)   
 [Implementing Syntax Coloring](../../extensibility/internals/implementing-syntax-coloring.md)   
 [Custom Colorable Items](../../extensibility/internals/custom-colorable-items.md)   
 [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service2.md)
