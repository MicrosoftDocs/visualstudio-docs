---
title: "Limitations on WCF Debugging"
description: Learn the ways to begin debugging a WCF service, the required conditions, and the debugging limitations.
ms.date: "11/04/2016"
ms.topic: article
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging, WCF"
  - "WCF, debugging limitations"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Limitations on WCF Debugging

There are three ways that you can begin debugging a WCF service:

- You are debugging a client process that calls a service. The debugger steps into the service. The service does not have to be in the same solution as your client application.

- You are debugging a client process that makes a request to a service. The service must be part of your solution.

- You use **Attach to Process** to attach to a service that is currently running. Debugging begins inside the service.

This topic describes limitations on these scenarios.

## Limitations on Stepping Into a Service
 To step into a service from a client applications that you are debugging, the following conditions must be met:

- The client must call the service by using a synchronous client object.

- The contract operation cannot be one-way.

- If the server is asynchronous, you cannot view the full call stack while you are executing code inside the service.

- Debugging must be enabled with the following code in the app.config or Web.config file:

    ```xml
    <system.web>
      <compilation debug="true" />
    </system.web>
    ```

     This code only has to be added one time. You can add this code by editing the .config file or by attaching to the service by using **Attach to Process**. When you use **Attach to Process** on a service, the debug code is automatically added to the .config file. After that, you can debug and step into the service without having to edit the .config file.

## Limitations on Stepping Out of a Service
 Stepping out of a service and back to the client has the same limitations described for stepping into a service. In addition, the debugger must be attached to the client. If you are debugging a client and step into a service, the debugger remains attached to the service. This is true whether you started the client by using **Start Debugging** or attached to the client by using **Attach to Process**. If you began debugging by attaching to the service, the debugger is not yet attached to the client. In that case, if you have to step out of the service and back to the client, you must first use **Attach to Process** to attach to the client manually.

## Limitations on Automatic Attach to a Service
 Automatically attaching to a service has the following limitations:

- The service must be part of the Visual Studio solution you are debugging.

- The service must be hosted. It may be part of a Web Site project (File System and HTTP), Web Application project (File System and HTTP), or WCF Service Library project. WCF Service Library projects can be either Service Libraries or Workflow Service Libraries.

- The service must be invoked from a WCF client.

- Debugging must be enabled with the following code in the app.config or Web.config file:

  ```xml
  <system.web>
    <compilation debug="true" />
  <system.web>
  ```

## Self-Hosting
 A *self-hosted service* is a WCF service that does not run inside IIS, the WCF Service Host, or the ASP.NET Development Server. For information about how to debug a self-hosted service, see [How to: Debug a Self-Hosted WCF Service](../debugger/how-to-debug-a-self-hosted-wcf-service.md).

 If you see the error message, "Unable to Automatically Step Into the Server.", repair your Visual Studio installation to try to resolve the issue. This may happen if you install Visual Studio before installing ASP.NET.

## Related content
- [Debugging WCF Services](../debugger/debugging-wcf-services.md)
- [How to: Debug a Self-Hosted WCF Service](../debugger/how-to-debug-a-self-hosted-wcf-service.md)
