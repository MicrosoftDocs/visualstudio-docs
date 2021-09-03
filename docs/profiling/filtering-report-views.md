---
title: "Filtering Report Views | Microsoft Docs"
description: In Visual Studio, apply filters to profiling data files to limit the profiling data that's displayed in the Performance Report views and exported to report files.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling tools, configuring"
ms.assetid: 820cf192-7fd6-4bee-9a51-aa69154aca85
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Filter report views
You can apply filters to profiling data files to limit the profiling data that is displayed in the Performance Report views and exported to report files. You can limit a report to the data between time stamp values, and you can limit the data to specific processes and threads. You can save filters to a file and then create a filter on a different profiling data file by importing the saved filter.

 You can also limit a report to a time segment by using the graphical timeline on the Summary View. See [How to: Filter Report Views from the Summary Timeline](../profiling/how-to-filter-report-views-from-the-summary-timeline.md).

 To exclude system and third-party code from a report, see [How to: Filter Profiling Tools Report Views to Display Just My Code](../profiling/how-to-filter-profiling-tools-report-views-to-display-just-my-code.md)

## Procedures

#### To create a profiler report filter

1. If the Performance Report View Filter window is not displayed, click **Show Filter** on the Performance Report View toolbar.

     The Performance Report View Filter is a table. Each row of the table represents a clause of the filter. You can add as many clauses as you want to a filter.

2. For each clause that you want to add to a filter, select or enter values in the following fields of a row.

    |Field|Description|
    |-----------|-----------------|
    |**And/Or**|Choose **And** if this clause and the next clause must both be true to match a result. Choose **Or** if either this clause or the next clause can be true to match a result.|
    |**Field**|Select the report field to use in the filter clause from the displayed list of data fields.|
    |**Operator**|Select the operator that specifies the relationship that you want in the clause between the field and value.<br /><br /> =    Equals<br /><br /> <>  Not Equals<br /><br /> <    Less Than<br /><br /> >    Greater Than<br /><br /> <=  Less Than or Equals<br /><br /> >=  Greater Than or Equals|
    |**Value**|Select or enter the value to look for. Some fields list the available values for the field.|

#### To create a profiler report filter from the Marks Report view

1. Select **Marks** from the **Current View** list on the Performance Report View toolbar.

    The Marks profiler report is displayed.

2. Select the ETW or sampling even that you want to use as the starting point of the report.

3. Press and hold CTRL and click the event that you want to use as the ending point of the report.

4. Right-click and then click one of the following options:

   - **Add Filter on Marks** creates filter clauses that use the Mark column as the filter field.

   - **Add Filter on Timestamps** creates filter clauses that use the Timestamp In Milliseconds column as the filter field.

     The two options filter the current data file at the same start and end points. Either option might be better if you export the filter to use in other reports.

#### To load an existing filter from a file

1. On the Performance Report View toolbar, click **Import Filter**.

     The **Load Filter** dialog box is displayed.

2. Specify the location and file name of the filter (.vspf) file to load.

#### To execute a filter

- On the Performance Report View toolbar, click **Execute Filter**.

#### To stop a filter that is taking too long to execute

- On the Performance Report View toolbar, click **Stop Filter**.

#### To remove a filter on a report view

1. Delete the rows of clauses in the Performance Report View Filter.

2. On the Performance Report View toolbar, click **Execute Filter**.

#### To save a filter to a file

1. On the Performance Report View toolbar, click **Export Filter**.

     The **Save Filter** dialog box is displayed.

2. Specify the location and file name of the filter (.vspf) file to save.

## See also
- [Customizing Performance Tools Report Views](../profiling/customizing-performance-tools-report-views.md)
