---
title: "How to: View Script Documents | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Script Explorer"
ms.assetid: 8b621e53-4508-4b4a-9995-70995b0b9ac8
caps.latest.revision: 22
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
# How to: View Script Documents
In earlier versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], client-side script files generated from server-side script appeared in the Script Explorer window. The Script Explorer window was often hidden, so that the availability of client-side script was not always obvious.  
  
 In [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)], client-side script files generated from server-side script appear in Solution Explorer, which is visible by default. The Script Explorer window has been eliminated.  
  
 Client-side script files are visible only when you are in debug mode or break mode. They appear in the **Script Documents** node.  
  
 Server-side script files are always visible. They appear in the **\<Website Pathname>** node. The name of the node resembles this example: `c:\...\Website2\`  
  
### To view a server-side script document  
  
1.  In **Solution Explorer**, open the **\<Website Pathname>** node.  
  
2.  Double-click the script file that you want to view.  
  
     The server-side script file opens in a source window.  
  
### To view a client-side script document  
  
1.  In **Solution Explorer**, open the **Script Documents** node.  
  
2.  Double-click the script file that you want to view.  
  
     The client-side script file opens in a source window.  
  
## See Also  
 [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)