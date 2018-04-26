---
title: "Create a Load Test Plug-In in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
f1_keywords:
  - "vs.test.load.loadtestplugin"
helpviewer_keywords:
  - "code, load tests"
  - "plug-ins, load test"
  - "load tests, plug-ins"
ms.assetid: 27806972-1b15-4388-833d-6d0632816f1f
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Create a Load Test Plug-In

You can create a load test plug-in to run code at different times while the load test is running. You create a plug-in to expand upon or modify the built in functionality of the load test. For example, you can code a load test plug-in to set or modify the load test pattern while the load test is running. To do this, you must create a class that inherits the <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin> interface. This class must implement the <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin.Initialize*> method of this interface. For more information, see <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin>.

> [!NOTE]
> You can also create plug-ins for Web performance tests. For more information, see [How to: Create a Web Performance Test Plug-In](../test/how-to-create-a-web-performance-test-plug-in.md)

## To create a Load Test Plug-in by using Visual C#

1.  Open a Web performance and load test project that contains a Web performance test.

2.  Add a load test to the test project and configure it to run a Web performance test.

     For more information, see [Quickstart: Create a load test project](../test/quickstart-create-a-load-test-project.md).

3.  In Solution Explorer, right-click on the solution and select **Add** and then choose **New Project**.

     The **Add New Project** dialog box is displayed.

4.  Under **Installed Templates**, select **Visual C#**.

5.  In the list of templates, select **Class Library**.

6.  In the **Name** text box, type a name for your class.

7.  Choose **OK**.

8.  The new class library project is added to Solution Explorer and the new class appears in the Code Editor.

9. In Solution Explorer, right-click the **References** folder in the new class library and select **Add Reference**.

10. The **Add Reference** dialog box is displayed.

11. Choose the **.NET** tab, scroll down, and then select **Microsoft.VisualStudio.QualityTools.LoadTestFramework**.

12. Choose **OK**.

     The reference to **Microsoft.VisualStudio.QualityTools.LoadTestFramework** is added to the **Reference** folder in Solution Explorer.

13. In Solution Explorer, right-click the top node of the Web performance and load test project that contains the load test to which you want to add the load test plug-in and select **Add Reference**.

14. The **Add Reference dialog box is displayed**.

15. Choose the **Projects** tab and select the Class Library Project.

16. Choose **OK**.

17. In the Code Editor, add a `using` statement for the <xref:Microsoft.VisualStudio.TestTools.LoadTesting> namespace.

18. Implement the <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin> interface for the class that was created in the Class Library project. See the following Example section for a sample implementation.

19. After you have written the code, build the new project.

20. Right-click on the top node of the load test and then choose **Add Load Test Plug-in**.

     The **Add Load Test Plug-in** dialog box is displayed.

21. Under **Select a plug-in**, select your load test plug-in class.

22. In the **Properties for selected plug-in** pane, set the initial values for the plug-in to use at run time.

    > [!NOTE]
    > You can expose as many properties as you want from your plug-ins; just make them public, settable, and of a base type such as Integer, Boolean, or String. You can also change the Web performance test plug-in properties later by using the Properties window.

23. Choose **OK**.

     The plug-in is added to the **Load Test Plug-ins** folder.

    > [!WARNING]
    > You might get an error similar to the following when you run a Web performance test or load test that uses your plug-in:
    >
    > **Request failed: Exception in \<plug-in> event: Could not load file or assembly '\<"Plug-in name".dll file>, Version=\<n.n.n.n>, Culture=neutral, PublicKeyToken=null' or one of its dependencies. The system cannot find the file specified.**
    >
    > This is caused if you make code changes to any of your plug-ins and create a new DLL version **(Version=0.0.0.0)**, but the plug-in is still referencing the original plug-in version. To correct this problem, follow these steps:
    >
    > 1.  In your Web performance and load test project, you will see a warning in references. Remove and re-add the reference to your plug-in DLL.
    > 2.  Remove the plug-in from your test or the appropriate location and then add it back.

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

-   <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.LoadTestStarting>

-   <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.LoadTestFinished>

-   <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.LoadTestWarmupComplete>

-   <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.TestStarting>

-   <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.TestFinished>

-   <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.ThresholdExceeded>

-   <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.Heartbeat>

-   <xref:Microsoft.VisualStudio.TestTools.LoadTesting.LoadTest.LoadTestAborted>

## See also

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin>
- [Create custom code and plug-ins for load tests](../test/create-custom-code-and-plug-ins-for-load-tests.md)
- [How to: Create a Web Performance Test Plug-In](../test/how-to-create-a-web-performance-test-plug-in.md)