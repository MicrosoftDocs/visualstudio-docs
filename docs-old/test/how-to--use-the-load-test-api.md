---
title: "How to: Use the Load Test API"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "code, load tests"
  - "plug-ins, load test"
  - "APIs, load tests"
ms.assetid: e15567bc-1f21-4feb-b81d-f17ba35cfde5
caps.latest.revision: 44
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Use the Load Test API
Visual Studio Enterprise supports load test plug-ins which can control or enhance a load test. Load test plug-ins are user defined classes which implement the \<xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin> interface found in the \<xref:Microsoft.VisualStudio.TestTools.LoadTesting> namespace. Load test plug-ins allow for custom load test control, such as, aborting a load test when a counter or error threshold is met. Use the properties on the \<xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest> class to get or set load test parameters from user defined code. Use the events on the \<xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest> class to attach delegates for notifications when the load test is running.  
  
> [!TIP]
>  Use the object browser to examine the \<xref:Microsoft.VisualStudio.TestTools.LoadTesting> namespace. Both the Visual C# and Visual Basic editors offer IntelliSense support for coding with the classes in the namespace.  
  
 You can also create plug-ins for Web performance tests. For more information, see [How to: Create a Web Performance Test Plug-In](../test/how-to--create-a-web-performance-test-plug-in.md) and [How to: Create a Request-Level Plug-In](../test/how-to--create-a-request-level-plug-in.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To use the LoadTesting namespace  
  
1.  Open a Web performance and load test Project that contains a load test.  
  
     For more information, see [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4).  
  
2.  Add a Visual C# or a Visual Basic class library project to your test solution.  
  
3.  Add a reference in the Web performance and load test project to the class library project.  
  
4.  Add a reference to the Microsoft.VisualStudio.QualityTools.LoadTestFramework DLL in the Class Library project.  
  
5.  In the class file located in the class library project, add a `using` statement for the \<xref:Microsoft.VisualStudio.TestTools.LoadTesting> namespace.  
  
6.  Create a public class that implements the \<xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin> interface.  
  
7.  Build the project.  
  
8.  Add the new load test plug-in using the Load Test Editor:  
  
    1.  Right-click the root node of the load test and then choose **Add Load Test Plug-in**.  
  
    2.  The **Add Load Test Plug-in** dialog box is displayed.  
  
    3.  In the Properties for selected plug-in pane, set the initial values for the plug-in to use at run time.  
  
        > [!NOTE]
        >  You can expose as many properties as you want from your plug-ins. Just make them public, settable, and of a base type such as Integer, Boolean, or String. You can also edit the load test plug-in properties later using the Properties window.  
  
9. Run your Load test.  
  
     For an implementation of \<xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin>, see [How to: Create a Load Test Plug-In](../test/how-to--create-a-load-test-plug-in.md).  
  
## See Also  
 \<xref:Microsoft.VisualStudio.TestTools.LoadTesting>   
 [Create custom code and plug-ins for load tests](../test/create-custom-code-and-plug-ins-for-load-tests.md)   
 [How to: Use the Web Performance Test API](../test/how-to--use-the-web-performance-test-api.md)   
 [How to: Create a Load Test Plug-In](../test/how-to--create-a-load-test-plug-in.md)