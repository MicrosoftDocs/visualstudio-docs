---
title: "Create custom code and plug-ins for load tests"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.dialog.recorderplugin"
helpviewer_keywords: 
  - "Web performance tests, plug-ins"
  - "load tests, plug-ins"
ms.assetid: 0c0fcc99-673b-4ea0-a268-0475f66e5cb6
caps.latest.revision: 26
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
# Create custom code and plug-ins for load tests
A custom plug-in uses code that you write and attach to a load test or a Web performance test. You can use the load test API and the Web Performance test API to create custom plug-ins for tests to expand to the built-in functionality.  
  
> [!NOTE]
>  In this version, you can add multiple plug-ins to your load test. Prior to Visual Studio Ultimate 2010, you were limited to using only one plug-in per load test. You no longer have to place all of your add-in code into the same plug-in.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Tasks  
  
|Tasks|Associated topics|  
|-----------|-----------------------|  
|**Create a custom plug-in for your load test**: You can use load test API to create a custom plug-in to add more testing functionality to your load test.|-   [How to: Use the Load Test API](../test/how-to--use-the-load-test-api.md)<br />-   [How to: Create a Load Test Plug-In](../test/how-to--create-a-load-test-plug-in.md)|  
|**Create a custom plug-in for your Web Performance test:** You can use Web performance test API to create a custom plug-in to add more testing functionality to your Web performance test, including at the request level. You can also create a Web Service test.<br /><br /> Additionally, you can create a Web recorder plug-in that can modify a Web performance test after it is recorded, but before it appears in the Web Performance Test Result Viewer.|-   [How to: Use the Web Performance Test API](../test/how-to--use-the-web-performance-test-api.md)<br />-   [How to: Create a Web Performance Test Plug-In](../test/how-to--create-a-web-performance-test-plug-in.md)<br />-   [How to: Create a Request-Level Plug-In](../test/how-to--create-a-request-level-plug-in.md)<br />-   [How to: Create a Web Service Test](../test/how-to--create-a-web-service-test.md)<br />-   [How to: Create a Recorder Plug-In](../test/how-to--create-a-recorder-plug-in.md)|  
|**Add UI features to Web Performance Test Results Viewer:** You can add more UI features to the Web Performance Test Results Viewer using a Visual Studio add-in.|-   [How to: Create a Visual Studio Add-In for the Web Performance Test Results Viewer](../test/how-to--create-a-visual-studio-add-in-for-the-web-performance-test-results-viewer.md)|  
|**Create a custom HTTP body editor:** You can create a custom editor to edit binary or string http XML responses from a web service.|-   [How to: Create a Custom HTTP Body Editor for the Web Performance Test Editor](../test/how-to--create-a-custom-http-body-editor-for-the-web-performance-test-editor.md)|  
  
## Reference  
 \<xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestPlugin>  
  
 \<xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRequestPlugin>  
  
 \<xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin>  
  
 \<xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin>  
  
 \<xref:Microsoft.VisualStudio.TestTools.LoadTesting>  
  
## See Also  
 [Analyzing Load Test Results](../test/analyzing-load-test-results-using-the-load-test-analyzer.md)   
 [Generate and run a coded web performance test](../test/generate-and-run-a-coded-web-performance-test.md)   
 [How to: Create a Coded Web Performance Test](../test_notintoc/how-to--create-a-coded-web-performance-test.md)   
 [Web performance and load tests in Visual Studio](../test_notintoc/web-performance-and-load-tests-in-visual-studio.md)   
 [API Reference for Testing Tools for Visual Studio ALM](../test/api-reference-for-testing-tools-for-visual-studio-alm.md)