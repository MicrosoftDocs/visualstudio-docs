---
title: "Modifying Load Test Logging Settings"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9649226a-857d-41ef-8ec7-047b6e498033
caps.latest.revision: 25
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
# Modifying Load Test Logging Settings
The load test result for the completed load test contains performance counter samples and error information that was collected in a log periodically from the computers-under-test. A large number of performance counter samples can be collected over the course of a load test run. The amount of performance data that is collected depends on the length of the run, the sampling interval, the number of computers under test, and the number of counters to collect. For a large load test, the amount of performance data that is collected can easily be several gigabytes; therefore, you might consider modifying how often data is saved to the log. See [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../dv_TeamTestALM/Distributing-Load-Test-Runs-Across-Multiple-Test-Machines-Using-Test-Controllers-and-Test-Agents.md).  
  
 The *test controller* spools all collected load test sample data to a database log while the test is running. Additional data, such as timing details and error details, is loaded into the database when the test completes.  
  
> [!NOTE]
>  For a complete list of the run settings properties and their descriptions, see [Load Test Run Settings Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
|Task|Associated topics|  
|----------|-----------------------|  
|**Specify how frequently to save logs during a load test run:** You can specify how frequently you want the test log saved when your load test is run.|-   [How to: Specify How Frequently Test Logs are Saved](../dv_TeamTestALM/How-to--Specify-How-Frequently-Test-Logs-are-Saved-Using-the-Load-Test-Editor.md)|  
|**Save logs if a load test fails:** You can specify if you want to save the test log whenever a load test fails.|-   [How to: Specify if Test Failures are Saved to Test Logs](../dv_TeamTestALM/How-to--Specify-if-Test-Failures-are-Saved-to-Test-Logs-Using-the-Load-Test-Editor.md)|  
|**Set the maximum file size for the log file:** You can edit the XML configuration file that is associated with the test controller service to specify the maximum file size you want to use for the log file.|[How to: Specify the Maximum Size for the Log File](../dv_TeamTestALM/How-to--Specify-the-Maximum-Size-for-the-Log-File.md)|  
  
## Related Tasks  
 A related property is **Timing Details** Storage. For more information, see [How to: Configure Collecting Full Details to Enable the Virtual User Activity Chart](../dv_TeamTestALM/How-to--Configure-Load-Tests-to-Collect-Full-Details-to-Enable-Virtual-User-Activity-in-Test-Results.md).  
  
## See Also  
 [Configuring Load Test Run Settings](../dv_TeamTestALM/Configuring-Load-Test-Run-Settings.md)   
 [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4)   
 [Load Test Analyzer Overview](../dv_TeamTestALM/Load-Test-Analyzer-Overview.md)