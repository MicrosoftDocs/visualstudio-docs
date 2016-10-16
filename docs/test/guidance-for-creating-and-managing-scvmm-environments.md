---
title: "Guidance for Creating and Managing SCVMM Environments"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio ALM, virtual environment guidelines"
ms.assetid: c2a27867-15df-4b42-8896-630562e5991c
caps.latest.revision: 46
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
# Guidance for Creating and Managing SCVMM Environments
To create or manage an SCVMM environment, you need to know which approach to choose, consider how each one manages virtual machines, and how each one avoids name conflicts. The options are:  
  
-   Stored virtual machines and templates  
  
-   Stored environment  
  
-   Network isolation  
  
-   Running virtual machines  
  
 Name conflicts can occur in or between lab environments when multiple machines on a network have the same unique identifier. Each virtual machine has several identifiers, including:  
  
-   Computer name - Also known as the machine name or host name, each virtual machine has one computer name.  
  
-   Media Access Control (MAC) address – The unique, unchanging value built into the hardware of a physical network adapter. Each virtual machine can have multiple, virtualized network adapters, each of which has its own MAC address.  
  
-   Windows security identifier (SID) – Each virtual machine that runs Windows has its own, unchanging computer SID.  
  
-   Internet Protocol (IP) address – Each network adapter (whether physical or virtual) can have multiple IP addresses, although in most cases each adapter has only one IP address. Most environments rely on DNS and DHCP servers to manage IP addresses automatically, but you can also manually assign or change an IP address.  
  
 If multiple copies of a virtual machine are running on a domain or workgroup and share one or more of these identifiers, a naming conflict can and frequently will occur. The , results can include a machine being disconnected from the network, or network traffic being sent to the wrong machine.  
  
 Each of these sections describes how to manage virtual machines and their name conflicts, so that you can choose the one that best meets your needs.:  
  
-   [Using stored virtual machines and templates](#storedvm)  
  
-   [Using a stored environment](#deployedenvironment)  
  
-   [Using Network Isolation](#networkisolation)  
  
-   [Using running virtual machines](#runningvm)  
  
 For an introduction to lab environments, see [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
###  <a name="storedvm"></a> Using stored virtual machines and templates  
 You can create a new SCVMM environment by choosing virtual machines and virtual machine templates that are stored in your Lab Management library. Each virtual machine stored in your Lab Management library has its own machine name and other identifiers. When you add a stored virtual machine to a lab environment, the name and identifiers are not changed to avoid name conflicts.  
  
 A virtual machine template is similar to a stored virtual machine, except that the template does not contain a machine name or any other unique identifier. When you add a template to your environment, [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] creates a new virtual machine based on that template. To avoid name conflicts, you must then create a unique identity for each of those virtual machines before you add them to the environment. However, you can use [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] to auto-generate the identity of each virtual machine. We recommend that you use templates instead of stored virtual machines unless you need to deploy a virtual machine that includes specific unique identifiers.  
  
 ![Creating an environment from templates and  VMs](../test/media/lmguide_vmtemplate.png "LMGuide_VMTemplate")  
  
 **Advantages**  
  
-   You can run multiple copies of the environment at the same time.  
  
-   If an app that you preinstall on the virtual machine is not affected by changing the identity of the virtual machines, you can easily deploy the environment.  
  
-   You can run any number or size of virtual machines in the environment.  
  
 **Disadvantages**  
  
-   To run multiple copies of a stored virtual machine, you must change the identify information of each copy. You can automate this process by using templates.  
  
-   If an app malfunctions when you change the machine identity, you can't preinstall that app on a stored virtual machine. Instead, you need to install the app after you deploy the stored virtual machine.  
  
-   Only one snapshot of an environment can run at a time. For example, if a tester finds a bug, she can create a snapshot of the state of the environment. However, she cannot continue running that environment while a developer investigates the bug in the snapshot.  
  
 You can store any combination of virtual machine and templates in your team project library. When you choose which ones to deploy, consider how you need to avoid naming conflicts in a domain. For information about creating an SCVMM environment using stored virtual machines and templates, see [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md).  For information about managing an SCVMM environment that includes stored virtual machines or templates, see [Managing Lab Environments and Virtual Machines](../test/managing-lab-environments-and-virtual-machines.md).  
  
###  <a name="deployedenvironment"></a> Using a stored environment  
 A stored environment is an SCVMM environment that is stored in your Team Project Library. After you create a stored environment, you can deploy a copy of it. The virtual machines in a stored environment can be stored virtual machines or templates. When you deploy a stored environment, you usually need to customize the names of its virtual machines. You must customize each stored virtual machine manually, but you can automatically customize each one created from a template.  
  
 ![Deploying environments from stored environments](../test/media/lmguide_createenv.png "LMGuide_CreateEnv")  
  
 **Advantages**  
  
-   You can build a complex lab environment once, and then re-deploy it many times, with minimal risk of accidentally building it wrong.  
  
     You can run multiple copies of the environment at the same time.  
  
-   If an app that you preinstall on the virtual machine is not affected by changing the identity of the virtual machines, you can easily deploy the environment.  
  
-   You can run any number or size of virtual machines in the environment.  
  
 **Disadvantages**  
  
-   To run multiple copies of a stored virtual machine, you must change the identify information of each copy. You can automate this process by using templates.  
  
-   If an app malfunctions when you change the machine identity, you can't preinstall that app on a stored virtual machine. Instead, you need to install the app after you deploy the stored virtual machine.  
  
-   Only one snapshot of an environment can run at a time. For example, if a tester finds a bug, she can create a snapshot of the state of the environment. However, she cannot continue running that environment while a developer investigates the bug in the snapshot.  
  
 For information about how to deploy a copy of a stored environment, see [Deploying a Stored SCVMM Environment](../test/deploying-a-stored-scvmm-environment.md). For information about how to store an SCVMM environment in your Team Project Library, see [How to: Store an SCVMM Environment](../test/how-to--store-an-scvmm-environment.md).  
  
###  <a name="networkisolation"></a> Using Network Isolation  
 If you want to run multiple identical copies of a lab environment at the same time, you must enable network isolation. An SCVMM environment that uses network isolation to avoid naming conflicts is called a network isolated environment. The machines in a network-isolated environment are protected from network conflicts by using two network adapters. One network adapter is used for a private network inside the environment. The second adapter is configured by [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] to present a separate, unique identity to the external network. The NetBIOS broadcast of the computer is disabled on the second adapter and the [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] identity is registered as an alias for the machine. This separate identity enables two-way communication between the virtual machines in the environment and the external network, even though multiple copies of the environment are running.  
  
 You can store a network isolated environment so that you can deploy multiple copies of it at the same time. When you deploy a copy of a network isolated environment, the corresponding virtual machines in the two copies are exact duplicates of each other, because the identities of the machines within the private network remain the same each time that they are deployed. The aliases of the virtual machines on the external network make sure that that network conflicts do not occur between the two environments.  
  
 You create a network isolated environment by choosing the network isolation capability when you create the environment from virtual machines or templates. Optionally, you install applications, or connect the virtual machines to the private network. You can then store a copy of the environment to the Library. Team members can deploy multiple copies of the stored environment at the same time.  
  
 **Advantages**  
  
-   You can run identical copies of your lab environments at the same time.  
  
-   Because the identities of the machines do not change, you can avoid reconfiguring or reinstalling some applications.  
  
-   You can run multiple snapshots of an environment at the same time.  
  
 **Disadvantages**  
  
-   All virtual machines in an isolated network must run on a single host computer. This also means that those virtual machines can’t run on clustered hosts.  
  
-   If the virtual machines in an isolated environment are members of a domain, the environment must include one or more virtual machines that act as the domain controller and DNS server. The domain can't be hosted on a virtual or physical computer that is outside the network isolated environment. An additional machine is not required for private workgroups.  
  
-   Each virtual machine in the environment has at least two network adapters, which are created when you enable network isolation. If your tests require an application that is not compatible with this configuration, you cannot use a network isolated environment.  
  
 For more information about network isolation, see [Cloning Virtual Machines through Network Isolation](../test/cloning-virtual-machines-through-network-isolation.md). For information about how to create a network isolated environment, see [Creating and using a network isolated environment](../test/creating-and-using-a-network-isolated-environment.md).  
  
###  <a name="runningvm"></a> Using running virtual machines  
 You can create an SCVMM environment by using virtual machines that are already running on your SCVMM host group. These virtual machines aren’t copied, but are instead included directly in your lab environment. A running virtual machine can be used in only one lab environment at a time. After you delete a lab environment, you can reuse its virtual machines in another lab environment.  
  
 **Advantages**  
  
-   This process is faster than deploying stored virtual machines or templates.  
  
-   If you run tests on virtual machines without using Lab Management, you can transition to Lab Management without recreating those virtual machines.  
  
 **Disadvantages**  
  
-   You cannot configure network isolation on a lab environment that includes running virtual machines.  
  
-   You can’t run multiple identical copies of these environments at the same time. Instead, you must change the unique identities of the virtual machines.  
  
 For more information about how to create an SCVMM environment using running virtual machines, see [SCVMM (virtual) environments](../test/scvmm--virtual--environments.md). For information about managing an SCVMM environment that includes running virtual machines, see [Managing Lab Environments and Virtual Machines](../test/managing-lab-environments-and-virtual-machines.md).  
  
## See Also  
 [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md)