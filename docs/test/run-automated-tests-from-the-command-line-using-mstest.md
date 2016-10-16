---
title: "Run automated tests from the command line using MSTest"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "tests, running from command line"
  - "tests, running"
ms.assetid: 39b61ad0-0055-44b5-963f-25d8a6b51581
caps.latest.revision: 38
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
# Run automated tests from the command line using MSTest
You use the executable program MSTest.exe to run tests from the command line. This program can run any tests that can be automatically run, that is, any tests other than manual tests.  
  
### To run tests from the command line  
  
1.  Open a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt.  
  
     To do this, choose **Start**, point to **All Programs**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, and then choose **Developer Command Prompt**.  
  
     By default, the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt opens to the following folder:  
  
     \<drive letter>:\Program Files\Microsoft Visual Studio 11.0\VC  
  
    > [!NOTE]
    >  To change the folder to which the command prompt window opens by default, choose **Start**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, right-click **Developer Command Prompt**, and then choose **Properties**. In the **Developer Command Prompt Properties** dialog box, you can change the path to the default folder in the **Start in** box.  
  
2.  Either change directory to your solution folder or, when you run the MSTest.exe program in step 3, specify a full or relative path to the metadata file or to the test container.  
  
     To identify your solution folder, first identify the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Projects folder. To do this, choose **Options** on the **Tools** menu in [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)], and then choose **Projects and Solutions**. Under **Visual Studio projects location**, you see a path such as the following:  
  
     **\<drive letter>:\Documents and Settings\\<user name\>\My Documents\Visual Studio\Projects**  
  
     Your solution folder is typically a child of this Projects folder, such as the Bank folder in the following example:  
  
     **\<drive letter>:\Documents and Settings\\<user name\>\My Documents\Visual Studio\Projects\Bank**  
  
3.  Run the MSTest.exe program.  
  
     When you run MSTest.exe, you must specify either a test metadata file or a test container, using either the **/testmetadata** option or the **/testcontainer** option, respectively. You use the /testmetadata option only once, to indicate one test metadata file. You can use the /testcontainer option multiple times, to indicate multiple test containers.  
  
     If necessary, include the path to the folder in which the metadata file or test container resides. Test metadata files reside in the solution folder.  
  
     Depending on the test type, test containers are XML files, assemblies built from test projects, or other files that reside in the folders of a test project.  
  
 **Examples**  
  
 You must use the /testcontainer option together with the /category option to select which tests in which categories to run. The following command, for example, is run in the solution folder and runs the tests that are in both the Priority 1 and ShoppingCart categories.:  
  
 **MSTest /testcontainer: testproject2\bin\debug\testproject2.dll /category:"Priority1&ShoppingCart"**  
  
> [!NOTE]
>  Because the test assembly file resides in a different folder, a relative path is necessary,  
  
 If you are using test lists, it is best to use the /testmetadata option together with the /testlist option. The following command, for example, is run in the solution folder. Because the test metadata file also resides in that folder, no path is necessary:  
  
 **MSTest /testmetadata:Bank.vsmdi /testlist:balancetests**  
  
> [!WARNING]
>  Test lists are no longer fully supported in [!INCLUDE[vs_dev11_long](../codequality/includes/vs_dev11_long_md.md)]:  
>   
>  -   You cannot create new test lists.  
> -   You cannot run test list tests from within Visual Studio.  
> -   If you upgraded from Visual Studio 2010, and had test list in your solution, you can continue to edit it in Visual Studio.  
> -   You can continue to run test list using mstest.exe from the command line, as described above.  
> -   If you were using a test list in your build definition, you can continue to use it.  
  
 Optionally, you can use other MSTest command-line options for purposes such as specifying individual tests to run, publishing test data, and customizing screen output. For more information about these options, see [MSTest.exe command-line options](../test/mstest.exe-command-line-options.md).  
  
## See Also  
 [Command-Line test results](../test/command-line-test-results.md)   
 [MSTest.exe command-line options](../test/mstest.exe-command-line-options.md)   
 [Walkthrough: using the command-line test utility](../test/walkthrough--using-the-command-line-test-utility.md)   
 [Command-Line options for publishing test results](../test/command-line-options-for-publishing-test-results.md)