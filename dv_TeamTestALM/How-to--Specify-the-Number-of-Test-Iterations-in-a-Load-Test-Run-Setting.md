---
title: "How to: Specify the Number of Test Iterations in a Load Test Run Setting"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 45a625db-b3e7-4d64-beda-b9a76248096d
caps.latest.revision: 22
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
# How to: Specify the Number of Test Iterations in a Load Test Run Setting
After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals. For more information, see [Creating load tests](../Topic/Creating%20load%20tests.md).  
  
 Using the **Load Test Editor**, you can edit the **Test Iterations** property of a run settings value in the Properties window. The **Test Iterations** property specifies the number of iterations to run on all the Web performance and unit tests in all the scenarios in a load test using the **Load Test Editor**.  
  
> [!NOTE]
>  For a complete list of the run settings properties and their descriptions, see [Load Test Run Settings Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To specify the number of test iterations in a run setting  
  
1.  Open a load test.  
  
     The **Load Test Editor** appears and displays the load test tree.  
  
2.  In the load test tree, in the **Run Settings** folder, choose a run setting.  
  
3.  On the **View** menu, select **Properties Window** to view the load run setting's categories and properties.  
  
4.  Set the **Use Test Iterations** property to **True**.  
  
5.  In the **Test Iterations** property, enter a number that indicates the number of test iterations to run during the load test.  
  
6.  After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Test Iterations** value.  
  
## See Also  
 [Configuring Load Test Run Settings](../dv_TeamTestALM/Configuring-Load-Test-Run-Settings.md)   
 [Step 4 - Specifying Run Settings in the New Load Test Wizard](../Topic/Creating%20load%20tests.md#CreatingLoadTestsUsingWizardStep4)   
 [Load Test Scenario Properties](../dv_TeamTestALM/Load-Test-Scenario-Properties.md)