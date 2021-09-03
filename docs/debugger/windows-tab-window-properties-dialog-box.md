---
title: "Windows Tab, Window Properties Dialog Box | Microsoft Docs"
description: Use the Windows tab of Windows Properties to show information on the windows that are related to the selected window. See this article for the settings.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
helpviewer_keywords:
  - "Window Properties dialog box, Windows Tab"
ms.assetid: 9001342a-09a8-4f5e-b6ed-881a3b9d7246
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Windows Tab, Window Properties Dialog Box
Use the **Windows** tab to show information on windows related to the selected window. To display the [Window Properties Dialog Box](../debugger/window-properties-dialog-box.md), move the focus to the [Windows View](../debugger/windows-view.md) window. Select any window node in the tree, then choose **Properties** from the **View** menu.

 The following settings are available on the **Windows** tab:

|Entry|Description|
|-----------|-----------------|
|**Next Window**|The handle of the next sibling window in the same sequence (Z-order) shown in the window tree view ("none" if there is no next window). Choose this entry to view the properties of the next window.|
|**Previous Window**|The handle of the previous sibling window in the same sequence (Z-order) shown in the window tree view ("none" if there is no previous window). Choose this entry to view the properties of the previous window.|
|**Parent Window**|The handle of this window's parent window ("none" if there is no parent). Choose this entry to view the properties of the parent window.|
|**First Child**|The handle of this window's first child window, in the sequence (Z-order) shown in the window tree view ("none" if there are no child windows). Choose this value to view the properties of the first child window.|
|**Owner Window**|The handle of this window's owner window. An application's main window typically owns system-modal dialog windows, for example ("none" if there is no owner). Choose this entry to view the properties of the owner window.|