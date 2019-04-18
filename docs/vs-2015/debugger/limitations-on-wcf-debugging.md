---
title: "Limitations on WCF Debugging | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging, WCF"
  - "WCF, debugging limitations"
ms.assetid: 8e0333c4-1ddc-4abe-8f1c-d19bf6a2a07a
caps.latest.revision: 33
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Limitations on WCF Debugging
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

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
  
    ```  
    <system.web>  
      <compilation debug="true" />  
    </system.web>  
    ```  
  
     This code only has to be added one time. You can add this code by editing the .config file or by attaching to the service by using **Attach to Process**. When you use **Attach to Process** on a service, the debug code is automatically added to the .config file. After that, you can debug and step into the service without having to edit the .config file.  
  
## Limitations on Stepping Out of a Service  
 Stepping out of a service and back to the client has the same limitations described for stepping into a service. In addition, the debugger must be attached to the client. If you are debugging a client and step into a service, the debugger remains attached to the service. This is true whether you started the client by using **Start Debugging** or attached to the client by using **Attach to Process**. If you began debugging by attaching to the service, the debugger is not yet attached to the client. In that case, if you have to step out of the service and back to the client, you must first use **Attach to Process** to attach to the client manually.  
  
## Limitations on Automatic Attach to a Service  
 Automatically attaching to a service has the following limitations:  
  
- The service must be part of the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] solution you are debugging.  
  
- The service must be hosted. It may be part of a Web Site Project (File System and HTTP), Web Application Project (File System and HTTP), or WCF Service Library project. WCF Service Library projects can be either Service Libraries or Workflow Service Libraries.  
  
- The service must be invoked from a WCF client.  
  
- Debugging must be enabled with the following code in the app.config or Web.config file:  
  
    ```  
    <system.web>  
      <compilation debug="true" />  
    <system.web>  
    ```  
  
## Self-Hosting  
 A *self-hosted service* is a WCF service that does not run inside IIS, the WCF Service Host, or the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] Development Server. For information about how to debug a self-hosted service, see [How to: Debug a Self-Hosted WCF Service](../debugger/how-to-debug-a-self-hosted-wcf-service.md).  
  
## Self-Hosting  
 To enable debugging of [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] 3.0 or 3.5 applications, [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] 3.0 or 3.5 must be installed before [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)] is installed. If [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)] is installed before [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] 3.0 or 3.5, an error occurs when you try to debug a [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] 3.0 or 3.5 application. The error message is, "Unable to Automatically Step Into the Server." To fix this problem, use the Windows **Control Panel**, **Programs and Features** to repair your [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)] installation.  
  
## See Also  
 [Debugging WCF Services](../debugger/debugging-wcf-services.md)   
 [How to: Debug a Self-Hosted WCF Service](../debugger/how-to-debug-a-self-hosted-wcf-service.md)
