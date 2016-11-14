---
title: "Upgrade Visual Studio 2010 unit test projects | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f1502b51-d6db-4894-9fbf-4a5723e4bb1a
caps.latest.revision: 8
ms.author: "mlearned"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Upgrade Visual Studio 2010 unit test projects
[!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)] includes test project compatibility with [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] SP1 test projects. For example, test projects that you created with [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] SP1 can be opened using [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)] without any upgrade. Therefore, your team can use both [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] SP1 and [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)] to work with same test project. For more information, see [Upgrading tests from Visual Studio 2010](http://msdn.microsoft.com/en-us/e9c8b7f6-bd72-448e-8edb-d090dcc5cf52).  
  
 [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)] introduces several changes for unit testing. Because of these changes, it is important to understand the compatibility issues between previous versions of Visual Studio and [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)]. Among the changes to unit testing, a significant change is that [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)] includes more than one test project template, including a unit test project template. New unit tests are added to the new unit test project template. Unit tests can also be included in another new test project template called the coded UI test project template. For more information about the new test project templates, see [Upgrading Tests from Earlier Versions of Visual Studio](http://msdn.microsoft.com/en-us/e9c8b7f6-bd72-448e-8edb-d090dcc5cf52). The new unit test projects no longer include a test settings file by default. By excluding the test settings file, the performance of your unit tests improves. For compatibility, you can still use your existing test projects that you created using Visual Studio 2010. However, we recommend that you remove the test settings file associated with the test project for performance reasons unless you have a specific need for the test settings file. For example, you might choose to retain the test settings file if your unit tests run in a distributed environment, or you need to collect specific diagnostic data. If you have a similar need using the new unit test project template, or coded UI test project template, you can manually add a test settings file to them as well.  
  
> [!NOTE]
>  Existing unit tests in your [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] SP1 test projects will work seamlessly between [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] SP1 and [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)]. No changes are made to the test project files when a Visual Studio 2010 test project containing your unit tests is opened in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)], or vice-versa.  
  
> [!CAUTION]
>  Visual Studio 2010 can't open a C++/CLI project that targets the 11.0 toolset—that is, a project created in Visual Studio 2012. This restriction applies to all C++/CLI projects, not just C++/CLI unit test projects.  
  
> [!NOTE]
>  You can run the new unit tests using vstest.console.exe from the command line. For more information about using vstest.console.exe, see [VSTest.Console.exe command-line options](/devops-test-docs/test/vstest-console-exe-command-line-options), or run the command by using the help switch: **vstest.console.exe /?**. You can continue to run your existing unit tests using MStest.exe. For more information, see [Run automated tests from the command line using MSTest](/devops-test-docs/test/run-automated-tests-from-the-command-line-using-mstest) and [MSTest.exe command-line options](/devops-test-docs/test/mstest-exe-command-line-options).  
  
 Another significant change is the new Test Explorer. In [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)], some of the testing windows you might be familiar with from previous version of Visual Studio have been deprecated, such as the Test View window. Test Explorer is designed to better support developers and teams who incorporate unit testing in their software development practices. For more information, see [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md).  
  
## Compatibility issues between Visual Studio 2010 SP1 and Visual Studio 2012  
 Here are some issues to be aware of when you migrate unit tests between Visual Studio 2010 SP1 and [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)]:  
  
|Unit Test functionality|Issue|Solution|  
|-----------------------------|-----------|--------------|  
|Test lists (.vsmdi files) are deprecated in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)].|You will no longer be able to create new test lists (.vsmdi files) or run test lists from Visual Studio. **Tip:**  Test categories provide more flexibility than the test lists functionality from earlier versions of Microsoft Visual Studio. You can use logical operators with test categories to run tests from multiple categories together or to limit the tests that you run to tests that belong to multiple categories. Also, test categories are easy to add as you create your test methods and you do not have to maintain test lists after you have created your test methods. By using test categories, you do not have to check in and check out the **\<solution name>.vsmdi** file that maintains the test lists. For more information, see [Defining Test Categories to Group Your Tests](/devops-test-docs/test/defining-test-categories-to-group-your-tests).|-   To maintain compatibility with your existing test projects that use test lists, you are still able to edit the .vsmdi files using Visual Studio.<br />-   Although you can’t run migrated test lists from with Visual Studio, you can still run them using mstest.exe from the command line. For more information, see [Run automated tests from the command line using MSTest](/devops-test-docs/test/run-automated-tests-from-the-command-line-using-mstest)<br />-   If you were using a test list in your build definition, you can continue to use it. For more information, see [How to: Configure and Run Scheduled Tests After Building Your Application](http://msdn.microsoft.com/en-us/32acfeb1-b1aa-4afb-8cfe-cc209e6183fd) and [Run tests in your build process](../Topic/Run%20tests%20in%20your%20build%20process.md).|  
|Private accessors are deprecated in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)].<br /><br /> In previous versions of Visual Studio, you could use Publicize to specify an internal application programming interfaces (API) and create public counterpart API that you can call in your tests, which would in turn, call into the internal APIs of your product. You could then use code generation to create test stubs and generate code snippet inside that stub.|You will no longer be able to create private accessors.|<ul><li>Visual Studio 2010 test projects will compile and work in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)]. The build will include output warnings.</li><li>If you still need to test internal APIs, you have these options:<br /><br /> <ul><li>Use the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject> class to assist in accessing internal and private APIs in your code. This is found in the Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll assembly.</li><li>Create a reflection framework that would be able to reflect off your code to access internal or private APIs.</li><li>If the code you are trying to access is internal, you might be able to access your APIs using <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute> so your test code can have access to the internal APIs.</li></ul></li></ul>|  
|Test Impact is removed|||  
|Sharing of run results through TRX logs from Test Explorer.||You can still get TRX logs from both the command line and Team Build.|  
  
## See Also  
 [Porting, Migrating, and Upgrading Visual Studio Projects](../porting/porting-migrating-and-upgrading-visual-studio-projects.md)   
 [Unit Test Your Code](../test/unit-test-your-code.md)   
 [Upgrading Tests from Earlier Versions of Visual Studio](http://msdn.microsoft.com/en-us/e9c8b7f6-bd72-448e-8edb-d090dcc5cf52)   
 [Upgrading Coded UI Tests from Visual Studio 2010](../test/upgrading-coded-ui-tests-from-visual-studio-2010.md)