---
title: VSCodeWindowManager Object
description: Learn about the VSCodeWindowManager object, which is responsible for managing adornments, for example, the drop-down bar.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VSCodeWindowManager
helpviewer_keywords:
- VsCodeWindowManager object
- views [Visual Studio SDK], VSCodeWindowManager object
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# VSCodeWindowManager object

The language service implements the code window manager and is responsible for managing adornments (for example, the drop-down bar). For more information, see [Customizing Code Windows by Using the Legacy API](/previous-versions/visualstudio/visual-studio-2015/extensibility/customizing-code-windows-by-using-the-legacy-api?preserve-view=true&view=vs-2015).

The following table shows the interfaces in the `VSCodeWindowManager` object.

|Interface|Description|
|---------------|-----------------|
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindowManager>|Allows adornments (such as drop-down bars) to be added to or removed from a code window.|