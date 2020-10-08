---
title: "Saving and Exporting Performance Tools Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "performance tools, saving and exporting reports"
ms.assetid: 2e9b28fe-3ed2-4e1d-b9cb-0a5e384380b0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Save and export performance tools data
This article describes how to save and export performance data files.

## How to: Save performance data files as analyzed report files
 You can save filtered or unfiltered views of profiling data (.*vsp*) files as analyzed report (.*vsps*) files. An analyzed report file can be viewed in the Report view window and is significantly smaller than the original .*vsp* file. However, you cannot apply a filter to the data of a .*vsps* file. You can create an analyzed report file from the Performance Explorer without opening the file in the integrated development environment (IDE), or you can open and filter the .*vsp* file and then save the results.

#### To save an analyzed performance report from the Performance Explorer

1. Under **Reports**, right-click the profiling data file that you want to analyze and then click **Save Analyzed**.

2. In the **Save Analyzed Data** dialog box, specify the directory and then type the file name.

3. Click **Save.**

#### To save an analyzed performance report from the Report view window

1. Open the profiling data (.*vsp*) file in the Report view window.

2. (Optional) Apply a filter to the data. For more information, see [Performance report view filter](../profiling/performance-report-view-filter.md).

3. Click **Save Analyzed** on the Report view window toolbar.

4. In the **Save Analyzed Data** dialog box, specify the directory and then type the file name.

5. Click **Save.**

## How to: Export profiling tools reports to an .xml or .csv file
 You can export one or more report views from a .*vsp* file or a .*vsps* profiling data file as either a comma delimited or an XML file. You can filter the data in the Report view window before you export, or you can export report views of the entire data file from the **Performance Explorer** window.

> [!NOTE]
> You can also copy and paste selected rows from the Report view window as tab separated values.

#### To export performance reports from the Performance Explorer window

1. In **Performance Explorer**, select the report and then right-click and select **Export**.

     The **Export Report** dialog box appears.

2. Select the report views you want to export.

3. Under **Prefix report with**, specify the prefix you want to add to the report name.

4. Under **Exported report location**, specify the directory.

5. Under **Exported report format**, select (Comma delimited) (\*.csv\), or XML Data (\*.xml\).

6. Click **Export**.

     Each report view is saved to a separate file that is named \<prefix>_\<report view name>.\<csv&#124;xml>

#### To export performance reports from the Report view window

1. Open the .*vsp* file in the Report view window.

2. (Optional) Apply a filter to the data. For more information, see [Performance report view filter](../profiling/performance-report-view-filter.md).

3. Click **Export Report** on the Report view window toolbar.

4. Select the report views you want to export.

5. Under **Prefix report with**, specify the prefix you want to add to the report name.

6. Under **Exported report location**, specify the directory.

7. Under **Exported report format**, select (Comma delimited) (\*.csv), or XML Data (\*.xml).

8. Click **Export**.

     Each report view is saved to a separate file that is named \<prefix>_\<report view name>.\<csv&#124;xml>

## See also
- [Performance Explorer](../profiling/performance-explorer.md)
- [Analyze performance tools data](../profiling/analyzing-performance-tools-data.md)
- [Compare performance data files](../profiling/comparing-performance-data-files.md)
- [VSPerfReport](../profiling/vsperfreport.md)
