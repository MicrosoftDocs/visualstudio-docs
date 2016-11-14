---
title: "Warning: Script Debugging Disabled | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.scriptdisabled"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 323d2b1d-52a4-42f7-b4ad-96b4b0c23b8d
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
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
# Warning: Script Debugging Disabled
Script Debugging is currently disabled in Internet Explorer  
  
 This warning occurs when you try to debug script without enabling script debugging in Internet Explorer. For security reasons, Internet Explorer disables script debugging by default.  
  
### To enable script debugging in Internet Explorer  
  
1.  On the Internet Explorer **Tools** menu, choose **Internet Options**.  
  
2.  In the **Internet Options** dialog box, click the **Advanced** tab.  
  
3.  On the **Advanced** tab, look in the **Settings** box, **Browsing** category.  
  
4.  Clear **Disable Script Debugging (Internet Explorer)**.  
  
5.  Click **OK**.  
  
6.  Exit and restart Internet Explorer.  
  
     The new settings will now be in effect.  
  
## See Also  
 [How to: Attach to Script](../debugger/how-to-attach-to-script.md)