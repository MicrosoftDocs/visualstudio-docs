---
title: Editor and Language Service Extensions
description: You can extend most features of the Visual Studio code editor, which is implemented using Windows Presentation Foundation and is written in managed code.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- editors [Visual Studio SDK]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Editor and language service extensions

You can extend most features of the Visual Studio code editor. The editor is based on the Windows Presentation Foundation (WPF) and is written in managed code. Although this design differs from the designs in earlier versions of Visual Studio, it provides most of the same features. To extend the editor, use the Managed Extensibility Framework (MEF).

 The Visual Studio SDK provides adapters known as *shims* to support VSPackages that were written for earlier versions. Nevertheless, if you have an existing VSPackage, we recommend that you update it to the new technology to obtain better performance and reliability.

## Related topics

|Title|Description|
|-----------|-----------------|
|[Create an extension with an editor item template](../extensibility/creating-an-extension-with-an-editor-item-template.md)|Introduction to using the Editor item templates.|
|[Extend the editor and language services](../extensibility/extending-the-editor-and-language-services.md)|Links to documents that introduce the design and features of the core editor and show how to extend it.|
|[Legacy interfaces in the editor](/previous-versions/visualstudio/visual-studio-2015/extensibility/legacy-interfaces-in-the-editor?preserve-view=true&view=vs-2015)|Links to documents that explain how to access the core editor from existing code.|
|[Create custom editors and designers](../extensibility/creating-custom-editors-and-designers.md)|Links to documents that explain how to create custom editors.|
|[Legacy language service extensibility](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/legacy-language-service-extensibility)|Links to documents that describe how to integrate programming languages into Visual Studio.|
|[Managed Extensibility Framework (MEF)](/dotnet/framework/mef/index)|Introduces the Managed Extensibility Framework (MEF).|
|[Windows Presentation Foundation](/dotnet/framework/wpf/index)|Introduces the Windows Presentation Foundation (WPF).|
