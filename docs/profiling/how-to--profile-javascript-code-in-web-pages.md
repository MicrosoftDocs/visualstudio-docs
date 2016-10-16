---
title: "How to: Profile JavaScript Code in Web Pages"
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
  - "JavaScript performance profiling"
  - "Profiling Tools,JavaScript"
  - "web site performance profiling"
ms.assetid: 37d02aad-ca4d-4eb0-bf66-ca3ecef31fbe
caps.latest.revision: 27
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
# How to: Profile JavaScript Code in Web Pages
[!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Profiling Tools can collect performance data for JavaScript code that executes in an [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web application, an arbitrary Web page, or JavaScript application by using the instrumentation profiling method.  
  
 **Requirements**  
  
-   [!INCLUDE[vsUltLong](../codequality/includes/vsultlong_md.md)], [!INCLUDE[vsPreLong](../codequality/includes/vsprelong_md.md)], [!INCLUDE[vsPro](../codequality/includes/vspro_md.md)]  
  
-   Internet Explorer 8 or later.  
  
> [!WARNING]
>  To profile JavaScript in Windows Store apps, see one of the following topics:  
>   
>  -   [JavaScript Function Timing](../Topic/JavaScript%20Function%20Timing.md) [JavaScript Function Timing on a Remote Device](../Topic/JavaScript%20Function%20Timing%20on%20a%20Remote%20Device.md)  
> -   [Analyze JavaScript Function Timing data](../Topic/Analyze%20JavaScript%20Function%20Timing%20data.md)  
> -  
  
 You can use the Profiling Wizard to create a performance session. Specify the instrumentation method and then specify the JavaScript profiling option on the Instrumentation page of the properties dialog box for the performance session.  
  
 When you specify JavaScript profiling, both the JavaScript code that executes in the browser and the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] code that executes on the server are profiled.  
  
-   For an [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web application, both the JavaScript code that executes in the browser and the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] code that executes on the server are profiled.  
  
-   For an arbitrary Web page, the JavaScript code that executes in the browser is profiled.  
  
### To profile JavaScript in an ASP.NET Web application project  
  
1.  In [!INCLUDE[vsPreLong](../codequality/includes/vsprelong_md.md)], open the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web project.  
  
2.  On the **Analyze** menu, click **Launch Performance Wizard**.  
  
3.  On the first page of the Performance Wizard, specify the **Instrumentation** profiling method, and then click **Next**.  
  
4.  On the second page of the wizard, make sure that the current project is selected in the list of targets, and then click **Next.**  
  
5.  On the third page of the wizard, select the **Profile JavaScript** check box, and then click **Next**.  
  
6.  On the fourth page of the wizard, click **Finish** to start the Web application in the browser.  
  
7.  Exercise the functionality that you want to profile.  
  
8.  To end the profiling session, close the browser.  
  
### To profile JavaScript in individual Web pages or a JavaScript applications  
  
1.  Open [!INCLUDE[vsPreShort](../codequality/includes/vspreshort_md.md)].  
  
2.  On the **Analyze** menu, click **Launch Performance Wizard**.  
  
3.  On the first page of the Performance Wizard, specify the **Instrumentation** profiling method, and then click **Next**.  
  
4.  On the second page of the wizard, click An ASP.NET or JavaScript application, and then click **Next.**  
  
5.  On the third page of the wizard:  
  
    1.  Type the URL of the page in the **What URL or path will run your application** box.  
  
    2.  Select the **Profile JavaScript** check box, and then click **Next**.  
  
6.  On the fourth page of the wizard, click **Finish** to start the Web page in the browser.  
  
7.  Exercise the functionality that you want to profile.  
  
8.  To end the profiling session, close the browser.