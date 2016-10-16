---
title: "Walkthrough: using the command-line test utility"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "tests, running"
  - "testing, command-line"
ms.assetid: 52c11992-9e94-4067-a4b7-59f19d69d867
caps.latest.revision: 42
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
# Walkthrough: using the command-line test utility
This walkthrough shows you how to run unit tests from a command-line prompt and then view the results.  
  
## Prerequisites  
  
-   In the walkthrough entitled, [Walkthrough: Creating and Running Unit Tests for Managed Code](../codequality/walkthrough--creating-and-running-unit-tests-for-managed-code.md) perform the following procedures: "Prepare the Walkthrough", "Create a Unit Test," and "Run a Unit Test and Fix Your Code".  
  
-   The Woodgrove Bank project. See [Sample Project for Creating Unit Tests](../codequality/sample-project-for-creating-unit-tests.md).  
  
## Use the Command-line Test Utility  
  
#### To use the command-line test utility  
  
1.  Open a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt.  
  
     To do this, choose **Start**, point to **All Programs**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, and then choose **Developer Command Prompt**.  
  
     The command prompt opens to the folder: \<drive>:\Program Files\Microsoft Visual Studio 11.0\VC  
  
2.  Change directory to the folder that contains the assembly built from your test project.  
  
     To do this, first change directory to your solution folder. For the Bank solution that was created in the prerequisite walkthrough, this folder is: \<drive>:\Documents and Settings\\<username\>\My Documents\Visual Studio\Projects\Bank. Then change directory to the folder for your test project by typing the following command at the command prompt:  
  
     **cd TestProject1\bin\Debug**  
  
     This folder contains the test project you created in the procedures for creating and running unit tests. The test project assembly, TestProject1.dll, contains just a few unit tests.  
  
    > [!NOTE]
    >  Your production code project and your test project will produce distinct assemblies. Make sure to run the command-line utility on the assembly of the test project, not on the assembly of your production code project.  
  
3.  MSTest.exe is a command-line utility that lets you start and control the execution of tests. You can view the choices that MSTest.exe makes available through its options by typing the following at the command prompt:  
  
     **MSTest /?**  
  
4.  Use the command-line utility to test the application.  
  
     Type the following at the command prompt:  
  
     **MSTest /testcontainer:TestProject1.dll**  
  
     This command runs all three tests and returns results such as the following:  
  
     **Loading TestProject1.dll...**  
  
     **Starting Execution...**  
  
     **Results              Top Level Tests**  
  
     **--------               ------------------**  
  
     **Inconclusive     TestProject1.BankAccountTest.CreditTest**  
  
     **Passed              TestProject1.BankAccountTest.DebitTest**  
  
     **Passed              TestProject1.BankAccountTest.FreezeAccountTest**  
  
     **2/3 test(s) Passed, 1 Inconclusive**  
  
     **Summary**  
  
     **----------**  
  
     **Test Run Inconclusive.**  
  
     **Inconclusive   1**  
  
     **Passed           2**  
  
     **-----------------**  
  
     **Total              3**  
  
     **Results file:           <path><test run name>.trx**  
  
     **Test Settings: Default Test Settings**  
  
    > [!NOTE]
    >  If you complete the procedure, "Create and Run a Unit Test for a Private Method" in [Walkthrough: Creating and Running Unit Tests for Managed Code](../codequality/walkthrough--creating-and-running-unit-tests-for-managed-code.md), this command will also show results for the GetAccountTestType unit test.  
  
5.  Run the tests again and save test results to a specified file.  
  
     Type the following at the command prompt:  
  
     **MSTest /testcontainer:TestProject1.dll /resultsfile:testResults1.trx**  
  
     This command runs all three tests and returns the same results as in the previous step. It also creates a file that is named testResults1.trx, and writes test results to that file, formatted for viewing in an XML viewer such as Microsoft Internet Explorer or Microsoft [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)]. If testResults1.trx already exists, MSTest.exe will not run and will show an error stating that a file with that name already exists.  
  
    > [!NOTE]
    >  For more information about the full range of options you can use with the MSTest command, see [MSTest.exe command-line options](../test/mstest.exe-command-line-options.md).  
  
6.  (Optional) View the test results file. Type the following at the command prompt:  
  
     **testResults1.trx**  
  
     This opens Internet Explorer and displays the test results. Alternatively, you can open this file in the Visual Studio integrated development environment (IDE), as follows:  
  
    1.  Choose **File**, point to **Open** and then choose **File**.  
  
    2.  In the **Open File** dialog box, open the folder that contains the .xml file.  
  
    3.  Double-click **testResults1.xml**.  
  
 The command-line utility MSTest.exe is especially useful for automating test runs, to be started in batch files or other utilities.  
  
## See Also  
 [Run automated tests from the command line using MSTest](../test/run-automated-tests-from-the-command-line-using-mstest.md)   
 [MSTest.exe command-line options](../test/mstest.exe-command-line-options.md)   
 [Walkthrough: Creating and Running Unit Tests for Managed Code](../codequality/walkthrough--creating-and-running-unit-tests-for-managed-code.md)