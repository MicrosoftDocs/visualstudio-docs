---
title: "Repairing Lab Environments"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b6625544-f5cd-42ee-9e6b-2682704a1bdb
caps.latest.revision: 9
manager: douge
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
# Repairing Lab Environments
When you view your lab environment in the **Environments** tab in **Lab Center**, the status might be in the **Not Ready** state and display the error message, “The environment has one or more errors.” This indicates that your environment is not ready to be used for manual or automated testing or with build, deploy, and test workflows. This error might indicate one of the following problems:  
  
-   The installation or configuration of a test agent on one or more of the machines in your environment failed.  
  
-   There is a communication problem between one of the test agents in your environment, and your test controller.  
  
-   The test controller or the test agent process has shut down or is not functioning.  
  
-   The user account of the test agent or the lab service account cannot be authenticated by the test controller.  
  
-   Your Team Foundation Server has been upgraded, but your lab management components have not been upgraded.  
  
    > [!WARNING]
    >  If you are upgrading your lab management components, you must upgrade your test controller before you repair your environment. For information on upgrading your test controller, see [Upgrading Test Controllers from Visual Studio 2010](assetId:///9cb10ae4-4586-4d42-a75c-e2e9749f4fda).  
  
 To address any of these problems, you need to repair your environment.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, Visual Studio Test Professional  
  
#### Repairing the environment  
  
1.  Choose your environment in the **Environments** list.  
  
2.  Choose **Repair Environment** from the shortcut menu of your environment.  
  
3.  The **Status** of your environment will change to **Repairing**.  
  
4.  If the repair is successful, the **Status** of the environment will change to **Ready**.  
  
## See Also  
 [Troubleshooting Lab Management](../dv_TeamTestALM/Troubleshooting-Lab-Management.md)   
 [Using a Lab Environment for Your Application Lifecycle](../dv_TeamTestALM/Using-a-Lab-Environment-for-Your-Application-Lifecycle.md)