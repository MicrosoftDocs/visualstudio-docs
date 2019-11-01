---
title: "Analyzing Coded UI Tests Using Coded UI Test Logs"
ms.date: 11/04/2016
ms.topic: conceptual
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
author: jillre
---
# Analyzing coded UI tests using coded UI test logs

Coded UI test logs filter and record important information about your coded UI test runs. The logs are presented in a format that allows for debugging issues quickly.

[!INCLUDE [coded-ui-test-deprecation](includes/coded-ui-test-deprecation.md)]

## Step 1: Enable logging

Depending on your scenario, use one of the following methods to enable the log:

- If there's no *App.config* file present in your test project:

   1. Determine which *QTAgent\*.exe* process is launched when you run your test. One way to do this is to watch the **Details** tab in Windows **Task Manager**.

   2. Open the corresponding *.config* file from the *%ProgramFiles(x86)%\Microsoft Visual Studio\\\<version>\\\<edition>\Common7\IDE* folder. For example, if the process that runs is *QTAgent_40.exe*, open *QTAgent_40.exe.config*.

   2. Modify the value of **EqtTraceLevel** to the log level you want.

      ```xml
      <!-- You must use integral values for "value".
           Use 0 for off, 1 for error, 2 for warn, 3 for info, and 4 for verbose. -->
      <add name="EqtTraceLevel" value="4" />
      ```

   3. Save the file.

- If there's an *App.config* file present in your test project:

  - Open the *App.config* file in the project, and add the following code under the configuration node:

    ```xml
    <system.diagnostics>
      <switches>
        <add name="EqtTraceLevel" value="4" />
      </switches>
    </system.diagnostics>`
    ```

- Enable logging from the test code itself:

   ```csharp
   Microsoft.VisualStudio.TestTools.UITesting.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
   ```

## Step 2: Run your coded UI test and view the log

When you run a coded UI test with the modifications to the *QTAgent\*.exe.config* file in place, you see an output link in the **Test Explorer** results. Log files are produced not only when your test fails but also for successful tests when the trace level is set to **verbose**.

1. On the **Test** menu, choose **Windows** and then select **Test Explorer**.

2. On the **Build** menu, choose **Build Solution**.

3. In **Test Explorer**, select the coded UI test you want to run, open its shortcut menu, and then choose **Run Select Tests**.

     The automated tests run and indicate if they passed or failed.

    > [!TIP]
    > To view **Test Explorer**, choose **Test** > **Windows**, and then choose **Test Explorer**.

4. Choose the **Output** link in the **Test Explorer** results.

     ![Output link in the Test Explorer](../test/media/cuit_htmlactionlog1.png)

     This displays the output for the test, which includes a link to the action log.

     ![Results and output links from coded UI test](../test/media/cuit_htmlactionlog2.png)

5. Choose the *UITestActionLog.html* link.

     The log is displayed in your web browser.

     ![Coded UI test log file](../test/media/cuit_htmlactionlog3.png)

## See also

- [Use UI automation to test your code](../test/use-ui-automation-to-test-your-code.md)
- [How to: Run tests from Microsoft Visual Studio](https://msdn.microsoft.com/Library/1a1207a9-2a33-4a1e-a1e3-ddf0181b1046)
