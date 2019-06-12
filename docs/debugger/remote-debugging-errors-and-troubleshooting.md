---
title: "Remote Debugging Errors and Troubleshooting | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "debugger, errors"
  - "debugging errors"
  - "remote debugging, troubleshooting"
  - "troubleshooting remote debugging"
  - "errors [debugger], remote debugging"
  - "remote debugging, errors"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Remote Debugging Errors and Troubleshooting
You may encounter the following errors when attempting to debug remotely.

- [Error: Unable to Automatically Step Into the Server](../debugger/error-unable-to-automatically-step-into-the-server.md)

- [Error: The Microsoft Visual Studio Remote Debugging Monitor (MSVSMON.EXE) does not appear to be running on the remote computer.](/visualstudio/debugger/error-remote-debugging-monitor-msvsmon-exe-does-not-appear-to-be-running)

- [Unable to Connect to the Microsoft Visual Studio Remote Debugging Monitor](../debugger/unable-to-connect-to-the-microsoft-visual-studio-remote-debugging-monitor.md)

- [Error: Remote machine does not appear in a Remote Connections dialog](../debugger/error-remote-machine-does-not-appear-in-a-remote-connections-dialog.md)

## Run the remote debugger as an administrator

If you do not run the remote debugger service as an administrator, you may encounter issues such as a [permissions error](error-the-microsoft-visual-studio-remote-debugging-monitor-no-permission.md) or a [different user account](error-the-microsoft-visual-studio-remote-debugging-monitor-on-the-remote-computer-is-running-as-a-different-user.md) error.

We recommend running the remote debugger service as an administrator for several reasons:

- The remote debugger service only allows connections from administrators, so there are no new security risks introduced by running the service as an administrator.

- It can prevent errors that result when the Visual Studio user has more rights to debug a process than the service itself does.

- To simplify the setup and configuration of the remote debugger.

While it is possible to debug without running the remote debugging service as an administrator, there are several requirements to make this work correctly and that often require more advanced service configuration steps.

- The account you are using on the remote machine must have the **logon as service** privilege (policy under **User Rights Assignment** in the Local Group Policy Editor).

- The account must have rights to debug the target process. To get these rights, you must run the service under the same account as the process to be debugged. (The easier alternative is to run the service as an administrator.) 

- The account must be able to connect back to (that is, authenticate with) the Visual Studio computer over the network. On a domain, it is easier to do this if the service is running under the built-in Local System or Network Service accounts, or a domain account. The built-in accounts have elevated security privileges that can present a security risk.

## See Also
- [Remote Debugging](../debugger/remote-debugging.md)