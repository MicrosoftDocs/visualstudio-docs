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

You may come across the following errors when attempting to debug remotely.

- [Error: Unable to Automatically Step Into the Server](../debugger/error-unable-to-automatically-step-into-the-server.md)

- [Error: The Microsoft Visual Studio Remote Debugging Monitor (MSVSMON.EXE) does not appear to be running on the remote computer.](error-remote-debugging-monitor-msvsmon-exe-does-not-appear-to-be-running.md)

- [Unable to Connect to the Microsoft Visual Studio Remote Debugging Monitor](../debugger/unable-to-connect-to-the-microsoft-visual-studio-remote-debugging-monitor.md)

- [Error: Remote machine does not appear in a Remote Connections dialog](../debugger/error-remote-machine-does-not-appear-in-a-remote-connections-dialog.md)

## Run the remote debugger as an administrator

You may come across issues if you don't run the remote debugger as an administrator. For example, you may see the following error: "The Visual Studio Remote Debugger (MSVSMON.EXE) has insufficient privileges to debug this process." If you are running the remote debugger as an application (not a service), you may see the [different user account](error-the-microsoft-visual-studio-remote-debugging-monitor-on-the-remote-computer-is-running-as-a-different-user.md) error.

### When running the remote debugger as a service

When running the remote debugger as s service, we recommend running it as an administrator for several reasons:

- The remote debugger service only allows connections from administrators, so there are **no** new security risks introduced by running it as an administrator.

- It can prevent errors that result when the Visual Studio user has more rights to debug a process than the remote debugger itself does.

- To simplify the setup and configuration of the remote debugger.

While it's possible to debug without running the remote debugger as an administrator, there are several requirements to make this work correctly and they often require more advanced service configuration steps.

- The account you are using on the remote machine must have the **logon as service** privilege. See the steps under "To add logon as a service" in the [cannot connect back](error-the-visual-studio-remote-debugger-service-on-the-target-computer-cannot-connect-back-to-this-computer.md) error article.

- The account must have rights to debug the target process. To get these rights, you must run the remote debugger under the same account as the process to be debugged. (The easier alternative is to run the service as an administrator.) 

- The account must be able to connect back to (that is, authenticate with) the Visual Studio computer over the network. On a domain, it is easier to connect back if the remote debugger is running under the built-in Local System or Network Service accounts, or a domain account. The built-in accounts have elevated security privileges that can present a security risk.

### When running the remote debugger as an application (normal mode)

If you are trying to attach to your own non-elevated process (such as a normal application), it doesn't matter if you are running the remote debugger as an administrator.

You want to run the remote debugger as an administrator in several scenarios:

- You want to attach to processes running as another user (such as when debugging IIS), or

- You are trying to launch another process, and the process you want to launch is an administrator.

You do **not** want to run as an administrator if you want to launch processes, and the process you want to launch should **not** be an administrator.

## See also
- [Remote Debugging](../debugger/remote-debugging.md)