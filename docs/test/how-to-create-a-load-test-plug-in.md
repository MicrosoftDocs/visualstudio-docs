---
title: Create a Load Test Plug-In
description: Learn how to create a load test plug-in to run code at different times while the load test runs, which can expand upon or modify functionality of the load test.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
f1_keywords: 
  - vs.test.load.loadtestplugin
helpviewer_keywords: 
  - code, load tests
  - plug-ins, load test
  - load tests, plug-ins
ms.assetid: 27806972-1b15-4388-833d-6d0632816f1f
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# How to: Create a load test plug-in

You can create a load test plug-in to run code at different times while the load test is running. You create a plug-in to expand upon or modify the built in functionality of the load test. For example, you can code a load test plug-in to set or modify the load test pattern while the load test is running. To do this, you must create a class that inherits the <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin> interface. This class must implement the <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin.Initialize*> method of this interface. For more information, see <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin>.

> [!TIP]
> You can also create plug-ins for web performance tests. For more information, see [How to: Create a web performance test plug-in](../test/how-to-create-a-web-performance-test-plug-in.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

<!-- markdownlint-disable MD003 MD020 -->
## To create a load test plug-in in C#
<!-- markdownlint-enable MD003 MD020 -->

1. Open a web performance and load test project that contains a web performance test.

2. Add a load test to the test project and configure it to run a web performance test.

     For more information, see [Quickstart: Create a load test project](../test/quickstart-create-a-load-test-project.md).

3. Add a new **Class Library** project to the solution. (In **Solution Explorer**, right-click on the solution and select **Add** and then choose **New Project**.)

4. In **Solution Explorer**, right-click the **References** folder in the new class library and select **Add Reference**.

   The **Add Reference** dialog box is displayed.

5. Choose the **.NET** tab, scroll down, and then select **Microsoft.VisualStudio.QualityTools.LoadTestFramework**.

6. Choose **OK**.

   The reference to **Microsoft.VisualStudio.QualityTools.LoadTestFramework** is added to the **Reference** folder in **Solution Explorer**.

7. In **Solution Explorer**, right-click the top node of the web performance and load test project that contains the load test to which you want to add the load test plug-in and select **Add Reference**.

   The **Add Reference dialog box is displayed**.

8. Choose the **Projects** tab and select the Class Library Project.

9. Choose **OK**.

10. In the **Code Editor**, add a `using` statement for the <xref:Microsoft.VisualStudio.TestTools.LoadTesting> namespace.

11. Implement the <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin> interface for the class that was created in the Class Library project. See the following Example section for a sample implementation.

12. After you have written the code, build the new project.

13. Right-click on the top node of the load test and then choose **Add Load Test Plug-in**.

     The **Add Load Test Plug-in** dialog box is displayed.

14. Under **Select a plug-in**, select your load test plug-in class.

15. In the **Properties for selected plug-in** pane, set the initial values for the plug-in to use at run time.

    > [!NOTE]
    > You can expose as many properties as you want from your plug-ins; just make them public, settable, and of a base type such as Integer, Boolean, or String. You can also change the web performance test plug-in properties later by using the **Properties** window.

16. Choose **OK**.

     The plug-in is added to the **Load Test Plug-ins** folder.

    > [!WARNING]
    > You might get an error similar to the following when you run a web performance test or load test that uses your plug-in:
    >
    > **Request failed: Exception in \<plug-in> event: Could not load file or assembly '\<"Plug-in name".dll file>, Version=\<n.n.n.n>, Culture=neutral, PublicKeyToken=null' or one of its dependencies. The system cannot find the file specified.**
    >
    > This is caused if you make code changes to any of your plug-ins and create a new DLL version **(Version=0.0.0.0)**, but the plug-in is still referencing the original plug-in version. To correct this problem, follow these steps:
    >
    > 1. In your web performance and load test project, you will see a warning in references. Remove and re-add the reference to your plug-in DLL.
    > 2. Remove the plug-in from your test or the appropriate location and then add it back.

## Example

The following code shows a load test plug-in that runs custom code after a LoadTestFinished event occurs. If this code is run on a test agent on a remote machine and the test agent does not have a localhost SMTP service, the load test will remain in the "In progress" state because a message box will be open.

> [!NOTE]
> The following code requires that you add a reference to System.Windows.Forms.

```csharp
using System;
using Microsoft.VisualStudio.TestTools.LoadTesting;
using System.Net.Mail;
using System.Windows.Forms;

namespace LoadTestPluginTest
{
    public class MyLoadTestPlugin : ILoadTestPlugin
    {
        LoadTest myLoadTest;

        public void Initialize(LoadTest loadTest)
        {
            myLoadTest = loadTest;
            myLoadTest.LoadTestFinished += new
                EventHandler(myLoadTest_LoadTestFinished);
        }

        void myLoadTest_LoadTestFinished(object sender, EventArgs e)
        {
            try
            {
                // place custom code here
                MailAddress MyAddress = new MailAddress("someone@example.com");
                MailMessage MyMail = new MailMessage(MyAddress, MyAddress);
                MyMail.Subject = "Load Test Finished -- Admin Email";
                MyMail.Body = myLoadTest..Name + " has finished.";

                SmtpClient MySmtpClient = new SmtpClient("localhost");
                MySmtpClient.Send(MyMail);
            }

            catch (SmtpException ex)
            {
                MessageBox.Show(ex.InnerException.Message +
                    ".\r\nMake sure you have a valid SMTP.", "LoadTestPlugin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
```

Eight events are associated with a load test that can be handled in the load test plug-in to run custom code with the load test. The following is a list of the events that provide access to different periods of the load test run:

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.LoadTestStarting>

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.LoadTestFinished>

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.LoadTestWarmupComplete>

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.TestStarting>

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.TestFinished>

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.ThresholdExceeded>

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.Heartbeat>

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.LoadTestAborted>

## See also

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin>
- [Create custom code and plug-ins for load tests](../test/create-custom-code-and-plug-ins-for-load-tests.md)
- [How to: Create a Web performance test plug-in](../test/how-to-create-a-web-performance-test-plug-in.md)
