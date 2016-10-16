---
title: "How to: Prevent Time-Outs for Diagnostic Data Adapters"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Diagnostic Data Adapter, increasing time-outs"
ms.assetid: 39fff4fc-9233-4f67-96ac-e81bbaf7ca82
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
# How to: Prevent Time-Outs for Diagnostic Data Adapters
If you are using diagnostic data adapters in your test settings, a time-out can occur when you start your test run because of one of the following reasons:  
  
-   The test controller service is not running on the test controller computer. You might have to restart the service. For more information about how to determine your test controller and manage test controllers, see [Managing Test Controllers and Test Agents with Visual Studio](../test/managing-test-controllers-and-test-agents-with-visual-studio.md).  
  
-   If you collect data on a remote computer, the firewall might block [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. The computer that runs [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] must accept incoming connections from the test controller. A time-out occurs when [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] does not receive a message from the controller because it is blocked by the firewall. You must check your firewall settings on the computer that runs [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. For more information about firewall settings, see the following [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=184980).  
  
-   The test controller cannot resolve the name of the computer that runs [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. This might occur if DNS provides the wrong address for this computer. You might have to contact the network administrator to resolve this issue.  
  
 When you run a long test that must collect a lot of data, you might find that the collection of this data times out. You can use the following procedure to resolve this issue.  
  
 You can increase the time-out by updating the configuration file for [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] or the configuration file for the test agent that is timing out.  
  
 For [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] the configuration file is called **mtm.exe.config**. It is located in the following directory: **%ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE**.  
  
 To update a test agent, you must update the following configuration files on the test agent computer. All these files are located on the test agent computer in the same directory: **%ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE**.  
  
-   QTAgent.exe.config  
  
-   QTAgent32.exe.config  
  
-   QTDCAgent.exe.config  
  
-   QTDCAgent32.exe.config  
  
 If you run manual tests and collect data from an environment, when a bug is created or the test case is completed, any data that has been collected by diagnostic data adapters is transferred to the computer that is running the manual tests. If you have collected a lot of data or you have a slow network connection, it might take longer than the default value of 60 seconds. For example, if you have configured the IntelliTrace adapter to collect IntelliTrace events and call information for many processes, the transfer of this data might exceed the default time-out. To increase this value, you can use the following procedure to update **mtm.exe.config**.  
  
 An error message is displayed if the Test Runner activity times out, or if a test agent times out. The error message for the test agent will contain the information about which test agent computer has timed out. Use the following procedure to update the configuration files, depending on the error message that you have received.  
  
### To increase the time-outs for your diagnostic data adapters  
  
1.  Open a Windows Explorer (or File Explorer) window.  
  
     To do this, right-click **Start** and point to **Explore**.  
  
    > [!NOTE]
    >  You might require administrative privileges to update the file.  
  
2.  Locate the directory on your computer **%ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE** that contains the file that you must update.  
  
3.  Right-click the file and point to **Open With**. Select an editor.  
  
     The file is displayed in the editor. There are many settings stored in this file. Most of these settings can be changed using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. However, the time-out settings must be changed manually as described in the following steps.  
  
4.  You must modify the test execution settings section to increase the time-out values. This section has the following format:  
  
    ```  
    <!-- Begin: Test execution settings -->  
  
        <!-- How long test runner will wait for an event raised to all local data collectors to complete.  Default is 300. -->  
        <add key="DataCollectorEventTimeoutInSeconds" value="300"/>  
  
        <!-- How long test runner will wait for test run operations, such as starting or stopping a test run, to complete.  Default is 60. -->  
        <add key="RunOperationTimeoutInSeconds" value="60"/>  
  
        <!-- End: Test execution settings -->  
    ```  
  
5.  To increase the time that diagnostic data adapters wait for events to be completed, increase the value for the key **DataCollectorEventTimeoutInSeconds**  
  
6.  If the time-out error message is for the Test Runner activity, you must increase the value for the key **RunOperationTimeoutInSeconds**.  
  
7.  To increase the time-out for transferring any data collected for a bug or when a test ends to the computer that is running the tests, you must add the following time-out to **mtm.exe.config** in the appSettings section of the file:  
  
    ```  
    <!-- How long test runner waits for data collected by diagnostic data adapters to be transferred to the computer. Default is 60 seconds. -->  
    <add key="GetCollectorDataTimeout" value="300"/>  
    ```  
  
    > [!NOTE]
    >  The time-out value is in seconds.  
  
8.  Save the changes that you have made to the file and rerun the tests that timed out previously.  
  
## See Also  
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)