---
title: "How to: Specify the Timing Details Storage Property for a Load Test Run Setting"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, properties"
  - "load tests, run settings"
ms.assetid: 867a9c21-0909-4963-bc02-d41e9393008c
caps.latest.revision: 25
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
# How to: Specify the Timing Details Storage Property for a Load Test Run Setting
After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals. See [Creating load tests](../test_notintoc/creating-load-tests.md).  
  
> [!NOTE]
>  For a complete list of the run settings properties and their descriptions, see [Load Test Run Settings Properties](../test/load-test-run-settings-properties.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 Using the Load Test Editor, you can edit a run settings **Timing Details Storage** property's value in the Properties window.  
  
 The **Timing Details Storage** property can be set to any of the following options:  
  
-   **All Individual Details:** Collects and stores individual timing data for each test, transaction, and page issued during the test.  
  
    > [!NOTE]
    >  The **All Individual Details** option must be selected to enable virtual user data information in your load test results. For more information, see [Analyzing Virtual User Activity in the Details View](../test/analyzing-load-test-virtual-user-activity-in-the-details-view-of-the-load-test-analyzer.md).  
  
-   **None:** Does not collect any individual timing details. However, the average values are still available.  
  
-   **Statistics Only:** Stores individual timing data, but only as percentile data. This saves space resources.  
  
 **Considerations for the Timing Details Storage Property**  
  
 If the **Timing Details Storage** property is enabled, then the time to execute each individual test, transaction, and page during the load test will be stored in the load test results repository. This allows for 90th and 95th percentile data to be shown in the Load Test Analyzer in the Tests, Transactions, and Pages tables.  
  
 If the **Timing Details Storage** property is enabled, by setting its value to either **StatisticsOnly** or **AllIndividualDetails**, all the individual tests, pages, and transactions are timed, and percentile data is calculated from the individual timing data. The difference is that with the **StatisticsOnly** option, after the percentile data has been calculated, the individual timing data is deleted from the repository. This reduces the amount of space that is required in the repository when timing details are used. However, you might want to process the timing detail data in other ways by using SQL tools, in which case the **AllIndividualDetails** option should be used so that the timing detail data is available for that processing. Additionally, if you set the property to **AllIndividualDetails**, then you can analyze the virtual user activity using the Virtual User Activity chart in the Load Test Analyzer after the load test completes running. For more information, see [Analyzing Virtual User Activity in the Details View](../test/analyzing-load-test-virtual-user-activity-in-the-details-view-of-the-load-test-analyzer.md).  
  
 The amount of space required in the load test results repository to store the timing details data can be very large, especially for longer running load tests. Also, the time to store this data in the load test results repository at the end of the load test is longer because this data is stored on the load test agents until the load test has finished executing, at which time the data is stored into the repository. The **Timing Details Storage** property is enabled by default. If this is an issue for your testing environment, you may wish to set the **Timing Details Storage** to **None**.  
  
 The timing details data is stored in the LoadTestItemResults.dat file during the run and is sent back to the controller after the load test is complete. For a load test running for a long duration, the size of the file is large. If there is not enough disk space on the agent machine, this will be an issue.  
  
> [!NOTE]
>  In versions of Visual Studio prior to Visual Studio 2010, including [!INCLUDE[vsprvsext](../test/includes/vsprvsext_md.md)] and [!INCLUDE[vs_orcas_long](../codequality/includes/vs_orcas_long_md.md)], the **All Individual Details** setting for the **Timing Details Storage** property was available. In Visual Studio 2010 and later, there are two important differences. First, the **All Individual Details** setting was not the default setting. The only way to access this information was by using SQL queries.  
  
 If you are upgrading a project from a previous version of Visual Studio load test, use the following procedure to enable full detail collection.  
  
### To configure the timing details storage property in a load test  
  
1.  Open a load test in the load test editor.  
  
2.  Expand the **Run Settings** node in the load test.  
  
3.  Choose on the run settings that you want to configure, for example **Run Settings1[Active]**.  
  
4.  Open the Properties Window. On the **View** menu, select **Properties Window**.  
  
5.  Under the **Results** category, choose the **Timing Details Storage** property and select **All Individual Details**.  
  
     After you have configured the **All Individual Details** setting for the **Timing Details Storage** property, you can run your load test and view the Virtual User Activity Chart. For more information, see [Running Load and Web Performance Tests](assetId:///a4fd686e-69ec-485d-a335-acf12348aa30) and [How to: Analyze What Virtual Users Are Doing During a Load Test](../test/8bda19b3-91c1-4daf-b6c7-09108bddadff.md).  
  
## See Also  
 [Analyzing Virtual User Activity in the Details View](../test/analyzing-load-test-virtual-user-activity-in-the-details-view-of-the-load-test-analyzer.md)   
 [Walkthrough: Using the Virtual User Activity Chart to Isolate Issues](../test/walkthrough--using-the-virtual-user-activity-chart-to-isolate-issues.md)