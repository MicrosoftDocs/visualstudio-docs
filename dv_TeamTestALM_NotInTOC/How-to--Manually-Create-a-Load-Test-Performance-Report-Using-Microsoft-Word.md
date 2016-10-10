---
title: "How to: Manually Create a Load Test Performance Report Using Microsoft Word"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3b864c75-2699-48c1-a2b4-9651f108c267
caps.latest.revision: 16
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
# How to: Manually Create a Load Test Performance Report Using Microsoft Word
You can manually create Microsoft Word load test reports by copying and pasting data from the Load Test Results summary view and graphs view. The data that is presented in the summary view and graphs view is applied in HTML format when it is copied.  
  
> [!TIP]
>  You can also copy plain text from the tables view and screenshots from the details view to Microsoft Word, but it is not applied in HTML format and will require additional formatting and editing.  
  
> [!TIP]
>  You can also generate organized Microsoft Excel reports automatically. For more information, see[How to: Create Load Test Performance Reports Using Microsoft Excel](../dv_TeamTestALM/How-to--Create-Load-Test-Performance-Reports-Using-Microsoft-Excel.md).  
  
 Before you copy and paste data from the Load Test Results by using the following procedures, you must first run your load test to collect the desired data:  
  
1.  Run a load test until it is completed. For more information, see [How to: Run a Load Test](../Topic/How%20to:%20Run%20a%20Load%20Test.md).  
  
     \- or -  
  
2.  View the details of a previously run load test. For more information, see [How to: Access Load Test Results for Analysis](../dv_TeamTestALM/How-to--Access-Load-Test-Results-for-Analysis.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### copying summary view data  
  
1.  In the Load Test Results, if the summary view is not currently displayed, click **Summary** in the toolbar.  
  
2.  In the summary view, right-click and select **Select All**.  
  
3.  In the summary view, right-click and select **Copy**. This renders the summary view data as HTML format to the clipboard.  
  
4.  In Microsoft Word, paste the summary view data in the desired location.  
  
    > [!TIP]
    >  If you are using Microsoft Word 2010, you can preview the paste action by right-clicking the mouse in the location where you want to paste the summary view data and pausing the pointer over the **Keep Source Formatting** option under **Paste Options**.  
  
5.  You can now modify, format, and delete aspects of the copied content to meet your reporting needs.  
  
### Copying graph view data  
  
1.  In the Load Test Results, if the graphs view is not currently displayed, choose **Graphs** in the toolbar.  
  
2.  (Optional) Zoom in on the specific graph that you want to copy to your Microsoft Word document, as shown in the following illustration. For more information, see[How to: Zoom in on a Region of the Graph](../dv_TeamTestALM/How-to--Zoom-in-on-a-Region-of-the-Graph-in-Load-Test-Results.md).  
  
     ![Graph view zoom control](../dv_TeamTestALM/media/LTest_ZoomControl.png "LTest_ZoomControl")  
Graph using zoom control  
  
3.  On the graph that you want to copy to your Microsoft Word document, right-click and select **Copy**.  
  
4.  In Microsoft Word, paste the graph and associated table data in the desired location.  
  
    > [!TIP]
    >  If you are using Microsoft Word 2010, you can preview the paste action by right-clicking the mouse in the location where you want to paste the graph and associated table data and pausing the pointer over the **Keep Source Formatting** option under **Paste Options**.  
  
    > [!WARNING]
    >  You cannot copy the graph from a remote desktop and paste it to another machine, because only the table information that is associated with the graph will be copied and not the graph image. The graph image is stored in the temporary directory on the machine from which it was copied, and the second machine cannot dereference that directory.  
  
## See Also  
 [Reporting Load Tests Results for Test Comparisons or Trend Analysis](../dv_TeamTestALM/Reporting-Load-Tests-Results-for-Test-Comparisons-or-Trend-Analysis.md)   
 [How to: Create Load Test Performance Reports Using Microsoft Excel](../dv_TeamTestALM/How-to--Create-Load-Test-Performance-Reports-Using-Microsoft-Excel.md)   
 [Load Test Analyzer Overview](../dv_TeamTestALM/Load-Test-Analyzer-Overview.md)