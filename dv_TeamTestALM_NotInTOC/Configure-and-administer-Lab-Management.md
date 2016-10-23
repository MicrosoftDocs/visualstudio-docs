---
title: "Configure and administer Lab Management"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 13a4c6e6-3287-427d-963c-28b0abecb879
caps.latest.revision: 32
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
# Configure and administer Lab Management
Visual Studio Lab Management lets you create and manage lab environments for a team project on Team Foundation Server. Use lab environments to develop, test, or run your application. Each machine in a lab environment represents a role required for the application that you intend to develop, test, or run. For example, you might be developing a multi-tiered application that requires three roles: a desktop client, a web server, and a database server. There are two types of lab environments: standard environments and SCVMM environments. A standard environment can contain physical machines and virtual machines using any virtualization platform. An SCVMM environment can only contain virtual machines that are managed by SCVMM on the Hyper-V virtualization platform. For more information about lab environments, see [Using a Lab Environment for Your Application Lifecycle](../dv_TeamTestALM/Using-a-Lab-Environment-for-Your-Application-Lifecycle.md).  
  
## Tasks  
 Use the following topics to help you configure and administer Lab Management:  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Setting up Lab Management for the first time:** To use Lab Management to create standard environments, you need to set up a test controller. To use Lab Management to create SCVMM environments, you must first configure Hyper-V and SCVMM.|-   [Configure Lab Management for SCVMM environments](../dv_TeamTestALM/Configure-Lab-Management-for-SCVMM-environments.md)|  
|**Changing your Lab Management configuration:** You might want to add more host groups, change the library share that is used, modify the integration service account, or add build controllers or test controllers after you have configured Lab Management for the first time.|-   [Change Existing Lab Management Configurations](../dv_TeamTestALM/Change-Existing-Lab-Management-Configurations.md)|  
|**Assigning users permissions to use Lab Management resources:** The default Team Foundation Server security groups automatically give members certain permissions to use Lab Management resources. You might want to modify those permissions or assign permissions to custom groups or users.|-   [Manage user permissions for Lab Management](../dv_TeamTestALM/Manage-user-permissions-for-Lab-Management.md)|  
|**Backing up and restoring your lab environments:** You can back up and restore your lab environments.|-   [Back up and restore TFS](../Topic/Back%20up%20and%20restore%20TFS.md)<br />-   [Restore Lab Management components](../Topic/Restore%20Lab%20Management%20components.md)|  
  
## Forums  
 [Visual Studio Lab Management](http://go.microsoft.com/fwlink/?LinkId=211860)  
  
## Blogs  
 [Visual Studio Lab Management team blog](http://go.microsoft.com/fwlink/?LinkId=211862)  
  
## See Also  
 [Using a Lab Environment for Your Application Lifecycle](../dv_TeamTestALM/Using-a-Lab-Environment-for-Your-Application-Lifecycle.md)   
 [Administer](../Topic/Administer%20Team%20Foundation%20Server.md)