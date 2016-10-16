---
title: "How to: Collect Performance Data for a Web Site"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vsperf.url.url"
  - "vsperf.chooseurl"
  - "vs.performance.wizard.asppage"
  - "vsperf.url.ok"
  - "vsperf.url.cancel"
helpviewer_keywords: 
  - "Profiling Tools,profiling ASP.NET"
  - "web sites, performance profiling"
  - "ASP.NET, performance profilng"
ms.assetid: a62d27fd-a966-4065-bebe-6874195a71fb
caps.latest.revision: 33
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
# How to: Collect Performance Data for a Web Site
You can use the **Performance Wizard** to collect performance data for an [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web application. You can profile a Web application that is open in [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)], or you can profile an [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web site that is located on your local computer and not open in the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] IDE.  
  
> [!NOTE]
>  The **Performance Wizard** enables you to add tier interaction (TIP) data, JScript performance data, or both to the collected profiling data. The TIP option collects data from server-side processes. The JScript profiling collects data from scripts that are running on a local or  remote Web site. In most cases, you should choose only one of the options.  
  
 Depending on User Access Permissions settings that an administrator has made available, an individual user might or might not have security permission to create a profiler session on the computer that hosts the ASP.NET process. The following examples illustrate possible differences among users:  
  
-   Some users may access advanced profiling features when the Administrator has set the driver and service to start.  
  
-   Domain users may access sample profiling only.  
  
-   Some users my deny access to profiling to all other users.  
  
 For more information, see [Profiling and Windows Vista Security](../profiling/profiling-and-windows-vista-security.md) and the ADMIN options in [VSPerfCmd](../profiling/vsperfcmd.md).  
  
### To profile a Web site project  
  
1.  Open the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web project in [!INCLUDE[vsPreShort](../codequality/includes/vspreshort_md.md)] or [!INCLUDE[vsUltShort](../codequality/includes/vsultshort_md.md)].  
  
2.  On the **Analyze** menu, click **Launch Performance Wizard**.  
  
3.  On the first page of the wizard, select a profiling method, and then click **Next**. For more information about profiling methods, see [Understanding Performance Collection Methods](../profiling/understanding-performance-collection-methods.md). Note that the concurrency visualizer profiling method is not available for web applications.  
  
4.  In the **Which application would you like to target for profiling?** drop-down list, make sure that the current project is selected, and then click **Next**.  
  
5.  On the third page of the wizard, you can choose to add tier interaction profiling (TIP) data, data from the JavaScript running in the Web pages, or both.  
  
    -   To collect tier interaction, select the **Enable Tier Interaction Profiling** check box.  
  
    -   To collect data from the JavaScript running in the Web pages, select the **Profile JavaScript** check box.  
  
6.  Click **Next**.  
  
7.  On the fourth page of the wizard, click **Finish**.  
  
8.  A performance session is created for the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] application, and the Web site is started in the browser. Exercise the functionality that you want to profile, and then close the browser.  
  
     The profiler generates the data file and displays the Summary view of the data in the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] main window.  
  
### To profile a Web site without opening a project in Visual Studio  
  
1.  Open [!INCLUDE[vsPreShort](../codequality/includes/vspreshort_md.md)] or [!INCLUDE[vsUltShort](../codequality/includes/vsultshort_md.md)].  
  
2.  On the **Analyze** menu, click **Launch Performance Wizard**.  
  
3.  On the first page of the wizard, select a profiling method, and then click **Next**. For more information, see [Understanding Performance Collection Methods](../profiling/understanding-performance-collection-methods.md).  
  
4.  On the second page of the wizard, select the **Profile an ASP.NET or JavaScript application** option, and then click **Next**.  
  
5.  In the **What URL or Path will run your web application** box on the third page of the wizard, enter the URL to the application home page, and then click **Next**.  
  
    -   For a server (IIS) based Web site, type a URL such as **http://localhost/MySite/default.aspx**. This causes the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] application on the local computer at the application root of MySite to be profiled, and the page default.aspx on that site to be started in Internet Explorer to start the session.  
  
    -   For a file based Web site, type a path such as file///**c:\WebSites\MySite\default.aspx**. This causes the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] application located at c:\webSites\MySite to be profiled and the page http://localhost:nnnn/MySite/default.aspx to be started in Internet Explorer to start the session.  
  
    -   For external sites that you wish to collect JavaScript data on, type the URL, for example http://www.contoso.com.  
  
     For more information, view the property pages for an [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] target binary.  
  
6.  On the third page of the wizard, you can choose to add tier interaction profiling (TIP) data, data from the JavaScript running in the Web pages, or both.  
  
    -   To collect tier interaction, select the **Enable Tier Interaction Profiling** check box.  
  
    -   To collect data from the JavaScript running in the Web pages, select the **Profile JavaScript** check box.  
  
7.  Click **Next**.  
  
8.  On the fourth page of the wizard, click **Finish**.  
  
9. A performance session is created for the ASP.NET application, and the Web site is started in the browser. Exercise the functionality that you want to profile, and then close the browser.  
  
     The profiler generates the data file and displays the Summary view of the data in the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] main window.  
  
## See Also  
 [Overviews](../profiling/overviews--performance-tools-.md)   
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [Understanding Instrumentation Data Values](../profiling/understanding-instrumentation-data-values.md)   
 [Understanding Sampling Data Values](../profiling/understanding-sampling-data-values.md)