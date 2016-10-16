---
title: "Assigning Roles to a Test Controller and Test Agent for Automated Testing in Visual Studio"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "testing, walkthroughs, test controller and test agents"
  - "test agent, walkthrough"
  - "walkthroughs [Visual Studio ALM] testing"
  - "test controller, walkthrough"
  - "walkthroughs, test controller and test agents"
ms.assetid: 57ed43ae-4e67-4139-8aec-3e9fceb0a745
caps.latest.revision: 33
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
# Assigning Roles to a Test Controller and Test Agent for Automated Testing in Visual Studio
This topic applies to:  
  
|[!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]|Visual Studio Enterprise|[!INCLUDE[vs_pro_current_short](../profiling/includes/vs_pro_current_short_md.md)]|[!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Express|  
|---------------------------------------------------------------------|------------------------------|--------------------------------------------------------------------------|--------------------------------------------------------------------|  
|![Topic applies](../test/media/doesapply.gif "DoesApply")|![Topic applies](../test/media/doesapply.gif "DoesApply")|![Topic applies](../test/media/doesapply.gif "DoesApply")|![Topic does not apply](../test/media/doesnotapply.gif "DoesNotApply")|  
  
 This walkthrough demonstrates how to create and configure a test setting that uses a test controller and test agent to distribute testing across several machines using Visual Studio. In addition, this walkthrough demonstrates how to add diagnostic and data adapters to the test setting.  
  
 In this walkthrough, you will complete the following tasks:  
  
-   Create a test setting.  
  
-   Assign roles to a test controller and test agents.  
  
-   Assign a diagnostic and data adapter to your test setting.  
  
## Prerequisites  
  
-   Create unit tests or coded UI tests to run with the test setting. For information about how to create unit tests or coded UI tests, see [Create your tests](../test/creating-manual-tests-using-the-web-portal.md).  
  
-   You must have a test controller and test agents installed. For information about how to install a test controller and test agents, see [Install and configure test agents](../test/install-and-configure-test-agents.md).  
  
### To create and configure a test setting  
  
1.  In Solution Explorer, right-click **Solution Items,** point to **Add**, and then choose **New Item**.  
  
     The **Add New Item** dialog box appears.  
  
2.  In the **Installed Templates** pane, choose **Test Settings**.  
  
3.  In the **Name** box, type **TestSettingDistributedTestWalkthrough**.  
  
4.  Choose **Add**.  
  
     The new test TestSettingDistributedTestWalkthrough.testsettings file appears in Solution Explorer, under the **Solution Items** folder.  
  
     The **Test Settings** dialog box is displayed. The **General** page is selected.  
  
     You can now edit and save test settings values.  
  
    > [!NOTE]
    >  Each test settings that you create is listed as a choice for the **Select Active Test Settings** and **Edit Test Settings** options on the **Test** menu.  
  
5.  Under **Name**, type the name for the test settings.  
  
6.  Under **Description**, type **Distributed test settings**.  
  
7.  Leave **Default naming scheme** selected.  
  
### To assign roles to a test controller and test agents  
  
1.  Choose **Roles**.  
  
     The **Roles** page is displayed.  
  
2.  To run your test remotely, use the **Test execution method** drop-down list and select **Remote execution**.  
  
3.  In the **Controller** drop-down list, type the computer name of [your test controller](../test/install-and-configure-test-agents.md).  
  
    > [!NOTE]
    >  If this is the first time that you are adding a controller, there are no controllers listed in the drop-down list. The list is populated by previous controllers that you have specified in other test settings.  
  
4.  Under **Roles**, choose **Add**.  
  
5.  In the highlighted row under the **Name** column, type **Distributed test**.  
  
### To assign a diagnostic and data adapter to your test setting  
  
1.  Choose **Data and Diagnostics**.  
  
     The **Data and Diagnostics** page is displayed.  
  
2.  Under **Role**, verify that the **Distributed test** role is selected.  
  
3.  Under **Data and Diagnostic for select role**, select the **IntelliTrace** and **System Information** adapters.  
  
     For information about these adapters and other adapters that you can use in a test setting, see [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md).  
  
4.  Choose **Hosts**.  
  
5.  (Optional) If your machine is running under a 64-bit version of Microsoft Windows, and you compiled your test using the **Any CPU** configuration, use the **Run test in 32 bit or 64 bit process** drop-down list and select Run tests in 64-bit process on 64-bit machine.  
  
    > [!TIP]
    >  For maximum flexibility, you should compile your test projects with the **Any CPU** configuration. Then you can run on both 32- and 64-bit agents. There is no advantage to compiling test projects with the **64-bit** configuration.  
  
6.  To save the new test settings, choose **Apply**.  
  
7.  Choose **Close**.  
  
8.  On the Test menu, select **Select Active Test Settings** and then choose **TestSettingDistributedTestWalkthrough.testsettings**.  
  
9. Run your test as usual.  
  
     When the test controller processes unit tests and coded UI tests, the test controller divides the tests into groups of 100 and sends them to a test agent machine. For example, if you have 250 unit tests and three test agents, the first 100 unit tests will be sent to agent1, the next 100 unit tests will be sent to agent2 and the remaining 50 unit tests will be sent to agent3.  
  
     For more information about how to create test settings to use in [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)], see [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md).  
  
## See Also  
 [Install and configure test agents](../test/install-and-configure-test-agents.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)   
 [Setting Up Test Controllers and Test Agents to Manage Tests with Visual Studio](../test/setting-up-test-controllers-and-test-agents-to-manage-tests-with-visual-studio.md)