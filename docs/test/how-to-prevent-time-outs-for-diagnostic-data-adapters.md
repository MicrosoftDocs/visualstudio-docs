---
title: "Time-Outs for Diagnostic Data Adapters in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Diagnostic Data Adapter, increasing time-outs"
ms.assetid: 39fff4fc-9233-4f67-96ac-e81bbaf7ca82
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Prevent Time-Outs for Diagnostic Data Adapters

If you are using diagnostic data adapters in your test settings, a time-out can occur when you start your test run because of one of the following reasons:

-   The test controller service is not running on the test controller computer. You might have to restart the service. For more information about how to determine your test controller and manage test controllers, see [Managing Test Controllers and Test Agents with Visual Studio](../test/manage-test-controllers-and-test-agents.md).

-   If you collect data on a remote computer, the firewall might block Microsoft Test Manager. The computer that runs Microsoft Test Manager must accept incoming connections from the test controller. A time-out occurs when Microsoft Test Manager does not receive a message from the controller because it is blocked by the firewall. You must check your firewall settings on the computer that runs Microsoft Test Manager. For more information about firewall settings, see the following [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=184980).

-   The test controller cannot resolve the name of the computer that runs Microsoft Test Manager. This might occur if DNS provides the wrong address for this computer. You might have to contact the network administrator to resolve this issue.

 When you run a long test that must collect a lot of data, you might find that the collection of this data times out. You can use the following procedure to resolve this issue.

 You can increase the time-out by updating the configuration file for Microsoft Test Manager or the configuration file for the test agent that is timing out.

 For Microsoft Test Manager the configuration file is called **mtm.exe.config**. It is located in the following directory: *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE*.

 To update a test agent, you must update the following configuration files on the test agent computer. All these files are located on the test agent computer in the same directory: *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE*.

-   QTAgent.exe.config

-   QTAgent32.exe.config

-   QTDCAgent.exe.config

-   QTDCAgent32.exe.config

 If you run manual tests and collect data from an environment, when a bug is created or the test case is completed, any data that has been collected by diagnostic data adapters is transferred to the computer that is running the manual tests. If you have collected a lot of data or you have a slow network connection, it might take longer than the default value of 60 seconds. For example, if you have configured the IntelliTrace adapter to collect IntelliTrace events and call information for many processes, the transfer of this data might exceed the default time-out. To increase this value, you can use the following procedure to update **mtm.exe.config**.

 An error message is displayed if the Test Runner activity times out, or if a test agent times out. The error message for the test agent will contain the information about which test agent computer has timed out. Use the following procedure to update the configuration files, depending on the error message that you have received.

## To increase the time-outs for your diagnostic data adapters

1.  Open a Windows Explorer (or File Explorer) window.

     To do this, right-click **Start** and point to **Explore**.

    > [!NOTE]
    > You might require administrative privileges to update the file.

2.  Locate the directory on your computer *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE* that contains the file that you must update.

3.  Right-click the file and point to **Open With**. Select an editor.

     The file is displayed in the editor. There are many settings stored in this file. Most of these settings can be changed using Microsoft Test Manager. However, the time-out settings must be changed manually as described in the following steps.

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
    > The time-out value is in seconds.

8.  Save the changes that you have made to the file and rerun the tests that timed out previously.

## See also

- [Collect Diagnostic Information Using Test Settings](../test/collect-diagnostic-information-using-test-settings.md)