---
title: "How to: Compare Performance Data Files | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vsperf.choosediffbinaries"
helpviewer_keywords: 
  - "profiling tools, how to compare profiler result files"
  - "profiler result files, how to compare"
ms.assetid: 1905b45d-c6b3-43c8-87b1-1aee734f37f9
caps.latest.revision: 25
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Compare Performance Data Files
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can compare the results of two different profiler data files (.vsp or .vsps) by creating a comparison ("Diff") report or view. The comparison shows the differences, performance regressions, and improvements that occurred from one profiling session to the other.  
  
 The Diff report presents a table view of the data. The table presents the delta, or change from the baseline. This is calculated by determining the difference between the old value, the baseline value, and the result value from the new analysis.  
  
 Comparisons of profiler data can be based on the functions in the code, modules in the application, lines, instruction pointers (IPs), and types.  
  
 A threshold can be set to reduce noise and filter out any data in the table view of the rows that have not changed by a specified amount.  
  
### To create comparison file view for a project in Performance Explorer  
  
1. In **Performance Explorer**, under **Reports**, select the .vsp or .vsps report file that you want to use as the baseline values for comparison.  
  
2. Select the .vsp or .vsps report files that you want to compare.  
  
3. Right-click one of the selected files and then click **Compare Reports**.  
  
### To compare values  
  
1. Select **Comparison Report** tab in the Report View window.  
  
2. In the **Table** drop-down list, select either function or modules to compare.  
  
3. In the **Column** drop-down list, select the value that you want to compare.  
  
4. (optional) Type a value for **Threshold**.  
  
5. Click **Apply**.  
  
### To compare report files  
  
1. On the **Analyze** menu, select **Compare Performance Reports**.  
  
2. In the **Select analysis files for comparison** window, browse and select the **Baseline File** analysis file (.vsp or .vsps) and the **Comparison File** (.vsp or .vsps).  
  
3. Click **OK**.
