---
title: Configure Windows Firewall for remote debugging | Microsoft Docs
ms.date: 10/31/2018
ms.topic: how-to
ms.assetid: 66e3230a-d195-4473-bbce-8ca198516014
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload: 
  - multiple
---
# Configure Windows Firewall for remote debugging

On a network protected by Windows Firewall, the firewall must be configured to permit remote debugging. Visual Studio and the remote debugging tools try to open the correct firewall ports during installation or startup, but you may also need to open ports or allow apps manually.

This topic describes how to configure the Windows firewall to enable remote debugging on Windows 10, 8/8.1, and 7; and Windows Server 2012 R2, 2012, and 2008 R2 computers. The Visual Studio and remote computer don't have to be running the same operating system. For example, the Visual Studio computer can run Windows 10, and the remote computer can run Windows Server 2012 R2.

>[!NOTE]
>The instructions for configuring the Windows firewall differ slightly on different operating systems, and for older versions of Windows. Windows 8/8.1, Windows 10, and Windows Server 2012 settings use the word *app*, while Windows 7 and Windows Server 2008 use the word *program*.

## Configure ports for remote debugging

Visual Studio and the remote debugger try to open the correct ports during installation or startup. However, in some scenarios, such as a third-party firewall, you may need to open ports manually.

**To open a port:**

1. In Windows **Start** menu, search for and open **Windows Firewall with Advanced Security**. In Windows 10, this is **Windows Defender Firewall with Advanced Security**.

1. For a new incoming port, select **Inbound Rules** and then select **New Rule**. For an outgoing rule, select **Outbound Rules** instead.

1. In the **New Inbound Rule Wizard**, select **Port**, and then select **Next**.

1. Select either **TCP** or **UDP**, depending on the port number from the following tables.

1. Under **Specific local ports**, enter a port number from the following tables, and select **Next**.

1. Select **Allow the Connection**, and then select **Next**.

1. Select one or more network types to enable, including the network type for the remote connection, and then select **Next**.

1. Add a name for the rule (for example, **msvsmon**, **IIS**, or **Web Deploy**), and then select **Finish**.

   The new rule should appear and be selected in the **Inbound Rules** or **Outbound Rules** list.

### Ports on the remote computer that enable remote debugging

For remote debugging, the following ports must be open on the remote computer:

::: moniker range="vs-2017"

|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|
|-|-|-|-|
|4022|Incoming|TCP|For VS 2017. The port number increments by 2 for each Visual Studio version. For more information, see [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).|
|4023|Incoming|TCP|For VS 2017. The port number increments by 2 for each Visual Studio version. This port is only used to remote debug a 32-bit process from a 64-bit version of the remote debugger. For more information, see  [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).|
|3702|Outgoing|UDP|(Optional) Required for remote debugger discovery.|

::: moniker-end

::: moniker range=">= vs-2019"

|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|
|-|-|-|-|
|4024|Incoming|TCP|For VS 2019. The port number increments by 2 for each Visual Studio version. For more information, see [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).|
|4025|Incoming|TCP|For VS 2019. The port number increments by 2 for each Visual Studio version. This port is only used to remote debug a 32-bit process from a 64-bit version of the remote debugger. For more information, see  [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).|
|3702|Outgoing|UDP|(Optional) Required for remote debugger discovery.|

::: moniker-end

If you select **Use Managed Compatibility Mode** under **Tools** > **Options** > **Debugging**, open these additional remote debugger ports. Debugger Managed Compatibility Mode enables a legacy, Visual Studio 2010 version of the debugger.

|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|
|-|-|-|-|
|135, 139, 445|Outgoing|TCP|Required.|
|137, 138|Outgoing|UDP|Required.|

If your domain policy requires network communication to be performed through IPSec, you must open additional ports on both the Visual Studio and remote computers. To debug on a remote IIS web server, open port 80 on the remote computer.

|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|
|-|-|-|-|
|500, 4500|Outgoing|UDP|Required if your domain policy requires network communication to be performed through IPSec.|
|80|Outgoing|TCP|Required for web server debugging.|

To allow specific apps through the Windows firewall, see [Configure remote debugging through Windows Firewall](#configure-remote-debugging-through-windows-firewall).

## Configure remote debugging through Windows firewall

You can install the remote debugging tools on the remote computer, or run them from a shared folder. In either case, the remote computer firewall must be configured correctly.

On a remote computer, the remote debugging tools are in:

*\<Visual Studio installation directory\>\\Common7\\IDE\\Remote Debugger\\\<x86*, *x64*, or *Appx*\>

### Allow and configure the remote debugger through Windows Firewall

1. In Windows **Start** menu, search for and open **Windows Firewall**, or **Windows Defender Firewall**.

1. Select **Allow an app through Windows Firewall**.

1. If **Remote Debugger** or **Visual Studio Remote Debugger** doesn't appear under **Allowed apps and features**, select **Change settings**, and then select **Allow another app**.

1. If the remote debugger app still isn't listed in the **Add an app** dialog, select **Browse**, and navigate to *\<Visual Studio installation directory\>\\Common7\\IDE\\Remote Debugger\\\<x86*, *x64*, or *Appx*\>, depending on the appropriate architecture for your app. Select *msvsmon.exe*, and then select **Add**.

1. In the **Apps** list, select the **Remote Debugger** that you just added. Select **Network types**, and then select one or more network types, including the network type for the remote connection.

1. Select **Add**, and then select **OK**.

## <a name="troubleshooting"></a>Troubleshoot the remote debugging connection

If you can't attach to your app with the remote debugger, make sure the remote debugging firewall ports, protocols, network types, and app settings are all correct.

- In the Windows **Start** menu, search for and open **Windows Firewall**, and select **Allow an app through Windows Firewall**. Make sure **Remote Debugger** or **Visual Studio Remote Debugger** appears in the **Allowed apps and features** list with a selected check box, and the correct network types are selected. If not, [add the correct apps and settings](#configure-remote-debugging-through-windows-firewall).

- In the Windows **Start** menu, search for and open **Windows Firewall with Advanced Security**. Make sure **Remote Debugger** or **Visual Studio Remote Debugger** appears under **Inbound Rules** (and optionally, **Outbound Rules**) with a green checkmark icon, and that all settings are correct.

  - To view or change the rule settings, right-click the **Remote Debugger** app in the list and select **Properties**. Use the **Properties** tabs to enable or disable the rule, or change port numbers, protocols, or network types.
  - If the remote debugger app doesn't appear in the rules list, [add and configure the correct ports](#configure-ports-for-remote-debugging).

## See also

- [Remote debugging](../debugger/remote-debugging.md)
- [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md)
