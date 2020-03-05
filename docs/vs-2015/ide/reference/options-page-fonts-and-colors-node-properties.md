---
title: "Options Page, Fonts and Colors Node Properties | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "Tools Options settings, Fonts and Colors node properties"
  - "automation [Visual Studio], controlling Tools Options"
ms.assetid: 8e1ab784-5f85-4e2b-8ef9-e5d59ca4dbcb
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: jillfra
---
# Options Page, Fonts and Colors Node Properties
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This document describes font and color properties for a tool window that is registered to appear under **Fonts and Colors** in the **Environment** category of the **Options** dialog box. This supports the dynamic nature of groups of colorable items, which can change if VSPackages are installed or uninstalled.

 The following section shows an example of a registered window type and the properties that are available for each window.

## Text Editor or Printer or Dialogs and Tool Windows
 `DTE.Properties("FontsAndColors", "TextEditor")`

 -or-

 `DTE.Properties("FontsAndColors", "Printer")`

 -or-

 `DTE.Properties("FontsAndColors", "Dialogs and Tool Windows")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|FontFamily|Get/Set (String)|The font name to use, such as "Courier New."|
|FontCharacterSet|Get/Set (<xref:EnvDTE.vsFontCharSet>)|A <xref:EnvDTE.vsFontCharSet> value, specifying the type of character set to use, such as Hebrew or Russian.|
|FontSize|Get/Set (Short)|The size of font to use, in points. For example, 10 or 12.|

## See Also
 [Controlling Options Settings](https://msdn.microsoft.com/library/a09ed242-7494-4cde-bbd1-7a8ec617965d)
 [Determining the Names of Property Items on Options Pages](https://msdn.microsoft.com/library/d450422d-47c7-4eeb-9f9f-3286264bc5aa)
 [Options Page, Environment Node Properties](../../ide/reference/options-page-environment-node-properties.md)
 [Options Page, Text Editor Node Properties](../../ide/reference/options-page-text-editor-node-properties.md)
