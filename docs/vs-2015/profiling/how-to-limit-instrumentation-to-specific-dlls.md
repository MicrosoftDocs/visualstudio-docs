---
title: "How to: Limit Instrumentation to Specific DLLs | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "performance tools, runtime profiling control window"
ms.assetid: 17c5996f-e3d0-4e44-b175-52b401b0f2d5
caps.latest.revision: 24
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Limit Instrumentation to Specific DLLs
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By using the instrumentation profiling method, you can limit the collection of profiling data to one or more DLLs in an application. To profile one or more DLLs in an application, you create a performance session that includes the .dll files as targets. You can specify the DLLs that you want to profile as projects in a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] solution or as independent binary files.  
  
### To limit instrumentation to specific DLLs in a Visual Studio solution  
  
1. Open the solution that contains the DLL in [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)].  
  
2. On the **Analyze** menu, select **Launch Performance Wizard**.  
  
3. Choose **Instrumentation** as the profiling method and then click **Next**.  
  
4. From the **Which of the following available targets would you like to profile?**, select the name of the .dll project and then click **Next**.  
  
5. Click **Finish** to exit the wizard and display the new performance session in the **Performance Explorer** window.  
  
6. Right-click **Targets** and then select **Add Target Project**.  
  
7. From the **Add Target Project** list, select the executable project that you want to use to exercise the DLL.  
  
     Optional. You can add any DLL projects that you want to profile.  
  
8. To prevent data collection for an added project, right-click the name of the project, and then clear the **Instrument** check box.  
  
### To specify specific DLLs to profile as independent binaries  
  
1. Open [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)].  
  
2. On the **Analyze** menu, select **Launch Performance Wizard**.  
  
3. From the **Which of the following available targets would you like to profile**, select the **Profile a dynamic link library (.DLL)** and then click **Next**.  
  
4. On the second page of the wizard, perform the following steps:  
  
    - Type the path and file name of the .dll file that you want to profile in **Dll path**. You can also click the ellipsis button (...) to locate the file in the **Dynamic link library to profile** dialog box. Note that you must specify the copy of the .dll file that will be launched by the executable (.exe) file that you select next.  
  
    - Type the path and file name of the executable (.exe) file that will exercise the .dll in **Executable path**. You can also click the ellipsis button (...) to locate the file in the **Executable to launch** dialog box.  
  
    - Optional. Type any command line arguments that you want to pass to the executable file in **Command line arguments**. If necessary, specify the working directory for the application in **Working directory**.  
  
    - Click **Next**.  
  
5. Choose **Instrumentation** as the profiling method and then click **Next**.  
  
6. Click **Finish** to exit the wizard and display the new performance session in the **Performance Explorer** window.  
  
7. Optional. To add more .dll files, right-click **Targets** and then select **Add Target Binary**. Select the files from the **Add Target Binary** dialog box.  
  
    > [!NOTE]
    > Do not specify the executable (.exe) file that exercises the DLLs.  
  
## See Also  
 [Controlling Data Collection](../profiling/controlling-data-collection.md)   
 [How to: Limit Instrumentation to Specific Functions](../profiling/how-to-limit-instrumentation-to-specific-functions.md)
