---
title: "Creating an Automated Test That Runs an Executable Using Generic Tests"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.generic.window"
helpviewer_keywords: 
  - "generic tests, for automated tests"
  - "automated tests, creating"
  - "automated tests, running as executable using generic tests"
ms.assetid: b8dadaf4-4473-49c5-a0d9-46eca9e65d52
caps.latest.revision: 33
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Creating an Automated Test That Runs an Executable Using Generic Tests
You use generic tests to call external programs and tests. After you have done this, the generic test is treated by the test engine as any other test type. For example, you can run generic tests from Test Explorer and you can obtain and publish results from generic tests just as you do from other tests.  
  
 Use a generic test to wrap an existing test, program, or third-party tool that behaves as follows:  
  
-   It can be run from a command line.  
  
-   It returns a value of Pass or Fail.  
  
-   Optionally, it also returns detailed results for 'inner' tests, which are tests that it contains.  
  
 Visual Studio treats generic tests just like other tests. You can manage and run them using the same views, and you can obtain and publish their results.  
  
 Generic tests are a simple form of extensibility for Visual Studio. They let you run other tests, such as previous tests and custom tests, in addition to the predefined test types, which are Web, load, unit, manual, and ordered.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
 **In this topic:**  
  
-   [Tasks](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md#CreatingGenericTests_Tasks)  
  
-   [How to Create a Generic Test](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md#CreatingGenericTests_HowTo)  
  
-   [Generic Test Command-Line Arguments](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md#CreatingGenericTests_CommandLineArgs)  
  
-   [Deploying Files for Generic Tests](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md#CreatingGenericTests_DeployingFiles)  
  
##  <a name="CreatingGenericTests_Tasks"></a> Tasks  
 Use the following topics to help you in creating generic tests:  
  
|Key Tasks|-   Associated Topics|  
|---------------|--------------------------|  
|**Creating a generic test:** You can create a generic test by using the generic test template provided in Visual Studio and by specifying the program that you want to call. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)][How to Create a Generic Test](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md#CreatingGenericTests_HowTo) in this topic.|-   [Walkthrough: Creating and Running a Generic Test](../test/walkthrough--creating-and-running-a-generic-test.md)|  
|**Using environment variables in generic tests:** You can use environment variables to represent paths to folders that contain files including your target executable and items to deploy.|-   [Using Environment Variables in Generic Tests](../test/using-environment-variables-in-generic-tests.md)|  
|**Run generic tests:** You can run the generic tests that you have created from Unit Test Explorer, or by using test categories from the command line.|-   [Walkthrough: Creating and Running a Generic Test](../test/walkthrough--creating-and-running-a-generic-test.md)<br />-   [How to: Run Tests from Microsoft Visual Studio](../test/how-to--run-tests-from-microsoft-visual-studio.md)<br />-   [Running automated tests from the command line](../test/running-automated-tests-from-the-command-line.md)<br />-   [Defining Test Categories to Group Your Tests](../test/defining-test-categories-to-group-your-tests.md)|  
|**Determining code coverage:** To know how much you are improving the quality of your code, you must determine how much of the code your generic tests are covering when you run them.|-   [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md)<br />-   [Code Coverage configuration using Test Settings is deprecated](../test_notintoc/code-coverage-configuration-using-test-settings-is-deprecated.md)|  
|**Create and use a summary results file:** Through the use of a summary results file, a generic test can generate specific, detailed, test results.|-   [Using a Summary Results File with a Generic Test](../test/using-a-summary-results-file-with-a-generic-test.md)|  
  
##  <a name="CreatingGenericTests_HowTo"></a> How to Create a Generic Test  
  
> [!NOTE]
>  The following procedure presumes that you have an existing test, program, or third-party tool in the form of executable file to wrap as a generic test. You must be able to run this executable file from the command line, and it must return a value of Pass or Fail.  
  
#### To create a generic test  
  
1.  In Solution Explorer, open the shortcut menu for either a unit test project or a coded UI test project, point to **Add**, and then choose **Generic Test**.  
  
     A template for a generic test is added to your test project. It appears in the main editing window. The new generic test is given a default name, such as GenericTest1.generic, and is displayed in Solution Explorer within the test project.  
  
2.  Under **Specify an existing program (a test, test harness, or test adapter) to wrap as a generic test**, indicate the path and file name of the test, program, or third-party tool to wrap into a generic test.  
  
3.  (Optional) Under **Command line arguments to pass to the generic test**, type one or more arguments to pass. Separate multiple arguments with spaces. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)][Generic Test Command-Line Arguments](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md#CreatingGenericTests_CommandLineArgs) in this topic.  
  
4.  (Optional) Under **Additional files to deploy with this generic test**, specify any files that the test must have to run correctly.  
  
    > [!NOTE]
    >  Before the test runs, the files that you specify in this step are copied to a deployment directory that is created by Visual Studio.  
  
     [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)] [Deploying Files for Generic Tests](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md#CreatingGenericTests_DeployingFiles) in this topic.  
  
5.  (Optional) Under **Working Directory**, specify a directory that the executable file is to use as a working directory as it runs.  
  
6.  (Optional) Specify the name of a results file.  
  
7.  Save the generic test.  
  
    > [!TIP]
    >  You can create and use an XML based summary results file to provide detailed results for portions of you generic test. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)][Using a Summary Results File with a Generic Test](../test/using-a-summary-results-file-with-a-generic-test.md).  
  
 The test is now ready to run; it will return a result of 0 or another number. The test engine interprets 0 as Passed and any other number as Failed.  
  
##  <a name="CreatingGenericTests_CommandLineArgs"></a> Generic Test Command-Line Arguments  
 You can pass command-line arguments to the program that your generic test wraps.  
  
 For example, to pass a single argument, simply type the argument in the box indicated by **Command-line arguments to pass to the generic test**, in the generic test.  
  
 To pass multiple arguments, type them in the **Command-line arguments to pass to the generic test** box, separated by spaces. For example, type: `12 "%TestDeploymentDir%\mydeployedfile.txt"`.  
  
 You can see this same example in context in [Walkthrough: Creating and Running a Generic Test](../test/walkthrough--creating-and-running-a-generic-test.md).  
  
##  <a name="CreatingGenericTests_DeployingFiles"></a> Deploying Files for Generic Tests  
 If either your generic test or the executable file that it wraps need additional supporting files when they run, you can deploy these files before the test is run.  
  
 This is shown in the [Deploy a File When You Run the Generic Test](../test/walkthrough--creating-and-running-a-generic-test.md#DeployAFile) procedure in [Walkthrough: Creating and Running a Generic Test](../test/walkthrough--creating-and-running-a-generic-test.md).  
  
#### To deploy files for a generic test  
  
1.  In Solution Explorer, open a test project that contains your generic test.  
  
2.  Under **Additional files to deploy with this generic test**, specify any files that the test must have to run correctly.  
  
    > [!NOTE]
    >  Before the test runs, the files that you specify in this step are copied to a deployment directory that is created by Visual Studio.  
  
3.  Save the generic test.  
  
## Security  
 Not only can a generic test call any executable program on your computer, it uses your credentials as it does so. For this reason, make sure that you trust the author of the program and know what the program will do.  
  
## See Also  
 [Creating Automated Tests Using Microsoft Test Manager](assetId:///7b5075ee-ddfe-411d-b1d4-94283550a5d0)   
 [Troubleshooting Generic Tests](../test/troubleshooting-generic-tests.md)