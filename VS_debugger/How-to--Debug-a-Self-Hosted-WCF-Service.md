---
title: "How to: Debug a Self-Hosted WCF Service"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 288922be-ba3f-411e-af50-bba39c9529cc
caps.latest.revision: 25
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Debug a Self-Hosted WCF Service
A *self-hosted service* is a WCF service that does not run inside IIS, the WCF Service Host, or the ASP.NET Development Server. The easiest way to debug a self-hosted WCF is to configure Visual Studio to launch both client and server when you choose **Start Debugging** on the **Debug** menu.  
  
 If the WCF service is self-hosting inside or a process that cannot be launched in this manner, such as NT service, you cannot use this method. Instead, you can do one of the following:  
  
-   Manually attach the debugger to the hosting process. For more information, see [Attach to Running Processes](../VS_debugger/Attach-to-Running-Processes-with-the-Visual-Studio-Debugger.md).  
  
     — or —  
  
-   Start debugging the client, and then step into a call to the service. This requires that you enable debugging in the app.config file. For more information, [Limitations on WCF Debugging](../VS_debugger/Limitations-on-WCF-Debugging.md).  
  
### To start both client and host from Visual Studio  
  
1.  Create a Visual Studio solution that contains both the client and server projects.  
  
2.  Configure the solution to start both client and server processes when you choose **Start** on the **Debug** menu.  
  
    1.  In **Solution Explorer**, right-click the solution name.  
  
    2.  Click **Set Startup Projects**.  
  
    3.  In the **Solution <name\> Properties** dialog box, select **Multiple Startup Projects**.  
  
    4.  In the **Multiple Startup Projects** grid, on the line that corresponds to the server project, click **Action** and choose **Start**.  
  
    5.  On the line that corresponds to the client project, click **Action** and choose **Start**.  
  
    6.  Click **OK**.  
  
## See Also  
 [Debugging WCF Services](../VS_debugger/Debugging-WCF-Services.md)   
 [Limitations on WCF Debugging](../VS_debugger/Limitations-on-WCF-Debugging.md)   
 [How to: Step into WCF Services](../VS_debugger/How-to--Step-into-WCF-Services.md)