---
title: "How to: View Script Documents | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Script Explorer"
ms.assetid: 8b621e53-4508-4b4a-9995-70995b0b9ac8
caps.latest.revision: 25
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: View Script Documents
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In earlier versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], client-side script files generated from server-side script appeared in the Script Explorer window. The Script Explorer window was often hidden, so that the availability of client-side script was not always obvious.  
  
 In [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)], client-side script files generated from server-side script appear in Solution Explorer, which is visible by default. The Script Explorer window has been eliminated.  
  
 Client-side script files are visible only when you are in debug mode or break mode. They appear in the **Script Documents** node.  
  
 Server-side script files are always visible. They appear in the **\<Website Pathname>** node. The name of the node resembles this example: `c:\...\Website2\`  
  
### To view a server-side script document  
  
1. In **Solution Explorer**, open the **\<Website Pathname>** node.  
  
2. Double-click the script file that you want to view.  
  
     The server-side script file opens in a source window.  
  
### To view a client-side script document  
  
1. In **Solution Explorer**, open the **Script Documents** node.  
  
2. Double-click the script file that you want to view.  
  
     The client-side script file opens in a source window.  
  
## See Also  
 [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)
