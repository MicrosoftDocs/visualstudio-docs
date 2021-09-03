---
title: Load Test API
description: Learn how to use the load test API, which supports test plug-ins, which can control or enhance a load test.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
helpviewer_keywords: 
  - code, load tests
  - plug-ins, load test
  - APIs, load tests
ms.assetid: e15567bc-1f21-4feb-b81d-f17ba35cfde5
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# How to: Use the load test API

Visual Studio supports load test plug-ins which can control or enhance a load test. Load test plug-ins are user defined classes which implement the <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin> interface found in the <xref:Microsoft.VisualStudio.TestTools.LoadTesting> namespace. Load test plug-ins allow for custom load test control, such as, aborting a load test when a counter or error threshold is met. Use the properties on the <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest> class to get or set load test parameters from user defined code. Use the events on the <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest> class to attach delegates for notifications when the load test is running.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

> [!TIP]
> Use the object browser to examine the <xref:Microsoft.VisualStudio.TestTools.LoadTesting> namespace. Both the Visual C# and Visual Basic editors offer IntelliSense support for coding with the classes in the namespace.

You can also create plug-ins for web performance tests. For more information, see [How to: Create a web performance test plug-in](../test/how-to-create-a-web-performance-test-plug-in.md) and [How to: Create a request-level plug-in](../test/how-to-create-a-request-level-plug-in.md).

## To use the LoadTesting namespace

1. Open a web performance and load test project that contains a load test.

2. Add a Visual C# or a Visual Basic class library project to your test solution.

3. Add a reference in the web performance and load test project to the class library project.

4. Add a reference to the Microsoft.VisualStudio.QualityTools.LoadTestFramework DLL in the Class Library project.

5. In the class file located in the class library project, add a `using` statement for the <xref:Microsoft.VisualStudio.TestTools.LoadTesting> namespace.

6. Create a public class that implements the <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin> interface.

7. Build the project.

8. Add the new load test plug-in using the Load Test Editor:

    1. Right-click the root node of the load test and then choose **Add Load Test Plug-in**.

    2. The **Add Load Test Plug-in** dialog box is displayed.

    3. In the **Properties for selected plug-in** pane, set the initial values for the plug-in to use at run time.

        > [!NOTE]
        > You can expose as many properties as you want from your plug-ins. Just make them public, settable, and of a base type such as Integer, Boolean, or String. You can also edit the load test plug-in properties later using the **Properties** window.

9. Run your Load test.

     For an implementation of <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin>, see [How to: Create a load test plug-in](../test/how-to-create-a-load-test-plug-in.md).

## See also

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting>
- [Create custom code and plug-ins for load tests](../test/create-custom-code-and-plug-ins-for-load-tests.md)
- [How to: Use the web performance test API](../test/how-to-use-the-web-performance-test-api.md)
- [How to: Create a load test plug-in](../test/how-to-create-a-load-test-plug-in.md)
