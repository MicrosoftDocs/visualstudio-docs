---
title: "Create a Recorder Plug-In for web performance tests"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Web performance tests, recorder plug-in"
ms.assetid: 6fe13be1-aeb5-4927-9bff-35950e194da9
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create a recorder plug-in

The <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin> lets you modify a recorded web performance test. The modification occurs after you choose **Stop** in the **Web Performance Test Recorder** toolbar but prior to the test being saved and presented in the Web Performance Test Editor.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

A recorder plug-in enables you to perform your own custom correlation on dynamic parameters. With the built-in correlation functionality, web performance tests detect the dynamic parameters in the web recording upon completion, or when you use the **Promote Dynamic Parameters to Web Test Parameters** on the **Web Performance Test Editor** toolbar. However, the built in detection functionality does not always find all the dynamic parameters. For example, it does not find a session ID, which usually gets its value changed between 5 to 30 minutes. Therefore, you have to manually perform the correlation process.

The <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin> lets you write code for your own custom plug-in. This plug-in can perform correlation or modify the web performance test in many ways prior to it being saved and presented in the Web Performance Test Editor. Therefore, if you determine that a specific dynamic variable has to be correlated for a lot of your recordings, you can automate the process.

Some other ways that a recorder plug-in can be used is for adding extraction and validation rules, adding context parameters, or converting comments to transactions in a web performance test.

The following procedures describe how to create the rudimentary code for a recorder plug-in, deploy the plug-in and execute the plug-in. The sample code following the procedures demonstrates how to use Visual C# to create a custom dynamic parameter correlation recorder plug-in.

## Create a recorder plug-in

### To create a recorder plug-in

1. Open a solution that contains the web performance and load test project with the web performance test for which you want to create a recorder plug-in.

2. Add a new **Class Library** project to the solution.

3. In **Solution Explorer**, in the new class library project folder, right-click the **References** folder and select **Add Reference**.

    > [!TIP]
    > An example of a new class library project folder is **RecorderPlugins**.

     The **Add Reference** dialog box is displayed.

4. Select the **.NET** tab.

5. Scroll down and select **Microsoft.VisualStudio.QualityTools.WebTestFramework** and then choose **OK**.

     The **Microsoft.VisualStudio.QualityTools.WebTestFramework** is added in the **References** folder in **Solution Explorer**.

6. Write the code for your recorder plug-in. First, create a new public class that derives from <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin>.

7. Override the <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin.PostWebTestRecording*> method.

    ```csharp
    public class Class1 : WebTestRecorderPlugin
        {
            public override void PostWebTestRecording(object sender, PostWebTestRecordingEventArgs e)
            {
                base.PostWebTestRecording(sender, e);
            }
        }
    ```

     The event arguments will give you two objects to work with: the recorded result and the recorded web performance test. This will allow you to iterate through the result looking for certain values and then jump to the same request in the web performance test to make modifications. You can also just modify the web performance test if you wanted to add a context parameter or parameterize parts of the URL.

    > [!NOTE]
    > If you do modify the web performance test, you will also need to set the <xref:Microsoft.VisualStudio.TestTools.WebTesting.PostWebTestRecordingEventArgs.RecordedWebTestModified*> property to true: `e.RecordedWebTestModified = true;`

8. Add more code according to what you want the recorder plug-in to execute after the web recording occurs. For example, you can add code to handle custom correlation as shown in the sample below. You can also create a recorder plug-in for such things as converting comments to transactions or adding validation rules to the web performance test.

9. On the **Build** menu, choose **Build \<class library project name>**.

Next, deploy the recorder plug-in in order for it to register with Visual Studio.

### Deploy the recorder plug-in

After you compile the recorder plug-in, place the resulting DLL in one of two locations:

- *%ProgramFiles(x86)%\Microsoft Visual Studio\\[version]\\[edition]\Common7\IDE\PrivateAssemblies\WebTestPlugins*

- *%USERPROFILE%\Documents\Visual Studio [version]\WebTestPlugins*

> [!WARNING]
> After you copy the recorder plug-in to one of the two locations, you must restart Visual Studio for the recorder plug-in to be registered.

### Execute the recorder plug-in

1. Create a new web performance test.

     The **Enable WebTestRecordPlugins** dialog box displays.

2. Select the check box for the recorder plug-in and choose **OK**.

     After the web performance test completes recording, the new recorder plug-in will be executed.

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

This sample demonstrates how to create a customized web performance test recorder plug-in to perform custom dynamic parameter correlation.

> [!NOTE]
> A complete listing of the sample code is located at the bottom of this topic.

### Iterate through the result to find first page with ReportSession

This part of the code sample iterates through each recorded object and searches the response body for ReportSession.

```csharp
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

### Add an extraction rule

Now that a response has been found, you need to add an extraction rule. This part of the code sample creates the extraction rule using the <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRuleReference> class and then finds the correct request in the web performance test to add the extraction rule to. Each result object has a new property added called DeclarativeWebTestItemId which is what is being used in the code to get correct request from the web performance test.

```csharp
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

### Replace query string parameters

Now the code finds all the query string parameters that have ReportSession as name and change the value to {{SessionId}} as shown in this part of the code sample:

```csharp
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

```csharp
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

## See also

- <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRequestPlugin>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin.PostWebTestRecording*>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRuleReference>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin.PostWebTestRecording*>
- [Create custom code and plug-ins for load tests](../test/create-custom-code-and-plug-ins-for-load-tests.md)
- [Generate and run a coded web performance test](../test/generate-and-run-a-coded-web-performance-test.md)