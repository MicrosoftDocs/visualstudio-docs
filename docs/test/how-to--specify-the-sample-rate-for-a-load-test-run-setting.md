---
title: "How to: Specify the Sample Rate for a Load Test Run Setting"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, run settings"
ms.assetid: 51cbe7d6-5dfd-4842-bca3-f7f8a665dc84
caps.latest.revision: 15
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
# How to: Specify the Sample Rate for a Load Test Run Setting
After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals. See [Step 4 - Specifying Run Settings in the New Load Test Wizard](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep4).  
  
 Using the **Load Test Editor**, you can edit a run settings **Sample Rate** property's value in the Properties window. For a complete list of the run settings properties and their descriptions, see [Load Test Run Settings Properties](../test/load-test-run-settings-properties.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 Choose an appropriate value for the **Sample Rate** property for the load test run setting based on the length of your load test. A smaller sample rate, such as the default value of five seconds, requires more space in the load test results database. For longer load tests, increasing the sample rate reduces the amount of data that you collect. For more information, see [How to: Specify the Sample Rate for a Load Test Run Setting](../test/how-to--specify-the-sample-rate-for-a-load-test-run-setting.md).  
  
 Here are some guidelines for sample rates:  
  
|Load Test Duration|Recommended Sample Rate|  
|------------------------|-----------------------------|  
|\< 1 Hour|5 seconds|  
|1 - 8 Hours|15 seconds|  
|8 - 24 Hours|30 seconds|  
|> 24 Hours|60 seconds|  
  
### To specify performance counter sampling rate in a run setting  
  
1.  Open a load test.  
  
     The **Load Test Editor** appears. The load test tree is displayed.  
  
2.  In the load test tree, in the **Run Settings** folder, choose the run setting that you want to specify the sample rate for.  
  
3.  On the **View** menu, select **Properties Window**.  
  
     The load run setting's categories and properties are displayed in the Properties window.  
  
4.  In the **Sample Rate** property, enter a time value that indicates the frequency at which the load test will collect performance counter data.  
  
5.  After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Sample Rate** value.  
  
## See Also  
 [Configuring Load Test Run Settings](../test/configuring-load-test-run-settings.md)   
 [Load Test Scenario Properties](../test/load-test-scenario-properties.md)