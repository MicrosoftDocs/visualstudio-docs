---
title: "Prepare a Domain Controller Virtual Machine Using SCVMM"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c3a4929f-c2e4-4792-986d-4623ce1f4432
caps.latest.revision: 11
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
# Prepare a Domain Controller Virtual Machine Using SCVMM
A virtual environment that uses network isolation requires that the virtual machines in the environment must be either in a workgroup or joined to a private domain that is served by a domain controller (DC) virtual machine within the environment. Among the steps to set up an environment that uses network isolation is to prepare a domain controller virtual machine. For more information about the other steps, see [Creating and using a network isolated environment](../test/creating-and-using-a-network-isolated-environment.md).  
  
 **Required Permissions**  
  
 To perform these procedures, you must be a member of the following groups:  
  
-   Either the **Administrator** user role or the **Self-Service User** role in System Center Virtual Machine Manager (SCVMM).  
  
 For more information about SCVMM roles, see [Managing User Roles](http://go.microsoft.com/fwlink/?LinkId=185869).  
  
### To prepare a domain controller virtual machine  
  
1.  Use SCVMM Administrator Console to create a new virtual machine with the Windows Server 2008 R2 operating system.  
  
    1.  We recommend that you use a new installation of the operating system instead of reusing or customizing an existing image.  
  
    2.  Make sure that you allocate at least 1GB of memory your virtual machine.  
  
2.  Install Active Directory and DNS server roles in the virtual machine. For more information about how to install Active Directory on Windows Server 2008 R2, see [AD DS Installation and Removal Step-by-Step Guide](http://go.microsoft.com/fwlink/?LinkId=237610).  
  
    1.  [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] does not support use of separate virtual machines in an environment for Active Directory and DNS.  
  
    2.  Make sure that the domain controller is the only DC in the forest and that it is the root of the forest.  
  
    3.  Do not use a domain name that is already used in your corporate or lab network. For example, if one of the domains in your network is called test.contoso.com, do not use the same name for your private domain.  
  
3.  Install the test agent on the domain controller virtual machine. For more information, see [Install and configure test agents](../test/install-and-configure-test-agents.md).  
  
4.  Verify that the Active Directory and DNS are installed correctly.  
  
5.  If the virtual machine was ever connected to a network, make sure that the only DNS entries are for the virtual machine. You only have to perform these steps one time: after you install Active Directory and DNS and before you store the virtual machine into library. Perform these steps and then immediately shut down the virtual machine. If you restart the virtual machine after you perform these steps, or if you leave the virtual machine running for a long time after you perform these steps, you must repeat them.  
  
    1.  Open the DNS tool by clicking **Start**, **Administrative Tools**, and then **DNS**.  
  
    2.  In the DNS tool, navigate to **Forward Lookup Zones**. Select each zone that is listed under **Forward Lookup Zones**. Then delete all the DNS entries under that zone that have an IP address listed in the **Data** column.  
  
    3.  In the DNS tool, navigate to **Reverse Lookup Zones**. If any reverse lookup zone is configured, delete all the DNS entries under that zone.  
  
    4.  Close the DNS tool.  
  
6.  Shut down the virtual machine, and store it in the SCVMM library.  
  
    1.  Do not turn off the Active Directory VM. You have to shut it down correctly.  
  
    2.  Do not generalize the Active Directory VM, either by running Sysprep or by storing the virtual machine as a template in SCVMM.  
  
## See Also  
 [Creating and using a network isolated environment](../test/creating-and-using-a-network-isolated-environment.md)   
 [Configure Lab Management for SCVMM environments](../test/configure-lab-management-for-scvmm-environments.md)