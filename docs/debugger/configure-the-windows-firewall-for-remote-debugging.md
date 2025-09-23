---
title: Configure Windows Firewall for remote debugging
description: Configure Windows Firewall for remote debugging. Configure ports for remote debugging. Troubleshoot the remote debugging connection.
ms.date: 09/04/2025
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Configure Windows Firewall for remote debugging

On a network protected by Windows Firewall, the firewall must be configured to permit remote debugging. Visual Studio and the remote debugging tools try to open the correct firewall ports during installation or startup, but you might also need to open ports or allow apps manually.

This topic describes how to configure the Windows Firewall to enable remote debugging on Windows 10, 8/8.1, and 7; and Windows Server 2012 R2, 2012, and 2008 R2 computers. The Visual Studio and remote computer don't have to be running the same operating system. For example, the Visual Studio computer can run Windows 11, and the remote computer can run Windows Server 2012 R2.

> [!NOTE]
> The instructions for configuring the Windows Firewall differ slightly on different operating systems, and for older versions of Windows. Windows 8/8.1, Windows 10 and newer versions, and Windows Server 2012 settings use the word *app*, while Windows 7 and Windows Server 2008 use the word *program*.

## Configure ports for remote debugging

Visual Studio and the remote debugger try to open the correct ports during installation or startup. However, in some scenarios, such as a third-party firewall, you might need to open ports manually.

To open a port:

1. In Windows **Start** menu, search for and open **Windows Firewall with Advanced Security**. Starting in Windows 10, this is **Windows Defender Firewall with Advanced Security**.

1. For a new incoming port, select **Inbound Rules** and then select **New Rule**. For an outgoing rule, select **Outbound Rules** instead.

1. In the **New Inbound Rule Wizard**, select **Port**, and then select **Next**.

1. Select either **TCP** or **UDP**, depending on the port number from the following tables.

1. Under **Specific local ports**, enter a port number from the following tables, and select **Next**.

1. Select **Allow the Connection**, and then select **Next**.

1. Select one or more network types to enable, including the network type for the remote connection, and then select **Next**.

1. Add a name for the rule (for example, `msvsmon`, `IIS`, or `Web Deploy`), and then select **Finish**.

   The new rule should appear and be selected in the **Inbound Rules** or **Outbound Rules** list.

To open a port using PowerShell:

For Windows Firewall, you can use PowerShell commands such as [New-NetFirewallRule](/powershell/module/netsecurity/new-netfirewallrule).

::: moniker range="visualstudio"
The following example opens port 4026 for the remote debugger on the remote computer. The port and path you need to use might be different.

```ps
New-NetFirewallRule -DisplayName "msvsmon" -Direction Inbound -Program "Program Files\Microsoft Visual Studio\18\Enterprise\Common7\IDE\Remote Debugger\x64\msvsmon.exe" -LocalPort 4026 -Protocol TCP -Authentication Required -Action Allow
```

::: moniker-end

::: moniker range="vs-2022"
The following example opens port 4026 for the remote debugger on the remote computer. The port and path you need to use might be different.

```ps
New-NetFirewallRule -DisplayName "msvsmon" -Direction Inbound -Program "Program Files\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\Remote Debugger\x64\msvsmon.exe" -LocalPort 4026 -Protocol TCP -Authentication Required -Action Allow
```

::: moniker-end
::: moniker range="vs-2019"
The following example opens port 4024 for the remote debugger on the remote computer. The path you need to use might be different.

```ps
New-NetFirewallRule -DisplayName "msvsmon" -Direction Inbound -Program "Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\Remote Debugger\x64\msvsmon.exe" -LocalPort 4024 -Protocol TCP -Authentication Required -Action Allow
```

::: moniker-end

### Ports on the remote computer that enable remote debugging

For remote debugging, the following ports must be open on the remote computer:

::: moniker range="vs-2022"

|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|
|-|-|-|-|
|4026|Incoming|TCP|For Visual Studio 2022. For more information, see [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).|
|4025|Incoming|TCP|For Visual Studio 2022 and Microsoft Azure App Service. This port is only used to remote debug a 32-bit process from a 64-bit version of the remote debugger. For more information, see [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).|
|4024|Incoming|TCP|For Microsoft Azure App Service. For more information, see [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).|
|3702|Outgoing|UDP|(Optional) Required for remote debugger discovery.|

::: moniker-end
::: moniker range="vs-2019"

|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|
|-|-|-|-|
|4024|Incoming|TCP|For Visual Studio 2019 and Microsoft Azure App Service. The port number increments by 2 for each Visual Studio version. For more information, see [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).|
|4025|Incoming|TCP|For Visual Studio 2019 and Azure App Service. This port is only used to remote debug a 32-bit process from a 64-bit version of the remote debugger. For more information, see [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).|
|3702|Outgoing|UDP|(Optional) Required for remote debugger discovery.|

If you select **Use Managed Compatibility Mode** under **Tools** > **Options** > **Debugging**, open these additional remote debugger ports. Debugger Managed Compatibility Mode enables a legacy, Visual Studio 2010 version of the debugger.

|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|
|-|-|-|-|
|135, 139, 445|Outgoing|TCP|Required.|
|137, 138|Outgoing|UDP|Required.|

::: moniker-end

## Ports for IPsec and IIS

If your domain policy requires network communication to be performed through Internet Protocol Security (IPsec), you must open additional ports on both the Visual Studio and remote computers. To debug on a remote Internet Information Services (IIS) web server, open port 80 on the remote computer.

|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|
|-|-|-|-|
|500, 4500|Outgoing|UDP|Required if your domain policy requires network communication to be performed through IPsec.|
|80|Outgoing|TCP|Required on the remote computer for web server debugging.|

To allow specific apps through the Windows Firewall, see [Configure remote debugging through Windows Firewall](#allow-the-remote-debugger-through-windows-firewall).

## Allow the remote debugger through Windows Firewall

When you [configure the remote debugger](../debugger/remote-debugging.md#bkmk_setup), the configuration software should open the correct ports on the remote computer. However, in some scenarios you might need to manually allow the remote debugger through the firewall.

To allow the remote debugger through Windows Firewall:

1. In Windows **Start** menu, search for and open **Windows Firewall**, or **Windows Defender Firewall**.

1. Select **Allow an app through Windows Firewall**.

1. If **Remote Debugger** or **Visual Studio Remote Debugger** doesn't appear under **Allowed apps and features**, select **Allow another app**, or select **Change settings** and then **Allow another app**.

1. If the remote debugger app still isn't listed in the **Add an app** dialog, select **Browse**, and navigate to *\<Visual Studio installation directory\>\\Common7\\IDE\\Remote Debugger\\\<x86*, *x64*, or *Appx*\>, depending on the appropriate architecture for your app. Select *msvsmon.exe*, and then select **Open**.

1. In the **Apps** list, select the **Remote Debugger** that you just added. Select **Network types**, and then select one or more network types, including the network type for the remote connection.

1. Select **Add**, and then select **OK**.

## <a name="troubleshooting"></a>Troubleshoot the remote debugging connection

If you can't attach to your app with the remote debugger, make sure the remote debugging firewall ports, protocols, network types, and app settings are all correct.

- In the Windows **Start** menu, search for and open **Windows Firewall**, and select **Allow an app through Windows Firewall**. Make sure **Remote Debugger** or **Visual Studio Remote Debugger** appears in the **Allowed apps and features** list with a selected checkbox, and the correct network types are selected. If not, [add the correct apps and settings](#allow-the-remote-debugger-through-windows-firewall).

- In the Windows **Start** menu, search for and open **Windows Firewall with Advanced Security**. Make sure **Remote Debugger** or **Visual Studio Remote Debugger** appears under **Inbound Rules** (and optionally, **Outbound Rules**) with a green check mark icon, and that all settings are correct.

  - To view or change the rule settings, right-click the **Remote Debugger** app in the list and select **Properties**. Use the **Properties** tabs to enable or disable the rule, or change port numbers, protocols, or network types.
  - If the remote debugger app doesn't appear in the rules list, [add and configure the correct ports](#configure-ports-for-remote-debugging).

## Related content

- [Remote debugging](../debugger/remote-debugging.md)
- [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md)
