---
title: "Reporting on testing progress for test plans"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7c1f384b-5287-4713-bf6d-2ec4427e384b
caps.latest.revision: 23
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
# Reporting on testing progress for test plans
You can track your progress for your test suites immediately after you run your tests from Microsoft Test Manager. You can view your progress in the **Run Tests** activity for each test suite individually. You can view the tests that have passed and failed. You can mark tests as blocked or reset tests to active when you are ready to run them again, as shown in the following illustration.  
  
 ![View Test Results](../dv_TeamTestALM/media/QuickStart_TestRes.png "QuickStart_TestRes")  
  
 **Requirements**  
  
-   Visual Studio Enterprise, Visual Studio Test Professional  
  
> [!NOTE]
>  You can also view this progress for each test suite from the **Contents** activity when you plan your testing.  
  
 If you want to view the results for all the suites in the test plan rolled up for your overall status, you can see this in the **Properties** view of your test plan in **Test Plan Status**.  
  
 You can also track the progress of your testing efforts by creating your own reports or by using predefined test reports. The predefined reports are available only when your team uses Microsoft Test Manager to create test plans and run tests. The data for the reports is automatically collected as you run tests and save test results.  
  
 The predefined reports are created in Excel and a subset of them is also created in Report Designer. If you create your own tests, you can use either Excel or Report Designer.  
  
> [!NOTE]
>  When you use these predefined reports or create your own reports, there is a time delay between the time that you save the test results and the time that the data is available in the warehouse database or the analysis services database in Team Foundation Server.  
  
 You can access test reports in one of three different ways, depending on your preference:  
  
 **Test Dashboard** If your team uses a project portal, you can view the predefined reports on the Test Dashboard. You can access the project portal from the **Track** view in Microsoft Test Manager. For more information about the Test Dashboard, see [Test](../Topic/Test%20dashboard%20\(Agile%20and%20CMMI\).md).  
  
 **Team Explorer** You can access Report Designer reports from the Reports folder for your team project, and you can access Excel reports from the Documents folder.  
  
 **The web portal** If you have access to the web portal, just as with Team Explorer, you can access Report Designer reports from the Reports folder for your team project, and you can access Excel reports from the Documents folder.  
  
 The following illustration shows how test points are created in your test plan based on your test cases and test configurations for each test suite. A *test point* is a pairing of a test case with a test configuration. When you run a set of test points, a test run is created that has a test result for each test point. These test runs are stored in Team Foundation Server. You can then use predefined reports to show your progress based on these test points, or you can create custom reports.  
  
 ![Report on Testing Progress](../dv_TeamTestALM/media/Report_TestingProg.png "Report_TestingProg")  
  
## Tasks  
 Use the following topics to help you track your software quality:  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Tracking how many test cases are ready to run:** You can view the progress on how many test cases are ready to run and how many have to be finished for a given timeframe.|-   [Test Case Readiness](../Topic/Test%20Case%20Readiness%20Report.md) (Report Designer)<br />-   [Test Case Readiness](../Topic/Test%20Case%20Readiness%20Excel%20Report.md)|  
|**Tracking your test plan progress:** You can use the Test Plan Progress report to determine, for a given time frame, how many test cases were never run, blocked, failed, or passed.|-   [Test Plan Progress](../Topic/Test%20Plan%20Progress%20Report.md) (Report Designer)<br />-   [Test Plan Progress](../Topic/Test%20Plan%20Progress%20Excel%20Report.md)|  
|**Tracking progress on testing user stories:** The **User Story Test Status** report shows how many tests have never run, are blocked, failed, or passed for each user story.|-   [User Story Test Status](../Topic/User%20Story%20Test%20Status%20Excel%20Report%20\(Agile\).md)|  
|**Tracking regression:** The **Failure Analysis** report shows the number of distinct configurations for each Test Case that previously passed and are now failing, for the past four weeks.|-   [Failure Analysis](../Topic/Failure%20Analysis%20Excel%20Report.md)|  
|**Tracking how all runs for all plans are doing:** You can use the Test Activity report to see how many test runs for all test cases never ran, were blocked, failed, and passed.|-   [Test Activity](../Topic/Test%20Activity%20Excel%20Report.md)|  
|**Create custom test reports:** You can create your own custom reports in either Excel or Report Designer, whichever you are most familiar with.|-   [Dashboards and reports](../Topic/Charts,%20dashboards,%20and%20reports%20for%20Visual%20Studio%20ALM.md)<br />-   [Perspectives and measure groups provided in the Analysis Services cube](../Topic/Perspectives%20and%20measure%20groups%20provided%20in%20the%20Analysis%20Services%20cube%20for%20Visual%20Studio.md)<br />-   [Create a Report Server Project](../Topic/Create%20a%20Report%20Server%20Project%20for%20Visual%20Studio%20ALM.md)<br />-   [Create a report in Microsoft Excel for Visual Studio ALM &#91;redirected&#93;](assetId:///ae021d09-18d9-4fb0-bc06-fd6667a0b122)<br />-   [Test Result tables](../Topic/Test%20Result%20tables.md)|  
  
## External resources  
  
### Guidance  
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 4: Manual System Tests](http://go.microsoft.com/fwlink/?LinkID=255195)  
  
## See Also  
 [Dashboards and reports](../Topic/Charts,%20dashboards,%20and%20reports%20for%20Visual%20Studio%20ALM.md)   
 [Tracking software quality](../dv_TeamTestALM/Tracking-software-quality.md)   
 [Reviewing Test Results in Microsoft Test Manager](assetId:///9fb3e429-78df-4fe2-89ed-0ad1db0738f4)