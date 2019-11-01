---
title: "Error: Ensure that DNS is Correctly Configured on the Target Computer | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.error.callback_dns_failed"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: Ensure that DNS is Correctly Configured on the Target Computer
When trying to do remote debugging, you may get the following error message:

```cmd
Error: The Visual Studio Remote Debugger on the target computer cannot connect back to this computer. Ensure that DNS is correctly configured on the target computer.
```

 This error happens when the target computer cannot resolve the name of the Visual Studio debugger host computer. Check the DNS settings on the target computer.

- For information about viewing your DNS setting in Windows 8.1, Vista, Windows 7, Windows Server 2012, Windows Server 2008, or Windows Server 2008 R2, , do this: on the **Start** menu, choose **Help and Support**, and then search for **Change TCP/IP settings**.

- For more information, go to [Microsoft Windows web site](https://www.microsoft.com/windows/) and search for **Change TCP/IP settings**.

  If you cannot resolve the DNS problem, you can try running the Remote Debugger under a different account. This error occurs only when you are running the Remote Debugger under the Local System or Network Service account. If you run the Remote Debugger under another account, it can use NTLM authentication, which does not require DNS. . For the procedure, see [Error: The Visual Studio Remote Debugger service on the target computer cannot connect back to this computer](../debugger/error-the-visual-studio-remote-debugger-service-on-the-target-computer-cannot-connect-back-to-this-computer.md).
