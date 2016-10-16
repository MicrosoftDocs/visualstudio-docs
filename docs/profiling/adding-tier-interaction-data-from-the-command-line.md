---
title: "Adding tier interaction data from the command line"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "tier interaction profiling method"
  - "profiling tools,tier interaction method"
ms.assetid: 5a35647f-03f2-4555-8eeb-fda7e0080e67
caps.latest.revision: 9
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Adding tier interaction data from the command line
Tier interaction profiling provides additional information about the execution times of synchronous [!INCLUDE[vstecado](../datatools/includes/vstecado_md.md)] calls in functions of multi-tiered applications that communicate with one or more databases.  
  
 **Windows 8 and Windows Server 2012**  
  
 To collect tier interaction data on Windows 8 desktop apps and Windows Server 2012 apps you must use the instrumentation method. Collecting tier interaction data on Windows Store apps is not supported.  
  
 **Visual Studio editions**  
  
 Tier interaction profiling can be collected using [!INCLUDE[vsUltLong](../codequality/includes/vsultlong_md.md)], [!INCLUDE[vsPreLong](../codequality/includes/vsprelong_md.md)], or [!INCLUDE[vs_pro_current_short](../profiling/includes/vs_pro_current_short_md.md)]. However, tier interaction profiling data can be viewed only in [!INCLUDE[vsUltLong](../codequality/includes/vsultlong_md.md)] and [!INCLUDE[vsPreLong](../codequality/includes/vsprelong_md.md)].  
  
 **Collecting TIP data on a remote machine**  
  
 To collect tier interaction data on a remote machine, you must copy the **vs_profiler_***\<Platform>***_***\<Language>***.exe** file from the *%VSInstallDir%***\Team Tools\Performance Tools\Setups** folder of a Visual Studio machine to the remote computer and install it. You cannot use the profiling tools in the [Visual Studio Remote Tools](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md) download package.  
  
 **TIP reports**  
  
 Tier interaction data can only be viewed in the [!INCLUDE[vsUltLong](../codequality/includes/vsultlong_md.md)] IDE. File based tier interaction reports through [VSPerfReport](../profiling/vsperfreport.md) are not available.  
  
## Adding tier interaction data with VSPerfCmd  
 The VSPerfASPNETCmd command line tool lets you access the complete functionality available in the Profiling Tools. To add tier interaction to profiling data collected by using VSPerfCmd, you must use the **VSPerfCLREnv** utility to set and remove the environment variables that enables tier interaction data. The options that you specify and the procedures required to collect data depend on the type of application that you are profiling.  
  
### Profiling stand-alone applications  
 To add tier interaction data to an application that is not run by another process, such as a Windows desktop application that makes synchronous [!INCLUDE[vstecado](../datatools/includes/vstecado_md.md)] calls to a SQLServer database, use the **VSPerfClrEnv /InteractionOn** option to set the environment variables, and the **VSPerfClrEnv /InteractionOff** option to remove them.  
  
 In the following example, a Windows desktop application is profiled by using the instrumentation method and tier interaction data is collected.  
  
##### Profiling a Windows desktop application example  
  
1.  Open a command prompt window with Administrator privileges. Click **Start**, point to **All Programs**, and then point to **Accessories**. Right-click **Command Prompt**, and then click **Run As Administrator**.  
  
2.  Initialize .NET profiling and the TIP environment variables. Type the following commands:  
  
    ```  
    vsperfclrenv /traceon  
    vsperfclrenv /interactionon  
    ```  
  
3.  Start the profiler. Type the following command:  
  
    ```  
    vsperfcmd /start:trace /output:Desktop_tip.vsp   
    ```  
  
4.  Start the application with VSPerfCmd. Type the following command:  
  
    ```  
    vsperfcmd /launch:DesktopApp.exe  
    ```  
  
5.  Exercise the application to collect profiling data, and then close the application in the regular way.  
  
6.  Clear the TIP environment variables. Type the following command:  
  
    ```  
    vsperfclrenv /off  
    ```  
  
 For more information, see [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md).  
  
### Profiling services  
 To profile services, including [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] applications, use the **VSPerfClrEnv /GlobalInteractionOn** option to set the environment variables, and the **VSPerfClrEnv /GlobalInteractionOff** option to remove them.  
  
 When you are profiling services, including [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web applications, you will often need to restart the computer to enable profiling.  
  
 In the following example, a Windows service is profiled by using the instrumenation method and tier interaction data is collected.  
  
##### Profiling a Windows service example  
  
1.  If necessary, install the service.  
  
2.  Open a command prompt window with Administrator privileges. Click **Start**, point to **All Programs**, and then point to **Accessories**. Right-click **Command Prompt**, and then click **Run As Administrator**.  
  
3.  Initialize the .NET profiling environment variables. Type the following command:  
  
    ```  
    vsperfclrenv /globaltraceon  
    ```  
  
4.  Initialize the TIP environment variables. Type the following command  
  
    ```  
    vsperfclrenv /globalinteractionon  
    ```  
  
5.  Restart the computer to register the environment variables.  
  
6.  Open a command prompt window with Administrator privileges.  
  
7.  Start the profiler. Type the following command:  
  
    ```  
    vsperfcmd /start:trace /output:MiddleTier_tip.vsp /user:SYSTEM /crosssession   
    ```  
  
8.  If necessary, start the service.  
  
9. Attach the profiler to the service. Type the following command:  
  
    ```  
    vsperfcmd /attach:MiddleTier.exe /output:MyService_tip.vsp /user:SYSTEM /crosssession   
    ```  
  
10. Exercise the service and collect profiling data.  
  
11. Stop the profiler. Type the following command:  
  
     `vsperfcmd /detach`  
  
12. Clear the .NET and TIP profiling environment variables. Type the following command:  
  
    ```  
    vsperfclrenv /globaloff  
    ```  
  
13. Restart the computer to register the cleared environment variables.  
  
 For more information, see one of the following topics:  
  
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-asp.net-web-applications.md)  
  
 [Profiling Services](../profiling/command-line-profiling-of-services.md)  
  
## Adding tier interaction data with VSPerfASPNETCmd  
 The VSPerfASPNETCmd command-line tool enables you to easily profile [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web applications. Compared with the **VSPerfCmd** command-line tool, options are reduced, no environment variables have to be set, and rebooting the computer is not required. These features of VSPerfASPNETCmd make the collection of tier interaction data exceptionally easy.  
  
 To add tier interaction to profiling data collected by using VSPerfASPNETCmd, add the **/TIP** option to the command line. For example, use the following command line to collect tier interaction data for an [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web application by using the instrumentation method:  
  
```  
vsperfaspnetcmd /tip /trace http://localhost/MyWebApp  
```  
  
 For more information about VSPerfASPNETCmd, see [Rapid Web Site Profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md).