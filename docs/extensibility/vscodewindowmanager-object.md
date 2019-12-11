---
title: "VSCodeWindowManager Object | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "VSCodeWindowManager"
helpviewer_keywords:
  - "VsCodeWindowManager object"
  - "views [Visual Studio SDK], VSCodeWindowManager object"
ms.assetid: e313add5-afdb-4d8d-abd1-764e1fc10c44
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# VSCodeWindowManager object

The language service implements the code window manager and is responsible for managing adornments (for example, the drop-down bar). For more information, see [Customizing Code Windows by Using the Legacy API](/visualstudio/extensibility/customizing-code-windows-by-using-the-legacy-api?view=vs-2015).

The following table shows the interfaces in the `VSCodeWindowManager` object.

|Interface|Description|
|---------------|-----------------|
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindowManager>|Allows adornments (such as drop-down bars) to be added to or removed from a code window.|