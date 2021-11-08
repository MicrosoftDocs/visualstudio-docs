---
title: 'How to: Use Built-In Colorable Items | Microsoft Docs'
description: Learn how to use the built-in colorable items in the Visual Studio integrated development environment (IDE) for your language service.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- colorable items
- language services, built-in colorable items
ms.assetid: 5e5f3436-6bad-4fd2-8823-6a30353ba648
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# How to: Use built-in colorable items
Before you use the built-in colorable items, you must first signal to the integrated development environment (IDE) that you are not providing your own custom colorable items, which in this case would be <xref:Microsoft.VisualStudio.TextManager.Interop.IVsProvideColorableItems> objects. You do this by setting a registry entry for the language service.

## To use built-in colorable items

1. Under **HKEY_LOCAL_MACHINE\VisualStudio\\<X.Y>\Languages\Language Services\\<Language Name\>**, where \<X.Y> is a version of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] and \<Language Name> is the name of your language, create a DWORD registry entry value called **RequestStockColors**.

2. Set the **RequestStockColors** registry entry value to *1*.

    After you create the registry entry, your colorizer's <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer.ColorizeLine%2A> method can use the members of the <xref:Microsoft.VisualStudio.TextManager.Interop.DEFAULTITEMS> enumeration to fill in the array of color attributes for use by the editor.

   > [!NOTE]
   > Do not set this registry entry if you are providing custom colorable items. For more information, see [Custom colorable items](../../extensibility/internals/custom-colorable-items.md).

## See also
- [Syntax coloring in custom editors](../../extensibility/syntax-coloring-in-custom-editors.md)
- [Syntax coloring in a legacy language service](../../extensibility/internals/syntax-coloring-in-a-legacy-language-service.md)
- [Implementing syntax coloring](../../extensibility/internals/implementing-syntax-coloring.md)
- [Custom colorable items](../../extensibility/internals/custom-colorable-items.md)
- [Register a legacy language service](../../extensibility/internals/registering-a-legacy-language-service2.md)
