---
title: "Adding tier interaction data from the command line | Microsoft Docs"
description: For multi-tiered applications that communicate with one or more databases, use tier interaction profiling for execution time information for synchronous calls. 
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "tier interaction profiling method"
  - "profiling tools,tier interaction method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Add tier interaction data from the command line

Tier interaction profiling provides additional information about the execution times of synchronous [!INCLUDE[vstecado](../data-tools/includes/vstecado_md.md)] calls in functions of multi-tiered applications that communicate with one or more databases.

**Windows 8 and Windows Server 2012**

To collect tier interaction data on Windows 8 desktop apps and Windows Server 2012 apps you must use the instrumentation method. Collecting tier interaction data on UWP apps is not supported.

**Visual Studio editions**

Tier interaction profiling can be collected using any edition of Visual Studio. However, tier interaction profiling data can be viewed only in Visual Studio Enterprise.

**Collect TIP data on a remote machine**

To collect tier interaction data on a remote machine, you must copy the **vs_profiler\_**_\<Platform>_**\_**_\<Language>_**.exe** file from the _%VSInstallDir%_**\Team Tools\Performance Tools\Setups** folder of a Visual Studio machine to the remote computer and install it. You cannot use the profiling tools in the [Remote Debugging](../debugger/remote-debugging.md) download package.

**TIP reports**

Tier interaction data can only be viewed in Visual Studio Enterprise. File based tier interaction reports through [VSPerfReport](../profiling/vsperfreport.md) are not available.

## Add tier interaction data with VSPerfCmd

The VSPerfASPNETCmd command line tool lets you access the complete functionality available in the Profiling Tools. To add tier interaction to profiling data collected by using VSPerfCmd, you must use the **VSPerfCLREnv** utility to set and remove the environment variables that enables tier interaction data. The options that you specify and the procedures required to collect data depend on the type of application that you are profiling.

## Profile stand-alone applications

To add tier interaction data to an application that is not run by another process, such as a Windows desktop application that makes synchronous [!INCLUDE[vstecado](../data-tools/includes/vstecado_md.md)] calls to a SQLServer database, use the **VSPerfClrEnv /InteractionOn** option to set the environment variables, and the **VSPerfClrEnv /InteractionOff** option to remove them.

In the following example, a Windows desktop application is profiled by using the instrumentation method and tier interaction data is collected.

### Profile a Windows desktop application example

1. Open a command prompt window with Administrator privileges. Click **Start**, point to **All Programs**, and then point to **Accessories**. Right-click **Command Prompt**, and then click **Run As Administrator**.

2. Initialize .NET profiling and the TIP environment variables. Type the following commands:

    ```cmd
    vsperfclrenv /traceon
    vsperfclrenv /interactionon
    ```

3. Start the profiler. Type the following command:

    ```cmd
    vsperfcmd /start:trace /output:Desktop_tip.vsp
    ```

4. Start the application with VSPerfCmd. Type the following command:

    ```cmd
    vsperfcmd /launch:DesktopApp.exe
    ```

5. Exercise the application to collect profiling data, and then close the application in the regular way.

6. Clear the TIP environment variables. Type the following command:

    ```cmd
    vsperfclrenv /off
    ```

For more information, see [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md).

## Profile services

To profile services, including [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] applications, use the **VSPerfClrEnv /GlobalInteractionOn** option to set the environment variables, and the **VSPerfClrEnv /GlobalInteractionOff** option to remove them.

When you are profiling services, including [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web applications, you will often need to restart the computer to enable profiling.

In the following example, a Windows service is profiled by using the instrumentation method and tier interaction data is collected.

### Profile a Windows service example

1. If necessary, install the service.

2. Open a command prompt window with Administrator privileges. Click **Start**, point to **All Programs**, and then point to **Accessories**. Right-click **Command Prompt**, and then click **Run As Administrator**.

3. Initialize the .NET profiling environment variables. Type the following command:

    ```cmd
    vsperfclrenv /globaltraceon
    ```

4. Initialize the TIP environment variables. Type the following command:

    ```cmd
    vsperfclrenv /globalinteractionon
    ```

5. Restart the computer to register the environment variables.

6. Open a command prompt window with Administrator privileges.

7. Start the profiler. Type the following command:

    ```cmd
    vsperfcmd /start:trace /output:MiddleTier_tip.vsp /user:SYSTEM /crosssession
    ```

8. If necessary, start the service.

9. Attach the profiler to the service. Type the following command:

    ```cmd
    vsperfcmd /attach:MiddleTier.exe /output:MyService_tip.vsp /user:SYSTEM /crosssession
    ```

10. Exercise the service and collect profiling data.

11. Stop the profiler. Type the following command:

     `vsperfcmd /detach`

12. Clear the .NET and TIP profiling environment variables. Type the following command:

    ```cmd
    vsperfclrenv /globaloff
    ```

13. Restart the computer to register the cleared environment variables.

For more information, see one of the following topics:

[Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)

[Profile services](../profiling/command-line-profiling-of-services.md)

## Add tier interaction data with VSPerfASPNETCmd

The VSPerfASPNETCmd command-line tool enables you to easily profile [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web applications. Compared with the **VSPerfCmd** command-line tool, options are reduced, no environment variables have to be set, and rebooting the computer is not required. These features of VSPerfASPNETCmd make the collection of tier interaction data exceptionally easy.

To add tier interaction to profiling data collected by using VSPerfASPNETCmd, add the **/TIP** option to the command line. For example, use the following command line to collect tier interaction data for an [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web application by using the instrumentation method:

```cmd
vsperfaspnetcmd /tip /trace http://localhost/MyWebApp
```

For more information about VSPerfASPNETCmd, see [Rapid web site profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md).
