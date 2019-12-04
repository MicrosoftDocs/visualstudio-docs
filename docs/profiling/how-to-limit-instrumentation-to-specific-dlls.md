---
title: "How to: Limit Instrumentation to Specific DLLs | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "performance tools, runtime profiling control window"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# How to: Limit instrumentation to specific DLLs

By using the instrumentation profiling method, you can limit the collection of profiling data to one or more DLLs in an application. To profile one or more DLLs in an application, you create a performance session that includes the .*dll* files as targets. You can specify the DLLs that you want to profile as projects in a Visual Studio solution or as independent binary files.

## To limit instrumentation to specific DLLs in a Visual Studio solution

1. Open the solution that contains the DLL in Visual Studio.

2. On the **Analyze** menu, select **Launch Performance Wizard**.

3. Choose **Instrumentation** as the profiling method and then click **Next**.

4. From the **Which of the following available targets would you like to profile?**, select the name of the .*dll* project and then click **Next**.

5. Click **Finish** to exit the wizard and display the new performance session in the **Performance Explorer** window.

6. Right-click **Targets** and then select **Add Target Project**.

7. From the **Add Target Project** list, select the executable project that you want to use to exercise the DLL.

     Optional. You can add any DLL projects that you want to profile.

8. To prevent data collection for an added project, right-click the name of the project, and then clear the **Instrument** check box.

## To specify specific DLLs to profile as independent binaries

1. Open Visual Studio.

2. On the **Analyze** menu, select **Launch Performance Wizard**.

3. From the **Which of the following available targets would you like to profile**, select the **Profile a dynamic link library (.DLL)** and then click **Next**.

4. On the second page of the wizard, perform the following steps:

    - Type the path and file name of the .*dll* file that you want to profile in **Dll path**. You can also click the ellipsis button (...) to locate the file in the **Dynamic link library to profile** dialog box. Note that you must specify the copy of the .*dll* file that will be launched by the executable (.*exe*) file that you select next.

    - Type the path and file name of the executable (.*exe*) file that will exercise the .*dll* in **Executable path**. You can also click the ellipsis button (...) to locate the file in the **Executable to launch** dialog box.

    - Optional. Type any command line arguments that you want to pass to the executable file in **Command line arguments**. If necessary, specify the working directory for the application in **Working directory**.

    - Click **Next**.

5. Choose **Instrumentation** as the profiling method and then click **Next**.

6. Click **Finish** to exit the wizard and display the new performance session in the **Performance Explorer** window.

7. Optional. To add more .*dll* files, right-click **Targets** and then select **Add Target Binary**. Select the files from the **Add Target Binary** dialog box.

    > [!NOTE]
    > Do not specify the executable (.*exe*) file that exercises the DLLs.

## See also

[Control data collection](../profiling/controlling-data-collection.md)
[How to: Limit instrumentation to specific functions](../profiling/how-to-limit-instrumentation-to-specific-functions.md)
