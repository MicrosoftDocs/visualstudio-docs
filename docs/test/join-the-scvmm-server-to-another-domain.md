---
title: "Join the SCVMM server to another domain"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: fa6fe08e-ddee-40fc-851a-76a771b441e0
caps.latest.revision: 2
ms.author: "ahomer"
manager: "douge"
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
# Join the SCVMM server to another domain
Occasionally, it might be necessary to change your [!INCLUDE[vstsTfsShort](../modeling/includes/vststfsshort_md.md)] from one active directory domain to another, or from a workgroup to a domain. For more information, see [Move TFS to a new domain ( environment move)](../Topic/Move%20Team%20Foundation%20Server%20from%20one%20environment%20to%20another.md). As part of this task, you should move SCVMM and Lab Management to the new domain.  
  
 In order to move an SCVMM server to a domain, or change its domain, you must re-install SCVMM. Therefore, you have to save the virtual machines and templates, and then re-define the environments in the new installation. This topic describes this procedure in more detail.  
  
### Uninstall SCVMM  
  
1.  Remove the hosts and library servers from the SCVMM server.  
  
    1.  Open the Virtual Machine Manager Administrator Console:  
  
         Choose **Start**, **Microsoft System Center**, **Virtual Machine Manager**, **Virtual Machine Manager Administrator Console**.  
  
    2.  Delete the library servers.  
  
    3.  Delete the host groups.  
  
2.  Delete all lab artifacts from [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] Library Center:  
  
     In the **Lab** tab, delete the environments. In the **Library** tab, delete the virtual machines and the environments.  
  
     Because the hosts and library servers are no longer associated with SCVMM, removing these items from [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] does not delete the actual virtual machines and VHDs.  
  
3.  Unconfigure SCVMM from Team Foundation Server.  
  
    1.  Log on to the Team Foundation Server as *tfsadmin*.  
  
    2.  Open **Team Foundation Administrator Console**.  
  
    3.  In the **Application Tier** node, choose **Lab Management**, then choose **Reconfigure Lab Management**.  
  
    4.  Delete the links between the library shares and the team project collection.  
  
4.  Uninstall SCVMM from the computer on which it was installed.  
  
### Join the computers to domain  
  
1.  Change the domain of the hosts and library servers.  
  
2.  Change the domain of the SCVMM server computer.  
  
### Re-install SCVMM and rebuild artifacts  
  
1.  Re-install SCVMM on its computer.  
  
2.  Add the hosts and library servers back to SCVMM.  
  
     For more information, see the SCVMM section in [Configure Lab Management for SCVMM environments](../test/configure-lab-management-for-scvmm-environments.md).  
  
3.  If any of the virtual machines has to be joined to the new domain, do so.  
  
     Network isolated environments have their own domain or workgroup. Therefore, their constituent machines do not have to be altered.  
  
4.  Configure the new SCVMM to couple it to your team project collection.  
  
     Set the new lab service account in Team Foundation Server.  
  
     For more information, see the SCVMM section in [Configure Lab Management for SCVMM environments](../test/configure-lab-management-for-scvmm-environments.md).  
  
5.  Using [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)], re-import the virtual machines and templates into the Library.  
  
     For more information, see [How to: Import a Virtual Machine or Template from SCVMM](../test/how-to--import-a-virtual-machine-or-template-from-scvmm.md).  
  
6.  Compose virtual machines into environments in [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
     For more information, see [How to: Store an SCVMM Environment](../test/how-to--store-an-scvmm-environment.md).