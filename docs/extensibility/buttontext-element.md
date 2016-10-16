---
title: "ButtonText Element"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "ButtonText element (VSCT XML schema)"
  - "VSCT XML schema elements, ButtonText"
ms.assetid: 56aba884-0356-4894-ae4e-32d3938f6865
caps.latest.revision: 6
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# ButtonText Element
This field lets you specify the text that appears in various menus. By default, the `ButtonText` element appears in menu controllers. The `ButtonText` element also becomes the default if the other text fields are blank. The `ButtonText` element cannot be blank even if the other text fields are specified.  
  
## Syntax  
  
```  
<ButtonText>My Command</ButtonText>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Strings Element](../extensibility/strings-element.md)|Groups text elements, such as `ButtonText` and `CommandName`.|  
  
## Text Value  
 The text value of the `ButtonText` element provides the text that is displayed for menu items, combos, and other user interface (UI) elements that have visible text.  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/visual-studio-command-table--.vsct--files.md)