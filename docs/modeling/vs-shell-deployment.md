---
title: "VS Shell deployment | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.topic: "article"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
ms.technology: vs-ide-modeling
---
# VS Shell deployment

An isolated shell lets you determine which Visual Studio functionality you need to interact with your domain-specific language and how that solution should appear. For more information about the Visual Studio isolated shell, see [Customizing the Isolated Shell](../extensibility/customizing-the-isolated-shell.md).

## To set a Visual Studio Shell as the Deployment Target
  
1.  In the **DslPackage** project, open **source.extension.tt**.  
  
2.  Under `<SupportedProducts>` insert:  
  
    ```  
    <IsolatedShell Version="1.0">MyIsolatedShell</IsolatedShell>  
    ```  
  
     Replace *MyIsolatedShell* with the name of your isolated shell package.