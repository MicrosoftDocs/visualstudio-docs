---
title: "How to: Debug a Self-Hosted WCF Service | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging, WCF"
  - "WCF, self-hosted service"
  - "WCF, debugging"
ms.assetid: 288922be-ba3f-411e-af50-bba39c9529cc
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Debug a Self-Hosted WCF Service
A *self-hosted service* is a WCF service that does not run inside IIS, the WCF Service Host, or the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Development Server. The easiest way to debug a self-hosted WCF is to configure [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] to launch both client and server when you choose **Start Debugging** on the **Debug** menu.

 If the WCF service is self-hosting inside or a process that cannot be launched in this manner, such as NT service, you cannot use this method. Instead, you can do one of the following:

- Manually attach the debugger to the hosting process. For more information, see [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).

     — or —

- Start debugging the client, and then step into a call to the service. This requires that you enable debugging in the app.config file. For more information, [Limitations on WCF Debugging](../debugger/limitations-on-wcf-debugging.md).

### To start both client and host from Visual Studio

1. Create a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] solution that contains both the client and server projects.

2. Configure the solution to start both client and server processes when you choose **Start** on the **Debug** menu.

   1. In **Solution Explorer**, right-click the solution name.

   2. Click **Set Startup Projects**.

   3. In the **Solution \<name> Properties** dialog box, select **Multiple Startup Projects**.

   4. In the **Multiple Startup Projects** grid, on the line that corresponds to the server project, click **Action** and choose **Start**.

   5. On the line that corresponds to the client project, click **Action** and choose **Start**.

   6. Click **OK**.

## See also
- [Debugging WCF Services](../debugger/debugging-wcf-services.md)
- [Limitations on WCF Debugging](../debugger/limitations-on-wcf-debugging.md)
- [How to: Step into WCF Services](../debugger/how-to-step-into-wcf-services.md)