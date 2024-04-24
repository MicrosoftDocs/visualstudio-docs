---
title: Configure Firewall for Remote Debugging Dialog Box
description: Read about the Configure Firewall for Remote Debugging dialog box, which appears when the Windows Firewall stops the debugger from receiving data over the network.
ms.date: "04/24/2024"
ms.topic: "ui-reference"
f1_keywords:
  - "vs.debug.firewallconfiguration"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "Configure Firewall for Remote Debugging dialog box"
  - "remote debugging, configuring firewalls"
  - "firewalls, configuring for remote debugging"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Configure Firewall for Remote Debugging Dialog Box

This dialog box appears when the Windows Firewall blocks the debugger from receiving information over the network. To continue remote debugging, you must open a port in the firewall so the debugger can receive information.

> [!CAUTION]
> Opening a port in the Firewall might expose your machine to security threats that the Firewall is designed to block. The port that must be opened for remote debugging in Visual Studio is dependent on the Visual Studio version. For more information, see [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md). To configure port in the firewall, see [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md).

## UIElement List

 **Cancel remote debugging**
 Cancels the remote debugging attempt. The security settings of your machine remain intact.

 **Unblock remote debugging from computers on the local network (subnet)**
 Enables remote debugging of machines on your local subnet. This might open vulnerabilities to machines on your local subnet, but the firewall continues to block information coming from outside the subnet.

 **Unblock remote debugging from any computer**
 Enables remote debugging of machines anywhere on the network. This setting is the least secure.

## See also

- [Debugger Security](../debugger/debugger-security.md)
- [Remote Debugging](../debugger/remote-debugging.md)
- [Debugging User Interface Reference](../debugger/debugging-user-interface-reference.md)
