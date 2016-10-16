---
title: "How to: Connect to machines in a Lab Environment"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio ALM, connect to a virtual environment"
  - "virtual environments [Lab Management], connect to"
ms.assetid: 1a1a9408-5310-4201-9bdc-424378cd5080
caps.latest.revision: 33
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
# How to: Connect to machines in a Lab Environment
You can connect to the physical and virtual machines in a [!INCLUDE[vstsLabLong](../test/includes/vstslablong_md.md)] environment through Windows Remote Desktop just as you connect to any machine on the network. You can also connect by using Microsoft Environment Viewer.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
 You can interact with the lab environments you create by using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] and Microsoft Environment Viewer, an additional tool that is included in [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]. You can connect only to deployed environments. Whether you can open a remote connection to each machine in the environment depends on the state of that machine.  
  
 ![Steps to connect to an enevironment](../test/media/connect_environment.png "Connect_Environment")  
  
### To connect to a lab environment  
  
1.  In [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], choose **Lab Center**, and then choose the **Lab** tab.  
  
2.  Choose the lab environment to connect to.  
  
3.  Choose **Connect**.  
  
## Host-based and Guest-based Connections  
 The Microsoft Environment Viewer uses two types of connections:  
  
-   Host-based  
  
-   Guest-based  
  
 The Microsoft Environment Viewer automatically determines the correct type of connection, based on the client operating system and your identity. You cannot manually select the type of connection.  
  
### Host-based Connections  
 These remote connections are routed through the hosts on which the virtual machines reside. They use the Hyper-V’s "Virtual Machine Connection" protocol. Because they are routed through the host, these connections let you interact with virtual machines even while they are turning on, shutting down, or when the virtual machine’s network is not completely formed. The virtual machines do not have to have an IP address or even a guest operating system. This form of connection is important, for example, if you want to install an operating system on the virtual machines of an environment, or if you must customize the operating system.  
  
 Environment Viewer uses a host-based connection automatically when both the following conditions are satisfied:  
  
-   The client from which you start the Microsoft Environment Viewer and connect to the environment is one of the following:  
  
    -   [!INCLUDE[winxp](../codequality/includes/winxp_md.md)] SP3 (For clients that run this operating system, you must follow the instructions in [Description of the Credential Security Service Provider (CredSSP) in Windows XP Service Pack 3](http://go.microsoft.com/fwlink/?LinkId=166121) and in [When I use the Virtual Machine Connection tool to connect to a virtual machine on a Windows Server 2008 Hyper-V-based computer I receive an error message: "A connection will not be made because credentials may not be sent to the remote computer"](http://go.microsoft.com/fwlink/?LinkId=179578).)  
  
    -   [!INCLUDE[windowsver](../deployment/includes/windowsver_md.md)] SP1 and later versions  
  
    -   [!INCLUDE[win7](../codequality/includes/win7_md.md)]  
  
    -   [!INCLUDE[firstref_longhorn](../test/includes/firstref_longhorn_md.md)]  
  
     If the client has any other version of the operating system, you cannot get a host-based connection to any virtual machine.  
  
-   The user who started Microsoft Environment Viewer is the creator of the environment. This is the person who originally created the environment.  
  
 There can only be one active host-based connection to an environment at a given time. Therefore, when one user is connected to an environment by using a host-based connection and another user tries the same type of connection, the first user is disconnected. Use the **In use** feature of environment to indicate that you are working on an environment and do not want other users to connect to it. [!INCLUDE[crabout](../codequality/includes/crabout_md.md)] how to turn on **In use**, see [Viewing and Modifying Properties of an SCVMM Environment](../test/viewing-and-modifying-properties-of-an-scvmm-environment.md).  
  
### Guest-based Connections  
 If any one of the conditions listed in the host-based connections section is not satisfied, Environment Viewer uses a guest-based connection. This connection directly uses Remote Desktop Protocol (RDP) to the virtual or physical machine. For this connection, the machine has to be turned on, its network stack should be working, its remote desktop connections must be enabled, and the user who is connecting to the machine should be a member of "Remote Desktop Users" on the machine. These connections only work with physical and virtual machines that support RDP.  
  
> [!NOTE]
>  When you are connected to the lab environment using a remote desktop or guest-based connection, you might experience frequent, unexpected disconnects. One possible cause of the loss of the connection is that the machine is configured to automatically log on to the network. Remove the automatic logon configuration. If the problem persists, contact your system administrator.  
  
 Although host-based connections are better for interacting with machines when they are turning on or powering up, guest-based connections usually have better performance characteristics and have additional features such as "copy to clipboard" and access to local devices. The ‘"copy to clipboard" capability of RDP lets users copy and paste text, images, and other objects between the client’s desktop and the virtual machine’s desktop.  
  
 The number of guest-based connections to an environment depends on the operating systems in its virtual machines. If the operating system on the machine is a client operating system such as [!INCLUDE[winxp](../codequality/includes/winxp_md.md)], there can be only one RDP connection. If the operating system on the machine is a client operating system such as [!INCLUDE[windowsver](../deployment/includes/windowsver_md.md)] or [!INCLUDE[win7](../codequality/includes/win7_md.md)], there can be multiple connections, but only one can be active at a given time. If the operating system on the machine is a server operating system such as Windows 2003 Server or later, then there can be multiple RDP connections, depending on how RDP was configured on the machine.  
  
## Connecting to a Domain Controller Virtual Machine  
 If you are working with a network-isolated environment that includes a domain controller virtual machine, communication to this virtual machine is possible only through a host-based connection or from another virtual machine in the environment. This is because [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] configures the domain controller virtual machine not to have external connectivity. To connect to the domain controller virtual machine follow these steps:  
  
-   From a machine with [!INCLUDE[windowsver](../deployment/includes/windowsver_md.md)] SP1 and later versions or [!INCLUDE[win7](../codequality/includes/win7_md.md)] clients, log on as the creator of the environment. This will make sure that you get a host-based connection.  
  
-   If that is not possible, connect to one of the other virtual machines in the environment. From that other machine, open an RDP connection to the domain controller virtual machine.  
  
## Operating a Standard Environment  
 After you are connected to a standard environment, you can perform the following operations on that environment through Microsoft Environment Viewer.  
  
-   Environment state operations: Refresh status, Mark "In use".  
  
 While you interact with the selected virtual or physical machine, you can follow these steps using Microsoft Environment viewer:  
  
-   Send CTRL+ALT+DEL keys to the virtual machine.  
  
-   View the desktop of the virtual machine in full-screen mode.  
  
-   Reconnect to the machine if the connection is lost.  
  
-   Open the machine with the Remote Desktop Connection application.  
  
## Operating a SCVMM Environment  
 After you are connected to an environment, you can perform the following operations on that environment through Microsoft Environment Viewer.  
  
-   Environment state operations: Start, Pause, Shutdown, Power off, Refresh status, Mark "In use".  
  
-   Environment snapshot operations: Take snapshot, Restore to previous or selected snapshot, Rename snapshot, Delete snapshot, Share snapshot.  
  
-   Capability operations: View status, Reset test and workflow integration capabilities.  
  
 While you interact with the selected virtual machine, you can follow these steps using Microsoft Environment viewer:  
  
-   Send CTRL+ALT+DEL keys to the virtual machine.  
  
-   View the desktop of the virtual machine in full-screen mode.  
  
-   View the system information about the virtual machine. System information contains computer name, internal computer name (for network-isolated environments), and SCVMM virtual machine name.  
  
 [!INCLUDE[crabout](../codequality/includes/crabout_md.md)] the operations that you can perform on a SCVMM environment, see [How to: Operate an SCVMM Environment](../test/how-to--operate-an-scvmm-environment.md).  
  
## External resources  
  
### Guidance  
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 3: Lab Environments](http://go.microsoft.com/fwlink/?LinkID=255192)  
  
## See Also  
 [Creating Lab Environments](../test/creating-lab-environments.md)