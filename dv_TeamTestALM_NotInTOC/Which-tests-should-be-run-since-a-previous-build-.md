---
title: "Which tests should be run since a previous build?"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1c641880-9cde-4f59-b1dd-29d44d41e7ce
caps.latest.revision: 24
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
# Which tests should be run since a previous build?
You can use Microsoft Test Manager to help you determine which tests might have to be run, based on coding changes that were made to the application you are testing. To be able to use this functionality, you have to use Team Foundation Build to build your application and use Visual Studio for version control for your source code.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, Visual Studio Test Professional  
  
> [!NOTE]
>  This functionality to determine which tests might have to be run, based on coding changes, is only supported for applications developed using managed code.  
  
 To find the recommended tests, you must first run your manual tests using Test Runner or run your automated tests. When you run these tests, you have to use test settings that collect the *test impact data*. This test impact data contains information about which methods are called when you run your tests. These links between methods in your application and test cases are stored to determine which test cases should be recommended to run again based on changes to the methods.  
  
 Test impact data is only collected when tests run and pass. This creates a baseline to gather valid data for which methods are used when the full test is run. When a test fails, only partial data of the methods that were used to run the test could be collected. This partial data would be inaccurate.  
  
 When a new build is created, any changes that were made to methods since a previous build and checked in using version control are compared with the test impact data. If you view the details of a specific build, you can see any impacted tests. For example, if a bug is fixed that updates a specific method, you can then compare the builds to find the recommended test cases as shown in the following illustration.  
  
 ![Recommended Tests](../dv_TeamTestALM/media/Aftershock_Camano.png "Aftershock_Camano")  
  
> [!NOTE]
>  Only test cases are displayed here. Automated tests that are not associated with test cases are not displayed in the **Recommended Tests** activity. For example, to view unit tests that might be impacted by a new build that are not associated with a test case, you can open the details for the specific build from Visual Studio.  
  
## To find which test cases are affected by code changes  
 Open your Test Plan in Microsoft Test Manager.  
  
1.  **Configure test settings to collect test impact data**  
  
     The default settings collect test impact data for the local machine on which you are running the tests, but not for other machines. For example if you are testing a web server and you want to find the tests that are affected by changes in the server code, then you must configure the test settings so that test impact data is collected from the server role.  
  
    1.  Open **Testing Center**, **Plan**, **Properties** and under **Manual Runs** or **Automated Runs**, choose or create **Test Settings**.  
  
    2.  In the **Test Settings** editor, on the **Roles** page, choose a set of roles that matches the collection of machines that you need for the tests.  
  
        -   *I don’t see a set of roles that matches the set of machines I require.*  
  
             You need to set up a standard or SCVMM environment that includes the machines you need.  See [Running Tests in Lab Environments](assetId:///f32d85ef-9a80-4cb8-9ad4-6601e20ba1e7).  
  
    3.  On the **Data and Diagnostics** page, select the role or the server. Check the **Test Impact** option.  
  
         To exclude specified processes or modules from data collection, choose **Configure**.  
  
         **If you are testing an ASP.NET application running under Internet Information Services:**  
  
        1.  In the web server role, check **Test Impact** and choose **Configure**. In the configuration dialog, on **Advanced** tab, check **Collect Data for ASP.NET applications**.  
  
        2.  In the **Local** or **Web Client** role, check **ASP.NET client proxy**.  
  
     For more information, see [Collect more diagnostic data](../dv_TeamTestALM/Collect-more-diagnostic-data-in-manual-tests.md).  
  
     ![Configure Test Impact Analysis](../dv_TeamTestALM/media/TestImpactCollector.png "TestImpactCollector")  
  
2.  **Select a team build to use for your testing.**  
  
     Specify the build that you are currently testing. This is then used as a basis to compare with other builds to determine the test cases that are recommended that you run again.  
  
    1.  Open **Testing Center**, **Plan**, **Properties**.  
  
    2.  At **Build in use**, choose **Modify**. Select the build that you are currently using.  
  
     For more information, see [How to: Select a Build for Your Test Plan](../Topic/How%20to:%20Select%20a%20Build%20for%20Your%20Test%20Plan.md)  
  
3.  **Run your tests**  
  
     The test impact data will be attached to your test results with a file name extension of testimpact.xml. Only test impact data for tests that pass is saved. You must start any processes for the application after you start the first test in your test run.  
  
     For more information, see [Run your tests](../dv_TeamTestALM/Running-manual-tests-using-the-web-portal.md) and [Running Automated Tests in Microsoft Test Manager](assetId:///0632f265-63fe-4859-a413-9bb934c66835).  
  
4.  **Find the recommended tests to run**  
  
    1.  Open **Testing Center**, **Track**, **Recommended Tests**.  
  
    2.  Select a build at **Previous build to compare**.  
  
5.  Select the test case and configuration pairs that you want to run again, and choose **Reset to active**.  
  
6.  You can choose **Related work items** to see work items associated with all the builds between and including the build in use and the previous build you select.  
  
## See Also  
 [Running Tests in Microsoft Test Manager](assetId:///7a154168-c409-4163-bbf2-29971a638458)   
 [determine changes between builds](../Topic/determine%20changes%20between%20builds.md)