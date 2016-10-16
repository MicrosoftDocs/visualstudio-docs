---
title: "Collect more diagnostic data in manual tests"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "test settings, manual tests"
  - "test settings, MTM"
ms.assetid: bb5a2cc0-84f5-4dfe-9560-ca3d313aefd2
caps.latest.revision: 71
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
# Collect more diagnostic data in manual tests
While you are testing your application, [Microsoft Test Manager](../test/testing-your-application-using-microsoft-test-manager.md) can collect data that will help diagnose any fault that you might find. If you create a bug report while you’re testing, the data is automatically attached to the bug work item.  
  
 ![Test settings machine roles and adapters](../test/media/testsettingsmachineroleconceptual.png "TestSettingsMachineRoleConceptual")  
  
 You can decide what kinds of data you want to collect.  
  
## What diagnostic data can I collect in a test?  
 The diagnostic data is collected in the test results. It will be added to a bug if you create one while performing the test.  
  
|Data you can collect|How|  
|--------------------------|---------|  
|-   Link to the test case.<br />-   The steps you marked as passed or failed.<br />-   Any comments or attachments that you added.|[Run tests in the web portal.](../test/running-manual-tests-using-the-web-portal.md)|  
|+<br /><br /> -   Operating system version and other system information.<br />-   Your keystrokes and gestures.<br />-   Screenshots, recorded automatically while you work.|[Run tests with Microsoft Test Manager](../test/run-manual-tests-with-microsoft-test-manager.md).<br /><br /> (Use default test settings.)<br /><br /> Microsoft Test Manager has to be installed on the machine where you run the tests, or on a machine connected to a device where the test runs.|  
|+<br /><br /> Data collected from your client or desktop application:<br /><br /> -   Event logs<br />-   IntelliTrace<br />-   Video recording of the desktop<br />-   Test impact analysis. This allows you to choose tests based on changes since a previous build.|Use [test settings](#testSettings) when you perform the tests with Microsoft Test Manager.<br /><br /> Test settings files configure diagnostic data adapters. You can choose a test settings file when you run tests, or you can set a default test settings file for your test plan.|  
|+<br /><br /> Data collected from your server software:<br /><br /> 1.  Event logs.<br />2.  IntelliTrace<br />3.  Test impact<br />4.  Virtual machine snapshots of the servers, if you are using an SCVMM lab environment|Install your server software on [a lab environment](../test/test-on-a-lab-environment.md) and perform the tests with Microsoft Test Manager.<br /><br /> Use [test settings](#testSettings) to define the data you want to collect.|  
  
##  <a name="testSettings"></a> How do I create test settings?  
 You need test settings only if you want to collect more data than the default. The default setting collects basic system information from each lab machine and your keystrokes and gestures from the local machine.  
  
1.  If the application you are testing is a website or has a server component, and you want to collect data from the servers:  
  
    1.  [Create a lab environment](../test/test-on-a-lab-environment.md). It can be a standard environment or an SCVMM environment.  
  
    2.  In the Properties of your test plan, set the test environment you want to use for manual tests.  
  
     ![In test plan properties, choose a lab environment.](../test/media/almt_ws91chooseenv.png "ALMT_ws91chooseEnv")  
  
2.  Choose an existing test settings file, or create a new one.  
  
     ![Select or create test settings.](../test/media/almt_ws92newsettings.png "ALMT_ws92newSettings")  
  
     This sets the default selection for performing tests in this test plan. You can override the selection when you perform individual test runs.  
  
3.  Give the test settings file a name.  
  
     ![Set the name of the new test settings.](../test/media/almt_ws93newsettingsname.png "ALMT_ws93newSettingsName")  
  
4.  Choose the lab environment you want to use for your tests. If you aren’t using a lab environment, choose Local.  
  
     ![On the Roles tab, choose the lab environment.](../test/media/almt_ws94newsettingsrole.png "ALMT_ws94newSettingsRole")  
  
     Each test settings file matches one set of machine roles.  
  
5.  For each machine role, choose the data you want to collect from that machine.  
  
     ![Choose diagnostics for each machine role.](../test/media/almt_ws95newsettingsdda.png "ALMT_ws95newSettingsDDA")  
  
     The Local role is the client machine on which you’ll perform the tests.  
  
##  <a name="MTMTestSettingsDataandDiagnostics"></a> What are the diagnostic data options?  
 On the Data and Diagnostics page you can add and configure diagnostic adapters to collect data for each machine role in your lab environment. In most cases the diagnostic data is included with the test results.  
  
 ![Test setting Data and Diagnostic page](../test/media/mtr_danddpage.png "MTR_danddPage")  
  
|Diagnostic data adapter|Configuration|  
|-----------------------------|-------------------|  
|**Action Log**: Allows you to record the actions you perform during your test, so that you can play them back rapidly on a subsequent occasion. The actions are also recorded as text descriptions in any bug report that you create.|[Record and play back manual tests](../test/record-and-play-back-manual-tests.md).<br /><br /> Not all gestures and applications are recorded.|  
|**ASP.NET Client Proxy for IntelliTrace and Test Impact**|Select this adapter in a web client role. It is required if you are testing an ASP.NET application, and you want to collect **Test Impact** or **Intellisense** data on the web server role.|  
|**Event log**<br /><br /> Collects events that your application wrote to the event logs.|Choose **Configure** to select the types of events you want.<br /><br /> Your application has to write events using \<xref:System.Diagnostics.EventLog.WriteEntry*>|  
|**IntelliTrace**: Generates an .itrace file that is linked to any bug that you create. From this IntelliTrace file, the local session can be simulated on another computer.|[Using IntelliTrace](../debugger/intellitrace.md).|  
|**System information**: Records information about the machine.|No additional configuration.|  
|**Test impact**: Enables the **Recommended Tests** feature in Testing Center, Track. This determines which tests are affected by the changes since a previous build, based on code coverage.|If you are testing an ASP.NET application:<br /><br /> 1.  On the role where the IIS server will run, enable **Test Impact** and then choose **Configure**, **Advanced**, **ASP.NET**.<br />2.  In the web client role, enable **ASP.NET Client Proxy for IntelliTrace and Test Impact**<br /><br /> Restart your server application after enabling this option.|  
|**Video Recorder** records the desktop in real time while you work.|To record audio, choose **Configure**.|