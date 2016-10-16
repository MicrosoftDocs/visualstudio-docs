---
title: "VSTest.Console.exe command-line options"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "VSTest.Console.exe"
  - "tests, running from command line"
  - "tests, running"
  - "command line, VSTest.Console.exe"
ms.assetid: 52e1689d-b1a8-4589-bd98-99a55acd0a11
caps.latest.revision: 21
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
# VSTest.Console.exe command-line options
VSTest.Console.exe is the command-line command that is used to run tests. You can specify several options in any order on the VSTest.Console.exe command line. These options are listed in the General Command Line Options table later in this topic.  
  
 vstest.console.exe interprets these options and values you specify in a case-insensitive manner.  
  
 The following table lists all the options for VSTest.Console.exe and short descriptions of them. You can see a similar summary by typing **VSTest.Console/?** at a command line.  
  
> [!NOTE]
>  The MSTest adapter in [!INCLUDE[vs_dev11_long](../codequality/includes/vs_dev11_long_md.md)] also works in legacy mode (equivalent of running tests with mstest.exe) for compatibility. In legacy mode, it cannot take advantage of new VS11 features TestCaseFilter. Adapter can switch to legacy mode when .testsettings file is specified, **forcelegacymode** is set to true in .runsettings file or using attributes like HostType.  
  
> [!NOTE]
>  In order to run automated tests on an ARM architecture based machine, you must use VSTest.Console.exe.  
  
 **General Command Line Options**  
  
|||  
|-|-|  
|**/Settings:[** *file name* **]**|Run tests with additional settings such as data collectors.<br /><br /> Example: **/Settings:Local.RunSettings**|  
|**/Tests:[** *test name* **]**|Run tests with names that match the provided values.<br /><br /> To provide multiple values, separate them by commas.<br /><br /> Example: **/Tests:TestMethod1,testMethod2** **Warning:**  The **/Tests** command line option cannot be used with the **/TestCaseFilter** command line option.|  
|**/Enablecodecoverage**|Enables data diagnostic adapter CodeCoverage in the test run.<br /><br /> Default settings are used if not specified using settings file.|  
|**/InIsolation**|Runs the tests in an isolated process.<br /><br /> This makes vstest.console.exe process less likely to be stopped on an error in the tests, but tests might run slower.|  
|**/UseVsixExtensions**|This makes vstest.console.exe process use or skip the VSIX extensions installed (if any) in the test run.<br /><br /> Example: **/UseVsixExtensions:true**|  
|**/Platform:[** *platform type* **]**|Target platform architecture to be used for test execution.<br /><br /> Valid values are x86, x64 and ARM.|  
|**/Framework: [** *framework version* **]**|Target .NET Framework version to be used for test execution.<br /><br /> Valid values are Framework35, Framework40 and Framework45.<br /><br /> Example: **/Framework:framework40**|  
|**/TestCaseFilter:[** *expression* **]**|Run tests that match the given expression.<br /><br /> \<Expression> is of the format \<property>=\<value>[&#124;\<Expression>].<br /><br /> Example: **/TestCaseFilter:"Priority=1"**<br /><br /> Example: **/TestCaseFilter:"TestCategory=Nightly&#124;FullyQualifiedName=Namespace.ClassName.MethodName"** **Warning:**  The **/TestCaseFilter** command line option cannot be used with the **/Tests** command line option. <br /><br /> For information about creating and using expressions, see [Running selective unit tests using TestCaseFilter](https://blogs.msdn.microsoft.com/vikramagrawal/2012/07/23/running-selective-unit-tests-in-vs-2012-rc-using-testcasefilter/).|  
|**/Logger:[** *uri/friendlyname* **]**|Specify a logger for test results.<br /><br /> Example: To log results into a Visual Studio Test Results File (TRX) use **/Logger:trx**.<br /><br /> Example: To publish test results to Team Foundation Server, use TfsPublisher:<br /><br /> **/logger:TfsPublisher;**<br /><br /> **Collection=\<team project url>;**<br /><br /> **BuildName=\<build name>;**<br /><br /> **TeamProject=\<team project name>;**<br /><br /> **[;Platform=\<Defaults to “Any CPU”>]**<br /><br /> **[;Flavor=\<Defaults to “Debug”>]**<br /><br /> **[;RunTitle=\<title>]** **Note:**  The TfsPublisher logger requires [!INCLUDE[vs_dev11_long](../codequality/includes/vs_dev11_long_md.md)] with [[Visual Studio 2012.1](http://go.microsoft.com/fwlink/?LinkID=267636)] or later.|  
|**/ListTests:[** *file name* **]**|Lists discovered tests from the given test container.|  
|**/ListDiscoverers**|Lists installed test discoverers.|  
|**/ListExecutors**|Lists installed test executors.|  
|**/ListLoggers**|Lists installed test loggers.|  
|**/ListSettingsProviders**|Lists installed test settings providers.|  
  
## Using VSTest.Console.exe with test files  
 The usage for vstest.console.exe is:  
  
 **Vstest.console.exe [TestFileNames] [Options]**  
  
 The following shows an example of using VSTest.Console.exe from the command line:  
  
 **Vstest.console.exe myTestProject.dll**  
  
 The following shows an example of using VSTest.Console.exe from the command line using multiple test files. This is done by separating test file names with spaces:  
  
 **Vstest.console.exe myTestFile.dll myOtherTestFile.dll**  
  
## Example  
 The following example shows the use of some of the options for running Vstest.console.exe. In this case, it will run the tests in the myTestFile.dll file, while collecting data specified in the Local.RunSettings file and in an isolated process. Additionally, it will filter the test cases to run based in “Priority 1”, and log the results to a .trx file.  
  
 **vstest.console.exe  myTestFile.dll /Settings:Local.RunSettings /InIsolation /TestCaseFilter:"Priority=1" /Logger:trx**  
  
## See Also  
 [Running automated tests from the command line](../test/running-automated-tests-from-the-command-line.md)   
 [Using VSTest.console from the command line](../test/using-vstest.console-from-the-command-line.md)