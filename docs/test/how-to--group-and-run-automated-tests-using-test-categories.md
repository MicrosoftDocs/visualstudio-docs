---
title: "How to: Group and Run Automated Tests Using Test Categories"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.testview.categories"
helpviewer_keywords: 
  - "test categories"
ms.assetid: 7d7b3263-43fb-4aa9-8f05-2ac2e4c8af94
caps.latest.revision: 54
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
# How to: Group and Run Automated Tests Using Test Categories
Test categories let you run groups of tests based on their assigned categories without the requirement to maintain test lists. A test category is a test method attribute that you can assign to one or more tests.  
  
 You can use logical operators with test categories to run tests from multiple categories together or to limit the tests that you run to tests that belong to multiple categories. Also, test categories are easy to add as you create your test methods and you do not have to maintain test lists after you have created your test methods.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
## Creating and Assigning Test Categories  
  
#### To manually add test categories to a test  
  
1.  In your unit test project, or coded UI test project in Solution Explorer, open the file that contains the unit test, and then locate the unit test method that you want to change.  
  
2.  Directly above the test method declaration, add a [TestCategory()] attribute for each test category that you want to assign to the test. Separate each attribute by using a comma.  
  
3.  Add the category name enclosed in parentheses to each [TestCategory()] attribute. The following example is a method with three Test Categories assigned to it named "Nightly", "Weekly", and "ShoppingCart":  
  
    ```c#  
    [TestCategory("Nightly"), TestCategory("Weekly"), TestCategory("ShoppingCart"), TestMethod()]  
    public void DebitTest()  
    {  
    }  
    ```  
  
## Running Tests by Categories  
 When you run tests from the command line, you can also use logical operators & (AND), &#124; (OR) and !(NOT) to select the tests to run based on the categories assigned to the tests.  
  
#### To run test using categories from the command-line  
  
1.  Open a Visual Studio command prompt. (Go to Start, All Programs, Microsoft Visual Studio, Visual Studio Tools, Developer Command Prompt.)  
  
     By default, the Visual Studio command prompt opens to the following folder:  
  
     \<drive letter>:\Program Files\Microsoft Visual Studio 12.0\VC  
  
    > [!NOTE]
    >  To change the folder to which the command prompt window opens by default, choose **Start**, point to **Microsoft Visual Studio**, point to **Visual Studio Tools**, right-click **Developer Command Prompt**, and then choose **Properties**. In the **Developer Command Prompt Properties** dialog box, you can change the path of the default folder in the **Start in** box.  
  
2.  Either change the directory to the location in your solution folder where the test container is located, typically the test project's .dll file, or, when you run the MSTest.exe program in step 3, specify a full or relative path for the test container.  
  
     To identify your solution folder, first identify the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] **Projects** folder. To do this, choose **Options** on the **Tools** menu in [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)], and then choose **Projects and Solutions**. Under **Visual Studio projects location**, you see a path such as the following:  
  
     **\<drive letter>:\Documents and Settings\\<user name\>\My Documents\Visual Studio\Projects**  
  
     Your solution folder is typically a child of this **Projects** folder, such as the Bank folder in the following example:  
  
     **\<drive letter>:\Documents and Settings\\<user name\>\My Documents\Visual Studio\Projects\Bank**  
  
3.  To run tests that are assigned to the "Nightly" category, run the VSTest.Console.exe using the /TestCaseFilter option, or from MSTest.exe by using the /testcontainer and the /category options:  
  
     **VSTest.Console.exe**  
  
     **Vstest.console.exe myTestProject.dll /TestCaseFilter:TestCategory=Nightly**  
  
     **MSTest.exe**  
  
     **mstest /testcontainer:MyTestprojectName.dll /category:"Nightly"**  
  
     The results and summary are displayed in the command prompt window.  
  
    > [!NOTE]
    >  You can use either AND or OR in your expression to select categories of tests, but not both in the same expression.  
  
     For more information, see [VSTest.Console.exe command-line options](../test/vstest.console.exe-command-line-options.md), [Run automated tests from the command line using MSTest](../test/run-automated-tests-from-the-command-line-using-mstest.md) and [MSTest.exe command-line options](../test/mstest.exe-command-line-options.md).  
  
## See Also  
 [Defining Test Categories to Group Your Tests](../test/defining-test-categories-to-group-your-tests.md)