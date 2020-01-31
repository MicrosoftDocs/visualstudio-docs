---
title: "How to: Profile JavaScript Code in Web Pages | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "JavaScript performance profiling"
  - "Profiling Tools,JavaScript"
  - "web site performance profiling"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# How to: Profile JavaScript code in web pages

Visual Studio Profiling Tools can collect performance data for JavaScript code that executes in an [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application, an arbitrary web page, or JavaScript application by using the instrumentation profiling method. Requires Internet Explorer 8 or later.

> [!WARNING]
> To profile JavaScript in UWP apps, see [JavaScript Memory](../profiling/javascript-memory.md)

You can use the Profiling Wizard to create a performance session. Specify the instrumentation method and then specify the JavaScript profiling option on the Instrumentation page of the properties dialog box for the performance session.

When you specify JavaScript profiling, both the JavaScript code that executes in the browser and the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] code that executes on the server are profiled.

- For an [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application, both the JavaScript code that executes in the browser and the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] code that executes on the server are profiled.

- For an arbitrary web page, the JavaScript code that executes in the browser is profiled.

## To profile JavaScript in an ASP.NET web application project

1. Open the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web project in Visual Studio.

2. On the **Analyze** menu, click **Launch Performance Wizard**.

3. On the first page of the Performance Wizard, specify the **Instrumentation** profiling method, and then click **Next**.

4. On the second page of the wizard, make sure that the current project is selected in the list of targets, and then click **Next.**

5. On the third page of the wizard, select the **Profile JavaScript** check box, and then click **Next**.

6. On the fourth page of the wizard, click **Finish** to start the web application in the browser.

7. Exercise the functionality that you want to profile.

8. To end the profiling session, close the browser.

### To profile JavaScript in individual web pages or a JavaScript applications

1. Open Visual Studio.

2. On the **Analyze** menu, click **Launch Performance Wizard**.

3. On the first page of the Performance Wizard, specify the **Instrumentation** profiling method, and then click **Next**.

4. On the second page of the wizard, click An ASP.NET or JavaScript application, and then click **Next.**

5. On the third page of the wizard:

    1. Type the URL of the page in the **What URL or path will run your application** box.

    2. Select the **Profile JavaScript** check box, and then click **Next**.

6. On the fourth page of the wizard, click **Finish** to start the web page in the browser.

7. Exercise the functionality that you want to profile.

8. To end the profiling session, close the browser.
