---
title: "Generate and run a coded web performance test"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 169e48f9-52fd-4d0b-83d9-54913bde506b
caps.latest.revision: 71
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
# Generate and run a coded web performance test
Web performance tests are [recorded by browsing through your web app](assetId:///bd0a82fd-cec0-4861-bc09-e1b0b2d258ef). The tests are included in [load tests](../dv_TeamTestALM/Editing-Think-Times-to-Simulate-Website-Human-Interaction-Delays-in-Load-Tests-Scenarios.md) to measure the performance of your web application under the stress of multiple users. A web performance test can be converted to a code-based script that you can edit and customize like any other source code.  For example, you can add looping and branching constructs.  
  
## Generate a coded web performance test  
  
1.  If you have not created a web performance test, see [Record and run a web performance test](assetId:///bd0a82fd-cec0-4861-bc09-e1b0b2d258ef).  
  
2.  Generate the coded test.  
  
     ![Generate a coded web performance test](../dv_TeamTestALM/media/Web_Test_Coded_Generate.png "Web_Test_Coded_Generate")  
  
3.  Name the test.  
  
     ![Enter a name for the coded web performance test](../dv_TeamTestALM/media/Web_Test_Coded_Generate_NameTest.png "Web_Test_Coded_Generate_NameTest")  
  
     The new coded test opens in the code editor.  
  
     Depending on which web performance and load test project template you added to your solution, the code will be generated in either Visual Basic, or Visual C#.  
  
     ![New coded test opens in the code editor](../dv_TeamTestALM/media/Web_Test_Coded_Generate_OpenCodeEditor.png "Web_Test_Coded_Generate_OpenCodeEditor")  
  
     You can see in the code that the GetRequestEnumerator() method in C#, or the Run() method in Visual Basic, contains each validation rule and web request that was in the recoded test.  
  
4.  To demonstrate adding some simple code, scroll down to the end of the method and after the code for the last web request, and add the following code:  
  
    ```c#  
    if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)  
    {  
        WebTestRequest customRequest = new WebTestRequest("http://weather.msn.com/");  
        yield return customRequest;  
    }  
    else  
    {  
        WebTestRequest customRequest = new WebTestRequest("http://msdn.microsoft.com/");  
        yield return customRequest;  
    }  
    ```  
  
    ```vb#  
    If DateTime.Today.DayOfWeek = DayOfWeek.Wednesday Then  
        Dim customRequest As WebTestRequest = New WebTestRequest("http://weather.msn.com/")  
        MyBase.Send(customRequest)  
    Else  
        Dim customRequest As WebTestRequest = New WebTestRequest("http://msdn.microsoft.com/")  
        MyBase.Send(customRequest)  
    End If  
    ```  
  
5.  Build the solution to verify that your custom code compiles.  
  
6.  Run the test.  
  
     ![Run the coded web perfromance test](../dv_TeamTestALM/media/Web_Test_Coded_Generate_Run.png "Web_Test_Coded_Generate_Run")  
  
     And because the day this was run happened to be a Wednesday…  
  
     ![Coded web performance test results](../dv_TeamTestALM/media/Web_Test_Coded_Generate_Results.png "Web_Test_Coded_Generate_Results")  
  
## Q&A  
  
### Q: Can I run more than one test at a time?  
 **A:** Yes, use the context menu in Solution Explorer.  
  
### Q: Should I add a data source before or after I generate a coded test?  
 **A:** It is easier to a [data source](../dv_TeamTestALM/Add-a-data-source-to-a-web-performance-test.md), before you generate the coded test because the code will be automatically generated for you.  
  
 When you run a coded test with a data source, you might see the following error message:  
  
 **Could not run test <Test Name\> on agent <Computer Name\>: Object reference not set to an instance of an object.**  
  
 This can occur because you have a DataSourceAttribute defined for the test class, without a corresponding DataBindingAttribute. To resolve this error, add an appropriate DataBindingAttribute, delete it, or comment it out of the code.  
  
### Q: Should I add validation and extraction rules before or after I generate a coded test?  
 **A:** It is easier to validation rules and extraction rules before you generate the coded test; however, we recommend that you use [coded UI tests](../VS_IDE/Use-UI-Automation-To-Test-Your-Code.md) for validation purposes.