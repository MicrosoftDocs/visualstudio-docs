---
title: "How to: Profile JavaScript Code in Web Pages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "JavaScript performance profiling"
  - "Profiling Tools,JavaScript"
  - "web site performance profiling"
ms.assetid: 37d02aad-ca4d-4eb0-bf66-ca3ecef31fbe
caps.latest.revision: 32
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Profile JavaScript Code in Web Pages
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools can collect performance data for JavaScript code that executes in an [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] Web application, an arbitrary Web page, or JavaScript application by using the instrumentation profiling method.  
  
 **Requirements**  
  
- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
- Internet Explorer 8 or later.  
  
> [!WARNING]
> To profile JavaScript in Windows Store apps, see one of the following topics:  
> 
> - [JavaScript Function Timing](https://msdn.microsoft.com/library/b2bf49fc-aea7-4d9c-8fcf-cff8b8dd0c03) [JavaScript Function Timing on a Remote Device](https://msdn.microsoft.com/library/d78812b6-a97e-46dc-8d99-e724d1d725d8)  
>   - [Analyze JavaScript Function Timing data](https://msdn.microsoft.com/library/b5aea8d8-36df-47ba-a7ca-95406700ca9b)  
>   - 
  
 You can use the Profiling Wizard to create a performance session. Specify the instrumentation method and then specify the JavaScript profiling option on the Instrumentation page of the properties dialog box for the performance session.  
  
 When you specify JavaScript profiling, both the JavaScript code that executes in the browser and the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] code that executes on the server are profiled.  
  
- For an [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] Web application, both the JavaScript code that executes in the browser and the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] code that executes on the server are profiled.  
  
- For an arbitrary Web page, the JavaScript code that executes in the browser is profiled.  
  
### To profile JavaScript in an ASP.NET Web application project  
  
1. In [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], open the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] Web project.  
  
2. On the **Analyze** menu, click **Launch Performance Wizard**.  
  
3. On the first page of the Performance Wizard, specify the **Instrumentation** profiling method, and then click **Next**.  
  
4. On the second page of the wizard, make sure that the current project is selected in the list of targets, and then click **Next.**  
  
5. On the third page of the wizard, select the **Profile JavaScript** check box, and then click **Next**.  
  
6. On the fourth page of the wizard, click **Finish** to start the Web application in the browser.  
  
7. Exercise the functionality that you want to profile.  
  
8. To end the profiling session, close the browser.  
  
### To profile JavaScript in individual Web pages or a JavaScript applications  
  
1. Open [!INCLUDE[vsPreShort](../includes/vspreshort-md.md)].  
  
2. On the **Analyze** menu, click **Launch Performance Wizard**.  
  
3. On the first page of the Performance Wizard, specify the **Instrumentation** profiling method, and then click **Next**.  
  
4. On the second page of the wizard, click An ASP.NET or JavaScript application, and then click **Next.**  
  
5. On the third page of the wizard:  
  
    1. Type the URL of the page in the **What URL or path will run your application** box.  
  
    2. Select the **Profile JavaScript** check box, and then click **Next**.  
  
6. On the fourth page of the wizard, click **Finish** to start the Web page in the browser.  
  
7. Exercise the functionality that you want to profile.  
  
8. To end the profiling session, close the browser.
