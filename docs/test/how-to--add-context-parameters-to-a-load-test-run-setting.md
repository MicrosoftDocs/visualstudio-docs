---
title: "How to: Add Context Parameters to a Load Test Run Setting"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, run settings, context parameters"
  - "load tests, context parameters"
ms.assetid: a8a0b97e-8040-4711-85ab-36548b130ed2
caps.latest.revision: 29
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
# How to: Add Context Parameters to a Load Test Run Setting
After you create your load test by using the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)][Creating load tests](../test_notintoc/creating-load-tests.md).  
  
> [!NOTE]
>  For a full list of the run settings properties and their descriptions, see [Load Test Run Settings Properties](../test/load-test-run-settings-properties.md).  
  
 You can create context parameters to use in a load test run setting by using the Load Test Editor. Context parameters let you parameterize a string.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 Suppose your load test contains a Web performance test that already uses a parameterized Web server URL by using a context parameter. You can add a context parameter to a load test run setting that uses the same name value as the one that is used in the Web performance test. This will map the Web performance test to a different server when you run the load test. For example, if your load test includes a Web performance test that uses a context parameter that is named WebServer1 for the name of the Web server in the URL. If you then specify a context parameter in your load test run setting that is also named WebServer1, the load test will use the context parameter that you assigned in the load test run setting. To clarify, if the Web performance test in the load test uses the same context parameter name as a context parameter in the load test, the context parameter in the load test will override the context parameter that is used in the Web performance test. For more information, see [How to: Use Context Parameters in a Web Performance Test](../test_notintoc/how-to--use-context-parameters-in-a-web-performance-test.md).  
  
> [!CAUTION]
>  Be careful not to unintentionally override the context parameter of a Web performance test when you use context parameters in a run setting. Avoid using the same context parameter names unless you do this intentionally.  
  
 If you assign the value of the Webserver1 context parameter to `http://CorporateStagingWebServer`, you can then use `WebServer1` throughout the load test and thereby easily change the value to a different Web server at any time.  
  
 Additionally, by assigning different values to a context parameter by using the same name in different load test run settings, you can run the load test by using different environments:  
  
-   Corporate Staging Web Server run setting: The context parameter that is named WebServer1=http://CorporateStagingWebServer  
  
-   Corporate Production Web Server run setting: The Context parameter that is named WebServer1=http://CorporateProductionWebServer  
  
 **Changing the Run Setting from the Command Line**  
  
 If you want to use different run settings from the command line to take advantage of the context parameter strategy, use the following commands:  
  
 **Set Test.UseRunSetting= CorporateStagingWebServer**  
  
 -and-  
  
 **mstest /testcontainer:loadtest1.loadtest**  
  
## Adding Context Parameters to a Run Setting  
  
#### To add a context parameter to a run setting  
  
1.  Open a load test.  
  
2.  Expand the **Run Settings** folder in the load test tree in the Load Test Editor.  
  
3.  Right-click the specific run setting to which you want to add a context parameter and then choose **Add Context Parameter**.  
  
     A new context parameter is added to the **Context Parameters** folder in the **Run Settings** folder in the load test tree.  
  
     -or-  
  
     If the run setting already contains a **Context Parameters** folder, you can right-click it and then choose **Add Context Parameter**.  
  
4.  In the Properties window, change the value for **Name** as appropriate (for example, WebServer1). In the Properties window, change **Value** to the parameter that you want to use (for example, http://CorporateStagingWebServer).  
  
5.  (Optional) Repeat steps 3 through 5 and use a different string for the **Value** property (for example, http://CorporateProductionWebServer).  
  
6.  Choose which run settings that you want to be active. Open the shortcut menu on the run settings and choose **Set As Active**.  
  
## See Also  
 [Configuring Load Test Run Settings](../test/configuring-load-test-run-settings.md)   
 [How to: Use Context Parameters in a Web Performance Test](../test_notintoc/how-to--use-context-parameters-in-a-web-performance-test.md)