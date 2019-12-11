---
title: "Create a Web Performance Test Plug-In"
ms.date: 10/03/2016
ms.topic: conceptual
f1_keywords:
  - "vs.test.web.webtestplugin"
helpviewer_keywords:
  - "Web performance tests, creating plug-ins"
  - "plug-ins, creating in Web performance tests"
ms.assetid: a612f2d2-9806-477d-a126-12842f07da6e
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create a web performance test plug-in

Web performance tests plug-ins enable you to isolate and reuse code outside the main declarative statements in your web performance test. A customized web performance test plug-in offers you a way to call some code as the web performance test is run. The web performance test plug-in is run one time for every test iteration. In addition, if you override the PreRequest or PostRequest methods in the test plug-in, those request plug-ins will run before or after each request, respectively.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

You can create a customized web performance test plug-in by deriving your own class from the <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestPlugin> base class.

You can use customized web performance test plug-ins with the web performance tests you have recorded, which enables you to write a minimal amount of code to obtain a greater level of control over your web performance tests. However, you can also use them with coded web performance tests. For more information, see [Generate and run a coded web performance test](../test/generate-and-run-a-coded-web-performance-test.md).

> [!NOTE]
> You can also create load test plug-ins. See [How to: Create a load test plug-in](../test/how-to-create-a-load-test-plug-in.md).

## To create a custom web performance test plug-in

1. Open a web performance and load test project that contains a web performance test.

2. In **Solution Explorer**, right-click on the solution and select **Add** and then choose **New Project**.

3. Create a new **Class Library** project.

   The new class library project is added to **Solution Explorer** and the new class appears in the **Code Editor**.

4. In **Solution Explorer**, right-click the **References** folder in the new class library and select **Add Reference**.

   The **Add Reference** dialog box is displayed.

5. Choose the **.NET** tab, scroll down, and select **Microsoft.VisualStudio.QualityTools.WebTestFramework**

6. Choose **OK**.

     The reference to **Microsoft.VisualStudio.QualityTools.WebTestFramework** is added to the **Reference** folder in **Solution Explorer**.

7. In **Solution Explorer**, right-click on the top node of the web performance and load test project that contains the load test to which you want to add the web performance test plug-in and select **Add Reference**.

8. The **Add Reference dialog box is displayed**.

9. Choose the **Projects** tab and select the **Class Library Project**.

10. Choose **OK**.

11. In the **Code Editor**, write the code of your plug-in. First, create a new public class that derives from <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestPlugin>.

12. Implement code inside one or more of the event handlers. See the following Example section for a sample implementation.

    - <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostWebTestRecordingEventArgs>

    - <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostWebTestEventArgs>

    - <xref:Microsoft.VisualStudio.TestTools.WebTesting.PreRequestEventArgs>

    - <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostRequestEventArgs>

    - <xref:Microsoft.VisualStudio.TestTools.WebTesting.PrePageEventArgs>

    - <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostPageEventArgs>

    - <xref:Microsoft.VisualStudio.TestTools.WebTesting.PreTransactionEventArgs>

    - <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostTransactionEventArgs>

13. After you have written the code, build the new project.

14. Open a web performance test.

15. To add the web performance test plug-in, choose **Add Web Test Plug-in** on the toolbar.

     The **Add Web Test Plug-in** dialog box is displayed.

16. Under **Select a plug-in**, select your web performance test plug-in class.

17. In the **Properties for selected plug-in** pane, set the initial values for the plug-in to use at run time.

    > [!NOTE]
    > You can expose as many properties as you want from your plug-ins; just make them public, settable, and of a base type such as Integer, Boolean, or String. You can also change the web performance test plug-in properties later by using the Properties window.

18. Choose **OK**.

     The plug-in is added to the **Web Test Plug-ins** folder.

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

The following code creates a customized web performance test plug-in that adds an item to the <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestContext> that represents the test iteration.

After running the web performance test, by using this plug-in you can see the added item that is named **TestIteratnionNumber** in the **Context** tab in the **Web Performance Results Viewer**.

```csharp
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.WebTesting;

namespace SampleRules
{
    [Description("This plugin can be used to set the ParseDependentsRequests property for each request")]
    public class SampleWebTestPlugin : WebTestPlugin
    {
        private bool m_parseDependents = true;

        public override void PreWebTest(object sender, PreWebTestEventArgs e)
        {
            // TODO: Add code to execute before the test.
        }

        public override void PostWebTest(object sender, PostWebTestEventArgs e)
        {
            // TODO: Add code to execute after the test.
        }

        public override void PreRequest(object sender, PreRequestEventArgs e)
        {
            // Code to execute before each request.
            // Set the ParseDependentsRequests value on the request
            e.Request.ParseDependentRequests = m_parseDependents;
        }

        // Properties for the plugin.
        [DefaultValue(true)]
        [Description("All requests will have their ParseDependentsRequests property set to this value")]
        public bool ParseDependents
        {
            get
            {
                return m_parseDependents;
            }
            set
            {
                m_parseDependents = value;
            }
        }
    }
}
```

## See also

- <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRequestPlugin>
- [Create custom code and plug-ins for load tests](../test/create-custom-code-and-plug-ins-for-load-tests.md)
- [How to: Create a request-level plug-in](../test/how-to-create-a-request-level-plug-in.md)
- [Code a custom extraction rule for a web performance test](../test/code-a-custom-extraction-rule-for-a-web-performance-test.md)
- [Code a custom validation rule for a web performance test](../test/code-a-custom-validation-rule-for-a-web-performance-test.md)
- [How to: Create a load test plug-in](../test/how-to-create-a-load-test-plug-in.md)
- [Generate and run a coded web performance test](../test/generate-and-run-a-coded-web-performance-test.md)