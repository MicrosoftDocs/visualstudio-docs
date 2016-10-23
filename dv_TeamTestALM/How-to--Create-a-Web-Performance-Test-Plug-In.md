---
title: "How to: Create a Web Performance Test Plug-In"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a612f2d2-9806-477d-a126-12842f07da6e
caps.latest.revision: 60
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Create a Web Performance Test Plug-In
Web performance tests plug-ins enable you to isolate and reuse code outside the main declarative statements in your Web performance test. A customized Web performance test plug-in offers you a way to call some code as the Web performance test is run. The Web performance test plug-in is run one time for every test iteration. In addition, if you override the PreRequest or PostRequest methods in the test plug-in, those request plug-ins will run before or after each request, respectively.  
  
 You can create a customized Web performance test plug-in by deriving your own class from the <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestPlugin?qualifyHint=False> base class.  
  
 You can use customized Web performance test plug-ins with the Web performance tests you have recorded, which enables you to write a minimal amount of code to obtain a greater level of control over your Web performance tests. However, you can also use them with coded Web performance tests. For more information, see [How to: Create a Coded Web Performance Test](../Topic/How%20to:%20Create%20a%20Coded%20Web%20Performance%20Test.md).  
  
> [!NOTE]
>  You can also create load test plug-ins. See [How to: Create a Load Test Plug-In](../dv_TeamTestALM/How-to--Create-a-Load-Test-Plug-In.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To create a custom Web performance test plug-in  
  
1.  Open a Web performance and load test project that contains a Web performance test.  
  
     For more information about how to create a Web performance and load test project, see [How to: Create and Configure Test Projects for Automated Tests](assetId:///8aabbd72-7d00-4823-93ac-24d02d67503b).  
  
2.  In Solution Explorer, right-click on the solution and select **Add** and then choose **New Project**.  
  
     The **Add New Project** dialog box is displayed.  
  
3.  Under **Installed Templates**, select **Visual C#**.  
  
4.  In the list of templates, select **Class Library**.  
  
5.  In the **Name** text box, type a name for your class.  
  
6.  Choose **OK**.  
  
7.  The new class library project is added to Solution Explorer and the new class appears in the Code Editor.  
  
8.  In Solution Explorer, right-click the **References** folder in the new class library and select **Add Reference**.  
  
9. The **Add Reference** dialog box is displayed.  
  
10. Choose the **.NET** tab, scroll down, and select **Microsoft.VisualStudio.QualityTools.WebTestFramework**  
  
11. Choose **OK**.  
  
     The reference to **Microsoft.VisualStudio.QualityTools.WebTestFramework** is added to the **Reference** folder in Solution Explorer.  
  
12. In Solution Explorer, right-click on the top node of the Web performance and load test project that contains the load test to which you want to add the Web performance test plug-in and select **Add Reference**.  
  
13. The **Add Reference dialog box is displayed**.  
  
14. Choose the **Projects** tab and select the Class Library Project.  
  
15. Choose **OK**.  
  
16. In the Code Editor, write the code of your plug-in. First, create a new public class that derives from <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestPlugin?qualifyHint=False>.  
  
17. Implement code inside one or more of the event handlers. See the following Example section for a sample implementation.  
  
    -   <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostWebTestRecordingEventArgs?qualifyHint=False>  
  
    -   <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostWebTestEventArgs?qualifyHint=False>  
  
    -   <xref:Microsoft.VisualStudio.TestTools.WebTesting.PreRequestEventArgs?qualifyHint=False>  
  
    -   <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostRequestEventArgs?qualifyHint=False>  
  
    -   <xref:Microsoft.VisualStudio.TestTools.WebTesting.PrePageEventArgs?qualifyHint=False>  
  
    -   <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostPageEventArgs?qualifyHint=False>  
  
    -   <xref:Microsoft.VisualStudio.TestTools.WebTesting.PreTransactionEventArgs?qualifyHint=False>  
  
    -   <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostTransactionEventArgs?qualifyHint=False>  
  
18. After you have written the code, build the new project.  
  
19. Open a Web performance test.  
  
20. To add the Web performance test plug-in, choose **Add Web Test Plug-in** on the toolbar.  
  
     The **Add Web Test Plug-in** dialog box is displayed.  
  
21. Under **Select a plug-in**, select your Web performance test plug-in class.  
  
22. In the **Properties for selected plug-in** pane, set the initial values for the plug-in to use at run time.  
  
    > [!NOTE]
    >  You can expose as many properties as you want from your plug-ins; just make them public, settable, and of a base type such as Integer, Boolean, or String. You can also change the Web performance test plug-in properties later by using the Properties window.  
  
23. Choose **OK**.  
  
     The plug-in is added to the **Web Test Plug-ins** folder.  
  
    > [!WARNING]
    >  You might get an error similar to the following when you run a Web performance test or load test that uses your plug-in:  
    >   
    >  **Request failed: Exception in <plug-in> event: Could not load file or assembly '<"Plug-in name".dll file>, Version=<n.n.n.n>, Culture=neutral, PublicKeyToken=null' or one of its dependencies. The system cannot find the file specified.**  
    >   
    >  This is caused if you make code changes to any of your plug-ins and create a new DLL version **(Version=0.0.0.0)**, but the plug-in is still referencing the original plug-in version. To correct this problem, follow these steps:  
    >   
    >  1.  In your Web performance and load test project, you will see a warning in references. Remove and re-add the reference to your plug-in DLL.  
    > 2.  Remove the plug-in from your test or the appropriate location and then add it back.  
  
## Example  
 The following code creates a customized Web performance test plug-in that adds an item to the <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestContext?qualifyHint=False> that represents the test iteration.  
  
 After running the Web performance test, by using this plug-in you can see the added item that is named **TestIteratnionNumber** in the **Context** tab in the Web Performance Results Viewer.  
  
```  
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
  
## See Also  
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRequestPlugin?qualifyHint=False>   
 [Create custom code and plug-ins for load tests](../dv_TeamTestALM/Create-custom-code-and-plug-ins-for-load-tests.md)   
 [How to: Create a Request-Level Plug-In](../dv_TeamTestALM/How-to--Create-a-Request-Level-Plug-In.md)   
 [Coding a custom extraction rule for a web performance test](../dv_TeamTestALM/Coding-a-custom-extraction-rule-for-a-web-performance-test.md)   
 [Coding a custom validation rule for a web performance test](../dv_TeamTestALM/Coding-a-custom-validation-rule-for-a-web-performance-test.md)   
 [How to: Create a Load Test Plug-In](../dv_TeamTestALM/How-to--Create-a-Load-Test-Plug-In.md)   
 [How to: Create a Coded Web Performance Test](../Topic/How%20to:%20Create%20a%20Coded%20Web%20Performance%20Test.md)   
 [How to: Edit an Existing Web Performance Test](assetId:///3b39a054-4bbd-430a-a14d-f38990fbadff)