---
title: "VS Shell deployment | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
---
# VS Shell deployment
An isolated shell lets you determine which Visual Studio functionality you need to interact with your domain-specific language and how that solution should appear. For more information about the Visual Studio isolated shell, see [Customizing the Isolated Shell](../extensibility/customizing-the-isolated-shell.md). You can find more information about how to customize the isolated shell in [Customizing the Isolated Shell](http://msdn.microsoft.com/en-us/d75463cd-1155-42e4-8b7a-046ed6becbbf).  
  
### To set a Visual Studio Shell as the Deployment Target  
  
1.  In the **DslPackage** project, open **source.extension.tt**.  
  
2.  Under `<SupportedProducts>` insert:  
  
    ```  
    <IsolatedShell Version="1.0">MyIsolatedShell</IsolatedShell>  
    ```  
  
     Replace *MyIsolatedShell* with the name of your isolated shell package.