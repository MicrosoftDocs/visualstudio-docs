---
title: "Debug 64-Bit Applications | Microsoft Docs"
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
  - "debugging [Visual Studio], 64-bit"
  - "64-bit debugging"
ms.assetid: db648e5f-6375-4e2d-aa98-eb7261958927
caps.latest.revision: 38
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debug 64-Bit Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [Debug 64-Bit Applications](https://docs.microsoft.com/visualstudio/debugger/debug-64-bit-applications) .  
  
You can debug a 64-bit application that is running on the local computer or on a remote computer.  
  
 To debug a 64-bit application that is running on a remote computer, see [Remote Debugging](../debugger/remote-debugging.md).  
  
 To debug 64-bit applications locally, Visual Studio uses a 64-bit worker process (msvsmon.exe) to perform the low-level operations that cannot be done inside of the 32-bit Visual Studio process.  
  
 Mixed-mode debugging is not supported for 64-bit processes that use .NET Framework version 3.5 or earlier.  
  
## Debug a 64-bit Application  
 To try debugging a 64-bit application:  
  
1. Create a Visual Studio solution, for example a C# console application.  
  
2. Set the configuration to 64-bit using the Configuration Manager. For more information, see [How to: Configure Projects to Target Platforms](../ide/how-to-configure-projects-to-target-platforms.md).  
  
3. At this point the 64-bit version of the remote debugger (msvsmon.exe) starts. It runs as long as the solution with the 64-bit configuration is open.  
  
4. Start debugging. You should have the same experience as with a 32-bit configuration. If you get errors, see the Troubleshooting section below.  
  
## Troubleshooting 64-bit debugging  
 You may see an error: “A 64-bit debugging operation is taking longer than expected.” In this case, Visual Studio has sent a request to the 64-bit version of msvsmon.exe, and it has taken a long time for the result of that request to come back.  
  
 There are two main causes for this error:  
  
- You have networking security software installed on your computer that has caused the networking stack to be unreliable, and it has dropped packets going over localhost. Try disabling all network security software and see if this resolves it. If so, report to your network security software vendor that the software is interfering with localhost traffic.  
  
- You are running into a hang or performance problem with Visual Studio. If the problem happens regularly, you can collect dumps of Visual Studio (devenv.exe) and the worker process (msvsmon.exe) and send them to Microsoft. 
  
## See Also  
 [64-bit Applications](https://msdn.microsoft.com/library/fd4026bc-2c3d-4b27-86dc-ec5e96018181)   
 [Configuring Programs for 64-Bit](https://msdn.microsoft.com/library/cb99f72b-8c74-48f4-846a-8921b37b97e9)   
 [Visual Studio IDE 64-Bit Support](../ide/visual-studio-ide-64-bit-support.md)   
 [Using Dump Files](../debugger/using-dump-files.md)   
 [Remote Debugging](../debugger/remote-debugging.md)
