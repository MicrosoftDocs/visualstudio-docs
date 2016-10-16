---
title: "MSTest.exe command-line options"
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
  - "test lists, running from command line"
  - "command line, MSTest.exe"
  - "MSTest.exe command-line options"
ms.assetid: 8813ba7f-e790-4e92-9f91-7080508a1c36
caps.latest.revision: 57
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
# MSTest.exe command-line options
MSTest.exe is the command-line command that is used to run tests. This command has several options that you can use to customize your test run. You can use many of these options in conjunction with one another; in fact, you must use certain options in conjunction with other options, as described in the following sections. You can specify these options in any order on the MSTest.exe command line.  
  
 MSTest.exe does not interpret the options or the values you specify for them in a case-sensitive manner.  
  
 The following tables list all the options for MSTest.exe and short descriptions of them. You can see a similar summary by typing **MSTest/h** at a command line.  
  
 **General Command Line Options**  
  
|||  
|-|-|  
|**/testcontainer:[** *file name* **]**|Load a file that contains tests.<br /><br /> Example: **/testcontainer:tests.dll**<br /><br /> For more information, see [/testcontainer](#testcontainer).|  
|**/testmetadata:[** *file name* **]**|Load a file that contains test metadata. For more information, see [/testmetadata](#testmetadata).|  
|**/testlist:[** *test list path* **]**|Specify the test list, as specified in the metadata file, to be run. For more information, see [/testlist](#testlist).|  
|**/category:[** *test category filter* **]**|Specify and filter which test categories to run. For more information, see [/category](#category).|  
|**/test:[** *test name* **]**|Specify the name of a test to be run. For more information, see [/test](#test).|  
|**/noisolation**|Run tests within the MSTest.exe process. This choice improves test run speed but increases risk to the MSTest.exe process.|  
|**/testsettings: [** *file name* **]**|Use the specified test settings file.<br /><br /> Example: **/testsettings:Local.Testsettings**<br /><br /> For more information, see [/testsettings](#testsettings).|  
|**/runconfig:[** *file name* **]**|Use the specified run configuration file.<br /><br /> Example: **/runconfig:localtestrun.Testrunconfig**<br /><br /> For more information, see [/runconfig](#runconfig). **Note:**  This command-line option is maintained for compatibility with previous versions of Visual Studio. Test run configurations have been replaced by test settings in Visual Studio Enterprise.|  
|**/resultsfile:[** *file name* **]**|Save the test run results to the specified file.<br /><br /> Example: **/resultsfile:testResults.trx**<br /><br /> For more information, see [/resultsfile](#resultsfile).|  
|**/detail:[** *property id* **]**|Specify the name of a property that you want to show values for, if any, in addition to the test outcome. For more information, see [/detail](#detail).|  
|**/help**|Display the MSTest.exe usage message (short form: **/?** or **/h**).|  
|**/nologo**|Display no startup banner and copyright message.|  
|**/usestderr**|Use standard error to output error information.|  
  
 **Command-Line Options for Publishing Test Results**  
  
 For more information about these options, see [Command-Line options for publishing test results](../test/command-line-options-for-publishing-test-results.md).  
  
|||  
|-|-|  
|**/publish:[** *server name* **]**|Publish results to the database for the team project collection of the specified server.|  
|**/publishresultsfile:[** *file name* **]**|Specify the results file name to be published. If no results file name is specified, use the file produced by the current run.|  
|**/publishbuild:[** *build id* **]**|Publish test results using this build ID.|  
|**/teamproject:[** *team project name* **]**|Specify the name of the team project to which the build belongs.|  
|**/platform:[** *platform* **]**|Specify the platform of the build against which test results should be published.|  
|**/flavor:[** *flavor* **]**|Specify the flavor of the build against which test results should be published.|  
  
## Using MSTest Options  
 The following sections describe many of the options for MSTest.exe in more detail. The options that were used for publishing test results are not included here. For information about those options, see [Command-Line options for publishing test results](../test/command-line-options-for-publishing-test-results.md).  
  
###  <a name="testcontainer"></a> /testcontainer  
 **/testcontainer:[** *file name* **]**  
  
 The test container is a file that contains the tests you want to run. For example, for ordered tests, the test container is the .orderedtest file that defines the ordered test. For unit tests, it is the assembly built from the test project that contains the unit test source files.  
  
> [!NOTE]
>  For unit tests, this is the assembly that contains test code, not the assembly that contains the code of the application that you are testing. For example, if your solution contains a project named BankAccount and a corresponding test project named BankAccountTest, specify **/testcontainer:BankAccountTest.dll**.  
  
> [!NOTE]
>  Because the test metadata file also lists tests that you can run, you must not specify both the **/testcontainer** and **/testmetadata** options in a single command line.  Doing this would be ambiguous and would produce an error.  
  
###  <a name="testmetadata"></a> /testmetadata  
 **/testmetadata:[** *file name* **]**  
  
 You can use the **/testmetadata** option to run tests in multiple test containers.  
  
 The test metadata file is created for your solution when you create test lists using the Test List Editor window. This file contains information about all the tests listed in the Test List Editor window. These are all the tests that exist in all test projects in your solution.  
  
 The test metadata file is an XML file that is created in the solution folder. This file is shown in Solution Explorer under the **Solution Items** node. A test metadata file has the extension .vsmdi, and is associated with the Test List Editor window. That is, if you double-click a .vsmdi file in Windows Explorer (or File Explorer), the file opens [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] and its contents. All the tests in a solution's test projects are displayed in the Test List Editor window.  
  
 You can change the test metadata file only by making changes that are reflected in the Test List Editor window, such as creating or deleting tests, or changing a test's properties.  
  
> [!NOTE]
>  Because the test container contains tests that you can run, you must not specify both the **/testcontainer** and **/testmetadata** options in a single command line.  Doing this would be ambiguous and would produce an error.  
  
 When you use the **/testmetadata** option, it is recommended that you indicate specific tests to run by using the **/test** option or the **/testlist** option, or both.  
  
###  <a name="testlist"></a> /testlist  
 **/testlist:[** *test list path* **]**  
  
 The **/testlist** option is a list of tests, as specified in the test metadata file, to be run. To run the tests that are contained in multiple test lists, use the **/testlist** option multiple times. Any ordered tests in the test list will be run.  
  
> [!NOTE]
>  You can use the **/testlist** option only if you also use the **/testmetadata** option.  
  
 You can use the **/testlist** option and the **/test** option together. This is equivalent to selecting both a test list and one or more individual tests in the Test List Editor window and then choosing **Run Tests**.  
  
###  <a name="category"></a> /category  
 **/category:[** *test category filter* **]**  
  
 Use the **/category** option to specify which test category to run.  
  
> [!NOTE]
>  You must use the **/testcontainer** option in order to use the **/category** option.  
  
 You can only use the **/category** option one time per command line, but you can specify multiple test categories with the test category filter. The test category filter consists of one or more test category names separated by the logical operators '&', '&#124;', '!', '&!'. The logical operators '&' and '&#124;' cannot be used together to create a test category filter.  
  
 For Example:  
  
-   **/category:group1** runs tests in the test category "group1".  
  
-   **/category:"group1&group2"** runs tests that are in both test categories "group1" and "group2." Tests that are only in one of the specified test categories will not be run.  
  
-   **/category:"group1&#124;group2"** runs tests that are in test category "group1" or "group2". Tests that are in both test categories will also be run.  
  
-   **/category:"group1&!group2"** runs tests from the test category "group1" that are not in the test category "group2." A test that is in both test category "group1" and "group2" will not be run.  
  
    > [!NOTE]
    >  If your filter consists of a single category such as **/category:group1**, you do not have to enclose the filter in quotation marks. However, if your filter references more than one category such as **/category:"group1&group2"** then the filter has to be enclosed in quotation marks.  
  
###  <a name="test"></a> /test  
 **/test:[** *test name* **]**  
  
 Use the **/test** option to specify individual tests to run. To run multiple tests, use the **/test** option multiple times.  
  
> [!NOTE]
>  You can use the **/test** option with either the **/testcontainer** option or with the **/testmetadata** option, but not with both.  
  
 You can use the **/testlist** option and the **/test** option together. This is equivalent to selecting both a test list and one or more individual tests in the Test List Editor window and then choosing **Run Tests**.  
  
 The string that you specify with the **/test** option is a used to match the names of tests in either a test container or a test metadata file. This means that you can specify multiple tests by using a single value for **/test**. For example, specifying **/test:ittest** would produce matches for tests named DebitTest and CreditTest because both test names contain the substring 'ittest'.  
  
> [!NOTE]
>  The value that you specify with the **/test** option is tested against not only the name of the test, but also the path of that test, as seen in Solution Explorer, or, with unit tests, to their fully qualified name.  
  
 Two usage examples follow:  
  
 **Unit-test example**: The file UnitTest1.cs in the project TestProject2 contains a unit test named TestMethod1. Specifying a value of 'ittest' for the /test option would also match this test, because the string is tested against the fully qualified name "TestProject2.UnitTest1.TestMethod1" and the string 'ittest' also appears in 'UnitTest1'.  
  
 **Generic-test example**: The following command line runs the specified generic test and, in the test results, displays the full path of the test.  
  
 **mstest /testcontainer:"C:\Documents and Settings\\<user name\>\My Documents\Visual Studio\Projects\TestProject2\TestProject2\generictest1.generic" /test:testproject32\generic**  
  
###  <a name="noisolation"></a> /noisolation  
 **/noisolation**  
  
 Use this option to run tests within the MSTest.exe process. Using this option causes no other changes to the test run configuration. The purpose of this option is to improve test run speed. However, it increases the risk to the test run as a whole because an unhandled exception thrown by the test code would cause the MSTest.exe process to crash.  
  
###  <a name="testsettings"></a> /testsettings  
 **/testsettings:[** *file name* **]**  
  
 Use this option to specify a test settings file. For example: **/testsettings:local.Testsettings**  
  
 You can specify a test settings file in other ways, such as with the /testmetadata option. The rules that govern the specification of test settings files are described here.  
  
-   If you use the **/testsettings** option, the file that it specifies will be used, whether you also use the **/testmetadata** option.  
  
-   If you use the **/testmetadata** option to point to a metadata file that specifies the active test settings file, that test settings file will be used if you do not use the **/testsettings** option.  
  
-   If you do not use the **/testsettings** option and you also do not specify a test settings file in the test metadata file, the test run uses the default test settings file.  
  
    > [!NOTE]
    >  For more information about test settings files, see [Create Test Settings for Automated System Tests Using Microsoft Test Manager](../test_notintoc/create-test-settings-for-automated-system-tests-using-microsoft-test-manager.md).  
  
###  <a name="runconfig"></a> /runconfig  
 **/runconfig:[** *file name* **]**  
  
 **Note** This command-line option is maintained for compatibility with previous versions of Visual Studio. Test run configurations have been replaced by test settings in Visual Studio Premium.  
  
 Use this option to specify a run configuration file. For example: **/runconfig:localtestrun.Testrunconfig**  
  
 You can specify a run configuration file in other ways, such as with the /testmetadata option. The rules that govern the specification of run configuration files are described here.  
  
-   If you use the **/runconfig** option, the file that it specifies will be used, whether or not you also use the **/testmetadata** option.  
  
-   If you use the **/testmetadata** option to point to a metadata file that specifies the active run configuration file, that run configuration file will be used if you do not use the **/runconfig** option.  
  
-   If you do not use the **/runconfig** option and you also do not specify a run configuration file in the test metadata file, the test run uses the default run configuration file.  
  
###  <a name="resultsfile"></a> /resultsfile  
 **/resultsfile:[** *file name* **]**  
  
 Use this option to save the test run results to the named file. For example: /resultsfile:testResults.trx.  
  
###  <a name="usestderr"></a> /usestderr  
 **/usestderr**  
  
 Using this option will cause the following information to be written to standard     error:  
  
-   Tests with a result of Failed, Aborted, Error, Timed out, Not Runnable, or Not Executed.  
  
-   Run level errors.  
  
-   Errors in parsing the command line arguments.  
  
-   Run summary when the test run has a failing result.  
  
 Without this option all output is sent to standard output.  
  
###  <a name="detail"></a> /detail  
 **/detail:[** *property id* **]**  
  
 This option is used to display additional test case properties, if they exist. You can pass more than one instance of the **/detail** option, each with only one property ID, in single command line. Valid property id's for the **/detail** option follow:  
  
||||  
|-|-|-|  
|adapter|id|projectrelativepath|  
|computername|isautomated|readonly|  
|debugtrace|link|spoolmessage|  
|description|longtext|stderr|  
|displaytext|name|stdout|  
|duration|outcometext|storage|  
|errormessage|owner|testcategoryid|  
|errorstacktrace|parentexecid|testname|  
|executionid|priority|testtype|  
|groups|projectname|traceinfo|  
  
> [!NOTE]
>  The actual selection of property IDs that you can use with the /detail option varies according to test type. Therefore, this list is only an approximation. In particular, if you are using custom test types, the selection of properties will be different. To know which propertyIDs you can use, examine the test results file produced by the test run. For more information about test results files, see [How to: Save and Open Web Performance and Load Test Results in Visual Studio](../test/how-to--save-and-open-web-performance-and-load-test-results-in-visual-studio.md).  
  
 If a property exists for specified test case, its information is included in the output result summary.  
  
 For example, the command line:  
  
 **mstest /testcontainer:Errors.dll /detail:testtype**  
  
 produces the following output, that contains test type information:  
  
```  
  
...  
Results                    Top Level Tests  
--------                   -----------------  
Inconclusive               TestProject2.BankAccountTest.CreditTest  
[testtype] = Unit Test  
...  
  
```  
  
## See Also  
 [Reviewing Test Results in Microsoft Test Manager](assetId:///9fb3e429-78df-4fe2-89ed-0ad1db0738f4)   
 [Running automated tests from the command line](../test/running-automated-tests-from-the-command-line.md)