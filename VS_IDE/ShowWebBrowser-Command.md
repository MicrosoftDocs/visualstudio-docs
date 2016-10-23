---
title: "ShowWebBrowser Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c6a4fbd6-8e9d-45cc-8b2f-93990d065e78
caps.latest.revision: 11
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# ShowWebBrowser Command
Displays the URL you specify in a Web browser window either within the integrated development environment (IDE) or external to the IDE.  
  
## Syntax  
  
```  
View.ShowWebBrowser URL [/new][/ext]  
```  
  
## Arguments  
 `URL`  
 Required. URL (Uniform Resource Locator) for the Web site.  
  
## Switches  
 /new  
 Optional. Specifies that the page appears in a new instance of the Web browser.  
  
 /ext  
 Optional. Specifies that the page appears in the default Web browser outside of the IDE.  
  
## Remarks  
 The alias for the **ShowWebBrowser** command is **navigate** or **nav**.  
  
## Example  
 The following example displays the MSDN Online home page in a Web browser outside of the IDE. If an instance of the Web browser is already open, it is used; otherwise a new instance is launched.  
  
```  
>View.ShowWebBrowser http://msdn.microsoft.com /ext  
```  
  
## See Also  
 [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md)   
 [Command Window](../VS_IDE/Command-Window.md)   
 [Find/Command Box](../VS_IDE/Find-Command-Box.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)