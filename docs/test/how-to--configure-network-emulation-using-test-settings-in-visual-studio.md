---
title: "How to: Configure Network Emulation Using Test Settings in Visual Studio"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "test settings, network emulation"
ms.assetid: ff275cfb-5df9-4710-9a91-9caabaaad34f
caps.latest.revision: 80
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
# How to: Configure Network Emulation Using Test Settings in Visual Studio
You can configure the diagnostic data adapter to test your application under various network environments from [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] and Visual Studio. It can also be configured to test an artificial network load, or bottleneck, when you run your tests.  
  
> [!CAUTION]
>  If you run your tests on a real network that is a slower type than the network you are emulating, the test will still run at the slower network speed. The emulation can only slow down the network environment, not speed it up.  
  
 The following procedure describes how to configure network emulation from the configuration editor. These steps apply to both the configuration editor in [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] and Visual Studio.  
  
> [!NOTE]
>  The network emulation diagnostic data adapter is only applicable to Visual Studio test settings. It is not used for test settings in [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
 An account that has administrator privileges must be used for network emulation. If you have selected network emulation for a local role that runs manual tests, you must start [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] by using administrator privileges. If you have selected network emulation for any other role, you must verify that the test agent on the machine for that role uses a user account that is a member of the administrators group. For more information about how to set up the account for your test agent, see [Install and configure test agents](../test/install-and-configure-test-agents.md).  
  
> [!NOTE]
>  The Network Service account, which is the default account for the test agent, is not a member of the administrators group.  
  
 The network setting offers the following network emulation types:  
  
-   LAN (default)  
  
-   3G  
  
-   Cable-DSL-1.5Mbps  
  
-   Cable-DSL-768k  
  
-   Cable/DSL-384k  
  
-   CDMA  
  
-   Dial-up 56k  
  
-   Intercontinental slow WAN 300 Kbps  
  
-   Intercontinental WAN 1.5 Mbps  
  
-   Intracontinental WAN 1.5 Mbps  
  
 **True Network Emulation**  
  
 Visual Studio uses software-based true network emulation for all test types. This includes load tests. True network emulation simulates network conditions by direct manipulation of the network packets. The true network emulator can emulate the behavior of both wired and wireless networks by using a reliable physical link, such as an Ethernet. The following network attributes are incorporated into true network emulation:  
  
-   Round-trip time across the network (latency)  
  
-   The amount of available bandwidth  
  
-   Queuing behavior  
  
-   Packet loss  
  
-   Reordering of packets  
  
-   Error propagations.  
  
 True network emulation also provides flexibility in filtering network packets based on IP addresses or protocols such as TCP, UDP, and ICMP.  
  
 True network emulation can be used by network-based developers and testers to emulate a desired test environment, assess performance, predict the effect of change, or make decisions about technology optimization. When compared to hardware test beds, true network emulation is a much cheaper and more flexible solution.  
  
## Configure Network Emulation for Your Test Settings  
 Before you perform the steps in this procedure, you must open your test settings from Visual Studio and then select the **Data and Diagnostics** page.  
  
#### To configure network emulation for your test settings  
  
1.  Select the role to use to emulate a specific network.  
  
    > [!NOTE]
    >  You have to configure the Network Emulation adapter only on either the client role or the server role. You do not have to use the adapter on both roles. The adapter emulates network noise that affects communication between both roles, so that you do not have to use it on both. Unless it is necessary, you should pick a client role for the Network Emulation adapter to avoid extra overhead on the server role.  
  
2.  Select **Network Emulation** and then choose **Configure**.  
  
     The dialog box to configure network emulation is displayed.  
  
3.  Choose the arrow next to **Select the network profile to use**, and select the network type that you want to emulate when you run a test (for example, **Cable-DSL 768Kps**).  
  
    > [!CAUTION]
    >  If you run your tests on a real network that is a slower type than the network that you are emulating, the test will still run at the slower network speed. The emulation can only slow down the network environment, not speed it up.  
  
4.  If you include the network emulation diagnostic data adapter in the test settings and you intend to use it on your local machine, then you must also bind the network emulation driver to one of your machine’s network adapters. The network emulation driver is required for the network emulation diagnostic data adapter to function. The network emulation driver is installed and bound to your adapter in two ways:  
  
    -   **Network emulation driver installed with Microsoft Visual Studio Test Agent:** The Microsoft Visual Studio Test Agent can be used on both remote machines and your local machine. When you install a Visual Studio Test Agent, the installation process includes a configuration step that binds the network emulation driver to your network card. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)][Install and configure test agents](../test/install-and-configure-test-agents.md).  
  
    -   **Network emulation driver installed with Microsoft Visual Studio Test Professional:** When you use network emulation for the first time, you are prompted to bind the network emulation driver to a network card.  
  
    > [!TIP]
    >  You can also install the network emulation driver from the command line on your local machine without installing the Visual Studio test agent by using the following command: **VSTestConfig NETWORKEMULATION /install**  
  
## See Also  
 [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)   
 [Run your tests](../test/running-manual-tests-using-the-web-portal.md)   
 [Record and play back manual tests](../test/record-and-play-back-manual-tests.md)