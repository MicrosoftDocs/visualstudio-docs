---
title: "How to: Create a Recorder Plug-In"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6fe13be1-aeb5-4927-9bff-35950e194da9
caps.latest.revision: 38
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
# How to: Create a Recorder Plug-In
The <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin?qualifyHint=False> lets you modify a recorded Web performance test. The modification occurs after you choose **Stop** in the Web performance test recorder toolbar but prior to the test being saved and presented in the Web Performance Test Editor.  
  
 The primary issue a recorder plug-in helps resolve is performing your own custom correlation on dynamic parameters. With the built-in correlation functionality, Web performance tests detect the dynamic parameters in the Web recording upon completion, or when you use the **Promote Dynamic Parameters to Web Test Parameters** on the Web Performance Test Editor toolbar. For more information, see [How to: Resolve Web Performance Test Playback Issues Caused by Dynamic Parameters](../Topic/How%20to:%20Resolve%20Web%20Performance%20Test%20Playback%20Issues%20Caused%20by%20Dynamic%20Parameters.md). However, the built in detection functionality does not always find all the dynamic parameters. For example, it does not find a session ID, which usually gets its value changed between 5 to 30 minutes. Therefore, you have to manually perform the correlation process. For more information, see [How to: Promote Dynamic Parameters to Web Performance Test Parameters](../Topic/How%20to:%20Promote%20Dynamic%20Parameters%20to%20Web%20Performance%20Test%20Parameters.md).  
  
 The <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin?qualifyHint=False> lets you write code for your own custom plug-in. This plug-in can perform correlation or modify the Web performance test in many ways prior to it being saved and presented in the Web Performance Test Editor. Therefore, if you determine that a specific dynamic variable has to be correlated for a lot of your recordings, you can automate the process.  
  
 Some other ways that a recorder plug-in can be used is for adding extraction and validation rules, adding context parameters, or converting comments to transactions in a Web performance test.  
  
 The following procedures describe how to create the rudimentary code for a recorder plug-in, deploy the plug-in and execute the plug-in. The sample code following the procedures demonstrates how to use Visual C# to create a custom dynamic parameter correlation recorder plug-in.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Creating a Recorder Plug-in  
  
#### To create a recorder plug-in  
  
1.  Open a solution that contains the Web performance and load test project with the Web performance test for which you want to create a recorder plug-in.  
  
2.  In Solution Explorer, right-click the solution, select **Add**, and then choose **New Project**.  
  
     The **Add New Project** dialog box is displayed.  
  
3.  Under **Installed Templates**, select **Visual C#**.  
  
4.  In the list of templates, select **Class Library**.  
  
5.  In the **Name** text box, type a name for the recorder plug-in.  
  
     The class library is added to the Solution Explorer and the new class is opened in the Code Editor.  
  
6.  In Solution Explorer, in the new class library project folder, right-click the **References** folder and select **Add Reference**.  
  
    > [!TIP]
    >  An example of a new class library project folder is **RecorderPlugins**.  
  
     The **Add Reference** dialog box is displayed.  
  
7.  Select the **.NET** tab.  
  
8.  Scroll down and select **Microsoft.VisualStudio.QualityTools.WebTestFramework** and then choose **OK**.  
  
     The **Microsoft.VisualStudio.QualityTools.WebTestFramework** is added in the **References** folder in Solution Explorer.  
  
9. Write the code for your recorder plug-in. First, create a new public class that derives from <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin?qualifyHint=False>.  
  
10. Override the <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin.PostWebTestRecording?qualifyHint=False> method.  
  
    ```  
    public class Class1 : WebTestRecorderPlugin  
        {  
            public override void PostWebTestRecording(object sender, PostWebTestRecordingEventArgs e)  
            {  
                base.PostWebTestRecording(sender, e);  
            }  
        }  
    ```  
  
     The event arguments will give you two objects to work with: the recorded result and the recorded Web performance test. This will allow you to iterate through the result looking for certain values and then jump to the same request in the Web performance test to make modifications. You can also just modify the Web performance test if you wanted to add a context parameter or parameterize parts of the URL.  
  
    > [!NOTE]
    >  If you do modify the Web performance test, you will also need to set the <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostWebTestRecordingEventArgs.RecordedWebTestModified?qualifyHint=False> property to true: `e.RecordedWebTestModified = true;`  
  
11. Add more code according to what you want the recorder plug-in to execute after the Web recording occurs. For example, you can add code to handle custom correlation as shown in the sample below. You can also create a recorder plug-in for such things as converting comments to transactions or adding validation rules to the Web performance test.  
  
12. On the **Build** menu, choose Build <class library project name\>.  
  
13. Next, you must deploy the recorder plug-in in order for it to register with Visual Studio.  
  
### Deploy the Recorder Plug-in  
 After you compile the recorder plug-in, you will need to place the resulting DLL in one of two locations:  
  
-   %ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE\PrivateAssemblies\WebTestPlugins  
  
-   %USERPROFILE%\My Documents\Visual Studio <*version*>\WebTestPlugins  
  
> [!CAUTION]
>  After you copy the recorder plug-in to one of the two locations, you must restart Visual Studio for the recorder plug-in to be registered.  
  
### Execute the Recorder Plug-in  
 When you create a new Web performance test, you will see the **Enable WebTestRecordPlugins** dialog box. The **Enable WebTestRecordPlugins** dialog box displays all of the available plug-ins that can be executed.  
  
##### To execute the recorder plug-in  
  
1.  Create a new Web performance test. For more information, see [Record and run a web performance test](assetId:///bd0a82fd-cec0-4861-bc09-e1b0b2d258ef).  
  
     The **Enable WebTestRecordPlugins** dialog box displays.  
  
2.  Select the check box for the recorder plug-in and choose OK.  
  
     After the Web performance test completes recording, the new recorder plug-in will be executed.  
  
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
 This sample demonstrates how to create a customized Web performance test recorder plug-in to perform custom dynamic parameter correlation.  
  
> [!NOTE]
>  A complete listing of the sample code is located at the bottom of this topic.  
  
 **Reviewing the Sample Code**  
  
## Iterate through the result to find first page with ReportSession  
 This part of the code sample iterates through each recorded object and searches the response body for ReportSession.  
  
```  
foreach (WebTestResultUnit unit in e.RecordedWebTestResult.Children)  
 {  
     WebTestResultPage page = unit as WebTestResultPage;   
     if (page != null)  
     {  
         if (!foundId)  
         {  
             int indexOfReportSession = page.RequestResult.Response.BodyString.IndexOf("ReportSession");  
             if (indexOfReportSession > -1)  
             {  
```  
  
## Add an extraction rule  
 Now that a response has been found, you need to add an extraction rule. This part of the code sample creates the extraction rule using the <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRuleReference?qualifyHint=False> class and then finds the correct request in the Web performance test to add the extraction rule to. Each result object has a new property added called DeclarativeWebTestItemId which is what is being used in the code to get correct request from the Web performance test.  
  
```  
  
ExtractionRuleReference ruleReference = new ExtractionRuleReference();  
     ruleReference.Type = typeof(ExtractText);  
     ruleReference.ContextParameterName = "SessionId";  
     ruleReference.Properties.Add(new PluginOrRuleProperty("EndsWith", "&ControlID="));  
     ruleReference.Properties.Add(new PluginOrRuleProperty("HtmlDecode", "True"));  
     ruleReference.Properties.Add(new PluginOrRuleProperty("IgnoreCase", "True"));  
     ruleReference.Properties.Add(new PluginOrRuleProperty("Index", "0"));  
     ruleReference.Properties.Add(new PluginOrRuleProperty("Required", "True"));  
     ruleReference.Properties.Add(new PluginOrRuleProperty("StartsWith", "ReportSession="));  
     ruleReference.Properties.Add(new PluginOrRuleProperty("UseRegularExpression", "False"));  
  
     WebTestRequest requestInWebTest = e.RecordedWebTest.GetItem(page.DeclarativeWebTestItemId) as WebTestRequest;  
     if (requestInWebTest != null)  
     {  
         requestInWebTest.ExtractionRuleReferences.Add(ruleReference);  
         e.RecordedWebTestModified = true;  
     }  
```  
  
## Replace query string parameters  
 Now the code finds all the query string parameters that have ReportSession as name and change the value to {{SessionId}} as shown in this part of the code sample:  
  
```  
WebTestRequest requestInWebTest = e.RecordedWebTest.GetItem(page.DeclarativeWebTestItemId) as WebTestRequest;  
if (requestInWebTest != null)  
{  
    foreach (QueryStringParameter param in requestInWebTest.QueryStringParameters)  
    {  
         if (param.Name.Equals("ReportSession"))  
         {  
             param.Value = "{{SessionId}}";  
         }  
     }  
 }  
```  
  
```  
using System.ComponentModel;  
using Microsoft.VisualStudio.TestTools.WebTesting;  
using Microsoft.VisualStudio.TestTools.WebTesting.Rules;  
  
namespace RecorderPlugin  
{  
    [DisplayName("Correlate ReportSession")]  
    [Description("Adds extraction rule for Report Session and binds this to querystring parameters that use ReportSession")]  
    public class CorrelateSessionId : WebTestRecorderPlugin  
    {  
        public override void PostWebTestRecording(object sender, PostWebTestRecordingEventArgs e)  
        {  
            //first find the session id  
            bool foundId = false;  
            foreach (WebTestResultUnit unit in e.RecordedWebTestResult.Children)  
            {  
                WebTestResultPage page = unit as WebTestResultPage;  
                if (page != null)  
                {  
                    if (!foundId)  
                    {  
                        int indexOfReportSession = page.RequestResult.Response.BodyString.IndexOf("ReportSession");  
                        if (indexOfReportSession > -1)  
                        {  
                            //add an extraction rule to this request  
                            // Get the corresponding request in the Declarative Web performance test  
                            ExtractionRuleReference ruleReference = new ExtractionRuleReference();  
  
                            ruleReference.Type = typeof(ExtractText);  
                            ruleReference.ContextParameterName = "SessionId";  
                            ruleReference.Properties.Add(new PluginOrRuleProperty("EndsWith", "&ControlID="));  
                            ruleReference.Properties.Add(new PluginOrRuleProperty("HtmlDecode", "True"));  
                            ruleReference.Properties.Add(new PluginOrRuleProperty("IgnoreCase", "True"));  
                            ruleReference.Properties.Add(new PluginOrRuleProperty("Index", "0"));  
                            ruleReference.Properties.Add(new PluginOrRuleProperty("Required", "True"));  
                            ruleReference.Properties.Add(new PluginOrRuleProperty("StartsWith", "ReportSession="));  
                            ruleReference.Properties.Add(new PluginOrRuleProperty("UseRegularExpression", "False"));  
  
                            WebTestRequest requestInWebTest = e.RecordedWebTest.GetItem(page.DeclarativeWebTestItemId) as WebTestRequest;  
                            if (requestInWebTest != null)  
                            {  
                                requestInWebTest.ExtractionRuleReferences.Add(ruleReference);  
                                e.RecordedWebTestModified = true;  
                            }  
                            foundId = true;  
  
                        }  
                    }  
                    else  
                    {  
                        //now update query string parameters  
                        WebTestRequest requestInWebTest = e.RecordedWebTest.GetItem(page.DeclarativeWebTestItemId) as WebTestRequest;  
                        if (requestInWebTest != null)  
                        {  
                            foreach (QueryStringParameter param in requestInWebTest.QueryStringParameters)  
                            {  
                                if (param.Name.Equals("ReportSession"))  
                                {  
                                    param.Value = "{{SessionId}}";  
                                }  
                            }  
                        }  
                    }  
                }  
            }  
        }  
    }  
}  
```  
  
## See Also  
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRequestPlugin?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin.PostWebTestRecording?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRuleReference?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin.PostWebTestRecording?qualifyHint=False>   
 [Create custom code and plug-ins for load tests](../dv_TeamTestALM/Create-custom-code-and-plug-ins-for-load-tests.md)   
 [How to: Create a Coded Web Performance Test](../Topic/How%20to:%20Create%20a%20Coded%20Web%20Performance%20Test.md)   
 [How to: Edit an Existing Web Performance Test](assetId:///3b39a054-4bbd-430a-a14d-f38990fbadff)