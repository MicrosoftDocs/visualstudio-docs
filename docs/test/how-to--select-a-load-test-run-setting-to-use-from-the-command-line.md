---
title: "How to: Select a Load Test Run Setting to Use from the Command-Line"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, command line"
  - "load tests, run settings, selecting"
ms.assetid: 175d1d58-f09a-4449-b132-a29a394a7c8e
caps.latest.revision: 14
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
# How to: Select a Load Test Run Setting to Use from the Command-Line
A load test can contain one or more *run settings*, which are a set of properties that influence the way a load test runs. Run settings are organized by categories in the Properties window. When a load test is run, it uses the run setting that is currently set as active. For more information, see [How to: Add Additional Run Settings to a Load Test](../test/how-to--add-additional-run-settings-to-a-load-test.md).  
  
 If your load test contains only one run setting, it is always the active node. If your load test contains multiple run settings nodes, you can select the one to use when you run a load test from the command-line. See [How to: Add Additional Run Settings to a Load Test](../test/how-to--add-additional-run-settings-to-a-load-test.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To change the run setting from the command-line  
  
1.  If you want to use different run settings from the command line to take advantage of the context parameter strategy, use the following set command:  
  
     **Set Test.UseRunSetting= CorporateStagingWebServer**  
  
2.  Run the load test using mstest:  
  
     **mstest /testcontainer:loadtest1.loadtest**  
  
## See Also  
 [Configuring Load Test Run Settings](../test/configuring-load-test-run-settings.md)   
 [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specifying-the-counter-sets-and-threshold-rules-for-computers-in-a-load-test.md)   
 [How to: Add Additional Run Settings to a Load Test](../test/how-to--add-additional-run-settings-to-a-load-test.md)   
 [How to: Select the Active Run Setting for a Load Test](../test/how-to--select-the-active-run-setting-for-a-load-test.md)