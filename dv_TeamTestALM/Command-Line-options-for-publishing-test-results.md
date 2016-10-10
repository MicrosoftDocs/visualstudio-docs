---
title: "Command-Line options for publishing test results"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 39c5e62b-bfe6-4ec5-9991-e654d0a4796e
caps.latest.revision: 28
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
# Command-Line options for publishing test results
The following options are used to publish test results when you are using the MSTest.exe command-line utility.  
  
## Prerequisites  
 Visual Studio Enterprise  
  
 The database for the team project collection resides on a Team Foundation Server computer. This means that you can publish test data only if you have Team Explorer installed and your Visual Studio user session is connected to a Team Foundation Server computer. For information about how to connect to Team Foundation Server, see [Connect to team projects](../Topic/Connect%20to%20team%20projects%20in%20Team%20Foundation%20Server.md).  
  
## Options Required for Publishing Test Results  
 When you publish test results from the command line, you can either publish the results of a previously completed test run, or you can run tests and publish the new results that the run produces.  
  
 The following options are required for publishing test results: [/publish](#publish), [/publishbuild](#publishbuild), [/platform](#platform), [/flavor](#flavor), and [/teamproject](#teamproject). Use this option only to publish the results of a previous test run: [/publishresultsfile](#publishresultsfile).  
  
> [!NOTE]
>  For information about the MSTest.exe command-line options not specifically used for publishing test results, see [MSTest.exe command-line options](../dv_TeamTestALM/MSTest.exe-command-line-options.md).  
  
##  <a name="publish"></a> /publish  
 **/publish:[** *server name*]  
  
 Use the **/publish** option to publish test data to the database for the team project collection associated with the project's Team Foundation Server.  
  
 When you use the **/publish** option, you must correctly specify the name of the Team Foundation Server. The correct format depends on whether the Team Foundation Server has been registered on the client computer, as described here:  
  
-   If the Team Foundation Server is not registered on the client computer, use the URI that identifies the Team Foundation Server. For example, **/publish:http://OurTFSMachine:8080/tfs/OurProjectCollection**.  
  
-   If the Team Foundation Server computer is registered, you can use a shortened form, namely: **/publish:OurTFSMachine**.  
  
##  <a name="publishbuild"></a> /publishbuild  
 **/publishbuild:[** *build name* **]**  
  
 To publish test data, you must specify the name of a build that has completed. To find the name of a build, follow these steps:  
  
1.  Open Visual Studio and connect to a Team Foundation Server. For more information, see [Connect to team projects](../Topic/Connect%20to%20team%20projects%20in%20Team%20Foundation%20Server.md).  
  
2.  Open Team Explorer.  
  
3.  Open your team project and expand the team project node.  
  
4.  Under the build, double-click **All Build Types** or a specific build type to see its builds.  
  
     Build names that you can use are in the **Name** column.  
  
    > [!NOTE]
    >  You can find information about the /platform and the /flavor by double-clicking the build name.  
  
##  <a name="flavor"></a> /flavor  
 **/flavor:[** *flavor* **]**  
  
 This option, input as a string, is mandatory for publishing test results. The values of **/flavor** and **/platform** must match a valid combination of values for the completed build identified by the **/publishbuild** option. When you run the MSTest utility with the options for publishing, it first finishes running tests and then it sets the flavor and platform properties of the test run before publishing the test run results.  
  
 Examples of using **/flavor**: **/flavor:debug**, **/flavor:retail**  
  
##  <a name="platform"></a> /platform  
 **/platform:[** *platform* **]**  
  
 This option, input as a string, is mandatory for publishing test results. The values of **/flavor** and **/platform** must match a valid combination of values for the completed build identified by the **/publishbuild** option. When you run the MSTest utility with the options for publishing, it first finishes running tests and then it sets the flavor and platform properties of the test run before publishing the test run results.  
  
 Examples of using **/platform**: **/platform:AnyCPU**, **/platform:x86**  
  
##  <a name="publishresultsfile"></a> /publishresultsfile  
 **/publishresultsfile:[** *file name* **]**  
  
 The name of the results file to be published. This file has the .trx extension. To publish the results of the current run using the default name, omit this option.  
  
##  <a name="teamproject"></a> /teamproject  
 **/teamproject:[** *team project name* **]**  
  
 Specify the name of the team project to which the build belongs.  
  
## See Also  
 [Running automated tests from the command line](../dv_TeamTestALM/Running-automated-tests-from-the-command-line.md)   
 [MSTest.exe command-line options](../dv_TeamTestALM/MSTest.exe-command-line-options.md)   
 [Run automated tests from the command line using MSTest](../dv_TeamTestALM/Run-automated-tests-from-the-command-line-using-MSTest.md)