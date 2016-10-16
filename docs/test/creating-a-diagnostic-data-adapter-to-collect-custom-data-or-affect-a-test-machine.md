---
title: "Creating a Diagnostic Data Adapter to Collect Custom Data or Affect a Test Machine"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Diagnostic Data Adapter [Visual Studio ALM]"
  - "Diagnostic Data Adapter"
ms.assetid: b0b53fae-7007-4ad9-a604-21685937622f
caps.latest.revision: 51
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
# Creating a Diagnostic Data Adapter to Collect Custom Data or Affect a Test Machine
You might want to create your own diagnostic data adapter to collect data when you run a test, or you might want to affect the test machine as part of your test. For example, you might want to collect log files that are created by your application under test and attach them to your test results, or you might want to run your tests when there is limited disk space left on your computer. Using APIs provided within Visual Studio Enterprise, you can write code to perform tasks at specific points in your test run. For example, you can perform tasks when a test run starts, before and after each individual test is run, and when the test run finishes.  
  
 You can provide default input to your custom diagnostic data adapter using a configuration settings file. For example, you can provide information about the location of the file you want to collect and attach to your test results, or how much disk space you want to be left on the system. This data can be configured for each test settings that you create. It can be displayed and edited using the default editor provided with [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] or you can create your own user control to use as an editor. Any changes that are made to the adapter configuration in your editor are stored with your test settings.  
  
 If you are running your tests from [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], you can associate the test settings with your test plan. If you are running your tests from Visual Studio, you must set these test settings to be active. For more information about test settings, see [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md).  
  
## Tasks  
 Use the following topics to help you create Diagnostic Data Adapters:  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Creating a Diagnostic Data Adapter:** You create a diagnostic data adapter by creating a class library, and then use the diagnostic data adapter APIs to collect information that you want or impact a test system that you are using to run your tests.|-   [How to: Create a Diagnostic Data Adapter](../test/how-to--create-a-diagnostic-data-adapter.md)|  
|**Installing a Custom Diagnostic Data Adapter:** You can install your diagnostic data adapter, or an adapter provided by someone else, by copying it into the correct directory.|-   [How to: Install a Custom Diagnostic Data Adapter](../test/how-to--install-a-custom-diagnostic-data-adapter.md)|  
|**Selecting a Custom Diagnostic Data Adapter to Use When Tests are Run:** You can select which diagnostic data adapter to use for your test settings, so that the adapter is used when you run your tests.|-   [Collect more diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md)<br />-   [Create Test Settings for Automated System Tests Using Microsoft Test Manager](../test_notintoc/create-test-settings-for-automated-system-tests-using-microsoft-test-manager.md)<br />-   [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md)|  
|**Configuring what a Diagnostic Data Adapter does:** You can configure the settings to control the actions of the diagnostic data adapter in that specific test settings.|-   [How to: Create a Custom Editor for Data for Your Diagnostic Data Adapter](../test/how-to--create-a-custom-editor-for-data-for-your-diagnostic-data-adapter.md)|  
  
## Related Scenarios  
 To see sample code for making a simple diagnostic data adapter that collects a file and a custom editor for the adapter, see [Sample Project for Creating a Diagnostic Data Adapter](../test/sample-project-for-creating-a-diagnostic-data-adapter.md).  
  
 To see sample code that enables you to call Process Monitor while running a test and return the collected log back to the test to be uploaded to the results, see the following [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=185606).  
  
## External resources  
  
### Guidance  
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 6: A Testing Toolbox](http://go.microsoft.com/fwlink/?LinkID=255203)  
  
## See Also  
 [Sample Project for Creating a Diagnostic Data Adapter](../test/sample-project-for-creating-a-diagnostic-data-adapter.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)