---
title: "Comparing load test results in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, reporting"
  - "load tests, results"
ms.assetid: 31874114-459a-45d5-9f8b-2ea503627db8
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# Reporting Load Tests Results for Test Comparisons or Trend Analysis

You can generate Microsoft Excel load test reports that are based on two or more test results. Two types of load test reports are available:

- Run comparison&mdash;This report is actually two reports that display side by side comparison data using tables and bar charts.

- Trend&mdash;You can generate trend analysis on two or more reports. The results are displayed using line charts.

Either report can be used to share performance data with stakeholders and convey whether the overall performance and health of the system is getting better or worse.

Report definitions are stored in the load test database. When a report is saved, the definition for the report is saved in the database and can be re-used later.

Also, the spreadsheet file can be shared with stakeholders so that stakeholders do not have to connect to the database to see the report.

> [!NOTE]
> If you add comments to a load test, they will appear in the Excel report. For more information, see [How to: Add Comments while Analyzing a Completed Load Test](../test/how-to-add-comments-on-a-completed-load-test.md).

## Tasks

|Tasks|Associated topics|
|-----------|-----------------------|
|**Create a performance and stress report:** You can create reports on your load and Web performance tests, using Microsoft Excel.|- [How to: Create Load Test Performance Reports Using Microsoft Excel](../test/how-to-create-load-test-performance-reports-using-microsoft-excel.md)|
|**Manually create a performance and stress report by using Microsoft Word:** You can create reports on your load and Web performance tests manually by copying and pasting summary, table, and graph data to a Microsoft Word document.|- [How to: Manually Create a Load Test Performance Report Using Microsoft Word](../test/how-to-manually-create-a-load-test-performance-report-using-microsoft-word.md)|

## See also

- [Analyze Load Test Results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)