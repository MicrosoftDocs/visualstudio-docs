---
title: How to - Step into WCF Services | Microsoft Docs
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - debugging, WCF
  - WCF, debugging
ms.assetid: 9893ad01-54af-499f-85a6-9d1cfe6eb640
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload: 
  - multiple
---
# How to: Step into WCF Services
In [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)], you can step into a WCF service. If the WCF service is in the same [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] solution as the client, you can hit breakpoints inside the WCF Service.

 For stepping to work, you must have debugging enabled in the app.config or Web.config file. For information about how to enable debugging and for limitations on stepping into WCF services, see [Limitations on WCF Debugging](../debugger/limitations-on-wcf-debugging.md).

### To step into a WCF Service

1. Create a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] solution that contains both the WCF client and WCF service projects.

2. In Solution Explorer, right-click the WCF Client project and then click **Set as Startup Project**.

3. Enable debugging in the app.config or web.config file. For more information, see [Limitations on WCF Debugging](../debugger/limitations-on-wcf-debugging.md).

4. Set a breakpoint at the location in the client project where you want to start stepping. Typically, this will be just before the WCF service call.

5. Run to the breakpoint, then begin stepping. The debugger will step into the service automatically.

## See also
- [Debugging WCF Services](../debugger/debugging-wcf-services.md)
- [Limitations on WCF Debugging](../debugger/limitations-on-wcf-debugging.md)
- [How to: Debug a Self-Hosted WCF Service](../debugger/how-to-debug-a-self-hosted-wcf-service.md)