---
title: "Options Page, Fonts and Colors Node Properties | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Tools Options settings, Fonts and Colors node properties"
  - "automation [Visual Studio], controlling Tools Options"
ms.assetid: 8e1ab784-5f85-4e2b-8ef9-e5d59ca4dbcb
caps.latest.revision: 8
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
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
# Options Page, Fonts and Colors Node Properties
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
 [Controlling Options Settings](../Topic/Controlling%20Options%20Settings.md)   
 [Determining the Names of Property Items on Options Pages](../Topic/Determining%20the%20Names%20of%20Property%20Items%20on%20Options%20Pages.md)   
 [Options Page, Environment Node Properties](../../ide/reference/options-page-environment-node-properties.md)   
 [Options Page, Text Editor Node Properties](../../ide/reference/options-page-text-editor-node-properties.md)