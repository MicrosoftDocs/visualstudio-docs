---
title: "Walkthrough: Creating and Running a Generic Test"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "generic tests, authoring"
  - "generic tests, running"
  - "generic tests, creating"
ms.assetid: b369241b-c36e-48fe-bad5-11a080a650c8
caps.latest.revision: 61
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
# Walkthrough: Creating and Running a Generic Test
This walkthrough will step you through the process of wrapping an executable file as a generic test, then running the test. You will start by creating an executable file using existing sample code. Next, you will create a new generic test and add the executable file to the generic test. Finally, you will run the test.  
  
> [!NOTE]
>  For information about generic tests, see [Creating an Automated Test That Runs an Executable Using Generic Tests](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md).  
  
 In this walkthrough, you will complete the following procedures:  
  
-   Create a program, that is, an executable file, to wrap as a generic test. This program represents a third-party testing tool that produces pass or fail results for its exit or return value at program completion. See [Prepare the Walkthrough](#PrepareWalkthrough).  
  
-   [Create the generic test](#CreateAGenericTest).  
  
-   [Run the generic test](#RunGenericTest).  
  
-   Pass command-line arguments when you run the generic test. For more information, see [Run the generic test](#RunGenericTest).  
  
-   [Deploy a File When You Run the Generic Test](#DeployAFile).  
  
## Prerequisites  
  
-   Visual Studio Enterprise  
  
-   You must create the executable file EvenOdd.exe. To do this, use the source code in [Generic Test Sample](../test/generic-test-sample.md) and follow the steps in the next procedure, "Prepare the Walkthrough."  
  
##  <a name="PrepareWalkthrough"></a> Prepare the Walkthrough  
  
#### To prepare the walkthrough  
  
1.  Create a project for a new Visual C# console application. In **Name** field of the **New Project** dialog box, type `EvenOdd` and then choose **OK**.  
  
     The EvenOdd solution is displayed in Solution Explorer. It contains a project named EvenOdd.  
  
2.  Within the EvenOdd project, open the source-code file Program.cs.  
  
3.  Replace the code of the Program.cs file with the code in [Generic Test Sample](../test/generic-test-sample.md).  
  
4.  Build the solution.  
  
     This creates the program that you will wrap to create a generic test.  
  
##  <a name="CreateAGenericTest"></a> Create a Generic Test  
  
#### To create a generic test  
  
1.  Right-click the EvenOdd solution, point to **Add**, and then choose **New Project**.  
  
     The **AddNew Project** dialog box is displayed.  
  
2.  In the **Add New Project** dialog box, expand **Visual C#** and then choose **Test**.  
  
3.  In the **Templates** pane, choose **Unit Test Project** and then choose **OK**. Accept the default name, for example, TestProject1.  
  
    > [!NOTE]
    >  Coded UI test projects can also include generic tests.  
  
4.  Right-click the unit test project, point to **Add**, and then choose **Generic Test**.  
  
     The template for a generic test is added to your test project and appears in the main editing window. The new generic test is given a default name, such as GenericTest1.GenericTest, and is displayed in Solution Explorer.  
  
5.  Under **Specify an existing program (a test, test harness, or test adapter) to wrap as a generic test**, indicate the path and file name of the EvenOdd.exe file.  
  
    > [!NOTE]
    >  To determine this path, choose **Options** on the **TOOLS** menu and then choose **Projects and Solutions**. The path of the EvenOdd solution is displayed under **Visual Studio projects location**. The EvenOdd solution contains a folder for the EvenOdd project. Under the EvenOdd project folder, EvenOdd.exe resides under bin\Debug\\.  
  
     This designation will look similar to the following sample:  
  
     `C:\Documents and Settings\<your user name>\My Documents\Visual Studio <version>\Projects\EvenOdd\EvenOdd\bin\Debug\EvenOdd.exe.`  
  
6.  Save the generic test.  
  
     You have created a generic test that wraps EvenOdd.exe. This test has the following characteristics:  
  
    -   You can run the test from a command line.  
  
    -   The test returns a value of 0, for Passed, or 1, for Failed.  
  
    -   You can now run the generic test from Test Explorer. To run the test now, see [Run the Generic Test](#RunGenericTest).  
  
##  <a name="RunGenericTest"></a> Run the Generic Test  
  
#### To run the generic test that you created  
  
1.  On the **TEST** menu, point to **Windows** and then choose **Test Explorer**.  
  
     The Test Explorer is displayed.  
  
2.  On the **BUILD** menu, choose **Build Solution**.  
  
3.  In Test Explorer, select the generic test and choose **Run**.  
  
     The EvenOdd executable file returns a value of 0 or 1 at random. Accordingly, when the generic test that wraps EvenOdd runs, it passes or fails depending on the number generated by EvenOdd. The Test Results window displays the result, either Passed or Failed.  
  
    > [!NOTE]
    >  In general, a generic test passes when the executable it wraps returns a value of 0, and fails if any other value is returned.  
  
     You can also pass arguments to the EvenOdd executable file. A test based on EvenOdd.exe passes or fails depending on the supplied arguments. For a description of the values that EvenOdd.exe returns, see [Generic Test Sample](../test/generic-test-sample.md).  
  
4.  To pass an argument when you run the generic test, on the GenericTest1.generic page, type `12` on the line **Command line arguments to pass to the generic test** and run the test again.  
  
     Because you passed an even number, the test passes. You can confirm this result in the Test Results window.  
  
5.  (Optional) Run the test additional times, passing in different values.  
  
     Some existing tests or executable programs require additional files when they run. You can specify files to deploy along with a generic test. For more information, see [Deploy a File When You Run the Generic Test](#DeployAFile).  
  
##  <a name="DeployAFile"></a> Deploy a File When You Run the Generic Test  
  
#### To deploy an additional file when you run the generic test  
  
1.  Create and save a file that is named mydeployedfile.txt. The file can be empty. Note the folder in which you created it.  
  
2.  Under **Additional files to deploy with this generic test**, choose **Add**.  
  
     The **Add Deployment Files** dialog box is displayed.  
  
3.  In the **Add Deployment Files** dialog box, under **Files of type**, choose **All files(\*.\*)**.  
  
4.  Navigate to the folder that contains mydeployedfile.txt, select the file, and then choose **Open**.  
  
     You have specified mydeployedfile.txt to be deployed when you run the generic test.  
  
     In the following steps, you can verify that the file is being deployed. You do this by using a specific feature of EvenOdd.exe that produces a Passed or Failed result depending on the presence or absence of the file that you specified.  
  
5.  In the generic test, change the value of the **Command-line arguments to pass to the generic test** run setting to: `12` `"%TestDeploymentDir%\mydeployedfile.txt"`  
  
6.  Save the generic test.  
  
     Two command-line arguments are now passed to the generic test. This change causes EvenOdd.exe to use a different criterion to produce a result of Pass or Fail. When you pass two arguments, the first argument is ignored. If the file specified by the second argument exists in the same directory as the test, the test passes. However, if the file was not deployed or if the name of the file specified in the command-line argument does not match the name of the deployed file, the test fails.  
  
     To run the test now, see [Run the Generic Test](#RunGenericTest).  
  
## See Also  
 [Creating an Automated Test That Runs an Executable Using Generic Tests](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md)