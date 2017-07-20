---
title: "Unable to Connect to the Microsoft Visual Studio Remote Debugging Monitor | Microsoft Docs"
ms.custom: ""
ms.date: "07/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.error.remote_debug"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
ms.assetid: a1d959fc-3817-491c-831b-e6b768a3877a
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Unable to Connect to the Microsoft Visual Studio Remote Debugging Monitor
This message may occur because the remote debugging monitor is not properly set up on the remote machine or the remote machine is inaccessible due to network problems or the presence of a firewall.
  
> [!IMPORTANT]
>  If you believe you have received this message because of a product bug, please [report this issue](../ide/how-to-report-a-problem-with-visual-studio-2017.md) to Visual Studio. If you need more help, see [Talk to Us](../ide/talk-to-us.md) for ways to contact Microsoft.

## <a name="specificerrors"></a>What is the detailed error message?

The `Unable to Connect to the Microsoft Visual Studio Remote Debugging Monitor` message is generic. Usually, a more specific message is included in the error string and that may help you identify the cause of the problem or search for a more exact fix. Here are a few of the more common error messages that are appended to the main error message:

- [There is no server by the specified name running on the remote computer](#no_server)
- [The requested name was valid, but no data of the requested type was found](#valid_name)
- [The Visual Studio Remote Debugger on the target computer cannot connect back to this computer](#cant_connect_back)
- [Invalid access to memory location](#invalid_access)
- [Access denied](#access_denied)
- [A security package specific error occurred](#security_package)

## <a name="no_server"></a> There is no server by the specified name running on the remote computer

Visual Studio could not connect to the remote debugger. This message may occur for several reasons:

1. The remote debugger may be running under a different user account. See [these steps](#user_accounts)

2. The port is blocked on the firewall. Make sure the firewall is [not blocking your request](#firewall), especially if you are using a third-party firewall.

3. The remote debugger version does not match Visual Studio. To get the correct version of the remote debugger, see [Remote Debugging](../debugger/remote-debugging.md)


## <a name="#valid_name"></a> The requested name was valid, but no data of the requested type was found

The remote computer exists, but Visual Studio could not connect to the remote debugger. This message may occur for several reasons:

1. A DNS issue is preventing the connection. See [these steps](#dns).

2. The remote debugger may be running under a different user account. Follow [these steps](#user_accounts).

3. The port is blocked on the firewall. Make sure the firewall is [not blocking your request](#firewall), especially if you are using a third-party firewall.

4. The remote debugger version does not match Visual Studio. To get the correct version of the remote debugger, see [Remote Debugging](../debugger/remote-debugging.md).

## <a name="cant_connect_back"></a> The Visual Studio Remote Debugger on the target computer cannot connect back to this computer

The remote debugger may be running under a different user account. In the remote debugger, open **Tools / Permissions** to add the user to the remote debugger's permissions.

    For more information, see [The remote debugger is running under a different user account](#user_accounts).

If the error message also mentions a firewall, the firewall on the local machine may be preventing communication from the remote computer back to Visual Studio. See [these steps](#firewall).

## <a name="invalid_access"></a> Invalid access to memory location

An internal error occurred. Restart Visual Studio and try again.

## <a name="access_denied"></a> Access denied

You may see this error if you try to debug on a 64-bit remote computer from a 32-bit computer (not supported).

## <a name="security_package"></a> A security package specific error occurred

This may be a legacy issue specific to Windows XP and Windows 7. See this [information](https://stackoverflow.com/questions/4786016/unable-to-connect-to-the-microsoft-remote-debugging-monitor-a-security-package). 

## Other causes

### <a name="dns"></a> The remote machine is not reachable 

If DNS is not able to resolve the remote computer name, try using the IP address instead. You can use `ipconfig` in a command line to get the IPv4 address. If you are using a HOSTS file, verify that it is configured correctly.

If that fails, verify that the remote computer is accessible on the network ([ping](https://technet.microsoft.com/en-us/library/ee624059\(v=ws.10\).aspx) the remote machine).
  
### (local debugging only) The server name is set incorrectly or third-party software is interfering with the remote debugger

In Visual Studio, look at the project properties and make sure the server name is correct. See topics for [C# and Visual Basic](../debugger/remote-debugging-csharp.md#remote_csharp) and [C++](../debugger/remote-debugging-cpp.md#remote_cplusplus). For ASP.NET, open **Properties / Web / Servers** or **Properties / Debug** depending on your project type. (If you are attaching to the process, you don't need to set the project properties.)

If the server name is set correctly, your anti-virus software or a third-party firewall may be blocking the remote debugger. This can happen because Visual Studio is a 32-bit application, so it uses the 64-bit version of the remote debugger to debug 64-bit applications. The 32-bit and 64-bit processes communicate using the local network within the local computer. No network traffic leaves the computer, but it is possible that third party security software may block the communication.

## <a name="user_accounts"></a> The remote debugger is running under a different user account  
 You can solve this in one of the following ways:  

-   Add the Visual Studio user to the remote debugger's permissions (in the remote debugger window, choose **Tools / Permissions**).

-   On the remote computer, restart the remote debugger under the same user account and password that you are using on the Visual Studio computer.

    > [!NOTE]
    > If you are running the remote debugger on a remote server, right-click the Remote Debugger app and choose **Run as administrator** (Or, you can run the remote debugger as a service). If you are not running it on a remote server, just start it normally.
  
-   You can start the remote debugger from the command line with the **/allow \<username>** parameter: `msvsmon /allow <username@computer>`  
  
-   Alternatively, you can allow any user to do remote debugging. In the remote debugger window, go to the **Tools /Options** dialog. When you select   **No Authentication**, you can then check **Allow any user to debug**. However, you should try this option only if the other options fail, or if you are on a private network.

## <a name="firewall"></a> The firewall on the remote machine doesn't allow incoming connections to the remote debugger  
 The firewall on the Visual Studio machine and the firewall on the remote machine must be configured to allow communication between Visual Studio and the remote debugger. For information about the ports the remote debugger is using, see [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md). For information about configuring the Windows firewall, see [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md).
  
### The version of the remote debugger doesn't match the version of Visual Studio  
 The version of Visual Studio that you are running locally needs to match the version of the remote debugging monitor that is running on the remote machine. To fix this, download and install the matching version of the remote debugging monitor. To get the correct version of the remote debugger, see [Remote Debugging](../debugger/remote-debugging.md).
  
### The local and remote machines have different authentication modes  
 The local and remote machines need to use the same authentication mode. To fix this, make sure that both machines are using the same authentication mode. You can change the authentication mode on the remote debugger in the **Tools / Options** dialog box.  
  
 For more information about authentication modes, see [Windows Authentication Overview](https://technet.microsoft.com/en-us/library/hh831472.aspx).   
  
### Anti-virus software is blocking the connections  
 Windows anti-virus software allows remote debugger connections, but some third-party anti-virus software may block them. Check the documentation for your anti-virus software to find out how to allow these connections.  
  
### Network security policy is blocking communication between the remote machine and Visual Studio  
 Review your network security to make sure that it is not blocking communication. For more information about Windows network security policy, see [Security policy settings](/windows/device-security/security-policy-settings/security-policy-settings).  
  
### The network is too busy to support remote debugging  
 You may need to do remote debugging at a different time, or reschedule work on the network for a different time.  
  
## More help  
 To get more remote debugger help, open the remote debugger's Help page (**Help / Usage** in the remote debugger).
  
## See Also  
 [Remote Debugging](../debugger/remote-debugging.md)