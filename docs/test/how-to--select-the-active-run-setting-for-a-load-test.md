---
title: "How to: Select the Active Run Setting for a Load Test"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, run settings, active"
ms.assetid: ed6ff546-acfa-4dd8-b3a2-6e7455930ca4
caps.latest.revision: 24
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
# How to: Select the Active Run Setting for a Load Test
After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals. See [Step 4 - Specifying Run Settings in the New Load Test Wizard](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep4).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 A load test can contain one or more *run settings* which are a set of properties that influence the way a load test runs. Run settings are organized by categories in the Properties window. When a load test is run, it uses the run setting that is currently set as active.  
  
> [!NOTE]
>  For a complete list of the run settings properties and their descriptions, see [Load Test Run Settings Properties](../test/load-test-run-settings-properties.md).  
  
 If your load test contains only one run setting node under the **Run Settings** folder, that node is always the active node. If your load test contains multiple run settings nodes, you can select the one to use when you run a load test. See [How to: Add Additional Run Settings to a Load Test](../test/how-to--add-additional-run-settings-to-a-load-test.md).  
  
 In the Load Test Editor, the active run setting is identified by the "[Active]" suffix.  
  
## Selecting the Active Run Setting  
  
#### To select the active run setting in a load test  
  
1.  Open a load test.  
  
2.  Expand the **Run Settings** folder.  
  
3.  Right-click the run settings node that you want to be the active node, and then choose **Set As Active**.  
  
     In the **Load Test Edito**r, the affected run setting node is updated with the "[Active]" suffix.  
  
     The run setting selected becomes active, and remains active until you select a different run setting to be active.  
  
> [!NOTE]
>  You can override the active run setting by setting an environment variable named `Test.UseRunSetting=<run setting name>`. This is useful when you run a load test from the command line or from a batch file. This lets you choose different run settings without opening your load test.  
  
### Specifying the Run Setting to Use from the Command Line  
 You can override the default run settings in your load test by setting an environment variable from the command line:  
  
 **Set Test.UseRunSetting=PreProdEnvironment**  
  
 And the run the test:  
  
 **mstest /testcontainer:loadtest1.loadtest**  
  
## See Also  
 [Configuring Load Test Run Settings](../test/configuring-load-test-run-settings.md)   
 [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specifying-the-counter-sets-and-threshold-rules-for-computers-in-a-load-test.md)   
 [How to: Add Additional Run Settings to a Load Test](../test/how-to--add-additional-run-settings-to-a-load-test.md)