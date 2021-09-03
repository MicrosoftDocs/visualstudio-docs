---
title: Configure Network Emulation Using Test Settings
description: Learn how to configure the diagnostic data adapter to test your application under various network environments from Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 10/03/2016
ms.topic: how-to
helpviewer_keywords:
  - test settings, network emulation
ms.assetid: ff275cfb-5df9-4710-9a91-9caabaaad34f
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# How to: Configure network emulation using test settings in Visual Studio

You can configure the diagnostic data adapter to test your application under various network environments from Visual Studio. It can also be configured to test an artificial network load, or bottleneck, when you run your tests.

> [!WARNING]
> If you run your tests on a real network that is a slower type than the network you are emulating, the test will still run at the slower network speed. The emulation can only slow down the network environment, not speed it up.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

::: moniker range="vs-2017"
The following procedure describes how to configure network emulation from the configuration editor. These steps apply to both the configuration editor in Microsoft Test Manager and Visual Studio.
::: moniker-end
::: moniker range=">=vs-2019"
The following procedure describes how to configure network emulation from the configuration editor. These steps apply to the configuration editor in Visual Studio.
::: moniker-end

> [!NOTE]
> The network emulation diagnostic data adapter is only applicable to Visual Studio test settings. It is not used for test settings in Microsoft Test Manager (deprecated in Visual Studio 2017).

::: moniker range="vs-2017"
An account that has administrator privileges must be used for network emulation. If you have selected network emulation for a local role that runs manual tests, you must start Microsoft Test Manager by using administrator privileges. If you have selected network emulation for any other role, you must verify that the test agent on the machine for that role uses a user account that is a member of the administrators group. For more information about how to set up the account for your test agent, see [Install and configure test agents](../test/lab-management/install-configure-test-agents.md).
::: moniker-end

> [!NOTE]
> The Network Service account, which is the default account for the test agent, is not a member of the administrators group.

**True Network Emulation**

Visual Studio uses software-based true network emulation for all test types. This includes load tests. True network emulation simulates network conditions by direct manipulation of the network packets. The true network emulator can emulate the behavior of both wired and wireless networks by using a reliable physical link, such as an Ethernet. The following network attributes are incorporated into true network emulation:

- Round-trip time across the network (latency)

- The amount of available bandwidth

- Queuing behavior

- Packet loss

- Reordering of packets

- Error propagations.

True network emulation also provides flexibility in filtering network packets based on IP addresses or protocols such as TCP, UDP, and ICMP.

True network emulation can be used by network-based developers and testers to emulate a desired test environment, assess performance, predict the effect of change, or make decisions about technology optimization. When compared to hardware test beds, true network emulation is a much cheaper and more flexible solution.

## Configure network emulation for your test settings

Before you perform the steps in this procedure, you must open your test settings from Visual Studio and then select the **Data and Diagnostics** page.

### To configure network emulation for your test settings

1. Select the role to use to emulate a specific network.

    > [!NOTE]
    > You have to configure the Network Emulation adapter only on either the client role or the server role. You do not have to use the adapter on both roles. The adapter emulates network noise that affects communication between both roles, so that you do not have to use it on both. Unless it is necessary, you should pick a client role for the Network Emulation adapter to avoid extra overhead on the server role.

2. Select **Network Emulation** and then choose **Configure**.

     The dialog box to configure network emulation is displayed.

3. Choose the arrow next to **Select the network profile to use**, and select the network type that you want to emulate when you run a test (for example, **Cable-DSL 768Kps**).

    > [!WARNING]
    > If you run your tests on a real network that is a slower type than the network that you are emulating, the test will still run at the slower network speed. The emulation can only slow down the network environment, not speed it up.

4. If you include the network emulation diagnostic data adapter in the test settings and you intend to use it on your local machine, then you must also bind the network emulation driver to one of your machine’s network adapters. The network emulation driver is required for the network emulation diagnostic data adapter to function. The network emulation driver is installed and bound to your adapter in two ways:

    - **Network emulation driver installed with Microsoft Visual Studio Test Agent:** The Microsoft Visual Studio Test Agent can be used on both remote machines and your local machine. When you install a Visual Studio Test Agent, the installation process includes a configuration step that binds the network emulation driver to your network card. For more information, see [Install and configure test agents](../test/lab-management/install-configure-test-agents.md).

    - **Network emulation driver installed with Microsoft Visual Studio Test Professional:** When you use network emulation for the first time, you are prompted to bind the network emulation driver to a network card.

    > [!TIP]
    > You can also install the network emulation driver from the command line on your local machine without installing the Visual Studio test agent by using the following command: **VSTestConfig NETWORKEMULATION /install**

## See also

- [Collect diagnostic information using test settings](../test/collect-diagnostic-information-using-test-settings.md)
- [Run manual tests (Azure Test Plans)](/azure/devops/test/run-manual-tests?view=vsts&preserve-view=true)
