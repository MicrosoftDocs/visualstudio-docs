---
title: "How to: Deploy Files for Tests"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.runconfig.options.deploy"
helpviewer_keywords: 
  - "tests, deploying"
  - "code-coverage, configuring"
ms.assetid: 7bad2edf-6c76-49f4-be4e-4355c9a5597e
caps.latest.revision: 72
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
# How to: Deploy Files for Tests
Before you run a test, the test and the application have to be copied to a location where they can run, together with other assemblies that they reference. A test typically also requires additional files such as test data, configuration files, a database, and explicitly loaded assemblies. To make those additional files available for the test, you must specify that they are to be deployed.  
  
## Where do tests run?  
 Visual Studio can run tests in several places:  
  
-   **In the build output folder**, typically \<your project>\bin\Debug.  
  
-   **In a local test deployment folder** on the same machine as the build.  
  
-   **On a remote computer.** Remote deployment is used to test distributed or web applications, and applications that must be run on a particular platform. For remote deployment you must set up a [test controller and test agents](../test/install-and-configure-test-agents.md), and you typically run the tests on a [lab environment](../test/test-on-a-lab-environment.md). For more information about remote deployment, see [How to: Run a Test Using Test Controllers and Test Agents](../test/how-to--run-a-test-using-test-controllers-and-test-agents.md).  
  
## How do I deploy test files for a local test?  
 Here’s the best way:  
  
1.  Copy the files to the build target directory as part of the build process.  
  
    -   If they are specific to one test project, include them as content files in the Visual Studio test project. Select them in Solution Explorer and set the **Copy to Output** property to **Copy if Newer**.  
  
    -   Otherwise, define a post-build task to copy the files into the build output directory. For example:  
  
        ```  
        xcopy /Y /S "$(SolutionDir)SharedFiles\*" "$(TargetDir)"  
        ```  
  
         Open the project properties of your test project. In a C# project, open the **Build Events** page. In a Visual Basic project, open the **Compile** page and choose **Build Events**. Add the copy command to the **Post-build event** field.  
  
2.  Use \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItemAttribute> on test methods or test classes to specify the files and folders that should be copied from the build output directory to the deployment directory.  
  
    ```c#  
    [TestClass]  
    class TestClass1  
    {  
      [TestMethod]  
      [DeploymentItem("source", "targetFolder")]  
      public void Test1()  
      {  
        string testData = System.IO.File.ReadAllText(@"targetFolder\source");  
        ...  
    } }  
    ```  
  
    ```vb#  
    <TestClass()> _  
    Public Class UnitTest1  
        <TestMethod()> _  
        <DeploymentItem("source", "targetFolder")> _  
        Sub TestMethod1()  
            Dim testData As String = _  
                System.IO.File.ReadAllText(@"targetFolder\source")  
        ...  
        End Sub  
    End Class  
  
    ```  
  
    -   *source* is a file or directory to copy. The path can be absolute, or relative to the build output directory.  
  
    -   *targetFolder* is optional. It is the directory into which the source file or directory contents will be copied. The path can be absolute, or relative to the deployment directory. The default value is ".", the deployment directory.  
  
        > [!NOTE]
        >  *targetFolder* is always a directory, never a file path. You cannot change the name of the file by using DeploymentItem.  
  
     You can use the attribute as many times as you want, and you can apply it to test methods or test classes.  
  
     When you select a set of tests to run, all the items specified in their DeploymentItem attributes are copied before the test run starts.  
  
3.  Consider running your unit tests directly in the build output directory, so that testing runs more rapidly. This is especially useful on the build server after you have checked in your tests.  
  
     To do this, [add a *.runsettings file](../codequality/configure-unit-tests-by-using-a-.runsettings-file.md) to your solution, include `<DeploymentEnabled>False</DeploymentEnabled>`, and select the file in the **Test**, **Test Settings** menu. The same effect occurs in any test run in which DeploymentItemAttribute is not used at all.  
  
     However, you cannot avoid using a deployment folder if you are using a [*.testsettings](../test/specifying-test-settings-for-visual-studio-tests.md) file, which is required for web and load tests, coded UI tests, and any test in which you deploy an application to remote machines.  
  
## What’s a *.runsettings file?  
 A file with any name and the filename extension '.runsettings'. It’s used to configure unit tests for some purposes. If you want to create one, copy the example from [Configure unit tests by using a .runsettings file](../codequality/configure-unit-tests-by-using-a-.runsettings-file.md). Put it in a solution folder and then make it active using the **Test>Test Settings** menu.  
  
## When should I use a *.testsettings file?  
 A [*.testsettings file](../test/specifying-test-settings-for-visual-studio-tests.md) (that is, a file with any name and the filename extension '.testsettings') is an older alternative to \*.runsettings. If you want to create one, use the menu item in the **Test>Test Settings** menu. Save the file in a solution folder, and make it active by using the **Test>Test Settings menu**.  
  
 Avoid using a [*.testsettings](../test/specifying-test-settings-for-visual-studio-tests.md) file if you can, because it makes the tests run more slowly and it is incompatible with third-party test frameworks. You don’t need it for plain unit tests. But you do need one in these cases:  
  
-   You are running [web performance and load tests](../test_notintoc/web-performance-and-load-tests-in-visual-studio.md) or [coded UI tests](../codequality/use-ui-automation-to-test-your-code.md)  
  
-   You are [running tests of a distributed application on more than one machine](../test/how-to--run-a-test-using-test-controllers-and-test-agents.md)  
  
-   You want to [collect additional diagnostic data](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md) from your tests  
  
 If you use a *.testsettings file, your application and test assemblies will always be copied to a deployment folder.  
  
 You can specify data files and directories on the **Deployment** page of the .testsettings editor. They will be copied to the deployment folder before each test run. Item paths specified on this page are always relative to the solution directory, and are always deployed to the deployment folder alongside the application and test assemblies.  
  
 If you want to use absolute paths or to specify a different target directory, open the .testsettings file with the XML editor, and insert a fragment similar to this:  
  
```xml  
<Deployment>  
  <DeploymentItem filename="C:\MyTestData\TestData.mdb"  
        outputDirectory="D:\TestDB\" />  
</Deployment>  
```  
  
 `outputDirectory` can be absolute or relative to the deployment directory.  
  
## When is a separate deployment folder used?  
 If you run tests by using Visual Studio, the deployment folder is created under TestResults in your solution folder.  
  
 A separate deployment folder is used if any of the test methods or classes in a test run has the DeploymentItem attribute, or if you use a [*.testsettings](../test/specifying-test-settings-for-visual-studio-tests.md) file.  
  
 If a deployment folder is used, the following files and folders are copied to the deployment folder before the tests are run:  
  
-   The test assembly file  
  
-   All dependent assemblies  
  
-   Files and directories that you have specified explicitly, either by using \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItemAttribute> or in a [*.testsettings](../test/specifying-test-settings-for-visual-studio-tests.md) file  
  
 ![Local Deployment Folder for Tests](../test/media/deployfolders.png "DeployFolders")  
Deployment folders for a local test run  
  
##  <a name="DeploymentOrder"></a> When are files deployed and in what sequence?  
 In a test run, all the files to be deployed are copied before any tests start. A test run is a batch of tests initiated by a single command or scheduled event. This means that if you specify a data file to be deployed for a particular test method, it will also be available for every other test that is performed in the same run.  
  
 The following items are copied, in the order shown. Items that are copied later overwrite those that were copied earlier, if they have the same name.  
  
1.  Items specified by using \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItemAttribute>  
  
2.  Dependencies. For example, application configuration files and dependent assemblies.  
  
3.  Items specified in a [*.testsettings](../test/specifying-test-settings-for-visual-studio-tests.md)file, if you are using one.  
  
4.  Instrumented binaries. For example, assemblies that have been instrumented to enable code coverage or IntelliTrace.  
  
     If you are using in-place instrumentation, binaries are instrumented first and then copied to the deployment directory; otherwise, they are copied first and then instrumented. In-place instrumentation is the default setting for tests that are run locally.  
  
5.  The file or files that comprise the test. These include test assemblies, for unit tests; text or .mht files, for manual tests; or other types of files for other test types, such as generic tests.  
  
## What’s in the TestResults directory?  
  
-   **Test run folder**. TestResults contains one folder for each test run that has started. Its name includes the time it was created.  
  
     If you specify setup and cleanup scripts in a *.testsettings file, the test run folder contains those scripts.  
  
-   **Out**. Each test run folder contains a folder named Out. The Out folder is the actual deployment folder, to which assemblies and other deployment files are copied when the test run starts.  
  
-   **In**. Code-coverage results and certain other test results are stored in the folder named In.  
  
## See Also  
 \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItemAttribute>   
 [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md)   
 [Instrumenting and Re-Signing Assemblies](../test_notintoc/instrumenting-and-re-signing-assemblies.md)