---
title: "How to: Specify Pre- and Post-Instrument Commands | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performance.property.instrument"
helpviewer_keywords: 
  - "profiling tools, pre-instrument events"
  - "events [Visual Studio], pre-instrument"
  - "pre-instrument events, performance tools"
ms.assetid: 6a8d5340-1d1b-4d81-88dd-8e1f435eb828
caps.latest.revision: 33
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Specify Pre- and Post-Instrument Commands
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can specify commands that run before or after the binaries in a performance session are instrumented. Any command that can be issued from the command line can be specified as a pre-instrument or a post-instrument event. For example, you can specify commands that automate the resigning of an assembly with a strong name key in a batch file that is executed after the binaries are instrumented.  
  
 You can specify commands for all instrumented binaries in the profiling run or for individual binaries. However, you can specify only one pre-instrument command to run before and only one post-instrument command to run after the instrumentation process. You cannot specify commands for both all binaries and for individual binaries. When you specify commands for all binaries, the commands are run before or after the instrumentation of each binary in the session.  
  
 **Requirements**  
  
- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
  The working directory in which the commands are executed depends on the operating systen  where you are running [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] and on the target platform of the profiled application.  
  
  **32-bit computers**  
  
  On 32-bit computers, the default profiler tools directory is Drive\Program Files\Microsoft Visual Studio 10.0\Team Tools\Performance Tools.  
  
  **64-bit computers**  
  
  On 64-bit computers, specify the path according to the target platform of the profiled application:  
  
- For 32-bit applications, the default profiler tools directory is:  
  
   *Drive*\Program Files (x86)\Microsoft Visual Studio 10.0\Team Tools\Performance Tools  
  
- For 64-bit applications, the default profiler tools directory is:  
  
   *Drive*\Program Files (x86)\Microsoft Visual Studio 10.0\Team Tools\Performance Tools\x64  
  
### To specify pre-instrument commands  
  
1. Perform one of the following steps:  
  
    - To specify pre-instrument commands for all binaries in a performance session, select the performance session node in **Performance Explorer**, and then right-click and select **Properties**.  
  
    - To specify pre-instrument commands for a specific binary, right-click the name of the binary in the **Targets** list of the performance session, and then select **Properties**.  
  
2. In the **Property Pages**, click **Instrumentation**.  
  
3. Type the command in the **Command line** text box under **Pre-Instrument events**.  
  
    > [!NOTE]
    > You can click the ellipsis button **(…)** that is adjacent to the **Command line** box to browse to and select the appropriate .exe, .cmd, or .bat file.  
  
4. Click **OK**.  
  
     To disable the command from running without removing it, select the **Exclude from instrumentation** check box. To modify compiler or linker settings, use the project property pages.  
  
### To specify post-instrument commands  
  
1. Perform one of the following steps:  
  
    - To specify post-instrument commands for all binaries in a performance session, select the performance session node in **Performance Explorer**, and then right-click and select **Properties**.  
  
    - To specify post-instrument commands for a specific binary, right-click the name of the binary in the **Targets** list of the performance session, and then select **Properties**.  
  
2. In the **Property Pages**, click **Instrumentation**.  
  
3. Type the command in the **Command line** text box under **Post-Instrument events**.  
  
    > [!NOTE]
    > You can click the ellipsis button **(…)** that is adjacent to the **Command line** box to browse to and select the appropriate .exe, .cmd, or .bat file.  
  
4. Click **OK**.  
  
     To disable the command from running without removing it, select the **Exclude from instrumentation** check box. To modify compiler or linker settings, use the project property pages.  
  
## See Also  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)
