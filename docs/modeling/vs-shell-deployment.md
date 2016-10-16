---
title: "VS Shell deployment"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: be8f2ffe-a322-4ac0-9c9e-873bd28e5d5e
caps.latest.revision: 2
ms.author: "awills"
manager: "kamrani"
---
# VS Shell deployment
An isolated shell lets you determine which Visual Studio functionality you need to interact with your domain-specific language and how that solution should appear. For more information about the Visual Studio isolated shell, see [Customizing the Isolated Shell](../extensibility/customizing-the-isolated-shell.md). You can find more information about how to customize the isolated shell in [Customizing the Isolated Shell](assetId:///d75463cd-1155-42e4-8b7a-046ed6becbbf).  
  
### To set a Visual Studio Shell as the Deployment Target  
  
1.  In the **DslPackage** project, open **source.extension.tt**.  
  
2.  Under `<SupportedProducts>` insert:  
  
    ```  
    <IsolatedShell Version="1.0">MyIsolatedShell</IsolatedShell>  
    ```  
  
     Replace *MyIsolatedShell* with the name of your isolated shell package.